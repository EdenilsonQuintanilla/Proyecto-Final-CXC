using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Common;
using CapaMant;
using CapaDatos;

namespace Cuentas_Por_Cobrar2
{
    public partial class Form1 : Form
    {
        

        BdConexion enl = new BdConexion();
        MattInsertar neg = new MattInsertar();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            neg.IdCliente1 = Convert.ToInt32(txtIdc.Text);
            neg.DUI1 = txtDui.Text;
            neg.Nit1 = txtNit.Text;
            neg.Nombres1 = txtNom.Text;
            neg.Direccion1 = txtDirec.Text;
            neg.NRC1 = txtNrc.Text;
            neg.IdArticulo1 = Convert.ToInt32(txtIdA.Text);
            neg.Descripcion1 = txtDescr.Text;
            neg.Cantidad1 = int.Parse(txtCn.Text);
            neg.Precio1 = Convert.ToDouble(txtPrec.Text);
            neg.MontoP1 = Convert.ToDouble(txtMonto.Text);
            neg.Total = Double.Parse(txtTotal.Text);
            neg.FechaL1 = txtFecha.Text;
            limpiar();
            neg.insertVendor();
            MessageBox.Show("Datos Ingresados");
            cargar();
            
            
        }
        public void limpiar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        
        }
        public void cargar()
        {
            neg.mostrarVendor();
            dataGridView1.DataSource = neg.dt;
        
        }
        /*public void carga2()
        {
            neg.BuscarVendor();
            dataGridView1.DataSource = neg.dt;
        
        
        }*/

        private void btnElimi_Click(object sender, EventArgs e)
        {
            neg.IdCliente1 = int.Parse(txtIdc.Text);
            limpiar();
            neg.ElimVend();
            MessageBox.Show("Cliente Eliminado");
            cargar();
            neg.mostrarVendor();
            dataGridView1.DataSource = neg.dt;
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdc.Text = "";
            txtDui.Text = "";
            txtNit.Text ="";
            txtNom.Text = "";
            txtDirec.Text = "";
            txtNrc.Text = "";
            txtIdA.Text = "";
            txtDescr.Text = "";
            txtCn.Text = "";
            txtPrec.Text = "";
            txtMonto.Text = "";
            txtTotal.Text = "";
            txtFecha.Text = "aa-mm-dd";
            

        }
        public void mostrar(DataGridView dgv)
        { 
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cuentasporcobrarDataSet.cuentas' Puede moverla o quitarla según sea necesario.
            this.cuentasTableAdapter.Fill(this.cuentasporcobrarDataSet.cuentas);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            neg.IdCliente1 = Convert.ToInt32(txtIdc.Text);
            neg.DUI1 = txtDui.Text;
            neg.Nit1 = txtNit.Text;
            neg.Nombres1 = txtNom.Text;
            neg.Direccion1 = txtDirec.Text;
            neg.NRC1 = txtNrc.Text;
            neg.IdArticulo1 = Convert.ToInt32(txtIdA.Text);
            neg.Descripcion1 = txtDescr.Text;
            neg.Cantidad1 = int.Parse(txtCn.Text);
            neg.Precio1 = Convert.ToDouble(txtPrec.Text);
            neg.MontoP1 = Convert.ToDouble(txtMonto.Text);
            neg.Total = Double.Parse(txtTotal.Text);
            neg.FechaL1 = txtFecha.Text;
            limpiar();
            neg.actualizarVendor();
            MessageBox.Show("Datos Actualizados");
            cargar();
            
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            neg.IdCliente1 = int.Parse(txtIdc.Text);
            
            
            


        }

        private void btmCargar_Click(object sender, EventArgs e)
        {
            
        }
        

        private void txtIdc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPrec_Leave(object sender, EventArgs e)
        {
            int v1;
            double  v2, r1, r2;
            v1 = Convert.ToInt32(txtCn.Text);
            v2 = Convert.ToDouble(txtPrec.Text);
            r1 = v1 * v2;
            r2 = v1 * v2;
            txtMonto.Text = r1.ToString();
            txtTotal.Text = r2.ToString();
        }

        
    }
}
