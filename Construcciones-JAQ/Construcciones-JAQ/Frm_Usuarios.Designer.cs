namespace Construcciones_JAQ
{
    partial class Frm_Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgv_Registro_usuario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Tpo_Usuario = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo_Usuario = new System.Windows.Forms.Label();
            this.btn_Agregar_Usuario = new System.Windows.Forms.Button();
            this.txt_Confirmar_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Confirmar_contraseña = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_usuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Agregar_Usuario);
            this.panel2.Controls.Add(this.btn_Seleccionar);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Location = new System.Drawing.Point(45, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 247);
            this.panel2.TabIndex = 36;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(12, 139);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 20;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(12, 83);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(12, 195);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // dgv_Registro_usuario
            // 
            this.dgv_Registro_usuario.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Registro_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro_usuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Registro_usuario.Location = new System.Drawing.Point(269, 264);
            this.dgv_Registro_usuario.Name = "dgv_Registro_usuario";
            this.dgv_Registro_usuario.ReadOnly = true;
            this.dgv_Registro_usuario.Size = new System.Drawing.Size(650, 254);
            this.dgv_Registro_usuario.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Tpo_Usuario);
            this.panel1.Controls.Add(this.lbl_Tipo_Usuario);
            this.panel1.Controls.Add(this.txt_Confirmar_Contraseña);
            this.panel1.Controls.Add(this.lbl_Confirmar_contraseña);
            this.panel1.Controls.Add(this.txt_Contraseña);
            this.panel1.Controls.Add(this.lbl_Contraseña);
            this.panel1.Controls.Add(this.cmb_Area);
            this.panel1.Controls.Add(this.labelCedula);
            this.panel1.Controls.Add(this.txt_Cedula);
            this.panel1.Controls.Add(this.lbl_Area);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.labelNombres);
            this.panel1.Location = new System.Drawing.Point(194, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 158);
            this.panel1.TabIndex = 38;
            // 
            // cmb_Tpo_Usuario
            // 
            this.cmb_Tpo_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tpo_Usuario.FormattingEnabled = true;
            this.cmb_Tpo_Usuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmb_Tpo_Usuario.Location = new System.Drawing.Point(373, 90);
            this.cmb_Tpo_Usuario.Name = "cmb_Tpo_Usuario";
            this.cmb_Tpo_Usuario.Size = new System.Drawing.Size(169, 21);
            this.cmb_Tpo_Usuario.TabIndex = 45;
            // 
            // lbl_Tipo_Usuario
            // 
            this.lbl_Tipo_Usuario.AutoSize = true;
            this.lbl_Tipo_Usuario.Location = new System.Drawing.Point(300, 90);
            this.lbl_Tipo_Usuario.Name = "lbl_Tipo_Usuario";
            this.lbl_Tipo_Usuario.Size = new System.Drawing.Size(67, 13);
            this.lbl_Tipo_Usuario.TabIndex = 44;
            this.lbl_Tipo_Usuario.Text = "Tipo Usuario";
            // 
            // btn_Agregar_Usuario
            // 
            this.btn_Agregar_Usuario.Location = new System.Drawing.Point(12, 28);
            this.btn_Agregar_Usuario.Name = "btn_Agregar_Usuario";
            this.btn_Agregar_Usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar_Usuario.TabIndex = 0;
            this.btn_Agregar_Usuario.Text = "Agregar";
            this.btn_Agregar_Usuario.UseVisualStyleBackColor = true;
            this.btn_Agregar_Usuario.Click += new System.EventHandler(this.Btn_Agregar_Usuario_Click);
            // 
            // txt_Confirmar_Contraseña
            // 
            this.txt_Confirmar_Contraseña.Location = new System.Drawing.Point(701, 74);
            this.txt_Confirmar_Contraseña.Name = "txt_Confirmar_Contraseña";
            this.txt_Confirmar_Contraseña.Size = new System.Drawing.Size(140, 20);
            this.txt_Confirmar_Contraseña.TabIndex = 42;
            // 
            // lbl_Confirmar_contraseña
            // 
            this.lbl_Confirmar_contraseña.AutoSize = true;
            this.lbl_Confirmar_contraseña.Location = new System.Drawing.Point(568, 77);
            this.lbl_Confirmar_contraseña.Name = "lbl_Confirmar_contraseña";
            this.lbl_Confirmar_contraseña.Size = new System.Drawing.Size(114, 13);
            this.lbl_Confirmar_contraseña.TabIndex = 41;
            this.lbl_Confirmar_contraseña.Text = "Confrme la Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(649, 24);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(140, 20);
            this.txt_Contraseña.TabIndex = 40;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(568, 31);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 39;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // cmb_Area
            // 
            this.cmb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Items.AddRange(new object[] {
            "Administracion",
            "Gerencia",
            "TI",
            "SST"});
            this.cmb_Area.Location = new System.Drawing.Point(363, 28);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(169, 21);
            this.cmb_Area.TabIndex = 38;
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(27, 36);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(40, 13);
            this.labelCedula.TabIndex = 23;
            this.labelCedula.Text = "Cedula";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(90, 33);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(169, 20);
            this.txt_Cedula.TabIndex = 11;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(300, 31);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(29, 13);
            this.lbl_Area.TabIndex = 28;
            this.lbl_Area.Text = "Area";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(90, 87);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(169, 20);
            this.txt_Nombre.TabIndex = 16;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(27, 90);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(49, 13);
            this.labelNombres.TabIndex = 22;
            this.labelNombres.Text = "Nombres";
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Registro_usuario);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Usuarios";
            this.Text = "Frm_Usuarios";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro_usuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Registro_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Tpo_Usuario;
        private System.Windows.Forms.Label lbl_Tipo_Usuario;
        private System.Windows.Forms.TextBox txt_Confirmar_Contraseña;
        private System.Windows.Forms.Label lbl_Confirmar_contraseña;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.Label labelCedula;
        public System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Button btn_Agregar_Usuario;
    }
}