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
        [Required(ErrorMessage = "Obrigat�rio informar o nome do livro")]
        public string Nome { get; set; }

        [Display(Name = "Estado de conserva��o")]
        [Required(ErrorMessage = "Obrigat�rio informar o estado de conserva��o do livro")]
        public EnumEstadoConservacao EstadoConservacao { get; set; }

        [Display(Name = "Data de publica��o")]
        public DateTime? DataPublicacao { get; set; }

        [Display(Name = "C�digo ISBN")]
        public string? Isbn { get; set; }

        [Display(Name = "Classifica��o indicativa")]
        public int ClassificacaoIndicativa { get; set; }

        [Display(Name = "Foto do livro")]
        public byte[] Foto { get; set; }

        [Display(Name = "Resumo do livro")]
        public string? Resumo { get; set; }

        [Display(Name = "Quantidade de p�ginas")]
        public int QtdPaginas { get; set; }

        [Display(Name="Disponibilidade para doa��o")]
        [Required(ErrorMessage = "Obrigat�rio informar a disponiblidade para doa��o")]
        public bool DisponivelDoacao { get; set; }

        public enum EnumEstadoConservacao
        {
            Ruim,
            Mediano,
            Bom,
            �timo
        }
    }
}