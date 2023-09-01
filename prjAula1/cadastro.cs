using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class cadastro : Form
    {
        public string Nome { get; set; }



        public cadastro()
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
                    cadastro dados = new cadastro();
                    string nome = txtNome.Text;



                    var menu = new mensagem();

                    this.Hide();
                    menu.Show();
                }

            }


        }
        class Cliente : cadastro
        {


            public Cliente()
            {
                Nome = txtNome.Text;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            try
            {
                if (SenhaConta.Text == RepetirSenhaConta.Text)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["UI.Properties.Settings.strConexao"].ToString());



                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Correntista";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nomecliente", txtNome.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(txtDataNascimento.Text));
                    cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                    cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cmbEstados.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpf.Text);
                    cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelular.Text);



                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Correntista cadastrado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



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




