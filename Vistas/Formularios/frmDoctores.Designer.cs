namespace Vistas.Formularios
{
    partial class frmDoctores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDoctores = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblDatDoct = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoctores
            // 
            this.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctores.Location = new System.Drawing.Point(38, 380);
            this.dgvDoctores.Name = "dgvDoctores";
            this.dgvDoctores.Size = new System.Drawing.Size(701, 187);
            this.dgvDoctores.TabIndex = 0;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnEliminar);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.btnAct);
            this.gbDatos.Controls.Add(this.txtCargo);
            this.gbDatos.Controls.Add(this.txtEspecialidad);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.txtName);
            this.gbDatos.Controls.Add(this.lblCargo);
            this.gbDatos.Controls.Add(this.lblEspecialidad);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.lblName);
            this.gbDatos.Controls.Add(this.lblDatDoct);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(64, 57);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(528, 207);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblDatDoct
            // 
            this.lblDatDoct.AutoSize = true;
            this.lblDatDoct.Location = new System.Drawing.Point(42, 25);
            this.lblDatDoct.Name = "lblDatDoct";
            this.lblDatDoct.Size = new System.Drawing.Size(114, 15);
            this.lblDatDoct.TabIndex = 0;
            this.lblDatDoct.Text = "Datos del Doctor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(45, 87);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(45, 116);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(90, 15);
            this.lblEspecialidad.TabIndex = 3;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(45, 149);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 15);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 87);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 21);
            this.txtApellido.TabIndex = 6;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(141, 113);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 21);
            this.txtEspecialidad.TabIndex = 7;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(96, 146);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 21);
            this.txtCargo.TabIndex = 8;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(385, 46);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 9;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(385, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(385, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvDoctores);
            this.Name = "frmDoctores";
            this.Text = "frmDoctores";
            this.Load += new System.EventHandler(this.frmDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctores;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDatDoct;
    }
}