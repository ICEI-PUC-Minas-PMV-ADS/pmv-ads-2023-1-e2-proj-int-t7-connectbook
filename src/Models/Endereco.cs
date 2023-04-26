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
        public int id { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }

        public Endereco(string cep, string cidade, string estado, string bairro)
        {
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.bairro = bairro;
        }
    }
}