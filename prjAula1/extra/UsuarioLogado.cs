﻿using prjAula1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace prjAula1.prjAula1.extra

{




    public static class UsuarioLogado
    {
        public static int Id { get; set; }
        public static string? NomeCorrentista { get; set; }
        public static DateTime? DataNascimento { get; set; }
        public static string? Logradouro { get; set; }
        public static string? Numero { get; set; }
        public static string? Complemento { get; set; }
        public static string? Cidade { get; set; }
        public static string? Estado { get; set; }
        public static string? Cpf { get; set; }
        public static string? Celular { get; set; }
        public static string? Senha { get; set; }
        public static object leitor { get; private set; }
        public static int IdCliente { get; internal set; }
        public static string NomeCliente { get; internal set; }
        public static string RG { get; internal set; }
        public static string Email { get; internal set; }
        public static string Endereço { get; internal set; }
        public static DateTime Diadeabertura { get; internal set; }
        public static string Statusdeconta { get; internal set; }

        public static List<global::prjAula1.classes.Conta> Contas = new List<global::prjAula1.classes.Conta>();
        internal static string sexo;

        public static void Deslogar()
        {

            UsuarioLogado.Id = 0;
            UsuarioLogado.NomeCorrentista = String.Empty;
            UsuarioLogado.DataNascimento = null;
            UsuarioLogado.Logradouro = String.Empty;
            UsuarioLogado.Numero = String.Empty;
            UsuarioLogado.Complemento = null;
            UsuarioLogado.Cidade = String.Empty;
            UsuarioLogado.Estado = String.Empty;
            UsuarioLogado.Cpf = String.Empty;
            UsuarioLogado.Celular = String.Empty;
            UsuarioLogado.Senha = String.Empty;
            UsuarioLogado.Contas.Clear();

        }
    }

}    

            
                namespace UI
        { 
            public static class UsuarioLogado
            {
                public static int Id { get; set; }
                public static string? NomeCorrentista { get; set; }
                public static DateTime? DataNascimento { get; set; }
                public static string? Logradouro { get; set; }
                public static string? Numero { get; set; }
                public static string? Complemento { get; set; }
                public static string? Cidade { get; set; }
                public static string? Estado { get; set; }
                public static string? Cpf { get; set; }
                public static string? Celular { get; set; }
                public static string? Senha { get; set; }


                public static List<Conta> Contas = new List<Conta>();



                public static void Deslogar()
                {
                    UsuarioLogado.Id = 0;
                    UsuarioLogado.NomeCorrentista = String.Empty;
                    UsuarioLogado.DataNascimento = null;
                    UsuarioLogado.Logradouro = String.Empty;
                    UsuarioLogado.Numero = String.Empty;
                    UsuarioLogado.Complemento = null;
                    UsuarioLogado.Cidade = String.Empty;
                    UsuarioLogado.Estado = String.Empty;
                    UsuarioLogado.Cpf = String.Empty;
                    UsuarioLogado.Celular = String.Empty;
                    UsuarioLogado.Senha = string.Empty;
                    UsuarioLogado.Contas.Clear();
                }
            }
        }

    
