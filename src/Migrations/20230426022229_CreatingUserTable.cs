using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connectbook.Migrations
{
    /// <inheritdoc />
    public partial class CreatingUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "data_nascimento",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "data_registro",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "id_contato",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_endereco",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "senha",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tipo_usuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_nascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "data_registro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "descricao",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "id_contato",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "id_endereco",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "senha",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "tipo_usuario",
                table: "Usuarios");
        }
    }
}
