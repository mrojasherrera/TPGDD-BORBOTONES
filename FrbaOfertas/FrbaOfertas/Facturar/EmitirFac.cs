﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace FrbaOfertas.Facturar
{
    public partial class EmitirFac : Form
    {
        public EmitirFac(String proveedor, DateTime desde, DateTime hasta)
        {
            InitializeComponent();
            ProvTB.Text = proveedor;
            cargarCupones(desde, hasta);
            DesdeDTP.Value = desde;
            HastaDTP.Value = hasta;
        }
        String fecha_sistema = Properties.Settings.Default.fechaSistema;
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void cargarCupones(DateTime desde, DateTime hasta) {
            //DateTime unaFecha = Convert.ToDateTime(fecha_sistema);
            String prov = ProvTB.Text;
            String cadena = "SELECT c.Oferta_Codigo 'Código de producto', count(c.Oferta_Codigo) 'Cantidad vendida', count(c.Oferta_Codigo)*o.Oferta_Precio 'Monto' ";
            cadena += "FROM LOS_BORBOTONES.Cupon c JOIN LOS_BORBOTONES.Oferta o ON (c.Oferta_Codigo = o.Oferta_Codigo) ";
            cadena += "GROUP BY c.Oferta_Codigo, o.Oferta_Precio, o.Oferta_Fecha, o.Oferta_Fecha_Venc, o.Provee_CUIT, c.Factura_Nro ";
            cadena += "HAVING cast(o.Oferta_Fecha as date) between cast('"+desde+"' as date) and Cast('"+hasta+"' as date) ";
            cadena += "AND c.Factura_Nro is null ";
            cadena += "AND o.Provee_CUIT = '" + prov + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            CuponesDGV.DataSource = dataSet.Tables[0];
           Double suma = 0.0;          
            foreach (DataGridViewRow row in CuponesDGV.Rows)
            {
                if (row.Cells[2].Value != null) 
                    suma += Convert.ToDouble(row.Cells[2].Value);
            }
            TotalTB.Text = suma.ToString();
        }

        private void EmitirFac_Load(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
