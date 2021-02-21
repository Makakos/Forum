using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Migrations
{
    public partial class Avatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Topics_TopicId",
                table: "Discussions");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Discussions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Topics_TopicId",
                table: "Discussions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Topics_TopicId",
                table: "Discussions");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Discussions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a8ce8a4a-acad-4e89-b746-a68de4125930");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "089df056-787b-4c47-8c81-331f6ea13cab", "AQAAAAEAACcQAAAAEF/KaMrrUaWafFIGxqvPLicybrOQafIGrGtdiJtUml1nc9lz6/ABw6Wio/ScS0XQ0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "606c561c-eaf5-4a66-8879-c924a6a19774", "AQAAAAEAACcQAAAAECIEPbI7qJgedJf0/CW0JuMqbT7uGq+pQn2iHZTTux4zAzcQhkoewrHMr860tiVsow==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Topics_TopicId",
                table: "Discussions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
