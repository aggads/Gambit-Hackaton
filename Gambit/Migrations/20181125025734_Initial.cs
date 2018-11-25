using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gambit.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Mi",
                columns: table => new
                {
                    RegisterNumber = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mi", x => x.RegisterNumber);
                });

            migrationBuilder.CreateTable(
                name: "Startup",
                columns: table => new
                {
                    Tva = table.Column<string>(nullable: false),
                    StartupName = table.Column<string>(nullable: true),
                    FounderName = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Risk = table.Column<int>(nullable: false),
                    DeadLine = table.Column<DateTime>(nullable: false),
                    UrlImage = table.Column<string>(nullable: true),
                    CollectedFund = table.Column<int>(nullable: false),
                    TargetGoal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Startup", x => x.Tva);
                    table.ForeignKey(
                        name: "FK_Startup_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiStartup",
                columns: table => new
                {
                    Tva = table.Column<string>(nullable: false),
                    RegisterNumber = table.Column<string>(nullable: false),
                    AmountInvest = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiStartup", x => new { x.RegisterNumber, x.Tva });
                    table.ForeignKey(
                        name: "FK_MiStartup_Mi_RegisterNumber",
                        column: x => x.RegisterNumber,
                        principalTable: "Mi",
                        principalColumn: "RegisterNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiStartup_Startup_Tva",
                        column: x => x.Tva,
                        principalTable: "Startup",
                        principalColumn: "Tva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MiStartup_Tva",
                table: "MiStartup",
                column: "Tva");

            migrationBuilder.CreateIndex(
                name: "IX_Startup_CategoryID",
                table: "Startup",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MiStartup");

            migrationBuilder.DropTable(
                name: "Mi");

            migrationBuilder.DropTable(
                name: "Startup");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
