using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmDoctores : Form
    {
        public frmDoctores()
        {
            InitializeComponent();
        }
        private void MostrarDoctores()
        {
            dgvDoctores.DataSource = null;
            dgvDoctores.DataSource = Doctor.CargarDoctores();
        }

        private void frmDoctores_Load(object sender, EventArgs e)
        {
            MostrarDoctores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Aqui vamos a crear el objeto y vamos a capturar la info 
            //Por medio de los textbox

            Doctor doc = new Doctor();

            doc.Nombre=txtName.Text;
            doc.Apellido=txtApellido.Text;
            doc.Especialidad1=txtEspecialidad.Text;
            doc.Cargo=txtCargo.Text;
            doc.InsertarDoctores();

            LimpiarCampo();

            MostrarDoctores();
            

        }

        private void LimpiarCampo()
        {
            MessageBox.Show("Registro exitoso");

            txtName.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
            txtEspecialidad.Clear();
        }

    }
}
