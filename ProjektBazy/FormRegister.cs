using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using ProjektBazy.Models;
using System.Data.SqlClient;

namespace ProjektBazy
{
    public partial class register_form : Form
    {
        public register_form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");
        SqlCommand sda = new SqlCommand();
        SqlDataAdapter dt = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string checkUsernameQuery = "SELECT COUNT(*) FROM LoginPage WHERE Login = '"+ text_username.Text +"'";
            SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameQuery, conn);
            int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());
            conn.Close();

            if (usernameCount > 0)
            {
                MessageBox.Show("Podany login jest już używany, proszę wybrać inny login", "Rejestracja nieudana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_username.Text = "";
                text_username.Focus();
            }
            else if(text_username.Text == "" && text_password.Text == "" && text_potpassword.Text == "")
            {
                MessageBox.Show("Login oraz hasło użytkownika są puste", "Rejestracja nieudana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(text_password.Text == text_potpassword.Text)
            {
                conn.Open();
                bool CzyAdmin = false;
                string rejestracja = "INSERT INTO LoginPage VALUES ('" + text_username.Text + "','" + text_password.Text + "','" + CzyAdmin + "')";

                sda = new SqlCommand(rejestracja, conn);
                sda.ExecuteNonQuery();
                conn.Close();

                text_username.Text = "";
                text_password.Text = "";
                text_potpassword.Text = "";

                MessageBox.Show("Twoje konto zostało pomyślnie utworzone", "Rejestracja udana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hasła nie pasują do siebie, wprowadź hasło ponownie", "Rejestracja nie udana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_password.Text = "";
                text_potpassword.Text = "";
                text_password.Focus();
            }
        }

        private void checkBox_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_password.Checked) 
            {
                text_password.PasswordChar = '\0';
                text_potpassword.PasswordChar = '\0';
            }
            else
            {
                text_password.PasswordChar = '*';
                text_potpassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_username.Text = "";
            text_password.Text = "";
            text_potpassword.Text = "";
            text_username.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
