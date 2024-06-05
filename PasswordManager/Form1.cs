using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();

        }

        private void OpenRegister()
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void HandleLogIn()
        {
            MessageBox.Show("Uspešna prijava!");
            this.Hide();
            var mainForm = new Main();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OpenRegister();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username.Length > 0 && password.Length > 0)
            {
                var db = new Database.UsersManagement();

                bool loggedIn = db.Login(username, password);

                if (loggedIn)
                {
                    this.HandleLogIn();
                }
            }
        }
    }
}