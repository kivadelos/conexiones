using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Npgsql;

namespace ConexionesInterface
{
    public interface IConexiones_Interface
    {
        bool AccesoMysql(string server, string us, string pwd, string bd);
        object Abrir();
        bool Cerrar();
        MySqlDataReader Consultar(string tabla);
        SqlDataReader ConsultaSql(string tabla);
        NpgsqlDataReader ConsultarPG(string tabla);
        bool Agregar(string tabla, string campos, string valores);
        bool Modificar(string tabla, string valores, string condicion, string valorCondicion);
        bool Eliminar(string tabla, string condicion, string conBorrar);
    }
}
