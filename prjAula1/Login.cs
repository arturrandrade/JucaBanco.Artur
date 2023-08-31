using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Xml.Linq;
using prjAula1.classes;
using prjAula1.prjAula1.extra;

namespace prjAula1
{
    public partial class Login : Form
    {
        

        public Login() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new cadastro();
            this.Hide();
            menu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtcpf.TextLength < 11 || txtSenha.TextLength < 6)

            {
                lblMensagem.Text = "Preencha o campo corretamente";
            }

            else

            {
                if (txtcpf.Text == "12312312312" && txtSenha.Text == "123456")

                {
                    lblMensagem.Text = "Usuário valido";
                    var telamenu = new mensagem();
                    this.Hide();
                    telamenu.Show();
                }

                else

                {

                    lblMensagem.Text = "Usuário inválido";

                }

                {
                    try
                    {



                        //Criando uma conexão
                        SqlConnection conexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.bancojuka"].ToString());
                        SqlDataReader leitor; //declarando uma variável do tipo leitor de dados



                        //Criando um comando
                        SqlCommand cmd = new SqlCommand();



                        //criando texto do comando, tipo e conexão que será usada
                        cmd.CommandText = "psValidaLogin";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conexao;



                        //passando os parâmetros necessários
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("logindecliente", txtcpf.Text);
                        cmd.Parameters.AddWithValue("senha", txtSenha.Text);



                        conexao.Open(); //abrindo a conexão



                        leitor = cmd.ExecuteReader();
                        //igualando o leitor ao resultado trazido do BD



                        if (leitor.HasRows) //se o leitor encontrar linhas de dados
                        {



                            leitor.Read();

                            UsuarioLogado.IdCliente = leitor.GetInt32(0);
                            UsuarioLogado.NomeCliente = leitor.GetString(1);
                            UsuarioLogado.Cpf = leitor.GetString(2);
                            UsuarioLogado.RG = leitor.GetString(3);
                            UsuarioLogado.Senha = leitor.GetString(4);
                            UsuarioLogado.DataNascimento = leitor.GetDateTime(5);
                            UsuarioLogado.Email = leitor.GetString(6);
                            UsuarioLogado.sexo = leitor.GetString(7);
                            UsuarioLogado.Celular = leitor.GetString(8);

                            if (!leitor.IsDBNull(10))



                            {



                                UsuarioLogado.Complemento = leitor.GetString(10);



                            }
                            UsuarioLogado.Endereço = leitor.GetString(9);
                            UsuarioLogado.Cidade = leitor.GetString(10);
                            UsuarioLogado.Estado = leitor.GetString(11);
                            UsuarioLogado.Diadeabertura = leitor.GetDateTime(12);
                            UsuarioLogado.Statusdeconta = leitor.GetString(13);



                            //fechando leitor
                            leitor.Close();



                            //criando texto do comando, tipo e conexão que será usada
                            cmd.CommandText = "ps_buscaContasPorIdCliente";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = conexao;





                            //passando os parâmetros necessários
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);





                            //ler novamente o leitor
                            leitor = cmd.ExecuteReader();



                            //verificar se há linhas retornadas do leitor
                            if (leitor.HasRows)
                            {
                                //repete a leitura e enquanto há linhas segue na estrutura
                                //de repetição
                                while (leitor.Read())
                                {
                                    //cria uma conta na memória
                                    Conta conta = new Conta();
                                    //passa os dados do leitor para a conta na memória - objeto conta
                                    conta.Id = leitor.GetInt32(0);
                                    conta.IdCliente = leitor.GetInt32(1);
                                    conta.DataAbertura = leitor.GetDateTime(2);
                                    conta.Saldo = (double)leitor.GetDecimal(4);
                                    conta.StatusConta = leitor.GetString(5);
                                    conta.Senha = leitor.GetString(6);





                                    //adiciona a conta recém criada na memória para a colection de contas
                                    UsuarioLogado.Contas.Add(conta);
                                }
                            }
                            leitor.Close(); //fecha leitor
                            conexao.Close(); //fecha conexao com BD


                            Form telaPrincipal = Application.OpenForms["TelaPrincipal"];

                            //acessando o formulário aberto através da variável janelaPrincipal

                            MenuStrip menuPrincipal = (MenuStrip)telaPrincipal.Controls[0];

                            menuPrincipal.Items[0].Text = "Logout";

                            menuPrincipal.Items[1].Visible = true;

                            menuPrincipal.Items[2].Visible = true;

                            menuPrincipal.Items[3].Visible = true;

                            menuPrincipal.Items[4].Visible = true;

                            menuPrincipal.Items[4].Text = UsuarioLogado.NomeCorrentista;

                            menuPrincipal.Items[5].Visible = true;

                            menuPrincipal.Items[6].Visible = true;

                            menuPrincipal.Items[6].Text = UsuarioLogado.Contas[0].Id.ToString();



                            MessageBox.Show($"Olá,{UsuarioLogado.NomeCorrentista}!\n" +

                                $"Você foi logado na conta {UsuarioLogado.Contas[0].Id.ToString()}\n" +

                                $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");

                            //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +

                            //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +

                            //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");

                            this.Close();


                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}



                    
                    