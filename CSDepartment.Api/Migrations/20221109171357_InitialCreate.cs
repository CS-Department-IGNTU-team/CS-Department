using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSDepartment.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => new { x.Title, x.Timestamp });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PostTimestamp = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PostTitle = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => new { x.Name, x.Timestamp });
                    table.ForeignKey(
                        name: "FK_Media_Posts_PostTitle_PostTimestamp",
                        columns: x => new { x.PostTitle, x.PostTimestamp },
                        principalTable: "Posts",
                        principalColumns: new[] { "Title", "Timestamp" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Email", "Name", "Password", "Role" },
                values: new object[] { "admin", "mrunpredictable3679@gmail.com", "Admin", "4321", "Administrator" });

            migrationBuilder.CreateIndex(
                name: "IX_Media_PostTitle_PostTimestamp",
                table: "Media",
                columns: new[] { "PostTitle", "PostTimestamp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
