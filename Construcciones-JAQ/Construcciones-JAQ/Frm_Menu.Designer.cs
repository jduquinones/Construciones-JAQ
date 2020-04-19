namespace Construcciones_JAQ
{
    partial class Frm_Menu
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_contracto = new System.Windows.Forms.Button();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Control_Nomina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(169, 376);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // btn_contracto
            // 
            this.btn_contracto.Location = new System.Drawing.Point(158, 98);
            this.btn_contracto.Name = "btn_contracto";
            this.btn_contracto.Size = new System.Drawing.Size(96, 67);
            this.btn_contracto.TabIndex = 9;
            this.btn_contracto.Text = "CONTRACTO";
            this.btn_contracto.UseVisualStyleBackColor = true;
            this.btn_contracto.Click += new System.EventHandler(this.Btn_contracto_Click);
            // 
            // btn_Personal
            // 
            this.btn_Personal.Location = new System.Drawing.Point(20, 98);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(96, 67);
            this.btn_Personal.TabIndex = 8;
            this.btn_Personal.Text = "PERSONAL";
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.Click += new System.EventHandler(this.Btn_Personal_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(87, 43);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(95, 13);
            this.lbl_Usuario.TabIndex = 7;
            this.lbl_Usuario.Text = "Nombre Logueado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(18, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 269);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestioDeUsuarioToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // gestioDeUsuarioToolStripMenuItem
            // 
            this.gestioDeUsuarioToolStripMenuItem.Name = "gestioDeUsuarioToolStripMenuItem";
            this.gestioDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestioDeUsuarioToolStripMenuItem.Text = "Gestio de Usuario";
            this.gestioDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.GestioDeUsuarioToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Control_Nomina);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Usuario);
            this.splitContainer1.Panel1.Controls.Add(this.btn_contracto);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Salir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Personal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(810, 437);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 13;
            // 
            // btn_Control_Nomina
            // 
            this.btn_Control_Nomina.Location = new System.Drawing.Point(20, 193);
            this.btn_Control_Nomina.Name = "btn_Control_Nomina";
            this.btn_Control_Nomina.Size = new System.Drawing.Size(96, 67);
            this.btn_Control_Nomina.TabIndex = 11;
            this.btn_Control_Nomina.Text = "NOMINA";
            this.btn_Control_Nomina.UseVisualStyleBackColor = true;
            this.btn_Control_Nomina.Click += new System.EventHandler(this.Btn_Control_Nomina_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(851, 513);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_contracto;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Control_Nomina;
    }
}