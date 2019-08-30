using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;


namespace Construcciones_JAQ
{
    public class ClsSql
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public void conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
                cn.Open();
                MessageBox.Show("La conexion se realizo con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de dato" + ex.ToString());
            }

        }








    }
}
