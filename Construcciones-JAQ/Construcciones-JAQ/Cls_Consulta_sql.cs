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
                cm.CommandText = "select * from Personal where Nombre like ('" + buscar + "%')";
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
    }
}
