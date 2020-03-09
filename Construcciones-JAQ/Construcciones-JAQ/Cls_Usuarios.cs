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
    class Cls_Usuarios
    {
        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
        DataTable dt;
        SqlCommand cm;
        SqlDataAdapter da;


        private int usuario_login;
        private string contraseña_login;
        private string nombre_login;
        private string area_login;
        private string tipo_usuario_login;

        public int Usuario_login { get => usuario_login; set => usuario_login = value; }
        public string Contraseña_login { get => contraseña_login; set => contraseña_login = value; }
        public string Nombre_login { get => nombre_login; set => nombre_login = value; }
        public string Area_login { get => area_login; set => area_login = value; }
        public string Tipo_usuario_login { get => tipo_usuario_login; set => tipo_usuario_login = value; }

        // Metodo para ingresar al Login
        public void logear(int usuario, string contraseña)
        {
            Usuario_login = usuario;
            Contraseña_login=contraseña;

            try
            {             
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Usuarios where Usuario = @usuario and Contraseña = @contraseña", cn);
                cmd.Parameters.AddWithValue("usuario", Usuario_login);
                cmd.Parameters.AddWithValue("contraseña", Contraseña_login);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    new Frm_Login().Hide();
                    new Frm_Menu(dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString()).Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                cn.Close();
            }
        }


        // Metodo para ver en el datagridview
        public void ver(DataGridView dgv)
        {
            cn.Open();
            try
            {
                da = new SqlDataAdapter("select * from Usuarios", cn);
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

        // Metodo para buscar por cedula, nombre o apellido
        public void buscarporid(DataGridView dgv, string buscar)
        {
            Usuario_login = Convert.ToInt32(buscar);
            Nombre_login = buscar;

            cn.Open();
            string info = "INFO";
            try
            {
                cm = new SqlCommand();
                cm = cn.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from Usuarios where Usuario like ('" + Usuario_login + "%') or Nombre like ('" + Nombre_login + "%')";
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

        // Metodo agregar personal al datagridview
        public void agregar(int usuario, string contraseña, string nombre, string area, string tipo_usuario)
        {
            Usuario_login = usuario;
            Contraseña_login = contraseña;
            Nombre_login = nombre;
            Area_login = area;
            Tipo_usuario_login = tipo_usuario;


            cn.Open();
            string agregado = "Datos agregados correctamente";
            try
            {
                cm = new SqlCommand("insert into Usuarios (Usuario, Contraseña, Nombre, Area, Tipo_Usuario) values (@Usuario, @Contraseña, @Nombre, @Area, @Tipo_Usuario)", cn);
                cm.Parameters.AddWithValue("@Usuario", Usuario_login);
                cm.Parameters.AddWithValue("@Contraseña", Contraseña_login);
                cm.Parameters.AddWithValue("@Nombre", Nombre_login);                             
                cm.Parameters.AddWithValue("@Area", Area_login);
                cm.Parameters.AddWithValue("@Tipo_Usuario", Tipo_usuario_login);                
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                agregado = "no se agrego: " + ex.ToString();
            }
            cn.Close();
        }

        //Metodo elimina datos del datagridview
        public void eliminar(int usuario)
        {
            Usuario_login = usuario;

            cn.Open();
            string agregado = "Datos agregados correctamente";
            try
            {
                cm = new SqlCommand("delete from  Usuarios where  Usuario = @Usuario", cn);
                cm.Parameters.AddWithValue("@Usuario", Usuario_login);
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



