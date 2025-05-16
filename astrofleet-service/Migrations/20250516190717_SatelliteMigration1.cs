using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace astrofleet_service.Migrations
{
    /// <inheritdoc />
    public partial class SatelliteMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Satellite",
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
                    SatelliteType = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TemperatureCelsius = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satellite", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Satellite");
        }
    }
}
