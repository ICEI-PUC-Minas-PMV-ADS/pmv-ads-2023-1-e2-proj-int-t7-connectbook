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
        
        public int IdTelefone { get; set; }
        [ForeignKey("IdTelefone")]
        public Telefone Telefone { get; set; }

        [Display(Name = "Email de contato")]
        public string Email { get; set; }

        [Display(Name = "Disponibilidade")]
        public string Disponibilidade { get; set; }
    }
}