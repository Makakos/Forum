using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Migrations
{
    public partial class _9messagesseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a55e4425-e6da-462c-aeac-e3921d2424b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54321g86-1846-3ag8-v38q-h387ae1b6eab",
                column: "ConcurrencyStamp",
                value: "52c30ba3-0516-48e5-97cf-c58da0c95ad9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68e22d31-6c38-490d-922e-d37ca3a8ea91", "AQAAAAEAACcQAAAAEE4TgthYQr+04AgmVvggAwClGEh7ix7AGs9il0Ufv4PQjt5GZz04V0P7U/p0dnnGUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d135f725-4341-4820-a712-a69f9c974e9c", "AQAAAAEAACcQAAAAEOqltTy5QB8jfyTHTH7tEhWHf/7zA/qsHME9ayoYDaGC0KwR67cZaIHa7UJP090Ebg==" });

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 2, 23, 12, 36, 43, 802, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 2, 23, 12, 36, 43, 806, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 2, 23, 12, 36, 43, 807, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 2, 23, 12, 36, 43, 807, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 2, 23, 12, 36, 43, 807, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Date", "DiscussionId", "Text", "UserId" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 2, 23, 12, 36, 43, 808, DateTimeKind.Local).AddTicks(515), 5, "test message 9", "6g29322e-4f66-49fa-a20f-e7685b9565d8" },
                    { 7, new DateTime(2021, 2, 23, 12, 36, 43, 808, DateTimeKind.Local).AddTicks(227), 4, "test message 7", "6g29322e-4f66-49fa-a20f-e7685b9565d8" },
                    { 6, new DateTime(2021, 2, 23, 12, 36, 43, 808, DateTimeKind.Local).AddTicks(169), 3, "test message 6", "3b62472e-4f66-49fa-a20f-e7685b9565d8" },
                    { 5, new DateTime(2021, 2, 23, 12, 36, 43, 808, DateTimeKind.Local).AddTicks(98), 3, "test message 5", "6g29322e-4f66-49fa-a20f-e7685b9565d8" },
                    { 4, new DateTime(2021, 2, 23, 12, 36, 43, 808, DateTimeKind.Local).AddTicks(40), 2, "test message 4", "3b62472e-4f66-49fa-a20f-e7685b9565d8" },
                    { 3, new DateTime(2021, 2, 23, 12, 36, 43, 807, DateTimeKind.Local).AddTicks(9970), 2, "test message 3", "6g29322e-4f66-49fa-a20f-e7685b9565d8" },
                    { 2, new DateTime(2021, 2, 23, 12, 36, 43, 807, DateTimeKind.Local).AddTicks(9737), 1, "test message 2", "3b62472e-4f66-49fa-a20f-e7685b9565d8" },
                    { 8, new DateTime(2021, 2, 23, 12, 36, 43, 808, DateTimeKind.Local).AddTicks(285), 4, "test message 8", "3b62472e-4f66-49fa-a20f-e7685b9565d8" },
                    { 1, new DateTime(2021, 2, 23, 12, 36, 43, 807, DateTimeKind.Local).AddTicks(5494), 1, "test message 1", "6g29322e-4f66-49fa-a20f-e7685b9565d8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

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
                column: "Date",
                value: new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Discussions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 2, 23, 9, 56, 28, 113, DateTimeKind.Local).AddTicks(3475));
        }
    }
}
