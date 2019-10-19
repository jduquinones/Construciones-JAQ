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
        SqlDataReader dr;
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds;
  
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
        public void filtrar(DataGridView dgv, string buscar)
        {
            cn.Open();
            string info = "INFO";
            try
            {
                cm = new SqlCommand();
                cm = cn.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Personal where Id_Personal like ('" + buscar + "%') OR Nombre like ('" + buscar + "%') OR Apellido like ('" + buscar + "%')";
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
        public string agregar(Int64 cedula, string nombre, string apellido, Int64 telefono, decimal salario, string correo, string direccion)
        {
            cn.Open();
            string agregado = "Datos agregados correctamente";            
            try
            {                
                cm = new SqlCommand("insert into Personal(Id_Personal, Nombre, Apellido, Telefono, Salario, Correo, Direccion) values (" + cedula + ",'"+ nombre + "','"+ apellido + "',"+ telefono + ","+salario+",'"+ correo + "','"+ direccion + "')", cn);
                cm.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                agregado = "no se agrego: " + ex.ToString();
            }
            cn.Close();
            return agregado;
        }

        //valida que los datos no se rrepitan
        public int validaregistro(int cedula)
        {
            cn.Open();
            int contador = 0;
            try
            {                
                cm = new SqlCommand("select * from Personal where Id_personal="+cedula+"", cn);
                dr=cm.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la consulta", ex.ToString());
            }
            cn.Close();
            return contador;

        }

        public void eliminar(DataGridView dgv, string buscar)
        {
            string seleccionar = "Se actualizo";
            cn.Open();
            try
            {
                dgv.Columns.Clear();
                DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                check.HeaderText = "Seleccionar";
                check.Name = "dgv_Seleccionar";
                check.Width = 60;
                dgv.Columns.Add(check);
                dgv.Columns[dgv.Columns.Count - 1].DisplayIndex = 0;
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Refresh();

                ver(dgv);
                filtrar(dgv, buscar);

            }
            catch (Exception ex)
            {
                seleccionar = "No se pudo actualizar"+ ex.ToString();
            }
            cn.Close();
        }

        public void modificar(Int32 cedula, string nombre, string apellido, Int64 telefono, Int64 salario, string correo, string direccion)
        {
            string fallido="Fallo al cargar el dgv";
            try
            {
                string query = "update Personal set Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Salario = @salario, Correo = @correo, Direccion = @direccion, where Id_Personal = @cedula";
                cn.Open();
                cm = new SqlCommand(query,cn);
                cm.Parameters.AddWithValue("@nombre", nombre);
                cm.Parameters.AddWithValue("@apellido", apellido);
                cm.Parameters.AddWithValue("@telefono", telefono);
                cm.Parameters.AddWithValue("@salario", salario);
                cm.Parameters.AddWithValue("@correo", correo);
                cm.Parameters.AddWithValue("@direccion", direccion);
                cm.Parameters.AddWithValue("@cedula", cedula);

                cm.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados con exito");
            }
            catch (Exception ex)
            {
                fallido = "No se pudo cargar los datos" + ex.ToString();
            }
            cn.Close();            
        }

    }
}
