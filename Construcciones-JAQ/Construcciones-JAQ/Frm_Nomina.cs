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
    public partial class Frm_Nomina : Form
    {
        Cls_Consulta_Contabilidad consulta;
        public Frm_Nomina()
        {
            InitializeComponent();
        }

        private void Btn_Control_Nomina_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Nomina_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Control_Ingresos_Egresos_Click(object sender, EventArgs e)
        {
            consulta = new Cls_Consulta_Contabilidad();
            consulta.control_i_e(dgv_Control_I_E);
        }
    }
}
