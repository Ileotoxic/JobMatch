using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class asdasf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "33b6db05-a09a-423b-bddc-44dd00e0ad6c");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "b49a660c-5b84-48cc-b5ae-5dc0e938f3f9");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "d8157985-dadf-48ae-883f-c266adfe6c82");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "d8181e6e-ca6a-4fd1-8454-132d7c54d6db");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Categories",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "1",
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "2",
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "3",
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "4",
                column: "Status",
                value: true);

            migrationBuilder.InsertData(
                table: "JobListingModels",
                columns: new[] { "JobListingId", "ApplicationDeadline", "CategoryId", "Description", "EmployerApplicationId", "ImagePath", "ImageUploaded", "Location", "Title" },
                values: new object[,]
                {
                    { "050f533f-9d15-40c6-9dac-eb42f5721b68", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "4", "Really not easy", null, null, false, "NY", "Data Structures" },
                    { "3206576e-6433-4568-ba9b-65f9b6cafeb6", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1", "Hello", null, null, false, "NY", "C# Programming" },
                    { "9e032e95-4489-4e0a-9844-933b756045db", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2", "Learning Harder", null, null, false, "NY", "Advanced Programming" },
                    { "cb10d019-d03f-418d-9843-d304dc599363", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "3", "Basic language", null, null, false, "NY", "Java Programming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "050f533f-9d15-40c6-9dac-eb42f5721b68");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "3206576e-6433-4568-ba9b-65f9b6cafeb6");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "9e032e95-4489-4e0a-9844-933b756045db");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "cb10d019-d03f-418d-9843-d304dc599363");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "JobListingModels",
                columns: new[] { "JobListingId", "ApplicationDeadline", "CategoryId", "Description", "EmployerApplicationId", "ImagePath", "ImageUploaded", "Location", "Title" },
                values: new object[,]
                {
                    { "33b6db05-a09a-423b-bddc-44dd00e0ad6c", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2", "Learning Harder", null, null, false, "NY", "Advanced Programming" },
                    { "b49a660c-5b84-48cc-b5ae-5dc0e938f3f9", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "3", "Basic language", null, null, false, "NY", "Java Programming" },
                    { "d8157985-dadf-48ae-883f-c266adfe6c82", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1", "Hello", null, null, false, "NY", "C# Programming" },
                    { "d8181e6e-ca6a-4fd1-8454-132d7c54d6db", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "4", "Really not easy", null, null, false, "NY", "Data Structures" }
                });
        }
    }
}
