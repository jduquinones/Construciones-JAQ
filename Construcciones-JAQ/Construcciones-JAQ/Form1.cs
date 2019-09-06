using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
 





namespace Construcciones_JAQ
{
    public partial class FormRegistroPersonal : Form 
    {
        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");

        public FormRegistroPersonal()
        {
            InitializeComponent();
        }
       

        // agrga datos al datagridviw
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            //Adicionar Nuevo Renglon
            int n = dtgvPersonal.Rows.Add();

            //Limpia el datagridviw 
            dtgvPersonal.Rows.Clear();

            //ingresar informacion
            dtgvPersonal.Rows[n].Cells[0].Value = txtCedulaP.Text;
            dtgvPersonal.Rows[n].Cells[1].Value = txtNombreP.Text;
            dtgvPersonal.Rows[n].Cells[2].Value = txtApellidoP.Text;
            dtgvPersonal.Rows[n].Cells[3].Value = txtTelefonoP.Text;
            dtgvPersonal.Rows[n].Cells[4].Value = txtSalarioP.Text;
            dtgvPersonal.Rows[n].Cells[5].Value = txtCorreoP.Text;
            dtgvPersonal.Rows[n].Cells[6].Value = txtDireccionP.Text;

            //limpiar los textbox
            txtCedulaP.Text = "";
            txtNombreP.Text = "";
            txtApellidoP.Text = "";
            txtTelefonoP.Text = "";
            txtSalarioP.Text = "";
            txtCorreoP.Text = "";
            txtDireccionP.Text = "";
        }
       
        // elimina una fila en datagridviw
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtgvPersonal.Rows.Remove(dtgvPersonal.CurrentRow);
        }

      
        // extrae los datos del sql
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Personal", cn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            ad.Fill(tabla);
            dtgvPersonal.DataSource = tabla;

        }

        //los datos del datagridviw los envia al sql
        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {            
            SqlCommand agregarbd = new SqlCommand("INSERT INTO Personal (Id_personal, Nombre, Apellido," +
                "Telefono, Salario, Correo, Direccion) VALUES (@CedulaP, @Nombre, @Apellido, " +
            "@Telefono, @Salario, @Correo, @Direccion)", cn);
            cn.Open();

            try
            {
                foreach (DataGridViewRow row in dtgvPersonal.Rows)
                {                    
                    agregarbd.Parameters.Clear();
                    agregarbd.Parameters.AddWithValue("@CedulaP", Convert.ToInt32(row.Cells["CedulaP"].Value));
                    agregarbd.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["NombreP"].Value));
                    agregarbd.Parameters.AddWithValue("@Apellido", Convert.ToString(row.Cells["ApellidoP"].Value));
                    agregarbd.Parameters.AddWithValue("@Telefono", Convert.ToInt64(row.Cells["TelefonoP"].Value));
                    agregarbd.Parameters.AddWithValue("@Salario", Convert.ToInt64(row.Cells["SalarioP"].Value));
                    agregarbd.Parameters.AddWithValue("@Correo", Convert.ToString(row.Cells["CorreoP"].Value));
                    agregarbd.Parameters.AddWithValue("@Direccion", Convert.ToString(row.Cells["DireccionP"].Value));

                    agregarbd.ExecuteNonQuery();
                }
                MessageBox.Show("Datos agregados");
                //limpia las filas del datagridviw
                dtgvPersonal.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar" + ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
