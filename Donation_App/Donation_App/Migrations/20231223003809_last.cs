using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donation_App.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    DonorImage = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrgEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    OrgPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrgEmail);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrganizationEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Card_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_Donations_Donors_DonorEmail",
                        column: x => x.DonorEmail,
                        principalTable: "Donors",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Organizations_OrganizationEmail",
                        column: x => x.OrganizationEmail,
                        principalTable: "Organizations",
                        principalColumn: "OrgEmail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorEmail",
                table: "Donations",
                column: "DonorEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_OrganizationEmail",
                table: "Donations",
                column: "OrganizationEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
