using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void OpenLogin()
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = 0;
            LoginInfo.Username = null;
            MessageBox.Show("Uspešno odjavljivanje!");
            this.OpenLogin();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var db = new Database.PasswordsManagement();
            int ID = LoginInfo.UserID;

            dataGridView1.DataSource = db.GetPasswordsByUser(ID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new Database.PasswordsManagement();
            string search = textBox1.Text;
            int ID = LoginInfo.UserID;

            dataGridView1.DataSource = db.SearchPasswords(ID, search);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        // Copy button
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var PG = new Database.PasswordsManagement();
            PasswordSizeLabel.Text = $"Dužina lozinke: {trackBar1.Value.ToString()}";
            PasswordLabel.Text = PG.PasswordGenerator(trackBar1.Value);
        }

        // Submit button
        private void button4_Click(object sender, EventArgs e)
        {
            var db = new Database.PasswordsManagement();
            string creds = textBox3.Text;
            string website = textBox2.Text;
            string password = PasswordLabel.Text;
            int ID = LoginInfo.UserID;

            db.AddNewPassword(creds, website, password, ID);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                var db = new Database.PasswordsManagement();
                int ID = LoginInfo.UserID;

                dataGridView1.DataSource = db.GetPasswordsByUser(ID);
            }
            if (e.TabPage == tabPage3)
            {
                var PG = new Database.PasswordsManagement();
                PasswordLabel.Text = PG.PasswordGenerator(trackBar1.Value);
            }
        }

        // Delete button
        private void button6_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Niste izabrali ništa za brisanje!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sigurno želite da obrišete ovo?", "Upozorenje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var db = new Database.PasswordsManagement();

                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    // gets the RowID from the first column in the grid
                    int rowID = (int)dataGridView1.Rows[selectedIndex].Cells[0].Value;

                    db.DeletePassword(rowID);

                    // Remove the row from the grid
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }

            }
        }

        // Copy selected
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index == -1)
                {
                    MessageBox.Show("Niste izabrali ništa za kopiranje!");
                }
                else
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string password = dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString()!;

                    Clipboard.SetText(password);
                    MessageBox.Show("Uspešno ste kopirali lozinku!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
