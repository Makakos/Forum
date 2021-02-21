using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Migrations
{
    public partial class Discussions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Topics_TopicId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_AspNetUsers_UserId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_UserId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Topics");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Messages",
                newName: "DiscussionId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_TopicId",
                table: "Messages",
                newName: "IX_Messages_DiscussionId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discussions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Discussions_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_TopicId",
                table: "Discussions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_UserId",
                table: "Discussions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Discussions_DiscussionId",
                table: "Messages",
                column: "DiscussionId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Discussions_DiscussionId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Topics");

            migrationBuilder.RenameColumn(
                name: "DiscussionId",
                table: "Messages",
                newName: "TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_DiscussionId",
                table: "Messages",
                newName: "IX_Messages_TopicId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "125e8c09-6a8b-4702-89db-70a0c83e0378");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82144d01-245f-4cca-8db3-b23dfba04a2a", "AQAAAAEAACcQAAAAEGdgzNdtIt35/fIR8/XWIr7R0ydKUenfOeQzbNg8kctaE8zVAvhdDQUbK8q/GO0MsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25c57939-f52f-42cb-8056-15f099444c26", "AQAAAAEAACcQAAAAENYqo5wSQJH7OiQ3xPm+Smy45QFTyBR6pcUDNveslRlydpJVCdI6Dz8ktuf6ddkH9Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_Topics_UserId",
                table: "Topics",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Topics_TopicId",
                table: "Messages",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_AspNetUsers_UserId",
                table: "Topics",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
