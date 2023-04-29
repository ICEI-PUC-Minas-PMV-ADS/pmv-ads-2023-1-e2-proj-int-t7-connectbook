using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connectbook.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Usuarios",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tipo_usuario",
                table: "Usuarios",
                newName: "TipoUsuario");

            migrationBuilder.RenameColumn(
                name: "id_endereco",
                table: "Usuarios",
                newName: "IdEndereco");

            migrationBuilder.RenameColumn(
                name: "id_contato",
                table: "Usuarios",
                newName: "IdContato");

            migrationBuilder.RenameColumn(
                name: "data_registro",
                table: "Usuarios",
                newName: "DataRegistro");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Usuarios",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Telefones",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "ddd",
                table: "Telefones",
                newName: "Ddd");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Telefones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "resumo",
                table: "Livros",
                newName: "Resumo");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Livros",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "Livros",
                newName: "Isbn");

            migrationBuilder.RenameColumn(
                name: "foto",
                table: "Livros",
                newName: "Foto");

            migrationBuilder.RenameColumn(
                name: "qtd_paginas",
                table: "Livros",
                newName: "QtdPaginas");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "Livros",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "id_categoria",
                table: "Livros",
                newName: "IdCategoria");

            migrationBuilder.RenameColumn(
                name: "id_autor",
                table: "Livros",
                newName: "IdAutor");

            migrationBuilder.RenameColumn(
                name: "estado_conservacao",
                table: "Livros",
                newName: "EstadoConservacao");

            migrationBuilder.RenameColumn(
                name: "disponivel_doacao",
                table: "Livros",
                newName: "DisponivelDoacao");

            migrationBuilder.RenameColumn(
                name: "data_publicacao",
                table: "Livros",
                newName: "DataPublicacao");

            migrationBuilder.RenameColumn(
                name: "classificacao_indicativa",
                table: "Livros",
                newName: "ClassificacaoIndicativa");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Enderecos",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Enderecos",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Enderecos",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Enderecos",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Enderecos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contatos",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "disponibilidade",
                table: "Contatos",
                newName: "Disponibilidade");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contatos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_telefone",
                table: "Contatos",
                newName: "IdTelefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Autores",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "introducao",
                table: "Autores",
                newName: "Introducao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Autores",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Autores",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "data_falecimento",
                table: "Autores",
                newName: "DataFalecimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Usuarios",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TipoUsuario",
                table: "Usuarios",
                newName: "tipo_usuario");

            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "Usuarios",
                newName: "id_endereco");

            migrationBuilder.RenameColumn(
                name: "IdContato",
                table: "Usuarios",
                newName: "id_contato");

            migrationBuilder.RenameColumn(
                name: "DataRegistro",
                table: "Usuarios",
                newName: "data_registro");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Usuarios",
                newName: "data_nascimento");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Telefones",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Ddd",
                table: "Telefones",
                newName: "ddd");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Telefones",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Resumo",
                table: "Livros",
                newName: "resumo");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Livros",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "Livros",
                newName: "isbn");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Livros",
                newName: "foto");

            migrationBuilder.RenameColumn(
                name: "QtdPaginas",
                table: "Livros",
                newName: "qtd_paginas");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Livros",
                newName: "id_usuario");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Livros",
                newName: "id_categoria");

            migrationBuilder.RenameColumn(
                name: "IdAutor",
                table: "Livros",
                newName: "id_autor");

            migrationBuilder.RenameColumn(
                name: "EstadoConservacao",
                table: "Livros",
                newName: "estado_conservacao");

            migrationBuilder.RenameColumn(
                name: "DisponivelDoacao",
                table: "Livros",
                newName: "disponivel_doacao");

            migrationBuilder.RenameColumn(
                name: "DataPublicacao",
                table: "Livros",
                newName: "data_publicacao");

            migrationBuilder.RenameColumn(
                name: "ClassificacaoIndicativa",
                table: "Livros",
                newName: "classificacao_indicativa");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Enderecos",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Enderecos",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Enderecos",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Enderecos",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enderecos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contatos",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Disponibilidade",
                table: "Contatos",
                newName: "disponibilidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contatos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdTelefone",
                table: "Contatos",
                newName: "id_telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Autores",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Introducao",
                table: "Autores",
                newName: "introducao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Autores",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Autores",
                newName: "data_nascimento");

            migrationBuilder.RenameColumn(
                name: "DataFalecimento",
                table: "Autores",
                newName: "data_falecimento");
        }
    }
}
