using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using ProjektBazy.Models;
using System.Xml.Linq;

namespace ProjektBazy
{
    public partial class FormZapisane : Form
    {
        private string day;
        private bool CzyAdmin;
        public FormZapisane(string dateday, bool admin)
        {
            InitializeComponent();
            this.day = dateday;
            this.CzyAdmin = admin;
            dataGridView1.AllowUserToAddRows = false;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");

        private void pokazRezerwacje()
        {
            conn.Open();
            string pokaz = "SELECT * FROM EventAdd WHERE Data = '" + Kalendarz.static_year + "-" + Kalendarz.static_month + "-" + day + "' ORDER BY Godzina";
            SqlDataAdapter sda = new SqlDataAdapter(pokaz, conn);

            var komenda = new SqlCommandBuilder(sda);
            DataTable ds = new DataTable();

            sda.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds;

            if(CzyAdmin)
            {
                deleteRowButtonAdd();
            }

            conn.Close();
        }
        private void deleteRowButtonAdd()
        {
            DataGridViewButtonColumn delButton = new DataGridViewButtonColumn();
            delButton.HeaderText = "Usuń";
            delButton.Text = "-";
            delButton.Name = "delButton";
            delButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(delButton);
        }

        private void button_exit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.ClearSelection();
            pokazRezerwacje();
        }

        private void FormZapisane_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            pokazRezerwacje();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string dzien, godzina;

                DateTime dt = Convert.ToDateTime(dataGridView1.Rows[0].Cells["Data"].Value);
                
                dzien = dt.ToString("yyyy-MM-dd");
                godzina = row.Cells[2].Value.ToString();

                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");
                SqlCommand sda = new SqlCommand();

                conn.Open();
                string usun = "DELETE FROM EventAdd WHERE Data = '" + dzien + "' AND Godzina = '" + godzina + "'";

                MessageBox.Show("Rezerwacja została pomyślnie usunięta", "Usunięto rezerwacje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sda = new SqlCommand(usun, conn);
                sda.ExecuteNonQuery();
                conn.Close();

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.ClearSelection();
                pokazRezerwacje();
            }
        }
    }
}
