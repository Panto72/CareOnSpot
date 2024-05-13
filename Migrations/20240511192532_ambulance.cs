using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareOnSpot.Migrations
{
    /// <inheritdoc />
    public partial class ambulance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ambulances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalId = table.Column<int>(type: "int", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    ContacNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsMedicalSupport = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ambulances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ambulances_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 12, 1, 25, 31, 568, DateTimeKind.Unspecified).AddTicks(1265), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 12, 1, 25, 31, 568, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 12, 1, 25, 31, 568, DateTimeKind.Unspecified).AddTicks(1297), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 12, 1, 25, 31, 568, DateTimeKind.Unspecified).AddTicks(1299), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 12, 1, 25, 31, 568, DateTimeKind.Unspecified).AddTicks(1301), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 12, 1, 25, 31, 568, DateTimeKind.Unspecified).AddTicks(1302), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ambulances_HospitalId",
                table: "ambulances",
                column: "HospitalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ambulances");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 11, 23, 38, 54, 834, DateTimeKind.Unspecified).AddTicks(9911), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 11, 23, 38, 54, 834, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 11, 23, 38, 54, 834, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 11, 23, 38, 54, 834, DateTimeKind.Unspecified).AddTicks(9949), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 11, 23, 38, 54, 834, DateTimeKind.Unspecified).AddTicks(9951), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 11, 23, 38, 54, 834, DateTimeKind.Unspecified).AddTicks(9953), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}
