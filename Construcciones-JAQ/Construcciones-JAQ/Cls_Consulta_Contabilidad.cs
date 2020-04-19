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
    class Cls_Consulta_Contabilidad
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;
        SqlDataReader dr;

        decimal engresos;
        decimal egresos;
        DateTime fecha;
        decimal saldo;
        string descripcion;

        public decimal Engresos { get => engresos; set => engresos = value; }
        public decimal Egresos { get => egresos; set => egresos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        public void control_i_e(DataGridView dgv)
        {
            cn.Open();
            try
            {
                da = new SqlDataAdapter("select * from Control_I_E", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llamar al datagridviw", ex.ToString());
            }
            cn.Close();


        }




    }
}
