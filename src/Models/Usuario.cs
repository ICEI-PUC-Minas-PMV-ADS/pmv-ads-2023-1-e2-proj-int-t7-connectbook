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
        public int id { get; set; }
        [ForeignKey("Contato")]
        public int id_contato { get; set; }
        [ForeignKey("Endereco")]
        public int id_endereco { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string data_nascimento { get; set; }
        public string data_registro { get; set; }
        public string descricao { get; set; }
        public string tipo_usuario { get; set; }

        public Usuario(string nome, string email, string senha, string data_nascimento, string data_registro, string descricao, string tipo_usuario)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.data_nascimento = data_nascimento;
            this.data_registro = data_registro;
            this.descricao = descricao;
            this.tipo_usuario = tipo_usuario;
        }

    }
}