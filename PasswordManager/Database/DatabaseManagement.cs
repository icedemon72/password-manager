using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace PasswordManager.Database
{
    internal class DatabaseManagement
    {
        protected string QuickHash(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }

        protected string getConnectionString()
        {
            var builder = new SqlConnectionStringBuilder("Data Source=;Initial Catalog=PasswordManager;Integrated Security=True;Pooling=False");

            return builder.ConnectionString;
        }
    }
}
