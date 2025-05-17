using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace astrofleet_service.Migrations
{
    /// <inheritdoc />
    public partial class SatelliteBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Satellites",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FamilyCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ElevationInKilometers = table.Column<double>(type: "double", nullable: false),
                    MassInKilograms = table.Column<double>(type: "double", nullable: false),
                    OrbitStartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OrbitType = table.Column<int>(type: "int", nullable: false),
                    HomePlanet = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satellites", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Satellites");
        }
    }
}
