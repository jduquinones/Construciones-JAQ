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
    class Cls_Consulta_Usuarioa
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");
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

        public void login(int cedula, string contraseña)
        {
            Cedua = cedula;
            Contraseña = contraseña;
            try
            {
                cn.Open();
                cm = new SqlCommand("select  Usuario, Contraseña from Usuarios where Usuario = @usuario  and Contraseña = @Contraseña", cn);
                cm.Parameters.AddWithValue("@usuario", Cedua);
                cm.Parameters.AddWithValue("@Contraseña", Contraseña);

                da = new SqlDataAdapter(cm);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == Convert.ToString(Cedua) && dt.Rows[0][1].ToString() == Contraseña)
                    {
                        new Frm_Menu().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña invalidos");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());
            }
        }


        public void agregar_usuario_login(int cedula, string nombre, string area, string contraseña1, string contraseña2, string tipo_usuario)
        {
            Cedua = cedula;
            Nombre = nombre;
            Area = area;
            Contraseña = contraseña1;
            confirmar_contraseña = contraseña2;
            Tipo_usuario = tipo_usuario;

            if (Contraseña == Confirmar_contraseña)
            {                
                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert into Usuarios (Usuario, Nombre, Area, Contraseña, Tipo_Usuario) values (@Usuario, @Nombre, @Area, @Contraseña, @Tipo_Usuario)", cn);
                    cm.Parameters.AddWithValue("@Usuario", Cedua);
                    cm.Parameters.AddWithValue("@Nombre", Nombre);
                    cm.Parameters.AddWithValue("@Area", Area);
                    cm.Parameters.AddWithValue("@Contraseña", Contraseña);
                    cm.Parameters.AddWithValue("@Tipo_Usuario", Tipo_usuario);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Se realizo el ingreso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales");                
            }
        }

 
        // Carga el datagridview
        public void ver_usuarios_ingresados(DataGridView dgv_registro_personal)
        {
            try
            {
                da = new SqlDataAdapter("select * from Usuarios", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv_registro_personal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llamar al datagridview" + ex.ToString());

            }
        }

        public void eliminar_usuarios_ingresados(int cedula)
        {
            Cedua = cedula;

            cn.Open();
            try
            {
                cm = new SqlCommand("delete from Usuarios where Usuario = @Usuario", cn);
                cm.Parameters.AddWithValue("@Usuario", Cedua);
                cm.ExecuteNonQuery();

                MessageBox.Show("Registro eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino" + ex.ToString());
            }
        }
    }

}
