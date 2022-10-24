using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08a07250-e34e-4684-9dc1-e7bab51e88ce", "c9274499-9810-4a72-a3f8-eff9418f8bf6", "manager", "MANAGER" },
                    { "9d754397-43de-47eb-879a-5a93403430b7", "e9144f21-560c-4f84-87f2-87a983194f6a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("9f780c05-7252-485d-8cf6-9279272e1086"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("c32b3780-5c90-4990-896f-502a478f9a22"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47ee3977-ddb6-4d10-aa33-2f5d08d521eb"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 689, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4fb540e6-7b18-4904-bef6-82323c423dc3"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 689, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a892244e-1ec6-4349-b11c-94c85655a820"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 689, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("07ca7d2c-08f0-4848-b760-03aac0ad29f4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("d6f0bb03-97c9-41a2-a20c-19e8fc788d72"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("f7becb0d-770c-4fc2-a6e2-c7eb75069af4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 688, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("3e3d9cbd-470d-493b-9fed-fafed765b47a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 50, 20, 689, DateTimeKind.Local).AddTicks(5434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08a07250-e34e-4684-9dc1-e7bab51e88ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d754397-43de-47eb-879a-5a93403430b7");

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: new Guid("c5eb9331-ae52-4c97-9f1a-eeef506f05df"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 860, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("9f780c05-7252-485d-8cf6-9279272e1086"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 860, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "CreditCardBrand",
                keyColumn: "Id",
                keyValue: new Guid("c32b3780-5c90-4990-896f-502a478f9a22"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 860, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("05dd35ae-c60d-4349-98b1-ba990fed57d5"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("3b90f7bc-2bb1-455f-a46e-2fdffbdd0167"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Infrastructure",
                keyColumn: "Id",
                keyValue: new Guid("884bc531-f0e6-463b-aa9f-f0ac9d8b521a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("47ee3977-ddb6-4d10-aa33-2f5d08d521eb"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4fb540e6-7b18-4904-bef6-82323c423dc3"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a892244e-1ec6-4349-b11c-94c85655a820"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("07ca7d2c-08f0-4848-b760-03aac0ad29f4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("45a0fbef-bd12-4fc5-ae7a-4f99a8e8f34d"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("d6f0bb03-97c9-41a2-a20c-19e8fc788d72"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductManufacturer",
                keyColumn: "Id",
                keyValue: new Guid("f7becb0d-770c-4fc2-a6e2-c7eb75069af4"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("3e3d9cbd-470d-493b-9fed-fafed765b47a"),
                column: "CreationDate",
                value: new DateTime(2022, 10, 20, 16, 41, 26, 861, DateTimeKind.Local).AddTicks(2996));
        }
    }
}
