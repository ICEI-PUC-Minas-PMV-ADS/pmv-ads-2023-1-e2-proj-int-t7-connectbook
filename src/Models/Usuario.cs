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

        public int IdContato { get; set; }
        [ForeignKey("IdContato")]
        public Contato Contato { get; set; }

        public int IdEndereco { get; set; }
        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }
        
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required]
        public string Senha { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        public DateTime DataRegistro { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Tipo de usuário")]
        public EnumTipoUsuario TipoUsuario { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public enum EnumTipoUsuario
        {
            Doador,
            Receptor
        }
    }
}