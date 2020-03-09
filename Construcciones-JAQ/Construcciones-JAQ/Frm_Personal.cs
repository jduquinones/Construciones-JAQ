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
    public partial class Frm_Personal : Form 
    {
        Cls_Consulta_Personal consulta;
        Cls_Consulta_Validaciones validacion;


        public Frm_Personal()
        {
            InitializeComponent();            
        }

        private void FormRegistroPersonal_Load_1(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Personal();
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
            consulta = new Cls_Consulta_Personal();
            validacion = new Cls_Consulta_Validaciones();
            consulta.agregar(Convert.ToInt32(txtCedulaP.Text), txtNombreP.Text, txtApellidoP.Text, Convert.ToInt64(txtTelefonoP.Text), Convert.ToInt64(txtSalarioP.Text), txtCorreoP.Text, txtDireccionP.Text, dtp_Fecha_Nacimiento.Value, cmb_Estado_civil.Text, cmb_hijos.Text, cmb_Eps.Text, cmb_Arl.Text, cmb_Obra_agsinado.Text );
            consulta.ver(dtgvPersonal);
            validacion.limpiar_campos(panel_personal);
            txt_Edad.Text = Convert.ToString(consulta.valor_edad(dtp_Fecha_Nacimiento.Value));
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            consulta.eliminar(Convert.ToInt32(txtCedulaP.Text));
            consulta.ver(dtgvPersonal);
            validacion.limpiar_campos(panel_personal);
        }

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {
            consulta.seleccionar();
        }

        private void Panel_personal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
