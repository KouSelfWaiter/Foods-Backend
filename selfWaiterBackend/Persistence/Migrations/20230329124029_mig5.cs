using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4012), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4015), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4018), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3696), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3700), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3702), new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3703) });
        }
    }
}
