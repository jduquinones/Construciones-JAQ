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
    public partial class Frm_Usuarios : Form
    {
        Cls_Consulta_Usuarioa consulta;
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

      
        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Usuarioa();
            consulta.ver_usuarios_ingresados(dgv_Registro_usuario);

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Usuarioa();
            consulta.eliminar_usuarios_ingresados(Convert.ToInt32(txt_Cedula.Text));
            consulta.ver_usuarios_ingresados(dgv_Registro_usuario);
        }

        private void Btn_Agregar_Usuario_Click(object sender, EventArgs e)
        {
            consulta.agregar_usuario_login(Convert.ToInt32(txt_Cedula.Text), txt_Nombre.Text, Convert.ToString(cmb_Area.SelectedItem), txt_Contraseña.Text, txt_Confirmar_Contraseña.Text, Convert.ToString(cmb_Tpo_Usuario.SelectedItem));

            // va el metodo limpiar
            txt_Cedula.Text = "";
            txt_Nombre.Text = "";
            cmb_Area.SelectedItem = null;
            txt_Contraseña.Text = "";
            txt_Confirmar_Contraseña.Text = "";
            cmb_Tpo_Usuario = null;
        }
    }
}
