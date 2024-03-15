using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBazy
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        private string name;
        private bool CzyAdmin;
        public UserControlDays(string usrname, bool admin)
        {
            InitializeComponent();
            this.name = usrname;
            this.CzyAdmin = admin;
        }

        public void Days(int numday)
        {
            label_dni.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = label_dni.Text;
            FormDodaj dodaj = new FormDodaj(name);
            dodaj.Show();
        }

        private void label_event_Click(object sender, EventArgs e)
        {
            static_day = label_dni.Text;
            FormZapisane zapisane = new FormZapisane(static_day, CzyAdmin);
            zapisane.Show();    
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            static_day = label_dni.Text;
        }
    }
}
