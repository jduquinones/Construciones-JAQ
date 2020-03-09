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
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Apcetar_login_Click(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Usuarioa();
            consulta.login(Convert.ToInt32(txt_usuario.Text), txt_contraseña.Text);

            limpiar_campos();
            //txt_usuario.Text = "";
            //txt_contraseña.Text = "";               

        }

        private void Btn_cancelar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiar_campos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.txt_usuario.Focus();
                }
            }

        }
    }
}
