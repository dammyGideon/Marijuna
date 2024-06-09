using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class initNow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountiesId",
                table: "PersonalIdentifications",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "ManufacturerDispensaries",
                type: "text",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalIdentifications_Counties_CountiesId",
                table: "PersonalIdentifications",
                column: "CountiesId",
                principalTable: "Counties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalIdentifications_Counties_CountiesId",
                table: "PersonalIdentifications");

            migrationBuilder.DropIndex(
                name: "IX_PersonalIdentifications_CountiesId",
                table: "PersonalIdentifications");

            migrationBuilder.DropColumn(
                name: "CountiesId",
                table: "PersonalIdentifications");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "ManufacturerDispensaries");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$rlKcXk1QfmeAttkC9DzVyu51j999lDQuiNYLDXyOQtA56FLxk.9Je", new DateTime(2024, 5, 27, 22, 54, 53, 903, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 27, 22, 54, 53, 603, DateTimeKind.Utc).AddTicks(2614));
        }
    }
}
