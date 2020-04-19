using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Construcciones_JAQ
{
    public partial class Frm_Login : Form
    {
        Cls_Consulta_Usuarioa consulta;
        Cls_Consulta_Validaciones validaciones;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Apcetar_login_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = new Cls_Consulta_Usuarioa();
                validaciones = new Cls_Consulta_Validaciones();
                consulta.login(Convert.ToInt32(txt_usuario.Text), txt_contraseña.Text);
                validaciones.limpiar_campos(panel_Login);
                this.txt_usuario.Focus();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llamar al datagridviw", ex.ToString());

            }
        }

        private void Btn_cancelar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
