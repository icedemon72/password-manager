using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordManager.Database
{
    internal class PasswordsManagement : DatabaseManagement
    {
        public DataTable GetPasswordsByUser(int ID)
        {
            var connection = new SqlConnection(getConnectionString());

            var cmd = new SqlCommand(@"
                SELECT * FROM passwords WHERE user_id = @ID
            ", connection);

            cmd.Parameters.AddWithValue("@ID", ID);

            return this.GetDataTable(connection, cmd);
        }

        public DataTable SearchPasswords(int ID, string query)
        {
            var connection = new SqlConnection(getConnectionString());

            var cmd = new SqlCommand(@"
                SELECT * FROM passwords WHERE user_id = @ID
                AND (website LIKE @QUERY OR creds LIKE @QUERY)
            ", connection);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@QUERY", "%" + query + "%");

            return this.GetDataTable(connection, cmd);
        }

        public string PasswordGenerator(int passwordLength)
        {
            Random character = new Random();
            string alphaNumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890";
            string specialCharacters = "~!@#$%&*()_-";

            string generatedPassword = "";

            int numOfSpecials = (int)Math.Floor((double)passwordLength / 5);

            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, alphaNumeric.Length);
                generatedPassword += alphaNumeric[randomNum];
            }

            var SB = new StringBuilder(generatedPassword);

            for (int i = 0; i < numOfSpecials; i++)
            {
                int randomNum = character.Next(0, passwordLength);
                int randomIndex = character.Next(0, specialCharacters.Length);
                SB.Remove(randomNum, 1);
                SB.Insert(randomNum, specialCharacters[randomIndex]);
            }

            return SB.ToString();
        }

        public bool AddNewPassword(string creds, string website, string password, int ID)
        {
            bool success = false;

            var connection = new SqlConnection(getConnectionString());

            var cmd = new SqlCommand("INSERT INTO passwords(creds, website, password, user_id) VALUES (@CREDS, @WEBSITE, @PASSWORD, @ID);",
                connection);

            try
            {
                if(creds.Length == 0 && website.Length == 0)
                {
                    throw new Exception("Mora se uneti ili e-adresa/korisničko ime ili web-stranica!");
                }
                connection.Open();
                cmd.Parameters.AddWithValue("@CREDS", creds);
                cmd.Parameters.AddWithValue("@WEBSITE", website);
                cmd.Parameters.AddWithValue("@PASSWORD", password);
                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspešno dodata lozinka!");
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return success;
        }

        private DataTable GetDataTable(SqlConnection connection, SqlCommand cmd)
        {
            var dataTable = new DataTable();

            try
            {
                connection.Open();
                
                var dr = cmd.ExecuteReader();

                dataTable.Columns.Add("#", typeof(int));
                dataTable.Columns.Add("Web-stranica", typeof(string));
                dataTable.Columns.Add("E-adresa/korisničko ime", typeof(string));
                dataTable.Columns.Add("Lozinka", typeof(string));

                while (dr.Read())
                {
                    dataTable.Rows.Add(new Object[]
                    {
                        dr["id"],
                        dr["website"].ToString().Trim(),
                        dr["creds"].ToString().Trim(),
                        dr["password"].ToString().Trim()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return dataTable;

        }

        public bool DeletePassword(int ID)
        {
            bool success = false;

            var connection = new SqlConnection(getConnectionString());

            var cmd = new SqlCommand(@"DELETE FROM passwords WHERE id = @ID", connection);

            try
            {
                connection.Open();
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return success;
        }
    }
}
