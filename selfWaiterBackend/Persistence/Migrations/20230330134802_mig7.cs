using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1824), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1686), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1693), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1696), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1696) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4503), new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4510), new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4513), new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4317), new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4328), new DateTime(2023, 3, 29, 14, 31, 35, 778, DateTimeKind.Utc).AddTicks(4328) });
        }
    }
}
