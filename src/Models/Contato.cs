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
        public int Id { get; set; }
        [ForeignKey("Telefone")]
        public int IdTelefone { get; set; }
        public string Email { get; set; }
        public string Disponibilidade { get; set; }

        public Contato(string Email, string Disponibilidade)
        {
            this.Email = Email;
            this.Disponibilidade = Disponibilidade;
        }
    }
}