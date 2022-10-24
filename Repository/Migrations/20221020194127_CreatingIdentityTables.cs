using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreatingIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
