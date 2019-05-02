using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassTest.Migrations
{
    public partial class register : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Gender = table.Column<string>(maxLength: 30, nullable: false),
                    DOB = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Address = table.Column<string>(maxLength: 30, nullable: false),
                    Highest_Qualification = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 30, nullable: false),
                    Hobbies = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
