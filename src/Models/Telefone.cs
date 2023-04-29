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
        public int Ddd { get; set; }
        public int Numero { get; set; }

    }
}