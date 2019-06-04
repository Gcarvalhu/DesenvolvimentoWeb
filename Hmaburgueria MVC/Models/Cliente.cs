using System;

namespace Hmaburgueria_MVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Endereco{get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public ulong Id { get; internal set; }
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}
    }
}