namespace deposito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Depositar_Click(object sender, EventArgs e)
        {

        }

        class ContaBancaria
        {
            private double saldo;

            public ContaBancaria(double saldoInicial)
            {
                saldo = saldoInicial;
            }

            public double Saldo
            {
                get { return saldo; }
            }

            public void Depositar(double valor)
            {
                if (valor > 0)
                {
                    saldo += valor;
                    MessageBox.Show($"Depósito de {valor:C} realizado com sucesso.");
                }
                else
                {
                    MessageBox.Show("O valor do depósito deve ser maior que zero.");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ContaBancaria minhaConta = new ContaBancaria(1000.0);

            MessageBox.Show($"Saldo inicial: {minhaConta.Saldo:C}");

            double valorDeposito = 500.0;
            minhaConta.Depositar(valorDeposito);

            MessageBox.Show($"Saldo após o depósito: {minhaConta.Saldo:C}");
        }
    }



    class ContaBancaria
    {
        private double saldo;

        public ContaBancaria(double saldoInicial)
        {
            saldo = saldoInicial;
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                MessageBox.Show($"Depósito de {valor:C} realizado com sucesso.");
            }
            else
            {
                MessageBox.Show("O valor do depósito deve ser maior que zero.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                MessageBox.Show($"Saque de {valor:C} realizado com sucesso.");
            }
            else if (valor <= 0)
            {
                MessageBox.Show("O valor do saque deve ser maior que zero.");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente para realizar o saque.");

                ContaBancaria minhaConta = new ContaBancaria(1000.0);

                MessageBox.Show($"Saldo inicial: {minhaConta.Saldo:C}");

                double valorDeposito = 500.0;
                minhaConta.Depositar(valorDeposito);

                MessageBox.Show($"Saldo após o depósito: {minhaConta.Saldo:C}");

                double valorSaque = 300.0;
                minhaConta.Sacar(valorSaque);

                MessageBox.Show($"Saldo após o saque: {minhaConta.Saldo:C}");
            }
        }

    }
}