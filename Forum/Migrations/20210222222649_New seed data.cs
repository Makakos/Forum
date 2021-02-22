using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Migrations
{
    public partial class Newseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Discussions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "818527a2-800a-4d46-8cbf-be5548bd752a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54321g86-1846-3ag8-v38q-h387ae1b6eab", "b804917a-8743-48f5-b239-7f744d49cd85", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e53784c-111e-4097-aea7-72ca1e1791a9", "AQAAAAEAACcQAAAAEAr6OtOFeyXdnzAnCT+fhO0fvx9GJjPdqTXSC77SALnI4DGEGkpfeRt34D99PipcCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bf466b8-d3c6-4072-adb8-175a7bf1683b", "AQAAAAEAACcQAAAAEEXM3LqA3RcyGa/Bl7rx3w849P0YYopmIdi9+QYrbvk9Ta3Vxq6O5x1mrAIne0Yr8w==" });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Java" },
                    { 3, "Python" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "54321g86-1846-3ag8-v38q-h387ae1b6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "Id", "Date", "Description", "Name", "TopicId", "UserId" },
                values: new object[] { 2, new DateTime(2021, 2, 23, 0, 26, 48, 437, DateTimeKind.Local).AddTicks(3898), "How to implement intefaces?", "Interfaces", 1, "6g29322e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "Id", "Date", "Description", "Name", "TopicId", "UserId" },
                values: new object[] { 1, new DateTime(2021, 2, 23, 0, 26, 48, 433, DateTimeKind.Local).AddTicks(4117), "I need to use LINQ but I dont know how", "What is LINQ", 1, "6g29322e-4f66-49fa-a20f-e7685b9565d8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54321g86-1846-3ag8-v38q-h387ae1b6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54321g86-1846-3ag8-v38q-h387ae1b6eab");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Discussions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "38d33419-cb70-4d57-9a18-07d0d6f87d59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6a8a3c8-69ec-49f3-a1c7-41463fba3b60", "AQAAAAEAACcQAAAAEHlW0TPmF+bOCoiRL+9cd23EDCadHC8omUvtIomaFBpUWHmcqkzWZIFZqpcwuiYBfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7e3fa83-4ccf-4035-abef-c242ab11e10a", "AQAAAAEAACcQAAAAEPAj7cif5ukdBjMf1kEpeHs0gRo9o0MlzBNM6y0k/MDZxvasIElKeYhCHubav7Pycg==" });
        }
    }
}
