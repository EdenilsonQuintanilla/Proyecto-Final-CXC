using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows;

namespace CapaMant
{
    public class MattInsertar
    {
        BdConexion test = new BdConexion();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader leer;
        
        private String DUI, Nit, Nombres, Direccion, NRC, Descripcion, FechaL;
        private Double Precio, MontoP, total;
        private int IdCliente, IdArticulo, Cantidad;

        public String FechaL1
        {
            get { return FechaL; }
            set { FechaL = value; }
        }

        public String Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public String NRC1
        {
            get { return NRC; }
            set { NRC = value; }
        }

        public String Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public String Nombres1
        {
            get { return Nombres; }
            set { Nombres = value; }
        }

        public String Nit1
        {
            get { return Nit; }
            set { Nit = value; }
        }

        public String DUI1
        {
            get { return DUI; }
            set { DUI = value; }
        }


        public int Cantidad1
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        public int IdArticulo1
        {
            get { return IdArticulo; }
            set { IdArticulo = value; }
        }

        public int IdCliente1
        {
            get { return IdCliente; }
            set { IdCliente = value; }
        }


        public Double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Double MontoP1
        {
            get { return MontoP; }
            set { MontoP = value; }
        }

        public Double Precio1
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public DataTable dt = new DataTable();


        public void insertVendor()
        {
            try
            {
                String insert = "INSERT INTO cuentas(idcliente,DUI,NIT,nombres,dirrecion,NRC,idarticulo,descripcion,cantidad,precio,montopendiente,total,fechalimite)VALUES(" + IdCliente + ",'" + DUI + "','" + Nit + "','" + Nombres + "','" + Direccion + "','" + NRC + "'," + IdArticulo + ",'" + Descripcion + "'," + Cantidad + "," + Precio + "," + MontoP + "," + total + ",'" + FechaL + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }
        public void actualizarVendor()
        {
            String cad = "update cuentas set DUI ='" + DUI + "', NIT = '" + Nit + "', nombres = '" + Nombres + "', dirrecion = '" + Direccion + "',NRC = '" + NRC + "', idarticulo = " + IdArticulo + ", descripcion = '" + Descripcion + "', cantidad = " + Cantidad + ", precio = " + Precio + ", montopendiente = " + MontoP + ", total = " + total + ",fechalimite = '"+FechaL+"'  where idcliente =" + IdCliente;
            test.Conectar();
            test.Modificarsql(cad);
            test.Desconectar();
        
        }
        public void ElimVend()
        {
            String cad = "DELETE FROM cuentas where idcliente =" + IdCliente;
            test.Conectar();
            test.Modificarsql(cad);
            test.Desconectar();

        }
        public void mostrarVendor()
        {
            try
            {
                String consulta = "select * from cuentas";

                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }
        }
        /*public void BuscarVendor()
        {
            try
            {
                String consulta = "select * from cuentas where idcliente =" + IdCliente;

                test.Conectar();
                test.BuscarSQL(consulta);
                test.db.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }
        }*/
              
        
        
    }
}
