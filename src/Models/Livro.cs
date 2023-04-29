using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace connectbook.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCategoria { get; set; }
        public int IdAutor { get; set; }
        public string Nome { get; set; }
        public EnumEstadoConservacao EstadoConservacao { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public string? Isbn { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public string? Foto { get; set; }
        public string? Resumo { get; set; }
        public int QtdPaginas { get; set; }
        public bool DisponivelDoacao { get; set; }

        public enum EnumEstadoConservacao
        {
            Ruim,
            Mediano,
            Bom,
            Ótimo
        }

        public Livro(string Nome, EnumEstadoConservacao EstadoConservacao)
        {
            this.Nome = Nome;
            this.EstadoConservacao = EstadoConservacao;
        }

      
    }
}