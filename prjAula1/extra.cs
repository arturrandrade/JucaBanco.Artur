using prjAula1.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public class ContaBancaria
    {
        private decimal saldo; // Variável para armazenar o saldo da conta

        // Construtor da classe
        public ContaBancaria(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }

        // Método para sacar dinheiro da conta
        public bool Sacar(decimal valorASacar)
        {
            if (valorASacar > 0 && valorASacar <= saldo)
            {
                saldo -= valorASacar;
                return true; // Saque realizado com sucesso
            }
            else
            {
                return false; // Não há saldo suficiente para o saque
            }
        }

        // Método para obter o saldo atual da conta
        public decimal ObterSaldo()
        {
            return saldo;
        }
    }
}