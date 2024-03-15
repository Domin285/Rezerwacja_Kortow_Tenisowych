using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormMenu : Form
    {
        private string name;
        public FormMenu(string usrname)
        {
            this.name = usrname;
            InitializeComponent();
            panel_nawigacja.Height = button_menu.Height;
            panel_nawigacja.Top = button_menu.Top;
            panel_nawigacja.Left = button_menu.Left;
            button_menu.BackColor = Color.FromName("LightGray");
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            menu2.Visible = true;
            kalendarz2.Visible = false;

            panel_nawigacja.Height = button_menu.Height;
            panel_nawigacja.Top = button_menu.Top;
            panel_nawigacja.Left = button_menu.Left;
            button_menu.BackColor = Color.FromName("LightGray");
        }

        private void button_kalendarz_Click(object sender, EventArgs e)
        {
            menu2.Visible = false;
            kalendarz2.Visible = true;

            panel_nawigacja.Height = button_kalendarz.Height;
            panel_nawigacja.Top = button_kalendarz.Top;
            button_kalendarz.BackColor = Color.FromName("LightGray");
        }

        private void button_wyloguj_Click(object sender, EventArgs e)
        {
            panel_nawigacja.Height = button_wyloguj.Height;
            panel_nawigacja.Top = button_wyloguj.Top;
            button_wyloguj.BackColor = Color.FromName("LightGray");

            new FormLogin().Show();
            this.Hide();
        }

        private void button_menu_Leave(object sender, EventArgs e)
        {
            button_menu.BackColor = Color.FromName("White");
        }

        private void button_kalendarz_Leave(object sender, EventArgs e)
        {
            button_kalendarz.BackColor = Color.FromName("White");
        }

        private void button_wyloguj_Leave(object sender, EventArgs e)
        {
            button_wyloguj.BackColor = Color.FromName("White");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            username_label.Text = name;
            menu2.Visible = true;
            kalendarz2.Visible = false;
        }

    }
}
