using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class Estadistico : Form
    {
        public Estadistico()
        {
            InitializeComponent();
            ListarCB.DropDownStyle = ComboBoxStyle.DropDownList;
            UnSemestreCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ListarCB.SelectedIndex = 0;
            UnSemestreCB.SelectedIndex = 0;
           
        }

       

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (ListarCB.SelectedIndex > 0)
            {
                if (UnSemestreCB.SelectedIndex > 0)
                {
                    if (ListarCB.SelectedIndex == 1)
                    {
                        if (UnSemestreCB.SelectedIndex == 1)
                        {
                            MessageBox.Show("elegí listar Proveedores con mayor porcentaje en el primer semestre del año");
                        }
                        else
                        {
                            MessageBox.Show("elegí listar Proveedores con mayor porcentaje en el segundo semestre del año");    
                        }
                        
                    }
                    else
                    {
                        if (UnSemestreCB.SelectedIndex == 1)
                        {
                            MessageBox.Show("elegí listar Proveedores con mayor facturación en el primer semestre del año");
                        }
                        else
                        {
                            MessageBox.Show("elegí listar Proveedores con mayor facturación en el segundor semestre del año");    
                        }
                          
                    }

                }
                else
                {
                    MessageBox.Show("Por favor elegir un semestre...");
                }
            }
            else
            {
                MessageBox.Show("Por favor elegir que una opción a listar...");
            }
        }
    }
}
