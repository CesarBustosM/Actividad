﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadRealizar
{
    public partial class Ingresado : Form
    {
        public Ingresado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal= new Principal();
            principal.Show();
        }
    }
}
