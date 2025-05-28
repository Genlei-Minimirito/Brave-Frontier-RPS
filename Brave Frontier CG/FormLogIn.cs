using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Brave_Frontier_CG
{
    public partial class FormLogIn : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader mdr;
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
                return;
            }

            var connString =
              "Server=localhost;Port=3306;Database=brave_frontier;Uid=root;Pwd=;";
            using (var connection = new MySqlConnection(connString))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT UserName " +
                    "  FROM userinfo " +
                    " WHERE UserName = @u " +
                    "   AND Password = @p;";
                cmd.Parameters.AddWithValue("@u", txtName.Text);
                cmd.Parameters.AddWithValue("@p", txtPword.Text);

                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        // no rows → bad credentials
                        MessageBox.Show("Invalid username or password.", "Error");
                        return;
                    }

                    // We did read a row—let’s grab it two ways:
                    string byName = reader.GetString("UserName");
                    string byIndex = reader.GetString(0);
                    string raw = reader["UserName"]?.ToString() ?? "(null)";

                    // Debug what we actually got:
                    MessageBox.Show(
                        "debug:\n" +
                        $"GetString(\"UserName\"): '{byName}'\n" +
                        $"GetString(0):          '{byIndex}'\n" +
                        $"reader[\"UserName\"]: '{raw}'",
                        "Login debug");

                    // Now set the session
                    Session.UserName = raw;
                    Session.UserName = reader.GetString(0);

                    // Show your main menu
                    this.Hide();
                    using (var main = new FormMainMenu())
                        main.ShowDialog();

                }
            }
        }

        private void picSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp formSign= new FormSignUp();
            formSign.StartPosition = FormStartPosition.Manual;
            formSign.Location = this.Location;
            formSign.ShowDialog();
        }
    }
}

