using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connectbook.Migrations
{
    /// <inheritdoc />
    public partial class GeneratingForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Livros");

            migrationBuilder.AlterColumn<int>(
                name: "TipoUsuario",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataRegistro",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Livros",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Contatos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdContato",
                table: "Usuarios",
                column: "IdContato");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdEndereco",
                table: "Usuarios",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_IdAutor",
                table: "Livros",
                column: "IdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_IdUsuario",
                table: "Livros",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_IdTelefone",
                table: "Contatos",
                column: "IdTelefone");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_UsuarioId",
                table: "Contatos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Telefones_IdTelefone",
                table: "Contatos",
                column: "IdTelefone",
                principalTable: "Telefones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Usuarios_UsuarioId",
                table: "Contatos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_IdAutor",
                table: "Livros",
                column: "IdAutor",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Usuarios_IdUsuario",
                table: "Livros",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Contatos_IdContato",
                table: "Usuarios",
                column: "IdContato",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Enderecos_IdEndereco",
                table: "Usuarios",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Telefones_IdTelefone",
                table: "Contatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Usuarios_UsuarioId",
                table: "Contatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_IdAutor",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Usuarios_IdUsuario",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Contatos_IdContato",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Enderecos_IdEndereco",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdContato",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdEndereco",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Livros_IdAutor",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_IdUsuario",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Contatos_IdTelefone",
                table: "Contatos");

            migrationBuilder.DropIndex(
                name: "IX_Contatos_UsuarioId",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Contatos");

            migrationBuilder.AlterColumn<string>(
                name: "TipoUsuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DataRegistro",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DataNascimento",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
