using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CareOnSpot.Migrations
{
    /// <inheritdoc />
    public partial class DoctorSpeciality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialitie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialitie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Specialitie",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Title", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2024, 5, 9, 11, 54, 20, 213, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 6, 0, 0, 0)), "Consult dermatologists for skin, hair, and nail conditions.", "Dermatology", null, null },
                    { 2, 1, new DateTimeOffset(new DateTime(2024, 5, 9, 11, 54, 20, 213, DateTimeKind.Unspecified).AddTicks(8090), new TimeSpan(0, 6, 0, 0, 0)), "Consult dermatologists for skin, hair, and nail conditions.", "Ophthalmology", null, null },
                    { 3, 1, new DateTimeOffset(new DateTime(2024, 5, 9, 11, 54, 20, 213, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 6, 0, 0, 0)), "Consult dermatologists for skin, hair, and nail conditions.", "Pediatrics", null, null },
                    { 4, 1, new DateTimeOffset(new DateTime(2024, 5, 9, 11, 54, 20, 213, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 6, 0, 0, 0)), "Consult dermatologists for skin, hair, and nail conditions.", "Cardiology", null, null },
                    { 5, 1, new DateTimeOffset(new DateTime(2024, 5, 9, 11, 54, 20, 213, DateTimeKind.Unspecified).AddTicks(8097), new TimeSpan(0, 6, 0, 0, 0)), "Consult dermatologists for skin, hair, and nail conditions.", "Psychiatry", null, null },
                    { 6, 1, new DateTimeOffset(new DateTime(2024, 5, 9, 11, 54, 20, 213, DateTimeKind.Unspecified).AddTicks(8099), new TimeSpan(0, 6, 0, 0, 0)), "Consult dermatologists for skin, hair, and nail conditions.", "Orthopedics", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialitie");
        }
    }
}
