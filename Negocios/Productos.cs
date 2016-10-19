using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionesInterface;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;

namespace Negocios
{
    public class Productos
    {
        IConexiones_Interface axeso = new AccesoMYSQL();
        //AccesoMYSQL axeso = new AccesoMYSQL();
        
        public bool Conexion()
        {
            bool conexion = axeso.AccesoMysql("localhost", "root", "usbw", "kivadelos");
            return conexion;

        }
        List<Productos> lista = new List<Productos>();
        //propiedades
        private int id;
        private string nombre;
        private string descripcion;
        private int precio;
        private string codBarras;
        private int cantidad;
        private string unidadDeMedida;

        //crear metodo enlistar productos se le llama para utilizacion en lo visual del proyecto
        public List<Productos> enlistarTodProd()
        {
            MySqlDataReader dtRd = axeso.Consultar("productos");
            //validar datareader
            if (dtRd.HasRows)
            {
                // numero de registros
                while (dtRd.Read())
                {
                    Productos prd = new Productos();
                    prd.Id = int.Parse(dtRd[0].ToString());
                    prd.Nombre = dtRd[1].ToString();
                    prd.Descripcion = dtRd[2].ToString();
                    prd.Precio = int.Parse(dtRd[3].ToString());
                    prd.CodBarras = dtRd[4].ToString();
                    prd.Cantidad = int.Parse(dtRd[5].ToString());
                    prd.UnidadDeMedida = dtRd[6].ToString();
                    //agregamos a la lista
                    lista.Add(prd);
                }
                dtRd.Close();
            }
            else
            {
                return null;
            }
            //return null;
            return lista;
        }
        //agregar productos
        public bool agregarProd()
        { 
            bool ejecutar = axeso.Agregar("productos", "id,nombre,descripcion,precio,codBarras,cantidad,unidadDemedida", "NULL,'" + nombre + "','" + descripcion + "','" + precio + "','" + codBarras + "','" + cantidad + "','" + unidadDeMedida + "'");
            return ejecutar;
           

        }
        //modificar productos
        public bool modificarProd()
        {
            axeso.Abrir();
            bool modify = axeso.Modificar("productos", "nombre=" + nombre + ",descripcion=" + descripcion + ",precio=" + codBarras + ",unidadDemedida=" + unidadDeMedida, "id", id + "");
            axeso.Cerrar();
            return modify;

        }
        public bool modificarCantidad()
        {
            axeso.Abrir();
            bool cambio = axeso.Modificar("productos", "cantidad=" + cantidad, "codBarras", codBarras + "");
            axeso.Cerrar();
            return cambio;
        }
        //eliminar 
        public bool eliminarProd()
        {
            axeso.Abrir();
            bool delete = axeso.Eliminar("productos", "id=", id.ToString());
            axeso.Cerrar();
            return delete;

        }
        //getters setters
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string CodBarras
        {
            get
            {
                return codBarras;
            }

            set
            {
                codBarras = value;
            }
        }

        public string UnidadDeMedida
        {
            get
            {
                return unidadDeMedida;
            }

            set
            {
                unidadDeMedida = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    }
}

