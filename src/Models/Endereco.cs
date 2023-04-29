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
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }

        public Endereco(string Cep, string Cidade, string Estado, string Bairro)
        {
            this.Cep = Cep;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Bairro = Bairro;
        }
    }
}