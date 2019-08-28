using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;

namespace Bodega.Productos
{
    public partial class ListadoProducto : Form
    {

        CapaDatosBodega conexion = new CapaDatosBodega();
        public ListadoProducto()
        {
            InitializeComponent();
            dgv_productos.DataSource = CapaDatosBodega.llenarInventario();
        }
    }
}
