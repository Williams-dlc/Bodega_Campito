using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;

namespace Bodega.Traslados
{
    public partial class EntradaProducto : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";


        
        public EntradaProducto()
        {
            InitializeComponent();
            txt_producto.Enabled = false;
            txt_cantidad.Enabled = false;
            //cmb_propietario.Enabled = false;
            btn_aceptar.Enabled = false;

            dgv_productos.DataSource = CapaDatosBodega.llenarproducto();
            //dtp_fecha.Format = DateTimePickerFormat.Custom;
            //Display the date as "Mon 27 Feb 2012".  
            //dtp_fecha.CustomFormat = "yyyy MM dd";
            cmb_encargado.DataSource = CapaDatosBodega.llenarTrabajador();//llama la tabla trabajador
            cmb_encargado.ValueMember = "Nombre";
            
            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_tipoBodega.DataSource = CapaDatosBodega.llenarBodega();
            cmb_tipoBodega.ValueMember = "tipo_bodega";

            Random r_aleatgenerador = new Random();
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);
        }
        
        
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC
                OdbcCommand cmd = new OdbcCommand("insert into detalleentrada values (null, '" + txt_cantidad.Text + "','" + txt_codigo.Text + "','" + txt_producto.Text + "')", con);
                con.Open();//abre la conexion ;
                cmd.ExecuteNonQuery();
                con.Close();//cierra la conexion

                OdbcCommand cmd1 = new OdbcCommand("update detalleinventario set Cantidad= Cantidad + '" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_producto.Text + " '", con);
                con.Open();//abre la conexion ;
                cmd1.ExecuteNonQuery();
                con.Close();//cierra la conexion
                txt_producto.Text = "";
                txt_cantidad.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || cmb_encargado.SelectedIndex == -1)
            {
                MessageBox.Show("llene todos los campos");//lanza mensaje
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                    OdbcCommand cmd1 = new OdbcCommand("insert into encabezadoentrada values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '"+ cmb_propietario.Text.ToString() + "', '" + cmb_encargado.Text.ToString() + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd1.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion

                    OdbcCommand cmd = new OdbcCommand("insert into EncabezadoInvetarioBodega values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + cmb_encargado.Text.ToString() + "', '" + cmb_tipoBodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    txt_producto.Enabled = true;
                    txt_cantidad.Enabled = true;
                    cmb_propietario.Enabled = true;
                    btn_aceptar.Enabled = true;
                    btn_continuar.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                DataTable tabla = new DataTable();
                using (OdbcConnection con = new OdbcConnection(ConnStr))
                {
                    con.Open();
                    OdbcDataAdapter cmd = new OdbcDataAdapter("select Nombre from producto", con);//llama a la tabla de inventario para ver stock
                                                                                                  //OdbcDataReader queryResults = cmd.ExecuteReader();
                    cmd.Fill(tabla);

                }

                dgv_productos.DataSource = tabla;
                txt_detalle.Text = txt_codigo.Text;
            }
        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_producto.Text = Convert.ToString(dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void nuevaEntrada()
        {
            Random r_aleatgenerador = new Random();//////////////////////////metodo para numero random
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);

            txt_detalle.Text = "";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Deseas realizar nueva entrada con diferente propietario?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                btn_continuar.Enabled = true;
                nuevaEntrada();
            }
            else if (result == DialogResult.No)
            {
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Devoluciones dev = new Devoluciones();
            dev.Show();
        }
    }
}
