using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Vistas
{
    public partial class TablaMySQL : Form
    {
        Productos prod = new Productos();
        List<Productos> products = new List<Productos>();    
        public TablaMySQL()
        {
            prod.Conexion();
            InitializeComponent();
        }

        private void TablaMySQL_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.Conexion();
            if (tabControl1.SelectedIndex==1)
            {
                dataGridView1.DataSource = null;
                DataTable tabla = new DataTable();
                tabla.Columns.Add("colNombre");
                tabla.Columns.Add("colDesc");
                tabla.Columns.Add("colCant");

                products = prod.enlistarTodProd();
                for (int i = 0; i < products.Count; i++)
                {
                    DataRow dtrd = tabla.NewRow();
                    dtrd["colNombre"] = products[i].Nombre;
                    dtrd["colDesc"] = products[i].Descripcion;
                    dtrd["colCant"] = products[i].Cantidad;
                    tabla.Rows.Add(dtrd);
                }
                dataGridView1.DataSource = tabla;
            }
        }
    }
}
