using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac4a6e-f7bb-4448-baaf-ladd431ccbbf", null, "Administrator", "ADMINISTRATOR" },
                    { "cac4a6e-f8bb-4447-baaf-ladd431ccbbf", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bab4a6e-f7bb-4448-baaf-ladd431ccbbf", 0, "1666aa02-e061-4111-a897-c9e5f7940398", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost", true, "System", "Admin", false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEEiYFW69OFQ8sw9whq+gckprupCzGuCBBlv3bhHb39FvkdpXXK8H5V5uMeEHPZ846A==", null, false, "f74f0667-8304-4320-be59-1249b97c44ca", null, false, "admin@localhost" },
                    { "dad4a6e-f7bb-4448-baaf-ladd431ccbbf", 0, "51fd6b74-ed1b-4104-a4f4-77c1ec3932b2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost", true, "System", "User", false, null, "USER@LOCALHOST", "USER@LOCALHOST", "AQAAAAIAAYagAAAAEExfARfwgo2+lnjBqOtBppIeTKPAbmbV6q11KRnR2bvM1P/SX3v9mDer5EWoYWEQag==", null, false, "e6a7435d-9ad0-4c37-8f06-2a16c08c6031", null, false, "user@localhost" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cac4a6e-f7bb-4448-baaf-ladd431ccbbf", "bab4a6e-f7bb-4448-baaf-ladd431ccbbf" },
                    { "cac4a6e-f8bb-4447-baaf-ladd431ccbbf", "dad4a6e-f7bb-4448-baaf-ladd431ccbbf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac4a6e-f7bb-4448-baaf-ladd431ccbbf", "bab4a6e-f7bb-4448-baaf-ladd431ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac4a6e-f8bb-4447-baaf-ladd431ccbbf", "dad4a6e-f7bb-4448-baaf-ladd431ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac4a6e-f7bb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac4a6e-f8bb-4447-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab4a6e-f7bb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad4a6e-f7bb-4448-baaf-ladd431ccbbf");
        }
    }
}
