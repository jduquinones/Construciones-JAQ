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

        SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");     
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;


        private int nit;
        private string razon_social;
        private string encargado;
        private Int64 telefono;
        private DateTime fecha_Inicial;
        private string correo;
        private string direccion;
        private string mano_obra;
        private int n_contracto;


        public int Nit { get => nit; set => nit = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public DateTime Fecha_Inicial { get => fecha_Inicial; set => fecha_Inicial = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Mano_obra { get => mano_obra; set => mano_obra = value; }
        public int N_contracto { get => n_contracto; set => n_contracto = value; }
        



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
        public void agregar(Int32 nit, string razon_social, string encargado, Int64 telefono, DateTime fecha_inicial, string correo, string direccion, string mano_obra, int n_contracto)
        {
            Nit = nit;         
            Razon_social= razon_social;
            Encargado= encargado;
            Telefono =telefono;
            Fecha_Inicial = fecha_inicial;
            Correo = correo;
            Direccion = direccion;
            Mano_obra = mano_obra;
            N_contracto = n_contracto;


        cn.Open();
            string agregado = "Datos agregados correctamente";
            try
            {
                cm = new SqlCommand("insert into Contracto (Nit, Razon_Social, Encargado, Telefono, Fecha_Inicial, Correo, Direccion, Mano_obra, N_contracto)" +
                    " values (@Nit, @Razon_Social, @Encargado, @Telefono, @Fecha_Inicial, @Correo, @Direccion, @Mano_obra, @N_contracto)", cn);
                cm.Parameters.AddWithValue("@Nit", Nit);
                cm.Parameters.AddWithValue("@Razon_Social", Razon_social);
                cm.Parameters.AddWithValue("@Encargado", Encargado);
                cm.Parameters.AddWithValue("@Telefono", Telefono);
                cm.Parameters.AddWithValue("@Fecha_Inicial", Fecha_Inicial);
                cm.Parameters.AddWithValue("@Correo", Correo);
                cm.Parameters.AddWithValue("@Direccion", Direccion);
                cm.Parameters.AddWithValue("@Mano_obra", Mano_obra);
                cm.Parameters.AddWithValue("@N_contracto", N_contracto);

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
