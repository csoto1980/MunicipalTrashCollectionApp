using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8515f3fa-1fdd-4b7c-9f3d-e4b31aa571aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52803ec-da6a-469d-8e85-950364f59b97");

            migrationBuilder.AlterColumn<int>(
                name: "OneTimePickup",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c85311f-335d-4880-8c37-09984bd667d7", "96d9e20f-c221-49ae-9bec-e224db88924d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "722b627e-cf62-44c8-9863-1fdda3ecff49", "6313fcb2-5df3-4117-86cd-1334cc356b5d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c85311f-335d-4880-8c37-09984bd667d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "722b627e-cf62-44c8-9863-1fdda3ecff49");

            migrationBuilder.AlterColumn<int>(
                name: "OneTimePickup",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a52803ec-da6a-469d-8e85-950364f59b97", "ea1936db-0894-48bf-b2ee-02a012202885", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8515f3fa-1fdd-4b7c-9f3d-e4b31aa571aa", "8d806ef3-b7c9-4c16-9c1d-df2d84a35ed1", "Employee", "EMPLOYEE" });
        }
    }
}
