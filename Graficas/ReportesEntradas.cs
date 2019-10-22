using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Bodega.Reportes
{
    public partial class ReportesEntradas : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        public ReportesEntradas()
        {

            InitializeComponent();
            
            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";
        }

        /*public DataTable EnviarDatos(string consulta)
        {
            OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, con);        
        }*/

        public void Barras_producto()
        {

            grf_Barras.Series["Series1"].LegendText = "Propietario";
            grf_Barras.Series["Series1"].XValueMember = "FK_Producto";
            grf_Barras.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }
            
            grf_Barras.DataSource = tabla;

            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Barras_producto();
        }
    }
}
