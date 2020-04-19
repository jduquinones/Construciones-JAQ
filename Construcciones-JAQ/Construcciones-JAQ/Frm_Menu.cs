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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Personal_Click(object sender, EventArgs e) => new Frm_Personal().Show();

        private void Btn_contracto_Click(object sender, EventArgs e) => new Frm_Contractos().Show();

        private void GestioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e) => new Frm_Usuarios().Show();

        private void Btn_Control_Nomina_Click(object sender, EventArgs e) => new Frm_Nomina().Show();

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            new Frm_Login();
        }


    }
}
