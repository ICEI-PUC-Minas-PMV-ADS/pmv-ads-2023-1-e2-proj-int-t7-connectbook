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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Introducao { get; set; }
        public string DataNascimento { get; set; }
        public string DataFalecimento { get; set; }

        public Autor(string Nome, string Introducao, string DataNascimento, string DataFalecimento)
        {
            this.Nome = Nome;
            this.Introducao = Introducao;
            this.DataNascimento = DataNascimento;
            this.DataFalecimento = DataFalecimento;
        }

    }
}