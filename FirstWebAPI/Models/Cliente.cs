using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstWebAPI.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome = "", int idade = 0, string cpf = "")
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }
    }
}