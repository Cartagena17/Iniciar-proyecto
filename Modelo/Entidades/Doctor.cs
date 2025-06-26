using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Doctor
    {
        private int idDoctor;
        private string nombre;
        private string apellido;
        private string Especialidad;
        private string cargo;

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        //Metodo para mostrar la info

        public static DataTable CargarDoctores()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            //Vamos a crear el query o la consulta

            string consultaQuery = "select nombre, apellido, especialidad from doctores;";
            //Necesitamos un adaptador
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataVirtual = new DataTable();
             
            add.Fill(dataVirtual);
            return dataVirtual;
        }
        
    }
}
