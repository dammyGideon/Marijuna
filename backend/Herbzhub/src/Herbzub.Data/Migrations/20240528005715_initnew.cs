using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class initnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerDispensaries_cities_CityId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturerDispensaries_CityId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "ManufacturerDispensaries");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$xjMsJnwbwlv4pDNSmm96H.DPZNlhX2mwtNN3eBGaB1ylZDTQ6cnwK", new DateTime(2024, 5, 28, 0, 57, 14, 46, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_BusinessCityId",
                table: "ManufacturerDispensaries",
                column: "BusinessCityId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_BusinessStateId",
                table: "ManufacturerDispensaries",
                column: "BusinessStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerDispensaries_States_BusinessStateId",
                table: "ManufacturerDispensaries",
                column: "BusinessStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerDispensaries_cities_BusinessCityId",
                table: "ManufacturerDispensaries",
                column: "BusinessCityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerDispensaries_States_BusinessStateId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerDispensaries_cities_BusinessCityId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturerDispensaries_BusinessCityId",
                table: "ManufacturerDispensaries");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturerDispensaries_BusinessStateId",
                table: "ManufacturerDispensaries");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "ManufacturerDispensaries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$xbiopJoYwi/mqCwiqrJJ5usPWH9uIzumQsrCvw6q/MlVp8RsSvnMS", new DateTime(2024, 5, 28, 0, 48, 46, 134, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 28, 0, 48, 45, 900, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_CityId",
                table: "ManufacturerDispensaries",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerDispensaries_cities_CityId",
                table: "ManufacturerDispensaries",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
