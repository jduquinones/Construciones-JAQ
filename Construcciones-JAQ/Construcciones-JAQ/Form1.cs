﻿using System;
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
        private void BtnAgregarP_Click(object sender, EventArgs e)
        {

        }
        //     Cls_Consulta_sql consulta;

        //    public FormRegistroPersonal()
        //    {
        //        InitializeComponent();            
        //    }

        //    private void BtnAgregarP_Click(object sender, EventArgs e)
        //    {
        //        consulta = new Cls_Consulta_sql();

        //        if (consulta.validaregistro(int.Parse(txtCedulaP.Text))==0)
        //        {
        //            MessageBox.Show(consulta.agregar(Convert.ToInt64(txtCedulaP.Text), txtNombreP.Text, txtApellidoP.Text, Convert.ToInt64(txtTelefonoP.Text), Convert.ToDecimal(txtSalarioP.Text), txtCorreoP.Text, txtDireccionP.Text));
        //            consulta.ver(dtgvPersonal);

        //            txtCedulaP.Text = "";
        //            txtNombreP.Text = "";
        //            txtApellidoP.Text = "";
        //            txtTelefonoP.Text = "";
        //            txtSalarioP.Text = "";
        //            txtDireccionP.Text = "";
        //            txtCorreoP.Text = "";
        //        }
        //    }

        //    private void FormRegistroPersonal_Load_1(object sender, EventArgs e)
        //    {
        //        // TODO: esta línea de código carga datos en la tabla 'construccionesJAQDataSet.Personal' Puede moverla o quitarla según sea necesario.
        //        this.personalTableAdapter.Fill(this.construccionesJAQDataSet.Personal);
        //        consulta = new Cls_Consulta_sql();
        //        consulta.ver(dtgvPersonal);
        //    }

        //    private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        //    {            
        //        if (txt_Buscar.Text == "")
        //        {
        //            consulta.ver(dtgvPersonal);
        //        }
        //        else
        //        {
        //            consulta.filtrar(dtgvPersonal, txt_Buscar.Text);
        //        }
        //    }

        //    private void Btn_Eliminar_Click(object sender, EventArgs e)
        //    {
        //        consulta.eliminar(dtgvPersonal, txt_Buscar.Text);
        //    }

        //    private void Btn_Modificar_Click(object sender, EventArgs e)
        //    {
        //        consulta.modificar(Convert.ToInt32(txtCedulaP.Text), txtNombreP.Text, txtApellidoP.Text, Convert.ToInt64(txtTelefonoP.Text), Convert.ToInt64(txtSalarioP.Text), txtCorreoP.Text, txtDireccionP.Text);
        //        consulta.ver(dtgvPersonal);
        //    }

        //    private void PersonalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //    {
        //        this.Validate();
        //        this.personalBindingSource.EndEdit();
        //        this.tableAdapterManager.UpdateAll(this.construccionesJAQDataSet);

        //    }
    }
}
