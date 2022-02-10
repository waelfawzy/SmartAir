using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class MyFirstMigrationnnm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationTypes_ReservationId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumberOfRemainingSeats",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "NumberOfSeats",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Reservations",
                newName: "StatusTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ReservationId",
                table: "Reservations",
                newName: "IX_Reservations_StatusTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SmartConfigurations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Seats",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservationTypeId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Organizations",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Organizations",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "HaveDelivery",
                table: "Organizations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Organizations",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntegrationConfigurationId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IntegrationProductionURL",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestingProductionURL",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IntegrationConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APIName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    InsertionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntegrationConfiguration_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StatusType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResuestBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IntegrationConfigurationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationsTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntegrationsTransactions_IntegrationConfiguration_IntegrationConfigurationId",
                        column: x => x.IntegrationConfigurationId,
                        principalTable: "IntegrationConfiguration",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CurrencyId",
                table: "Reservations",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationTypeId",
                table: "Reservations",
                column: "ReservationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationConfiguration_OrganizationId",
                table: "IntegrationConfiguration",
                column: "OrganizationId",
                unique: true,
                filter: "[OrganizationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTransactions_IntegrationConfigurationId",
                table: "IntegrationsTransactions",
                column: "IntegrationConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Currency_CurrencyId",
                table: "Reservations",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationTypes_ReservationTypeId",
                table: "Reservations",
                column: "ReservationTypeId",
                principalTable: "ReservationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_StatusType_StatusTypeId",
                table: "Reservations",
                column: "StatusTypeId",
                principalTable: "StatusType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Currency_CurrencyId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationTypes_ReservationTypeId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_StatusType_StatusTypeId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "IntegrationsTransactions");

            migrationBuilder.DropTable(
                name: "StatusType");

            migrationBuilder.DropTable(
                name: "IntegrationConfiguration");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CurrencyId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "IntegrationConfigurationId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "IntegrationProductionURL",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "TestingProductionURL",
                table: "Organizations");

            migrationBuilder.RenameColumn(
                name: "StatusTypeId",
                table: "Reservations",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_StatusTypeId",
                table: "Reservations",
                newName: "IX_Reservations_ReservationId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SmartConfigurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Organizations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Organizations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HaveDelivery",
                table: "Organizations",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRemainingSeats",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeats",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationTypes_ReservationId",
                table: "Reservations",
                column: "ReservationId",
                principalTable: "ReservationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
