namespace Construcciones_JAQ
{
    partial class Frm_Usuario
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_Permisos = new System.Windows.Forms.Button();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_Habilitar = new System.Windows.Forms.RadioButton();
            this.rbt_Deshabilitar = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_dgv_Usuario = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.Cmb_Tipo_Usuario = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo_Usuario = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.txt_Cedula_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Contraseña_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_lNombres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_dgv_Usuario.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(124, 16);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 0;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click_1);
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(14, 16);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_Crear.TabIndex = 1;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // btn_Permisos
            // 
            this.btn_Permisos.Location = new System.Drawing.Point(334, 15);
            this.btn_Permisos.Name = "btn_Permisos";
            this.btn_Permisos.Size = new System.Drawing.Size(75, 23);
            this.btn_Permisos.TabIndex = 2;
            this.btn_Permisos.Text = "Permisos";
            this.btn_Permisos.UseVisualStyleBackColor = true;
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Location = new System.Drawing.Point(33, 15);
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.Size = new System.Drawing.Size(678, 188);
            this.dgv_Usuario.TabIndex = 3;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(226, 16);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 6;
            this.btn_Actualizar.Text = "Actulizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Crear);
            this.panel1.Controls.Add(this.btn_Actualizar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Permisos);
            this.panel1.Location = new System.Drawing.Point(44, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 53);
            this.panel1.TabIndex = 7;
            // 
            // rbt_Habilitar
            // 
            this.rbt_Habilitar.AutoSize = true;
            this.rbt_Habilitar.Location = new System.Drawing.Point(21, 14);
            this.rbt_Habilitar.Name = "rbt_Habilitar";
            this.rbt_Habilitar.Size = new System.Drawing.Size(63, 17);
            this.rbt_Habilitar.TabIndex = 8;
            this.rbt_Habilitar.TabStop = true;
            this.rbt_Habilitar.Text = "Habilitar";
            this.rbt_Habilitar.UseVisualStyleBackColor = true;
            // 
            // rbt_Deshabilitar
            // 
            this.rbt_Deshabilitar.AutoSize = true;
            this.rbt_Deshabilitar.Location = new System.Drawing.Point(21, 57);
            this.rbt_Deshabilitar.Name = "rbt_Deshabilitar";
            this.rbt_Deshabilitar.Size = new System.Drawing.Size(80, 17);
            this.rbt_Deshabilitar.TabIndex = 9;
            this.rbt_Deshabilitar.TabStop = true;
            this.rbt_Deshabilitar.Text = "Deshabilitar";
            this.rbt_Deshabilitar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rbt_Habilitar);
            this.panel2.Controls.Add(this.rbt_Deshabilitar);
            this.panel2.Location = new System.Drawing.Point(557, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 100);
            this.panel2.TabIndex = 10;
            // 
            // panel_dgv_Usuario
            // 
            this.panel_dgv_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_dgv_Usuario.Controls.Add(this.dgv_Usuario);
            this.panel_dgv_Usuario.Location = new System.Drawing.Point(44, 355);
            this.panel_dgv_Usuario.Name = "panel_dgv_Usuario";
            this.panel_dgv_Usuario.Size = new System.Drawing.Size(733, 227);
            this.panel_dgv_Usuario.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmb_Area);
            this.panel3.Controls.Add(this.lbl_Area);
            this.panel3.Controls.Add(this.Cmb_Tipo_Usuario);
            this.panel3.Controls.Add(this.lbl_Tipo_Usuario);
            this.panel3.Controls.Add(this.lbl_Buscar);
            this.panel3.Controls.Add(this.txt_Buscar);
            this.panel3.Controls.Add(this.lbl_Cedula);
            this.panel3.Controls.Add(this.txt_Cedula_Usuario);
            this.panel3.Controls.Add(this.lbl_Contraseña);
            this.panel3.Controls.Add(this.txt_Contraseña_Usuario);
            this.panel3.Controls.Add(this.txt_Nombre_Usuario);
            this.panel3.Controls.Add(this.lbl_lNombres);
            this.panel3.Location = new System.Drawing.Point(26, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 159);
            this.panel3.TabIndex = 35;
            // 
            // cmb_Area
            // 
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Items.AddRange(new object[] {
            "Administracio",
            "Gerencia",
            "Sst",
            "Ti",
            "Obra"});
            this.cmb_Area.Location = new System.Drawing.Point(156, 68);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(121, 21);
            this.cmb_Area.TabIndex = 38;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(91, 74);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(29, 13);
            this.lbl_Area.TabIndex = 37;
            this.lbl_Area.Text = "Area";
            // 
            // Cmb_Tipo_Usuario
            // 
            this.Cmb_Tipo_Usuario.FormattingEnabled = true;
            this.Cmb_Tipo_Usuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.Cmb_Tipo_Usuario.Location = new System.Drawing.Point(490, 71);
            this.Cmb_Tipo_Usuario.Name = "Cmb_Tipo_Usuario";
            this.Cmb_Tipo_Usuario.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Tipo_Usuario.TabIndex = 36;
            this.Cmb_Tipo_Usuario.SelectedIndexChanged += new System.EventHandler(this.Cmb_Tipo_Usuario_SelectedIndexChanged);
            // 
            // lbl_Tipo_Usuario
            // 
            this.lbl_Tipo_Usuario.AutoSize = true;
            this.lbl_Tipo_Usuario.Location = new System.Drawing.Point(402, 74);
            this.lbl_Tipo_Usuario.Name = "lbl_Tipo_Usuario";
            this.lbl_Tipo_Usuario.Size = new System.Drawing.Size(82, 13);
            this.lbl_Tipo_Usuario.TabIndex = 35;
            this.lbl_Tipo_Usuario.Text = "Tipo de Usuario";
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(119, 118);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 33;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(201, 115);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 20);
            this.txt_Buscar.TabIndex = 32;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.Txt_Buscar_TextChanged_1);
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(16, 32);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cedula.TabIndex = 23;
            this.lbl_Cedula.Text = "Cedula";
            // 
            // txt_Cedula_Usuario
            // 
            this.txt_Cedula_Usuario.Location = new System.Drawing.Point(79, 29);
            this.txt_Cedula_Usuario.Name = "txt_Cedula_Usuario";
            this.txt_Cedula_Usuario.Size = new System.Drawing.Size(135, 20);
            this.txt_Cedula_Usuario.TabIndex = 11;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(490, 32);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 28;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Contraseña_Usuario
            // 
            this.txt_Contraseña_Usuario.Location = new System.Drawing.Point(557, 25);
            this.txt_Contraseña_Usuario.Name = "txt_Contraseña_Usuario";
            this.txt_Contraseña_Usuario.Size = new System.Drawing.Size(152, 20);
            this.txt_Contraseña_Usuario.TabIndex = 19;
            // 
            // txt_Nombre_Usuario
            // 
            this.txt_Nombre_Usuario.Location = new System.Drawing.Point(317, 29);
            this.txt_Nombre_Usuario.Name = "txt_Nombre_Usuario";
            this.txt_Nombre_Usuario.Size = new System.Drawing.Size(140, 20);
            this.txt_Nombre_Usuario.TabIndex = 16;
            // 
            // lbl_lNombres
            // 
            this.lbl_lNombres.AutoSize = true;
            this.lbl_lNombres.Location = new System.Drawing.Point(254, 32);
            this.lbl_lNombres.Name = "lbl_lNombres";
            this.lbl_lNombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_lNombres.TabIndex = 22;
            this.lbl_lNombres.Text = "Nombres";
            // 
            // Frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_dgv_Usuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Usuario";
            this.Text = "Frm_Usuario";
            this.Load += new System.EventHandler(this.Frm_Usuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_dgv_Usuario.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_Permisos;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_Habilitar;
        private System.Windows.Forms.RadioButton rbt_Deshabilitar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_dgv_Usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Cmb_Tipo_Usuario;
        private System.Windows.Forms.Label lbl_Tipo_Usuario;
        private System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Cedula;
        public System.Windows.Forms.TextBox txt_Cedula_Usuario;
        private System.Windows.Forms.TextBox txt_Nombre_Usuario;
        private System.Windows.Forms.Label lbl_lNombres;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Contraseña_Usuario;
        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.Label lbl_Area;
    }
}