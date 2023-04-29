using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace connectbook.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }
    }
}