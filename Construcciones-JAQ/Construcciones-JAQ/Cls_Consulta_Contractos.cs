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



        private int cedua;
        private string nombre;
        private int telefono;
        private DateTime fecha_nacimiento;
        private string estado_civil;
        private string correo;
        private string direccion;
        private int hijos;
        private string contraseña;
        private string confirmar_contraseña;
        private string tipo_usuario;

        private string area;


        public int Cedua { get => cedua; set => cedua = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Hijos { get => hijos; set => hijos = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Area { get => area; set => area = value; }
        public string Confirmar_contraseña { get => confirmar_contraseña; set => confirmar_contraseña = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }



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
