using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class newIntial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

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
                columns: new[] { "RoleName", "UpdatedAt" },
                values: new object[] { "Dispensary", new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RoleName", "UpdatedAt" },
                values: new object[] { "Transporter", new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RoleName", "UpdatedAt" },
                values: new object[] { "Customer", new DateTime(2024, 6, 6, 0, 14, 10, 170, DateTimeKind.Utc).AddTicks(8473) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "RoleName", "UpdatedAt" },
                values: new object[] { "Manufacturer Driver", new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RoleName", "UpdatedAt" },
                values: new object[] { "Dispensary", new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RoleName", "UpdatedAt" },
                values: new object[] { "Customer Driver", new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer", new DateTime(2024, 5, 28, 0, 57, 13, 740, DateTimeKind.Utc).AddTicks(3833) });

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
        }
    }
}
