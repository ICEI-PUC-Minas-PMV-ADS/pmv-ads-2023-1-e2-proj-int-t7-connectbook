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
        [Display(Name = "Nome do autor")]
        public string Nome { get; set; }

        [Display(Name = "Breve introducao sobre o autor")]
        public string Introducao { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de falecimento")]
        public DateTime DataFalecimento { get; set; }
    }
}