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
    class Cls_Consulta_sql
    {
        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;
  
        //ver registros
        public void ver(DataGridView dgv)
        {
            cn.Open();
            try
            {
                da = new SqlDataAdapter("select * from Personal", cn);
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

        //buscar por cedula
        public void buscarporid(DataGridView dgv, string buscar)
        {
            cn.Open();
            string info = "INFO";
            try
            {
                cm = new SqlCommand();
                cm = cn.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Personal where Id_Personal like ('" + buscar + "%') or Nombre like ('" + buscar + "%') or Apellido like ('" + buscar + "%')";
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

        //agregar personal
        public void agregar(Int32 cedula, string nombre, string apellido, Int64 telefono, decimal salario, string correo, string direccion)
        {
            cn.Open();
            string agregado = "Datos agregados correctamente";            
            try
            {                
                cm = new SqlCommand("insert into Personal(Id_Personal, Nombre, Apellido, Telefono, Salario, Correo, Direccion) values (@Id_Personal, @Nombre, @Apellido, @Telefono, @Salario, @Correo, @Direccion)", cn); 
                cm.Parameters.AddWithValue("@Id_Personal", Convert.ToInt32(cedula));
                cm.Parameters.AddWithValue("@Nombre", nombre);
                cm.Parameters.AddWithValue("@Apellido", apellido);
                cm.Parameters.AddWithValue("@Telefono", Convert.ToInt64(telefono));
                cm.Parameters.AddWithValue("@Salario", Convert.ToDecimal(salario));
                cm.Parameters.AddWithValue("@Correo", correo);
                cm.Parameters.AddWithValue("@Direccion", direccion);
                cm.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                agregado = "no se agrego: " + ex.ToString();
            }
            cn.Close();            
        }

        public void eliminar(Int32 cedula)
        {           
            cn.Open();
            string agregado = "Datos agregados correctamente";
            try
            {
                cm = new SqlCommand("delete from  Personal where  Id_Personal = @Id_Personal", cn);                
                cm.Parameters.AddWithValue("@Id_Personal", Convert.ToInt32(cedula));                
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
