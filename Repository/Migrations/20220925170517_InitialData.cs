using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Active", "Address", "Cnpj", "CommercialName", "Contact", "Country", "County", "CreationDate", "Ddd", "Email", "Name", "Neighborhood", "Phone", "UF", "UserUpdate", "WebSite", "ZipCode" },
                values: new object[] { new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"), true, "Av. Central, 100", "05.185.409/0001-43", "Zé Gracha", "José da Silva", "Brasil", "Santa isabel", new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(6834), "011", "contato@zegracha.com", "Zé Gracha Ltda", "Centro", "984561122", "SP", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a"), "zegracha.com", "07500000" });

            migrationBuilder.InsertData(
                table: "Infrastructure",
                columns: new[] { "Id", "Active", "CreationDate", "Name", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"), true, new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(8460), "Área para fumante", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") },
                    { new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"), true, new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(8457), "Sala de espera", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") },
                    { new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"), true, new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(8452), "Ar condicionado", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"));

            migrationBuilder.DeleteData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"));

            migrationBuilder.DeleteData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"));

            migrationBuilder.DeleteData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"));
        }
    }
}
