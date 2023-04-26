using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace connectbook.Models
{
    [Table("Autores")]
    public class Autor
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string introducao { get; set; }
        public string data_nascimento { get; set; }
        public string data_falecimento { get; set; }

        public Autor(string nome, string introducao, string data_nascimento, string data_falecimento)
        {
            this.nome = nome;
            this.introducao = introducao;
            this.data_nascimento = data_nascimento;
            this.data_falecimento = data_falecimento;
        }

    }
}