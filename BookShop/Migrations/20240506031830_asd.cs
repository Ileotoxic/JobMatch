using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "31e382f2-d194-4f3d-b342-2a2fb0433771");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "60e8f89e-0a6c-48ef-8844-06d819b2f2f4");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "a82cefe5-b873-4321-a076-fd7edfdbede3");

            migrationBuilder.DeleteData(
                table: "JobListingModels",
                keyColumn: "JobListingId",
                keyValue: "e655119b-aae2-40cc-9861-3d13029e4767");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ApplicationModels",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ApplicationModels");

            migrationBuilder.InsertData(
                table: "JobListingModels",
                columns: new[] { "JobListingId", "ApplicationDeadline", "CategoryId", "Description", "EmployerApplicationId", "ImagePath", "ImageUploaded", "Location", "Title" },
                values: new object[,]
                {
                    { "31e382f2-d194-4f3d-b342-2a2fb0433771", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "3", "Basic language", null, null, false, "NY", "Java Programming" },
                    { "60e8f89e-0a6c-48ef-8844-06d819b2f2f4", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "4", "Really not easy", null, null, false, "NY", "Data Structures" },
                    { "a82cefe5-b873-4321-a076-fd7edfdbede3", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2", "Learning Harder", null, null, false, "NY", "Advanced Programming" },
                    { "e655119b-aae2-40cc-9861-3d13029e4767", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "1", "Hello", null, null, false, "NY", "C# Programming" }
                });
        }
    }
}
