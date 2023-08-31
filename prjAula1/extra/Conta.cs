using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjAula1.classes
{
    public class Conta
    {
        public static int TotalContas { get; set; }
        public int IdConta { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public double Saldo { get; set; }
        public string? Status { get; set; }
        public double Limite { get; set; }
        public string? TipodeConta { get; set; }
        public DateTime DiadeAbertura { get; set; }
        public DateTime DiadeFechamento { get; set; }
        public static double SaldoTotal { get; set; }
        public int Id { get; internal set; }
        public int IdCliente { get; internal set; }
        public string StatusConta { get; internal set; }
        public string Senha { get; internal set; }

        public Conta()
        {
            TotalContas = TotalContas + 1;
            Saldo = SaldoTotal + Saldo;
        }
        public Conta(int idConta, DateTime dataAbertura, DateTime? dataFechamento, double saldo, string? status, double limite, string? tipodeConta, DateTime diadeAbertura, DateTime diadeFechamento)
        {
            IdConta = idConta;
            DataAbertura = dataAbertura;
            DataFechamento = dataFechamento;
            Saldo = saldo;
            Status = status;
            Limite = limite;
            TipodeConta = tipodeConta;
            DiadeAbertura = diadeAbertura;
            DiadeFechamento = diadeFechamento;
            TotalContas = TotalContas + 1;
            SaldoTotal = SaldoTotal + Saldo;
        }
        public double Depositar(double Valordepositado)
        {

            this.Saldo = this.Saldo + Valordepositado;
            return this.Saldo;

        }
        public static double RetornarSaldoTodasContas()
        {

            return SaldoTotal;
        }
        public static string RetornoSaldoTodasContas()
        {
            return $"O saldo de todas as contas é R$ {SaldoTotal}";
        }

        public double Sacar(double valorSaque)
        {
            if (valorSaque <= 0)
            {
                throw new Exception("Valor de saque inválido!");
            }
            else if (valorSaque > this.Saldo)
            {
                throw new Exception("Saldo Indisponível");
            }
            else
            {
                this.Saldo = this.Saldo - valorSaque;
            }
            return this.Saldo;
        }


    }
}