using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
    public partial class Kalendarz : UserControl
    {
        int year, month;
        private string name;
        private bool CzyAdmin;
        public static int static_month, static_year;
        public Kalendarz(string usrname)
        {
            InitializeComponent();
            this.name = usrname;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P0CU9U3\SQLEXPRESS;Initial Catalog=BazaProjektNowy;Integrated Security=True");
            SqlCommand sda = new SqlCommand();

            conn.Open();
            string rejestracja = "SELECT CzyAdmin FROM LoginPage WHERE Login = '" + name + "'";


            sda = new SqlCommand(rejestracja, conn);


            using (SqlDataReader reader = sda.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader[0].ToString() == "True")
                    {
                        CzyAdmin = true;
                    }
                }
            }
            conn.Close();
        }

        private void Kalendarz_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;  
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_date.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            
            for(int i = 1; i<dayoftheweek; i++)
            {
                UserControlBlank usrControlBlank = new UserControlBlank(); 
                panel_container.Controls.Add(usrControlBlank);  
            }

            for (int i = 1; i<=days; i++)
            {
                UserControlDays usrControlDays = new UserControlDays(name, CzyAdmin);
                usrControlDays.Days(i);
                panel_container.Controls.Add(usrControlDays);
            }
        }

        private void button_poprzedni_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();

            month--;

            if(month<1)
            {
                year--;
                month = 12;
            }

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_date.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank usrControlBlank = new UserControlBlank();
                panel_container.Controls.Add(usrControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays usrControlDays = new UserControlDays(name, CzyAdmin);
                usrControlDays.Days(i);
                panel_container.Controls.Add(usrControlDays);
            }
        }

        private void button_nastepny_Click(object sender, EventArgs e)
        {
            panel_container.Controls.Clear();

            month++;

            if(month>12)
            {
                year++;
                month = 1;
            }

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_date.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank usrControlBlank = new UserControlBlank();
                panel_container.Controls.Add(usrControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays usrControlDays = new UserControlDays(name, CzyAdmin);
                usrControlDays.Days(i);
                panel_container.Controls.Add(usrControlDays);
            }
        }
    }
}
