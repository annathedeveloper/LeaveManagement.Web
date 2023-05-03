using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaxIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee02572-8bfb-4a5e-98f0-a824becc6ea1", "AQAAAAIAAYagAAAAEEAohTDLMwaSez1mmle8jmDX2Wp1GjVKyTykw8HGDR996YZYmmcH/JLsoV6nLvJaYQ==", "75b7077f-18fd-4306-8a90-6915e5f1fbd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06adba83-110b-43c0-916b-8737b340a802", "AQAAAAIAAYagAAAAEF8NYX3d2Nz1kl+8xZeR92p3Sd29N8zsOsML6hQxW3UpmjCbfgPQNd4ksJOcWrpB3w==", "b7cd1b8d-62e9-4eef-b86a-c714d1f2ba6f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f1d1c3f-1365-4c2e-8382-987f8044d267", "AQAAAAIAAYagAAAAEOEV1/Qz7lU2toGaOCs7/7WLeb1SnfvHCsjq4SbkGgMmggxWx0QIhjDpLJkrj3B81A==", "d2a1b474-2304-4e2b-b019-7a3bbba943ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dc69ec4-b674-4023-a1fb-01af6c5ceef0", "AQAAAAIAAYagAAAAEGEU0idBPpzi5jIaTWEaUIkhswXlmyh2ac1agfikT/w30LPvFI5+ukQ3JAFdI5NFYw==", "c2caee8d-b997-4526-b32f-221cb323537b" });
        }
    }
}
