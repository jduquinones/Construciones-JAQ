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
    class Cls_Consulta_Personal
    {
        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;
               

        private int cedula;
        private string nombre;
        private string apellido;
        private int edad;
        private Int64 telefono;
        private DateTime fecha_nacimiento;
        private string estado_civil;
        private string correo;
        private string direccion;
        private string hijos;
        private string eps;
        private string arl;
        private string obra_agsinado;
        private Int64 salario;

               
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public Int64 Telefono { get => telefono; set => telefono = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Hijos { get => hijos; set => hijos = value; }
        public string Eps { get => eps; set => eps = value; }
        public string Arl { get => arl; set => arl = value; }
        public string Obra_agsinado { get => obra_agsinado; set => obra_agsinado = value; }
        public Int64 Salario { get => salario; set => salario = value; }




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
            Cedula = Convert.ToInt32(buscar);
            Nombre = buscar;
            Apellido = buscar;

            cn.Open();
            string info = "INFO";
            try
            {
                cm = new SqlCommand();
                cm = cn.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Personal where Cedula like ('" + Cedula + "%') or Nombre like ('" + Nombre + "%') or Apellido like ('" + Apellido + "%')";
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
        public void agregar(Int32 cedula, string nombre, string apellido, Int64 telefono, Int64 salario, string correo, string direccion, DateTime fecha_nacimiento, string estado_civil, string hijos, string eps, string arl, string obra_agsinado)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Salario = salario;
            Correo = correo;
            Direccion = direccion;
            Fecha_nacimiento = fecha_nacimiento;
            Estado_civil = estado_civil;
            Hijos = hijos;
            Eps = eps;
            Arl = arl;
            Obra_agsinado = obra_agsinado;      


        cn.Open();

            try
            {                
                cm = new SqlCommand("insert into Personal(Cedula, Nombre, Apellido, Telefono, Salario, Correo, Direccion, Fecha_Nacimiento, Estado_Civil, Hijos, EPS, ARL, Obra_Agsinado) values (@Cedula, @Nombre, @Apellido, @Telefono, @Salario, @Correo, @Direccion, @Fecha_Nacimiento, @Estado_Civil, @Hijos, @EPS, @ARL, @Obra_Agsinado)", cn); 
                cm.Parameters.AddWithValue("@Cedula", Cedula);
                cm.Parameters.AddWithValue("@Nombre", Nombre);
                cm.Parameters.AddWithValue("@Apellido", Apellido);
                cm.Parameters.AddWithValue("@Telefono", Telefono);
                cm.Parameters.AddWithValue("@Salario", Salario);
                cm.Parameters.AddWithValue("@Correo", Correo);
                cm.Parameters.AddWithValue("@Direccion", Direccion);
                cm.Parameters.AddWithValue("@Fecha_Nacimiento", Fecha_nacimiento);
                cm.Parameters.AddWithValue("@Estado_Civil", Estado_civil);
                cm.Parameters.AddWithValue("@Hijos", Hijos);
                cm.Parameters.AddWithValue("@EPS", Eps);
                cm.Parameters.AddWithValue("@ARL", Arl);
                cm.Parameters.AddWithValue("@Obra_Agsinado", Obra_agsinado);
                cm.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se agrego: " + ex.ToString());
            }
            cn.Close();            
        }

        public void eliminar(Int32 cedula)
        {           
            cn.Open();
            try
            {
                cm = new SqlCommand("delete from  Personal where  Cedula = @Cedula", cn);                
                cm.Parameters.AddWithValue("@Cedula", Convert.ToInt32(cedula));                
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se elimino: " + ex.ToString());
            }
            cn.Close();            
        }

        public void seleccionar()
        {
            cm = new SqlCommand(string.Format("select * from  Personal where  Cedula = @Cedula"),cn);
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                Frm_Personal seleccionar = new Frm_Personal();
                seleccionar.txtCedulaP.Text = Convert.ToString(dr.GetInt32(0));
                
            }
        }
        
        public int valor_edad(DateTime fecha_nacimiento)
        {
            Fecha_nacimiento = fecha_nacimiento;

            if (Fecha_nacimiento.Year == DateTime.Today.Year)
            {
                return (0);
            }
            else
            {
                return 1 + valor_edad(Fecha_nacimiento.AddYears(1));
            }


        }
    }
}
