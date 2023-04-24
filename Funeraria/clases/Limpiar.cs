using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria.clases
{
    public class Limpiar
    {
        public void BorrarCampos(Control ctr)
        {
            foreach (var txt in ctr.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).ResetText();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedItem = 0;
                }
            }
        }
    }
}
