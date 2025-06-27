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

            string consultaQuery = "select nombre, apellido, especialidad, cargp from doctores;";
            //Necesitamos un adaptador
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataVirtual = new DataTable();
             
            add.Fill(dataVirtual);
            return dataVirtual;
        }

        #region
        public bool InsertarDoctores()
        {
            SqlConnection conexion=ConexionDB.Conectar();

            // Crearemos la query o consulta

            string ConsultaQueuryInsertar = "insert into doctores (nombre, apellido, especialidad, cargp) values (@nombre,@apellido, @especialidad, @cargp)";
            SqlCommand insertar = new SqlCommand(ConsultaQueuryInsertar,conexion);

            insertar.Parameters.AddWithValue("@nombre", nombre);
            insertar.Parameters.AddWithValue("@apellido",apellido);
            insertar.Parameters.AddWithValue("@especialidad",Especialidad);
            insertar.Parameters.AddWithValue("@cargp",cargo);

            //Ahora insertamos los valor que reciben desde el form por medio de un objeto
            //y el set nos ayuda a darle esos valores

            //Hay q validar si almenos una fila se afecto

            if (insertar.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }





            
        }
        #endregion

    }
}
