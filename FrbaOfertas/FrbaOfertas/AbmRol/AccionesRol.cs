﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public partial class AccionesRol : Form
    {
        public AccionesRol()
        {
            InitializeComponent();
        }

        private void NuevoRolBtn_Click(object sender, EventArgs e)
        {
            AbmRol.NuevoRol nuevo = new AbmRol.NuevoRol();
            nuevo.ShowDialog();
        }

        private void FiltrarRolBtn_Click(object sender, EventArgs e)
        {
            AbmRol.FiltrarRol filtrar = new AbmRol.FiltrarRol();
            filtrar.ShowDialog();
        }

        private void RestaurarBtn_Click(object sender, EventArgs e)
        {
            AbmRol.RestaurarRol restaurar = new RestaurarRol();
            restaurar.ShowDialog();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
