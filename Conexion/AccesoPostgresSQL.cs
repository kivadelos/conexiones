using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ConexionesInterface;

namespace ConexionesInterface
{
    class AccesoPostgresSQL: IConexiones_Interface
    {
        NpgsqlConnection conex = new NpgsqlConnection();
        NpgsqlCommand mycom = new NpgsqlCommand();
        NpgsqlDataReader dtRd;
        MySqlDataReader st;
        SqlDataReader sq;

        List<AccesoMYSQL> mysql = new List<AccesoMYSQL>();
        string error;
        private string servidor;
        private string usua;
        private string pass;
        private string baseDa;
        private string tabla;
        private string valores;
        private string campos;
        private string condicion;
        private string valorCondi;
        private string connectionString;
        public bool AccesoMysql(string server, string us, string pwd, string bd)
        {
            bool res = false;
            servidor = server;
            usua = us;
            pass = pwd;
            baseDa = bd;

            connectionString = "server=" + servidor + ";database=" + baseDa + ";uid=" + usua + ";pwd=" + pass + ";";
            res = true;
            return res;
        }
        public object Abrir()
        {
            bool res = false;
            try
            {
                conex.ConnectionString = connectionString;
                conex.Open();
                res = true;
            }
            catch (NpgsqlException msqlex)
            {
                error = "Error al cargar la sesion" + msqlex.Message;
            }
            catch (Exception exp)
            {
                error = "Error al cargar la sesion" + exp.Message;
            }
            return res;
        }
        public bool Cerrar()
        {
            bool res = false;
            try
            {
                if (conex.State == System.Data.ConnectionState.Open)
                {
                    conex.Close();
                    res = true;
                }
                else if (conex.State == System.Data.ConnectionState.Closed)
                {
                    res = true;
                }
                else
                {
                    error = "La conexion esta ocupada intentelo mas tarde";
                    res = false;
                }
            }
            catch (NpgsqlException mexp)
            {
                error = "Error al cargar ka sesion" + mexp.Message;
            }
            catch (Exception xp)
            {
                error = "Error al cargar la sesion" + xp.Message;
            }
            return res;
        }
        public bool Agregar(string tabla, string campos, string valores)
        {
            bool res = false;
            try
            {
                mycom.CommandText = "INSERT INTO " + tabla + " ( " + campos + " ) VALUES ( " + valores + " );";
                this.Abrir();
                mycom.Connection = conex;
                mycom.ExecuteNonQuery();
                res = true;
            }
            catch (NpgsqlException slexp)
            {
                error = "Error al insertar datos" + slexp.Message;
            }
            catch (Exception ti)
            {
                error = "Error general al ingresar datos" + ti.Message;
            }
            //cerramos conexion
            finally
            {
                this.Cerrar();
            }
            return res;
        }
        public NpgsqlDataReader ConsultarPG(string tabla)
        {
            try
            {
                mycom.CommandText = "SELECT * FROM " + tabla + ";";
                this.Abrir();
                mycom.Connection = conex;
                dtRd = mycom.ExecuteReader();
                //dtRd.Read();
            }
            catch (NpgsqlException sd)
            {
                error = "No se puede mostrar ningun campo error en la conexion " + sd;
            }
            catch (Exception on)
            {
                error = "No se puede mostrar ningun campo error general en la conexion " + on;
            }
            //finally
            //{
            //    this.cerrar();
            //}
            return dtRd;
        }
        public MySqlDataReader Consultar(string tabla)
        {
            return st;
        }
        public SqlDataReader ConsultaSql(string tabla)
        {
            return sq;
        }
        public bool Modificar(string tabla, string valores, string condicion, string valorDeCondicion)
        {
            bool res = false;
            try
            {
                mycom.CommandText = "UPDATE " + tabla + " SET " + valores + " WHERE " + condicion + " = " + valorDeCondicion + " ; ";
                //abrimos conexion
                //Console.WriteLine(mycom.CommandText);
                this.Abrir();
                mycom.Connection = conex;
                //ejecutamos query
                mycom.ExecuteNonQuery();
                res = true;
            }
            catch (NpgsqlException slexp)
            {
                error = "Error al modificar datos " + slexp.Message;
            }
            catch (Exception ti)
            {
                error = "Error general al modificar datos " + ti.Message;
            }
            //cerramos conexion
            finally
            {
                this.Cerrar();
            }
            return res;
        }
        public bool Eliminar(string tabla, string condicion, string opcionBorrar)
        {
            bool res = false;
            try
            {
                mycom.CommandText = "DELETE FROM  " + tabla + " WHERE " + opcionBorrar + " = " + condicion + ";";
                this.Abrir();
                mycom.Connection = conex;
                //ejecutamos query
                mycom.ExecuteNonQuery();
                res = true;
            }
            catch (NpgsqlException sqlex)
            {
                error = "Error al eliminar datos" + sqlex.Message;
            }
            catch (Exception exe)
            {
                error = "Error general al eliminar datos" + exe.Message;
            }
            finally
            {
                this.Cerrar();
            }
            return res;
        }
    }
}
