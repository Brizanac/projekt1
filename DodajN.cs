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
    public partial class DodajN : Form
    {
        string povezi = "Data Source=desktop-2si5ov9;Initial Catalog = Projekt; Integrated Security = True";
        
        public DodajN()
        {
            InitializeComponent();

            timer1.Start();
        }


        private void DodajP(object sender, EventArgs e)
        {
    
            var AdrP = "centar";
            SqlConnection konekcija = new SqlConnection(povezi);
            konekcija.Open();
            string zadatak = " Insert into Narudzba(DatumN, DatumD, AdresaD,AdresaP,Ime,Prezime) values ('" + DateTime.Today + "','" + DateTime.Today.AddDays(3)+ "','" + this.AdresaDTXT.Text + "','" + AdrP + "', '" + this.ImeTXT.Text + "','" + PrezimeTXT + "' );";
            SqlCommand napravi = new SqlCommand(zadatak, konekcija);
            SqlDataReader napravi1 = napravi.ExecuteReader();
            AdresaDTXT.Text = "";
            ImeTXT.Text = "";
            PrezimeTXT.Text = "";
            konekcija.Close();

        }

        private static void Povecaj_Datum(DateTime VrijemDostave)
        {
            VrijemDostave.AddDays(3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.Datum.Text = time.ToString();
        }

        
    }
}