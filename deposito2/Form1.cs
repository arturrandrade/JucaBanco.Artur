using System.Drawing;
using static deposito2.Form1;

namespace deposito2
{
    public partial class Form1 : Form
    {
        private int valor;
        private int saldo;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void CriarConta_Click(object sender, EventArgs e)
        {
        }

        public class ContaBancaria
        {
            private double saldo; // Vari�vel para armazenar o saldo da conta

            // Construtor para inicializar a conta com um saldo inicial
            public ContaBancaria(double saldoInicial)
            {
                saldo = saldoInicial;
            }

            // M�todo para depositar dinheiro na conta
            public void Depositar(double valor)
            {
                if (valor > 0)
                {
                    saldo += valor;
                    Console.WriteLine($"Dep�sito de R${valor} realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("O valor do dep�sito deve ser maior que zero.");
                }
            }

            // M�todo para obter o saldo atual da conta
            public double ObterSaldo()
            {
                return saldo;
            }

            internal void Sacar(int v)
            {
                throw new NotImplementedException();
            }

            internal void Sacar(double valorSaque)
            {
                throw new NotImplementedException();
            }
        }

        class Program
        {
            static void Main()
            {
                // Cria uma inst�ncia da classe ContaBancaria com um saldo inicial de 1000
                ContaBancaria conta = new ContaBancaria(1000);

                // Realiza um dep�sito de 500 na conta
                conta.Depositar(500);

                // Obt�m o saldo atual da conta e imprime na tela
                double saldoAtual = conta.ObterSaldo();
                Console.WriteLine($"Saldo atual: R${saldoAtual}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            }
            else if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }

        // M�todo para obter o saldo atual da conta
        public double ObterSaldo()
        {
            return saldo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ContaBancaria conta = new ContaBancaria(1000);

            // Solicita ao usu�rio que digite o valor do saque
            Console.Write("Digite o valor do saque: ");
            double valorSaque;
            if (double.TryParse(Console.ReadLine(), out valorSaque))
            {
                // Tenta realizar o saque
                conta.Sacar(valorSaque);
            }
            else
            {
                Console.WriteLine("Valor de saque inv�lido.");
            }

            // Obt�m o saldo atual da conta e imprime na tela
            double saldoAtual = conta.ObterSaldo();
            Console.WriteLine($"Saldo atual: R${saldoAtual}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            }

            // M�todo para depositar dinheiro na conta
            public void Depositar(double valor)
            {
                if (valor > 0)
                {
                    Console.WriteLine($"Dep�sito de R${valor} realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("O valor do dep�sito deve ser maior que zero.");
                }
            }

            // M�todo para sacar dinheiro da conta
            public void Sacar(double valor)
            {
                if (valor > 0 && valor <= saldo)
                {
                    Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
                }
                else if (valor <= 0)
                {
                    Console.WriteLine("O valor do saque deve ser maior que zero.");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para o saque.");
                }
            }
        }
    }



class Program
{
    static void Main()
    {
        // Cria uma inst�ncia da classe ContaBancaria com um saldo inicial de 1000
        ContaBancaria conta = new ContaBancaria(1000);

        // Realiza um saque de 500 na conta
        conta.Sacar(500);

        // Obt�m o saldo atual da conta e imprime na tela
        double saldoAtual = conta.ObterSaldo();
        Console.WriteLine($"Saldo atual: R${saldoAtual}");
    }
}


