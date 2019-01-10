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

namespace Projekt
{
    public partial class Login : Form
    {
        string povezi = "Data Source=desktop-2si5ov9;Initial Catalog = Projekt; Integrated Security = True";

        public Login()
        {
            InitializeComponent();
        }

        private void Registriraj_novo(object sender, EventArgs e)
        {
            Registracija novi = new Registracija();
            novi.Show();
            this.Hide();
        }

        private void Prijavi_Se(object sender, EventArgs e)
        {
            SqlConnection konekcija = new SqlConnection(povezi);
            konekcija.Open();
            string zadatak = "Select count (*) from Registracija1 where username = '" + this.user.Text + "' and password= '" + this.pass.Text + "';";

            SqlDataAdapter prikljucivac = new SqlDataAdapter(zadatak, konekcija);
            DataTable pomocna = new DataTable();

            prikljucivac.Fill(pomocna);

            if(pomocna.Rows.Count == 1)
            {
                Izbornik izb = new Izbornik();
                izb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Pogresan username ili password");
            }
            konekcija.Close();
        }
    }
}
