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
        public int id { get; set; }
        public int ddd { get; set; }
        public int numero { get; set; }

    }
}