using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connectbook.Migrations
{
    /// <inheritdoc />
    public partial class CreatingPendingEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ddd",
                table: "Telefones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numero",
                table: "Telefones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "classificacao_indicativa",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "data_publicacao",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "disponivel_doacao",
                table: "Livros",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "estado_conservacao",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "foto",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_autor",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_categoria",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "isbn",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "qtd_paginas",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "resumo",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bairro",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cep",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cidade",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "disponibilidade",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "id_telefone",
                table: "Contatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "data_falecimento",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "data_nascimento",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "introducao",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ddd",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "numero",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "classificacao_indicativa",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "data_publicacao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "disponivel_doacao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "estado_conservacao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "foto",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "id_autor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "id_categoria",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "isbn",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "qtd_paginas",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "resumo",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "bairro",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "cidade",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "disponibilidade",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "id_telefone",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "data_falecimento",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "data_nascimento",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "introducao",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "Autores");
        }
    }
}
