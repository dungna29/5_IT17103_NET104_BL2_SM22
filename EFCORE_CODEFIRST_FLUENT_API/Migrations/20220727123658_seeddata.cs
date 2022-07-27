using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCORE_CODEFIRST_FLUENT_API.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 27, 19, 36, 58, 437, DateTimeKind.Local).AddTicks(9356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 26, 23, 31, 31, 994, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder" },
                values: new object[] { 1, true, 0, 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder" },
                values: new object[] { 2, true, 1, 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder" },
                values: new object[] { 3, true, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 7, 26, 23, 31, 31, 994, DateTimeKind.Local).AddTicks(7139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 7, 27, 19, 36, 58, 437, DateTimeKind.Local).AddTicks(9356));
        }
    }
}
