using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareOnSpot.Migrations
{
    /// <inheritdoc />
    public partial class Emergencyhelplocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectArea",
                table: "EmergencyHelps");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "EmergencyHelps",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 16, 3, 52, 191, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 16, 3, 52, 191, DateTimeKind.Unspecified).AddTicks(9349), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 16, 3, 52, 191, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 16, 3, 52, 191, DateTimeKind.Unspecified).AddTicks(9354), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 16, 3, 52, 191, DateTimeKind.Unspecified).AddTicks(9356), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 16, 3, 52, 191, DateTimeKind.Unspecified).AddTicks(9358), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyHelps_LocationId",
                table: "EmergencyHelps",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyHelps_Location_LocationId",
                table: "EmergencyHelps",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyHelps_Location_LocationId",
                table: "EmergencyHelps");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyHelps_LocationId",
                table: "EmergencyHelps");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "EmergencyHelps");

            migrationBuilder.AddColumn<string>(
                name: "SelectArea",
                table: "EmergencyHelps",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 15, 22, 22, 171, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 15, 22, 22, 171, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 15, 22, 22, 171, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 15, 22, 22, 171, DateTimeKind.Unspecified).AddTicks(3127), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 15, 22, 22, 171, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 15, 22, 22, 171, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}
