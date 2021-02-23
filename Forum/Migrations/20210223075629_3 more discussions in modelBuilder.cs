using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Migrations
{
    public partial class _3morediscussionsinmodelBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5774a407-fd7f-445d-95af-89561478f497");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54321g86-1846-3ag8-v38q-h387ae1b6eab",
                column: "ConcurrencyStamp",
                value: "b54d54d7-a5a8-4084-a5ed-0050d63ed66f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "066e1e2a-de61-48b3-8d7b-6ca894516d92", "AQAAAAEAACcQAAAAEEna1HFbJogOd/E+SxRk70zh6iBhGxHA7hIiQfCbO3rfJxbsNW+Lx/89vVmf9oxqVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77c7d650-b45c-4ad1-9244-e66eaaff02b7", "AQAAAAEAACcQAAAAEI4/erOXwqf04fIRIckuj8AMHNzC8cjSjboxETUJFbajqNipK7n/pCk8cQ7vECXEIA==" });

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 2, 23, 9, 56, 28, 108, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3072), "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "Id", "Date", "Description", "Name", "TopicId", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3265), "What is incapsulation?", "OOP", 1, "6g29322e-4f66-49fa-a20f-e7685b9565d8" },
                    { 4, new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3327), "Which lenguage should i choose?", "Java vs C#", 2, "3b62472e-4f66-49fa-a20f-e7685b9565d8" },
                    { 5, new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3475), "how to declare array in python", "Array", 3, "6g29322e-4f66-49fa-a20f-e7685b9565d8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "818527a2-800a-4d46-8cbf-be5548bd752a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54321g86-1846-3ag8-v38q-h387ae1b6eab",
                column: "ConcurrencyStamp",
                value: "b804917a-8743-48f5-b239-7f744d49cd85");

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

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 2, 23, 0, 26, 48, 433, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2021, 2, 23, 0, 26, 48, 437, DateTimeKind.Local).AddTicks(3898), "6g29322e-4f66-49fa-a20f-e7685b9565d8" });
        }
    }
}
