﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajN novi = new DodajN();
            novi.Show();
            this.Hide();
        }
    }
}
