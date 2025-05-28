using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Brave_Frontier_CG
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void picLogIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connString = "Server=localhost;Port=3306;Database=brave_frontier;Uid=root;Pwd=;";
            using (var conn = new MySqlConnection(connString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO userinfo (UserName, Password) VALUES (@u, @p)";
                cmd.Parameters.AddWithValue("@u", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtPword.Text.Trim()); // Consider hashing in real use

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!");

                    this.Close(); // Close sign-up form after success
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Duplicate entry
                        MessageBox.Show("Username already exists. Please choose a different one.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
                this.Hide();
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.StartPosition = FormStartPosition.Manual;
                formLogIn.Location = this.Location;
                formLogIn.ShowDialog();
            }
        }
    }
}
