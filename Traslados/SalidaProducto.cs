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

namespace Bodega.Traslados
{
    public partial class SalidaProducto : Form
    {
        CapaDatosBodega conexion = new CapaDatosBodega();
        string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        public SalidaProducto()
        {
            InitializeComponent();

            dgv_producto.DataSource = CapaDatosBodega.llenarproducto();
            cmb_encargado.DataSource = CapaDatosBodega.llenarTrabajador();//llama la tabla trabajador
            cmb_encargado.ValueMember = "Nombre";

            cmb_propietario.DataSource = CapaDatosBodega.llenarPropietario();
            cmb_propietario.ValueMember = "Nombre";

            cmb_bodega.DataSource = CapaDatosBodega.llenarBodega();
            cmb_bodega.ValueMember = "tipo_bodega";

            Random r_aleatgenerador = new Random();
            int numero_generado;
            numero_generado = r_aleatgenerador.Next();
            txt_codigo.Text = Convert.ToString(numero_generado);
            
            txt_cantidad.Enabled = false;
            txt_producto.Enabled = false;
            txt_disponible.Enabled = false;
            btn_aceptar.Enabled = false;
        }


        public void producto()
        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select * from producto", con);//llama a la tabla de inventario para ver stock
                                                                                              //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_producto.DataSource = tabla;
        }

        private void btn_prestar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || cmb_encargado.SelectedIndex == -1 || cmb_propietario.SelectedIndex == -1 || cmb_bodega.SelectedIndex == -1)
            {
                MessageBox.Show("llene todos los campos");//lanza mensaje
            }
            else
            {
                try
                {
                    OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC


                    OdbcCommand cmd = new OdbcCommand("insert into encabezadopedido values ('" + txt_codigo.Text + "','" + dtp_fecha.Value.ToString("yyyyMMdd") + "', '" + cmb_propietario.Text.ToString() + "', '" +cmb_encargado.Text.ToString() + "', '" + cmb_bodega.Text.ToString() + "')", con);
                    con.Open();//abre la conexion 
                    cmd.ExecuteNonQuery();//ejecuta el query
                    con.Close();//cierra la conexion
                    txt_producto.Enabled = true;
                    txt_cantidad.Enabled = true;
                    txt_disponible.Enabled = true;
                    btn_aceptar.Enabled = true;
                    btn_continuar.Enabled = false;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                
                txt_detalle.Text = txt_codigo.Text;
            }
        }

        public void disponibilidad() ////////////////////////////////////////////////procedimiento para mostrar disponibilidad de producto en bodega

        {
            DataTable tabla = new DataTable();
            using (OdbcConnection con = new OdbcConnection(ConnStr))
            {
                con.Open();
                OdbcDataAdapter cmd = new OdbcDataAdapter("select FK_producto, cantidad, FK_Propietario from DetalleInventario where FK_Producto= '"+txt_producto.Text+"' AND FK_Propietario='"+cmb_propietario.Text.ToString()+"'", con);//llama a la tabla de inventario para ver stock
                                                                                                                                      //OdbcDataReader queryResults = cmd.ExecuteReader();
                cmd.Fill(tabla);

            }

            dgv_producto.DataSource = tabla;
            
        }

        private void dgv_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_producto.Text == "")
            {
                try
                {

                    txt_producto.Text = Convert.ToString(dgv_producto.Rows[e.RowIndex].Cells[0].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid
                    disponibilidad();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {

                    txt_disponible.Text = Convert.ToString(dgv_producto.Rows[e.RowIndex].Cells[1].Value.ToString());//llena el textbox con los campos seleccionados en el datagrid

                    producto();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                OdbcCommand cmd1 = new OdbcCommand("insert into DetallePedido values (NULL,'" + txt_cantidad.Text + "', '" + txt_detalle.Text + "', '" + txt_producto.Text + "')", con);
                con.Open();//abre la conexion ;
                cmd1.ExecuteNonQuery();
                con.Close();//cierra la conexion

                OdbcCommand cmd2 = new OdbcCommand("update detalleinventario set Cantidad='" + txt_disponible.Text + "'-'" + txt_cantidad.Text + "' where FK_Propietario='" + cmb_propietario.Text.ToString() + "' AND FK_producto='" + txt_producto.Text + " '", con);//elimina de stock lo solicitado
                con.Open();//abre la conexion ;               
                cmd2.ExecuteNonQuery();
                con.Close();//cierra la conexion

                txt_producto.Text = "";
                txt_cantidad.Text = "";
                txt_disponible.Text = "";
                producto();
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
            DialogResult result = MessageBox.Show("Deseas realizar nueva salida con diferente propietario?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                nuevaEntrada();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar esta operación?", "Nuevo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                txt_producto.Text = "";
                txt_cantidad.Text = "";

                OdbcConnection con = new OdbcConnection(ConnStr);//varibale para llamar la conexion ODBC

                OdbcCommand cmd1 = new OdbcCommand("delete from encabezadopedido where idPedido='" + txt_codigo.Text + "'", con);
                con.Open();//abre la conexion 
                cmd1.ExecuteNonQuery();//ejecuta el query
                con.Close();//cierra la conexion

                

                btn_continuar.Enabled = true;
                txt_producto.Enabled = false;
                txt_cantidad.Enabled = false;
                btn_aceptar.Enabled = false;
                nuevaEntrada();

            }
            else if (result == DialogResult.No)
            {
            }
        }
    }
}
