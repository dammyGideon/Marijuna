using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class initit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerDispensaries_States_StateId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropIndex(
                name: "IX_PersonalIdentifications_CountiesId",
                table: "PersonalIdentifications");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturerDispensaries_StateId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "ManufacturerDispensaries");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$ZmYUVm3YpgbabbXZ7mXPMOI.M3kNEbZIoHAzIvAAd5VrJHFNso3Ee", new DateTime(2024, 5, 28, 0, 42, 43, 473, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 42, 43, 248, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifications_CountiesId",
                table: "PersonalIdentifications",
                column: "CountiesId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonalIdentifications_CountiesId",
                table: "PersonalIdentifications");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "ManufacturerDispensaries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$q7fdkbtRtAtu/lWUHC5QZuJF7TNxBe7yGvt/RvN5PDGMa55r2DlK.", new DateTime(2024, 5, 28, 0, 10, 52, 356, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 10, 52, 22, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifications_CountiesId",
                table: "PersonalIdentifications",
                column: "CountiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_StateId",
                table: "ManufacturerDispensaries",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerDispensaries_States_StateId",
                table: "ManufacturerDispensaries",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
