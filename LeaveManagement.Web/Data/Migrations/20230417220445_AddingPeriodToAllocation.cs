using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1f256f4-1502-4f34-b2e4-534cc5b34f08", "AQAAAAIAAYagAAAAEH7A8pG1V7jWAFXvMBLh8Bv/lq3MettEzl5ghJnRX0rm7pPCKII66u9GBFx6v346nA==", "cefaa964-c1f9-4236-9fa0-6274d36f004f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a3f07f4-009b-4b66-9016-163e76e7a724", "AQAAAAIAAYagAAAAEKCnpvUmXly9p1ifEtz/2yagc/zeta5Y7Vhux64M921Wi9kvE2tQ3YaVGgu1xXNT9Q==", "331e91e1-968c-465e-8464-d01797c56739" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1666aa02-e061-4111-a897-c9e5f7940398", "AQAAAAIAAYagAAAAEEiYFW69OFQ8sw9whq+gckprupCzGuCBBlv3bhHb39FvkdpXXK8H5V5uMeEHPZ846A==", "f74f0667-8304-4320-be59-1249b97c44ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad4a6e-f7bb-4448-baaf-ladd431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51fd6b74-ed1b-4104-a4f4-77c1ec3932b2", "AQAAAAIAAYagAAAAEExfARfwgo2+lnjBqOtBppIeTKPAbmbV6q11KRnR2bvM1P/SX3v9mDer5EWoYWEQag==", "e6a7435d-9ad0-4c37-8f06-2a16c08c6031" });
        }
    }
}
