﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAula1
{
    internal class UtilUI
    {
        
            public static void LimpaForm(Form form)
            {
                foreach (Control c in form.Controls)
                {
                    if (c is TextBox || c is ComboBox)
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

