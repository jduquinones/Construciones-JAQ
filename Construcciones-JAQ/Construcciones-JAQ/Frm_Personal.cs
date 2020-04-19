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
    public partial class Frm_Personal : Form 
    {
        Cls_Consulta_Personal consulta;
        Cls_Consulta_Validaciones validacion;

        private bool update = false;


        public Frm_Personal()
        {
            InitializeComponent();            
        }

        private void FormRegistroPersonal_Load_1(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Personal();
            consulta.ver(dtgvPersonal);
            consulta.llenar_cmb(cmb_Obra_agsinado);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                consulta.ver(dtgvPersonal);
            }
            else
            {
                consulta.buscarporid(dtgvPersonal, txt_Buscar.Text);
            }
        }

       
        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Personal();
            validacion = new Cls_Consulta_Validaciones();

            if (update == false)
            {
                try
                {
                    consulta.agregar(Convert.ToInt32(txtCedulaP.Text), txtNombreP.Text, txtApellidoP.Text, Convert.ToInt64(txtTelefonoP.Text), Convert.ToDecimal(txtSalarioP.Text), txtCorreoP.Text, txtDireccionP.Text, dtp_Fecha_Nacimiento.Value, cmb_Estado_civil.Text, cmb_hijos.Text, cmb_Eps.Text, cmb_Arl.Text, cmb_Obra_agsinado.Text);
                    consulta.ver(dtgvPersonal);
                    validacion.limpiar_campos(panel_personal);
                    txt_Edad.Text = Convert.ToString(consulta.valor_edad(dtp_Fecha_Nacimiento.Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardaron los datos" + ex.ToString());
                }               
            }
            else
            {
                MessageBox.Show("No se pudo guardar el registro, los campos estan llenos");
            }
            
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (update == true)
            {
                try
                {
                    consulta.eliminar(Convert.ToInt32(txtCedulaP.Text));
                    consulta.ver(dtgvPersonal);
                    validacion.limpiar_campos(panel_personal);
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Primero seleccione una fila" + ex.ToString());
                }
            }
            
        }

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {
            validacion = new Cls_Consulta_Validaciones();
            validacion.limpiar_campos(panel_personal);

            if (dtgvPersonal.SelectedRows.Count>0)
            {
                update=true;  // para actualizar

                lbl_Id.Text = dtgvPersonal.CurrentRow.Cells["Id"].Value.ToString();
                txtCedulaP.Text = dtgvPersonal.CurrentRow.Cells["Cedula"].Value.ToString();
                txtNombreP.Text = dtgvPersonal.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidoP.Text = dtgvPersonal.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefonoP.Text = dtgvPersonal.CurrentRow.Cells["Telefono"].Value.ToString();
                txtSalarioP.Text = dtgvPersonal.CurrentRow.Cells["Salario"].Value.ToString();
                txtCorreoP.Text = dtgvPersonal.CurrentRow.Cells["Correo"].Value.ToString();
                txtDireccionP.Text = dtgvPersonal.CurrentRow.Cells["Direccion"].Value.ToString();
                cmb_Estado_civil.Text = dtgvPersonal.CurrentRow.Cells["Estado_Civil"].Value.ToString();
                dtp_Fecha_Nacimiento.Text = dtgvPersonal.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString();
                cmb_Eps.Text = dtgvPersonal.CurrentRow.Cells["EPS"].Value.ToString();
                cmb_Arl.Text = dtgvPersonal.CurrentRow.Cells["ARL"].Value.ToString();
                cmb_Obra_agsinado.Text = dtgvPersonal.CurrentRow.Cells["Obra_Agsinado"].Value.ToString();
                cmb_hijos.Text = dtgvPersonal.CurrentRow.Cells["Hijos"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }          
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (update == true)
            {
                try
                {
                    consulta.update(Convert.ToInt64(lbl_Id.Text), Convert.ToInt32(txtCedulaP.Text), txtNombreP.Text, txtApellidoP.Text, Convert.ToInt64(txtTelefonoP.Text), Convert.ToDecimal(txtSalarioP.Text), txtCorreoP.Text, txtDireccionP.Text, dtp_Fecha_Nacimiento.Value, cmb_Estado_civil.Text, cmb_hijos.Text, cmb_Eps.Text, cmb_Arl.Text, cmb_Obra_agsinado.Text);
                    MessageBox.Show("Datos actualizados");
                    consulta.ver(dtgvPersonal);
                    validacion.limpiar_campos(panel_personal);
                    update = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione una fila");
            }

        }
    }
}
