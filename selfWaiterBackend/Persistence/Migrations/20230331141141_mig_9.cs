using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "TableNo", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ac947-a4f7-4785-9a48-b46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), false, false, "1", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ac947-a4f7-4785-9a48-b46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), false, false, "1", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ac947-a4f7-4785-9a48-b46e2a600003"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, "1", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CreatedDate", "Name", "RelationId", "TranslationCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Yiyecek", new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "İçecek", new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Tatlı", new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "IsActive", "IsDeleted", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-c4f7-4785-9a48-d46e2a600001"), new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, 48m, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9a48-d46e2a600002"), new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, 50m, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9a48-d46e2a600003"), new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, 50m, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9a48-d46e2a600004"), new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, 24m, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9a48-d46e2a600005"), new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, 24m, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9a48-d46e2a600006"), new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, false, 24m, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "RelationId", "TranslationCode", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600001"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "", "Portakal Suyu", new Guid("000ec947-c4f7-4785-9a48-d46e2a600002"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600002"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Nefis lahmacun", "Lahmacun", new Guid("000ec947-c4f7-4785-9a48-d46e2a600001"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600003"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Ağzınızı Serinletecek buz gibi milkshake", "MilkShake", new Guid("000ec947-c4f7-4785-9a48-d46e2a600004"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600004"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Taze çekilmiş türk kahvesi ile 40 yıl hatır", "Türk Kahvesi", new Guid("000ec947-c4f7-4785-9a48-d46e2a600005"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600005"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Yöresel Kıymalı Pide", "Kıymalı Pide", new Guid("000ec947-c4f7-4785-9a48-d46e2a600003"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600006"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "", "Çorba", new Guid("000ec947-c4f7-4785-9a48-d46e2a600006"), 0, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600101"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "", "Orange Juice", new Guid("000ec947-c4f7-4785-9a48-d46e2a600002"), 1, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("000ec947-c4f7-4785-9b48-d46e2a600104"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "40 years of memory with freshly ground Turkish coffee", "Turkish coffee", new Guid("000ec947-c4f7-4785-9a48-d46e2a600005"), 1, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("000ac947-a4f7-4785-9a48-b46e2a600001"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("000ac947-a4f7-4785-9a48-b46e2a600002"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("000ac947-a4f7-4785-9a48-b46e2a600003"));

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
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600001"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600002"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600003"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600004"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600005"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600006"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600101"));

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9b48-d46e2a600104"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9a48-d46e2a600001"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9a48-d46e2a600002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9a48-d46e2a600003"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9a48-d46e2a600004"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9a48-d46e2a600005"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-c4f7-4785-9a48-d46e2a600006"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"));
        }
    }
}
