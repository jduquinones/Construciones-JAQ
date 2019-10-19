namespace Construcciones_JAQ
{
    partial class FormRegistroPersonal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCedulaP = new System.Windows.Forms.TextBox();
            this.txtTelefonoP = new System.Windows.Forms.TextBox();
            this.txtSalarioP = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.txtCorreoP = new System.Windows.Forms.TextBox();
            this.txtDireccionP = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelDirrecion = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.dtgvPersonal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCedulaP
            // 
            this.txtCedulaP.Location = new System.Drawing.Point(79, 29);
            this.txtCedulaP.Name = "txtCedulaP";
            this.txtCedulaP.Size = new System.Drawing.Size(135, 20);
            this.txtCedulaP.TabIndex = 11;
            // 
            // txtTelefonoP
            // 
            this.txtTelefonoP.Location = new System.Drawing.Point(79, 63);
            this.txtTelefonoP.Name = "txtTelefonoP";
            this.txtTelefonoP.Size = new System.Drawing.Size(152, 20);
            this.txtTelefonoP.TabIndex = 13;
            // 
            // txtSalarioP
            // 
            this.txtSalarioP.Location = new System.Drawing.Point(317, 63);
            this.txtSalarioP.Name = "txtSalarioP";
            this.txtSalarioP.Size = new System.Drawing.Size(152, 20);
            this.txtSalarioP.TabIndex = 14;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(562, 25);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(152, 20);
            this.txtApellidoP.TabIndex = 15;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(317, 29);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(140, 20);
            this.txtNombreP.TabIndex = 16;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(13, 18);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarP.TabIndex = 17;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.BtnAgregarP_Click);
            // 
            // txtCorreoP
            // 
            this.txtCorreoP.Location = new System.Drawing.Point(562, 63);
            this.txtCorreoP.Name = "txtCorreoP";
            this.txtCorreoP.Size = new System.Drawing.Size(152, 20);
            this.txtCorreoP.TabIndex = 19;
            // 
            // txtDireccionP
            // 
            this.txtDireccionP.Location = new System.Drawing.Point(79, 96);
            this.txtDireccionP.Name = "txtDireccionP";
            this.txtDireccionP.Size = new System.Drawing.Size(152, 20);
            this.txtDireccionP.TabIndex = 21;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(254, 32);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(49, 13);
            this.labelNombres.TabIndex = 22;
            this.labelNombres.Text = "Nombres";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(16, 32);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(40, 13);
            this.labelCedula.TabIndex = 23;
            this.labelCedula.Text = "Cedula";
            // 
            // labelDirrecion
            // 
            this.labelDirrecion.AutoSize = true;
            this.labelDirrecion.Location = new System.Drawing.Point(16, 103);
            this.labelDirrecion.Name = "labelDirrecion";
            this.labelDirrecion.Size = new System.Drawing.Size(49, 13);
            this.labelDirrecion.TabIndex = 27;
            this.labelDirrecion.Text = "Dirrecion";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(502, 70);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 28;
            this.labelCorreo.Text = "Correo";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(254, 66);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 29;
            this.labelSalario.Text = "Salario";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(16, 66);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 30;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(502, 32);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 31;
            this.labelApellidos.Text = "Apellidos";
            // 
            // dtgvPersonal
            // 
            this.dtgvPersonal.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPersonal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPersonal.Location = new System.Drawing.Point(47, 367);
            this.dtgvPersonal.Name = "dtgvPersonal";
            this.dtgvPersonal.ReadOnly = true;
            this.dtgvPersonal.Size = new System.Drawing.Size(743, 217);
            this.dtgvPersonal.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Buscar);
            this.panel1.Controls.Add(this.txt_Buscar);
            this.panel1.Controls.Add(this.labelCedula);
            this.panel1.Controls.Add(this.txtCedulaP);
            this.panel1.Controls.Add(this.labelTelefono);
            this.panel1.Controls.Add(this.labelSalario);
            this.panel1.Controls.Add(this.labelApellidos);
            this.panel1.Controls.Add(this.labelCorreo);
            this.panel1.Controls.Add(this.txtApellidoP);
            this.panel1.Controls.Add(this.txtCorreoP);
            this.panel1.Controls.Add(this.txtNombreP);
            this.panel1.Controls.Add(this.txtDireccionP);
            this.panel1.Controls.Add(this.txtSalarioP);
            this.panel1.Controls.Add(this.labelNombres);
            this.panel1.Controls.Add(this.txtTelefonoP);
            this.panel1.Controls.Add(this.labelDirrecion);
            this.panel1.Location = new System.Drawing.Point(47, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 185);
            this.panel1.TabIndex = 34;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(90, 143);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 33;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(172, 140);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 20);
            this.txt_Buscar.TabIndex = 32;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.Txt_Buscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Seleccionar);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btnAgregarP);
            this.panel2.Location = new System.Drawing.Point(47, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 102);
            this.panel2.TabIndex = 35;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(13, 62);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(110, 62);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(110, 18);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 20;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // FormRegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvPersonal);
            this.Name = "FormRegistroPersonal";
            this.Text = "REGISTRO PERSONAL";
            this.Load += new System.EventHandler(this.FormRegistroPersonal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefonoP;
        private System.Windows.Forms.TextBox txtSalarioP;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.TextBox txtCorreoP;
        private System.Windows.Forms.TextBox txtDireccionP;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelDirrecion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.TextBox txtCedulaP;
        public System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView dtgvPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Seleccionar;
    }
}

