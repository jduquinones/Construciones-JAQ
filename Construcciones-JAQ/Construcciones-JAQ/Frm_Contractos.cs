using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construcciones_JAQ
{
    public partial class Frm_Contractos : Form
    {

        Cls_Consulta_Contractos ConsultaContracto;


        public Frm_Contractos()
        {
            InitializeComponent();
        }            

        private void Frm_Contractos_Load(object sender, EventArgs e)
        {
            ConsultaContracto = new Cls_Consulta_Contractos();
            ConsultaContracto.ver(dtgvContracto);
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            ConsultaContracto = new Cls_Consulta_Contractos();
            ConsultaContracto.agregar(Convert.ToInt32(txt_Nit.Text), txt_Razon_Social.Text, txt_encargado.Text, Convert.ToInt64(txtTelefono.Text), Convert.ToDateTime(dtp_fecha_ini_contracto.Value), txtCorreo.Text, txtDireccion.Text, txt_nombre_obra.Text);
            ConsultaContracto.ver(dtgvContracto);
            txt_Nit.Text = "";
            txt_Razon_Social.Text = "";
            txt_encargado.Text = "";
            txtTelefono.Text = "";
            dtp_fecha_ini_contracto.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
        }
    }
}
