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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_Concluido = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.dtgvContracto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_fecha_ini_contracto = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre_obra = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_Obra = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Nit = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContracto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Numero_Contracto
            // 
            this.Lbl_Numero_Contracto.AutoSize = true;
            this.Lbl_Numero_Contracto.Location = new System.Drawing.Point(799, 59);
            this.Lbl_Numero_Contracto.Name = "Lbl_Numero_Contracto";
            this.Lbl_Numero_Contracto.Size = new System.Drawing.Size(93, 13);
            this.Lbl_Numero_Contracto.TabIndex = 0;
            this.Lbl_Numero_Contracto.Text = "Numero Contracto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Seleccionar);
            this.panel2.Controls.Add(this.btn_Concluido);
            this.panel2.Controls.Add(this.btnAgregarP);
            this.panel2.Location = new System.Drawing.Point(71, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 60);
            this.panel2.TabIndex = 36;
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
            this.dtgvContracto.Location = new System.Drawing.Point(179, 314);
            this.dtgvContracto.Name = "dtgvContracto";
            this.dtgvContracto.ReadOnly = true;
            this.dtgvContracto.Size = new System.Drawing.Size(665, 217);
            this.dtgvContracto.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_fecha_ini_contracto);
            this.panel1.Controls.Add(this.txt_nombre_obra);
            this.panel1.Controls.Add(this.lbl_Nombre_Obra);
            this.panel1.Controls.Add(this.lbl_Buscar);
            this.panel1.Controls.Add(this.txt_Buscar);
            this.panel1.Controls.Add(this.lbl_Nit);
            this.panel1.Controls.Add(this.txt_Nit);
            this.panel1.Controls.Add(this.labelTelefono);
            this.panel1.Controls.Add(this.lbl_encargado);
            this.panel1.Controls.Add(this.labelCorreo);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txt_Razon_Social);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txt_encargado);
            this.panel1.Controls.Add(this.Lbl_Razon_social);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.labelDirrecion);
            this.panel1.Location = new System.Drawing.Point(118, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 177);
            this.panel1.TabIndex = 38;
            // 
            // dtp_fecha_ini_contracto
            // 
            this.dtp_fecha_ini_contracto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_ini_contracto.Location = new System.Drawing.Point(78, 148);
            this.dtp_fecha_ini_contracto.Name = "dtp_fecha_ini_contracto";
            this.dtp_fecha_ini_contracto.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha_ini_contracto.TabIndex = 36;
            // 
            // txt_nombre_obra
            // 
            this.txt_nombre_obra.Location = new System.Drawing.Point(610, 111);
            this.txt_nombre_obra.Name = "txt_nombre_obra";
            this.txt_nombre_obra.Size = new System.Drawing.Size(152, 20);
            this.txt_nombre_obra.TabIndex = 34;
            // 
            // lbl_Nombre_Obra
            // 
            this.lbl_Nombre_Obra.AutoSize = true;
            this.lbl_Nombre_Obra.Location = new System.Drawing.Point(505, 114);
            this.lbl_Nombre_Obra.Name = "lbl_Nombre_Obra";
            this.lbl_Nombre_Obra.Size = new System.Drawing.Size(96, 13);
            this.lbl_Nombre_Obra.TabIndex = 35;
            this.lbl_Nombre_Obra.Text = "Nombre de la Obra";
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(75, 110);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_Buscar.TabIndex = 33;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(130, 107);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 20);
            this.txt_Buscar.TabIndex = 32;
            // 
            // lbl_Nit
            // 
            this.lbl_Nit.AutoSize = true;
            this.lbl_Nit.Location = new System.Drawing.Point(77, 38);
            this.lbl_Nit.Name = "lbl_Nit";
            this.lbl_Nit.Size = new System.Drawing.Size(25, 13);
            this.lbl_Nit.TabIndex = 23;
            this.lbl_Nit.Text = "NIT";
            // 
            // txt_Nit
            // 
            this.txt_Nit.Location = new System.Drawing.Point(130, 31);
            this.txt_Nit.Name = "txt_Nit";
            this.txt_Nit.Size = new System.Drawing.Size(135, 20);
            this.txt_Nit.TabIndex = 11;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(75, 72);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 30;
            this.labelTelefono.Text = "Telefono";
            // 
            // lbl_encargado
            // 
            this.lbl_encargado.AutoSize = true;
            this.lbl_encargado.Location = new System.Drawing.Point(542, 38);
            this.lbl_encargado.Name = "lbl_encargado";
            this.lbl_encargado.Size = new System.Drawing.Size(59, 13);
            this.lbl_encargado.TabIndex = 29;
            this.lbl_encargado.Text = "Encargado";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(302, 72);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 28;
            this.labelCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(368, 69);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(152, 20);
            this.txtCorreo.TabIndex = 19;
            // 
            // txt_Razon_Social
            // 
            this.txt_Razon_Social.Location = new System.Drawing.Point(368, 31);
            this.txt_Razon_Social.Name = "txt_Razon_Social";
            this.txt_Razon_Social.Size = new System.Drawing.Size(140, 20);
            this.txt_Razon_Social.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(610, 69);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(152, 20);
            this.txtDireccion.TabIndex = 21;
            // 
            // txt_encargado
            // 
            this.txt_encargado.Location = new System.Drawing.Point(610, 31);
            this.txt_encargado.Name = "txt_encargado";
            this.txt_encargado.Size = new System.Drawing.Size(152, 20);
            this.txt_encargado.TabIndex = 14;
            // 
            // Lbl_Razon_social
            // 
            this.Lbl_Razon_social.AutoSize = true;
            this.Lbl_Razon_social.Location = new System.Drawing.Point(292, 38);
            this.Lbl_Razon_social.Name = "Lbl_Razon_social";
            this.Lbl_Razon_social.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Razon_social.TabIndex = 22;
            this.Lbl_Razon_social.Text = "Razon Social";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 69);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // labelDirrecion
            // 
            this.labelDirrecion.AutoSize = true;
            this.labelDirrecion.Location = new System.Drawing.Point(542, 72);
            this.labelDirrecion.Name = "labelDirrecion";
            this.labelDirrecion.Size = new System.Drawing.Size(49, 13);
            this.labelDirrecion.TabIndex = 27;
            this.labelDirrecion.Text = "Dirrecion";
            // 
            // Frm_Contractos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvContracto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Numero_Contracto);
            this.Name = "Frm_Contractos";
            this.Text = "CONTRACTOS";
            this.Load += new System.EventHandler(this.Frm_Contractos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContracto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Numero_Contracto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Concluido;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Panel panel1;
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
    }
}