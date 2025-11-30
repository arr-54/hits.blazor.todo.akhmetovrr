using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class NameRust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Taskitems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Taskitems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 28, 0, 8, 6, 300, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 28, 0, 8, 6, 300, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 28, 0, 8, 6, 300, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 28, 0, 8, 6, 300, DateTimeKind.Local).AddTicks(4289));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Taskitems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Taskitems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 11, 25, 23, 29, 51, 267, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 11, 25, 23, 29, 51, 267, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 11, 25, 23, 29, 51, 267, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Taskitems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 11, 25, 23, 29, 51, 267, DateTimeKind.Local).AddTicks(7096));
        }
    }
}
