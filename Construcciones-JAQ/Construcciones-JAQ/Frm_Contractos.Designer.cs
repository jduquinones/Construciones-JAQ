namespace Construcciones_JAQ
{
    partial class Frm_Contractos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Numero_Contracto = new System.Windows.Forms.Label();
            this.lbl_N_Contracto = new System.Windows.Forms.Label();
            this.panel_botones = new System.Windows.Forms.Panel();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_Concluido = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.dtgvContracto = new System.Windows.Forms.DataGridView();
            this.panel_contractos = new System.Windows.Forms.Panel();
            this.lbl_Fecha_Termino = new System.Windows.Forms.Label();
            this.txt_nombre_obra = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_Obra = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.lbl_Nit = new System.Windows.Forms.Label();
            this.dtp_fecha_ini_contracto = new System.Windows.Forms.DateTimePicker();
            this.txt_Nit = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.lbl_encargado = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txt_Razon_Social = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txt_encargado = new System.Windows.Forms.TextBox();
            this.Lbl_Razon_social = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelDirrecion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNominaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contronIEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContracto)).BeginInit();
            this.panel_contractos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Numero_Contracto
            // 
            this.Lbl_Numero_Contracto.AutoSize = true;
            this.Lbl_Numero_Contracto.Location = new System.Drawing.Point(797, 59);
            this.Lbl_Numero_Contracto.Name = "Lbl_Numero_Contracto";
            this.Lbl_Numero_Contracto.Size = new System.Drawing.Size(93, 13);
            this.Lbl_Numero_Contracto.TabIndex = 0;
            this.Lbl_Numero_Contracto.Text = "Numero Contracto";
            // 
            // lbl_N_Contracto
            // 
            this.lbl_N_Contracto.AutoSize = true;
            this.lbl_N_Contracto.Location = new System.Drawing.Point(917, 59);
            this.lbl_N_Contracto.Name = "lbl_N_Contracto";
            this.lbl_N_Contracto.Size = new System.Drawing.Size(35, 13);
            this.lbl_N_Contracto.TabIndex = 1;
            this.lbl_N_Contracto.Text = "label1";
            // 
            // panel_botones
            // 
            this.panel_botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_botones.Controls.Add(this.btn_Seleccionar);
            this.panel_botones.Controls.Add(this.btn_Concluido);
            this.panel_botones.Controls.Add(this.btnAgregarP);
            this.panel_botones.Location = new System.Drawing.Point(71, 40);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(349, 60);
            this.panel_botones.TabIndex = 36;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(127, 18);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 20;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // btn_Concluido
            // 
            this.btn_Concluido.Location = new System.Drawing.Point(250, 18);
            this.btn_Concluido.Name = "btn_Concluido";
            this.btn_Concluido.Size = new System.Drawing.Size(75, 23);
            this.btn_Concluido.TabIndex = 19;
            this.btn_Concluido.Text = "Concluido";
            this.btn_Concluido.UseVisualStyleBackColor = true;
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
            // dtgvContracto
            // 
            this.dtgvContracto.AllowUserToAddRows = false;
            this.dtgvContracto.AllowUserToDeleteRows = false;
            this.dtgvContracto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvContracto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvContracto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvContracto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvContracto.Location = new System.Drawing.Point(129, 382);
            this.dtgvContracto.Name = "dtgvContracto";
            this.dtgvContracto.ReadOnly = true;
            this.dtgvContracto.Size = new System.Drawing.Size(798, 217);
            this.dtgvContracto.TabIndex = 37;
            // 
            // panel_contractos
            // 
            this.panel_contractos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_contractos.Controls.Add(this.lbl_Fecha_Termino);
            this.panel_contractos.Controls.Add(this.txt_nombre_obra);
            this.panel_contractos.Controls.Add(this.lbl_Nombre_Obra);
            this.panel_contractos.Controls.Add(this.dateTimePicker1);
            this.panel_contractos.Controls.Add(this.lbl_Buscar);
            this.panel_contractos.Controls.Add(this.txt_Buscar);
            this.panel_contractos.Controls.Add(this.lbl_Fecha_Inicio);
            this.panel_contractos.Controls.Add(this.lbl_Nit);
            this.panel_contractos.Controls.Add(this.dtp_fecha_ini_contracto);
            this.panel_contractos.Controls.Add(this.txt_Nit);
            this.panel_contractos.Controls.Add(this.labelTelefono);
            this.panel_contractos.Controls.Add(this.lbl_encargado);
            this.panel_contractos.Controls.Add(this.labelCorreo);
            this.panel_contractos.Controls.Add(this.txtCorreo);
            this.panel_contractos.Controls.Add(this.txt_Razon_Social);
            this.panel_contractos.Controls.Add(this.txtDireccion);
            this.panel_contractos.Controls.Add(this.txt_encargado);
            this.panel_contractos.Controls.Add(this.Lbl_Razon_social);
            this.panel_contractos.Controls.Add(this.txtTelefono);
            this.panel_contractos.Controls.Add(this.labelDirrecion);
            this.panel_contractos.Location = new System.Drawing.Point(140, 134);
            this.panel_contractos.Name = "panel_contractos";
            this.panel_contractos.Size = new System.Drawing.Size(766, 206);
            this.panel_contractos.TabIndex = 38;
            // 
            // lbl_Fecha_Termino
            // 
            this.lbl_Fecha_Termino.AutoSize = true;
            this.lbl_Fecha_Termino.Location = new System.Drawing.Point(252, 110);
            this.lbl_Fecha_Termino.Name = "lbl_Fecha_Termino";
            this.lbl_Fecha_Termino.Size = new System.Drawing.Size(78, 13);
            this.lbl_Fecha_Termino.TabIndex = 39;
            this.lbl_Fecha_Termino.Text = "Fecha Termino";
            // 
            // txt_nombre_obra
            // 
            this.txt_nombre_obra.Location = new System.Drawing.Point(570, 110);
            this.txt_nombre_obra.Name = "txt_nombre_obra";
            this.txt_nombre_obra.Size = new System.Drawing.Size(152, 20);
            this.txt_nombre_obra.TabIndex = 34;
            // 
            // lbl_Nombre_Obra
            // 
            this.lbl_Nombre_Obra.AutoSize = true;
            this.lbl_Nombre_Obra.Location = new System.Drawing.Point(465, 113);
            this.lbl_Nombre_Obra.Name = "lbl_Nombre_Obra";
            this.lbl_Nombre_Obra.Size = new System.Drawing.Size(96, 13);
            this.lbl_Nombre_Obra.TabIndex = 35;
            this.lbl_Nombre_Obra.Text = "Nombre de la Obra";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(343, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(35, 156);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 33;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(90, 153);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 20);
            this.txt_Buscar.TabIndex = 32;
            // 
            // lbl_Fecha_Inicio
            // 
            this.lbl_Fecha_Inicio.AutoSize = true;
            this.lbl_Fecha_Inicio.Location = new System.Drawing.Point(35, 110);
            this.lbl_Fecha_Inicio.Name = "lbl_Fecha_Inicio";
            this.lbl_Fecha_Inicio.Size = new System.Drawing.Size(65, 13);
            this.lbl_Fecha_Inicio.TabIndex = 37;
            this.lbl_Fecha_Inicio.Text = "Fecha Inicio";
            // 
            // lbl_Nit
            // 
            this.lbl_Nit.AutoSize = true;
            this.lbl_Nit.Location = new System.Drawing.Point(37, 37);
            this.lbl_Nit.Name = "lbl_Nit";
            this.lbl_Nit.Size = new System.Drawing.Size(25, 13);
            this.lbl_Nit.TabIndex = 23;
            this.lbl_Nit.Text = "NIT";
            // 
            // dtp_fecha_ini_contracto
            // 
            this.dtp_fecha_ini_contracto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_ini_contracto.Location = new System.Drawing.Point(117, 104);
            this.dtp_fecha_ini_contracto.Name = "dtp_fecha_ini_contracto";
            this.dtp_fecha_ini_contracto.Size = new System.Drawing.Size(97, 20);
            this.dtp_fecha_ini_contracto.TabIndex = 36;
            // 
            // txt_Nit
            // 
            this.txt_Nit.Location = new System.Drawing.Point(90, 30);
            this.txt_Nit.Name = "txt_Nit";
            this.txt_Nit.Size = new System.Drawing.Size(135, 20);
            this.txt_Nit.TabIndex = 11;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(35, 71);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 30;
            this.labelTelefono.Text = "Telefono";
            // 
            // lbl_encargado
            // 
            this.lbl_encargado.AutoSize = true;
            this.lbl_encargado.Location = new System.Drawing.Point(502, 37);
            this.lbl_encargado.Name = "lbl_encargado";
            this.lbl_encargado.Size = new System.Drawing.Size(59, 13);
            this.lbl_encargado.TabIndex = 29;
            this.lbl_encargado.Text = "Encargado";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(262, 71);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 28;
            this.labelCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(328, 68);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(152, 20);
            this.txtCorreo.TabIndex = 19;
            // 
            // txt_Razon_Social
            // 
            this.txt_Razon_Social.Location = new System.Drawing.Point(328, 30);
            this.txt_Razon_Social.Name = "txt_Razon_Social";
            this.txt_Razon_Social.Size = new System.Drawing.Size(140, 20);
            this.txt_Razon_Social.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(570, 68);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(152, 20);
            this.txtDireccion.TabIndex = 21;
            // 
            // txt_encargado
            // 
            this.txt_encargado.Location = new System.Drawing.Point(570, 30);
            this.txt_encargado.Name = "txt_encargado";
            this.txt_encargado.Size = new System.Drawing.Size(152, 20);
            this.txt_encargado.TabIndex = 14;
            // 
            // Lbl_Razon_social
            // 
            this.Lbl_Razon_social.AutoSize = true;
            this.Lbl_Razon_social.Location = new System.Drawing.Point(252, 37);
            this.Lbl_Razon_social.Name = "Lbl_Razon_social";
            this.Lbl_Razon_social.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Razon_social.TabIndex = 22;
            this.Lbl_Razon_social.Text = "Razon Social";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(90, 68);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // labelDirrecion
            // 
            this.labelDirrecion.AutoSize = true;
            this.labelDirrecion.Location = new System.Drawing.Point(502, 71);
            this.labelDirrecion.Name = "labelDirrecion";
            this.labelDirrecion.Size = new System.Drawing.Size(49, 13);
            this.labelDirrecion.TabIndex = 27;
            this.labelDirrecion.Text = "Dirrecion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearNominaToolStripMenuItem
            // 
            this.crearNominaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNominaToolStripMenuItem1,
            this.verNominaToolStripMenuItem});
            this.crearNominaToolStripMenuItem.Name = "crearNominaToolStripMenuItem";
            this.crearNominaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearNominaToolStripMenuItem.Text = "Nomina";
            this.crearNominaToolStripMenuItem.Click += new System.EventHandler(this.CrearNominaToolStripMenuItem_Click);
            // 
            // crearNominaToolStripMenuItem1
            // 
            this.crearNominaToolStripMenuItem1.Name = "crearNominaToolStripMenuItem1";
            this.crearNominaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.crearNominaToolStripMenuItem1.Text = "Crear Nomina";
            this.crearNominaToolStripMenuItem1.Click += new System.EventHandler(this.CrearNominaToolStripMenuItem1_Click);
            // 
            // verNominaToolStripMenuItem
            // 
            this.verNominaToolStripMenuItem.Name = "verNominaToolStripMenuItem";
            this.verNominaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verNominaToolStripMenuItem.Text = "Ver Nomina";
            // 
            // contronIEToolStripMenuItem
            // 
            this.contronIEToolStripMenuItem.Name = "contronIEToolStripMenuItem";
            this.contronIEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contronIEToolStripMenuItem.Text = "Contron I E";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNominaToolStripMenuItem,
            this.contronIEToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // Frm_Contractos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 627);
            this.Controls.Add(this.panel_contractos);
            this.Controls.Add(this.dtgvContracto);
            this.Controls.Add(this.panel_botones);
            this.Controls.Add(this.lbl_N_Contracto);
            this.Controls.Add(this.Lbl_Numero_Contracto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Contractos";
            this.Text = "CONTRACTOS";
            this.Load += new System.EventHandler(this.Frm_Contractos_Load);
            this.panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContracto)).EndInit();
            this.panel_contractos.ResumeLayout(false);
            this.panel_contractos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Numero_Contracto;
        private System.Windows.Forms.Label lbl_N_Contracto;
        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Concluido;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Panel panel_contractos;
        private System.Windows.Forms.Label lbl_Buscar;
        public System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Nit;
        public System.Windows.Forms.TextBox txt_Nit;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label lbl_encargado;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txt_Razon_Social;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txt_encargado;
        private System.Windows.Forms.Label Lbl_Razon_social;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelDirrecion;
        private System.Windows.Forms.TextBox txt_nombre_obra;
        private System.Windows.Forms.Label lbl_Nombre_Obra;
        private System.Windows.Forms.DateTimePicker dtp_fecha_ini_contracto;
        private System.Windows.Forms.DataGridView dtgvContracto;
        private System.Windows.Forms.Label lbl_Fecha_Termino;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Fecha_Inicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNominaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contronIEToolStripMenuItem;
    }
}