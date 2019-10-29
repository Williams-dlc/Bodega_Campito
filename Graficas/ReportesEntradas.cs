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

            grf_Barras.Visible = false;
            grf_pie.Visible = false;
        }

        public void mes()
        {
            if (cmb_mes.Text.ToString() == "Enero")
            {
                txt_numero.Text = "1";
            }else if (cmb_mes.Text.ToString() == "Febrero")
            {
                txt_numero.Text = "2";
            }
            else if (cmb_mes.Text.ToString() == "Marzo")
            {
                txt_numero.Text = "3";
            }
            else if (cmb_mes.Text.ToString() == "Abril")
            {
                txt_numero.Text = "4";
            }
            else if (cmb_mes.Text.ToString() == "Mayo")
            {
                txt_numero.Text = "5";
            }
            else if (cmb_mes.Text.ToString() == "Junio")
            {
                txt_numero.Text = "6";
            }
            else if (cmb_mes.Text.ToString() == "Julio")
            {
                txt_numero.Text = "7";
            }
            else if (cmb_mes.Text.ToString() == "Agosto")
            {
                txt_numero.Text = "8";
            }
            else if (cmb_mes.Text.ToString() == "Septiembre")
            {
                txt_numero.Text = "9";
            }
            else if (cmb_mes.Text.ToString() == "Octubre")
            {
                txt_numero.Text = "10";
            }
            else if (cmb_mes.Text.ToString() == "Noviembre")
            {
                txt_numero.Text = "11";
            }
            else if (cmb_mes.Text.ToString() == "Diciembre")
            {
                txt_numero.Text = "12";
            }
        }
        

        public void Barras_producto()
        {
            mes();
            grf_Barras.Series["Series1"].LegendText = cmb_propietario.Text.ToString();
            grf_Barras.Series["Series1"].XValueMember = "FK_Producto";
            grf_Barras.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from encabezadoEntrada a INNER JOIN detalleentrada b ON a.idEntrada=b.FK_encEntrada AND b.FK_Producto=100 AND a.FK_Usuario ='" + cmb_propietario.Text.ToString() + "' and a.Fecha BETWEEN '2019-" + txt_numero.Text + "-1' AND '2019-" + txt_numero.Text + "-30'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                               //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }
            
            grf_Barras.DataSource = tabla;

            
        }

        public void pie_producto()
        {
            mes();
            MessageBox.Show(cmb_mes.Text.ToString());
            grf_pie.Series["Series1"].IsValueShownAsLabel = true;
            grf_pie.Series["Series1"].XValueMember = "FK_Producto";
            grf_pie.Series["Series1"].YValueMembers = "Cantidad";
            grf_pie.Series["Series1"].Points.AddXY("FK_Producto","Cantidad");
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from encabezadoEntrada a INNER JOIN detalleentrada b ON a.idEntrada=b.FK_encEntrada AND b.FK_Producto=100 AND a.FK_Usuario ='"+cmb_propietario.Text.ToString()+"' and a.Fecha BETWEEN '2019-"+txt_numero.Text+ "-1' AND '2019-" + txt_numero.Text + "-30'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_pie.DataSource = tabla;
        }

        public void Barras_productoAnual()
        {

            grf_Barras.Series["Series1"].LegendText = cmb_propietario.Text.ToString();
            grf_Barras.Series["Series1"].XValueMember = "FK_Producto";
            grf_Barras.Series["Series1"].YValueMembers = "Cantidad";
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from detalleInventario where FK_Propietario =  '" + cmb_propietario.Text.ToString() + "' and YEAR(NOW())", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_Barras.DataSource = tabla;


        }

        public void pie_productoAnual()
        {

            grf_pie.Series["Series1"].IsValueShownAsLabel = true;
            grf_pie.Series["Series1"].XValueMember = "FK_Producto";
            grf_pie.Series["Series1"].YValueMembers = "Cantidad";
            grf_pie.Series["Series1"].Points.AddXY("FK_Producto", "Cantidad");
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from detalleInventario where FK_Propietario =  '" + cmb_propietario.Text.ToString() + "' and YEAR(NOW())", con);//llama a la tabla de inventario para ver stock
                                                                                                                                                                                     //OdbcDataReader queryResults = cmd.ExecuteReader();
                                                                                                                                                                                     //SELECT YEAR(Fecha), SUM(Cantidad) as total, '"+cmb_propietario.Text.ToString()+"' from encabezadoentrada a INNER JOIN detalleentrada b on a.idEntrada = b.FK_encEntrada
                                                                                                                                                                                     //"select * from detalleInventario where FK_Propietario =  '"+cmb_propietario.Text.ToString()+"' and Fecha=MONTH(text)"
                cmd.Fill(tabla);

            }

            grf_pie.DataSource = tabla;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (rdb_año.Checked==false && rdb_Mes.Checked==false) {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else {
                grf_Barras.Visible = true;
                grf_pie.Visible = false;
                if (rdb_Mes.Checked == true)
                {
                    Barras_producto();


                } else if (rdb_año.Checked == true)
                {
                    Barras_productoAnual();

                }
            }
        }

        private void btn_barras_Click(object sender, EventArgs e)
        {
            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                grf_Barras.Visible = true;
                grf_pie.Visible = false;
                if (rdb_Mes.Checked == true)
                {
                    Barras_producto();


                }
                else if (rdb_año.Checked == true)
                {
                    Barras_productoAnual();

                }
            }

        }

        private void btn_pie_Click(object sender, EventArgs e)
        {
            if (rdb_año.Checked == false && rdb_Mes.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                grf_Barras.Visible = false;
                grf_pie.Visible = true;
                if (rdb_Mes.Checked == true)
                {
                    pie_producto();


                }
                else if (rdb_año.Checked == true)
                {
                    pie_productoAnual();

                }
            }

        }
    }
}
