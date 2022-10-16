using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class updatenametableproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 671, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("9f780c05-7252-485d-8cf6-9279272e1086"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("c32b3780-5c90-4990-896f-502a478f9a22"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47ee3977-ddb6-4d10-aa33-2f5d08d521eb"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 673, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4fb540e6-7b18-4904-bef6-82323c423dc3"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 673, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a892244e-1ec6-4349-b11c-94c85655a820"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 673, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("07ca7d2c-08f0-4848-b760-03aac0ad29f4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("d6f0bb03-97c9-41a2-a20c-19e8fc788d72"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("f7becb0d-770c-4fc2-a6e2-c7eb75069af4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 672, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("3e3d9cbd-470d-493b-9fed-fafed765b47a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 16, 10, 22, 3, 673, DateTimeKind.Local).AddTicks(2357));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 737, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("9f780c05-7252-485d-8cf6-9279272e1086"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 737, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("c32b3780-5c90-4990-896f-502a478f9a22"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 737, DateTimeKind.Local).AddTicks(7173));

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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47ee3977-ddb6-4d10-aa33-2f5d08d521eb"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4fb540e6-7b18-4904-bef6-82323c423dc3"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a892244e-1ec6-4349-b11c-94c85655a820"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("07ca7d2c-08f0-4848-b760-03aac0ad29f4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("d6f0bb03-97c9-41a2-a20c-19e8fc788d72"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("f7becb0d-770c-4fc2-a6e2-c7eb75069af4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("3e3d9cbd-470d-493b-9fed-fafed765b47a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 14, 14, 52, 59, 738, DateTimeKind.Local).AddTicks(8071));
        }
    }
}
