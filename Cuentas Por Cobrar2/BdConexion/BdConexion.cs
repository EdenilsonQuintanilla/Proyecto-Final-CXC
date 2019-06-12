using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;

namespace CapaDatos
{
    public class BdConexion
    {
        String cadenaConex = "Data Source=DESKTOP1;Initial Catalog=cuentasporcobrar;Integrated Security=True";
        SqlDataAdapter adaptador;
        DataTable DT;
        SqlCommandBuilder comm;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        public SqlDataReader dr; 
        public SqlDataAdapter da,db;

        public SqlConnection Conexion1
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public bool Conectar()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = cadenaConex;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public void consultaSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }

        }


        public void Modificarsql(String Guardar)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(Guardar, conexion);
                comando.ExecuteNonQuery();
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }

        }
        public void ElimarSql(String Elimn)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(Elimn, conexion);
                comando.ExecuteNonQuery();
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }

        }
        /*public void BuscarSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {

                comando = new SqlCommand(consulta, conexion);
                dr = comando.ExecuteReader();
                db = new SqlDataAdapter(comando);
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }

        }*/
        public void mostrarSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {

                comando = new SqlCommand(consulta, conexion);
                dr = comando.ExecuteReader();
                da = new SqlDataAdapter(comando);
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }

        }

    }
}
