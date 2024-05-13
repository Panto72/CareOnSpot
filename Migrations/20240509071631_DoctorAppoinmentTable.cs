using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareOnSpot.Migrations
{
    /// <inheritdoc />
    public partial class DoctorAppoinmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "specialty",
                table: "Doctors",
                newName: "Specialty");

            migrationBuilder.RenameColumn(
                name: "experience",
                table: "Doctors",
                newName: "Experience");

            migrationBuilder.CreateTable(
                name: "DoctorAppointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialitieId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(85)", maxLength: 85, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PreferredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConferenceLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAppointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorAppointment_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorAppointment_Specialities_SpecialitieId",
                        column: x => x.SpecialitieId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAppointment_DoctorId",
                table: "DoctorAppointment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAppointment_SpecialitieId",
                table: "DoctorAppointment",
                column: "SpecialitieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorAppointment");

            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "Doctors",
                newName: "specialty");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Doctors",
                newName: "experience");

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7373), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2024, 5, 9, 11, 58, 11, 560, DateTimeKind.Unspecified).AddTicks(7377), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}
