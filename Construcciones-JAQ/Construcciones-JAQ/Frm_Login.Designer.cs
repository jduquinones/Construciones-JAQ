namespace Construcciones_JAQ
{
    partial class Frm_Login
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
            this.btn_Apcetar_login = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_INGRESO = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_construccionesjaq = new System.Windows.Forms.Label();
            this.btn_cancelar_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Apcetar_login
            // 
            this.btn_Apcetar_login.Location = new System.Drawing.Point(46, 288);
            this.btn_Apcetar_login.Name = "btn_Apcetar_login";
            this.btn_Apcetar_login.Size = new System.Drawing.Size(75, 23);
            this.btn_Apcetar_login.TabIndex = 0;
            this.btn_Apcetar_login.Text = "APCETAR";
            this.btn_Apcetar_login.UseVisualStyleBackColor = true;
            this.btn_Apcetar_login.Click += new System.EventHandler(this.Btn_Apcetar_login_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(86, 160);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(121, 20);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(86, 242);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(121, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // lbl_INGRESO
            // 
            this.lbl_INGRESO.AutoSize = true;
            this.lbl_INGRESO.Location = new System.Drawing.Point(124, 41);
            this.lbl_INGRESO.Name = "lbl_INGRESO";
            this.lbl_INGRESO.Size = new System.Drawing.Size(59, 13);
            this.lbl_INGRESO.TabIndex = 4;
            this.lbl_INGRESO.Text = "INGRESO ";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(124, 144);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(56, 13);
            this.lbl_usuario.TabIndex = 5;
            this.lbl_usuario.Text = "USUARIO";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(112, 206);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(81, 13);
            this.lbl_contraseña.TabIndex = 6;
            this.lbl_contraseña.Text = "CONTRASEÑA";
            // 
            // lbl_construccionesjaq
            // 
            this.lbl_construccionesjaq.AutoSize = true;
            this.lbl_construccionesjaq.Location = new System.Drawing.Point(83, 69);
            this.lbl_construccionesjaq.Name = "lbl_construccionesjaq";
            this.lbl_construccionesjaq.Size = new System.Drawing.Size(136, 13);
            this.lbl_construccionesjaq.TabIndex = 7;
            this.lbl_construccionesjaq.Text = "CONSTRUCCIONES J A Q";
            this.lbl_construccionesjaq.Click += new System.EventHandler(this.Lbl_construccionesjaq_Click);
            // 
            // btn_cancelar_login
            // 
            this.btn_cancelar_login.Location = new System.Drawing.Point(166, 288);
            this.btn_cancelar_login.Name = "btn_cancelar_login";
            this.btn_cancelar_login.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_login.TabIndex = 8;
            this.btn_cancelar_login.Text = "CANCELAR";
            this.btn_cancelar_login.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 372);
            this.Controls.Add(this.btn_cancelar_login);
            this.Controls.Add(this.lbl_construccionesjaq);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_INGRESO);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_Apcetar_login);
            this.Name = "Frm_Login";
            this.Text = "INGRESO USUARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Apcetar_login;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_INGRESO;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_construccionesjaq;
        private System.Windows.Forms.Button btn_cancelar_login;
    }
}