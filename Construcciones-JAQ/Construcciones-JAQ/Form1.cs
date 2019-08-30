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
        public FormRegistroPersonal()
        {
            InitializeComponent();
        }
        


        private void FormRegistroPersonal_Load(object sender, EventArgs e)
        {

        }

        SqlConnection cn = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=ConstruccionesJAQ;Integrated Security=True");


        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            //Adicionar NUevo Renglon

            int n = dtgvPersonal.Rows.Add();

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
       

        //private void txtBuscar_TextChanged(object sender, EventArgs e)
        //{
        //    if(txtBuscar.Text == "")
        //    {
        //        dtgvPersonal.CurrentCell = null;

        //        foreach (DataGridViewRow r in dtgvPersonal.Rows)
        //        {
        //            r.Visible = false;

        //        }
        //        foreach (DataGridViewRow r in dtgvPersonal.Rows)
        //        {
        //            foreach (DataGridViewCell c in r.Cells)
        //            {
        //                if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper())== 0)
        //                {
        //                    r.Visible = true;
        //                    break;
        //                }

        //            }

        //        }
        //    }
        //    else
        //    {
        //    }
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtgvPersonal.Rows.Remove(dtgvPersonal.CurrentRow);
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            SqlCommand agregarbd = new SqlCommand("INSERT INTO Personal (Id_Personal,Nombre,Apellido,Telefono,Salario,Correo,Direccion)" +
                " VALUES (@Id_Personal,@Nombre,@Apellido,@Telefono," +
                "@Salario,@Correo,@Direccion)", cn);
            cn.Open();

            try
            {                
                foreach(DataGridViewRow row in dtgvPersonal.Rows)
                {
                    agregarbd.Parameters.Clear();
                    agregarbd.Parameters.AddWithValue("@Id_Personal", Convert.ToInt32(row.Cells["CedulaP"].Value));
                    agregarbd.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["NombreP"].Value));
                    agregarbd.Parameters.AddWithValue("@Apellido", Convert.ToString(row.Cells["ApellidoP"].Value));
                    agregarbd.Parameters.AddWithValue("@Telefono", Convert.ToDouble(row.Cells["TelefonoP"].Value));
                    agregarbd.Parameters.AddWithValue("@Salario", Convert.ToInt32(row.Cells["SalarioP"].Value));
                    agregarbd.Parameters.AddWithValue("@Correo", Convert.ToString(row.Cells["CorreoP"].Value));
                    agregarbd.Parameters.AddWithValue("@Direccion", Convert.ToString(row.Cells["DireccionP"].Value));

                    agregarbd.ExecuteNonQuery();
                }
                MessageBox.Show("Datos agregados");
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
