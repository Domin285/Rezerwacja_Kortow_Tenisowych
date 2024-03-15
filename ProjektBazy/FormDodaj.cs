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
using System.Globalization;

namespace ProjektBazy
{
    public partial class FormDodaj : Form
    {
        private string name;
        public FormDodaj(string usrname)
        {
            this.name = usrname;
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");
        SqlCommand sda = new SqlCommand();
        SqlCommand czy = new SqlCommand();

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string[] akceptowalneFormaty = { "yyyy-MM-dd", "yyyy-M-dd", "yyyy-MM-d", "yyyy-M-d" };

            DateTime dataRezerwacji;
            if (!DateTime.TryParseExact(text_data.Text, akceptowalneFormaty, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataRezerwacji))
            {
                MessageBox.Show("Nieprawidłowy format daty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime aktualnaData = DateTime.Now.Date;

            if (dataRezerwacji <= aktualnaData)
            {
                MessageBox.Show("Nie możesz zarezerwować terminu na dzisiejszą lub wcześniejszą datę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isReservationExists = false;

            conn.Open();
            string czyIstnieje = "SELECT COUNT(*) FROM EventAdd WHERE Data = '" + text_data.Text + "' AND Godzina = '" + text_select.Text + "'";
            czy = new SqlCommand(czyIstnieje, conn);
            czy.ExecuteNonQuery();

            int count = Convert.ToInt32(czy.ExecuteScalar());

            if (count > 0)
            {
                isReservationExists = true;
            }
            conn.Close();
   
            if (isReservationExists)
            {
                MessageBox.Show("Wybrany termin jest już zajęty", "Przejrzyj zajęte terminy i spróbuj ponownie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string nowy = "INSERT INTO EventAdd VALUES ('" + text_data.Text + "','" + text_event.Text + "','" + text_select.Text + "','" + name + "')";
                sda = new SqlCommand(nowy, conn);
                sda.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Twoja rezerwacja przebiegła pomyśle", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDodaj_Load(object sender, EventArgs e)
        {
            text_data.Text = Kalendarz.static_year+"-"+ Kalendarz.static_month+"-"+UserControlDays.static_day;
            text_data.Enabled=false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
