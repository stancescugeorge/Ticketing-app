using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectPAW_Stancescu_Georgian_1057.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programatori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Functie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programatori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitluProblema = table.Column<string>(nullable: true),
                    Client = table.Column<string>(nullable: true),
                    DescriereProblema = table.Column<string>(nullable: true),
                    DataRaportare = table.Column<DateTime>(nullable: false),
                    ProgramatorId = table.Column<int>(nullable: false),
                    Gravitate = table.Column<int>(nullable: false),
                    Stadiu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bugs_Programatori_ProgramatorId",
                        column: x => x.ProgramatorId,
                        principalTable: "Programatori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solutii",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescriereSol = table.Column<string>(nullable: true),
                    Cauza = table.Column<string>(nullable: true),
                    DataSol = table.Column<DateTime>(nullable: false),
                    BugId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solutii_Bugs_BugId",
                        column: x => x.BugId,
                        principalTable: "Bugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ProgramatorId",
                table: "Bugs",
                column: "ProgramatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Solutii_BugId",
                table: "Solutii",
                column: "BugId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solutii");

            migrationBuilder.DropTable(
                name: "Bugs");

            migrationBuilder.DropTable(
                name: "Programatori");
        }
    }
}
