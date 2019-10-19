using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construcciones_JAQ
{
    public partial class Frmdatospersonal : Form
    {
        public Frmdatospersonal()
        {
            InitializeComponent();
        }

        private void PersonalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.construccionesJAQDataSet);

        }

        private void Frmdatospersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'construccionesJAQDataSet.Personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.construccionesJAQDataSet.Personal);

        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            personalTableAdapter.Agregar(Convert.ToInt32(id_PersonalTextBox.Text),nombreTextBox.Text,apellidoTextBox.Text,Convert.ToInt64(telefonoTextBox.Text),Convert.ToInt64(salarioTextBox.Text),correoTextBox.Text,direccionTextBox.Text);
            this.personalTableAdapter.Fill(this.construccionesJAQDataSet.Personal);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            personalTableAdapter.Eliminar(Convert.ToInt32(id_PersonalTextBox.Text));
            this.personalTableAdapter.Fill(this.construccionesJAQDataSet.Personal);

        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            personalTableAdapter.Modificar(Convert.ToInt32(id_PersonalTextBox.Text), nombreTextBox.Text, apellidoTextBox.Text, Convert.ToInt64(telefonoTextBox.Text), Convert.ToInt64(salarioTextBox.Text), correoTextBox.Text, direccionTextBox.Text,Convert.ToInt32(id_PersonalTextBox.Text));
            this.personalTableAdapter.Fill(this.construccionesJAQDataSet.Personal);
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            personalTableAdapter.Buscar(construccionesJAQDataSet.Personal, Convert.ToInt32(id_PersonalTextBox.Text), nombreTextBox.Text, apellidoTextBox.Text);
            this.personalTableAdapter.Fill(this.construccionesJAQDataSet.Personal);

        }
    }
}
