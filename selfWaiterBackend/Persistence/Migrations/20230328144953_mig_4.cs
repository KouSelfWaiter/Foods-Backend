using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3696), true, false, new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3698) },
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3700), true, false, new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3700) },
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3702), true, false, new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3703) }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CreatedDate", "Name", "RelationId", "TranslationCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4012), "Yiyecek", new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), 0, new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4012) },
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4015), "İçecek", new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), 0, new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4016) },
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4018), "Tatlı", new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"), 0, new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4018) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
