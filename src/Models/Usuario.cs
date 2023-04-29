using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace connectbook.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Contato")]
        public int IdContato { get; set; }
        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DataNascimento { get; set; }
        public string DataRegistro { get; set; }
        public string Descricao { get; set; }
        public string TipoUsuario { get; set; }

        public Usuario(string Nome, string Email, string Senha, string DataNascimento, string DataRegistro, string Descricao, string TipoUsuario)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            this.DataNascimento = DataNascimento;
            this.DataRegistro = DataRegistro;
            this.Descricao = Descricao;
            this.TipoUsuario = TipoUsuario;
        }

    }
}