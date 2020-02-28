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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_contracto = new System.Windows.Forms.Button();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(248, 456);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(163, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_contracto
            // 
            this.btn_contracto.Location = new System.Drawing.Point(129, 105);
            this.btn_contracto.Name = "btn_contracto";
            this.btn_contracto.Size = new System.Drawing.Size(96, 67);
            this.btn_contracto.TabIndex = 9;
            this.btn_contracto.Text = "CONTRACTO";
            this.btn_contracto.UseVisualStyleBackColor = true;
            this.btn_contracto.Click += new System.EventHandler(this.Btn_contracto_Click);
            // 
            // btn_Personal
            // 
            this.btn_Personal.Location = new System.Drawing.Point(12, 105);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(96, 67);
            this.btn_Personal.TabIndex = 8;
            this.btn_Personal.Text = "PERSONAL";
            this.btn_Personal.UseVisualStyleBackColor = true;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(72, 40);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(95, 13);
            this.lbl_Usuario.TabIndex = 7;
            this.lbl_Usuario.Text = "Nombre Logueado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(267, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 269);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(739, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_contracto);
            this.Controls.Add(this.btn_Personal);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.splitter1);
            this.Name = "Frm_Menu";
            this.Text = "MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_contracto;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}