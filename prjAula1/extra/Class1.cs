using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAula1.prjAula1.classes
{
    internal class Class1
    {
        public static void LimparForm(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox || c is CheckBox)
                {
                    c.Text = String.Empty;

                }
                else if (c is DateTimePicker)
                {
                    c.Text = DateTime.Now.ToString();
                }
            }
        }
    }
}


