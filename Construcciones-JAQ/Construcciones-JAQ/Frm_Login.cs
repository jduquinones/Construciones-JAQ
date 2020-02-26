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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Apcetar_login_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
            SqlDataReader dr;
            DataTable dt;
            SqlCommand cm;
            SqlDataAdapter da;

        }

        private void Lbl_construccionesjaq_Click(object sender, EventArgs e)
        {

        }
    }
}
