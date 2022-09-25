using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CommercialName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ddd = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    County = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Infrastructure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infrastructure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfrastructureCompany",
                columns: table => new
                {
                    CompaniesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InfrastructuresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfrastructureCompany", x => new { x.CompaniesId, x.InfrastructuresId });
                    table.ForeignKey(
                        name: "FK_InfrastructureCompany_Company_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfrastructureCompany_Infrastructure_InfrastructuresId",
                        column: x => x.InfrastructuresId,
                        principalTable: "Infrastructure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfrastructureCompany_InfrastructuresId",
                table: "InfrastructureCompany",
                column: "InfrastructuresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfrastructureCompany");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Infrastructure");
        }
    }
}
