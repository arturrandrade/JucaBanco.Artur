using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class Form3 : Form
    {
        public string Nome { get; set; }



        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (txtCpfCadastro.Text == string.Empty || txtDataNascimento.Text == string.Empty || txtEmail.Text == string.Empty || txtNome.Text == string.Empty || txtSenhaCadastro.Text == string.Empty)
            {
                MessageBox.Show("Alguma caixa esta vazia!");
            }
            else
            {

                if (double.TryParse(txtCpfCadastro.Text, out double res) == false || txtCpfCadastro.TextLength < 11)
                {
                    MessageBox.Show("Cpf errado!");

                }
                if (int.TryParse(txtSenhaCadastro.Text, out int res1) == false || txtSenhaCadastro.TextLength < 6)
                {
                    MessageBox.Show("Senha errada!");
                }
                else
                {
                    MessageBox.Show("Cadastrado!");
                    Form3 dados = new Form3();
                    string nome = txtNome.Text;



                    var menu = new Form2();

                    this.Hide();
                    menu.Show();
                }

            }

            
        }
        class Cliente : Form3
        {
            

            public Cliente()
            {
                Nome = txtNome.Text;
            }
        }

    }
    
}


         

