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
        public int id_usuario { get; set; }
        public int id_categoria { get; set; }
        public int id_autor { get; set; }
        public string nome { get; set; }
        public string estado_conservacao { get; set; }
        public string? data_publicacao { get; set; }
        public string? isbn { get; set; }
        public int classificacao_indicativa { get; set; }
        public string? foto { get; set; }
        public string? resumo { get; set; }
        public int qtd_paginas { get; set; }
        public bool disponivel_doacao { get; set; }

        public Livro(string nome, string estado_conservacao)
        {
            this.nome = nome;
            this.estado_conservacao = estado_conservacao;
        }
    }
}