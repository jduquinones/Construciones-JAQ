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
    class Cls_Consulta_Contractos
    {

        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");     
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;

        //ver Contractos
        public void ver(DataGridView dgv)
        {
            cn.Open();
            try
            {
                da = new SqlDataAdapter("select * from Contracto", cn);
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

        //buscar por Nit
        public void buscarporid(DataGridView dgv, string buscar)
        {
            cn.Open();
            string info = "INFO";
            try
            {
                cm = new SqlCommand();
                cm = cn.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Contracto where NIt like ('" + buscar + "%') or Razon_Social like ('" + buscar + "%')";
                cm.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cm);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                info = ("No se pudo llamar al datagridviw" + ex.ToString());
            }
            cn.Close();

        }

        //agregar Contracto
        public void agregar(Int32 Nit, string Razon_Social, string Encargado, Int64 telefono, DateTime Fecha_Inicial, string correo, string direccion, string mano_obra)
        {
            cn.Open();
            string agregado = "Datos agregados correctamente";
            try
            {
                cm = new SqlCommand("insert into Contracto(Nit, Razon_Social, Encargado, Telefono, Fecha_Inicial, Correo, Direccion, mano_obra) values (@Nit, @Razon_Social, @Encargado, @Telefono, @Fecha_Inicial, @Correo, @Direccion, @mano_obra)", cn);
                cm.Parameters.AddWithValue("@Nit", Convert.ToInt32(Nit));
                cm.Parameters.AddWithValue("@Razon_Social", Razon_Social);
                cm.Parameters.AddWithValue("@Encargado", Encargado);
                cm.Parameters.AddWithValue("@Telefono", Convert.ToInt64(telefono));
                cm.Parameters.AddWithValue("@Fecha_Inicial", Convert.ToDateTime(Fecha_Inicial));
                cm.Parameters.AddWithValue("@Correo", correo);
                cm.Parameters.AddWithValue("@Direccion", direccion);
                cm.Parameters.AddWithValue("@mano_obra", mano_obra);

                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                agregado = "no se agrego: " + ex.ToString();
            }
            cn.Close();
        }

        // ELiminar Contracto
        public void eliminar(Int32 cedula)
        {
            cn.Open();
            string agregado = "Datos agregados correctamente";
            try
            {
                cm = new SqlCommand("delete from  Contracto where  Nit = @Nit", cn);
                cm.Parameters.AddWithValue("@Nit", Convert.ToInt32(cedula));
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                agregado = "no se agrego: " + ex.ToString();
            }
            cn.Close();
        }
    }
}
