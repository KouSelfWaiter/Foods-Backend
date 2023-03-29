using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6487), new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6492), new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6496), new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6343), new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6349), new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6352), new DateTime(2023, 3, 29, 12, 40, 28, 994, DateTimeKind.Utc).AddTicks(6352) });
        }
    }
}
