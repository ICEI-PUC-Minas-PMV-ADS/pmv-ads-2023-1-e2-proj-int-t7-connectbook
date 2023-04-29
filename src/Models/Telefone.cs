using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace connectbook.Models
{
    [Table("Telefones")]
    public class Telefone
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "DDD")]
        [Required]
        public int Ddd { get; set; }

        [Display(Name = "Número do telefone")]
        [Required]
        public int Numero { get; set; }

    }
}