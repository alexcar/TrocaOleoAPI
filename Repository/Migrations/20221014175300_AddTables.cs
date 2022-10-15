using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfrastructureCompany_Company_CompaniesId",
                table: "InfrastructureCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_InfrastructureCompany_Infrastructure_InfrastructuresId",
                table: "InfrastructureCompany");

            migrationBuilder.CreateTable(
                name: "CreditCardBrand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductManufacturer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductManufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ProductManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductManufacturer_ProductManufacturerId",
                        column: x => x.ProductManufacturerId,
                        principalTable: "ProductManufacturer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyService",
                columns: table => new
                {
                    CompaniesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyService", x => new { x.CompaniesId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_CompanyService_Company_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyService_Service_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductService",
                columns: table => new
                {
                    ProductiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductService", x => new { x.ProductiesId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_ProductService_Product_ProductiesId",
                        column: x => x.ProductiesId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductService_Service_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 737, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.InsertData(
                table: "CreditCardBrand",
                columns: new[] { "Id", "Active", "CreationDate", "Name", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("9f780c05-7252-485d-8cf6-9279272e1086"), true, new DateTime(2022, 10, 14, 14, 52, 59, 737, DateTimeKind.Local).AddTicks(7182), "Visa", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") },
                    { new Guid("c32b3780-5c90-4990-896f-502a478f9a22"), true, new DateTime(2022, 10, 14, 14, 52, 59, 737, DateTimeKind.Local).AddTicks(7173), "Mastercard", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") }
                });

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.InsertData(
                table: "ProductManufacturer",
                columns: new[] { "Id", "Active", "CreationDate", "Name", "UserUpdate" },
                values: new object[,]
                {
                    { new Guid("07ca7d2c-08f0-4848-b760-03aac0ad29f4"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2418), "Shell", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") },
                    { new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2406), "Lubrax Petrobras", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") },
                    { new Guid("d6f0bb03-97c9-41a2-a20c-19e8fc788d72"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2414), "Mobil Industrial", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") },
                    { new Guid("f7becb0d-770c-4fc2-a6e2-c7eb75069af4"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2422), "Ipiranga", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Active", "CreationDate", "Name", "UserUpdate" },
                values: new object[] { new Guid("3e3d9cbd-470d-493b-9fed-fafed765b47a"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(8071), "Troca de Óleo", new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Active", "CreationDate", "Description", "Name", "Price", "ProductManufacturerId", "UserUpdate" },
                values: new object[] { new Guid("47ee3977-ddb6-4d10-aa33-2f5d08d521eb"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(6615), "Óleo Lubrax 20w50", "Óleo Lubrax 20w50 SL 3lt", 149.85m, new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"), new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Active", "CreationDate", "Description", "Name", "Price", "ProductManufacturerId", "UserUpdate" },
                values: new object[] { new Guid("4fb540e6-7b18-4904-bef6-82323c423dc3"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(6601), "Óleo Lubrax 20w50", "Óleo Motor 20w50 Essencial SL", 62.22m, new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"), new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Active", "CreationDate", "Description", "Name", "Price", "ProductManufacturerId", "UserUpdate" },
                values: new object[] { new Guid("a892244e-1ec6-4349-b11c-94c85655a820"), true, new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(6623), "Óleo Lubrax 20w50", "Óleo Do Motor Lubrax Essencial", 39.99m, new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"), new Guid("5cf7137c-ae20-497d-831d-8df824697c8a") });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyService_ServicesId",
                table: "CompanyService",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductManufacturerId",
                table: "Product",
                column: "ProductManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductService_ServicesId",
                table: "ProductService",
                column: "ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_InfrastructureCompany_Company_CompaniesId",
                table: "InfrastructureCompany",
                column: "CompaniesId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InfrastructureCompany_Infrastructure_InfrastructuresId",
                table: "InfrastructureCompany",
                column: "InfrastructuresId",
                principalTable: "Infrastructure",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfrastructureCompany_Company_CompaniesId",
                table: "InfrastructureCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_InfrastructureCompany_Infrastructure_InfrastructuresId",
                table: "InfrastructureCompany");

            migrationBuilder.DropTable(
                name: "CompanyService");

            migrationBuilder.DropTable(
                name: "CreditCardBrand");

            migrationBuilder.DropTable(
                name: "ProductService");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ProductManufacturer");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                column: "CreationDate",
                value: new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"),
                column: "CreationDate",
                value: new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"),
                column: "CreationDate",
                value: new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"),
                column: "CreationDate",
                value: new DateTime(2022, 9, 25, 14, 5, 16, 831, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.AddForeignKey(
                name: "FK_InfrastructureCompany_Company_CompaniesId",
                table: "InfrastructureCompany",
                column: "CompaniesId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InfrastructureCompany_Infrastructure_InfrastructuresId",
                table: "InfrastructureCompany",
                column: "InfrastructuresId",
                principalTable: "Infrastructure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
