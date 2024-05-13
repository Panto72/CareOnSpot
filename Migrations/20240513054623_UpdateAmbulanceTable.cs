using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareOnSpot.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAmbulanceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MedicineName",
                table: "MedicalShop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "MedicalShop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMedicalSupport",
                table: "ambulances",
                type: "bit",
                maxLength: 20,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "ambulances",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 11, 46, 20, 936, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 11, 46, 20, 936, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 11, 46, 20, 936, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 11, 46, 20, 936, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 11, 46, 20, 936, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 11, 46, 20, 936, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 6, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MedicineName",
                table: "MedicalShop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "MedicalShop",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsMedicalSupport",
                table: "ambulances",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "ambulances",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 0, 36, 21, 294, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 0, 36, 21, 294, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 0, 36, 21, 294, DateTimeKind.Unspecified).AddTicks(6370), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 0, 36, 21, 294, DateTimeKind.Unspecified).AddTicks(6372), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 0, 36, 21, 294, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 13, 0, 36, 21, 294, DateTimeKind.Unspecified).AddTicks(6375), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}
