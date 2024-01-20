using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentityCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    TenantId = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, دوار واعظی, 8, ريسوت, Colombia", "الدويم", new DateTime(2024, 1, 20, 11, 54, 8, 583, DateTimeKind.Local).AddTicks(6324), "asamh59@gmail.com", "705.872.2391" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, ش فاطمی, 050, الحريق, Sao Tome and Principe", "قلقيلية", new DateTime(2024, 1, 20, 10, 39, 10, 875, DateTimeKind.Local).AddTicks(3233), "shymaa86@hotmail.com", "1-606-977-3038 x46934" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 4811, الرقة, Taiwan", "أم الفحم", new DateTime(2024, 1, 20, 10, 38, 27, 804, DateTimeKind.Local).AddTicks(8280), "jmanh.aqyl16@yahoo.com", "837-536-2884" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اقبال لاهوری, 7, عنيزة, Guernsey", "كفرشوبا", new DateTime(2024, 1, 19, 21, 43, 10, 512, DateTimeKind.Local).AddTicks(207), "jmanh_fuad38@yahoo.com", "844.961.7324 x052" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, دوار یادگار امام, 0, ورقلة, Guinea-Bissau", "صور", new DateTime(2024, 1, 20, 14, 51, 10, 858, DateTimeKind.Local).AddTicks(6043), "zyd_blal9@gmail.com", "680-664-5674 x637" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 77, الجش, Greenland", "الكرك", new DateTime(2024, 1, 19, 23, 7, 31, 99, DateTimeKind.Local).AddTicks(4961), "iynas15@hotmail.com", "(310) 893-0387 x693" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, 5348, تدمر, Nepal", "عقوبة", new DateTime(2024, 1, 20, 9, 0, 33, 834, DateTimeKind.Local).AddTicks(6127), "rqyh_marwf3@yahoo.com", "408-985-0258" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 0737, إدفو, Slovakia (Slovak Republic)", "جونية", new DateTime(2024, 1, 20, 12, 9, 7, 738, DateTimeKind.Local).AddTicks(2995), "fuad.asamh20@hotmail.com", "1-586-385-2264" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, شارع دیباجی, 214, بنجرير, Poland", "مدينة الحرير", new DateTime(2024, 1, 20, 16, 1, 11, 441, DateTimeKind.Local).AddTicks(305), "slah53@gmail.com", "(304) 594-4388 x0020" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, 901, مادبا, United States of America", "الدقم", new DateTime(2024, 1, 20, 5, 46, 52, 842, DateTimeKind.Local).AddTicks(773), "abyr64@hotmail.com", "667.744.6646 x08121" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, طريق مالک اشتر, 93, الرمادي, Denmark", "الدوحة", new DateTime(2024, 1, 20, 11, 38, 39, 853, DateTimeKind.Local).AddTicks(8574), "rbya43@gmail.com", "748-346-3581" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 8476, كيهيدي, Zambia", "مدينة عيسى", new DateTime(2024, 1, 20, 8, 17, 48, 628, DateTimeKind.Local).AddTicks(6787), "shymaa_iyhab59@hotmail.com", "644.315.7737" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, شارع سمیه, 84, الهفوف, Luxembourg", "قريات", new DateTime(2024, 1, 19, 23, 46, 59, 84, DateTimeKind.Local).AddTicks(9916), "rqyh_iyhab@hotmail.com", "860.741.6476 x11534" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, ش ابوذر, 013, تل كيف, Benin", "شبين الكوم", new DateTime(2024, 1, 20, 3, 51, 49, 157, DateTimeKind.Local).AddTicks(4028), "fuad84@gmail.com", "743-251-2352 x0382" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, 93, مدنين, Albania", "الأزرق", new DateTime(2024, 1, 20, 1, 34, 29, 796, DateTimeKind.Local).AddTicks(982), "mna92@gmail.com", "971-757-9688 x2494" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, طريق یادگار امام, 064, بلبيس, Congo", "آلاك", new DateTime(2024, 1, 19, 22, 6, 29, 517, DateTimeKind.Local).AddTicks(4647), "blal_aashwr@gmail.com", "(533) 398-4579" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, ش یادگار امام, 9957, الخليل, Malawi", "توريرت", new DateTime(2024, 1, 19, 22, 28, 34, 486, DateTimeKind.Local).AddTicks(382), "fatmh.araqy@gmail.com", "(812) 465-0604" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, تقاطع سمیه, 9, صير بني ياس, Zambia", "القيصومة", new DateTime(2024, 1, 20, 1, 34, 57, 902, DateTimeKind.Local).AddTicks(3145), "rbya.farwq@gmail.com", "1-578-252-6336 x807" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, تقاطع اقبال لاهوری, 026, العلمة, Bosnia and Herzegovina", "تطوان", new DateTime(2024, 1, 20, 4, 42, 3, 655, DateTimeKind.Local).AddTicks(428), "farwq_jabr@gmail.com", "611.227.8560 x08943" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, 0985, بوكى, Sudan", "تنومة", new DateTime(2024, 1, 19, 19, 53, 23, 234, DateTimeKind.Local).AddTicks(5218), "amjd_jabr99@yahoo.com", "1-548-325-8951" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 651, اليوسفية, Israel", "أسيوط", new DateTime(2024, 1, 20, 15, 21, 7, 638, DateTimeKind.Local).AddTicks(9426), "hazm59@gmail.com", "275-415-0315 x095" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, ش حقانی, 82, دسوق, Cote d'Ivoire", "زحلة", new DateTime(2024, 1, 20, 11, 53, 9, 371, DateTimeKind.Local).AddTicks(5716), "sarh_salm@gmail.com", "(695) 720-6304" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, ش کارگر شمالی, 38, القصر الكبير, Armenia", "الشارقة", new DateTime(2024, 1, 20, 15, 37, 31, 49, DateTimeKind.Local).AddTicks(8535), "hajr.iyhab58@yahoo.com", "(311) 985-1421 x160" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, 6, العريش, Luxembourg", "تبوك", new DateTime(2024, 1, 20, 12, 31, 43, 292, DateTimeKind.Local).AddTicks(8086), "arwa69@hotmail.com", "470.868.9243 x57729" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, تقاطع دکتر چمران, 9011, اولاد التايمة, China", "ملكال", new DateTime(2024, 1, 20, 18, 16, 48, 656, DateTimeKind.Local).AddTicks(994), "rbya_zyd@hotmail.com", "454.372.8926 x26200" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, طريق دکتر چمران, 234, الخرج, Namibia", "ريسوت", new DateTime(2024, 1, 20, 6, 45, 38, 65, DateTimeKind.Local).AddTicks(8327), "hsn.tarq18@yahoo.com", "896-892-1078 x915" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, 4003, كيفة, Cayman Islands", "العريش", new DateTime(2024, 1, 20, 3, 3, 44, 617, DateTimeKind.Local).AddTicks(8481), "arwa.asamh67@gmail.com", "1-692-875-4234" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, ميدان آذربایجان, 431, برشيد, Slovakia (Slovak Republic)", "حلب", new DateTime(2024, 1, 20, 10, 46, 48, 696, DateTimeKind.Local).AddTicks(4255), "sayd.aadm@gmail.com", "(538) 985-4007 x938" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 03, سيلبابي, Myanmar", "ثول", new DateTime(2024, 1, 20, 16, 48, 29, 264, DateTimeKind.Local).AddTicks(5458), "jabr.amjd@hotmail.com", "1-893-652-0813" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, 19, خريبة السوق, Sweden", "المحلة الكبرى", new DateTime(2024, 1, 19, 22, 42, 49, 694, DateTimeKind.Local).AddTicks(2684), "abyr_sayd@yahoo.com", "(674) 577-7904 x24484" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 1901, بجاية, Honduras", "سنجة", new DateTime(2024, 1, 20, 10, 41, 53, 213, DateTimeKind.Local).AddTicks(8377), "tarq43@gmail.com", "1-825-419-2324" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 7756, الجزائر, Cuba", "سامراء", new DateTime(2024, 1, 20, 15, 28, 31, 301, DateTimeKind.Local).AddTicks(5878), "zyd96@hotmail.com", "516-305-6399" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, طريق کارگر شمالی, 85, أربيل, Bhutan", "المالكية", new DateTime(2024, 1, 20, 10, 17, 1, 660, DateTimeKind.Local).AddTicks(466), "rym_aashwr@hotmail.com", "1-348-370-2674 x2005" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, تقاطع آزادی, 6239, سيلبابي, Netherlands", "خان شيخون", new DateTime(2024, 1, 20, 15, 7, 15, 576, DateTimeKind.Local).AddTicks(4677), "iynas.blal@hotmail.com", "1-323-383-7465 x496" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, دوار شهید مطهری, 8456, ارمناز, Brunei Darussalam", "حارم", new DateTime(2024, 1, 20, 7, 52, 41, 626, DateTimeKind.Local).AddTicks(998), "aayh94@hotmail.com", "957.429.5777 x14419" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, ميدان یادگار امام, 7892, سيان, Iceland", "السلط", new DateTime(2024, 1, 19, 20, 53, 31, 436, DateTimeKind.Local).AddTicks(4485), "aayh.aashwr@yahoo.com", "(229) 427-3915" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, طريق استاد قریب, 7765, حديثة, Montserrat", "الليث", new DateTime(2024, 1, 20, 11, 46, 49, 346, DateTimeKind.Local).AddTicks(5594), "arwa_fuad8@gmail.com", "1-977-743-0308 x72171" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, ش دماوند, 4599, معرة النعمان, Thailand", "بلبيس", new DateTime(2024, 1, 19, 20, 16, 45, 168, DateTimeKind.Local).AddTicks(9522), "abyr56@hotmail.com", "1-492-884-5097 x6098" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, طريق اقبال لاهوری, 167, دير البلح, Switzerland", "بنها", new DateTime(2024, 1, 20, 8, 46, 41, 814, DateTimeKind.Local).AddTicks(3196), "fatmh_rbya85@hotmail.com", "(798) 863-3273 x9602" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, ش فاطمی, 7, اكجوجت, Timor-Leste", "الخرطوم", new DateTime(2024, 1, 20, 16, 29, 23, 957, DateTimeKind.Local).AddTicks(8428), "shymaa67@yahoo.com", "343.796.7055 x07351" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, ميدان استاد قریب, 104, القيروان, France", "رأس الخيمة", new DateTime(2024, 1, 20, 4, 42, 53, 687, DateTimeKind.Local).AddTicks(6024), "aadm51@gmail.com", "1-207-247-5228 x69162" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, 890, تونس, Cuba", "الجفر", new DateTime(2024, 1, 20, 9, 13, 48, 812, DateTimeKind.Local).AddTicks(1305), "amjd_aadm@yahoo.com", "843.877.2541 x25403" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 351, اكجوجت, Burkina Faso", "كركوك", new DateTime(2024, 1, 19, 21, 1, 21, 855, DateTimeKind.Local).AddTicks(1525), "rna58@hotmail.com", "1-937-243-6365 x1634" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, طريق راستوان, 442, باجل, Moldova", "كفر كنا", new DateTime(2024, 1, 20, 5, 25, 45, 899, DateTimeKind.Local).AddTicks(8460), "amjd.aqyl@gmail.com", "903.745.6168" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, 30, النعمة, South Africa", "الزرقاء", new DateTime(2024, 1, 20, 9, 37, 49, 10, DateTimeKind.Local).AddTicks(254), "rym_zyd@gmail.com", "1-270-807-9626 x094" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, دوار امیرکبیر, 02, الظهران, Antigua and Barbuda", "جلب", new DateTime(2024, 1, 20, 17, 54, 25, 280, DateTimeKind.Local).AddTicks(2284), "mna_blal99@hotmail.com", "829.866.4393 x96214" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, شارع مالک اشتر, 20, بسكرة, Bolivia", "الشامية", new DateTime(2024, 1, 20, 5, 42, 56, 272, DateTimeKind.Local).AddTicks(4769), "amjd77@yahoo.com", "1-928-783-8612" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 1, الرويس, Kyrgyz Republic", "مسقط", new DateTime(2024, 1, 20, 0, 3, 16, 802, DateTimeKind.Local).AddTicks(2437), "rbya.aqyl@hotmail.com", "856.407.3045" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, شارع راستوان, 1287, سوسه, Estonia", "دهوك", new DateTime(2024, 1, 20, 12, 17, 4, 973, DateTimeKind.Local).AddTicks(6903), "hajr.asamh@gmail.com", "1-670-499-8513" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 62, درعا, Benin", "العريش", new DateTime(2024, 1, 20, 8, 3, 44, 450, DateTimeKind.Local).AddTicks(7329), "dana97@yahoo.com", "(654) 494-1867 x933" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, شارع یادگار امام, 021, كفر الدوار, Taiwan", "الدوادمي", new DateTime(2024, 1, 20, 0, 32, 25, 563, DateTimeKind.Local).AddTicks(7538), "fatmh.hazm@hotmail.com", "1-628-598-0933" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, تقاطع دماوند, 5080, شبين الكوم, Burundi", "قنا", new DateTime(2024, 1, 20, 9, 33, 17, 936, DateTimeKind.Local).AddTicks(6216), "hajr.amjd37@hotmail.com", "447-561-9482 x0267" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, دوار کارگر شمالی, 2, السيب, Brunei Darussalam", "الرباط", new DateTime(2024, 1, 19, 23, 54, 20, 442, DateTimeKind.Local).AddTicks(6440), "shymaa.sayd@gmail.com", "324-723-7925 x42793" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, ميدان دماوند, 8, اولاد التايمة, Serbia", "صحم", new DateTime(2024, 1, 20, 18, 5, 57, 800, DateTimeKind.Local).AddTicks(9398), "jmanh1@yahoo.com", "(443) 233-3122" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 41, سيدي بلعباس, Jordan", "الباحة", new DateTime(2024, 1, 20, 16, 27, 21, 249, DateTimeKind.Local).AddTicks(9700), "blal23@gmail.com", "1-317-382-0043" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, طريق سمیه, 466, كفر الدوار, Gabon", "القويسمة", new DateTime(2024, 1, 20, 0, 32, 22, 492, DateTimeKind.Local).AddTicks(3111), "hazm_blal@yahoo.com", "215.682.1883 x2253" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, 9, تيفلت, Cape Verde", "عفك", new DateTime(2024, 1, 20, 17, 54, 7, 782, DateTimeKind.Local).AddTicks(428), "aayh.hsn@yahoo.com", "403.748.5502" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, شارع آفریقا, 697, بنها, Democratic People's Republic of Korea", "الكاظمية", new DateTime(2024, 1, 20, 17, 21, 44, 462, DateTimeKind.Local).AddTicks(759), "fatmh.aashwr90@gmail.com", "326.418.6341 x1788" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, ش آذربایجان, 329, جرجا, Bahrain", "بلبيس", new DateTime(2024, 1, 20, 1, 54, 28, 388, DateTimeKind.Local).AddTicks(5638), "fryd.tarq50@hotmail.com", "741.956.8859 x641" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, 5, سنجة, Martinique", "تلمسان", new DateTime(2024, 1, 20, 8, 24, 18, 179, DateTimeKind.Local).AddTicks(2120), "iynas83@hotmail.com", "848-772-2909 x76870" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع ابوذر, 806, الفلوجة, Saudi Arabia", "ذي سفال", new DateTime(2024, 1, 20, 2, 4, 45, 533, DateTimeKind.Local).AddTicks(2666), "lma63@yahoo.com", "1-823-258-1600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, 45, الوكرة, Antigua and Barbuda", "الرس", new DateTime(2024, 1, 20, 10, 15, 29, 961, DateTimeKind.Local).AddTicks(4155), "fatmh28@gmail.com", "483.925.7553 x71205" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, 9371, طنطا, New Caledonia", "العوجا", new DateTime(2024, 1, 20, 17, 1, 28, 451, DateTimeKind.Local).AddTicks(7362), "iynas_aqyl@gmail.com", "1-949-614-1606" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, ش سمیه, 29, المنيا, Vanuatu", "ربك", new DateTime(2024, 1, 20, 1, 51, 2, 934, DateTimeKind.Local).AddTicks(7609), "rqyh50@gmail.com", "1-701-582-5040 x87611" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, ميدان شهید مطهری, 4511, ملكال, Malawi", "مسعد", new DateTime(2024, 1, 19, 18, 35, 50, 915, DateTimeKind.Local).AddTicks(61), "arwa_iyhab@yahoo.com", "736.499.8614" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 460, جدة, Anguilla", "نالوت", new DateTime(2024, 1, 19, 22, 2, 18, 577, DateTimeKind.Local).AddTicks(4219), "hsn15@gmail.com", "671-897-4651" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, 0801, عجلون, United States Minor Outlying Islands", new DateTime(2024, 1, 20, 8, 33, 51, 633, DateTimeKind.Local).AddTicks(291), "blal38@yahoo.com", "1-594-250-0556 x59016" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, 40, العقير, Uzbekistan", "جاردو", new DateTime(2024, 1, 20, 14, 58, 4, 192, DateTimeKind.Local).AddTicks(1224), "zynb.rbya@gmail.com", "(358) 983-7380" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, 55, سيهات, Germany", "جالكاسيو", new DateTime(2024, 1, 19, 23, 4, 9, 62, DateTimeKind.Local).AddTicks(510), "fryd.salm@yahoo.com", "1-399-838-2851 x97206" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, 5873, طوباس, Australia", "بيت الفقيه", new DateTime(2024, 1, 19, 19, 48, 16, 632, DateTimeKind.Local).AddTicks(6166), "aadm54@gmail.com", "586-602-7915 x709" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, دوار استاد قریب, 2154, قالمة, Montenegro", "وجدة", new DateTime(2024, 1, 19, 18, 56, 15, 263, DateTimeKind.Local).AddTicks(744), "jmanh_asamh@hotmail.com", "941-584-6904" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع استاد قریب, طريق فاطمی, 3390, المالكية, Ethiopia", "برج بو عريريج", new DateTime(2024, 1, 20, 0, 40, 25, 532, DateTimeKind.Local).AddTicks(6699), "dana.hsn@yahoo.com", "1-239-694-6145 x13938" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, ميدان یادگار امام, 5, أم درمان, Taiwan", "أريحا", new DateTime(2024, 1, 20, 12, 40, 10, 373, DateTimeKind.Local).AddTicks(637), "rbya.marwf@hotmail.com", "(467) 342-6464 x6042" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, ميدان یادگار امام, 095, صلالة, Martinique", "القويعية", new DateTime(2024, 1, 19, 20, 54, 17, 802, DateTimeKind.Local).AddTicks(6126), "zynb.tarq@yahoo.com", "758-987-6503" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, ش آذربایجان, 494, رداع, Sierra Leone", "بريدة", new DateTime(2024, 1, 19, 22, 16, 18, 708, DateTimeKind.Local).AddTicks(5343), "mna.jabr@gmail.com", "501-570-1675 x870" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, 4916, الجوف, Armenia", "المناقل", new DateTime(2024, 1, 20, 0, 12, 31, 837, DateTimeKind.Local).AddTicks(4164), "zyd_aashwr83@gmail.com", "907-591-3107 x0752" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, شارع دستغیب, 4, جاردو, Spain", "الميادين", new DateTime(2024, 1, 20, 13, 17, 1, 868, DateTimeKind.Local).AddTicks(2971), "tarq_marwf@gmail.com", "1-204-829-8644" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, شارع آزادی, 8049, البديع, Nigeria", "سنار", new DateTime(2024, 1, 20, 4, 13, 48, 325, DateTimeKind.Local).AddTicks(1019), "hajr93@yahoo.com", "412-667-3114" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, ميدان امیرکبیر, 2239, برشيد, Kuwait", "انواديبو", new DateTime(2024, 1, 19, 20, 33, 51, 444, DateTimeKind.Local).AddTicks(5482), "sayd_amjd28@yahoo.com", "637.206.0384" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 1009, نجران, Peru", "سلفيت", new DateTime(2024, 1, 20, 14, 58, 55, 110, DateTimeKind.Local).AddTicks(2174), "jabr_fryd90@yahoo.com", "518-693-8603" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, طريق ابوذر, 9, شفاعمرو, El Salvador", "صفرو", new DateTime(2024, 1, 19, 19, 52, 44, 810, DateTimeKind.Local).AddTicks(1521), "aadm67@gmail.com", "1-423-639-4375 x1145" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, 78, كرو, Saint Helena", "العمران", new DateTime(2024, 1, 20, 1, 19, 6, 224, DateTimeKind.Local).AddTicks(4443), "iyhab_tarq@gmail.com", "243.752.9092" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, ش رسالت, 34, دهبان, Yemen", "الرملة", new DateTime(2024, 1, 20, 13, 30, 10, 801, DateTimeKind.Local).AddTicks(1324), "hsn51@hotmail.com", "(553) 628-6348" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, دوار امیرکبیر, 3623, غرداية, Guyana", "فرسان", new DateTime(2024, 1, 20, 6, 41, 52, 941, DateTimeKind.Local).AddTicks(4364), "hazm.zyd28@hotmail.com", "362.406.5582" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, طريق شهید مطهری, 63, الشوف, China", "الجنينة", new DateTime(2024, 1, 20, 2, 31, 40, 400, DateTimeKind.Local).AddTicks(3846), "shymaa.fryd@yahoo.com", "(575) 689-3198" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 0, رندا, Greece", "ودمدني", new DateTime(2024, 1, 20, 16, 15, 56, 420, DateTimeKind.Local).AddTicks(4293), "fuad_aashwr@gmail.com", "(604) 291-4164 x087" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, ميدان امیرکبیر, 155, المحرق, Panama", "ادلب", new DateTime(2024, 1, 20, 14, 54, 23, 541, DateTimeKind.Local).AddTicks(2406), "fatmh.salm43@yahoo.com", "288.845.2610 x89346" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, تقاطع ابوذر, 57, بيت لاهيا, Romania", "صلنفة", new DateTime(2024, 1, 20, 11, 37, 14, 27, DateTimeKind.Local).AddTicks(4101), "rna_aadm35@yahoo.com", "389.759.3556 x91647" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, 7333, المنصورة, Niger", "العلمة", new DateTime(2024, 1, 19, 22, 7, 14, 562, DateTimeKind.Local).AddTicks(5583), "aayh14@yahoo.com", "(237) 398-9201 x49563" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, شارع رسالت, 8, الرستاق, Paraguay", "بركاء", new DateTime(2024, 1, 20, 11, 53, 52, 967, DateTimeKind.Local).AddTicks(1119), "iynas51@yahoo.com", "(775) 889-1063 x856" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, تقاطع آذربایجان, 0, النجف, Papua New Guinea", "مقطع لحجار", new DateTime(2024, 1, 20, 12, 49, 42, 310, DateTimeKind.Local).AddTicks(2257), "amjd.zyd@yahoo.com", "1-399-321-9754" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, 6, براقي, Taiwan", "الكسوة", new DateTime(2024, 1, 20, 2, 18, 10, 207, DateTimeKind.Local).AddTicks(7958), "arwa_iyhab57@hotmail.com", "(506) 682-9499" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, ميدان آفریقا, 29, بورو, Peru", "الناعورة", new DateTime(2024, 1, 20, 7, 3, 7, 319, DateTimeKind.Local).AddTicks(9886), "asamh_slah28@gmail.com", "938-293-4665 x69567" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, ش کارگر شمالی, 27, البليدة, Chad", "بريدة‏", new DateTime(2024, 1, 20, 15, 43, 7, 160, DateTimeKind.Local).AddTicks(5483), "fatmh86@hotmail.com", "1-443-837-2487" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, 9, سيان, Jordan", "القامشلي", new DateTime(2024, 1, 20, 0, 39, 52, 611, DateTimeKind.Local).AddTicks(8683), "salm.aqyl@gmail.com", "674.588.6221" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, 3, الفقيه بنصالح, Albania", "الرميلة", new DateTime(2024, 1, 19, 18, 34, 12, 283, DateTimeKind.Local).AddTicks(8751), "iyhab_azyz@hotmail.com", "1-524-991-4853" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, شارع اقبال لاهوری, 5, الدمام, Uganda", "تلمسان", new DateTime(2024, 1, 20, 10, 52, 49, 185, DateTimeKind.Local).AddTicks(7870), "iyhab30@yahoo.com", "492.651.2840 x6311" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 881, طبرق, Kuwait", "رندا", new DateTime(2024, 1, 20, 4, 53, 56, 782, DateTimeKind.Local).AddTicks(5120), "arwa_aadm@gmail.com", "1-518-509-7904" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, 6, صفاقس, Colombia", "شيبه", new DateTime(2024, 1, 19, 19, 11, 35, 407, DateTimeKind.Local).AddTicks(9279), "farwq.jabr16@hotmail.com", "(915) 662-0496 x2316" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, ش موحد دانش, 36, الزيمة, Svalbard & Jan Mayen Islands", "القويسمة", new DateTime(2024, 1, 20, 1, 54, 6, 383, DateTimeKind.Local).AddTicks(1196), "fryd.rbya71@hotmail.com", "410.883.9208 x88833" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, 672, القنيطرة, Liechtenstein", "المناقل", new DateTime(2024, 1, 19, 21, 52, 59, 191, DateTimeKind.Local).AddTicks(4807), "arwa_sayd@yahoo.com", "943-242-6701 x49476" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, دوار حقانی, 3703, ابها, Belize", "قابس", new DateTime(2024, 1, 20, 2, 24, 41, 609, DateTimeKind.Local).AddTicks(1299), "iynas_amjd@hotmail.com", "943.414.0086 x21336" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان فاطمی, ش راستوان, 039, مدينة الصدر, Oman", "سخنين", new DateTime(2024, 1, 20, 0, 35, 0, 82, DateTimeKind.Local).AddTicks(7650), "rna14@gmail.com", "(420) 358-2291 x37947" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سباری, طريق فاطمی, 58, دبا, Kazakhstan", "عين البيضاء", new DateTime(2024, 1, 20, 6, 1, 21, 481, DateTimeKind.Local).AddTicks(3289), "arwa.tarq@hotmail.com", "(881) 492-5517 x233" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, دوار کارگر شمالی, 924, كفرشوبا, Dominica", "ثادق", new DateTime(2024, 1, 19, 19, 47, 36, 309, DateTimeKind.Local).AddTicks(9932), "tarq55@yahoo.com", "1-582-894-2618 x3543" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, شارع رسالت, 8, عمان, Somalia", "درعا", new DateTime(2024, 1, 20, 8, 11, 28, 9, DateTimeKind.Local).AddTicks(9768), "farwq_fuad69@yahoo.com", "1-495-767-1032" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, 0199, فيفاء, Saint Lucia", "طانطان", new DateTime(2024, 1, 20, 11, 44, 38, 858, DateTimeKind.Local).AddTicks(7230), "tarq10@yahoo.com", "1-540-805-1815 x62337" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, تقاطع اجاره دار, 80, الطائف, Syrian Arab Republic", "بسكرة", new DateTime(2024, 1, 20, 12, 43, 41, 179, DateTimeKind.Local).AddTicks(5999), "lma1@gmail.com", "(604) 323-5460 x5194" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, تقاطع قدس, 339, حمص, Sierra Leone", "دومة الجندل", new DateTime(2024, 1, 19, 18, 34, 52, 428, DateTimeKind.Local).AddTicks(8504), "abyr.marwf66@yahoo.com", "926.529.4225" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, طريق یادگار امام, 69, الناصرة, Saint Lucia", "كرو", new DateTime(2024, 1, 19, 22, 21, 15, 528, DateTimeKind.Local).AddTicks(7404), "blal18@yahoo.com", "1-686-222-8485 x504" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آذربایجان, طريق آفریقا, 468, جباليا, Maldives", "كسماوي", new DateTime(2024, 1, 20, 8, 23, 43, 184, DateTimeKind.Local).AddTicks(3066), "hsn_fuad@hotmail.com", "(613) 525-1390 x31012" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, شارع سمیه, 506, صير بني ياس, Croatia", "أبو كمال", new DateTime(2024, 1, 20, 8, 9, 36, 540, DateTimeKind.Local).AddTicks(9313), "lma_hsn62@gmail.com", "(839) 748-7490 x2365" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 03, أرتا, Dominica", "بني وليد", new DateTime(2024, 1, 20, 13, 40, 8, 582, DateTimeKind.Local).AddTicks(5302), "jabr.sayd54@hotmail.com", "859-674-1297 x69002" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, ميدان آفریقا, 579, الحسكة, Macedonia", "المكلا", new DateTime(2024, 1, 20, 0, 10, 26, 954, DateTimeKind.Local).AddTicks(5043), "jabr46@gmail.com", "1-405-604-3576 x3972" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, تقاطع دکتر چمران, 484, تيارت, Nigeria", "ابها", new DateTime(2024, 1, 20, 14, 42, 7, 382, DateTimeKind.Local).AddTicks(5191), "aadm52@hotmail.com", "940.400.1459 x0770" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, شارع ابوذر, 31, ذي سفال, Bulgaria", "عنيزة", new DateTime(2024, 1, 20, 10, 0, 2, 940, DateTimeKind.Local).AddTicks(1819), "fatmh.azyz@hotmail.com", "(304) 956-0787 x256" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, 2, القضارف, Ethiopia", "ارمناز", new DateTime(2024, 1, 20, 1, 36, 8, 173, DateTimeKind.Local).AddTicks(6557), "shymaa11@gmail.com", "1-426-720-6717" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, ميدان آذربایجان, 6, الدور, Georgia", "الوجه", new DateTime(2024, 1, 19, 20, 49, 37, 159, DateTimeKind.Local).AddTicks(2248), "arwa_hsn@hotmail.com", "524.214.7754 x94895" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 7, حلب, Albania", "خانقين", new DateTime(2024, 1, 19, 19, 58, 40, 271, DateTimeKind.Local).AddTicks(6426), "frydh54@gmail.com", "1-401-885-9949 x0755" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, شارع سباری, 4, الحسكة, Jordan", "الجوف", new DateTime(2024, 1, 20, 10, 5, 56, 379, DateTimeKind.Local).AddTicks(1697), "aayh_fryd29@hotmail.com", "833.923.6454" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, شارع رسالت, 02, المنيا, Bahrain", "الدقم", new DateTime(2024, 1, 20, 5, 46, 48, 619, DateTimeKind.Local).AddTicks(1699), "mna50@hotmail.com", "317-878-8675 x35259" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, 28, بلبيس, Turkey", "بريدة‏", new DateTime(2024, 1, 20, 12, 9, 2, 281, DateTimeKind.Local).AddTicks(9539), "tarq_araqy16@hotmail.com", "451-813-3295" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 3, حقل, Bahamas", "الفقيه بنصالح", new DateTime(2024, 1, 19, 20, 0, 51, 511, DateTimeKind.Local).AddTicks(9331), "abyr67@gmail.com", "1-604-707-2488 x7769" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, طريق سباری, 2, الوكرة, Moldova", "عفيف", new DateTime(2024, 1, 19, 23, 6, 17, 875, DateTimeKind.Local).AddTicks(3407), "amjd34@hotmail.com", "(774) 607-5959 x8281" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع قدس, طريق راستوان, 898, أم درمان, Mayotte", "عبري", new DateTime(2024, 1, 20, 7, 26, 46, 317, DateTimeKind.Local).AddTicks(9688), "rbya_aadm@hotmail.com", "414-676-0233" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, دوار موحد دانش, 78, كوستي, Niger", "بيت حانون", new DateTime(2024, 1, 20, 4, 30, 0, 995, DateTimeKind.Local).AddTicks(5558), "amjd_fuad@hotmail.com", "1-548-581-3428" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, ميدان دماوند, 063, الجلفة, Belarus", "الشارقة", new DateTime(2024, 1, 20, 2, 27, 59, 85, DateTimeKind.Local).AddTicks(8293), "farwq71@gmail.com", "(258) 992-5258 x508" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, ميدان دماوند, 06, السماوة, Heard Island and McDonald Islands", "ابراء", new DateTime(2024, 1, 20, 4, 20, 19, 582, DateTimeKind.Local).AddTicks(4137), "sarh_sayd74@yahoo.com", "1-671-355-4445 x1481" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, ش حقانی, 049, قسنطينة, Spain", "تارودانت", new DateTime(2024, 1, 20, 6, 12, 46, 589, DateTimeKind.Local).AddTicks(7860), "iyhab.salm@hotmail.com", "1-465-353-8255 x6490" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, 5144, العوجا, Democratic People's Republic of Korea", "رداع", new DateTime(2024, 1, 20, 9, 36, 2, 254, DateTimeKind.Local).AddTicks(4023), "hajr_tarq50@yahoo.com", "852.642.5783 x847" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, دوار دستغیب, 895, التل, Taiwan", "الديماس", new DateTime(2024, 1, 20, 1, 54, 19, 813, DateTimeKind.Local).AddTicks(9260), "aadm_hsn@gmail.com", "(701) 260-0578 x136" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 32, السماوة, Nigeria", "حمص", new DateTime(2024, 1, 20, 0, 11, 16, 513, DateTimeKind.Local).AddTicks(7327), "abyr29@hotmail.com", "1-351-355-9691" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, 101, عطبرة, Malta", "الجش", new DateTime(2024, 1, 20, 16, 2, 37, 27, DateTimeKind.Local).AddTicks(3157), "abyr88@hotmail.com", "754-829-8993" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, طريق مالک اشتر, 0872, الزيمة, Tuvalu", "دخيل", new DateTime(2024, 1, 19, 21, 55, 37, 330, DateTimeKind.Local).AddTicks(5340), "rqyh.aashwr@hotmail.com", "(691) 993-5394 x954" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, تقاطع رسالت, 65, مكة المكرمة, Serbia", "جلب", new DateTime(2024, 1, 20, 3, 5, 48, 118, DateTimeKind.Local).AddTicks(5636), "zyd40@gmail.com", "1-564-276-8902 x71646" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, 43, أريحا, Micronesia", "ازويرات", new DateTime(2024, 1, 20, 16, 52, 18, 204, DateTimeKind.Local).AddTicks(829), "fatmh_hsn69@gmail.com", "661.884.4596" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 9, إدلب, Niue", "أربيل", new DateTime(2024, 1, 20, 16, 43, 34, 99, DateTimeKind.Local).AddTicks(4134), "asamh.aashwr63@gmail.com", "1-836-997-8829" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, طريق کارگر شمالی, 15, صور, American Samoa", "النهود", new DateTime(2024, 1, 19, 22, 23, 46, 370, DateTimeKind.Local).AddTicks(6990), "mna_hsn@hotmail.com", "237.310.8831" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, طريق اقبال لاهوری, 14, دمازين, American Samoa", "صرمان", new DateTime(2024, 1, 19, 21, 36, 8, 462, DateTimeKind.Local).AddTicks(8596), "aayh29@yahoo.com", "509-849-0273 x4044" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, ميدان سباری, 578, جالكاسيو, Angola", "شندي", new DateTime(2024, 1, 20, 1, 3, 10, 792, DateTimeKind.Local).AddTicks(872), "zynb.farwq72@gmail.com", "1-313-820-2864 x104" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, شارع راستوان, 7, اللد, Saint Vincent and the Grenadines", "عمان", new DateTime(2024, 1, 20, 14, 55, 45, 361, DateTimeKind.Local).AddTicks(7208), "iynas_fryd32@hotmail.com", "369-749-9335" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, طريق سباری, 3, كركوك, Niger", "تبوك", new DateTime(2024, 1, 20, 4, 20, 3, 487, DateTimeKind.Local).AddTicks(2490), "slah.iyhab@gmail.com", "(224) 626-2711" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, 9, غريان, French Southern Territories", "الدوحة", new DateTime(2024, 1, 20, 16, 18, 7, 920, DateTimeKind.Local).AddTicks(1294), "amjd80@hotmail.com", "904-746-5427 x976" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, دوار آفریقا, 064, وادي حلفا, New Caledonia", "قرية الجهراء", new DateTime(2024, 1, 20, 18, 28, 46, 793, DateTimeKind.Local).AddTicks(9665), "rna.araqy@hotmail.com", "986.257.5771 x330" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, 9, الفاشر, Puerto Rico", "الظهران", new DateTime(2024, 1, 20, 3, 13, 28, 4, DateTimeKind.Local).AddTicks(8241), "amjd.aashwr53@yahoo.com", "589-691-0811" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, تقاطع اجاره دار, 84, العيينة, Martinique", "الناعورة", new DateTime(2024, 1, 19, 21, 7, 20, 629, DateTimeKind.Local).AddTicks(9730), "sayd86@hotmail.com", "358-606-0870" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, 9151, الرس, Belize", "تنبدغة", new DateTime(2024, 1, 20, 11, 46, 9, 4, DateTimeKind.Local).AddTicks(9323), "salm_sayd@yahoo.com", "399-654-7896" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, ميدان شهید مطهری, 7, مصياف, Guinea", "الرمادي", new DateTime(2024, 1, 20, 11, 29, 49, 880, DateTimeKind.Local).AddTicks(8405), "rbya0@gmail.com", "532-569-4625 x023" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, دوار دماوند, 1263, تاروت, Dominican Republic", "جد حفص", new DateTime(2024, 1, 20, 13, 45, 37, 268, DateTimeKind.Local).AddTicks(2374), "zynb_slah@hotmail.com", "563.766.6091" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, 8, عين البيضاء, Niue", "صور", new DateTime(2024, 1, 19, 21, 44, 43, 165, DateTimeKind.Local).AddTicks(6340), "tarq95@hotmail.com", "586-453-8842" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, شارع امیرکبیر, 215, ليلى, Saint Barthelemy", "معرة النعمان", new DateTime(2024, 1, 20, 15, 29, 3, 824, DateTimeKind.Local).AddTicks(2631), "shymaa.amjd64@yahoo.com", "1-873-301-1528 x2468" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, طريق موحد دانش, 447, كسماوي, Macao", "بني ملال", new DateTime(2024, 1, 19, 19, 50, 12, 127, DateTimeKind.Local).AddTicks(3976), "lma21@gmail.com", "728-563-0739 x4752" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع مالک اشتر, طريق فاطمی, 7, شفاعمرو, Senegal", "معرة النعمان", new DateTime(2024, 1, 20, 5, 51, 8, 214, DateTimeKind.Local).AddTicks(780), "fatmh_tarq96@gmail.com", "943-664-4458" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, 6464, حلبجة, United Kingdom", "طرابلس", new DateTime(2024, 1, 19, 18, 35, 37, 512, DateTimeKind.Local).AddTicks(1829), "sarh_amjd18@hotmail.com", "1-581-421-1084 x79006" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, ميدان سباری, 145, تعز, Macedonia", "دورا", new DateTime(2024, 1, 20, 11, 16, 32, 648, DateTimeKind.Local).AddTicks(6512), "jmanh.hashm@yahoo.com", "1-559-911-9294" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار موحد دانش, 85, السويس, Bouvet Island (Bouvetoya)", "الكاظمية", new DateTime(2024, 1, 19, 23, 12, 8, 885, DateTimeKind.Local).AddTicks(1113), "iyhab68@gmail.com", "1-810-699-9488 x48459" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 981, أسفي, Philippines", "طرعان", new DateTime(2024, 1, 19, 20, 17, 12, 637, DateTimeKind.Local).AddTicks(6295), "jabr.araqy@yahoo.com", "1-285-331-5643 x6174" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, ميدان امیرکبیر, 989, خصب, Puerto Rico", "أوبوك", new DateTime(2024, 1, 20, 10, 7, 53, 758, DateTimeKind.Local).AddTicks(2824), "arwa25@hotmail.com", "1-398-272-8969 x40437" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, 8, جيجل, Guam", "الرمثا", new DateTime(2024, 1, 20, 7, 30, 41, 227, DateTimeKind.Local).AddTicks(3777), "aadm.aashwr@hotmail.com", "252.821.9998 x042" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 514, ذي سفال, Burkina Faso", "ولاتة", new DateTime(2024, 1, 20, 1, 48, 3, 587, DateTimeKind.Local).AddTicks(2318), "fryd_amjd47@hotmail.com", "910.719.5472 x53452" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, شارع دستغیب, 6104, جرش, Hungary", "الفحيص", new DateTime(2024, 1, 20, 2, 58, 55, 926, DateTimeKind.Local).AddTicks(3346), "hsn.aadm@hotmail.com", "1-420-391-9376 x479" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, 26, قنا, Saint Kitts and Nevis", "نابلس", new DateTime(2024, 1, 20, 1, 1, 59, 285, DateTimeKind.Local).AddTicks(468), "mna_aashwr55@gmail.com", "(514) 598-7195" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, طريق فاطمی, 8, خور فكان, Brunei Darussalam", "عين اعبيد", new DateTime(2024, 1, 20, 11, 8, 18, 219, DateTimeKind.Local).AddTicks(465), "zyd56@gmail.com", "378-463-6807 x5762" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, 7, بالهو, Niue", "البديع", new DateTime(2024, 1, 20, 1, 12, 12, 740, DateTimeKind.Local).AddTicks(6294), "hsn_rbya@yahoo.com", "655-396-7125 x821" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, 7033, الحوامدية, Georgia", "شبين الكوم", new DateTime(2024, 1, 20, 7, 44, 20, 491, DateTimeKind.Local).AddTicks(491), "fuad.azyz67@hotmail.com", "1-334-509-2142" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش رسالت, 133, شهبا, Virgin Islands, U.S.", "أسفي", new DateTime(2024, 1, 19, 21, 42, 44, 421, DateTimeKind.Local).AddTicks(49), "fryd29@yahoo.com", "393.204.9699" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, 687, القضيمة, Mali", "دبا", new DateTime(2024, 1, 20, 16, 3, 46, 989, DateTimeKind.Local).AddTicks(2373), "lma_farwq71@hotmail.com", "1-518-326-3281 x734" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 73, الجبيل, Palestinian Territory", "قنا", new DateTime(2024, 1, 20, 2, 28, 35, 342, DateTimeKind.Local).AddTicks(1764), "zyd97@yahoo.com", "(260) 732-3353 x8475" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, شارع حقانی, 256, سيلبابي, Tanzania", "سوسه", new DateTime(2024, 1, 19, 23, 10, 14, 86, DateTimeKind.Local).AddTicks(6714), "hsn.asar@yahoo.com", "226.877.3389 x4785" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, دوار موحد دانش, 7034, شقراء, Japan", "جرابلس", new DateTime(2024, 1, 20, 3, 47, 11, 994, DateTimeKind.Local).AddTicks(8112), "fuad35@gmail.com", "(753) 349-9594 x0076" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, ميدان موحد دانش, 131, العمارة, Uzbekistan", "إجدابيا", new DateTime(2024, 1, 20, 12, 55, 57, 255, DateTimeKind.Local).AddTicks(9522), "frydh.azyz42@gmail.com", "697-490-0573 x00208" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, 93, تدمر, Bahrain", "الحديدة", new DateTime(2024, 1, 19, 20, 16, 16, 288, DateTimeKind.Local).AddTicks(6654), "aadm99@yahoo.com", "685-835-9773 x90794" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, دوار مالک اشتر, 024, المالكية, Venezuela", "بوتلميت", new DateTime(2024, 1, 20, 8, 24, 48, 619, DateTimeKind.Local).AddTicks(6577), "amjd.iyhab57@gmail.com", "1-400-509-7508 x6296" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, ميدان راستوان, 031, الخبر, Papua New Guinea", "بهلا", new DateTime(2024, 1, 19, 23, 5, 56, 750, DateTimeKind.Local).AddTicks(1376), "fatmh96@yahoo.com", "314-933-1755 x2070" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, 9027, عين اعبيد, Gibraltar", "القطيف", new DateTime(2024, 1, 20, 2, 55, 54, 880, DateTimeKind.Local).AddTicks(3112), "abyr54@gmail.com", "338.570.0178" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 730, لوك, Uganda", "تلعفر", new DateTime(2024, 1, 20, 13, 55, 5, 189, DateTimeKind.Local).AddTicks(5819), "hazm_sayd3@hotmail.com", "(711) 724-3029 x291" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, طريق آذربایجان, 87, زوارة, Haiti", "صفرو", new DateTime(2024, 1, 20, 1, 7, 7, 227, DateTimeKind.Local).AddTicks(5347), "zynb7@yahoo.com", "390-229-9530 x71302" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, ش رسالت, 03, ثادق, Jamaica", "بنجرير", new DateTime(2024, 1, 20, 3, 9, 55, 566, DateTimeKind.Local).AddTicks(9257), "blal_tarq56@yahoo.com", "1-201-881-9726 x7785" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, 27, الباحة, Croatia", "العيون", new DateTime(2024, 1, 20, 12, 48, 16, 749, DateTimeKind.Local).AddTicks(4849), "hazm83@gmail.com", "888-946-9559 x78317" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, تقاطع فاطمی, 8259, العمران, Gambia", "الأغواط", new DateTime(2024, 1, 20, 12, 1, 34, 969, DateTimeKind.Local).AddTicks(3660), "fryd_jabr@yahoo.com", "(263) 539-9818" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, شارع فاطمی, 0, حلبجة, Czech Republic", "مال", new DateTime(2024, 1, 19, 19, 7, 15, 510, DateTimeKind.Local).AddTicks(6937), "frydh_aqyl@hotmail.com", "225-236-6817" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, شارع یادگار امام, 930, حائل, Turks and Caicos Islands", "جرسيف", new DateTime(2024, 1, 20, 12, 22, 36, 851, DateTimeKind.Local).AddTicks(361), "fatmh58@gmail.com", "1-282-440-6412" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 38, باجل, Gambia", "جلافي", new DateTime(2024, 1, 20, 10, 44, 57, 98, DateTimeKind.Local).AddTicks(3289), "fuad.asar55@yahoo.com", "(912) 467-0874" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, تقاطع دستغیب, 7639, جرابلس, Thailand", "الرمثا", new DateTime(2024, 1, 20, 4, 13, 44, 507, DateTimeKind.Local).AddTicks(1096), "jabr31@gmail.com", "(212) 932-3806" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, ش اجاره دار, 25, تاروت, Paraguay", "ازويرات", new DateTime(2024, 1, 20, 17, 30, 29, 9, DateTimeKind.Local).AddTicks(9437), "fuad70@hotmail.com", "650.756.6287" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, شارع آفریقا, 3009, تلكلخ, El Salvador", "عنيزة", new DateTime(2024, 1, 20, 2, 58, 44, 653, DateTimeKind.Local).AddTicks(8887), "salm59@hotmail.com", "1-558-627-3667 x2378" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, شارع حقانی, 215, بيشة, Mexico", "رداع", new DateTime(2024, 1, 20, 7, 52, 43, 551, DateTimeKind.Local).AddTicks(4254), "mna.azyz68@gmail.com", "(426) 380-2560" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, 9204, وادي الدواسر, Tunisia", "خور أنجار", new DateTime(2024, 1, 19, 22, 36, 47, 996, DateTimeKind.Local).AddTicks(7261), "dana.tarq@yahoo.com", "1-267-200-2437" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, ميدان کارگر شمالی, 8845, ذي سفال, Saint Lucia", "إب", new DateTime(2024, 1, 20, 10, 16, 27, 850, DateTimeKind.Local).AddTicks(781), "tarq_slah@gmail.com", "665.806.4569 x085" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, طريق سمیه, 712, أطار, Mauritania", "بيجي", new DateTime(2024, 1, 20, 0, 47, 56, 531, DateTimeKind.Local).AddTicks(5873), "fuad24@gmail.com", "(235) 655-9497 x327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, تقاطع سباری, 2596, القائم, Azerbaijan", "الرويس", new DateTime(2024, 1, 20, 5, 40, 47, 696, DateTimeKind.Local).AddTicks(3310), "rqyh.zyd@yahoo.com", "(330) 890-5841 x84999" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, 71, سوق أهراس, Senegal", "تربة البقوم", new DateTime(2024, 1, 20, 5, 27, 55, 889, DateTimeKind.Local).AddTicks(5383), "asamh.tarq@gmail.com", "1-277-291-9230 x6280" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, 4, علي صبيح, Botswana", "حلب", new DateTime(2024, 1, 19, 19, 47, 24, 72, DateTimeKind.Local).AddTicks(6052), "iynas_tarq28@yahoo.com", "(603) 340-5387 x071" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, 1, شبين الكوم, Cyprus", "الجفر", new DateTime(2024, 1, 20, 8, 47, 22, 536, DateTimeKind.Local).AddTicks(9163), "frydh_zyd@yahoo.com", "1-749-814-3116 x706" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, ش هویزه, 5881, الشارقة, Ukraine", "أريحا", new DateTime(2024, 1, 20, 10, 44, 12, 98, DateTimeKind.Local).AddTicks(8108), "hajr_aqyl@hotmail.com", "(978) 474-7426 x663" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, طريق یادگار امام, 4237, يافا, Angola", "عين وسارة", new DateTime(2024, 1, 20, 14, 18, 42, 576, DateTimeKind.Local).AddTicks(6902), "aadm_farwq22@gmail.com", "695-690-9052" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 174, الأزرق, Saint Helena", "الديماس", new DateTime(2024, 1, 20, 7, 57, 0, 807, DateTimeKind.Local).AddTicks(1762), "jmanh.hashm31@gmail.com", "(512) 714-3873 x4118" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, دوار استاد قریب, 575, إدفو, New Caledonia", "باب الزوار", new DateTime(2024, 1, 20, 4, 21, 39, 497, DateTimeKind.Local).AddTicks(7501), "zynb.zyd@gmail.com", "(427) 686-1073" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 5750, يريم, Bangladesh", "طبرق", new DateTime(2024, 1, 20, 13, 18, 10, 893, DateTimeKind.Local).AddTicks(2362), "asamh66@yahoo.com", "(372) 437-5076" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, تقاطع شهید مطهری, 243, الشامية, Canada", "كفر قاسم", new DateTime(2024, 1, 20, 4, 56, 44, 971, DateTimeKind.Local).AddTicks(8695), "sarh.marwf@yahoo.com", "1-810-624-3055" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 10, 19, 1, 46, 8, 678, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 1, 19, 20, 24, 8, 231, DateTimeKind.Local).AddTicks(905), "سارة ربيع", "Ronaldo Hermiston", "عقیل - أمجد", "5100639644262949177", "Gambia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 8, 1, 8, 17, 9, 666, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 1, 20, 11, 15, 13, 679, DateTimeKind.Local).AddTicks(5621), "رقية سالم", "Triston Johns", "بلال Group", "3745927645456612790", "Timor-Leste", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 8, 31, 0, 5, 1, 55, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 1, 20, 16, 50, 27, 754, DateTimeKind.Local).AddTicks(6303), "فاطمة عراقی", "Raymundo Bode", "سالم LLC", "7735029507890940543", "Ecuador" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 3, 2, 4, 37, 19, 790, DateTimeKind.Local).AddTicks(302), new DateTime(2024, 1, 20, 1, 58, 17, 135, DateTimeKind.Local).AddTicks(3646), "فؤاد أسامة", "Janie Ebert", 1, "أسامة - معروف", "1377696469467128365", "Lesotho", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 11, 23, 18, 13, 13, 58, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 1, 20, 15, 39, 57, 121, DateTimeKind.Local).AddTicks(9754), "شيماء عزیز", "Brett Wyman", "فاروق Inc", "2875582036557349907", "Nepal", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 2, 5, 2, 48, 30, 703, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 1, 20, 17, 8, 11, 865, DateTimeKind.Local).AddTicks(315), "هاجر آدم", "Libby Schiller", "سعيد, هاشم and فؤاد", "8944911598765535175", "Bahrain", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 4, 24, 1, 28, 54, 870, DateTimeKind.Local).AddTicks(2031), new DateTime(2024, 1, 20, 8, 39, 18, 41, DateTimeKind.Local).AddTicks(9674), "أسامة فريد", "Elton Hintz", 0, "زيد and Sons", "8681307118090358244", "Barbados", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 9, 5, 9, 17, 10, 267, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 1, 20, 2, 27, 1, 491, DateTimeKind.Local).AddTicks(8314), "رقية عراقی", "Yvette Ferry", 1, "ربيع - هاشم", "3337549980463371260", "Congo" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 4, 21, 15, 19, 36, 42, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 1, 19, 23, 21, 34, 315, DateTimeKind.Local).AddTicks(5765), "إيناس عارف", "Lesley Gerlach", "عصار - حازم", "232064457922029211", "Martinique", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1988, 6, 24, 15, 54, 7, 227, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 1, 20, 5, 1, 18, 594, DateTimeKind.Local).AddTicks(5261), "عبير فاروق", "Nova Zemlak", 1, "إيهاب, أمجد and عارف", "6728768035179211284", "Sri Lanka" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 10, 31, 1, 51, 32, 770, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 1, 20, 4, 18, 15, 299, DateTimeKind.Local).AddTicks(6847), "حازم عصار", "Candice Schneider", 1, "عزیز, عزیز and عاشور", "7738217257890561770", "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 3, 27, 5, 4, 39, 606, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 1, 20, 9, 28, 37, 755, DateTimeKind.Local).AddTicks(6259), "Isadore Crooks", "معروف - فؤاد", "8452338936959298000", "United Arab Emirates", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1956, 12, 26, 4, 32, 22, 856, DateTimeKind.Local).AddTicks(8609), new DateTime(2024, 1, 20, 14, 16, 28, 184, DateTimeKind.Local).AddTicks(6578), "آدم حازم", "Brannon Boyle", "طارق - أسامة", "8248617773616357868", "Afghanistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 11, 3, 18, 7, 24, 215, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 1, 20, 4, 28, 53, 352, DateTimeKind.Local).AddTicks(5104), "شيماء فريد", "Burnice Kihn", "معروف LLC", "9016750158254237307", "Maldives", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 7, 11, 20, 26, 59, 761, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 1, 20, 2, 9, 29, 131, DateTimeKind.Local).AddTicks(527), "آدم عاشور", "Brielle Mills", "سالم and Sons", "7046961202661996779", "Austria", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 8, 18, 15, 39, 3, 609, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 1, 20, 13, 56, 27, 707, DateTimeKind.Local).AddTicks(203), "سارة صلاح", "Dina Mills", 1, "فاروق, صلاح and عارف", "2231680261004521709", "South Africa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 1, 18, 5, 0, 12, 783, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 1, 20, 14, 20, 6, 107, DateTimeKind.Local).AddTicks(1254), "هاجر هاشم", "Lia Shanahan", 0, "آدم, أسامة and عزیز", "4165853426637056848", "Bangladesh", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 7, 5, 23, 7, 32, 91, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 1, 20, 8, 20, 36, 219, DateTimeKind.Local).AddTicks(7435), "طارق عراقی", "Tiara Christiansen", 0, "إيهاب LLC", "2411767537437672803", "Northern Mariana Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 1, 5, 12, 30, 1, 691, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 1, 20, 13, 34, 31, 250, DateTimeKind.Local).AddTicks(4980), "ريم صلاح", "Lera Greenholt", "معروف - أمجد", "6522120202997648783", "Lithuania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 7, 12, 7, 42, 33, 163, DateTimeKind.Local).AddTicks(5182), new DateTime(2024, 1, 20, 4, 2, 45, 39, DateTimeKind.Local).AddTicks(2918), "حازم هاشم", "Clementine Lubowitz", 1, "عاشور LLC", "1984807527515299190", "Turkey", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 11, 11, 5, 22, 24, 30, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 1, 19, 21, 54, 51, 917, DateTimeKind.Local).AddTicks(6946), "أمجد عاشور", "Fred Lynch", "عراقی, عزیز and عاشور", "7761802601949510225", "Portugal", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 1, 19, 15, 20, 32, 882, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 1, 20, 5, 59, 5, 877, DateTimeKind.Local).AddTicks(4394), "جمانة ربيع", "Anita Batz", 1, "بلال, عاشور and عارف", "1640783616313888255", "Reunion", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 6, 8, 11, 43, 23, 368, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 1, 20, 5, 0, 31, 242, DateTimeKind.Local).AddTicks(1420), "أروى أمجد", "Katrina Weber", 0, "عصار Group", "4468855074895635836", "Kuwait", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 5, 1, 8, 25, 59, 72, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 1, 20, 17, 0, 25, 154, DateTimeKind.Local).AddTicks(7436), "صلاح سعيد", "Lavon Schumm", 1, "أسامة, طارق and هاشم", "1578573825225444585", "Ethiopia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 2, 9, 15, 53, 4, 980, DateTimeKind.Local).AddTicks(2381), new DateTime(2024, 1, 20, 0, 15, 16, 389, DateTimeKind.Local).AddTicks(5467), "فؤاد هاشم", "Rossie Sauer", 1, "عارف Inc", "4859454006606909410", "Togo" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1987, 12, 27, 8, 32, 7, 35, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 1, 20, 12, 27, 51, 946, DateTimeKind.Local).AddTicks(5083), "شيماء فاروق", "Gail Murray", "سالم Inc", "4004622200659175736", "Gambia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 4, 21, 20, 56, 5, 186, DateTimeKind.Local).AddTicks(2446), new DateTime(2024, 1, 20, 2, 43, 38, 405, DateTimeKind.Local).AddTicks(9854), "هاجر طارق", "Dianna Gusikowski", "حازم Group", "8773255885411199274", "Cuba", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1959, 1, 17, 9, 53, 42, 167, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 1, 20, 1, 22, 18, 394, DateTimeKind.Local).AddTicks(7486), "دانا إيهاب", "Abdiel Goyette", "إيهاب, فؤاد and عقیل", "8810530316192373819", "Belarus" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 5, 25, 23, 11, 33, 101, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 1, 19, 20, 46, 38, 53, DateTimeKind.Local).AddTicks(9701), "جابر‌ عقیل", "Freddy Cartwright", "فؤاد, زيد and فريد", "6950746492026656591", "Guyana", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 5, 6, 19, 46, 17, 297, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 1, 20, 4, 16, 23, 622, DateTimeKind.Local).AddTicks(3448), "إيناس عراقی", "Virginie Botsford", "أسامة Group", "1375929786108047004", "Madagascar", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 9, 15, 23, 46, 52, 492, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 1, 20, 0, 40, 1, 808, DateTimeKind.Local).AddTicks(7438), "إيهاب عزیز", "Maurice Quigley", "عقیل, إيهاب and عارف", "5477658748595711529", "Syrian Arab Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 11, 23, 0, 13, 28, 936, DateTimeKind.Local).AddTicks(7613), new DateTime(2024, 1, 20, 2, 35, 16, 623, DateTimeKind.Local).AddTicks(1297), "جمانة إيهاب", "Albert Wunsch", "أسامة - حسن", "193102956467877893", "Virgin Islands, U.S.", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 4, 22, 12, 10, 59, 614, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 1, 20, 18, 23, 32, 892, DateTimeKind.Local).AddTicks(3587), "إيهاب أسامة", "Nico Williamson", 1, "حسن, عارف and عزیز", "1463450526165813917", "Fiji", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 5, 9, 13, 30, 9, 437, DateTimeKind.Local).AddTicks(1844), new DateTime(2024, 1, 20, 14, 43, 21, 847, DateTimeKind.Local).AddTicks(2803), "شيماء جابر‌", "Dulce Padberg", "عراقی - صلاح", "7201680747481053805", "Montenegro" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 10, 3, 14, 42, 13, 140, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 1, 19, 19, 3, 31, 443, DateTimeKind.Local).AddTicks(5976), "سارة عقیل", "Stanford Steuber", 0, "صلاح LLC", "5330480249822796152", "Belgium" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 7, 11, 2, 13, 18, 998, DateTimeKind.Local).AddTicks(4296), new DateTime(2024, 1, 19, 19, 55, 26, 727, DateTimeKind.Local).AddTicks(4280), "رنا أمجد", "Woodrow Kshlerin", "فاروق, أمجد and طارق", "6845638626704874460", "Central African Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 5, 23, 0, 12, 45, 56, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 1, 20, 2, 20, 24, 4, DateTimeKind.Local).AddTicks(8652), "آدم فريد", "Chelsea Mitchell", "فؤاد - آدم", "2022062177259971259", "Cambodia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 10, 11, 16, 51, 32, 953, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 1, 20, 10, 55, 1, 129, DateTimeKind.Local).AddTicks(2153), "عبير سعيد", "Phoebe Greenholt", "عصار Group", "6737575686100605902", "Afghanistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 6, 2, 6, 11, 39, 929, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 1, 20, 2, 8, 42, 166, DateTimeKind.Local).AddTicks(8192), "عبير طارق", "Anita Sanford", 0, "عزیز - آدم", "6519844277568673505", "Luxembourg" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 4, 2, 14, 31, 13, 298, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 1, 20, 17, 1, 46, 631, DateTimeKind.Local).AddTicks(2748), "آية عاشور", "Anastacio Koepp", "فؤاد - ربيع", "6284931456119678305", "Rwanda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 5, 22, 21, 7, 25, 248, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 1, 20, 4, 23, 9, 466, DateTimeKind.Local).AddTicks(780), "سالم سعيد", "Orland Hyatt", "فريد Inc", "2873371169806626763", "Rwanda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 6, 24, 17, 34, 48, 676, DateTimeKind.Local).AddTicks(1521), new DateTime(2024, 1, 20, 17, 37, 51, 623, DateTimeKind.Local).AddTicks(8181), "جابر‌ زيد", "Lexi Rice", "عراقی, إيهاب and عزیز", "3720303118521059687", "Brazil", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 15, 9, 4, 58, 759, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 1, 20, 12, 39, 2, 832, DateTimeKind.Local).AddTicks(5678), "آية عزیز", "Dustin Volkman", "أسامة LLC", "8195704667925724321", "Panama", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 1, 9, 1, 32, 18, 8, DateTimeKind.Local).AddTicks(4546), new DateTime(2024, 1, 20, 17, 12, 13, 163, DateTimeKind.Local).AddTicks(8738), "فاروق صلاح", "Leta Cartwright", 0, "هاشم - حسن", "6438223063338941693", "Indonesia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 12, 3, 6, 38, 10, 690, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 1, 20, 2, 43, 22, 755, DateTimeKind.Local).AddTicks(4171), "زيد جابر‌", "Maverick Reichert", 1, "سعيد, جابر‌ and هاشم", "546664992100471206", "Zimbabwe", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1956, 7, 24, 11, 3, 44, 328, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 1, 19, 23, 34, 55, 602, DateTimeKind.Local).AddTicks(2015), "فؤاد فؤاد", "Johnathan Torphy", "فؤاد, آدم and زيد", "3235435939591432128", "Peru" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 5, 18, 13, 5, 9, 758, DateTimeKind.Local).AddTicks(7327), new DateTime(2024, 1, 20, 6, 6, 38, 217, DateTimeKind.Local).AddTicks(3465), "آية بلال", "Gail King", "طارق Inc", "1039023416873656221", "Maldives", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 2, 12, 21, 9, 109, DateTimeKind.Local).AddTicks(7400), new DateTime(2024, 1, 20, 14, 26, 16, 497, DateTimeKind.Local).AddTicks(9717), "ربيع هاشم", "Hallie Walter", 0, "فاروق, إيهاب and عارف", "7755741352632148373", "Panama", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 3, 31, 15, 43, 45, 351, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 1, 20, 3, 14, 24, 374, DateTimeKind.Local).AddTicks(6025), "منى هاشم", "Angus Zemlak", "حسن, عراقی and إيهاب", "6024153395493951118", "Marshall Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1982, 3, 31, 1, 41, 28, 998, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 1, 19, 23, 4, 17, 473, DateTimeKind.Local).AddTicks(1685), "شيماء سعيد", "Travon Russel", 1, "سالم, عاشور and آدم", "2849184964534601640", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 2, 8, 7, 24, 24, 421, DateTimeKind.Local).AddTicks(9282), new DateTime(2024, 1, 20, 13, 4, 35, 165, DateTimeKind.Local).AddTicks(4913), "صلاح عراقی", "Melvin Trantow", 0, "معروف, أمجد and عقیل", "5354106910307543043", "Pakistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 11, 30, 2, 37, 3, 710, DateTimeKind.Local).AddTicks(9203), new DateTime(2024, 1, 20, 12, 16, 49, 851, DateTimeKind.Local).AddTicks(3469), "دانا سالم", "Kaycee Larkin", 1, "أمجد, عارف and فؤاد", "5992702303058268048", "Madagascar", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 9, 2, 8, 21, 40, 870, DateTimeKind.Local).AddTicks(1461), new DateTime(2024, 1, 20, 18, 12, 25, 878, DateTimeKind.Local).AddTicks(9824), "هاجر عارف", "Jerrold Stiedemann", "طارق and Sons", "3668384355391342206", "Italy", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 12, 7, 1, 16, 28, 351, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 1, 20, 11, 12, 5, 883, DateTimeKind.Local).AddTicks(2264), "جمانة بلال", "Jerrold Stoltenberg", 0, "هاشم and Sons", "5987341272578412861", "Niue", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 11, 27, 18, 42, 20, 158, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 1, 20, 0, 6, 41, 712, DateTimeKind.Local).AddTicks(4436), "فريد سعيد", "Gordon Hauck", "عراقی Group", "485790099488091372", "Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 1, 12, 16, 30, 31, 580, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 1, 20, 3, 24, 43, 994, DateTimeKind.Local).AddTicks(5951), "طارق عصار", "Vidal Johnson", "أسامة, سعيد and عزیز", "1423191879764408028", "Denmark", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 9, 21, 14, 41, 15, 735, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 1, 20, 8, 32, 41, 311, DateTimeKind.Local).AddTicks(7338), "فريدة إيهاب", "Neil Schamberger", "إيهاب, ربيع and أسامة", "8459333634190197888", "Thailand", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 4, 20, 22, 51, 53, 17, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 1, 20, 8, 38, 39, 844, DateTimeKind.Local).AddTicks(8984), "حازم سعيد", "Francisca Mueller", 1, "فؤاد LLC", "8918277483298536260", "Lebanon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 7, 23, 10, 12, 25, 72, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 1, 20, 3, 20, 22, 501, DateTimeKind.Local).AddTicks(6228), "بلال أسامة", "Benjamin Jakubowski", 0, "جابر‌ - إيهاب", "2851538771580883056", "Indonesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 4, 22, 11, 5, 29, 875, DateTimeKind.Local).AddTicks(2356), new DateTime(2024, 1, 19, 20, 44, 19, 496, DateTimeKind.Local).AddTicks(4782), "هاجر أمجد", "Ericka Jacobi", 1, "عقیل, آدم and آدم", "7949943442391468671", "Lebanon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 2, 3, 14, 52, 26, 185, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 1, 20, 2, 28, 35, 338, DateTimeKind.Local).AddTicks(1164), "أسامة عزیز", "Conor Purdy", "هاشم - إيهاب", "60640770167977987", "South Africa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 7, 22, 3, 20, 43, 33, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 1, 19, 22, 32, 55, 449, DateTimeKind.Local).AddTicks(6380), "آية جابر‌", "Keon Labadie", 0, "سعيد, صلاح and فريد", "2392952514344428877", "Ukraine", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 7, 17, 3, 39, 43, 711, DateTimeKind.Local).AddTicks(3951), new DateTime(2024, 1, 20, 5, 44, 55, 458, DateTimeKind.Local).AddTicks(6835), "زينب عاشور", "Francisca Greenholt", "بلال, زيد and أمجد", "2029332485631406834", "Venezuela", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 5, 28, 9, 42, 9, 667, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 1, 20, 13, 26, 48, 84, DateTimeKind.Local).AddTicks(6048), "فؤاد عصار", "Claire Stracke", 0, "زيد - سعيد", "8654185789762819646", "Saint Vincent and the Grenadines" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 12, 21, 9, 52, 47, 783, DateTimeKind.Local).AddTicks(3561), new DateTime(2024, 1, 19, 20, 29, 28, 375, DateTimeKind.Local).AddTicks(6714), "دانا حازم", "Kyler Lueilwitz", "فريد Inc", "4694293732229886714", "Chad" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 12, 21, 23, 59, 13, 911, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 1, 20, 0, 56, 46, 841, DateTimeKind.Local).AddTicks(4879), "فؤاد عقیل", "Susie Cronin", 1, "فؤاد LLC", "204449719669014605", "Nauru", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 28, 19, 15, 26, 774, DateTimeKind.Local).AddTicks(1534), new DateTime(2024, 1, 20, 4, 0, 7, 435, DateTimeKind.Local).AddTicks(6341), "فريدة معروف", "Crystel Goodwin", "عصار, فاروق and فريد", "8146314740441857436", "Falkland Islands (Malvinas)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 2, 20, 8, 27, 21, 925, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 1, 20, 4, 21, 28, 529, DateTimeKind.Local).AddTicks(9487), "فؤاد عقیل", "Edward Harber", 1, "فؤاد, عصار and حسن", "1065945466252154631", "Niger", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 20, 22, 20, 43, 360, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 1, 20, 4, 48, 52, 691, DateTimeKind.Local).AddTicks(9661), "صلاح فريد", "Veda Reinger", 0, "سالم, صلاح and بلال", "7383865167510696262", "Tanzania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 12, 14, 9, 36, 47, 308, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 1, 19, 19, 19, 2, 468, DateTimeKind.Local).AddTicks(2952), "حسن سالم", "Jameson O'Kon", "صلاح and Sons", "1633152817257579767", "Turkmenistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 3, 24, 14, 46, 19, 600, DateTimeKind.Local).AddTicks(1158), new DateTime(2024, 1, 19, 21, 41, 3, 734, DateTimeKind.Local).AddTicks(8121), "سارة عقیل", "Idella Reichert", "طارق Inc", "7424596465112214786", "Switzerland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 1, 24, 7, 0, 38, 112, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 1, 20, 11, 19, 8, 361, DateTimeKind.Local).AddTicks(6126), "بلال سعيد", "Mabel Ritchie", "عقیل Inc", "1262954676604401698", "Germany", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 2, 11, 50, 26, 116, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 1, 20, 12, 17, 46, 438, DateTimeKind.Local).AddTicks(6270), "فؤاد زيد", "Allan Upton", "فاروق, زيد and حسن", "7871927299614803198", "Sweden", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 10, 17, 19, 16, 13, 901, DateTimeKind.Local).AddTicks(1680), new DateTime(2024, 1, 19, 21, 16, 53, 372, DateTimeKind.Local).AddTicks(5806), "إيناس هاشم", "Yasmine Bauch", 1, "عراقی, عقیل and عزیز", "4997829571092485860", "United Arab Emirates", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 6, 8, 11, 56, 48, 416, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 1, 19, 19, 15, 44, 460, DateTimeKind.Local).AddTicks(4667), "آية آدم", "Heidi Hansen", 0, "عصار - سعيد", "8238794721877884811", "Wallis and Futuna", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 3, 6, 5, 48, 28, 895, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 1, 20, 6, 37, 24, 407, DateTimeKind.Local).AddTicks(5759), "فريد عصار", "Unique Waters", "إيهاب - أسامة", "4235566688912142847", "Jamaica", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 3, 20, 15, 3, 27, 739, DateTimeKind.Local).AddTicks(2443), new DateTime(2024, 1, 19, 19, 13, 39, 321, DateTimeKind.Local).AddTicks(2205), "صلاح فؤاد", "Kaela Price", "صلاح LLC", "6588317609808922784", "Uzbekistan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 2, 24, 0, 34, 4, 986, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 1, 20, 2, 12, 19, 371, DateTimeKind.Local).AddTicks(5192), "شيماء طارق", "Nestor Schultz", 1, "بلال LLC", "5178036801498383434", "Sudan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1954, 7, 8, 23, 24, 9, 49, DateTimeKind.Local).AddTicks(7433), new DateTime(2024, 1, 20, 18, 8, 28, 849, DateTimeKind.Local).AddTicks(3254), "آدم حسن", "Vilma Russel", 0, "فريد - هاشم", "8339021285714947073", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 12, 9, 7, 14, 1, 349, DateTimeKind.Local).AddTicks(5414), new DateTime(2024, 1, 20, 1, 43, 18, 186, DateTimeKind.Local).AddTicks(8912), "فريد فريد", "Kamille Weimann", "عصار Group", "5681837872080238297", "Cameroon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 5, 15, 22, 38, 49, 619, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 1, 20, 17, 3, 26, 781, DateTimeKind.Local).AddTicks(1893), "زينب سعيد", "Leif Feest", "جابر‌, فؤاد and آدم", "8742909774614727978", "Central African Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 3, 25, 0, 29, 54, 706, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 1, 20, 14, 45, 31, 364, DateTimeKind.Local).AddTicks(737), "آدم حسن", "Pierre Waelchi", 1, "حسن - أمجد", "2195877423450044311", "Gabon", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 4, 15, 18, 5, 47, 869, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 1, 20, 6, 33, 19, 810, DateTimeKind.Local).AddTicks(1718), "جمانة حازم", "Kieran Ratke", 1, "عزیز - سعيد", "4826479348355403291", "Iran", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 1, 31, 21, 1, 25, 177, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 1, 20, 16, 35, 15, 382, DateTimeKind.Local).AddTicks(4542), "آدم بلال", "Silas Kihn", 1, "آدم, فؤاد and عراقی", "7156917752251998529", "Bermuda", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 18, 10, 14, 34, 860, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 1, 19, 18, 37, 3, 25, DateTimeKind.Local).AddTicks(2190), "هاجر إيهاب", "Cyrus Ritchie", "حسن Group", "8219163676734037746", "Nicaragua", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 3, 23, 7, 43, 32, 748, DateTimeKind.Local).AddTicks(967), new DateTime(2024, 1, 20, 10, 37, 15, 731, DateTimeKind.Local).AddTicks(9465), "دانا هاشم", "Uriel Abshire", "فريد LLC", "1793141399960008474", "Reunion", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 13, 13, 49, 59, 281, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 1, 19, 23, 51, 56, 182, DateTimeKind.Local).AddTicks(8352), "جمانة حسن", "Lucinda Johnson", 0, "عارف, إيهاب and حازم", "6324374140087646229", "Guinea-Bissau", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 12, 6, 21, 27, 18, 35, DateTimeKind.Local).AddTicks(4441), new DateTime(2024, 1, 20, 10, 0, 43, 707, DateTimeKind.Local).AddTicks(2940), "آية إيهاب", "Martin Halvorson", 0, "إيهاب LLC", "2191370630001154289", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 1, 31, 23, 59, 24, 701, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 1, 20, 3, 56, 40, 556, DateTimeKind.Local).AddTicks(4915), "فاروق فؤاد", "Garfield Rempel", 0, "ربيع, بلال and حسن", "5437165649820494889", "Peru", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 4, 13, 8, 1, 38, 628, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 1, 19, 23, 43, 6, 757, DateTimeKind.Local).AddTicks(4116), "إيهاب فؤاد", "Carlos Lakin", 0, "فريد, بلال and فريد", "8716807360829831814", "Slovenia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 11, 23, 3, 44, 34, 584, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 1, 19, 21, 6, 46, 898, DateTimeKind.Local).AddTicks(6553), "رقية هاشم", "Patience Schultz", 0, "عراقی, فريد and فاروق", "480478816291103506", "Wallis and Futuna", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 4, 26, 1, 20, 37, 136, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 1, 20, 16, 34, 41, 239, DateTimeKind.Local).AddTicks(2137), "حازم أسامة", "Irma Von", 0, "عراقی, فؤاد and جابر‌", "8941184652354575070", "Barbados", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 26, 11, 55, 5, 36, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 1, 20, 17, 33, 28, 951, DateTimeKind.Local).AddTicks(2059), "دانا هاشم", "Coty Bednar", 0, "عصار and Sons", "4125256003680510907", "Macedonia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 10, 21, 8, 38, 40, 72, DateTimeKind.Local).AddTicks(4419), new DateTime(2024, 1, 20, 4, 2, 45, 553, DateTimeKind.Local).AddTicks(6476), "ريم عزیز", "Emilio Wunsch", 0, "حسن - عراقی", "8472471202291123674", "Antigua and Barbuda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 10, 8, 16, 6, 32, 387, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 1, 20, 8, 19, 28, 400, DateTimeKind.Local).AddTicks(39), "بلال حسن", "Tianna Robel", 1, "أمجد - هاشم", "8868544166790437386", "Nepal", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 11, 13, 13, 30, 743, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 1, 19, 21, 49, 4, 642, DateTimeKind.Local).AddTicks(7748), "سارة سالم", "Elinore Baumbach", "طارق, زيد and إيهاب", "5181338853015595151", "Madagascar", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 2, 17, 52, 42, 867, DateTimeKind.Local).AddTicks(6028), new DateTime(2024, 1, 20, 2, 33, 4, 601, DateTimeKind.Local).AddTicks(372), "إيهاب هاشم", "Albina Ferry", "فاروق, حازم and أمجد", "6409864603031935554", "Macedonia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 7, 11, 15, 32, 41, 775, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 1, 20, 17, 22, 36, 8, DateTimeKind.Local).AddTicks(1629), "أمجد إيهاب", "Maida Conn", "طارق - عقیل", "8480478229267235056", "Netherlands Antilles", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 12, 20, 16, 3, 44, 261, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 1, 20, 0, 46, 51, 312, DateTimeKind.Local).AddTicks(8272), "رنا عقیل", "Ignacio Carroll", 0, "طارق, زيد and صلاح", "362026565088993844", "Antarctica (the territory South of 60 deg S)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 11, 20, 8, 24, 23, 306, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 1, 20, 7, 55, 50, 581, DateTimeKind.Local).AddTicks(9744), "فؤاد طارق", "Monte Grimes", "جابر‌, عزیز and عقیل", "8247294385351436103", "American Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 2, 5, 4, 35, 20, 28, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 1, 19, 21, 4, 12, 224, DateTimeKind.Local).AddTicks(6451), "أسامة آدم", "Stan Braun", "أمجد - زيد", "527642570008430304", "Kenya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 12, 9, 19, 9, 57, 739, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 1, 20, 9, 16, 9, 108, DateTimeKind.Local).AddTicks(4317), "دانا سعيد", "Ciara Zieme", "عقیل, ربيع and عصار", "8295318223955980250", "Macao", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 4, 27, 4, 9, 30, 267, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 1, 20, 15, 32, 54, 22, DateTimeKind.Local).AddTicks(376), "طارق ربيع", "Elroy Feil", 1, "هاشم, حسن and معروف", "2718880027376694548", "Jersey" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 5, 1, 20, 7, 23, 488, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 1, 20, 12, 57, 11, 884, DateTimeKind.Local).AddTicks(902), "أسامة سعيد", "Jessie Fritsch", 1, "زيد LLC", "5160585787530254752", "Germany", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 8, 6, 3, 30, 6, 341, DateTimeKind.Local).AddTicks(6490), new DateTime(2024, 1, 20, 9, 1, 39, 528, DateTimeKind.Local).AddTicks(3987), "جمانة عارف", "Antonette Schuster", "عزیز, هاشم and فاروق", "1871883023489905435", "South Africa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 7, 23, 21, 32, 11, 500, DateTimeKind.Local).AddTicks(9009), new DateTime(2024, 1, 20, 17, 56, 43, 90, DateTimeKind.Local).AddTicks(4697), "منى صلاح", "Amalia Kulas", 1, "حسن and Sons", "7591702083000295794", "Iceland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 7, 17, 23, 44, 50, 145, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 1, 20, 1, 33, 55, 177, DateTimeKind.Local).AddTicks(3999), "إيهاب طارق", "Diamond Kunze", "بلال, عزیز and إيهاب", "8094454489425424665", "Tanzania", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 2, 22, 21, 15, 36, 547, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 1, 19, 18, 43, 24, 394, DateTimeKind.Local).AddTicks(7123), "أسامة زيد", "Gordon O'Hara", 0, "عارف - عصار", "7422449181930939731", "Faroe Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 11, 3, 19, 52, 32, 194, DateTimeKind.Local).AddTicks(2714), new DateTime(2024, 1, 20, 14, 59, 15, 941, DateTimeKind.Local).AddTicks(571), "حسن زيد", "Lonzo Hauck", 0, "حازم, طارق and فؤاد", "2275276986224616173", "Norfolk Island", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 9, 4, 14, 4, 30, 448, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 1, 20, 8, 11, 49, 393, DateTimeKind.Local).AddTicks(5155), "فاطمة عقیل", "Donny Schamberger", "أمجد - صلاح", "3881217892339198804", "Spain", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 1, 7, 0, 45, 30, 211, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 1, 20, 9, 15, 39, 795, DateTimeKind.Local).AddTicks(8938), "رقية فؤاد", "Angeline Bergnaum", "إيهاب - سالم", "7567854533201371476", "Japan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 6, 9, 11, 2, 8, 64, DateTimeKind.Local).AddTicks(8123), new DateTime(2024, 1, 19, 19, 58, 14, 257, DateTimeKind.Local).AddTicks(9878), "منى عاشور", "Raphaelle McDermott", 0, "حازم, إيهاب and عزیز", "5211928566262525041", "Madagascar", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 12, 18, 21, 19, 19, 807, DateTimeKind.Local).AddTicks(1931), new DateTime(2024, 1, 19, 23, 48, 3, 28, DateTimeKind.Local).AddTicks(2473), "آدم عراقی", "Yadira Schiller", "ربيع Inc", "6486272079253551011", "Zambia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 12, 9, 17, 54, 29, 341, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 1, 20, 5, 43, 19, 521, DateTimeKind.Local).AddTicks(5786), "سارة أسامة", "Nova Spencer", "عزیز LLC", "8699531056370295758", "Poland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 5, 14, 14, 41, 10, 568, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 1, 20, 12, 57, 23, 606, DateTimeKind.Local).AddTicks(9000), "فاروق حازم", "Beverly Mills", "حسن - عراقی", "4601458304569926272", "Slovenia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 4, 27, 15, 5, 20, 171, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 1, 20, 15, 5, 35, 887, DateTimeKind.Local).AddTicks(3544), "جابر‌ إيهاب", "Jessyca VonRueden", 0, "سالم, آدم and طارق", "950133904476107042", "Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 9, 19, 23, 38, 34, 13, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 1, 19, 19, 26, 8, 710, DateTimeKind.Local).AddTicks(4749), "سارة فاروق", "Naomie Schmitt", 0, "هاشم Inc", "3484395788975564232", "Mali", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 2, 5, 1, 4, 11, 747, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 1, 19, 23, 52, 6, 507, DateTimeKind.Local).AddTicks(9909), "زيد عارف", "Irwin Schaefer", "عقیل and Sons", "2591802890326194813", "Mayotte" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 10, 9, 18, 51, 21, 298, DateTimeKind.Local).AddTicks(84), new DateTime(2024, 1, 20, 1, 47, 59, 348, DateTimeKind.Local).AddTicks(6642), "أروى بلال", "Amy Mohr", "سالم and Sons", "1135583578395182498", "Cyprus", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 8, 17, 7, 23, 13, 684, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 1, 19, 21, 56, 10, 515, DateTimeKind.Local).AddTicks(4419), "حسن هاشم", "Felicita Hermiston", 0, "طارق - صلاح", "3422451171118244893", "Botswana", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 3, 27, 10, 46, 30, 28, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 1, 20, 16, 5, 43, 237, DateTimeKind.Local).AddTicks(5695), "رنا جابر‌", "Vergie Mayer", 1, "جابر‌, سعيد and بلال", "1731490337121289003", "French Guiana" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 11, 28, 6, 59, 5, 399, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 1, 20, 3, 17, 33, 995, DateTimeKind.Local).AddTicks(9359), "أسامة فاروق", "Zachary Koss", "أمجد Inc", "7325478576105128546", "Tonga", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 4, 16, 15, 24, 8, 314, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 1, 20, 2, 49, 39, 493, DateTimeKind.Local).AddTicks(6379), "أروى عقیل", "Claude Kling", 0, "زيد - أسامة", "1155758806179309126", "Romania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 12, 7, 7, 22, 12, 314, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 1, 20, 9, 52, 20, 573, DateTimeKind.Local).AddTicks(6375), "سارة سالم", "Ulises Abbott", "عارف Group", "262623296896873608", "Turkey", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 2, 14, 11, 8, 17, 110, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 1, 20, 17, 59, 35, 8, DateTimeKind.Local).AddTicks(5220), "جابر‌ معروف", "Cathy Batz", 1, "فريد Inc", "1377069313323250512", "French Polynesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 11, 17, 0, 59, 49, 112, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 1, 20, 14, 18, 52, 364, DateTimeKind.Local).AddTicks(9556), "ربيع ربيع", "Angie Daugherty", "ربيع, سعيد and عقیل", "894309056050788827", "Virgin Islands, British", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 2, 25, 17, 16, 9, 770, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 1, 20, 16, 1, 49, 449, DateTimeKind.Local).AddTicks(4169), "أروى فريد", "Lila Macejkovic", "معروف, صلاح and فاروق", "976592625710982205", "Jersey", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 4, 6, 19, 36, 56, 433, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 1, 20, 16, 44, 4, 269, DateTimeKind.Local).AddTicks(2486), "بلال أمجد", "Shawn Aufderhar", 1, "أمجد - صلاح", "3447892193832243173", "Central African Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 1, 15, 2, 19, 11, 206, DateTimeKind.Local).AddTicks(8419), new DateTime(2024, 1, 20, 14, 57, 6, 139, DateTimeKind.Local).AddTicks(633), "عبير فاروق", "Hanna Kunde", 0, "عاشور Inc", "2113179998176042892", "French Southern Territories", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 8, 24, 16, 6, 15, 411, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 1, 20, 12, 17, 47, 722, DateTimeKind.Local).AddTicks(3749), "دانا فؤاد", "Karolann Gusikowski", "عراقی and Sons", "4793045665329809980", "Canada", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 12, 12, 8, 8, 17, 708, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 1, 20, 1, 16, 14, 545, DateTimeKind.Local).AddTicks(1474), "أمجد فاروق", "Terence Lind", 1, "ربيع and Sons", "1992541602079517157", "Venezuela", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 11, 8, 7, 21, 20, 390, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 1, 19, 23, 46, 52, 611, DateTimeKind.Local).AddTicks(2980), "سارة فاروق", "Emmitt Shields", "أسامة, جابر‌ and عقیل", "7367221727678914099", "San Marino" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 3, 21, 16, 21, 34, 656, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 1, 20, 8, 37, 29, 891, DateTimeKind.Local).AddTicks(3246), "دانا إيهاب", "Misty Cormier", 0, "بلال, أمجد and عارف", "2363296033865729331", "Saint Vincent and the Grenadines", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1964, 2, 24, 11, 22, 38, 235, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 1, 20, 7, 24, 4, 297, DateTimeKind.Local).AddTicks(3070), "سالم آدم", "Larue Koepp", 0, "ربيع - جابر‌", "5350927836035141986", "France" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 9, 26, 10, 17, 19, 730, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 1, 20, 1, 57, 7, 498, DateTimeKind.Local).AddTicks(8567), "زيد سالم", "Jess Macejkovic", 0, "فؤاد, فاروق and فؤاد", "7369149127343572065", "Kazakhstan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 12, 2, 3, 7, 44, 173, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 1, 20, 0, 29, 10, 219, DateTimeKind.Local).AddTicks(543), "صلاح ربيع", "Anita Wolff", 0, "جابر‌ and Sons", "2375454823761823409", "Macedonia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1958, 1, 6, 21, 43, 54, 410, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 1, 20, 14, 40, 57, 551, DateTimeKind.Local).AddTicks(5844), "أسامة أسامة", "Abbie Cummings", 1, "آدم, عصار and إيهاب", "2954003154041660019", "Faroe Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 15, 0, 53, 56, 771, DateTimeKind.Local).AddTicks(5754), new DateTime(2024, 1, 19, 23, 58, 34, 963, DateTimeKind.Local).AddTicks(4012), "سعيد عقیل", "Emery Flatley", "فاروق, فؤاد and طارق", "5864438582378277199", "Spain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 5, 31, 19, 59, 6, 439, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 1, 20, 12, 55, 43, 162, DateTimeKind.Local).AddTicks(192), "ريم عراقی", "Joan Bechtelar", "حسن, فاروق and عقیل", "3875163581277165066", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 5, 17, 6, 18, 48, 292, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 1, 20, 13, 50, 30, 581, DateTimeKind.Local).AddTicks(6921), "فريد فريد", "Maximo Abernathy", 1, "عارف - صلاح", "2004917788073757451", "Faroe Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 7, 16, 9, 0, 43, 570, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 1, 20, 17, 39, 56, 206, DateTimeKind.Local).AddTicks(9623), "لمى حسن", "Shayne Reichel", 1, "ربيع and Sons", "3532725060379491953", "Saint Kitts and Nevis", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 3, 8, 23, 43, 18, 181, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 1, 20, 14, 39, 38, 152, DateTimeKind.Local).AddTicks(7859), "سالم عراقی", "Dawson Larson", 0, "سالم Group", "7479042002898119950", "Syrian Arab Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 2, 28, 7, 28, 9, 941, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 1, 20, 7, 22, 35, 880, DateTimeKind.Local).AddTicks(5956), "عبير جابر‌", "Gideon Gleason", 1, "فؤاد - فاروق", "3624000158271700875", "Turks and Caicos Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 6, 8, 1, 34, 15, 749, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 1, 20, 2, 40, 40, 21, DateTimeKind.Local).AddTicks(317), "رقية زيد", "Kailyn Metz", 0, "سالم - صلاح", "5190613020198888112", "Saint Barthelemy", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 11, 18, 7, 5, 55, 873, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 1, 20, 17, 45, 8, 739, DateTimeKind.Local).AddTicks(4338), "جمانة حازم", "Herminio Heathcote", "فاروق - عزیز", "6871952578062236673", "Jamaica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1959, 12, 1, 23, 32, 5, 340, DateTimeKind.Local).AddTicks(6677), new DateTime(2024, 1, 20, 13, 1, 8, 797, DateTimeKind.Local).AddTicks(4921), "فاطمة آدم", "Idella Goyette", "حازم - سالم", "5687160938774450405", "Trinidad and Tobago" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 4, 4, 14, 51, 27, 590, DateTimeKind.Local).AddTicks(8938), new DateTime(2024, 1, 20, 3, 21, 43, 368, DateTimeKind.Local).AddTicks(3096), "رقية عزیز", "Ethel Schulist", 0, "معروف Group", "2138896266920378738", "Bahamas", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 12, 23, 9, 42, 52, 575, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 1, 20, 9, 57, 18, 982, DateTimeKind.Local).AddTicks(4847), "حازم عاشور", "Damian Gleichner", "سعيد - زيد", "7174634744274993962", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 4, 23, 23, 25, 22, 476, DateTimeKind.Local).AddTicks(5332), new DateTime(2024, 1, 20, 14, 17, 44, 360, DateTimeKind.Local).AddTicks(4681), "هاجر فؤاد", "Norene Braun", "حازم - ربيع", "3878650869282438410", "Hong Kong" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 4, 28, 13, 40, 38, 670, DateTimeKind.Local).AddTicks(8331), new DateTime(2024, 1, 20, 13, 25, 37, 311, DateTimeKind.Local).AddTicks(7305), "رنا آدم", "Myles Jast", 1, "أسامة, زيد and طارق", "2032882031267316776", "Namibia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 11, 12, 16, 18, 46, 971, DateTimeKind.Local).AddTicks(4885), new DateTime(2024, 1, 19, 21, 0, 11, 10, DateTimeKind.Local).AddTicks(8238), "رنا عارف", "Florence Becker", 0, "عقیل, أمجد and عاشور", "2506830563549500661", "El Salvador", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 11, 21, 16, 35, 14, 870, DateTimeKind.Local).AddTicks(1541), new DateTime(2024, 1, 20, 6, 50, 13, 693, DateTimeKind.Local).AddTicks(365), "هاجر عقیل", "Jeromy Schumm", 1, "جابر‌ - أمجد", "7691049756330373078", "Saint Barthelemy", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 10, 18, 22, 11, 4, 946, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 1, 20, 7, 59, 22, 990, DateTimeKind.Local).AddTicks(3194), "زيد فؤاد", "Damaris White", 1, "أسامة - فريد", "7103862416895640841", "Saint Martin", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 4, 17, 22, 36, 8, 815, DateTimeKind.Local).AddTicks(2235), new DateTime(2024, 1, 19, 20, 58, 5, 394, DateTimeKind.Local).AddTicks(5942), "رنا طارق", "Abner Walker", "عزیز, فؤاد and فؤاد", "4361699013901621098", "Azerbaijan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 9, 3, 10, 59, 20, 670, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 1, 20, 2, 38, 0, 466, DateTimeKind.Local).AddTicks(1169), "فريدة حسن", "Duane Schaefer", "سعيد Inc", "8870634543154952835", "Costa Rica", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 7, 11, 53, 44, 861, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 1, 19, 19, 57, 9, 3, DateTimeKind.Local).AddTicks(5026), "أسامة طارق", "Marion Zemlak", 1, "عاشور - جابر‌", "7731334673079056269", "Argentina", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 7, 10, 8, 0, 35, 135, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 1, 20, 14, 11, 55, 530, DateTimeKind.Local).AddTicks(9472), "آية عارف", "Rollin Dickens", 1, "فاروق and Sons", "3313952338627432159", "Libyan Arab Jamahiriya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 10, 15, 5, 3, 42, 235, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 1, 19, 22, 56, 39, 266, DateTimeKind.Local).AddTicks(4403), "أمجد سعيد", "Susana Wunsch", 1, "عراقی - عراقی", "2365462170600565471", "Denmark", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 8, 22, 14, 58, 27, 578, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 1, 20, 16, 45, 30, 82, DateTimeKind.Local).AddTicks(6906), "صلاح صلاح", "Carolyne Medhurst", 1, "فاروق - حسن", "1780722010504551515", "Vanuatu", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1992, 10, 7, 19, 37, 19, 985, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 1, 19, 21, 5, 47, 900, DateTimeKind.Local).AddTicks(897), "لمى بلال", "Mekhi Jacobson", "حسن LLC", "2685792390489783935", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1960, 1, 18, 16, 50, 27, 242, DateTimeKind.Local).AddTicks(9777), new DateTime(2024, 1, 20, 0, 56, 14, 172, DateTimeKind.Local).AddTicks(7562), "رنا هاشم", "Randi Bahringer", "بلال Group", "3270727581697961455", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 6, 22, 17, 36, 20, 604, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 1, 20, 8, 9, 31, 837, DateTimeKind.Local).AddTicks(9134), "هاجر آدم", "Hershel Lehner", 0, "حازم Group", "7950055946005200022", "Mauritania" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 11, 14, 15, 52, 23, 914, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 1, 19, 21, 0, 16, 278, DateTimeKind.Local).AddTicks(7927), "دانا أسامة", "Garth Rolfson", "حسن, فاروق and عزیز", "1366453739606131919", "Suriname", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 3, 16, 0, 22, 50, 953, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 1, 20, 4, 20, 43, 58, DateTimeKind.Local).AddTicks(1731), "زيد عقیل", "Estrella Predovic", 1, "أسامة Group", "8433392589642866444", "Bermuda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 5, 15, 3, 49, 50, 586, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 1, 20, 10, 21, 5, 152, DateTimeKind.Local).AddTicks(9631), "عبير معروف", "Lisette Brekke", 1, "إيهاب - أمجد", "3198885471041047610", "Honduras", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 2, 19, 13, 47, 587, DateTimeKind.Local).AddTicks(5040), new DateTime(2024, 1, 19, 19, 18, 8, 929, DateTimeKind.Local).AddTicks(756), "بلال عراقی", "Dashawn Skiles", 0, "طارق and Sons", "1851395946568597226", "Kiribati", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 7, 31, 22, 20, 51, 932, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 1, 20, 0, 13, 9, 455, DateTimeKind.Local).AddTicks(2323), "أمجد حسن", "Tabitha Satterfield", "بلال, إيهاب and جابر‌", "4839885811861981751", "Slovakia (Slovak Republic)", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 7, 3, 16, 50, 26, 245, DateTimeKind.Local).AddTicks(9123), new DateTime(2024, 1, 19, 21, 41, 20, 396, DateTimeKind.Local).AddTicks(4796), "هاجر ربيع", "Dawn Herzog", "حازم Group", "2622743473143500044", "Morocco", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 12, 22, 43, 31, 145, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 1, 20, 11, 36, 45, 228, DateTimeKind.Local).AddTicks(6212), "حسن ربيع", "Jody Labadie", "سالم, صلاح and سعيد", "2758947595835427555", "Northern Mariana Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 3, 20, 13, 21, 50, 213, DateTimeKind.Local).AddTicks(1920), new DateTime(2024, 1, 19, 22, 35, 41, 145, DateTimeKind.Local).AddTicks(7479), "بلال سعيد", "Sigmund Klocko", 0, "سالم, هاشم and عراقی", "1497106912060325550", "Bouvet Island (Bouvetoya)", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 1, 7, 7, 52, 22, 221, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 1, 20, 0, 38, 43, 129, DateTimeKind.Local).AddTicks(1854), "شيماء حازم", "Christopher Green", "عقیل and Sons", "4667767081936309186", "American Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 2, 5, 11, 21, 2, 566, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 1, 19, 20, 21, 7, 464, DateTimeKind.Local).AddTicks(2811), "Rosella Kirlin", "أمجد, صلاح and سعيد", "1146321237153596071", "Seychelles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 2, 9, 20, 30, 2, 798, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 1, 20, 12, 6, 31, 805, DateTimeKind.Local).AddTicks(3705), "شيماء سعيد", "Cordia Sanford", 1, "طارق, صلاح and فؤاد", "5744948509525861774", "Kuwait", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 2, 19, 10, 38, 47, 786, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 1, 20, 17, 51, 17, 152, DateTimeKind.Local).AddTicks(5941), "لمى إيهاب", "Tracy Beier", 0, "إيهاب LLC", "5038264248327193323", "Ireland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 4, 30, 10, 26, 51, 475, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 1, 20, 12, 13, 24, 685, DateTimeKind.Local).AddTicks(1579), "أمجد فؤاد", "Anibal Pagac", "حسن, عاشور and طارق", "3062257958395770658", "Niue", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 8, 31, 12, 25, 2, 768, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 1, 19, 19, 1, 34, 866, DateTimeKind.Local).AddTicks(3271), "هاجر جابر‌", "Connie Spinka", 1, "إيهاب and Sons", "5097166592675607569", "Colombia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 1, 18, 19, 0, 23, 92, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 1, 20, 17, 40, 59, 487, DateTimeKind.Local).AddTicks(1854), "هاجر طارق", "Trenton Oberbrunner", 1, "عقیل Inc", "5734748972699036380", "Romania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 6, 23, 3, 26, 30, 313, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 1, 20, 11, 7, 45, 16, DateTimeKind.Local).AddTicks(5842), "أمجد زيد", "Ariel Auer", 1, "عاشور - فريد", "3193243834130749150", "Iran", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 7, 18, 17, 55, 59, 597, DateTimeKind.Local).AddTicks(9987), new DateTime(2024, 1, 20, 15, 54, 2, 296, DateTimeKind.Local).AddTicks(3540), "فؤاد سالم", "Rowena Becker", "زيد, أمجد and حازم", "6209993465435162988", "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 8, 2, 6, 22, 43, 451, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 1, 20, 18, 26, 54, 212, DateTimeKind.Local).AddTicks(5202), "إيهاب عصار", "Ricky Jenkins", 1, "عقیل - زيد", "5815680724915298566", "Turkmenistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1987, 8, 6, 20, 55, 41, 144, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 1, 20, 13, 17, 30, 659, DateTimeKind.Local).AddTicks(8048), "حسن عقیل", "Eino Jacobson", "سالم - صلاح", "5785240192762812722", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 8, 25, 22, 23, 35, 357, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 1, 20, 14, 55, 10, 790, DateTimeKind.Local).AddTicks(4181), "شيماء فؤاد", "Julia Hirthe", 0, "حسن - معروف", "8597436659767064532", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 7, 6, 13, 5, 39, 502, DateTimeKind.Local).AddTicks(327), new DateTime(2024, 1, 20, 15, 48, 15, 171, DateTimeKind.Local).AddTicks(7394), "إيناس أمجد", "Aron Smitham", "عراقی - طارق", "4590582068444161032", "Chad", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 10, 18, 11, 5, 7, 472, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 1, 20, 3, 48, 33, 266, DateTimeKind.Local).AddTicks(1320), "سارة بلال", "Maybelle Marvin", "أسامة - حسن", "1344830072264427301", "Grenada", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 1, 27, 7, 54, 38, 34, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 1, 19, 22, 28, 40, 198, DateTimeKind.Local).AddTicks(9045), "سعيد حسن", "Koby Erdman", 0, "حازم - ربيع", "5025267032106748605", "Honduras", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 6, 21, 3, 24, 32, 981, DateTimeKind.Local).AddTicks(7565), new DateTime(2024, 1, 19, 18, 53, 4, 821, DateTimeKind.Local).AddTicks(7140), "أسامة آدم", "Edgardo Durgan", "حسن Inc", "987352697792719316", "Nicaragua", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 6, 2, 9, 1, 21, 721, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 1, 20, 18, 3, 18, 694, DateTimeKind.Local).AddTicks(5110), "عبير إيهاب", "Marta Champlin", 1, "عزیز - فريد", "4502098814902771716", "Aruba", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 4, 10, 20, 7, 25, 979, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 1, 20, 9, 25, 54, 183, DateTimeKind.Local).AddTicks(2944), "إيناس فاروق", "Candice Ruecker", "معروف - آدم", "77130365919822808", "Trinidad and Tobago", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 6, 10, 18, 8, 57, 78, DateTimeKind.Local).AddTicks(8485), new DateTime(2024, 1, 19, 22, 48, 17, 358, DateTimeKind.Local).AddTicks(6811), "عبير معروف", "Jayde Wisoky", "عقیل - صلاح", "5431938449676994188", "New Caledonia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 5, 17, 0, 25, 8, 820, DateTimeKind.Local).AddTicks(7372), new DateTime(2024, 1, 19, 22, 37, 20, 699, DateTimeKind.Local).AddTicks(1891), "هاجر عصار", "Keon Lynch", 1, "معروف, سعيد and فاروق", "6315187433034609803", "Brazil", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1981, 12, 22, 19, 42, 41, 835, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 1, 20, 17, 2, 45, 618, DateTimeKind.Local).AddTicks(137), "جابر‌ ربيع", "Tina Green", "جابر‌, عقیل and حسن", "9131943607146205649", "Cambodia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 4, 23, 5, 43, 35, 467, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 1, 20, 1, 51, 1, 905, DateTimeKind.Local).AddTicks(3116), "سارة أمجد", "Brielle Boyle", 1, "طارق - آدم", "5615903279301652291", "Indonesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 12, 10, 9, 58, 45, 426, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 1, 19, 22, 9, 28, 803, DateTimeKind.Local).AddTicks(5611), "صلاح طارق", "Laurel Kuhn", 1, "عارف - عصار", "7220757134316108337", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 2, 25, 1, 3, 39, 810, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 1, 20, 5, 17, 26, 913, DateTimeKind.Local).AddTicks(3487), "منى عارف", "Corrine Abernathy", "عقیل - زيد", "5596085292793561916", "Bosnia and Herzegovina", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 11, 25, 0, 4, 3, 97, DateTimeKind.Local).AddTicks(3917), new DateTime(2024, 1, 20, 0, 34, 16, 749, DateTimeKind.Local).AddTicks(5873), "أروى عاشور", "Barry Balistreri", "سالم LLC", "6889963787700991647", "Chad", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 7, 1, 14, 58, 33, 154, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 1, 20, 11, 44, 12, 583, DateTimeKind.Local).AddTicks(754), "عبير جابر‌", "Jamal Kris", "فاروق, جابر‌ and جابر‌", "4043579406200926029", "Ghana", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 7, 3, 0, 4, 10, 495, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 1, 20, 15, 47, 19, 483, DateTimeKind.Local).AddTicks(7455), "جابر‌ أسامة", "Reyna Ferry", 1, "آدم, معروف and فاروق", "197361630954290372", "Lithuania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1964, 11, 22, 12, 53, 36, 149, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 1, 20, 13, 9, 37, 212, DateTimeKind.Local).AddTicks(3388), "طارق معروف", "Mara Jast", 1, "أمجد - أمجد", "8006751995964850736", "Angola" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 3, 31, 0, 46, 57, 554, DateTimeKind.Local).AddTicks(8075), new DateTime(2024, 1, 20, 3, 21, 4, 759, DateTimeKind.Local).AddTicks(2087), "صلاح عاشور", "Matt Reichert", 0, "معروف - سعيد", "9125199869910789111", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 2, 23, 6, 45, 1, 778, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 1, 20, 4, 31, 51, 177, DateTimeKind.Local).AddTicks(7040), "منى زيد", "Jarred Walsh", 1, "ربيع, آدم and فاروق", "867191944477925715", "Uzbekistan", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, 005, جلاجل, United Kingdom", "خان شيخون", new DateTime(2024, 1, 17, 6, 0, 49, 686, DateTimeKind.Local).AddTicks(584), "dana.araqy9@hotmail.com", "251-702-2516 x9089" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 29, سنار, Germany", "إب", new DateTime(2024, 1, 17, 4, 27, 24, 66, DateTimeKind.Local).AddTicks(3259), "blal.amjd@gmail.com", "(963) 380-9111 x5423" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, 050, المنصورة, Belarus", "حلفا الجديدة", new DateTime(2024, 1, 17, 5, 46, 13, 88, DateTimeKind.Local).AddTicks(6175), "arwa_slah@gmail.com", "687-272-3600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 0, بيت حانون, Cape Verde", "حارم", new DateTime(2024, 1, 17, 9, 15, 13, 791, DateTimeKind.Local).AddTicks(7279), "aadm33@gmail.com", "1-760-503-0452" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, دوار فاطمی, 7, خان يونس, Heard Island and McDonald Islands", "تلكلخ", new DateTime(2024, 1, 17, 19, 48, 23, 800, DateTimeKind.Local).AddTicks(8046), "aayh_hazm@gmail.com", "(534) 888-4115 x701" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, شارع موحد دانش, 2, بور سعيد, Cambodia", "صور", new DateTime(2024, 1, 17, 17, 9, 11, 297, DateTimeKind.Local).AddTicks(1965), "hazm18@hotmail.com", "(956) 375-9561 x266" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 3, أبو كبير, Romania", "عين اعبيد", new DateTime(2024, 1, 17, 3, 36, 2, 676, DateTimeKind.Local).AddTicks(4670), "sayd_fuad68@gmail.com", "1-980-336-4132" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, تقاطع یادگار امام, 25, سطيف, Gambia", "طرابلس", new DateTime(2024, 1, 17, 4, 56, 13, 450, DateTimeKind.Local).AddTicks(2210), "arwa.salm19@gmail.com", "315-353-7005 x187" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 9801, بريكة, Kyrgyz Republic", "برشيد", new DateTime(2024, 1, 17, 19, 38, 11, 89, DateTimeKind.Local).AddTicks(6296), "mna87@hotmail.com", "(207) 815-8012 x237" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, ش ابوذر, 46, مدينة الصدر, Netherlands", "آلاك", new DateTime(2024, 1, 17, 2, 0, 11, 477, DateTimeKind.Local).AddTicks(3266), "blal.aashwr@yahoo.com", "(361) 561-4724" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, شارع اقبال لاهوری, 545, بيت حانون, Gambia", "اكجوجت", new DateTime(2024, 1, 17, 20, 20, 0, 647, DateTimeKind.Local).AddTicks(1349), "jmanh.tarq69@hotmail.com", "(398) 427-6305" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دیباجی, طريق آفریقا, 010, المالكية, Uzbekistan", "سطيف", new DateTime(2024, 1, 17, 9, 7, 53, 516, DateTimeKind.Local).AddTicks(785), "lma.sayd@hotmail.com", "373.348.3807 x4187" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, طريق شهید مطهری, 080, كفر الشيخ, Mauritania", "دمياط", new DateTime(2024, 1, 17, 21, 1, 55, 792, DateTimeKind.Local).AddTicks(2244), "rbya27@gmail.com", "808-557-8630 x11362" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, 35, بسكرة, Falkland Islands (Malvinas)", "بجاية", new DateTime(2024, 1, 17, 12, 47, 37, 380, DateTimeKind.Local).AddTicks(7393), "salm.iyhab52@gmail.com", "(843) 806-3473 x06527" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, شارع استاد قریب, 4, البصرة, Belarus", "قليوب", new DateTime(2024, 1, 17, 5, 29, 15, 14, DateTimeKind.Local).AddTicks(9143), "lma65@yahoo.com", "883.838.6165" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, ش آزادی, 6077, اوبيو, New Caledonia", "مدحاء", new DateTime(2024, 1, 17, 22, 37, 26, 298, DateTimeKind.Local).AddTicks(9111), "asamh59@yahoo.com", "(338) 798-5466 x7680" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, دوار مالک اشتر, 51, الرمثا, Aruba", "الحسيمة", new DateTime(2024, 1, 17, 15, 39, 12, 274, DateTimeKind.Local).AddTicks(7075), "hazm_hsn@yahoo.com", "1-617-791-3284" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 950, البليدة, Gambia", "تجكجة", new DateTime(2024, 1, 17, 10, 39, 33, 50, DateTimeKind.Local).AddTicks(6773), "abyr.araqy95@yahoo.com", "(635) 801-8600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, دوار سمیه, 5765, القحطانية, Samoa", "الدوحة", new DateTime(2024, 1, 17, 18, 27, 1, 336, DateTimeKind.Local).AddTicks(912), "asamh34@gmail.com", "996.741.4284" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, دوار سباری, 7766, السويداء, Anguilla", "باب الزوار", new DateTime(2024, 1, 17, 18, 26, 46, 507, DateTimeKind.Local).AddTicks(7200), "fatmh.hazm@yahoo.com", "619.244.6955 x452" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق رسالت, ش حقانی, 4189, السماوة, French Southern Territories", "سيدي بلعباس", new DateTime(2024, 1, 16, 23, 50, 25, 306, DateTimeKind.Local).AddTicks(4236), "zynb.fryd@hotmail.com", "488.785.0083" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, 6772, النبطية, Netherlands", "طرابلس", new DateTime(2024, 1, 17, 18, 33, 52, 87, DateTimeKind.Local).AddTicks(8577), "rna.araqy@gmail.com", "778.406.9224 x5370" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, 764, غريان, Solomon Islands", "الرملة", new DateTime(2024, 1, 17, 9, 53, 52, 764, DateTimeKind.Local).AddTicks(1784), "rqyh_amjd88@hotmail.com", "540.662.4102" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, 932, تلكلخ, Tanzania", "بور سعيد", new DateTime(2024, 1, 17, 8, 3, 27, 180, DateTimeKind.Local).AddTicks(301), "shymaa.hazm@hotmail.com", "(960) 608-7998" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, 0150, المالكية, Kazakhstan", "حلبجة", new DateTime(2024, 1, 17, 21, 13, 30, 439, DateTimeKind.Local).AddTicks(9939), "hajr_asar0@hotmail.com", "434-457-1448" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, 4708, الوجه, Maldives", "المسيلة", new DateTime(2024, 1, 17, 3, 6, 29, 948, DateTimeKind.Local).AddTicks(5186), "asamh89@gmail.com", "1-456-990-5912 x1598" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, 5458, الرس, Bulgaria", "أم درمان", new DateTime(2024, 1, 16, 23, 46, 14, 468, DateTimeKind.Local).AddTicks(9390), "rqyh_hsn14@hotmail.com", "336-277-7186 x485" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 9, الخميسات, Barbados", "عين اعبيد", new DateTime(2024, 1, 17, 12, 29, 14, 563, DateTimeKind.Local).AddTicks(8143), "farwq_fryd@yahoo.com", "1-564-398-8859" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, طريق آزادی, 6377, زلفي, Mauritius", "الفيوم", new DateTime(2024, 1, 17, 20, 26, 40, 722, DateTimeKind.Local).AddTicks(4062), "farwq.hashm28@yahoo.com", "1-370-463-4574 x627" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 177, بوكى, Burkina Faso", "غليزان", new DateTime(2024, 1, 17, 3, 47, 50, 784, DateTimeKind.Local).AddTicks(7484), "zyd.asar@gmail.com", "1-708-907-9811" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, دوار دستغیب, 8556, الزاوية, Moldova", "الإسماعيلية", new DateTime(2024, 1, 17, 18, 25, 14, 973, DateTimeKind.Local).AddTicks(677), "zynb_rbya@yahoo.com", "802.519.4031 x02026" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, 39, القنيطرة, Tuvalu", "السويداء", new DateTime(2024, 1, 17, 4, 58, 2, 677, DateTimeKind.Local).AddTicks(4526), "hajr.salm@yahoo.com", "(224) 630-1426" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, 3, تبوك, Jamaica", "دسوق", new DateTime(2024, 1, 17, 8, 25, 5, 613, DateTimeKind.Local).AddTicks(7717), "rna60@yahoo.com", "1-677-404-5669 x91633" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, ش رسالت, 22, العمران, Uruguay", "شرورة", new DateTime(2024, 1, 17, 0, 52, 39, 265, DateTimeKind.Local).AddTicks(4249), "mna25@hotmail.com", "490.663.4503 x844" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, طريق یادگار امام, 9, يافا, Belize", "القائم", new DateTime(2024, 1, 17, 1, 12, 26, 365, DateTimeKind.Local).AddTicks(3386), "amjd.hashm@hotmail.com", "999.210.7452 x8327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, 624, سيان, Tuvalu", "الفجيرة", new DateTime(2024, 1, 17, 14, 55, 17, 296, DateTimeKind.Local).AddTicks(3027), "dana.farwq78@yahoo.com", "1-343-840-4167 x754" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, تقاطع یادگار امام, 2871, العقير, Tuvalu", "الوادي", new DateTime(2024, 1, 17, 16, 3, 11, 157, DateTimeKind.Local).AddTicks(1696), "fuad.farwq@gmail.com", "632.418.6768 x829" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, 0, سلفيت, Algeria", "عدن", new DateTime(2024, 1, 17, 1, 1, 30, 473, DateTimeKind.Local).AddTicks(2551), "arwa96@hotmail.com", "663-909-0158" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, ميدان ابوذر, 01, أم رواب, Macedonia", "المنستير", new DateTime(2024, 1, 17, 12, 30, 58, 334, DateTimeKind.Local).AddTicks(8946), "amjd67@gmail.com", "1-592-666-8470 x9252" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق رسالت, تقاطع اقبال لاهوری, 66, القبة, Bhutan", "رابغ", new DateTime(2024, 1, 17, 15, 17, 39, 765, DateTimeKind.Local).AddTicks(7816), "sarh99@hotmail.com", "(628) 332-9148 x99194" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 6, العقبة, Dominican Republic", "مادبا", new DateTime(2024, 1, 17, 8, 42, 19, 598, DateTimeKind.Local).AddTicks(478), "amjd.sayd74@hotmail.com", "(459) 270-4387 x64296" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 96, مسعد, Bermuda", "بنها", new DateTime(2024, 1, 17, 20, 0, 59, 676, DateTimeKind.Local).AddTicks(8295), "asamh_aadm49@hotmail.com", "666-961-9716 x187" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, ميدان راستوان, 8, بورتسودان, Rwanda", "تعز", new DateTime(2024, 1, 17, 12, 35, 58, 598, DateTimeKind.Local).AddTicks(8144), "arwa1@yahoo.com", "1-596-839-2358" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, شارع آزادی, 5, عين وسارة, Somalia", "الفحيص", new DateTime(2024, 1, 17, 15, 34, 41, 858, DateTimeKind.Local).AddTicks(741), "hsn_hsn55@gmail.com", "1-946-954-9574 x3552" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, ش کارگر شمالی, 369, مقطع لحجار, Croatia", "دسوق", new DateTime(2024, 1, 17, 5, 15, 53, 30, DateTimeKind.Local).AddTicks(6660), "abyr.hsn60@hotmail.com", "(830) 382-8788 x996" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق راستوان, 16, أسيوط, Reunion", "الفلوجة", new DateTime(2024, 1, 17, 21, 28, 38, 882, DateTimeKind.Local).AddTicks(4606), "aadm_fryd60@hotmail.com", "(536) 690-6674" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, طريق سمیه, 3, الفيوم, Latvia", "زوارة", new DateTime(2024, 1, 17, 13, 4, 6, 169, DateTimeKind.Local).AddTicks(9507), "iynas11@yahoo.com", "1-509-600-5979 x7907" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, طريق قدس, 67, الصويرة, Kenya", "خميس مشيط", new DateTime(2024, 1, 17, 1, 51, 19, 935, DateTimeKind.Local).AddTicks(4248), "zyd.aqyl57@yahoo.com", "665-921-0445 x43059" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 843, كركوك, Turkmenistan", "بنغازي", new DateTime(2024, 1, 17, 9, 25, 58, 43, DateTimeKind.Local).AddTicks(4001), "zynb48@hotmail.com", "315-691-6836" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 0, حديثة, Vanuatu", "بركاء", new DateTime(2024, 1, 17, 10, 21, 7, 44, DateTimeKind.Local).AddTicks(6279), "shymaa_zyd15@gmail.com", "(219) 743-9736 x9921" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, ميدان دستغیب, 97, علي صبيح, Sierra Leone", "مطرح", new DateTime(2024, 1, 17, 1, 6, 31, 941, DateTimeKind.Local).AddTicks(7087), "shymaa.farwq40@hotmail.com", "1-832-488-7823" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, تقاطع سمیه, 5, القدس, Brunei Darussalam", "سكيكدة", new DateTime(2024, 1, 17, 9, 9, 23, 909, DateTimeKind.Local).AddTicks(500), "iyhab.hazm@gmail.com", "334.706.5051" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, طريق آذربایجان, 7, غريان, Faroe Islands", "بور سعيد", new DateTime(2024, 1, 17, 6, 4, 17, 408, DateTimeKind.Local).AddTicks(9833), "tarq8@hotmail.com", "954.664.2310 x43071" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 3, العقبة, Pakistan", "الدامر", new DateTime(2024, 1, 17, 4, 15, 45, 867, DateTimeKind.Local).AddTicks(828), "lma_hazm38@gmail.com", "330-631-3231 x15912" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, دوار شهید مطهری, 713, مدينة الملك عبد الله الاقتصادية, Cocos (Keeling) Islands", "اوبيو", new DateTime(2024, 1, 17, 16, 13, 3, 893, DateTimeKind.Local).AddTicks(8517), "sarh_asamh15@gmail.com", "1-933-451-4305" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, 0, الأغواط, Mayotte", "القريات", new DateTime(2024, 1, 17, 18, 39, 41, 330, DateTimeKind.Local).AddTicks(8620), "rna.marwf48@hotmail.com", "1-481-994-7494 x12645" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 1936, أسيوط, Thailand", "روصو", new DateTime(2024, 1, 16, 23, 55, 37, 688, DateTimeKind.Local).AddTicks(4668), "tarq_aarf67@hotmail.com", "219-740-3500" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, ميدان دماوند, 0459, سكاكا, French Southern Territories", "أرتا", new DateTime(2024, 1, 17, 19, 44, 47, 36, DateTimeKind.Local).AddTicks(5204), "hazm.rbya60@gmail.com", "1-802-843-7478 x10728" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, ميدان مالک اشتر, 11, الباحة, Tunisia", "سيان", new DateTime(2024, 1, 17, 15, 18, 1, 290, DateTimeKind.Local).AddTicks(1412), "shymaa58@yahoo.com", "(250) 762-4411" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, 062, صفاقس, French Guiana", "جنين", new DateTime(2024, 1, 17, 20, 28, 57, 975, DateTimeKind.Local).AddTicks(2841), "hsn37@gmail.com", "811-515-2757 x88146" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, 846, تزنيت, Saint Barthelemy", "حمص", new DateTime(2024, 1, 17, 6, 32, 58, 490, DateTimeKind.Local).AddTicks(1582), "zynb.aadm@yahoo.com", "445.653.4072 x89839" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, دوار استاد قریب, 076, كلميم, Egypt", "قلعة السراغنة", new DateTime(2024, 1, 17, 12, 28, 24, 168, DateTimeKind.Local).AddTicks(3793), "sarh_tarq32@yahoo.com", "1-350-668-6117" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق راستوان, 9, أسوان, Japan", "يافا", new DateTime(2024, 1, 17, 5, 0, 49, 627, DateTimeKind.Local).AddTicks(8125), "aayh85@yahoo.com", "598.280.9882 x3919" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, 24, يي, Canada", "ازويرات", new DateTime(2024, 1, 17, 19, 5, 23, 520, DateTimeKind.Local).AddTicks(4164), "farwq.azyz@yahoo.com", "1-298-988-9605 x32581" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, ميدان اقبال لاهوری, 1, الوادي, Western Sahara", "بورو", new DateTime(2024, 1, 17, 6, 35, 23, 33, DateTimeKind.Local).AddTicks(1723), "blal_azyz21@gmail.com", "661.537.1438" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, 60, الحجرة, Virgin Islands, U.S.", "بنجرير", new DateTime(2024, 1, 17, 4, 24, 24, 606, DateTimeKind.Local).AddTicks(5593), "tarq99@hotmail.com", "929-282-2718 x51988" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, طريق اقبال لاهوری, 823, مدينة ستة أكتوبر, Botswana", new DateTime(2024, 1, 17, 22, 5, 45, 769, DateTimeKind.Local).AddTicks(3948), "rbya.salm@yahoo.com", "(414) 567-7241" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, 85, القائم, United Arab Emirates", "مكة المكرمة", new DateTime(2024, 1, 17, 0, 55, 36, 181, DateTimeKind.Local).AddTicks(191), "rym_hashm3@yahoo.com", "306.415.8141 x44046" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, شارع راستوان, 6, جالكاسيو, South Georgia and the South Sandwich Islands", "الصويرة", new DateTime(2024, 1, 17, 2, 1, 42, 548, DateTimeKind.Local).AddTicks(7625), "aadm.jabr@yahoo.com", "(337) 797-9247 x27313" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, 51, اللد, Liberia", "البيضاء", new DateTime(2024, 1, 17, 13, 39, 51, 117, DateTimeKind.Local).AddTicks(4089), "fuad12@hotmail.com", "1-918-347-5970 x422" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, ش اقبال لاهوری, 1, مدينة عيسى, Turkmenistan", "الأبيض", new DateTime(2024, 1, 17, 0, 9, 28, 7, DateTimeKind.Local).AddTicks(9851), "iynas_iyhab41@yahoo.com", "584-929-8319 x46185" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, طريق آذربایجان, 9601, صحار, Eritrea", "السيب", new DateTime(2024, 1, 17, 17, 5, 36, 656, DateTimeKind.Local).AddTicks(9374), "fatmh84@gmail.com", "921-660-4456 x233" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, تقاطع دکتر چمران, 6126, الأغواط, British Indian Ocean Territory (Chagos Archipelago)", "القرداحة", new DateTime(2024, 1, 17, 1, 19, 38, 269, DateTimeKind.Local).AddTicks(4260), "iyhab54@yahoo.com", "1-305-221-0468 x00490" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 38, الخمس, New Zealand", "المزاحمية", new DateTime(2024, 1, 17, 20, 47, 10, 400, DateTimeKind.Local).AddTicks(7870), "slah_farwq@hotmail.com", "650.487.2806" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, 461, درنة, Gambia", "ملكال", new DateTime(2024, 1, 17, 15, 55, 30, 900, DateTimeKind.Local).AddTicks(9878), "jmanh43@hotmail.com", "1-517-437-2705 x75215" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, ش رسالت, 9220, الرويس, Cuba", "ازويرات", new DateTime(2024, 1, 16, 23, 1, 24, 594, DateTimeKind.Local).AddTicks(2137), "fatmh77@hotmail.com", "1-699-880-2388 x5574" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, ش فاطمی, 68, الأبيض, Cameroon", "الوجه", new DateTime(2024, 1, 17, 2, 15, 16, 181, DateTimeKind.Local).AddTicks(4149), "aadm11@yahoo.com", "1-889-523-4257 x052" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, دوار هویزه, 9, يي, Saint Kitts and Nevis", "المنامة", new DateTime(2024, 1, 17, 13, 6, 14, 52, DateTimeKind.Local).AddTicks(1306), "rbya_jabr16@yahoo.com", "1-666-786-9023" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, 957, عدن, Hong Kong", "ترهونة", new DateTime(2024, 1, 17, 6, 37, 36, 573, DateTimeKind.Local).AddTicks(8093), "asamh.jabr@yahoo.com", "1-289-299-1540 x8980" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, 933, جرجا, Solomon Islands", "الفاشر", new DateTime(2024, 1, 17, 12, 15, 2, 853, DateTimeKind.Local).AddTicks(1410), "fuad93@yahoo.com", "(233) 932-1804 x05820" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, شارع استاد قریب, 313, العريش, Slovakia (Slovak Republic)", "سلمية", new DateTime(2024, 1, 17, 18, 31, 40, 83, DateTimeKind.Local).AddTicks(4471), "arwa.aqyl@gmail.com", "803-804-9002" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, تقاطع واعظی, 0, عشرة رمضان, Turks and Caicos Islands", "أبو كبير", new DateTime(2024, 1, 17, 7, 53, 40, 664, DateTimeKind.Local).AddTicks(2451), "hsn34@hotmail.com", "(326) 252-3283" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, 50, دبا, Democratic People's Republic of Korea", "راس العين", new DateTime(2024, 1, 16, 23, 29, 59, 931, DateTimeKind.Local).AddTicks(7428), "amjd.tarq@gmail.com", "1-348-822-8868" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 6, درعا, Suriname", "الوادي", new DateTime(2024, 1, 17, 11, 24, 35, 194, DateTimeKind.Local).AddTicks(7837), "sarh.asamh43@hotmail.com", "(395) 788-9149" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, 93, القيصومة, Egypt", "السيب", new DateTime(2024, 1, 17, 1, 50, 16, 793, DateTimeKind.Local).AddTicks(768), "arwa52@hotmail.com", "(893) 503-3425 x54897" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اقبال لاهوری, تقاطع دکتر چمران, 58, دير القمر, Mauritius", "الرطبة", new DateTime(2024, 1, 17, 14, 7, 11, 26, DateTimeKind.Local).AddTicks(2785), "lma.farwq26@gmail.com", "1-784-735-3821 x1087" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 293, بالهو, Montenegro", "الثورة", new DateTime(2024, 1, 17, 15, 41, 17, 121, DateTimeKind.Local).AddTicks(387), "blal70@hotmail.com", "1-955-815-7465" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, دوار مالک اشتر, 6238, اليوسفية, India", "رندا", new DateTime(2024, 1, 17, 2, 43, 4, 708, DateTimeKind.Local).AddTicks(6158), "abyr_aarf@gmail.com", "736.533.0486 x29878" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 4780, الحسيمة, Egypt", "جرابلس", new DateTime(2024, 1, 17, 18, 53, 24, 682, DateTimeKind.Local).AddTicks(186), "abyr_marwf47@yahoo.com", "261.841.8811 x339" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, ميدان آذربایجان, 681, بنجرير, Northern Mariana Islands", "الحريق", new DateTime(2024, 1, 17, 17, 33, 11, 859, DateTimeKind.Local).AddTicks(2226), "mna_hashm57@yahoo.com", "(717) 827-2736" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, طريق دستغیب, 2, أخميم, Turkmenistan", "العلا", new DateTime(2024, 1, 17, 17, 25, 4, 259, DateTimeKind.Local).AddTicks(7732), "amjd_blal@yahoo.com", "1-759-440-1540 x425" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, 18, الميادين, Finland", "سبها", new DateTime(2024, 1, 17, 11, 36, 55, 860, DateTimeKind.Local).AddTicks(5153), "blal_araqy16@gmail.com", "(321) 579-6228 x9140" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, ميدان موحد دانش, 2, مدينة عيسى, Czech Republic", "بيشة", new DateTime(2024, 1, 17, 3, 24, 27, 653, DateTimeKind.Local).AddTicks(4182), "blal89@hotmail.com", "1-917-695-9447" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سباری, 5867, الأغواط, Niue", "السبت اولاد النمة", new DateTime(2024, 1, 17, 16, 24, 49, 109, DateTimeKind.Local).AddTicks(9895), "salm71@hotmail.com", "(794) 803-5108 x454" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 7570, طنجة, Bulgaria", "عفيف", new DateTime(2024, 1, 17, 6, 13, 31, 528, DateTimeKind.Local).AddTicks(6032), "abyr_aadm94@gmail.com", "945-423-4116 x30600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 02, سطات, Iraq", "صافيتا", new DateTime(2024, 1, 17, 14, 23, 42, 629, DateTimeKind.Local).AddTicks(7207), "asamh_farwq@yahoo.com", "1-550-938-7598" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, طريق آفریقا, 57, برشيد, Grenada", "خان شيخون", new DateTime(2024, 1, 17, 19, 52, 18, 321, DateTimeKind.Local).AddTicks(2138), "hajr53@gmail.com", "1-977-987-0259 x5685" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, طريق دیباجی, 63, بنى سويف, Dominican Republic", "أبو كمال", new DateTime(2024, 1, 16, 23, 33, 30, 861, DateTimeKind.Local).AddTicks(1525), "fuad_hashm62@hotmail.com", "381-593-0784" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, تقاطع آذربایجان, 8584, المطرية, Israel", "الحسيمة", new DateTime(2024, 1, 17, 15, 6, 49, 658, DateTimeKind.Local).AddTicks(8039), "slah22@yahoo.com", "(627) 684-9055" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 9, العيون, Bulgaria", "الشامية", new DateTime(2024, 1, 17, 2, 57, 6, 455, DateTimeKind.Local).AddTicks(7679), "shymaa68@gmail.com", "1-728-338-3171" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, ميدان دکتر چمران, 597, بسكرة, Belize", "دورا", new DateTime(2024, 1, 17, 20, 48, 12, 511, DateTimeKind.Local).AddTicks(8409), "hazm.fryd79@hotmail.com", "1-870-654-3588 x915" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, 3920, بريدة‏, Namibia", "طرطوس", new DateTime(2024, 1, 17, 12, 50, 36, 502, DateTimeKind.Local).AddTicks(9202), "shymaa24@gmail.com", "1-915-306-0177 x60776" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, 308, يريم, Djibouti", "القطيف", new DateTime(2024, 1, 17, 14, 36, 39, 931, DateTimeKind.Local).AddTicks(2434), "rna_slah@gmail.com", "404.556.2786 x4224" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, طريق واعظی, 65, تل رفعت, Oman", "مدينة الحرير", new DateTime(2024, 1, 16, 23, 19, 5, 965, DateTimeKind.Local).AddTicks(1564), "slah.rbya@gmail.com", "1-853-998-5232" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, طريق سمیه, 851, الحلة, Colombia", "الرياض", new DateTime(2024, 1, 17, 10, 36, 54, 299, DateTimeKind.Local).AddTicks(2836), "hajr.salm@yahoo.com", "383-789-2891 x77610" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, 4, حائل, Macao", "صوران", new DateTime(2024, 1, 17, 15, 28, 33, 710, DateTimeKind.Local).AddTicks(1627), "rbya.aarf@hotmail.com", "(402) 657-3848 x0125" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, ميدان استاد قریب, 6337, قصرين, Saudi Arabia", "طرطوس", new DateTime(2024, 1, 17, 7, 31, 20, 682, DateTimeKind.Local).AddTicks(3220), "blal_zyd76@gmail.com", "361.894.0261 x270" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, 8, البصرة, Sao Tome and Principe", "جبلة", new DateTime(2024, 1, 17, 15, 43, 0, 134, DateTimeKind.Local).AddTicks(8857), "fryd_jabr@yahoo.com", "258.265.0857 x51110" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, دوار آفریقا, 3803, بريدة‏, New Caledonia", "ازرع", new DateTime(2024, 1, 17, 5, 41, 49, 773, DateTimeKind.Local).AddTicks(3973), "salm.sayd@gmail.com", "936-877-0614 x67664" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, طريق راستوان, 2035, مصيرة, Switzerland", "عدل بكرو", new DateTime(2024, 1, 17, 10, 9, 13, 40, DateTimeKind.Local).AddTicks(9488), "blal77@gmail.com", "1-357-552-7455 x25921" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, تقاطع سمیه, 24, أسوان, Sierra Leone", "البيرة", new DateTime(2024, 1, 17, 6, 28, 55, 172, DateTimeKind.Local).AddTicks(2181), "sarh13@gmail.com", "572.939.5744 x54547" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, ميدان واعظی, 4291, طرابلس, Namibia", "سترة", new DateTime(2024, 1, 17, 5, 8, 7, 698, DateTimeKind.Local).AddTicks(1703), "lma38@hotmail.com", "851-280-5090 x15956" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, ميدان سمیه, 8, جت, Hong Kong", "فيفاء", new DateTime(2024, 1, 17, 6, 44, 11, 494, DateTimeKind.Local).AddTicks(8990), "hajr37@gmail.com", "1-225-286-5322 x37849" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, طريق واعظی, 2711, الغردقة, Antarctica (the territory South of 60 deg S)", "جسر الشغور", new DateTime(2024, 1, 17, 6, 9, 41, 26, DateTimeKind.Local).AddTicks(8339), "aayh.slah9@hotmail.com", "314.246.9428" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سباری, طريق امیرکبیر, 5, جيجل, Gabon", "غزة", new DateTime(2024, 1, 17, 7, 34, 43, 577, DateTimeKind.Local).AddTicks(2291), "abyr87@gmail.com", "(945) 887-3620" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, دوار امیرکبیر, 599, عين البيضاء, United Arab Emirates", "كفر قاسم", new DateTime(2024, 1, 17, 12, 27, 8, 381, DateTimeKind.Local).AddTicks(3024), "mna_blal@gmail.com", "1-529-703-2243" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, شارع مالک اشتر, 12, غريان, Malawi", "مسيعيد", new DateTime(2024, 1, 17, 22, 22, 29, 144, DateTimeKind.Local).AddTicks(2984), "zynb_rbya@yahoo.com", "(869) 845-2764" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, تقاطع دیباجی, 9156, القطيف, Latvia", "نجران", new DateTime(2024, 1, 17, 8, 9, 16, 268, DateTimeKind.Local).AddTicks(3909), "sayd50@gmail.com", "249-248-9858" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, 1, صلالة, Chile", "دير عطية", new DateTime(2024, 1, 17, 6, 52, 29, 469, DateTimeKind.Local).AddTicks(241), "sayd24@yahoo.com", "245.802.6903 x33446" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 76, شلالة العذاورة, Palau", "جونية", new DateTime(2024, 1, 17, 5, 58, 19, 843, DateTimeKind.Local).AddTicks(5849), "sarh_hsn@gmail.com", "574-594-1716" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, دوار فاطمی, 5551, صحم, Syrian Arab Republic", "حجة", new DateTime(2024, 1, 17, 12, 43, 23, 924, DateTimeKind.Local).AddTicks(7783), "tarq.zyd@yahoo.com", "1-826-587-5501" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, تقاطع دکتر چمران, 119, ميت غمر, Vietnam", "الدامر", new DateTime(2024, 1, 17, 9, 41, 15, 78, DateTimeKind.Local).AddTicks(9250), "aadm41@hotmail.com", "202-387-9418" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 687, ثادق, Swaziland", "مدحاء", new DateTime(2024, 1, 17, 11, 21, 1, 24, DateTimeKind.Local).AddTicks(7444), "iynas53@yahoo.com", "(295) 712-6937" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, طريق امیرکبیر, 67, مصراتة, United States Minor Outlying Islands", "إب", new DateTime(2024, 1, 17, 19, 48, 18, 435, DateTimeKind.Local).AddTicks(4803), "rqyh_salm@hotmail.com", "797.926.3732" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, ميدان اجاره دار, 5, خان يونس, Syrian Arab Republic", "الفحيص", new DateTime(2024, 1, 17, 3, 54, 50, 606, DateTimeKind.Local).AddTicks(9463), "iynas.jabr50@gmail.com", "1-367-789-2586 x0010" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, 79, سمائل, Oman", "الإسماعيلية", new DateTime(2024, 1, 17, 12, 18, 37, 875, DateTimeKind.Local).AddTicks(1314), "aayh.salm7@hotmail.com", "806-338-7332 x6232" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, طريق هویزه, 670, سلفيت, Netherlands Antilles", "أوبوك", new DateTime(2024, 1, 17, 11, 4, 28, 309, DateTimeKind.Local).AddTicks(5251), "fuad.fryd@hotmail.com", "1-973-732-0636 x24482" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 419, بنجرير, Democratic People's Republic of Korea", "القائم", new DateTime(2024, 1, 17, 13, 5, 49, 908, DateTimeKind.Local).AddTicks(413), "aadm_blal@gmail.com", "619-577-8744 x15160" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, 626, دبى, Jersey", "بن عروس", new DateTime(2024, 1, 17, 18, 54, 59, 130, DateTimeKind.Local).AddTicks(3924), "hajr2@hotmail.com", "1-533-296-8508 x3502" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, دوار کارگر شمالی, 8, المنطقة الخضراء, Saint Helena", "الرميلة", new DateTime(2024, 1, 17, 3, 30, 14, 168, DateTimeKind.Local).AddTicks(4945), "hazm.aarf67@hotmail.com", "830.949.3360" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, 61, سوهاج, Cote d'Ivoire", "المحلة الكبرى", new DateTime(2024, 1, 17, 4, 37, 4, 322, DateTimeKind.Local).AddTicks(7950), "lma0@gmail.com", "647.223.3150" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, 172, رام الله, Belgium", "ابراء", new DateTime(2024, 1, 17, 13, 3, 15, 249, DateTimeKind.Local).AddTicks(2553), "fryd_aadm@gmail.com", "(807) 323-4432" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, 15, الناصرة, Pitcairn Islands", "مرسى مطروح", new DateTime(2024, 1, 17, 1, 13, 57, 910, DateTimeKind.Local).AddTicks(5919), "amjd88@hotmail.com", "1-346-911-6642" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, ميدان دیباجی, 2, باتنة, Canada", "السويداء", new DateTime(2024, 1, 17, 17, 3, 28, 112, DateTimeKind.Local).AddTicks(2590), "jabr.sayd56@gmail.com", "(796) 229-9375 x070" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, دوار اجاره دار, 790, شمسطار, Poland", "مصراتة", new DateTime(2024, 1, 17, 21, 55, 29, 364, DateTimeKind.Local).AddTicks(3116), "arwa_tarq90@gmail.com", "791.911.1662 x78714" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, طريق فاطمی, 6, أم درمان, Gibraltar", "جدة", new DateTime(2024, 1, 17, 22, 35, 35, 73, DateTimeKind.Local).AddTicks(348), "aayh_hashm31@gmail.com", "(755) 389-8402 x996" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, 8278, القبة, Greenland", "القدس", new DateTime(2024, 1, 17, 13, 26, 22, 270, DateTimeKind.Local).AddTicks(8353), "farwq79@yahoo.com", "320.530.8813 x3535" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, دوار شهید مطهری, 9560, بلد, Brazil", "أوبوك", new DateTime(2024, 1, 17, 21, 14, 3, 39, DateTimeKind.Local).AddTicks(5094), "fryd90@gmail.com", "419.513.7179" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, ش دستغیب, 9, مسعد, Vietnam", "بنت جبيل", new DateTime(2024, 1, 17, 16, 11, 32, 762, DateTimeKind.Local).AddTicks(5224), "amjd68@gmail.com", "545.687.1377 x2501" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, تقاطع سمیه, 6210, الفحيحيل, Cook Islands", "السويداء", new DateTime(2024, 1, 16, 23, 14, 3, 110, DateTimeKind.Local).AddTicks(8889), "hsn.asamh@gmail.com", "1-820-457-4258" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, 7129, النبطية, Syrian Arab Republic", "السيب", new DateTime(2024, 1, 17, 8, 1, 58, 276, DateTimeKind.Local).AddTicks(3897), "shymaa30@hotmail.com", "(420) 232-3135" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, تقاطع آفریقا, 042, نابلس, Kyrgyz Republic", "البغدادي", new DateTime(2024, 1, 17, 4, 20, 56, 880, DateTimeKind.Local).AddTicks(2224), "fatmh_aqyl@gmail.com", "560-939-3809" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, 560, الرستاق, Kenya", "الطريف", new DateTime(2024, 1, 17, 0, 12, 12, 804, DateTimeKind.Local).AddTicks(9604), "fatmh71@yahoo.com", "698.868.6698 x889" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, 83, الرمادي, Guernsey", "بنزرت", new DateTime(2024, 1, 17, 19, 43, 47, 489, DateTimeKind.Local).AddTicks(7325), "salm.azyz37@gmail.com", "501.445.5872 x42957" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 45, الخرطوم, Gibraltar", "كسماوي", new DateTime(2024, 1, 17, 21, 5, 22, 897, DateTimeKind.Local).AddTicks(2327), "fryd_azyz18@gmail.com", "379-203-1043 x02194" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سباری, 24, قرية سار, Malaysia", "المسيلة", new DateTime(2024, 1, 17, 19, 32, 14, 3, DateTimeKind.Local).AddTicks(2102), "jabr63@hotmail.com", "621-697-0311" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, طريق رسالت, 9600, القيروان, Uruguay", "الديوانية", new DateTime(2024, 1, 17, 16, 58, 4, 45, DateTimeKind.Local).AddTicks(2565), "rym53@yahoo.com", "865-818-1975 x9643" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, طريق اقبال لاهوری, 8, البديع, Austria", "بريكة", new DateTime(2024, 1, 17, 4, 48, 34, 966, DateTimeKind.Local).AddTicks(8439), "asamh.jabr40@hotmail.com", "965-488-1025 x954" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 6756, إدفو, Montserrat", "غريان", new DateTime(2024, 1, 17, 4, 57, 37, 447, DateTimeKind.Local).AddTicks(7495), "iynas8@gmail.com", "1-980-889-7247 x749" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, شارع سمیه, 77, رداع, Ecuador", "الجوف", new DateTime(2024, 1, 17, 15, 39, 30, 89, DateTimeKind.Local).AddTicks(3258), "blal_tarq@yahoo.com", "797.977.7519 x2284" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, طريق سمیه, 2642, الخبر, Morocco", "العزيزية", new DateTime(2024, 1, 17, 14, 1, 1, 152, DateTimeKind.Local).AddTicks(5235), "shymaa91@gmail.com", "(215) 408-8580 x186" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 686, الوادي, Zimbabwe", "الرستاق", new DateTime(2024, 1, 17, 13, 55, 11, 993, DateTimeKind.Local).AddTicks(2252), "aadm_hashm@hotmail.com", "370-956-7769" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, تقاطع اقبال لاهوری, 6594, جاردو, Colombia", "الرطبة", new DateTime(2024, 1, 17, 12, 59, 23, 643, DateTimeKind.Local).AddTicks(4263), "farwq41@yahoo.com", "651-578-4167 x555" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 962, عين العرب, Palestinian Territory", "أسيلا", new DateTime(2024, 1, 17, 22, 52, 37, 775, DateTimeKind.Local).AddTicks(8155), "sarh30@gmail.com", "1-431-828-1222 x225" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, ش سباری, 6, المزاحمية, Martinique", "عبري", new DateTime(2024, 1, 17, 15, 34, 36, 120, DateTimeKind.Local).AddTicks(6199), "aayh63@yahoo.com", "645-291-5064 x04774" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, 139, أبو ظبي, Ethiopia", "أربيل", new DateTime(2024, 1, 17, 17, 16, 53, 2, DateTimeKind.Local).AddTicks(4343), "abyr_iyhab@yahoo.com", "(521) 246-8171" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, طريق دیباجی, 23, المقدادية, Macao", "رفحا", new DateTime(2024, 1, 17, 19, 10, 50, 707, DateTimeKind.Local).AddTicks(8643), "fatmh_rbya@gmail.com", "1-568-728-3600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, تقاطع کارگر شمالی, 7, عجلون, Heard Island and McDonald Islands", "بلد", new DateTime(2024, 1, 17, 16, 33, 16, 332, DateTimeKind.Local).AddTicks(2272), "fryd56@hotmail.com", "492.837.7565" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, 72, بيت لحم, Colombia", "العقبة", new DateTime(2024, 1, 17, 4, 42, 20, 70, DateTimeKind.Local).AddTicks(5788), "slah15@hotmail.com", "671.281.1562" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, ش دماوند, 3177, هيت, Montserrat", "نابلس", new DateTime(2024, 1, 17, 19, 44, 8, 581, DateTimeKind.Local).AddTicks(4946), "dana6@hotmail.com", "270.853.1396 x8677" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, شارع دکتر چمران, 144, جسر الشغور, Mali", "اوبيو", new DateTime(2024, 1, 17, 7, 20, 46, 27, DateTimeKind.Local).AddTicks(6485), "blal_marwf31@hotmail.com", "892.678.2903" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, دوار امیرکبیر, 97, الديوانية, Gambia", "خنيفرة", new DateTime(2024, 1, 17, 7, 42, 12, 42, DateTimeKind.Local).AddTicks(8620), "fatmh6@hotmail.com", "325.444.2693" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, 549, السيب, Mauritius", "الرطبة", new DateTime(2024, 1, 17, 7, 42, 38, 281, DateTimeKind.Local).AddTicks(540), "fatmh_asar14@hotmail.com", "(920) 535-5660" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, 73, دبى, Philippines", "بيت الفقيه", new DateTime(2024, 1, 17, 7, 11, 27, 42, DateTimeKind.Local).AddTicks(388), "zyd_asar@hotmail.com", "1-517-704-1072" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, شارع قدس, 855, الجفر, Belarus", "طولكرم", new DateTime(2024, 1, 17, 17, 34, 27, 300, DateTimeKind.Local).AddTicks(1696), "sarh.azyz@yahoo.com", "1-554-567-9948 x60469" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, شارع موحد دانش, 2, ثادق, Falkland Islands (Malvinas)", "الدوحة", new DateTime(2024, 1, 17, 10, 41, 2, 356, DateTimeKind.Local).AddTicks(404), "sayd_aqyl73@gmail.com", "1-364-788-2422" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, 3129, ثقبة, Palau", "تلكلخ", new DateTime(2024, 1, 17, 0, 33, 15, 317, DateTimeKind.Local).AddTicks(616), "shymaa_azyz@yahoo.com", "376-910-3051" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق رسالت, ش یادگار امام, 345, الرويس, Sweden", "بوكى", new DateTime(2024, 1, 17, 10, 7, 10, 528, DateTimeKind.Local).AddTicks(5036), "slah19@yahoo.com", "1-750-655-1388 x1686" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 1811, مصراتة, Armenia", "سطات", new DateTime(2024, 1, 17, 5, 3, 54, 677, DateTimeKind.Local).AddTicks(9179), "sayd11@hotmail.com", "373.348.1303 x955" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, شارع اقبال لاهوری, 13, الليث, Eritrea", "ذمار", new DateTime(2024, 1, 17, 6, 58, 56, 468, DateTimeKind.Local).AddTicks(895), "asamh_salm6@hotmail.com", "838-386-8100 x7896" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 9, نزوى, Tajikistan", "الجفر", new DateTime(2024, 1, 17, 21, 41, 2, 242, DateTimeKind.Local).AddTicks(2126), "hajr_blal@hotmail.com", "364-476-9438 x42658" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, 4880, نابل, Guinea", "الوجه", new DateTime(2024, 1, 17, 22, 7, 43, 217, DateTimeKind.Local).AddTicks(1857), "fryd55@gmail.com", "1-619-947-7702 x6263" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 397, صلالة, Slovakia (Slovak Republic)", "برج بو عريريج", new DateTime(2024, 1, 17, 2, 57, 58, 961, DateTimeKind.Local).AddTicks(2165), "rqyh46@gmail.com", "338-855-2750" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, شارع سمیه, 919, الدوحة, Israel", "ملكال", new DateTime(2024, 1, 17, 5, 53, 41, 310, DateTimeKind.Local).AddTicks(2260), "aadm.araqy@gmail.com", "971.467.2091 x38157" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 299, خريبكة, Belize", "داريا", new DateTime(2024, 1, 17, 11, 33, 48, 761, DateTimeKind.Local).AddTicks(9886), "asamh.araqy@gmail.com", "1-325-576-7687 x190" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, 4761, ليوا, Holy See (Vatican City State)", "سنجة", new DateTime(2024, 1, 17, 14, 6, 38, 602, DateTimeKind.Local).AddTicks(1482), "hajr25@hotmail.com", "268-255-0243 x5594" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, طريق سمیه, 2, غريان, Montenegro", "المرج", new DateTime(2024, 1, 17, 2, 52, 28, 434, DateTimeKind.Local).AddTicks(3911), "mna_araqy@yahoo.com", "(478) 864-9711" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, دوار دیباجی, 305, القنفذة, United Arab Emirates", "تيماء", new DateTime(2024, 1, 17, 2, 58, 15, 510, DateTimeKind.Local).AddTicks(9685), "jmanh_hsn@hotmail.com", "1-317-273-8297 x30917" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, تقاطع اقبال لاهوری, 75, الليث, Lao People's Democratic Republic", "بغداد", new DateTime(2024, 1, 17, 20, 42, 55, 559, DateTimeKind.Local).AddTicks(8919), "shymaa_azyz@yahoo.com", "842.872.6385 x80122" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, 16, صلخد, Northern Mariana Islands", "دمشق", new DateTime(2024, 1, 17, 10, 34, 21, 963, DateTimeKind.Local).AddTicks(8241), "dana_aarf@yahoo.com", "768.567.3762" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, طريق آزادی, 295, القرداحة, Central African Republic", "السويق", new DateTime(2024, 1, 16, 23, 20, 50, 795, DateTimeKind.Local).AddTicks(5239), "zyd_fuad39@gmail.com", "419-386-4037 x18090" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, 0, الجزائر, Togo", "ذمار", new DateTime(2024, 1, 17, 16, 11, 8, 875, DateTimeKind.Local).AddTicks(8276), "rym14@yahoo.com", "1-315-355-1462 x1236" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, تقاطع ابوذر, 8145, سيهات, Saint Martin", "العضيلية", new DateTime(2024, 1, 17, 11, 17, 22, 494, DateTimeKind.Local).AddTicks(6404), "arwa_araqy10@gmail.com", "927-488-7538" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع استاد قریب, ميدان سباری, 3054, زبيد, Germany", "اكجوجت", new DateTime(2024, 1, 17, 13, 37, 25, 597, DateTimeKind.Local).AddTicks(6159), "lma_fuad22@hotmail.com", "467.812.9670 x1485" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, 9, الجوف, New Caledonia", "عطبرة", new DateTime(2024, 1, 17, 20, 26, 28, 255, DateTimeKind.Local).AddTicks(6530), "frydh.slah84@gmail.com", "1-911-273-9225" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, طريق موحد دانش, 13, سيلبابي, Republic of Korea", "خان شيخون", new DateTime(2024, 1, 17, 20, 32, 57, 393, DateTimeKind.Local).AddTicks(228), "mna.zyd@hotmail.com", "1-492-245-6330" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, شارع موحد دانش, 1420, القرداحة, Austria", "رأس تنورة", new DateTime(2024, 1, 17, 13, 50, 45, 132, DateTimeKind.Local).AddTicks(2481), "farwq_marwf80@hotmail.com", "(605) 299-7040 x6107" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, دوار آزادی, 4265, دمياط, South Georgia and the South Sandwich Islands", "النبطية", new DateTime(2024, 1, 17, 5, 14, 21, 5, DateTimeKind.Local).AddTicks(1393), "iynas36@hotmail.com", "884-350-6329" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, شارع شهید مطهری, 60, خور أنجار, Israel", "الرفاع الغربي", new DateTime(2024, 1, 17, 22, 9, 52, 310, DateTimeKind.Local).AddTicks(658), "hazm21@hotmail.com", "(495) 940-8776" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, طريق دیباجی, 60, ثادق, Tunisia", "مدينة الكويت", new DateTime(2024, 1, 17, 1, 58, 35, 978, DateTimeKind.Local).AddTicks(455), "zynb.araqy@hotmail.com", "834.219.4694 x0579" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, 723, جنين, Spain", "راس العين", new DateTime(2024, 1, 17, 17, 36, 17, 838, DateTimeKind.Local).AddTicks(706), "tarq51@yahoo.com", "311-557-2421" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, 6822, حائل, Canada", "النهود", new DateTime(2024, 1, 17, 12, 37, 49, 859, DateTimeKind.Local).AddTicks(9800), "arwa_marwf@yahoo.com", "1-658-827-1412" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, 888, تنومة, Romania", "القحطانية", new DateTime(2024, 1, 17, 3, 5, 40, 228, DateTimeKind.Local).AddTicks(4363), "shymaa_asar@hotmail.com", "257.556.4723 x74343" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, 7233, خور أنجار, Somalia", "لوك", new DateTime(2024, 1, 17, 18, 37, 41, 480, DateTimeKind.Local).AddTicks(9350), "dana_farwq57@hotmail.com", "694-681-6794 x4170" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, طريق موحد دانش, 1430, حلبجة, Martinique", "بغداد", new DateTime(2024, 1, 17, 20, 0, 45, 313, DateTimeKind.Local).AddTicks(527), "hsn_aashwr61@hotmail.com", "1-276-515-5010" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, 6, الخميسات, Peru", "حماة", new DateTime(2024, 1, 17, 7, 30, 29, 703, DateTimeKind.Local).AddTicks(435), "zynb.jabr@hotmail.com", "(286) 366-4874" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, 59, ليوا, Moldova", "بنزرت", new DateTime(2024, 1, 17, 5, 5, 34, 895, DateTimeKind.Local).AddTicks(4952), "blal_zyd44@hotmail.com", "275.400.4004 x167" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, 7, دير البلح, Kiribati", "السويداء", new DateTime(2024, 1, 17, 16, 53, 58, 290, DateTimeKind.Local).AddTicks(7074), "salm_fuad@gmail.com", "1-979-394-2959 x2406" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, دوار ابوذر, 5135, جيجل, Guernsey", "بجاية", new DateTime(2024, 1, 17, 0, 3, 30, 587, DateTimeKind.Local).AddTicks(3773), "aayh53@yahoo.com", "(372) 510-2241 x911" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, ميدان دیباجی, 1, طرابلس, Timor-Leste", "قليوب", new DateTime(2024, 1, 17, 22, 51, 51, 590, DateTimeKind.Local).AddTicks(1559), "fatmh_hazm@yahoo.com", "213-369-8632 x70726" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 12, 16, 7, 58, 8, 264, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 1, 17, 18, 12, 1, 54, DateTimeKind.Local).AddTicks(5253), "هاجر عقیل", "Maurine Johnson", "حسن - بلال", "5985754388186182036", "British Indian Ocean Territory (Chagos Archipelago)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 1, 25, 19, 44, 31, 414, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 1, 17, 17, 2, 8, 616, DateTimeKind.Local).AddTicks(8590), "أسامة صلاح", "Charles Swift", "صلاح - هاشم", "1359854063692730569", "Greenland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 1, 18, 0, 27, 26, 127, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 1, 17, 11, 51, 28, 655, DateTimeKind.Local).AddTicks(6925), "فاطمة سعيد", "Alfonzo Langosh", "حازم Inc", "3707863386276435061", "Guinea-Bissau" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 2, 22, 15, 37, 42, 144, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 1, 17, 16, 55, 30, 700, DateTimeKind.Local).AddTicks(1824), "ريم زيد", "Thea Nolan", 0, "بلال - سالم", "6419030982280666373", "Hungary", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 7, 26, 17, 7, 9, 604, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 1, 17, 13, 40, 14, 0, DateTimeKind.Local).AddTicks(9677), "حازم زيد", "Kyra Goldner", "جابر‌, بلال and ربيع", "956050596043819028", "Bouvet Island (Bouvetoya)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 8, 10, 13, 4, 29, 711, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 1, 17, 15, 12, 40, 278, DateTimeKind.Local).AddTicks(8434), "فاطمة حسن", "Evalyn Witting", "طارق, طارق and عارف", "1610058304136315229", "Cuba", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 8, 30, 8, 17, 53, 717, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 1, 17, 16, 8, 28, 870, DateTimeKind.Local).AddTicks(9660), "أسامة طارق", "Betsy Veum", 1, "عاشور - عصار", "1525452084708244109", "Argentina", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 7, 11, 1, 30, 45, 65, DateTimeKind.Local).AddTicks(7864), new DateTime(2024, 1, 17, 10, 33, 24, 20, DateTimeKind.Local).AddTicks(6664), "فريد أمجد", "Joshua Schinner", 0, "فؤاد, ربيع and هاشم", "2147631745784710774", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 10, 17, 20, 47, 754, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 1, 17, 16, 21, 7, 838, DateTimeKind.Local).AddTicks(7026), "سارة عراقی", "Tanya Gorczany", "زيد - بلال", "3721770933432684278", "Philippines", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 8, 1, 5, 31, 52, 789, DateTimeKind.Local).AddTicks(9389), new DateTime(2024, 1, 17, 19, 17, 25, 623, DateTimeKind.Local).AddTicks(5866), "إيهاب فاروق", "Kira Towne", 0, "هاشم, زيد and صلاح", "565123317574309494", "Panama" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 10, 6, 22, 37, 48, 584, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 1, 17, 20, 55, 18, 728, DateTimeKind.Local).AddTicks(6079), "ريم جابر‌", "Lavada Glover", 0, "جابر‌, أسامة and صلاح", "8733429393573979396", "Costa Rica" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 12, 28, 13, 44, 58, 993, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 1, 17, 21, 55, 6, 321, DateTimeKind.Local).AddTicks(566), "Tina Wunsch", "فريد Inc", "9036999857793170422", "Tanzania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1963, 9, 26, 5, 25, 36, 148, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 1, 17, 13, 34, 34, 758, DateTimeKind.Local).AddTicks(4076), "شيماء هاشم", "Bethel Koch", "صلاح - أسامة", "100343125027572781", "Kyrgyz Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 4, 13, 23, 17, 4, 817, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 1, 17, 19, 3, 32, 278, DateTimeKind.Local).AddTicks(9065), "فريد سعيد", "Kristin Kautzer", "حازم, صلاح and معروف", "5927791240000874181", "Ecuador", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 1, 16, 20, 5, 57, 458, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 1, 17, 22, 29, 6, 161, DateTimeKind.Local).AddTicks(5809), "حازم عراقی", "Penelope Reilly", "فؤاد, عراقی and آدم", "6404058997613676576", "Saint Helena", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 11, 15, 14, 37, 15, 950, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 1, 17, 21, 40, 44, 991, DateTimeKind.Local).AddTicks(1568), "إيهاب معروف", "Clifford Huel", 0, "عقیل - جابر‌", "5213733810326612330", "Latvia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 11, 8, 19, 48, 33, 325, DateTimeKind.Local).AddTicks(7889), new DateTime(2024, 1, 17, 17, 40, 28, 390, DateTimeKind.Local).AddTicks(1934), "حسن عراقی", "Fanny Grady", 1, "عصار Group", "4225649035166855077", "Yemen", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 10, 10, 19, 38, 5, 615, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 1, 17, 9, 7, 21, 43, DateTimeKind.Local).AddTicks(4411), "لمى معروف", "Donald Osinski", 1, "عاشور Group", "2529575193526000451", "Greece", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 12, 24, 6, 48, 12, 730, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 1, 17, 5, 2, 54, 679, DateTimeKind.Local).AddTicks(2907), "فؤاد بلال", "Amie Kub", "زيد - بلال", "853642300746668195", "Turks and Caicos Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 3, 21, 15, 2, 47, 638, DateTimeKind.Local).AddTicks(591), new DateTime(2024, 1, 17, 6, 7, 42, 266, DateTimeKind.Local).AddTicks(8337), "أسامة آدم", "Louie Vandervort", 0, "طارق - عزیز", "9109051123747753651", "French Polynesia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 6, 28, 8, 29, 16, 214, DateTimeKind.Local).AddTicks(3132), new DateTime(2024, 1, 17, 3, 38, 48, 172, DateTimeKind.Local).AddTicks(4987), "فريد سالم", "Libby MacGyver", "ربيع Group", "4296512997878825398", "Congo", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 5, 8, 1, 46, 30, 296, DateTimeKind.Local).AddTicks(1773), new DateTime(2024, 1, 17, 19, 5, 12, 278, DateTimeKind.Local).AddTicks(3035), "زينب آدم", "Lilian Harris", 0, "زيد - حازم", "9077842100602356484", "Montenegro", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 4, 2, 9, 26, 23, 287, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 1, 17, 5, 28, 11, 867, DateTimeKind.Local).AddTicks(2983), "دانا إيهاب", "Nadia Rau", 1, "معروف - سعيد", "5491462134809439198", "Uzbekistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 22, 21, 29, 27, 574, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 1, 17, 21, 58, 20, 541, DateTimeKind.Local).AddTicks(7074), "ربيع ربيع", "Fred Ryan", 0, "عارف, حسن and فؤاد", "5457829582835893394", "Isle of Man", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 1, 28, 14, 47, 21, 555, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 1, 17, 14, 44, 15, 693, DateTimeKind.Local).AddTicks(5500), "فؤاد حسن", "Abdiel Hauck", 0, "آدم - فاروق", "1520048838586609610", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 8, 21, 8, 27, 17, 845, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 1, 17, 21, 4, 16, 221, DateTimeKind.Local).AddTicks(9508), "رقية عقیل", "Oma O'Hara", "عزیز - سالم", "3847181504556897642", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 8, 14, 14, 40, 54, 754, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 1, 17, 2, 51, 9, 116, DateTimeKind.Local).AddTicks(3080), "صلاح عاشور", "Joyce Zemlak", "معروف Group", "650046530000106408", "Armenia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 2, 15, 16, 8, 15, 780, DateTimeKind.Local).AddTicks(6382), new DateTime(2024, 1, 17, 3, 51, 19, 702, DateTimeKind.Local).AddTicks(6175), "جابر‌ عراقی", "Diego Flatley", "عقیل LLC", "2946782872589065289", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 6, 8, 11, 39, 45, 390, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 1, 17, 6, 33, 30, 303, DateTimeKind.Local).AddTicks(5025), "إيهاب عزیز", "Giovanni Littel", "أمجد Inc", "1488582529523134531", "Japan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 5, 16, 18, 16, 21, 275, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 1, 17, 22, 48, 31, 755, DateTimeKind.Local).AddTicks(8038), "آدم عقیل", "Carmine Nader", "عقیل - جابر‌", "9198860600748706478", "Yemen", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 22, 8, 51, 19, 92, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 1, 17, 9, 49, 35, 912, DateTimeKind.Local).AddTicks(5040), "آية هاشم", "Luisa Luettgen", "فريد LLC", "5947245147914632761", "Egypt", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 7, 31, 2, 11, 55, 4, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 1, 17, 21, 15, 3, 401, DateTimeKind.Local).AddTicks(9444), "إيناس بلال", "Gerald Schaden", "آدم - عزیز", "5125450155578364976", "Grenada", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 6, 22, 20, 36, 9, 749, DateTimeKind.Local).AddTicks(7941), new DateTime(2024, 1, 17, 3, 17, 57, 431, DateTimeKind.Local).AddTicks(9864), "أسامة زيد", "Valentina Schroeder", 0, "عاشور Inc", "4192390815266274591", "Aruba", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 2, 14, 16, 1, 31, 110, DateTimeKind.Local).AddTicks(256), new DateTime(2024, 1, 17, 17, 3, 27, 713, DateTimeKind.Local).AddTicks(6674), "طارق زيد", "Alek VonRueden", "زيد, بلال and أمجد", "1255834386920382260", "South Georgia and the South Sandwich Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2001, 7, 21, 4, 33, 23, 703, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 1, 16, 23, 54, 45, 884, DateTimeKind.Local).AddTicks(6229), "رنا فاروق", "Nat Brown", 1, "سعيد LLC", "4347284642027653151", "Nicaragua" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 2, 13, 11, 4, 32, 188, DateTimeKind.Local).AddTicks(7574), new DateTime(2024, 1, 16, 23, 21, 53, 990, DateTimeKind.Local).AddTicks(986), "آية صلاح", "Jensen Jerde", "حازم Group", "8822876109346794896", "Anguilla", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 12, 5, 54, 50, 228, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 1, 17, 5, 44, 11, 203, DateTimeKind.Local).AddTicks(2650), "رنا هاشم", "Alvis Kuhic", "فاروق Group", "605187918639000460", "Andorra", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 7, 11, 9, 53, 764, DateTimeKind.Local).AddTicks(2467), new DateTime(2024, 1, 17, 13, 19, 39, 629, DateTimeKind.Local).AddTicks(5037), "ريم زيد", "Bridgette Heathcote", "عقیل - فريد", "3864226403197079140", "Saint Barthelemy", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 9, 19, 15, 40, 49, 259, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 1, 17, 18, 25, 8, 989, DateTimeKind.Local).AddTicks(1503), "طارق عقیل", "Clarabelle O'Hara", 1, "حسن LLC", "7795325310601891136", "Virgin Islands, U.S." });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 12, 26, 8, 35, 33, 290, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 1, 17, 7, 18, 52, 178, DateTimeKind.Local).AddTicks(9845), "زيد عارف", "Eileen Ernser", "ربيع - سعيد", "5915231400364081660", "Australia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 1, 8, 10, 47, 9, 155, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 1, 17, 12, 5, 38, 407, DateTimeKind.Local).AddTicks(5057), "سارة زيد", "Jessika Beer", "عراقی - سعيد", "7407869950602189249", "United Arab Emirates", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 9, 27, 0, 53, 59, 338, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 1, 17, 11, 6, 34, 559, DateTimeKind.Local).AddTicks(1439), "سالم فؤاد", "Garland Wiegand", "جابر‌, عقیل and ربيع", "7295696783627940253", "Benin", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 8, 11, 23, 0, 57, 927, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 1, 17, 22, 15, 59, 899, DateTimeKind.Local).AddTicks(1631), "بلال فريد", "Yadira Littel", "عاشور, إيهاب and معروف", "8998493104145037350", "Tajikistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 5, 12, 19, 9, 30, 881, DateTimeKind.Local).AddTicks(3622), new DateTime(2024, 1, 17, 2, 40, 3, 900, DateTimeKind.Local).AddTicks(4067), "إيهاب حسن", "Graham Moore", 1, "عقیل Group", "5456588080719812736", "Pakistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 4, 16, 23, 20, 5, 302, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 1, 17, 21, 17, 36, 678, DateTimeKind.Local).AddTicks(2256), "فاروق سالم", "Lizzie Moore", 0, "حسن, عاشور and حسن", "976271009197089210", "Equatorial Guinea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1981, 9, 21, 15, 52, 56, 57, DateTimeKind.Local).AddTicks(2305), new DateTime(2024, 1, 17, 4, 34, 31, 67, DateTimeKind.Local).AddTicks(9834), "عبير جابر‌", "Aimee Morissette", "عصار, سعيد and فاروق", "798910865445837931", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 9, 29, 22, 23, 25, 140, DateTimeKind.Local).AddTicks(3339), new DateTime(2024, 1, 17, 21, 51, 32, 494, DateTimeKind.Local).AddTicks(6766), "آية زيد", "Mossie Klocko", "طارق Group", "8606847716985146632", "Svalbard & Jan Mayen Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 4, 12, 4, 50, 7, 370, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 1, 17, 9, 50, 2, 836, DateTimeKind.Local).AddTicks(8250), "زينب عارف", "Tate Connelly", 1, "جابر‌, صلاح and حازم", "3635847533840505810", "Andorra", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 5, 21, 6, 58, 50, 313, DateTimeKind.Local).AddTicks(9862), new DateTime(2024, 1, 16, 23, 2, 15, 308, DateTimeKind.Local).AddTicks(4522), "طارق آدم", "Nannie Kutch", "معروف Inc", "7115328165567525376", "French Guiana", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(2003, 3, 26, 8, 10, 5, 709, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 1, 17, 15, 58, 55, 215, DateTimeKind.Local).AddTicks(5662), "سالم عاشور", "Jovany Lang", 0, "جابر‌, فريد and سالم", "1634665475813179485", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 10, 9, 23, 5, 53, 969, DateTimeKind.Local).AddTicks(7123), new DateTime(2024, 1, 17, 18, 27, 32, 298, DateTimeKind.Local).AddTicks(4166), "إيناس فؤاد", "Elias VonRueden", 1, "آدم and Sons", "3265263549930565965", "South Georgia and the South Sandwich Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 11, 9, 45, 27, 214, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 1, 17, 20, 49, 18, 91, DateTimeKind.Local).AddTicks(3885), "جابر‌ عارف", "Ulices Padberg", 0, "حازم, عارف and إيهاب", "4789504200097963347", "Greenland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 7, 20, 2, 19, 47, 944, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 1, 17, 22, 52, 36, 870, DateTimeKind.Local).AddTicks(3257), "دانا ربيع", "Madelynn Bode", "آدم, أمجد and حسن", "2651123957967331543", "Western Sahara", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 2, 2, 11, 38, 45, 714, DateTimeKind.Local).AddTicks(9854), new DateTime(2024, 1, 17, 2, 19, 0, 914, DateTimeKind.Local).AddTicks(9407), "أسامة بلال", "Adelia Waters", 1, "عقیل - صلاح", "6804464633379144576", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 1, 26, 13, 57, 7, 366, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 1, 17, 19, 53, 24, 198, DateTimeKind.Local).AddTicks(5294), "آية جابر‌", "Rhianna Kozey", "عراقی Inc", "2242428554710524039", "Palestinian Territory", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 23, 21, 21, 33, 305, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 1, 17, 14, 5, 1, 598, DateTimeKind.Local).AddTicks(4100), "أسامة هاشم", "Rebekah Friesen", "فريد - حازم", "3104451137735283201", "Puerto Rico", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 9, 11, 6, 3, 4, 937, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 1, 17, 1, 52, 29, 398, DateTimeKind.Local).AddTicks(4429), "إيناس فاروق", "Nicole Hartmann", "فؤاد - آدم", "6812712187653446266", "Cayman Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 6, 8, 6, 3, 19, 738, DateTimeKind.Local).AddTicks(4532), new DateTime(2024, 1, 17, 14, 19, 43, 56, DateTimeKind.Local).AddTicks(1928), "جمانة زيد", "Maryse Bailey", 0, "بلال - معروف", "6175855109095109764", "Argentina", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 5, 30, 12, 21, 21, 489, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 1, 17, 10, 36, 32, 282, DateTimeKind.Local).AddTicks(1388), "آية هاشم", "Elta Welch", 1, "آدم, معروف and عقیل", "433945013921156185", "Thailand", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 14, 4, 41, 25, 63, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 1, 17, 15, 53, 24, 831, DateTimeKind.Local).AddTicks(8392), "فريد عاشور", "Carlo Brakus", 0, "أسامة and Sons", "1145164059507785022", "Belgium", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 9, 26, 4, 31, 13, 149, DateTimeKind.Local).AddTicks(6581), new DateTime(2024, 1, 17, 6, 37, 12, 217, DateTimeKind.Local).AddTicks(4292), "أمجد جابر‌", "Lillian Feeney", "أمجد Group", "7818220763041322475", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 3, 10, 8, 50, 49, 747, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 1, 17, 6, 13, 13, 688, DateTimeKind.Local).AddTicks(1836), "فؤاد عراقی", "Alanna Smitham", 1, "فريد - آدم", "1555685843087342225", "South Africa", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 12, 30, 2, 59, 29, 496, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 1, 17, 21, 34, 14, 764, DateTimeKind.Local).AddTicks(9902), "أمجد أسامة", "Kendrick Kshlerin", "حازم - أمجد", "587625963796559328", "Nepal", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1967, 11, 20, 5, 29, 30, 105, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 1, 17, 10, 5, 30, 614, DateTimeKind.Local).AddTicks(3923), "ربيع إيهاب", "Dominic Baumbach", 1, "معروف - آدم", "8452280895024770479", "Holy See (Vatican City State)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1987, 7, 2, 11, 16, 35, 47, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 1, 17, 5, 23, 48, 953, DateTimeKind.Local).AddTicks(3505), "آية فؤاد", "Gerhard Legros", "عزیز - عصار", "7458076060865852059", "Bouvet Island (Bouvetoya)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 3, 0, 30, 34, 448, DateTimeKind.Local).AddTicks(7286), new DateTime(2024, 1, 17, 13, 34, 23, 682, DateTimeKind.Local).AddTicks(2310), "إيهاب حازم", "Edgardo Carroll", 0, "عارف, عصار and هاشم", "2975948688025136807", "Ireland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 12, 18, 19, 29, 56, 405, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 1, 17, 13, 20, 18, 150, DateTimeKind.Local).AddTicks(9204), "إيناس سعيد", "Adelia Bogisich", "عقیل Inc", "6055722712938551253", "Gambia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 9, 19, 19, 19, 39, 922, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 1, 17, 18, 38, 27, 403, DateTimeKind.Local).AddTicks(6947), "صلاح سعيد", "Joe Sauer", 0, "عقیل Inc", "4378662712682187689", "Bolivia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 10, 2, 21, 55, 15, 50, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 1, 17, 6, 6, 14, 963, DateTimeKind.Local).AddTicks(3123), "سعيد حازم", "Kaycee Hegmann", 1, "طارق, بلال and صلاح", "7036300357123085506", "Cote d'Ivoire", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 1, 31, 12, 54, 53, 212, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 1, 17, 11, 11, 55, 953, DateTimeKind.Local).AddTicks(5945), "آدم فاروق", "Betty Hirthe", "أمجد and Sons", "5087678090117310453", "United Kingdom", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 1, 7, 9, 10, 59, 156, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 1, 17, 21, 52, 7, 927, DateTimeKind.Local).AddTicks(8044), "طارق عراقی", "Clement Brown", "سالم Group", "8048026574024551403", "Jersey", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 1, 17, 11, 14, 27, 555, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 1, 17, 11, 26, 24, 555, DateTimeKind.Local).AddTicks(6981), "منى بلال", "Bethany Price", "بلال, أمجد and إيهاب", "7549033000861236981", "Luxembourg", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 28, 7, 12, 21, 870, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 1, 17, 1, 55, 26, 748, DateTimeKind.Local).AddTicks(7583), "جابر‌ حسن", "Rhoda Kutch", "فريد Inc", "477012155487583255", "Germany", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 1, 25, 1, 9, 45, 214, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 1, 17, 22, 55, 1, 517, DateTimeKind.Local).AddTicks(2273), "فاطمة طارق", "Janick Moen", 0, "فريد Group", "5485634915901810170", "Mongolia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 20, 3, 24, 28, 524, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 1, 17, 12, 31, 44, 205, DateTimeKind.Local).AddTicks(429), "سعيد سالم", "Michale Roob", 1, "إيهاب - عراقی", "3346949831821035142", "Nauru", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 9, 8, 1, 4, 0, 11, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 1, 17, 1, 1, 53, 15, DateTimeKind.Local).AddTicks(5730), "عبير عاشور", "Trenton Greenholt", "عزیز - فاروق", "8612182209936466858", "Antigua and Barbuda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 9, 24, 18, 43, 30, 558, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 1, 17, 1, 25, 14, 535, DateTimeKind.Local).AddTicks(3421), "إيناس سعيد", "Brannon Bernhard", "زيد Inc", "5415825262688214593", "China", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 9, 28, 9, 33, 26, 908, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 1, 17, 7, 37, 58, 516, DateTimeKind.Local).AddTicks(9042), "جابر‌ فؤاد", "Jesse Senger", 0, "إيهاب and Sons", "8148142477934457317", "Bolivia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1985, 12, 25, 0, 44, 52, 308, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 1, 17, 16, 9, 59, 340, DateTimeKind.Local).AddTicks(7618), "فريدة عزیز", "Hazel Boyle", 1, "صلاح LLC", "2721717600309810150", "Bulgaria" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 6, 28, 11, 11, 7, 952, DateTimeKind.Local).AddTicks(5848), new DateTime(2024, 1, 17, 4, 32, 16, 400, DateTimeKind.Local).AddTicks(5701), "جابر‌ هاشم", "Robert Murphy", "هاشم LLC", "1559501415495896229", "Tajikistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 1, 9, 9, 4, 20, 695, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 1, 17, 16, 27, 26, 504, DateTimeKind.Local).AddTicks(3330), "أمجد أمجد", "Jaquelin Runolfsson", "فؤاد Group", "4932309664365053299", "Fiji" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 8, 25, 10, 21, 10, 483, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 1, 17, 19, 13, 34, 459, DateTimeKind.Local).AddTicks(2309), "سارة ربيع", "Burdette Grimes", 0, "بلال, فاروق and عصار", "7145910086776121093", "Seychelles", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 18, 16, 23, 58, 98, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 1, 17, 10, 6, 23, 518, DateTimeKind.Local).AddTicks(9204), "رقية زيد", "Carole Nikolaus", 0, "عزیز - زيد", "7851832034890786708", "Reunion", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 8, 25, 18, 15, 56, 432, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 1, 17, 3, 25, 42, 728, DateTimeKind.Local).AddTicks(487), "زينب بلال", "Deven Rempel", 0, "عاشور - عقیل", "6297909947747150238", "Portugal", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 2, 11, 22, 31, 14, 118, DateTimeKind.Local).AddTicks(4632), new DateTime(2024, 1, 17, 3, 14, 7, 983, DateTimeKind.Local).AddTicks(8437), "سالم هاشم", "Moshe Pollich", "أسامة, فاروق and سالم", "4685306528230283702", "Swaziland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 7, 12, 2, 56, 9, 913, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 1, 17, 17, 1, 0, 856, DateTimeKind.Local).AddTicks(5395), "حسن ربيع", "Cicero Ziemann", "حسن - صلاح", "1861611705745521476", "Norfolk Island", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 7, 29, 0, 37, 36, 89, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 1, 17, 19, 57, 53, 419, DateTimeKind.Local).AddTicks(230), "فريد عزیز", "Alaina Ratke", 1, "آدم, عراقی and عاشور", "1029705264641660881", "Madagascar", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1985, 8, 13, 0, 47, 11, 791, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 1, 17, 6, 39, 35, 841, DateTimeKind.Local).AddTicks(3192), "حازم بلال", "Lorine Armstrong", 1, "عارف - عزیز", "8208467964389405785", "Cyprus" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 3, 18, 18, 26, 12, 308, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 1, 17, 7, 31, 51, 118, DateTimeKind.Local).AddTicks(7726), "دانا بلال", "Ethel Heidenreich", 1, "زيد Group", "4063327943965395659", "Equatorial Guinea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 3, 16, 8, 15, 14, 801, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 1, 17, 1, 15, 9, 800, DateTimeKind.Local).AddTicks(7634), "حسن سالم", "Lorena Feil", 1, "عصار Inc", "1042224137766563671", "Togo", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 11, 17, 11, 39, 39, 741, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 1, 17, 15, 54, 4, 176, DateTimeKind.Local).AddTicks(2320), "فاروق عزیز", "Delphia Aufderhar", 1, "عارف LLC", "50338650039599130", "Morocco", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 4, 9, 3, 19, 24, 204, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 1, 17, 18, 17, 49, 691, DateTimeKind.Local).AddTicks(719), "ربيع فاروق", "Summer Nolan", 1, "عزیز - عاشور", "4892064853703485130", "French Polynesia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 22, 2, 15, 40, 743, DateTimeKind.Local).AddTicks(1528), new DateTime(2024, 1, 17, 1, 1, 56, 997, DateTimeKind.Local).AddTicks(7645), "شيماء ربيع", "Darren Lehner", 1, "حازم, جابر‌ and سعيد", "5842854666231482289", "Israel", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 6, 26, 16, 45, 28, 582, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 1, 17, 3, 52, 6, 258, DateTimeKind.Local).AddTicks(1223), "جمانة عارف", "Theron Torp", 1, "سعيد - سالم", "676766247509890606", "Thailand", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 10, 31, 2, 52, 15, 101, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 1, 17, 8, 34, 22, 56, DateTimeKind.Local).AddTicks(1301), "أمجد عقیل", "Ebony Connelly", 0, "إيهاب, ربيع and عراقی", "2761325563726858311", "Sao Tome and Principe", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 1, 10, 20, 10, 59, 23, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 1, 17, 7, 45, 9, 807, DateTimeKind.Local).AddTicks(4628), "لمى فريد", "Maximo Streich", "معروف, حازم and سعيد", "7011506696561554582", "Gambia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 5, 15, 3, 29, 51, 388, DateTimeKind.Local).AddTicks(1224), new DateTime(2024, 1, 17, 2, 26, 39, 915, DateTimeKind.Local).AddTicks(5156), "حازم حسن", "Lelah Boehm", "عراقی - معروف", "5826733165966093648", "Brunei Darussalam", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 4, 26, 9, 46, 23, 439, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 1, 17, 20, 8, 58, 237, DateTimeKind.Local).AddTicks(1145), "حازم حسن", "Michel Barton", "عقیل - هاشم", "7625693248453907464", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 3, 11, 9, 21, 6, 870, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 1, 17, 19, 25, 57, 299, DateTimeKind.Local).AddTicks(1641), "حسن فؤاد", "Sallie Lehner", 1, "سالم and Sons", "6258628970652945605", "Dominica", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 1, 23, 30, 28, 627, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 1, 17, 23, 1, 0, 361, DateTimeKind.Local).AddTicks(7589), "جابر‌ طارق", "Libby Mosciski", "زيد, فؤاد and هاشم", "163264268286517023", "Syrian Arab Republic", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 9, 22, 17, 9, 48, 594, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 1, 17, 0, 16, 4, 676, DateTimeKind.Local).AddTicks(2411), "طارق فاروق", "Marley Bauch", "حازم, هاشم and عاشور", "1351796024270376611", "Nepal", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 8, 27, 22, 10, 55, 777, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 1, 17, 8, 8, 35, 846, DateTimeKind.Local).AddTicks(2005), "آدم آدم", "Leo Watsica", "سالم Inc", "5063982195472593270", "Romania", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 9, 22, 21, 40, 10, 603, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 1, 17, 9, 47, 27, 405, DateTimeKind.Local).AddTicks(3592), "أسامة عاشور", "Hyman Schiller", 0, "عصار, عقیل and سالم", "3560163117969214897", "Sudan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 5, 17, 21, 33, 27, 796, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 1, 17, 15, 8, 39, 745, DateTimeKind.Local).AddTicks(9384), "شيماء حازم", "Chanel Paucek", 0, "آدم, حازم and بلال", "5160112764897322464", "Indonesia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 1, 14, 19, 50, 24, 847, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 1, 17, 10, 5, 10, 622, DateTimeKind.Local).AddTicks(9249), "إيناس عقیل", "Mitchel Kihn", "سعيد - طارق", "6192635612606389384", "Lesotho", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 9, 26, 21, 57, 30, 742, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 1, 17, 14, 26, 13, 204, DateTimeKind.Local).AddTicks(1854), "دانا عصار", "Heloise Beer", 0, "أمجد, معروف and عصار", "6693332818992763683", "Gabon", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 12, 9, 7, 48, 0, 276, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 1, 17, 13, 13, 13, 857, DateTimeKind.Local).AddTicks(7534), "بلال جابر‌", "Rubie Graham", "سالم - زيد", "5094376440878064990", "Netherlands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 11, 14, 18, 18, 59, 400, DateTimeKind.Local).AddTicks(5076), new DateTime(2024, 1, 17, 17, 49, 56, 640, DateTimeKind.Local).AddTicks(4289), "زيد سالم", "Esther Hamill", 1, "زيد Inc", "6329740735814143717", "French Southern Territories", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 3, 3, 22, 54, 44, 8, DateTimeKind.Local).AddTicks(1808), new DateTime(2024, 1, 17, 8, 25, 15, 31, DateTimeKind.Local).AddTicks(3677), "آدم فؤاد", "Ariel Cartwright", 1, "عارف, سالم and عزیز", "5049400060627579965", "Heard Island and McDonald Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 3, 7, 5, 50, 7, 687, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 1, 17, 10, 14, 23, 392, DateTimeKind.Local).AddTicks(4879), "فاروق أسامة", "Guido Dach", "عقیل LLC", "8649661302090742430", "Netherlands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1972, 2, 27, 22, 14, 9, 663, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 1, 17, 22, 36, 40, 809, DateTimeKind.Local).AddTicks(2663), "إيناس سعيد", "Bryana O'Hara", "عاشور, فاروق and حازم", "3132169762657151080", "Poland" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 7, 4, 2, 49, 31, 270, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 1, 17, 15, 36, 39, 552, DateTimeKind.Local).AddTicks(6644), "آدم سعيد", "Lyla Gusikowski", 1, "هاشم and Sons", "3575381718128080196", "Yemen", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 3, 12, 3, 37, 10, 150, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 1, 17, 9, 30, 53, 678, DateTimeKind.Local).AddTicks(3564), "أمجد جابر‌", "Erika Metz", "عقیل - طارق", "6132649533379722337", "Iceland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 3, 22, 2, 11, 8, 607, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 1, 17, 10, 56, 10, 360, DateTimeKind.Local).AddTicks(4833), "جمانة ربيع", "Bill Christiansen", "حسن - فاروق", "4431422982921375750", "Bulgaria", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 7, 3, 13, 53, 43, 267, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 1, 17, 3, 24, 1, 594, DateTimeKind.Local).AddTicks(5210), "زيد أسامة", "Annabelle Wolf", "أمجد, عارف and عراقی", "2714071822080131469", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 2, 19, 1, 42, 11, 395, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 1, 17, 1, 45, 8, 129, DateTimeKind.Local).AddTicks(6330), "فؤاد عراقی", "Florida Adams", 1, "أمجد - ربيع", "8702055609882372949", "Mozambique", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 6, 18, 16, 31, 130, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 1, 16, 23, 4, 7, 472, DateTimeKind.Local).AddTicks(4289), "فاروق ربيع", "Felicita Hoeger", 1, "أمجد Inc", "8672689531759332038", "Liechtenstein", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1988, 5, 4, 0, 28, 46, 524, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 1, 17, 17, 39, 14, 489, DateTimeKind.Local).AddTicks(1488), "إيهاب فريد", "Ivah Willms", "بلال Group", "1598910816461785976", "Cote d'Ivoire" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 6, 6, 1, 4, 46, 624, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 1, 17, 12, 6, 19, 660, DateTimeKind.Local).AddTicks(4359), "منى حسن", "Rusty Dietrich", "بلال Group", "6017965384747339467", "Mauritania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 11, 26, 11, 12, 18, 643, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 1, 17, 2, 0, 13, 793, DateTimeKind.Local).AddTicks(6147), "فريد عاشور", "Dena Kassulke", 1, "هاشم - آدم", "1198083830765296593", "Guernsey", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 8, 19, 6, 6, 11, 549, DateTimeKind.Local).AddTicks(8942), new DateTime(2024, 1, 17, 17, 0, 30, 346, DateTimeKind.Local).AddTicks(7659), "حازم فاروق", "Ervin Denesik", 0, "حسن Inc", "6934258437387364671", "Libyan Arab Jamahiriya" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 8, 26, 11, 11, 43, 615, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 1, 17, 21, 26, 5, 135, DateTimeKind.Local).AddTicks(7146), "إيهاب بلال", "Shanel Lindgren", "إيهاب, عاشور and أمجد", "9124370986837183192", "China", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 4, 11, 11, 23, 33, 445, DateTimeKind.Local).AddTicks(4537), new DateTime(2024, 1, 17, 20, 35, 23, 914, DateTimeKind.Local).AddTicks(3660), "فؤاد فريد", "Clyde Hegmann", 1, "سعيد - بلال", "5697494083940196496", "Suriname", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 12, 25, 14, 39, 47, 93, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 1, 17, 21, 58, 41, 934, DateTimeKind.Local).AddTicks(1735), "شيماء صلاح", "Vernie Crist", "فريد, أمجد and معروف", "2190568086550512354", "Singapore", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 5, 27, 3, 6, 29, 556, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 1, 17, 3, 44, 52, 265, DateTimeKind.Local).AddTicks(4523), "رنا فاروق", "Maymie Ebert", 0, "أسامة and Sons", "5354371732726660487", "Ecuador", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 3, 6, 0, 52, 24, 395, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 1, 17, 14, 19, 7, 102, DateTimeKind.Local).AddTicks(5495), "جابر‌ حازم", "Faustino Graham", "حازم and Sons", "5559388927351246835", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 11, 10, 16, 19, 27, 305, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 1, 16, 23, 8, 45, 135, DateTimeKind.Local).AddTicks(9332), "آدم عارف", "Lenore Gerhold", "هاشم and Sons", "5216499722462312365", "Saint Barthelemy", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 10, 4, 21, 32, 17, 190, DateTimeKind.Local).AddTicks(7801), new DateTime(2024, 1, 17, 20, 25, 12, 562, DateTimeKind.Local).AddTicks(4637), "شيماء أمجد", "Yvette Kub", 0, "صلاح, صلاح and حازم", "6656420384954346308", "Croatia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 5, 10, 59, 3, 136, DateTimeKind.Local).AddTicks(6169), new DateTime(2024, 1, 17, 10, 58, 35, 900, DateTimeKind.Local).AddTicks(1403), "حسن عصار", "Haylie Goodwin", 1, "طارق Group", "310408269971472082", "Mexico", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 1, 24, 5, 1, 42, 919, DateTimeKind.Local).AddTicks(7471), new DateTime(2024, 1, 17, 11, 59, 18, 388, DateTimeKind.Local).AddTicks(8295), "فريدة بلال", "Aurelie Kautzer", "عاشور - فاروق", "2980580872897563952", "Ethiopia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 9, 3, 15, 49, 19, 795, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 1, 17, 21, 35, 5, 205, DateTimeKind.Local).AddTicks(9676), "أسامة إيهاب", "Israel Kreiger", 0, "جابر‌ - إيهاب", "5509477849788880588", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1975, 1, 6, 16, 0, 17, 475, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 1, 17, 17, 52, 53, 651, DateTimeKind.Local).AddTicks(5436), "ريم آدم", "Piper Wisozk", "فؤاد - ربيع", "7134575252445013622", "Dominican Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 12, 11, 0, 8, 10, 148, DateTimeKind.Local).AddTicks(3665), new DateTime(2024, 1, 17, 3, 13, 2, 451, DateTimeKind.Local).AddTicks(5890), "حازم أمجد", "Esther Dickinson", 1, "معروف - سعيد", "8866041576550777747", "Singapore", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 1, 6, 3, 32, 59, 347, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 1, 17, 5, 42, 41, 289, DateTimeKind.Local).AddTicks(7998), "آدم ربيع", "Meta Sporer", 1, "عاشور - عزیز", "5795991045484292433", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 8, 9, 23, 46, 38, 633, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 1, 17, 11, 17, 16, 218, DateTimeKind.Local).AddTicks(6519), "زينب عزیز", "Beverly Reichert", 1, "فاروق and Sons", "8068145869746513850", "Saint Pierre and Miquelon", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 9, 6, 1, 47, 54, 20, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 1, 16, 23, 10, 20, 56, DateTimeKind.Local).AddTicks(974), "أسامة أسامة", "Mallie Hermann", 1, "عصار - أمجد", "5209804747195153834", "Namibia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 5, 16, 22, 27, 7, 676, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 1, 17, 5, 36, 37, 65, DateTimeKind.Local).AddTicks(2449), "فريد عقیل", "Demetris Armstrong", 0, "بلال - هاشم", "2669724011670387205", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 1, 8, 20, 38, 51, 239, DateTimeKind.Local).AddTicks(1332), new DateTime(2024, 1, 17, 17, 39, 45, 634, DateTimeKind.Local).AddTicks(2040), "ربيع فؤاد", "Berneice Treutel", "أمجد, صلاح and سعيد", "7132122611628343840", "Guinea-Bissau", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1958, 10, 25, 10, 42, 0, 423, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 1, 17, 0, 59, 4, 645, DateTimeKind.Local).AddTicks(9164), "ربيع فؤاد", "Hermann Okuneva", "فريد Inc", "2048297230248310749", "Iran" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 5, 21, 18, 21, 57, 192, DateTimeKind.Local).AddTicks(7894), new DateTime(2024, 1, 17, 16, 12, 34, 375, DateTimeKind.Local).AddTicks(9913), "رنا فاروق", "Bell Smitham", 0, "صلاح LLC", "8041490494628626060", "Ireland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 7, 28, 16, 7, 22, 514, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 1, 17, 12, 38, 58, 949, DateTimeKind.Local).AddTicks(8989), "رقية عقیل", "Noe Keebler", 0, "سعيد - فريد", "4522082734647997718", "French Polynesia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 5, 18, 17, 11, 36, 58, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 1, 17, 17, 9, 3, 418, DateTimeKind.Local).AddTicks(5471), "سعيد فؤاد", "Sandra Purdy", 1, "عاشور, عقیل and أسامة", "2447933026044074059", "Tonga", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 7, 30, 19, 18, 8, 134, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 1, 17, 7, 38, 6, 481, DateTimeKind.Local).AddTicks(1289), "إيهاب بلال", "Antonetta Baumbach", 0, "بلال, عاشور and سالم", "3543144507366194090", "Saint Kitts and Nevis", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 5, 3, 17, 59, 36, 709, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 1, 17, 0, 50, 25, 743, DateTimeKind.Local).AddTicks(8106), "ريم سالم", "Era Satterfield", 1, "عارف Inc", "2225174410476884710", "Australia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 7, 1, 16, 42, 36, 794, DateTimeKind.Local).AddTicks(752), new DateTime(2024, 1, 17, 3, 31, 28, 21, DateTimeKind.Local).AddTicks(7397), "ريم عراقی", "Ava Larkin", "فؤاد, زيد and زيد", "7693233318328051746", "Congo", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 9, 9, 14, 50, 7, 815, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 1, 17, 18, 5, 22, 842, DateTimeKind.Local).AddTicks(1716), "عبير عقیل", "Thora Corwin", "آدم, هاشم and ربيع", "2637543743758309698", "Namibia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 7, 4, 10, 46, 9, 255, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 1, 17, 1, 20, 49, 640, DateTimeKind.Local).AddTicks(425), "زينب سالم", "Arlie Dietrich", 1, "عاشور Inc", "1046554584555068674", "Heard Island and McDonald Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 2, 8, 16, 36, 8, 484, DateTimeKind.Local).AddTicks(1969), new DateTime(2024, 1, 17, 12, 0, 54, 364, DateTimeKind.Local).AddTicks(8202), "حسن فاروق", "Yvette Shanahan", "عراقی, هاشم and عاشور", "6062853626225356502", "Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 9, 17, 15, 36, 38, 79, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 1, 17, 13, 20, 0, 661, DateTimeKind.Local).AddTicks(5723), "جابر‌ حسن", "Roger Johns", "حسن LLC", "1264026323933945795", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 11, 24, 17, 18, 19, 743, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 1, 17, 0, 50, 27, 439, DateTimeKind.Local).AddTicks(2150), "رنا إيهاب", "Lolita Herzog", 0, "عارف, أمجد and عراقی", "7795461989197904538", "Ukraine", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 4, 5, 13, 12, 54, 842, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 1, 17, 21, 59, 41, 559, DateTimeKind.Local).AddTicks(4991), "عبير فؤاد", "Sadie Runolfsdottir", 1, "فريد Group", "4728602172611089990", "Guinea-Bissau", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 2, 3, 17, 8, 14, 262, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 1, 17, 9, 2, 51, 267, DateTimeKind.Local).AddTicks(3282), "سارة إيهاب", "Clyde Abernathy", 0, "أمجد - هاشم", "532419920586024955", "Spain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 4, 20, 5, 57, 35, 796, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 1, 17, 0, 21, 14, 988, DateTimeKind.Local).AddTicks(8818), "آدم فؤاد", "Lazaro Streich", 0, "عصار Group", "7566733536680322493", "Bahrain", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 5, 9, 0, 28, 58, 424, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 1, 17, 22, 38, 40, 429, DateTimeKind.Local).AddTicks(3683), "حسن سالم", "Janiya Feeney", "فاروق Inc", "7140418955643325289", "Palau", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 10, 20, 4, 41, 28, 413, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 1, 17, 4, 46, 40, 855, DateTimeKind.Local).AddTicks(6587), "فريد عقیل", "Deshawn Tromp", "بلال - إيهاب", "6333366124532540287", "Palestinian Territory", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 7, 8, 0, 21, 39, 232, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 1, 17, 8, 5, 40, 92, DateTimeKind.Local).AddTicks(7579), "أسامة صلاح", "Etha Thiel", 0, "عقیل Inc", "6689923838984204057", "Turkmenistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 17, 11, 55, 43, 80, DateTimeKind.Local).AddTicks(134), new DateTime(2024, 1, 16, 23, 21, 58, 427, DateTimeKind.Local).AddTicks(2805), "آدم عارف", "Dominique Altenwerth", 0, "طارق - سعيد", "3337175993748024200", "Belarus", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 16, 4, 2, 37, 799, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 1, 17, 14, 14, 39, 845, DateTimeKind.Local).AddTicks(2005), "زينب فاروق", "Esmeralda Upton", 0, "عزیز, زيد and حسن", "4415602829126914208", "Guam", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 7, 23, 18, 28, 44, 779, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 1, 17, 3, 54, 28, 171, DateTimeKind.Local).AddTicks(6393), "فريدة عارف", "Laura Wintheiser", 0, "فاروق Group", "702614583408220202", "Holy See (Vatican City State)", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1974, 2, 20, 22, 5, 18, 557, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 1, 17, 16, 9, 29, 431, DateTimeKind.Local).AddTicks(8451), "إيهاب إيهاب", "Elvis Herman", "عارف and Sons", "2190399770952323087", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(2002, 5, 27, 20, 5, 54, 163, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 1, 17, 0, 16, 50, 891, DateTimeKind.Local).AddTicks(3861), "لمى حازم", "Emilia Carter", "إيهاب - هاشم", "5931878448355402032", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 2, 11, 22, 1, 3, 979, DateTimeKind.Local).AddTicks(5806), new DateTime(2024, 1, 17, 3, 23, 16, 887, DateTimeKind.Local).AddTicks(5882), "شيماء إيهاب", "Grady Wuckert", 1, "ربيع and Sons", "1162018260845113842", "Paraguay" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 9, 21, 0, 49, 37, 525, DateTimeKind.Local).AddTicks(1538), new DateTime(2024, 1, 17, 10, 19, 51, 509, DateTimeKind.Local).AddTicks(8417), "زينب أمجد", "Marietta Gorczany", "حسن - آدم", "7946308690367189097", "Turkey", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 7, 13, 21, 0, 34, 639, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 1, 17, 11, 59, 12, 927, DateTimeKind.Local).AddTicks(4610), "هاجر بلال", "Lera Hartmann", 0, "بلال Group", "7047989257055417487", "Turkey", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 12, 5, 1, 57, 23, 108, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 1, 17, 22, 48, 43, 899, DateTimeKind.Local).AddTicks(9590), "ربيع هاشم", "Alta Kemmer", 0, "عراقی Group", "7903523252226351762", "Nauru", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 8, 18, 4, 44, 36, 534, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 1, 17, 17, 9, 52, 887, DateTimeKind.Local).AddTicks(9602), "جابر‌ عصار", "Alivia Considine", 1, "عزیز, عقیل and حسن", "8526526640054705137", "Brazil", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 5, 7, 13, 19, 22, 353, DateTimeKind.Local).AddTicks(883), new DateTime(2024, 1, 17, 10, 50, 51, 149, DateTimeKind.Local).AddTicks(2736), "أمجد صلاح", "Keith Hettinger", "زيد, سعيد and فاروق", "2644248871076634819", "Guyana", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 9, 24, 6, 3, 39, 728, DateTimeKind.Local).AddTicks(6025), new DateTime(2024, 1, 17, 13, 41, 3, 414, DateTimeKind.Local).AddTicks(9351), "فريد طارق", "Vicente Towne", "عصار, عقیل and صلاح", "8826205000283672496", "Dominica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 7, 13, 23, 27, 12, 184, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 1, 17, 7, 37, 28, 684, DateTimeKind.Local).AddTicks(7296), "هاجر فاروق", "Gracie Kirlin", "بلال Group", "1031012624009665607", "Lithuania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 8, 2, 14, 31, 2, 211, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 1, 17, 0, 29, 53, 727, DateTimeKind.Local).AddTicks(7571), "جابر‌ ربيع", "Kenton Schumm", 1, "زيد LLC", "3109121485355065064", "Czech Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 3, 6, 11, 15, 35, 710, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 1, 17, 9, 56, 56, 523, DateTimeKind.Local).AddTicks(5001), "سالم حازم", "Linnie Larson", "جابر‌, فاروق and أسامة", "2260914451282233743", "Barbados", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 8, 12, 3, 50, 45, 272, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 1, 17, 21, 26, 54, 372, DateTimeKind.Local).AddTicks(7809), "Catharine Hane", "زيد - فريد", "4310025653983492882", "Liberia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 5, 17, 21, 3, 16, 124, DateTimeKind.Local).AddTicks(3752), new DateTime(2024, 1, 16, 23, 55, 36, 105, DateTimeKind.Local).AddTicks(7473), "فاروق عصار", "Colten Ruecker", 0, "بلال - زيد", "6930065357821716797", "Algeria", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 1, 30, 16, 48, 14, 100, DateTimeKind.Local).AddTicks(4709), new DateTime(2024, 1, 16, 23, 24, 53, 123, DateTimeKind.Local).AddTicks(608), "منى آدم", "Eloy Witting", 1, "عراقی LLC", "5636631067664694388", "Malawi", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 8, 5, 7, 12, 34, 164, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 1, 17, 0, 33, 7, 887, DateTimeKind.Local).AddTicks(4044), "حسن أسامة", "Milan O'Conner", "عصار, آدم and صلاح", "2459083832416316075", "Armenia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 9, 10, 7, 24, 36, 651, DateTimeKind.Local).AddTicks(2504), new DateTime(2024, 1, 17, 5, 16, 36, 13, DateTimeKind.Local).AddTicks(8718), "زينب سعيد", "Keshawn Bartoletti", 0, "هاشم Group", "3350948124644422708", "Central African Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 5, 1, 9, 36, 45, 890, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 1, 17, 8, 56, 23, 671, DateTimeKind.Local).AddTicks(3447), "آية طارق", "Jadon Upton", 0, "آدم and Sons", "264378989049160316", "Mexico", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 10, 7, 21, 17, 43, 421, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 1, 17, 11, 39, 32, 742, DateTimeKind.Local).AddTicks(3965), "عبير أمجد", "Evalyn Jacobi", 0, "عراقی LLC", "545173187066839782", "Ethiopia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 3, 1, 14, 2, 15, 281, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 1, 17, 6, 47, 35, 797, DateTimeKind.Local).AddTicks(6620), "سارة حازم", "Maurice Emard", "فؤاد - بلال", "2770925461229202742", "Bahamas" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 10, 13, 19, 39, 41, 136, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 1, 17, 1, 24, 22, 697, DateTimeKind.Local).AddTicks(7684), "دانا بلال", "Kaylee Koch", 0, "سعيد, أسامة and سعيد", "7387259984918516213", "Svalbard & Jan Mayen Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1956, 12, 7, 11, 31, 58, 101, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 1, 17, 14, 30, 27, 391, DateTimeKind.Local).AddTicks(4552), "سعيد حسن", "Robin Thompson", "عقیل - عصار", "1032136694617111558", "Rwanda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1975, 12, 29, 21, 55, 48, 143, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 1, 17, 3, 12, 13, 657, DateTimeKind.Local).AddTicks(6993), "منى سعيد", "Idell Altenwerth", 1, "معروف - عصار", "7537292900683158635", "Canada" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 5, 11, 23, 46, 36, 538, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 1, 17, 13, 22, 56, 308, DateTimeKind.Local).AddTicks(5879), "شيماء سالم", "Rosanna Brakus", "فاروق - جابر‌", "1092010710980805855", "Guernsey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 8, 18, 22, 15, 53, 62, DateTimeKind.Local).AddTicks(4310), new DateTime(2024, 1, 17, 12, 36, 41, 271, DateTimeKind.Local).AddTicks(7940), "أمجد فريد", "Dejah Ruecker", "معروف, أمجد and بلال", "614969065002803548", "Senegal", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 15, 11, 42, 18, 93, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 1, 16, 23, 55, 54, 174, DateTimeKind.Local).AddTicks(4658), "هاجر عارف", "Heaven Brakus", 1, "أمجد, فؤاد and عصار", "2738258646430504740", "China", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 9, 17, 21, 50, 2, 112, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 1, 17, 14, 55, 39, 591, DateTimeKind.Local).AddTicks(2959), "رقية عقیل", "Fannie Jacobs", "أسامة, آدم and معروف", "5001651598709780090", "Vanuatu", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 8, 9, 2, 13, 31, 371, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 1, 17, 13, 10, 12, 453, DateTimeKind.Local).AddTicks(5140), "ريم سعيد", "Reid Blick", 0, "سعيد - حسن", "2439328103676272095", "Libyan Arab Jamahiriya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 11, 13, 9, 14, 10, 80, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 1, 17, 2, 21, 7, 829, DateTimeKind.Local).AddTicks(3914), "زيد عاشور", "Xavier Ledner", "بلال, آدم and عارف", "6333887109883515086", "India", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 8, 20, 12, 15, 59, 63, DateTimeKind.Local).AddTicks(2730), new DateTime(2024, 1, 17, 7, 12, 15, 31, DateTimeKind.Local).AddTicks(5170), "أمجد أمجد", "Christina Bode", "معروف LLC", "2592109442884928451", "Marshall Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 10, 4, 1, 41, 3, 496, DateTimeKind.Local).AddTicks(6889), new DateTime(2024, 1, 17, 22, 22, 29, 947, DateTimeKind.Local).AddTicks(5887), "أسامة معروف", "Emily Halvorson", 0, "فريد Inc", "4449039867085814524", "Greenland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 7, 5, 15, 29, 41, 725, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 1, 17, 2, 27, 22, 252, DateTimeKind.Local).AddTicks(2582), "لمى فريد", "Gordon Considine", "هاشم - عصار", "8423145210199796253", "Andorra" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 7, 17, 17, 21, 25, 152, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 1, 17, 18, 24, 23, 701, DateTimeKind.Local).AddTicks(1759), "فؤاد حسن", "Cicero Tillman", 0, "عصار, هاشم and عصار", "4474643592651122908", "Virgin Islands, British", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 2, 5, 11, 19, 56, 3, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 1, 17, 17, 41, 57, 551, DateTimeKind.Local).AddTicks(9681), "جابر‌ عقیل", "Bruce Wyman", 0, "عزیز - آدم", "8446956046890538220", "Cameroon" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 11, 7, 1, 12, 45, 191, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 1, 17, 2, 0, 56, 896, DateTimeKind.Local).AddTicks(5531), "رنا أسامة", "Adolphus Bosco", "عراقی, فؤاد and فاروق", "4243445195781519373", "Tuvalu", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 4, 26, 2, 34, 40, 253, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 1, 16, 23, 40, 30, 791, DateTimeKind.Local).AddTicks(1086), "سالم سعيد", "Abdul Okuneva", "زيد - عراقی", "2476662911887414274", "Bangladesh", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 7, 13, 20, 19, 38, 560, DateTimeKind.Local).AddTicks(3189), new DateTime(2024, 1, 17, 21, 39, 19, 50, DateTimeKind.Local).AddTicks(4657), "سارة عارف", "Nannie Schultz", "بلال, هاشم and أسامة", "3054319205508365725", "Christmas Island", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 4, 11, 1, 2, 28, 789, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 1, 17, 6, 48, 4, 60, DateTimeKind.Local).AddTicks(9167), "حسن عزیز", "Jeremie O'Kon", 0, "عزیز - معروف", "1816187520801805686", "Cyprus", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 4, 19, 6, 52, 27, 147, DateTimeKind.Local).AddTicks(5243), new DateTime(2024, 1, 17, 15, 5, 39, 366, DateTimeKind.Local).AddTicks(257), "طارق ربيع", "Clifton Stiedemann", 0, "طارق - سعيد", "4783650768464754875", "Guernsey" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1977, 8, 30, 12, 52, 11, 375, DateTimeKind.Local).AddTicks(9232), new DateTime(2024, 1, 17, 17, 18, 20, 75, DateTimeKind.Local).AddTicks(2755), "سعيد جابر‌", "Freda Nienow", 1, "أسامة, عاشور and عصار", "94366039967206292", "India" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 2, 12, 15, 41, 41, 123, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 1, 17, 2, 10, 0, 277, DateTimeKind.Local).AddTicks(7139), "إيهاب عراقی", "Jillian Moen", 0, "حسن - معروف", "6490779214450446527", "Iceland", 4 });
        }
    }
}
