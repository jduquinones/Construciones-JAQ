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
        public Frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");

        public void logear(string usuario, string contraseña)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Login where Usuario = @usuario and Contraseña = @contraseña", cn);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contraseña", contraseña);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count==1)
                {
                    //limpiadores provicional, en este espacio va una objeto de la clase validar
                    this.txt_usuario.Clear();
                    this.txt_contraseña.Clear();

                    this.Hide();
                    new Frm_Menu().Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    this.txt_usuario.Clear();
                    this.txt_contraseña.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                    
            }

            finally
            {
                cn.Close();
            }
        }

        private void Btn_Apcetar_login_Click(object sender, EventArgs e)
        {
            logear(this.txt_usuario.Text, this.txt_contraseña.Text);
        }

        private void Btn_cancelar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
