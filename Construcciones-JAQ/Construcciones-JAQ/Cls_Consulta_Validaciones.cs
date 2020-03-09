using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construcciones_JAQ
{
    class Cls_Consulta_Validaciones
    {
        public void limpiar_campos( Panel panel)
        {
            foreach (var c in panel.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = null;
                }
            }
        }
        
    }
}
