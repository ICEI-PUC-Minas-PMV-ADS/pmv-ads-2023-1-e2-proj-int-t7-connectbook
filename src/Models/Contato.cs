using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace connectbook.Models
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Telefone")]
        public int id_telefone { get; set; }
        public string email { get; set; }
        public string disponibilidade { get; set; }

        public Contato(string email, string disponibilidade)
        {
            this.email = email;
            this.disponibilidade = disponibilidade;
        }
    }
}