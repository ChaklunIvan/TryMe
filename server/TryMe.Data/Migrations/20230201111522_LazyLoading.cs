using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TryMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class LazyLoading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$lMPSsM6ToCB3kzOgLT9WcejHGnIbEuH92sPzMHJLnovw3sOQ.s6I6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$I/46nAJAlu2V/BCuIstjguLEDPoMiBqoX1J9OLD1B6/r.lJWmrnOe");
        }
    }
}
