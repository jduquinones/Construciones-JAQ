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
    public partial class Frm_Usuario : Form
    {
        Cls_Usuarios consulta;

        public Frm_Usuario()
        {
            InitializeComponent();
        }
        private void Frm_Usuario_Load_1(object sender, EventArgs e)
        {
            consulta = new Cls_Usuarios();
            consulta.ver(dgv_Usuario);
        }

        private void Txt_Buscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                consulta.ver(dgv_Usuario);
            }
            else
            {
                consulta.buscarporid(dgv_Usuario, txt_Buscar.Text);
            }
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            consulta = new Cls_Usuarios();
            consulta.agregar(Convert.ToInt32(txt_Cedula_Usuario.Text), txt_Contraseña_Usuario.Text, txt_Nombre_Usuario.Text, Convert.ToString(cmb_Area.SelectedItem), Convert.ToString(Cmb_Tipo_Usuario.SelectedItem));
            consulta.ver(dgv_Usuario);
            txt_Cedula_Usuario.Text = "";
            txt_Nombre_Usuario.Text = "";
            txt_Contraseña_Usuario.Text = "";
            cmb_Area.SelectedItem = null;
            Cmb_Tipo_Usuario.SelectedItem = null;
        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            consulta = new Cls_Usuarios();
            consulta.eliminar(Convert.ToInt32(txt_Cedula_Usuario.Text));
            consulta.ver(dgv_Usuario);
            txt_Cedula_Usuario.Text = "";
            txt_Nombre_Usuario.Text = "";
            txt_Contraseña_Usuario.Text = "";            
            cmb_Area.SelectedItem = null;
            Cmb_Tipo_Usuario.SelectedItem = null;
        }

        private void Cmb_Tipo_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
