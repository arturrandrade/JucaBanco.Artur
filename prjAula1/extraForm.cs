using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjAula1.classes;

namespace prjAula1
{
    public partial class extraForm : Form
    {
        Conta minhaContinha;
        public extraForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //minhaContinha = new
            //    Conta(2, DateTime.Now, null, 1000, "Ativa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(minhaContinha)
            //  Depositar(Convert.ToDouble(txtValorDeposito.Text)).ToString()
            //  , "Novo Saldo");

            lblMensagem.Text = $"Saldo: R$ {minhaContinha.Depositar(Convert.ToDouble(txtValorDeposito.Text)).ToString("n2")}.";

            Conta contaA = new Conta();
            contaA.Depositar(500);
            Conta contaB = new Conta();
            contaB.Depositar(1500);

            MessageBox.Show(ContaBancaria.RetornarSaldoTodasContas(), "Valor total de depósito:");
        }
    }
}
