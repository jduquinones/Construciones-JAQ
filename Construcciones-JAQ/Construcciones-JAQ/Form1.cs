using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
 

namespace Construcciones_JAQ
{
    public partial class FormRegistroPersonal : Form 
    {
         Cls_Consulta_sql consulta;

        public FormRegistroPersonal()
        {
            InitializeComponent();            
        }

        private void FormRegistroPersonal_Load_1(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_sql();
            consulta.ver(dtgvPersonal);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                consulta.ver(dtgvPersonal);
            }
            else
            {
                consulta.buscarporid(dtgvPersonal, txt_Buscar.Text);
            }
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_sql();
            consulta.agregar(Convert.ToInt32(txtCedulaP.Text), txtNombreP.Text, txtApellidoP.Text, Convert.ToInt64(txtTelefonoP.Text), Convert.ToDecimal(txtSalarioP.Text), txtCorreoP.Text, txtDireccionP.Text);
            consulta.ver(dtgvPersonal);
            txtCedulaP.Text = "";
            txtNombreP.Text = "";
            txtApellidoP.Text = "";
            txtTelefonoP.Text = "";
            txtSalarioP.Text = "";
            txtCorreoP.Text = "";
            txtDireccionP.Text = "";
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            consulta.eliminar(Convert.ToInt32(txtCedulaP.Text));
            consulta.ver(dtgvPersonal);
            txtCedulaP.Text = "";
            txtNombreP.Text = "";
            txtApellidoP.Text = "";
            txtTelefonoP.Text = "";
            txtSalarioP.Text = "";
            txtCorreoP.Text = "";
            txtDireccionP.Text = "";
        }
    }
}
