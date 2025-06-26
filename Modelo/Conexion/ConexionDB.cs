using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    public class ConexionDB
    {
        private static string servidor = "LAB03-DS-EQ25\\SQLEXPRESS";
        private static String basedeDatos = "Hospital";


        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source = {servidor} ; Initial Catalog = {basedeDatos}; Integrated Security = true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
