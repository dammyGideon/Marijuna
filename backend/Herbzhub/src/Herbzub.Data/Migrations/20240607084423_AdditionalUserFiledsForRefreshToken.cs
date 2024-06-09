using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserFiledsForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 582, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "RefreshToken", "RefreshTokenExpiryTime", "UpdatedAt" },
                values: new object[] { "$2a$11$xuuG2LYbfV6m.U2hs4NREufliTcULQHx4c4xol9ygdwHnlMsJqMJW", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 8, 44, 22, 745, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 7, 8, 44, 22, 583, DateTimeKind.Utc).AddTicks(986));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$PRlLKJkapHgv4vxDkKDjDO7gm1o/iXxjm2EZVUfWkXCQoAetA8dlW", new DateTime(2024, 6, 6, 0, 14, 10, 353, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8284));
        }
    }
}
