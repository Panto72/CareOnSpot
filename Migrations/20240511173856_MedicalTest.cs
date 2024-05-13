using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareOnSpot.Migrations
{
    /// <inheritdoc />
    public partial class MedicalTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalTest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Price = table.Column<double>(type: "float", maxLength: 10, nullable: true),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalTest_Hospitals_HospitalId",
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

            migrationBuilder.CreateIndex(
                name: "IX_MedicalTest_HospitalId",
                table: "MedicalTest",
                column: "HospitalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalTest");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 13, 16, 30, 920, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 13, 16, 30, 920, DateTimeKind.Unspecified).AddTicks(5419), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 13, 16, 30, 920, DateTimeKind.Unspecified).AddTicks(5421), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 13, 16, 30, 920, DateTimeKind.Unspecified).AddTicks(5423), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 13, 16, 30, 920, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 13, 16, 30, 920, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}
