﻿using prjAula1.classes;
using prjAula1.prjAula1.extra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaConta.Text == txtRepeteSenhaConta.Text)
                {
                    Conta conta = new Conta();
                    conta.IdCorrentista = UsuarioLogado.Id;
                    conta.DataAbertura = DateTime.Now;
                    conta.Saldo = (double)Convert.ToDecimal(txtSaldoInicial.Text);
                    conta.StatusConta = "ATIVA";
                    conta.Senha = txtSenhaConta.Text;



                    //Criando uma conexão
                    SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["UI.Properties.Settings.strConexao"].ToString());



                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCorrentista", conta.IdCorrentista);
                    cmd.Parameters.AddWithValue("dataAbertura", conta.DataAbertura);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("statusConta", conta.StatusConta);
                    cmd.Parameters.AddWithValue("senha", conta.Senha);



                    //abrir a conexão
                    conexao.Open();



                    //executa o comando no BD e captura o retorno devolvido pelo procedimento
                    conta.Id = Convert.ToInt32(cmd.ExecuteScalar());



                    MessageBox.Show(conta.Id.ToString());



                    conexao.Close();
                    MessageBox.Show("Conta criada com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    UsuarioLogado.Contas.Add(conta);



                    UtilUI.LimpaForm(this);



                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
    }
}
