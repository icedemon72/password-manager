using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Database
{
    internal class UsersManagement : DatabaseManagement
    {
        public bool Register(string username, string password)
        {
            bool success = false;
            var connection = new SqlConnection(getConnectionString());

            string hashedPassword = QuickHash(password);

            var checkIfExists = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @username", connection);

            var cmd = new SqlCommand(@"
                INSERT INTO users (username,password) VALUES
                (@username, @password)
            ", connection);

            try
            {
                connection.Open();
                checkIfExists.Parameters.AddWithValue("@username", username);
                
                Int32 count = (Int32) checkIfExists.ExecuteScalar();
                
                if (count > 0)
                {
                    throw new Exception("Već postoji korisnik sa ovim korisničkim imenom!");
                }

                cmd.Parameters.AddWithValue("@username", username.ToLower());
                cmd.Parameters.AddWithValue("@password", hashedPassword);
               
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
    
        public bool Login(string username, string password)
        {
            bool success = false;

            var connection = new SqlConnection(getConnectionString());
            string hashedPassword = QuickHash(password);

            var cmd = new SqlCommand("SELECT id FROM users WHERE username = @username AND password = @password", connection);

            try
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                connection.Open();
                var dr = cmd.ExecuteReader();

                if(!dr.Read())
                {
                    throw new Exception("Pogrešno korisničko ime i/ili lozinka!");
                }

                int ID = Convert.ToInt32(dr["id"]);

                LoginInfo.UserID = ID;
                LoginInfo.Username = username;

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
