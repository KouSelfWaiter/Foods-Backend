using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"));

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1686), true, false, new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1689) },
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1693), true, false, new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1694) },
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1696), true, false, new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1696) }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CreatedDate", "Name", "RelationId", "TranslationCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1824), "Yiyecek", new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), 0, new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1824) },
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1828), "İçecek", new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), 0, new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1829) },
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"), new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1831), "Tatlı", new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"), 0, new DateTime(2023, 3, 30, 13, 48, 2, 349, DateTimeKind.Utc).AddTicks(1832) }
                });
        }
    }
}
