using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TryMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class SmallFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tests",
                type: "TEXT",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 80);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$B0Z6PEUKyzVetYEdk9Jbq.1Jpr9kZ/boyqgBjsNG./.gNQZsFdCRm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$mTw8jV97ITWbKOvxdZqGiOpNH6oAmjvjMG.kBbZOOehuSNKDNzIKG");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Id",
                table: "Answers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Answers_Id",
                table: "Answers");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tests",
                type: "TEXT",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$yYbNHNpndHc3cFAguJ8IvekuaW2mLwyhcBgmPzNOX3q2V.uKV6oHO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$mkQ/onXbpBHwFWvqdBzN3uXm7ahEr5S5gXTHOJrZkln9DH5MCTlQ.");
        }
    }
}
