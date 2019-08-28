using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Bodega
{
    class CapaDatosBodega
    {
        public static OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta);

        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=35.225.5.123;Database=Db_Colchoneria;uid=umg;pwd=umg";
        public static string producto = "select * from Producto";
        public static string encargado = "select * from trabajador";
        public static string propietario = "select * from distribuidores";
        public static string bodega = "select * from Bodega";
        public static string pedido = "select * from DetalleInventario";
        public static string prestador = "select * from prestador";

        public static DataTable llenarproducto()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(producto, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarTrabajador()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(encargado, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarPropietario()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(propietario, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarBodega()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(bodega, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }


        public static DataTable llenarInventario()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(pedido, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }

        public static DataTable llenarPrestador()
        {
            DataTable tmp = new DataTable();
            OdbcDataAdapter msj = new OdbcDataAdapter(prestador, cnx);
            try
            {
                cnx.Open();
                msj.Fill(tmp);
                cnx.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { cnx.Close(); }
            return tmp;
        }
    }
}
