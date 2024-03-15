using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using ProjektBazy.Models;
using System.Windows.Forms;

namespace ProjektBazy
{
    public partial class Menu : UserControl
    {
        private string name;
        public Menu(string usrname)
        {
            InitializeComponent();
            pokazRezerwacje();
            this.name = usrname;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");

        private void pokazRezerwacje()
        {
            conn.Open();
            string login = "SELECT Event, Data, Godzina FROM EventAdd WHERE Kto = '" + name + "' ORDER BY Data, Godzina";
            SqlDataAdapter sda = new SqlDataAdapter(login, conn);

            var komenda = new SqlCommandBuilder(sda);
            DataTable ds = new DataTable();

            sda.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds;
         
            conn.Close();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();

            dataGridView1.ClearSelection();
            pokazRezerwacje();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            pokazRezerwacje();
        }
    }
}
