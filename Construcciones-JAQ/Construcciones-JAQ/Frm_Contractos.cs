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
        int ncontracto = 0;
        
        Cls_Consulta_Contractos ConsultaContracto;
        Cls_Consulta_Validaciones validaciones;


        public Frm_Contractos()
        {
            InitializeComponent();
        }            

        private void Frm_Contractos_Load(object sender, EventArgs e)
        {
            ConsultaContracto = new Cls_Consulta_Contractos();
            ConsultaContracto.ver(dtgvContracto);
            int contador = ncontracto + 1;
            lbl_N_Contracto.Text = Convert.ToString(contador);
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            ConsultaContracto = new Cls_Consulta_Contractos();
            validaciones = new Cls_Consulta_Validaciones();

           
            

            ConsultaContracto.agregar(Convert.ToInt32(txt_Nit.Text), txt_Razon_Social.Text, txt_encargado.Text, Convert.ToInt64(txtTelefono.Text),
                Convert.ToDateTime(dtp_fecha_ini_contracto.Value), txtCorreo.Text, txtDireccion.Text, txt_nombre_obra.Text, Convert.ToInt32(lbl_N_Contracto.Text));

            ConsultaContracto.ver(dtgvContracto);
            validaciones.limpiar_campos(panel_contractos);

            
            

        }

        private void CrearNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CrearNominaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
