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
    public partial class Registracija : Form
    {
        
        string povezi = "Data Source=desktop-2si5ov9;Initial Catalog = Projekt; Integrated Security = True";
        
        public Registracija()
        {
            InitializeComponent();
        }

        private void Izadji(object sender, EventArgs e)
        {

            Login izlaz = new Login();
            izlaz.Show();
            this.Hide();

        }

        private void spremi_novog(object sender, EventArgs e)
        {
            
            SqlConnection konekcija = new SqlConnection(povezi);
            konekcija.Open();
            string zadatak = " Insert into Registracija1 values (  "+this.vrstaTXT.Text+", '"+this.ImeTXT.Text+"','"+this.PrezimeTXT.Text+"', '"+this.UsernameTXT.Text+"','"+this.PasswordTXT.Text+"' );";
            SqlCommand napravi = new SqlCommand (zadatak,konekcija);
            napravi.ExecuteNonQuery();
            
            vrstaTXT.Text = "";
            ImeTXT.Text = "";
            PrezimeTXT.Text = "";
            UsernameTXT.Text = "";
            PasswordTXT.Text = "";
            konekcija.Close();


        }
    }
}
