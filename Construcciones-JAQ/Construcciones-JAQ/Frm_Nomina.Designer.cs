namespace Construcciones_JAQ
{
    partial class Frm_Nomina
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Nomina_Obra = new System.Windows.Forms.Button();
            this.btn_Control_Ingresos_Egresos = new System.Windows.Forms.Button();
            this.btn_Nomina_Total = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Control_I_E = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Control_I_E)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 67);
            this.button1.TabIndex = 13;
            this.button1.Text = "NOMINA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Nomina_Obra
            // 
            this.btn_Nomina_Obra.Location = new System.Drawing.Point(57, 149);
            this.btn_Nomina_Obra.Name = "btn_Nomina_Obra";
            this.btn_Nomina_Obra.Size = new System.Drawing.Size(96, 34);
            this.btn_Nomina_Obra.TabIndex = 15;
            this.btn_Nomina_Obra.Text = "Nomina por Obra";
            this.btn_Nomina_Obra.UseVisualStyleBackColor = true;
            // 
            // btn_Control_Ingresos_Egresos
            // 
            this.btn_Control_Ingresos_Egresos.Location = new System.Drawing.Point(57, 85);
            this.btn_Control_Ingresos_Egresos.Name = "btn_Control_Ingresos_Egresos";
            this.btn_Control_Ingresos_Egresos.Size = new System.Drawing.Size(96, 27);
            this.btn_Control_Ingresos_Egresos.TabIndex = 14;
            this.btn_Control_Ingresos_Egresos.Text = "Control I E";
            this.btn_Control_Ingresos_Egresos.UseVisualStyleBackColor = true;
            this.btn_Control_Ingresos_Egresos.Click += new System.EventHandler(this.Btn_Control_Ingresos_Egresos_Click);
            // 
            // btn_Nomina_Total
            // 
            this.btn_Nomina_Total.Location = new System.Drawing.Point(57, 17);
            this.btn_Nomina_Total.Name = "btn_Nomina_Total";
            this.btn_Nomina_Total.Size = new System.Drawing.Size(89, 29);
            this.btn_Nomina_Total.TabIndex = 12;
            this.btn_Nomina_Total.Text = "Nomina Total";
            this.btn_Nomina_Total.UseVisualStyleBackColor = true;
            this.btn_Nomina_Total.Click += new System.EventHandler(this.Btn_Control_Nomina_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Nomina_Obra);
            this.panel1.Controls.Add(this.btn_Control_Ingresos_Egresos);
            this.panel1.Controls.Add(this.btn_Nomina_Total);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 332);
            this.panel1.TabIndex = 16;
            // 
            // dgv_Control_I_E
            // 
            this.dgv_Control_I_E.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Control_I_E.Location = new System.Drawing.Point(261, 119);
            this.dgv_Control_I_E.Name = "dgv_Control_I_E";
            this.dgv_Control_I_E.Size = new System.Drawing.Size(783, 274);
            this.dgv_Control_I_E.TabIndex = 17;
            // 
            // Frm_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 527);
            this.Controls.Add(this.dgv_Control_I_E);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Nomina";
            this.Text = "Frm_Nomina";
            this.Load += new System.EventHandler(this.Frm_Nomina_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Control_I_E)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Nomina_Obra;
        private System.Windows.Forms.Button btn_Control_Ingresos_Egresos;
        private System.Windows.Forms.Button btn_Nomina_Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Control_I_E;
    }
}