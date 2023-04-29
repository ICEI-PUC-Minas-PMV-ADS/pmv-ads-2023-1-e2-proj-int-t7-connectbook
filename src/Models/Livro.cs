using Microsoft.AspNetCore.Authorization.Infrastructure;
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
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        public int IdAutor { get; set; }
        [ForeignKey("IdAutor")]
        public Autor Autor { get; set; }

        [Display(Name = "Nome do livro")]
        [Required(ErrorMessage = "Obrigatório informar o nome do livro")]
        public string Nome { get; set; }

        [Display(Name = "Estado de conservação")]
        [Required(ErrorMessage = "Obrigatório informar o estado de conservação do livro")]
        public EnumEstadoConservacao EstadoConservacao { get; set; }

        [Display(Name = "Data de publicação")]
        public DateTime? DataPublicacao { get; set; }

        [Display(Name = "Código ISBN")]
        public string? Isbn { get; set; }

        [Display(Name = "Classificação indicativa")]
        public int ClassificacaoIndicativa { get; set; }

        [Display(Name = "Foto do livro")]
        public byte[] Foto { get; set; }

        [Display(Name = "Resumo do livro")]
        public string? Resumo { get; set; }

        [Display(Name = "Quantidade de páginas")]
        public int QtdPaginas { get; set; }

        [Display(Name="Disponibilidade para doação")]
        [Required(ErrorMessage = "Obrigatório informar a disponiblidade para doação")]
        public bool DisponivelDoacao { get; set; }

        public enum EnumEstadoConservacao
        {
            Ruim,
            Mediano,
            Bom,
            Ótimo
        }
    }
}