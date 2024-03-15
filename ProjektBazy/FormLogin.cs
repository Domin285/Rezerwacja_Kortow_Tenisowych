using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using ProjektBazy.Models;
using System.Xml.Schema;

namespace ProjektBazy
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String username, user_password;

            username = text_username.Text;
            user_password = text_password.Text;

            try
            {
                string login = "SELECT * FROM LoginPage WHERE Login = '" + text_username.Text + "' AND Haslo = '" + text_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(login, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = text_username.Text;
                    user_password = text_password.Text;

                    new FormMenu(text_username.Text).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa nazwa użytkownika lub hasło, spróbuj ponownie", "Logowanie nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    text_username.Clear();
                    text_password.Clear();
                    text_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_username.Clear();
            text_password.Clear();
            text_username.Focus();
        }

        private void checkBox_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_password.Checked)
            {
                text_password.PasswordChar = '\0';
            }
            else
            {
                text_password.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new register_form().Show();
            this.Hide();
        }

        private void button_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
