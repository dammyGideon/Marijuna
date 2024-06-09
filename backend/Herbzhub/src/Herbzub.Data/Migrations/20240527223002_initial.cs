using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    HashPassword = table.Column<string>(type: "text", nullable: false),
                    PasswordResetToken = table.Column<string>(type: "text", nullable: true),
                    ResetTokenExpiry = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalIdentifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalIdentifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalIdentifications_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalIdentifications_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalIdentifications_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SMSVerificationCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthenticationEntityId = table.Column<int>(type: "integer", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    verification_code = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSVerificationCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SMSVerificationCodes_Users_AuthenticationEntityId",
                        column: x => x.AuthenticationEntityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerDispensaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalIdentificationId = table.Column<int>(type: "integer", nullable: false),
                    StateLicenseNumber = table.Column<string>(type: "text", nullable: false),
                    LegalBusinessName = table.Column<string>(type: "text", nullable: false),
                    BusinessEIN = table.Column<string>(type: "text", nullable: false),
                    BusinessEmail = table.Column<string>(type: "text", nullable: false),
                    BusinessContact = table.Column<string>(type: "text", nullable: false),
                    BusinessAddress = table.Column<string>(type: "text", nullable: false),
                    BusinessCityId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    BusinessStateId = table.Column<int>(type: "integer", nullable: false),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    BusinessZipCode = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerDispensaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManufacturerDispensaries_PersonalIdentifications_PersonalId~",
                        column: x => x.PersonalIdentificationId,
                        principalTable: "PersonalIdentifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturerDispensaries_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturerDispensaries_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adair" },
                    { 2, "Andrew" },
                    { 3, "Atchison" },
                    { 4, "Audrain" },
                    { 5, "Barry" },
                    { 6, "Barton" },
                    { 7, "Bates" },
                    { 8, "Benton" },
                    { 9, "Bollinger" },
                    { 10, "Boone" },
                    { 11, "Buchanan" },
                    { 12, "Butler" },
                    { 13, "Caldwell" },
                    { 14, "Callaway" },
                    { 15, "Camden" },
                    { 16, "Cape Girardeau" },
                    { 17, "Carroll" },
                    { 18, "Carter" },
                    { 19, "Cass" },
                    { 20, "Cedar" },
                    { 21, "Chariton" },
                    { 22, "Christian" },
                    { 23, "Clark" },
                    { 24, "Clay" },
                    { 25, "Clinton" },
                    { 26, "Cole" },
                    { 27, "Cooper" },
                    { 28, "Crawford" },
                    { 29, "Dade" },
                    { 30, "Dallas" },
                    { 31, "Daviess" },
                    { 32, "DeKalb" },
                    { 33, "Dent" },
                    { 34, "Douglas" },
                    { 35, "Dunklin" },
                    { 36, "Franklin" },
                    { 37, "Gasconade" },
                    { 38, "Gentry" },
                    { 39, "Greene" },
                    { 40, "Grundy" },
                    { 41, "Harrison" },
                    { 42, "Henry" },
                    { 43, "Hickory" },
                    { 44, "Holt" },
                    { 45, "Howard" },
                    { 46, "Howell" },
                    { 47, "Iron" },
                    { 48, "Jackson" },
                    { 49, "Jasper" },
                    { 50, "Jefferson" },
                    { 51, "Johnson" },
                    { 52, "Knox" },
                    { 53, "Laclede" },
                    { 54, "Lafayette" },
                    { 55, "Lawrence" },
                    { 56, "Lewis" },
                    { 57, "Lincoln" },
                    { 58, "Linn" },
                    { 59, "Livingston" },
                    { 60, "Macon" },
                    { 61, "Madison" },
                    { 62, "Maries" },
                    { 63, "Marion" },
                    { 64, "McDonald" },
                    { 65, "Mercer" },
                    { 66, "Miller" },
                    { 67, "Mississippi" },
                    { 68, "Moniteau" },
                    { 69, "Monroe" },
                    { 70, "Montgomery" },
                    { 71, "Morgan" },
                    { 72, "New Madrid" },
                    { 73, "Newton" },
                    { 74, "Nodaway" },
                    { 75, "Oregon" },
                    { 76, "Osage" },
                    { 77, "Ozark" },
                    { 78, "Pemiscot" },
                    { 79, "Perry" },
                    { 80, "Pettis" },
                    { 81, "Phelps" },
                    { 82, "Pike" },
                    { 83, "Platte" },
                    { 84, "Polk" },
                    { 85, "Pulaski" },
                    { 86, "Putnam" },
                    { 87, "Ralls" },
                    { 88, "Randolph" },
                    { 89, "Ray" },
                    { 90, "Reynolds" },
                    { 91, "Ripley" },
                    { 92, "St. Charles" },
                    { 93, "St. Clair" },
                    { 94, "St. Francois" },
                    { 95, "St. Louis" },
                    { 96, "Ste. Genevieve" },
                    { 97, "Saline" },
                    { 98, "Schuyler" },
                    { 99, "Scotland" },
                    { 100, "Scott" },
                    { 101, "Shannon" },
                    { 102, "Shelby" },
                    { 103, "Stoddard" },
                    { 104, "Stone" },
                    { 105, "Sullivan" },
                    { 106, "Taney" },
                    { 107, "Texas" },
                    { 108, "Vernon" },
                    { 109, "Warren" },
                    { 110, "Washington" },
                    { 111, "Wayne" },
                    { 112, "Webster" },
                    { 113, "Worth" },
                    { 114, "Wright" },
                    { 115, "City of St. Louis" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(32) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(39) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "United Kingdom", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(40) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nigeria", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(41) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Togo", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(42) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manufacturer", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(1172) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manufacturer Driver", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(1177) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dispensary", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(1178) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Driver", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(1179) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(1180) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "AL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alabama", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(413) },
                    { 2, "AK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alaska", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(417) },
                    { 3, "AZ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arizona", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(418) },
                    { 4, "AR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arkansas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(419) },
                    { 5, "CA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(421) },
                    { 6, "CO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorado", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(424) },
                    { 7, "CT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connecticut", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(425) },
                    { 8, "DE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delaware", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(426) },
                    { 9, "FL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florida", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(427) },
                    { 10, "GA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(429) },
                    { 11, "HI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(430) },
                    { 12, "ID", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Idaho", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(432) },
                    { 13, "IL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illinois", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(433) },
                    { 14, "IN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indiana", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(434) },
                    { 15, "IA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iowa", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(435) },
                    { 16, "KS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kansas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(436) },
                    { 17, "KY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kentucky", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(438) },
                    { 18, "LA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louisiana", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(440) },
                    { 19, "ME", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maine", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(441) },
                    { 20, "MD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maryland", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(443) },
                    { 21, "MA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massachusetts", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(551) },
                    { 22, "MI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michigan", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(554) },
                    { 23, "MN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minnesota", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(555) },
                    { 24, "MS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mississippi", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(557) },
                    { 25, "MO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missouri", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(558) },
                    { 26, "MT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montana", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(559) },
                    { 27, "NE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nebraska", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(560) },
                    { 28, "NV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevada", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(562) },
                    { 29, "NH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Hampshire", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(563) },
                    { 30, "NJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Jersey", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(564) },
                    { 31, "NM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Mexico", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(565) },
                    { 32, "NY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(567) },
                    { 33, "NC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Carolina", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(568) },
                    { 34, "ND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Dakota", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(573) },
                    { 35, "OH", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ohio", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(574) },
                    { 36, "OK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oklahoma", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(575) },
                    { 37, "OR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oregon", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(577) },
                    { 38, "PA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pennsylvania", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(578) },
                    { 39, "RI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rhode Island", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(579) },
                    { 40, "SC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Carolina", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(580) },
                    { 41, "SD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Dakota", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(581) },
                    { 42, "TN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(582) },
                    { 43, "TX", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(583) },
                    { 44, "UT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Utah", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(585) },
                    { 45, "VT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vermont", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(586) },
                    { 46, "VA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(587) },
                    { 47, "WA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(588) },
                    { 48, "WV", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Virginia", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(589) },
                    { 49, "WI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wisconsin", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(590) },
                    { 50, "WY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyoming", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(591) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "HashPassword", "PasswordResetToken", "ResetTokenExpiry", "UpdatedAt" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "$2a$11$0BBZcD2TIct9xlwrNPiCXOL0yF/4.G2JD9Xu86jh2AczlWvtKNzEC", null, null, new DateTime(2024, 5, 27, 22, 30, 1, 891, DateTimeKind.Utc).AddTicks(4948) });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "Id", "CreatedAt", "Name", "State", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York City", "New York", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(854) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(861) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "Illinois", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(862) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(863) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "Arizona", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(864) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philadelphia", "Pennsylvania", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(868) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Antonio", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(869) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(870) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(871) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Jose", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(874) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(875) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacksonville", "Florida", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(876) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fort Worth", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(877) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbus", "Ohio", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(878) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Francisco", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(880) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", "North Carolina", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(881) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indianapolis", "Indiana", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(882) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle", "Washington", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(884) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denver", "Colorado", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(885) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", "District of Columbia", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(887) },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boston", "Massachusetts", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(888) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Paso", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(889) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nashville", "Tennessee", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(890) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Detroit", "Michigan", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(891) },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oklahoma City", "Oklahoma", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(892) },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portland", "Oregon", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(894) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las Vegas", "Nevada", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(895) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memphis", "Tennessee", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(896) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louisville", "Kentucky", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(897) },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baltimore", "Maryland", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(898) },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milwaukee", "Wisconsin", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(899) },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albuquerque", "New Mexico", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(900) },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tucson", "Arizona", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(901) },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresno", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(904) },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sacramento", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(905) },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kansas City", "Missouri", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(906) },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long Beach", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(907) },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mesa", "Arizona", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(908) },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlanta", "Georgia", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(909) },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorado Springs", "Colorado", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(910) },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia Beach", "Virginia", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(911) },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raleigh", "North Carolina", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(913) },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omaha", "Nebraska", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(914) },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", "Florida", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(915) },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oakland", "California", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(916) },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minneapolis", "Minnesota", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(917) },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tulsa", "Oklahoma", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(918) },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wichita", "Kansas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(919) },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Orleans", "Louisiana", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(921) },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlington", "Texas", new DateTime(2024, 5, 27, 22, 30, 1, 690, DateTimeKind.Utc).AddTicks(922) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_CityId",
                table: "ManufacturerDispensaries",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_PersonalIdentificationId",
                table: "ManufacturerDispensaries",
                column: "PersonalIdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerDispensaries_StateId",
                table: "ManufacturerDispensaries",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifications_CityId",
                table: "PersonalIdentifications",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifications_StateId",
                table: "PersonalIdentifications",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalIdentifications_userId",
                table: "PersonalIdentifications",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SMSVerificationCodes_AuthenticationEntityId",
                table: "SMSVerificationCodes",
                column: "AuthenticationEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ManufacturerDispensaries");

            migrationBuilder.DropTable(
                name: "SMSVerificationCodes");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "PersonalIdentifications");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
