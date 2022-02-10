using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class addControleAndValidationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ControllerNames",
                table: "Validations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasValue",
                table: "Validations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValidationTypeId",
                table: "Validations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "FieldsValidations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ControleId",
                table: "Fields",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasValidation",
                table: "Fields",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Controle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValidationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Validations_ValidationTypeId",
                table: "Validations",
                column: "ValidationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_ControleId",
                table: "Fields",
                column: "ControleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_Controle_ControleId",
                table: "Fields",
                column: "ControleId",
                principalTable: "Controle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Validations_ValidationTypes_ValidationTypeId",
                table: "Validations",
                column: "ValidationTypeId",
                principalTable: "ValidationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fields_Controle_ControleId",
                table: "Fields");

            migrationBuilder.DropForeignKey(
                name: "FK_Validations_ValidationTypes_ValidationTypeId",
                table: "Validations");

            migrationBuilder.DropTable(
                name: "Controle");

            migrationBuilder.DropTable(
                name: "ValidationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Validations_ValidationTypeId",
                table: "Validations");

            migrationBuilder.DropIndex(
                name: "IX_Fields_ControleId",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "ControllerNames",
                table: "Validations");

            migrationBuilder.DropColumn(
                name: "HasValue",
                table: "Validations");

            migrationBuilder.DropColumn(
                name: "ValidationTypeId",
                table: "Validations");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "FieldsValidations");

            migrationBuilder.DropColumn(
                name: "Caption",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "ControleId",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "HasValidation",
                table: "Fields");
        }
    }
}
