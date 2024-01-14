using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedTenantModelandTenantIdtoBaseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "TreatmentsHistory",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Patients",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "MedicalFiles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "FinancialInfos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Examinations",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "ContactInfos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Attachments",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyCode = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ActiveField = table.Column<bool>(type: "boolean", nullable: false),
                    TenantId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, 64, انواديبو, Japan", "جاردو", new DateTime(2024, 1, 13, 1, 31, 39, 911, DateTimeKind.Local).AddTicks(6587), "rym.farwq@gmail.com", "205-581-2515 x59758", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دکتر چمران, طريق یادگار امام, 09, دبا, Peru", "سيان", new DateTime(2024, 1, 13, 11, 57, 4, 482, DateTimeKind.Local).AddTicks(4563), "zynb.zyd50@hotmail.com", "940-478-8786 x72256", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش یادگار امام, تقاطع قدس, 045, جد حفص, Swaziland", "المحرق", new DateTime(2024, 1, 13, 10, 58, 37, 703, DateTimeKind.Local).AddTicks(9704), "farwq_asamh@gmail.com", "(614) 241-6657", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق امیرکبیر, 95, كربلاء, Guadeloupe", "بن عروس", new DateTime(2024, 1, 13, 6, 39, 7, 425, DateTimeKind.Local).AddTicks(7735), "fryd_aarf@yahoo.com", "(260) 480-8396", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع فاطمی, 01, القضيمة, Tonga", "سيدي سليمان", new DateTime(2024, 1, 13, 13, 15, 9, 466, DateTimeKind.Local).AddTicks(1309), "rqyh_asar@gmail.com", "850.846.6799", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دماوند, طريق راستوان, 52, عين اعبيد, Tunisia", "عفيف", new DateTime(2024, 1, 13, 12, 29, 38, 167, DateTimeKind.Local).AddTicks(8672), "fryd.slah@gmail.com", "972-493-0252", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اقبال لاهوری, 434, عفرين, Belarus", "خان شيخون", new DateTime(2024, 1, 13, 13, 37, 39, 133, DateTimeKind.Local).AddTicks(1316), "jabr.tarq@gmail.com", "951.948.0941", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع موحد دانش, دوار هویزه, 1, يوبوكي, Hungary", "راس العين", new DateTime(2024, 1, 13, 19, 11, 35, 861, DateTimeKind.Local).AddTicks(7771), "hajr32@yahoo.com", "1-697-498-0968 x75648", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, 587, القرداحة, Austria", "سخنين", new DateTime(2024, 1, 13, 8, 18, 38, 698, DateTimeKind.Local).AddTicks(8376), "zyd.hashm@hotmail.com", "(316) 287-8280", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, 2527, دهبان, Guam", "جحفية", new DateTime(2024, 1, 13, 7, 18, 10, 16, DateTimeKind.Local).AddTicks(2677), "abyr.asamh23@yahoo.com", "1-487-290-1295 x39164", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, 4, إربد, Paraguay", "المالكية", new DateTime(2024, 1, 13, 5, 45, 39, 876, DateTimeKind.Local).AddTicks(4933), "sarh_araqy@gmail.com", "1-775-930-5807", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع هویزه, شارع دماوند, 2, الفيوم, Turks and Caicos Islands", "زاخو", new DateTime(2024, 1, 13, 22, 4, 26, 732, DateTimeKind.Local).AddTicks(715), "fuad71@gmail.com", "965-478-7410 x6783", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سمیه, ش دماوند, 67, منبج, India", "شرورة", new DateTime(2024, 1, 13, 13, 6, 6, 934, DateTimeKind.Local).AddTicks(6692), "rqyh22@yahoo.com", "670.468.5809 x99912", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, 6192, أسوان, Greece", "رداع", new DateTime(2024, 1, 13, 16, 29, 38, 841, DateTimeKind.Local).AddTicks(3274), "hazm_aqyl40@yahoo.com", "572-381-0231", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع هویزه, تقاطع فاطمی, 5839, قليوب, Svalbard & Jan Mayen Islands", "الدار البيضاء", new DateTime(2024, 1, 13, 14, 11, 49, 419, DateTimeKind.Local).AddTicks(1545), "abyr38@hotmail.com", "(484) 247-0792 x87666", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, 61, أم رواب, Belarus", "سبها", new DateTime(2024, 1, 13, 20, 59, 30, 292, DateTimeKind.Local).AddTicks(2410), "frydh99@hotmail.com", "312-740-4158", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش رسالت, طريق رسالت, 1, صلالة, France", "نابلس", new DateTime(2024, 1, 13, 0, 41, 28, 699, DateTimeKind.Local).AddTicks(2165), "fatmh.hashm@hotmail.com", "1-433-497-2197 x1949", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دکتر چمران, ش سباری, 03, عكا, Liberia", "نجران", new DateTime(2024, 1, 13, 16, 35, 24, 399, DateTimeKind.Local).AddTicks(9123), "asamh36@yahoo.com", "837.443.9107 x789", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق یادگار امام, 885, طرابلس, Vanuatu", "العين", new DateTime(2024, 1, 13, 16, 52, 48, 252, DateTimeKind.Local).AddTicks(9332), "dana_asamh78@hotmail.com", "824-417-9145 x05457", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اجاره دار, طريق اقبال لاهوری, 866, الخرج, Slovakia (Slovak Republic)", "أبو كبير", new DateTime(2024, 1, 13, 1, 19, 23, 817, DateTimeKind.Local).AddTicks(9963), "shymaa70@yahoo.com", "1-267-395-1457", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان راستوان, تقاطع اقبال لاهوری, 3542, ينبع, Eritrea", "الفلوجة", new DateTime(2024, 1, 13, 18, 5, 22, 652, DateTimeKind.Local).AddTicks(6820), "frydh_amjd@hotmail.com", "1-610-472-8311", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش امیرکبیر, 5521, تعز, Belize", "جلب", new DateTime(2024, 1, 13, 17, 36, 52, 862, DateTimeKind.Local).AddTicks(7403), "blal20@yahoo.com", "1-586-882-3210", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دستغیب, تقاطع رسالت, 637, اليوسفية, Burundi", "حلبا", new DateTime(2024, 1, 13, 5, 35, 41, 248, DateTimeKind.Local).AddTicks(9212), "lma97@yahoo.com", "694-713-6425 x13842", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دستغیب, ميدان شهید مطهری, 6, الدور, Nepal", "الصويرة", new DateTime(2024, 1, 13, 8, 14, 33, 878, DateTimeKind.Local).AddTicks(4620), "salm33@hotmail.com", "565.784.2466 x07189", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دستغیب, 52, الحسيمة, Trinidad and Tobago", "سيان", new DateTime(2024, 1, 13, 9, 17, 32, 820, DateTimeKind.Local).AddTicks(747), "zynb48@gmail.com", "631-571-9066", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, ميدان قدس, 889, فاس, Ethiopia", "طرابلس", new DateTime(2024, 1, 13, 2, 52, 25, 274, DateTimeKind.Local).AddTicks(4595), "hazm37@gmail.com", "703.294.5410 x286", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان موحد دانش, 338, القحطانية, Burundi", "صير بني ياس", new DateTime(2024, 1, 13, 12, 8, 30, 6, DateTimeKind.Local).AddTicks(2527), "hsn_sayd43@hotmail.com", "1-218-248-2375", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, 3, الجلفة, Serbia", "مراكش", new DateTime(2024, 1, 14, 0, 26, 32, 219, DateTimeKind.Local).AddTicks(1649), "rym.slah35@yahoo.com", "(445) 506-0692", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار قدس, طريق دستغیب, 7876, الرطبة, Guinea-Bissau", "عطبرة", new DateTime(2024, 1, 13, 1, 17, 26, 811, DateTimeKind.Local).AddTicks(9824), "rbya.farwq86@gmail.com", "1-601-466-3636 x59748", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش حقانی, ش واعظی, 196, خريبة السوق, Jersey", "الجوف", new DateTime(2024, 1, 13, 22, 15, 16, 850, DateTimeKind.Local).AddTicks(6818), "dana79@hotmail.com", "866.272.5984", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دیباجی, طريق آفریقا, 54, يامبيو, Sao Tome and Principe", "الموصل", new DateTime(2024, 1, 13, 21, 28, 30, 925, DateTimeKind.Local).AddTicks(6524), "blal.salm4@gmail.com", "1-663-341-2088 x6593", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دکتر چمران, طريق سمیه, 38, بيشة, Guinea", "نابلس", new DateTime(2024, 1, 13, 23, 38, 29, 947, DateTimeKind.Local).AddTicks(6679), "hazm_iyhab1@gmail.com", "1-782-429-1294 x7441", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دکتر چمران, 8989, جحفية, Zimbabwe", "القريات", new DateTime(2024, 1, 13, 5, 13, 4, 513, DateTimeKind.Local).AddTicks(8168), "slah_aashwr@hotmail.com", "562-909-0002", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, 9, دورا, Jordan", "الفجيرة", new DateTime(2024, 1, 13, 6, 24, 26, 567, DateTimeKind.Local).AddTicks(6347), "farwq39@yahoo.com", "408-886-0975 x333", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, ميدان سمیه, 0161, ملوى, Bhutan", "يبرود", new DateTime(2024, 1, 13, 7, 54, 53, 380, DateTimeKind.Local).AddTicks(1867), "amjd_araqy@yahoo.com", "546-442-0701 x1634", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع اقبال لاهوری, شارع رسالت, 12, أربيل, Russian Federation", "القنيطرة", new DateTime(2024, 1, 13, 5, 31, 51, 676, DateTimeKind.Local).AddTicks(7342), "salm.farwq58@gmail.com", "1-512-777-0981 x278", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان امیرکبیر, 9, العيون, United States of America", "باقة الغربية", new DateTime(2024, 1, 13, 5, 27, 54, 446, DateTimeKind.Local).AddTicks(2590), "fryd.aadm@yahoo.com", "1-628-390-5105 x7981", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار فاطمی, 018, مدنين, Seychelles", "سكاكا", new DateTime(2024, 1, 13, 9, 51, 9, 248, DateTimeKind.Local).AddTicks(219), "fuad_blal23@gmail.com", "250-320-1611", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع واعظی, دوار دیباجی, 449, العلا, Cambodia", "الدور", new DateTime(2024, 1, 13, 19, 29, 27, 327, DateTimeKind.Local).AddTicks(7904), "asamh84@hotmail.com", "262-935-0958", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سمیه, طريق دماوند, 4062, زليطن, New Zealand", "الحجرة", new DateTime(2024, 1, 14, 0, 18, 25, 217, DateTimeKind.Local).AddTicks(9846), "rbya.fuad@gmail.com", "530-245-8424", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سباری, دوار کارگر شمالی, 6100, مقطع لحجار, Moldova", "جاردو", new DateTime(2024, 1, 13, 2, 31, 50, 939, DateTimeKind.Local).AddTicks(7275), "abyr.aarf12@hotmail.com", "(848) 790-3923 x04635", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, شارع آذربایجان, 0204, سترة, Bahrain", "التل", new DateTime(2024, 1, 13, 2, 6, 38, 77, DateTimeKind.Local).AddTicks(1366), "abyr37@hotmail.com", "559.819.9364 x58491", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع یادگار امام, 21, البغدادي, Saint Kitts and Nevis", "إدلب", new DateTime(2024, 1, 13, 14, 28, 54, 272, DateTimeKind.Local).AddTicks(8613), "aadm.zyd@gmail.com", "583.663.2375 x537", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سباری, 7, معرة النعمان, Vietnam", "الكاظمية", new DateTime(2024, 1, 13, 7, 42, 8, 149, DateTimeKind.Local).AddTicks(4736), "sarh.tarq@yahoo.com", "454-999-2855", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار شهید مطهری, طريق کارگر شمالی, 0, صلخد, Mauritania", "البريمي", new DateTime(2024, 1, 13, 20, 34, 24, 329, DateTimeKind.Local).AddTicks(9911), "zynb.asar24@yahoo.com", "208-745-9425", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, ش سمیه, 1121, أطار, Luxembourg", "رفحا", new DateTime(2024, 1, 13, 17, 0, 59, 617, DateTimeKind.Local).AddTicks(9302), "aadm.asamh73@hotmail.com", "819.318.0569", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع قدس, شارع ابوذر, 72, الزقازيق, Belize", "أدم", new DateTime(2024, 1, 13, 15, 3, 58, 285, DateTimeKind.Local).AddTicks(2349), "mna30@yahoo.com", "1-899-830-4248 x306", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع موحد دانش, 9, بوكادوم, Cambodia", "العيون", new DateTime(2024, 1, 13, 20, 54, 10, 718, DateTimeKind.Local).AddTicks(8211), "amjd_salm@hotmail.com", "972.976.4562 x68161", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق هویزه, شارع سباری, 6650, خان يونس, South Georgia and the South Sandwich Islands", "دخيل", new DateTime(2024, 1, 13, 7, 26, 38, 873, DateTimeKind.Local).AddTicks(3417), "blal.tarq@yahoo.com", "(566) 282-1183 x9067", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق قدس, ميدان دماوند, 9, باب الزوار, Ireland", "الرمادي", new DateTime(2024, 1, 13, 18, 25, 58, 743, DateTimeKind.Local).AddTicks(861), "zyd_zyd73@hotmail.com", "674.339.1427 x948", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع هویزه, 93, عشرة رمضان, San Marino", "مادبا", new DateTime(2024, 1, 13, 16, 47, 53, 809, DateTimeKind.Local).AddTicks(7596), "frydh2@hotmail.com", "391.972.8765", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, دوار امیرکبیر, 08, أم قصر, Ethiopia", "دسوق", new DateTime(2024, 1, 13, 11, 28, 31, 24, DateTimeKind.Local).AddTicks(6984), "dana_asamh94@hotmail.com", "1-310-271-8084 x91085", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سمیه, 8872, صلنفة, Equatorial Guinea", "سيدي بلعباس", new DateTime(2024, 1, 13, 14, 9, 19, 603, DateTimeKind.Local).AddTicks(4600), "zyd.araqy8@hotmail.com", "322.347.9281 x643", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق کارگر شمالی, 953, إب, Finland", "المحرق", new DateTime(2024, 1, 13, 13, 40, 52, 420, DateTimeKind.Local).AddTicks(9705), "aadm_araqy77@gmail.com", "(267) 997-4512 x657", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, ش استاد قریب, 154, العيينة, Moldova", "الأتارب", new DateTime(2024, 1, 13, 12, 6, 36, 127, DateTimeKind.Local).AddTicks(4366), "hsn.iyhab48@yahoo.com", "1-444-222-9995", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, 7367, جيجل, Cook Islands", "سوق أهراس", new DateTime(2024, 1, 13, 5, 45, 55, 500, DateTimeKind.Local).AddTicks(8274), "frydh.hsn@hotmail.com", "(734) 729-2986 x328", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دماوند, 40, أسفي, Croatia", "كفرشوبا", new DateTime(2024, 1, 13, 5, 7, 5, 72, DateTimeKind.Local).AddTicks(4558), "mna.fuad32@gmail.com", "509.281.4963 x600", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار یادگار امام, 166, دخيل, San Marino", "القطيف", new DateTime(2024, 1, 14, 0, 4, 40, 149, DateTimeKind.Local).AddTicks(1736), "zynb98@hotmail.com", "200-549-3076 x89398", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, طريق یادگار امام, 9021, سيلبابي, Turks and Caicos Islands", "الكسوة", new DateTime(2024, 1, 13, 6, 8, 9, 113, DateTimeKind.Local).AddTicks(7866), "shymaa.amjd@yahoo.com", "594.563.1098 x9403", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع رسالت, 34, قسنطينة, Madagascar", "الزقازيق", new DateTime(2024, 1, 13, 22, 49, 37, 65, DateTimeKind.Local).AddTicks(5633), "zyd_fryd53@hotmail.com", "901-685-2611 x258", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان استاد قریب, 2332, القريات, Sao Tome and Principe", "البريمي", new DateTime(2024, 1, 13, 22, 51, 44, 479, DateTimeKind.Local).AddTicks(5245), "fatmh.hashm@gmail.com", "1-480-743-2849 x06586", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش حقانی, ش آزادی, 9155, الإسماعيلية, Cambodia", "أبو ظبي", new DateTime(2024, 1, 13, 20, 32, 2, 15, DateTimeKind.Local).AddTicks(7292), "zynb21@gmail.com", "(527) 800-4151 x0718", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اقبال لاهوری, 36, مقطع لحجار, Sri Lanka", "جت", new DateTime(2024, 1, 13, 3, 26, 10, 397, DateTimeKind.Local).AddTicks(7307), "hajr_zyd@yahoo.com", "1-289-822-5993 x63702", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دیباجی, 169, الجديدة, Saint Helena", "دير البلح", new DateTime(2024, 1, 13, 3, 46, 58, 789, DateTimeKind.Local).AddTicks(9594), "lma.iyhab@hotmail.com", "623-616-5284 x3380", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دیباجی, شارع ابوذر, 23, أبو كمال, Mauritania", "العين", new DateTime(2024, 1, 13, 5, 46, 23, 399, DateTimeKind.Local).AddTicks(740), "amjd12@gmail.com", "351-848-4009", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, طريق دیباجی, 32, أسيوط, Grenada", "باتنة", new DateTime(2024, 1, 13, 5, 5, 21, 689, DateTimeKind.Local).AddTicks(5613), "jabr.aashwr@hotmail.com", "1-555-544-4201 x87423", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, دوار هویزه, 339, بلد, Nigeria", "مدينة الحرير", new DateTime(2024, 1, 13, 22, 46, 50, 57, DateTimeKind.Local).AddTicks(3141), "jmanh_asamh@gmail.com", "(301) 729-7791", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آزادی, تقاطع یادگار امام, 61, السليمانية, Portugal", "العيينة", new DateTime(2024, 1, 13, 18, 12, 30, 937, DateTimeKind.Local).AddTicks(8012), "zyd_aarf@gmail.com", "1-915-532-5090", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دماوند, 6, سلفيت, Thailand", "صلخد", new DateTime(2024, 1, 13, 11, 23, 48, 450, DateTimeKind.Local).AddTicks(8759), "hazm_salm@hotmail.com", "654-892-8558", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آزادی, ميدان شهید مطهری, 390, المالكية, Philippines", "السويق", new DateTime(2024, 1, 13, 21, 22, 40, 69, DateTimeKind.Local).AddTicks(4737), "jabr57@gmail.com", "1-346-375-6296", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, شارع سمیه, 290, دهبان, Pitcairn Islands", "جرسيف", new DateTime(2024, 1, 13, 7, 47, 3, 822, DateTimeKind.Local).AddTicks(5627), "blal.araqy@gmail.com", "638.280.3299 x9923", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار استاد قریب, 6, عقوبة, Martinique", "التل", new DateTime(2024, 1, 13, 17, 39, 34, 447, DateTimeKind.Local).AddTicks(3738), "fuad.asamh36@gmail.com", "1-312-861-4914 x82402", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سباری, 2490, القبة, Nauru", "صلخد", new DateTime(2024, 1, 13, 20, 34, 51, 69, DateTimeKind.Local).AddTicks(7425), "abyr.jabr71@hotmail.com", "602-838-0883", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آذربایجان, دوار استاد قریب, 531, باب الزوار, Iran", "طرعان", new DateTime(2024, 1, 13, 2, 45, 14, 747, DateTimeKind.Local).AddTicks(2149), "aadm43@hotmail.com", "1-459-361-1927", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آفریقا, تقاطع سمیه, 05, مقطع لحجار, Burundi", "سيدي قاسم", new DateTime(2024, 1, 13, 13, 5, 54, 449, DateTimeKind.Local).AddTicks(3005), "slah.aashwr44@gmail.com", "599.613.6846", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان واعظی, ميدان فاطمی, 7, الخرطوم, Niue", "غرداية", new DateTime(2024, 1, 13, 23, 27, 11, 329, DateTimeKind.Local).AddTicks(2881), "rbya.aashwr@yahoo.com", "581.590.2397 x94293", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع یادگار امام, طريق واعظی, 16, عفرين, American Samoa", "ينبع", new DateTime(2024, 1, 13, 12, 9, 21, 375, DateTimeKind.Local).AddTicks(8713), "sayd.jabr@hotmail.com", "(726) 362-1860", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آفریقا, شارع اجاره دار, 1, الجش, Israel", "تل كيف", new DateTime(2024, 1, 13, 13, 8, 58, 385, DateTimeKind.Local).AddTicks(9655), "slah.slah64@gmail.com", "1-750-571-8872 x3402", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دماوند, دوار فاطمی, 5, الطينطان, Germany", "الدمام", new DateTime(2024, 1, 14, 0, 0, 58, 965, DateTimeKind.Local).AddTicks(5383), "sayd.salm42@yahoo.com", "(487) 479-5759 x444", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار واعظی, 7, اللد, American Samoa", "مسعد", new DateTime(2024, 1, 13, 15, 51, 19, 957, DateTimeKind.Local).AddTicks(4856), "fryd.marwf@gmail.com", "(895) 457-9788 x5658", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار هویزه, 2, أدم, Bulgaria", "تقورت", new DateTime(2024, 1, 13, 6, 6, 56, 881, DateTimeKind.Local).AddTicks(4777), "fryd1@hotmail.com", "211-562-3720", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دماوند, 1, ازويرات, Mali", "عفرين", new DateTime(2024, 1, 13, 18, 35, 48, 586, DateTimeKind.Local).AddTicks(43), "abyr.salm@hotmail.com", "640-673-4294 x846", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سمیه, 157, جاردو, Gibraltar", "كربلاء", new DateTime(2024, 1, 13, 14, 46, 44, 418, DateTimeKind.Local).AddTicks(4116), "rbya_hsn@hotmail.com", "988.677.3022 x4843", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سمیه, طريق اجاره دار, 3, الفاشر, Saint Pierre and Miquelon", "بوكادوم", new DateTime(2024, 1, 13, 13, 16, 0, 111, DateTimeKind.Local).AddTicks(6526), "lma.zyd@hotmail.com", "315-763-0038", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش کارگر شمالی, شارع سمیه, 814, صلنفة, Antarctica (the territory South of 60 deg S)", "عكا", new DateTime(2024, 1, 13, 12, 45, 35, 85, DateTimeKind.Local).AddTicks(7700), "hsn.aarf@gmail.com", "825-751-2399 x96485", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع موحد دانش, ش ابوذر, 8, الرستن, Iceland", "الأغواط", new DateTime(2024, 1, 13, 0, 53, 50, 573, DateTimeKind.Local).AddTicks(2437), "aayh_rbya@hotmail.com", "914-499-3905", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سمیه, 9913, بركان, Burundi", "خريبكة", new DateTime(2024, 1, 13, 10, 18, 40, 504, DateTimeKind.Local).AddTicks(6091), "mna_farwq59@gmail.com", "302.930.3428 x884", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار ابوذر, تقاطع آذربایجان, 1, جحفية, Ukraine", "عين البيضاء", new DateTime(2024, 1, 13, 4, 2, 39, 266, DateTimeKind.Local).AddTicks(738), "zyd.hashm40@gmail.com", "988.901.5685", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان امیرکبیر, دوار اجاره دار, 8, عين العرب, Italy", "السويداء", new DateTime(2024, 1, 13, 3, 55, 41, 785, DateTimeKind.Local).AddTicks(7821), "tarq_farwq87@gmail.com", "874-406-0720", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اقبال لاهوری, 3, ريسوت, Western Sahara", "بور سعيد", new DateTime(2024, 1, 13, 11, 40, 10, 545, DateTimeKind.Local).AddTicks(5403), "zynb_blal31@hotmail.com", "984.397.7270 x968", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, تقاطع سمیه, 52, العزيزية, Isle of Man", "مدينة ستة أكتوبر", new DateTime(2024, 1, 13, 2, 20, 17, 510, DateTimeKind.Local).AddTicks(1194), "tarq.marwf8@hotmail.com", "352.707.9034", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع امیرکبیر, 8546, الجيزة, Virgin Islands, U.S.", "الرمادي", new DateTime(2024, 1, 13, 22, 5, 9, 159, DateTimeKind.Local).AddTicks(239), "salm.fryd@gmail.com", "1-853-697-0885", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آفریقا, شارع ابوذر, 6105, ولاتة, Costa Rica", "اكجوجت", new DateTime(2024, 1, 13, 14, 14, 18, 291, DateTimeKind.Local).AddTicks(3166), "lma69@hotmail.com", "1-837-685-3057", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع قدس, شارع سباری, 18, الخمس, Palau", "غرداية", new DateTime(2024, 1, 13, 17, 15, 38, 163, DateTimeKind.Local).AddTicks(1715), "farwq62@yahoo.com", "882-398-1902", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع اقبال لاهوری, ش آذربایجان, 1, أوبوك, Brazil", "الدقم", new DateTime(2024, 1, 14, 0, 31, 16, 194, DateTimeKind.Local).AddTicks(6700), "amjd16@hotmail.com", "941-235-9465 x28380", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اجاره دار, دوار کارگر شمالی, 416, هيت, Armenia", "أسفي", new DateTime(2024, 1, 13, 10, 44, 4, 184, DateTimeKind.Local).AddTicks(4722), "rna_aadm26@hotmail.com", "692-792-5977 x36069", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش قدس, 4933, خنشلة, Angola", "شيبه", new DateTime(2024, 1, 13, 4, 25, 18, 991, DateTimeKind.Local).AddTicks(9648), "iyhab60@gmail.com", "336.247.0303 x354", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار واعظی, ميدان واعظی, 66, خنيفرة, Panama", "دمازين", new DateTime(2024, 1, 13, 18, 17, 14, 148, DateTimeKind.Local).AddTicks(5415), "rna36@hotmail.com", "672.741.5394 x186", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان امیرکبیر, 8532, حلبا, Turkey", "خريبكة", new DateTime(2024, 1, 13, 6, 59, 28, 611, DateTimeKind.Local).AddTicks(6541), "zyd.amjd@yahoo.com", "(913) 861-0792", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع حقانی, طريق دیباجی, 151, قرية سار, Malta", "خنيفرة", new DateTime(2024, 1, 13, 18, 31, 32, 112, DateTimeKind.Local).AddTicks(8619), "shymaa.salm50@hotmail.com", "575.543.9174", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع حقانی, 622, مدينة الملك عبد الله الاقتصادية, Mongolia", "الحوامدية", new DateTime(2024, 1, 13, 9, 25, 42, 549, DateTimeKind.Local).AddTicks(2741), "mna.aashwr61@gmail.com", "(977) 676-6897 x8459", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار رسالت, تقاطع موحد دانش, 2, النهود, Senegal", "سرت", new DateTime(2024, 1, 14, 0, 30, 35, 656, DateTimeKind.Local).AddTicks(1766), "frydh72@gmail.com", "(219) 235-6542", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش حقانی, 891, رداع, Libyan Arab Jamahiriya", "مراكش", new DateTime(2024, 1, 13, 18, 57, 1, 693, DateTimeKind.Local).AddTicks(5866), "dana_sayd@hotmail.com", "901.317.8364", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع حقانی, ش دماوند, 5, العيون, Ireland", "أرتا", new DateTime(2024, 1, 13, 19, 51, 16, 752, DateTimeKind.Local).AddTicks(7748), "iynas_hashm42@gmail.com", "1-809-736-8090 x89918", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سمیه, 2992, السويق, Dominican Republic", "صفرو", new DateTime(2024, 1, 13, 12, 1, 20, 180, DateTimeKind.Local).AddTicks(780), "rym.aadm@hotmail.com", "240.800.1536", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دیباجی, 575, الشوف, Bhutan", "سيدي سليمان", new DateTime(2024, 1, 13, 6, 53, 43, 420, DateTimeKind.Local).AddTicks(8418), "jmanh_iyhab27@yahoo.com", "948-235-2432 x3949", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, ش مالک اشتر, 63, الفلوجة, Denmark", "بوكادوم", new DateTime(2024, 1, 13, 6, 25, 31, 204, DateTimeKind.Local).AddTicks(1519), "jmanh_hazm94@hotmail.com", "715.796.4056 x531", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دکتر چمران, 5780, حديثة, Lebanon", "أسوان", new DateTime(2024, 1, 14, 0, 11, 26, 942, DateTimeKind.Local).AddTicks(2903), "mna50@hotmail.com", "999-805-2967 x62002", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آفریقا, 5, اللد, Dominican Republic", "جرابلس", new DateTime(2024, 1, 13, 23, 32, 49, 593, DateTimeKind.Local).AddTicks(1140), "dana_iyhab@yahoo.com", "798.334.4334 x7707", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار فاطمی, 31, حقل, Papua New Guinea", "القريات", new DateTime(2024, 1, 13, 2, 59, 25, 172, DateTimeKind.Local).AddTicks(2517), "mna3@hotmail.com", "1-330-802-1519 x09188", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع واعظی, ش مالک اشتر, 7, كفر الدوار, China", "نواكشوط", new DateTime(2024, 1, 13, 14, 33, 3, 701, DateTimeKind.Local).AddTicks(5981), "slah.azyz@gmail.com", "627.316.8348 x202", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 5, بجاية, Chile", "مطرح", new DateTime(2024, 1, 13, 23, 33, 13, 20, DateTimeKind.Local).AddTicks(1691), "rbya_asamh10@gmail.com", "1-740-236-6068 x1848", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع یادگار امام, 9009, الجلفة, Cape Verde", "الشحر", new DateTime(2024, 1, 13, 1, 59, 41, 49, DateTimeKind.Local).AddTicks(1011), "lma_aadm@yahoo.com", "(670) 625-6601", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, 8, بقيق, Colombia", "العين", new DateTime(2024, 1, 13, 3, 24, 2, 326, DateTimeKind.Local).AddTicks(2144), "tarq.slah@hotmail.com", "705-943-3811 x214", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آذربایجان, ميدان آفریقا, 68, قابس, Serbia", "حوطة بني تميم", new DateTime(2024, 1, 13, 19, 51, 59, 682, DateTimeKind.Local).AddTicks(5514), "hazm18@hotmail.com", "927-579-6583", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دکتر چمران, شارع امیرکبیر, 3717, جرسيف, Azerbaijan", "سوق أهراس", new DateTime(2024, 1, 13, 8, 45, 12, 952, DateTimeKind.Local).AddTicks(5427), "fuad_araqy99@hotmail.com", "878.813.8496", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان استاد قریب, 1058, السويس, Bolivia", "الرس", new DateTime(2024, 1, 13, 14, 22, 26, 431, DateTimeKind.Local).AddTicks(2321), "lma_tarq@hotmail.com", "1-294-856-8516 x75449", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دیباجی, شارع واعظی, 266, صحم, Solomon Islands", "الكسوة", new DateTime(2024, 1, 13, 17, 15, 4, 184, DateTimeKind.Local).AddTicks(1866), "salm15@gmail.com", "(286) 501-7232 x6954", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع موحد دانش, ش راستوان, 15, عقوبة, Faroe Islands", "خان يونس", new DateTime(2024, 1, 13, 13, 29, 58, 304, DateTimeKind.Local).AddTicks(5306), "dana.zyd49@hotmail.com", "491-728-6397 x02941", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, 758, البيضاء, Lithuania", "مادبا", new DateTime(2024, 1, 13, 20, 22, 37, 357, DateTimeKind.Local).AddTicks(9018), "fryd_hazm96@yahoo.com", "(497) 282-7267", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دماوند, 371, يبرود, Cambodia", "وجدة", new DateTime(2024, 1, 13, 14, 40, 4, 266, DateTimeKind.Local).AddTicks(5371), "rbya_sayd@yahoo.com", "(443) 789-5519", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق هویزه, 63, يافا, Bhutan", "بور سعيد", new DateTime(2024, 1, 13, 23, 39, 33, 790, DateTimeKind.Local).AddTicks(6483), "rym_slah@yahoo.com", "(603) 590-8627 x775", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع یادگار امام, شارع دستغیب, 5, الوادي, Timor-Leste", "أسيوط", new DateTime(2024, 1, 13, 18, 24, 17, 126, DateTimeKind.Local).AddTicks(7703), "arwa_amjd@hotmail.com", "265-621-8922", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, ميدان سباری, 9376, أسيلا, Cape Verde", "كسماوي", new DateTime(2024, 1, 13, 7, 33, 20, 945, DateTimeKind.Local).AddTicks(7108), "sayd_aadm7@hotmail.com", "(413) 443-9642", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, طريق امیرکبیر, 1356, الناصرة, Grenada", "برج الكيفان", new DateTime(2024, 1, 13, 2, 16, 40, 489, DateTimeKind.Local).AddTicks(3183), "sarh.salm@gmail.com", "492.668.0846 x553", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اجاره دار, طريق آذربایجان, 6722, الخرج, Bouvet Island (Bouvetoya)", "بيت لحم", new DateTime(2024, 1, 13, 14, 1, 40, 227, DateTimeKind.Local).AddTicks(1206), "rqyh_sayd6@yahoo.com", "1-549-774-3276 x59571", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش حقانی, 6964, الدور, Aruba", "البديع", new DateTime(2024, 1, 13, 1, 57, 26, 906, DateTimeKind.Local).AddTicks(5511), "sarh28@yahoo.com", "798.643.5934 x28904", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع واعظی, ش حقانی, 7233, تيارت, Guadeloupe", "درنة", new DateTime(2024, 1, 13, 17, 2, 36, 480, DateTimeKind.Local).AddTicks(6976), "rna_asar@yahoo.com", "(467) 332-3142", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سمیه, 7224, سطات, Antarctica (the territory South of 60 deg S)", "بابابى", new DateTime(2024, 1, 13, 7, 11, 20, 675, DateTimeKind.Local).AddTicks(42), "hajr49@gmail.com", "(852) 563-8315", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق حقانی, طريق یادگار امام, 10, بو سعادة, Guinea", "الدور", new DateTime(2024, 1, 13, 15, 43, 57, 376, DateTimeKind.Local).AddTicks(3803), "fatmh.fuad15@gmail.com", "1-800-613-0885", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع موحد دانش, 801, السويس, Guyana", "حيفا", new DateTime(2024, 1, 13, 20, 7, 48, 145, DateTimeKind.Local).AddTicks(1486), "aadm.tarq@hotmail.com", "950.544.8874 x793", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, 55, ضرما, Cook Islands", "القدس", new DateTime(2024, 1, 14, 0, 24, 7, 425, DateTimeKind.Local).AddTicks(4506), "fatmh_amjd54@yahoo.com", "617-581-9074", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دماوند, طريق دیباجی, 9, الوكرة, Tuvalu", "الدقم", new DateTime(2024, 1, 13, 16, 18, 23, 585, DateTimeKind.Local).AddTicks(9057), "amjd.blal@hotmail.com", "981.968.4699 x367", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار هویزه, ميدان اقبال لاهوری, 335, قالمة, British Indian Ocean Territory (Chagos Archipelago)", "صحم", new DateTime(2024, 1, 13, 4, 43, 3, 808, DateTimeKind.Local).AddTicks(34), "tarq.asar@yahoo.com", "551-935-7591 x30433", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اقبال لاهوری, 658, كفرشوبا, French Polynesia", "ازرع", new DateTime(2024, 1, 13, 15, 18, 27, 929, DateTimeKind.Local).AddTicks(9373), "iyhab87@hotmail.com", "1-445-934-2400 x29179", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آزادی, 17, ريان, Thailand", "كركوك", new DateTime(2024, 1, 13, 7, 49, 8, 467, DateTimeKind.Local).AddTicks(1839), "jabr.asamh@gmail.com", "687-625-2716 x617", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دماوند, دوار ابوذر, 43, المحرق, Pitcairn Islands", "الفنيدق", new DateTime(2024, 1, 13, 14, 24, 26, 29, DateTimeKind.Local).AddTicks(6052), "amjd_hazm18@hotmail.com", "(324) 984-2597 x15296", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سمیه, ميدان دستغیب, 94, ازرع, Colombia", "السيب", new DateTime(2024, 1, 13, 6, 29, 39, 481, DateTimeKind.Local).AddTicks(4584), "iynas_slah@gmail.com", "1-373-429-7463", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, 8024, الشوف, Antarctica (the territory South of 60 deg S)", "شمسطار", new DateTime(2024, 1, 13, 6, 26, 27, 41, DateTimeKind.Local).AddTicks(6370), "mna_amjd12@yahoo.com", "1-691-720-1874", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش استاد قریب, 1, منبج, Dominica", "ودمدني", new DateTime(2024, 1, 13, 2, 18, 24, 948, DateTimeKind.Local).AddTicks(4218), "hajr_blal34@gmail.com", "560-769-2168 x37327", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع حقانی, 6857, زلفي, Azerbaijan", "الأبيض", new DateTime(2024, 1, 13, 13, 14, 54, 194, DateTimeKind.Local).AddTicks(806), "hazm.aqyl69@hotmail.com", "1-302-697-3456 x047", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق یادگار امام, ش اجاره دار, 411, مراكش, Vanuatu", "ملوى", new DateTime(2024, 1, 13, 21, 24, 6, 509, DateTimeKind.Local).AddTicks(8733), "arwa.araqy8@hotmail.com", "378-524-4153 x32541", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دیباجی, 605, الباب, Namibia", "كربلاء", new DateTime(2024, 1, 13, 11, 11, 45, 677, DateTimeKind.Local).AddTicks(5755), "farwq20@gmail.com", "946.255.3132", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق ابوذر, 234, ريسوت, Cocos (Keeling) Islands", "البديع", new DateTime(2024, 1, 13, 5, 19, 7, 534, DateTimeKind.Local).AddTicks(9181), "dana_iyhab@hotmail.com", "1-604-845-3095 x351", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آفریقا, ش قدس, 9379, عدن, Pitcairn Islands", "مراكش", new DateTime(2024, 1, 13, 23, 43, 28, 388, DateTimeKind.Local).AddTicks(7471), "rqyh95@hotmail.com", "(295) 952-2680 x3556", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع رسالت, طريق امیرکبیر, 757, طبرق, Isle of Man", "تنومة", new DateTime(2024, 1, 13, 20, 19, 59, 483, DateTimeKind.Local).AddTicks(1834), "fryd.araqy@yahoo.com", "411.399.8354 x3510", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع شهید مطهری, تقاطع راستوان, 22, وادي الدواسر, Croatia", "المالكية", new DateTime(2024, 1, 13, 1, 55, 14, 337, DateTimeKind.Local).AddTicks(722), "sayd.marwf93@gmail.com", "322.843.4498 x46288", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سباری, شارع مالک اشتر, 570, ازرع, Timor-Leste", "قسنطينة", new DateTime(2024, 1, 13, 5, 31, 39, 833, DateTimeKind.Local).AddTicks(9048), "hajr.aashwr50@hotmail.com", "411.394.0509", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش حقانی, 9, تلمسان, Senegal", "مصياف", new DateTime(2024, 1, 13, 19, 29, 14, 160, DateTimeKind.Local).AddTicks(6501), "iynas.aadm@gmail.com", "269.290.8763", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق ابوذر, تقاطع حقانی, 2288, جد حفص, Samoa", "الرملة", new DateTime(2024, 1, 13, 13, 27, 54, 219, DateTimeKind.Local).AddTicks(4141), "aadm33@hotmail.com", "266-958-4443 x79806", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دماوند, 941, صلالة, Mayotte", "سخنين", new DateTime(2024, 1, 13, 2, 36, 41, 222, DateTimeKind.Local).AddTicks(6372), "rym_aarf@gmail.com", "1-879-798-9595 x8566", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع مالک اشتر, 0574, مكة المكرمة, Guyana", "الدوادمي", new DateTime(2024, 1, 13, 13, 52, 39, 297, DateTimeKind.Local).AddTicks(9738), "jabr_fryd97@hotmail.com", "900-597-7064 x018", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان قدس, 2, لوك, Netherlands Antilles", "بعبدا", new DateTime(2024, 1, 13, 5, 0, 8, 922, DateTimeKind.Local).AddTicks(6705), "lma_tarq@yahoo.com", "588.601.3175", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آفریقا, 51, بيت الفقيه, Martinique", "بغداد", new DateTime(2024, 1, 13, 1, 34, 10, 809, DateTimeKind.Local).AddTicks(5611), "rym_tarq82@hotmail.com", "735-682-5707 x09977", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دستغیب, 94, النجف, Niger", "الجفر", new DateTime(2024, 1, 13, 22, 39, 17, 631, DateTimeKind.Local).AddTicks(4303), "hsn.fuad91@hotmail.com", "(424) 734-7098 x0094", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دماوند, 1687, المقدادية, Central African Republic", "طانطان", new DateTime(2024, 1, 13, 7, 8, 31, 136, DateTimeKind.Local).AddTicks(5096), "tarq_hsn@hotmail.com", "1-308-710-7573 x709", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع استاد قریب, 0, بغداد, Vanuatu", "نيالا", new DateTime(2024, 1, 13, 5, 15, 36, 836, DateTimeKind.Local).AddTicks(9194), "salm30@hotmail.com", "347-676-4492 x860", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دماوند, طريق هویزه, 82, رأس لفان, Angola", "بعبدا", new DateTime(2024, 1, 13, 4, 18, 54, 779, DateTimeKind.Local).AddTicks(4926), "sarh39@yahoo.com", "1-591-777-6548 x41021", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دکتر چمران, 6, قنا, French Polynesia", "السيب", new DateTime(2024, 1, 13, 9, 20, 41, 540, DateTimeKind.Local).AddTicks(2668), "rqyh.araqy@gmail.com", "373.218.1125 x840", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار مالک اشتر, شارع راستوان, 9, برج الكيفان, Paraguay", "حلبا", new DateTime(2024, 1, 13, 10, 46, 21, 354, DateTimeKind.Local).AddTicks(9563), "fryd66@gmail.com", "744-292-2063 x724", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آزادی, شارع سمیه, 9, جرسيف, Bahrain", "الجلفة", new DateTime(2024, 1, 13, 18, 19, 31, 165, DateTimeKind.Local).AddTicks(3781), "iyhab_sayd@hotmail.com", "419-248-0296 x4924", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع راستوان, ميدان شهید مطهری, 418, الجوف, Northern Mariana Islands", "جد حفص", new DateTime(2024, 1, 13, 7, 15, 5, 849, DateTimeKind.Local).AddTicks(8513), "aadm90@yahoo.com", "412-331-9910 x8873", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان موحد دانش, 232, بريكة, Comoros", "مقديشو", new DateTime(2024, 1, 13, 17, 42, 36, 174, DateTimeKind.Local).AddTicks(1765), "asamh_araqy6@yahoo.com", "1-907-913-2644", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق استاد قریب, 35, الرمثا, Saint Helena", "جرش", new DateTime(2024, 1, 13, 6, 29, 44, 64, DateTimeKind.Local).AddTicks(6233), "hsn1@gmail.com", "(981) 619-5369 x4624", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دماوند, 408, الحسيمة, Lesotho", "أبو كمال", new DateTime(2024, 1, 13, 19, 39, 48, 998, DateTimeKind.Local).AddTicks(6206), "sarh8@gmail.com", "(599) 380-1900 x527", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آزادی, 63, مصياف, Mexico", "زوارة", new DateTime(2024, 1, 13, 8, 10, 29, 623, DateTimeKind.Local).AddTicks(5068), "aadm_sayd62@hotmail.com", "(809) 404-8957 x67270", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آفریقا, طريق فاطمی, 013, أم درمان, Turkey", "نابل", new DateTime(2024, 1, 13, 21, 20, 19, 588, DateTimeKind.Local).AddTicks(8128), "hazm.hsn2@hotmail.com", "487-614-8742 x15233", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, تقاطع یادگار امام, 100, بنغازي, Zambia", "الشارقة", new DateTime(2024, 1, 13, 2, 5, 24, 253, DateTimeKind.Local).AddTicks(1911), "iynas.asar@gmail.com", "762.854.5694 x81457", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آزادی, 5483, اللاذقية, Falkland Islands (Malvinas)", "التل", new DateTime(2024, 1, 13, 9, 24, 10, 835, DateTimeKind.Local).AddTicks(4503), "arwa.azyz92@gmail.com", "1-299-941-4097", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش یادگار امام, 8, الليث, India", "الجيزة", new DateTime(2024, 1, 13, 2, 22, 1, 22, DateTimeKind.Local).AddTicks(3146), "jmanh.aqyl7@yahoo.com", "834.686.3266 x6487", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, ش مالک اشتر, 70, حجة, Saint Lucia", "مسيعيد", new DateTime(2024, 1, 13, 18, 26, 11, 838, DateTimeKind.Local).AddTicks(1622), "rbya_fryd27@gmail.com", "1-565-521-4892 x792", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دیباجی, دوار دکتر چمران, 6, سطات, Madagascar", "النماص", new DateTime(2024, 1, 13, 3, 10, 4, 400, DateTimeKind.Local).AddTicks(9272), "iyhab_rbya83@hotmail.com", "414-632-8500", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آزادی, شارع موحد دانش, 44, مقديشو, Turkey", "وجدة", new DateTime(2024, 1, 13, 21, 21, 16, 838, DateTimeKind.Local).AddTicks(6638), "hajr_hsn@yahoo.com", "992.589.4856 x022", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش فاطمی, 57, وادي حلفا, Belize", "كسلا", new DateTime(2024, 1, 13, 2, 10, 10, 398, DateTimeKind.Local).AddTicks(1718), "arwa_sayd62@hotmail.com", "766-690-1453 x15200", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار حقانی, 35, السماوة, Uganda", "منح", new DateTime(2024, 1, 13, 6, 25, 13, 343, DateTimeKind.Local).AddTicks(9424), "rym.farwq@gmail.com", "578.840.9487 x5795", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان راستوان, 67, بو سعادة, Luxembourg", "جدة", new DateTime(2024, 1, 13, 9, 49, 38, 983, DateTimeKind.Local).AddTicks(3566), "salm.blal@yahoo.com", "(703) 349-5772", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 6, كركوك, French Polynesia", "الرطبة", new DateTime(2024, 1, 13, 10, 3, 18, 677, DateTimeKind.Local).AddTicks(2290), "mna.slah@hotmail.com", "(380) 745-4919", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش استاد قریب, دوار شهید مطهری, 07, مرزق, Zimbabwe", "كفر الشيخ", new DateTime(2024, 1, 13, 15, 13, 6, 192, DateTimeKind.Local).AddTicks(4991), "sayd_aqyl@gmail.com", "567.383.7183", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان موحد دانش, دوار دکتر چمران, 3842, المحلة الكبرى, South Africa", "ورزازات", new DateTime(2024, 1, 13, 16, 39, 52, 693, DateTimeKind.Local).AddTicks(2317), "frydh.amjd@hotmail.com", "403-532-6716", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع موحد دانش, شارع مالک اشتر, 81, بالهو, Saint Martin", "أم القيوين", new DateTime(2024, 1, 13, 3, 9, 3, 315, DateTimeKind.Local).AddTicks(7911), "fuad.rbya35@yahoo.com", "349.302.9805 x6247", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع اقبال لاهوری, 3, سنجة, Jamaica", "حجة", new DateTime(2024, 1, 13, 7, 44, 48, 329, DateTimeKind.Local).AddTicks(4477), "rna.araqy66@hotmail.com", "1-210-591-0724 x60504", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار هویزه, دوار دستغیب, 48, ودمدني, Palestinian Territory", "جلب", new DateTime(2024, 1, 13, 19, 5, 11, 156, DateTimeKind.Local).AddTicks(9182), "jmanh73@gmail.com", "1-492-236-0646 x421", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع موحد دانش, 87, صفرو, Sao Tome and Principe", "قرية سار", new DateTime(2024, 1, 13, 19, 5, 33, 506, DateTimeKind.Local).AddTicks(2103), "jabr_slah76@gmail.com", "302-469-6612", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان شهید مطهری, 8774, الدامور, Bhutan", "تزنيت", new DateTime(2024, 1, 13, 12, 31, 5, 793, DateTimeKind.Local).AddTicks(8715), "rna_fryd48@hotmail.com", "530-325-3384 x214", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آفریقا, طريق سباری, 21, تبسة, Cook Islands", "هيت", new DateTime(2024, 1, 13, 2, 46, 38, 7, DateTimeKind.Local).AddTicks(7114), "lma_rbya35@yahoo.com", "223.472.0196 x542", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار کارگر شمالی, 47, أسفي, Nigeria", "حائل", new DateTime(2024, 1, 13, 21, 40, 42, 740, DateTimeKind.Local).AddTicks(7852), "sarh37@yahoo.com", "1-928-695-4613", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار فاطمی, 8517, الرمثا, Saint Martin", "وادي حلفا", new DateTime(2024, 1, 13, 16, 19, 53, 993, DateTimeKind.Local).AddTicks(7154), "frydh62@hotmail.com", "1-432-559-7496 x965", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع امیرکبیر, تقاطع موحد دانش, 8496, القصر الكبير, French Guiana", "سوق أهراس", new DateTime(2024, 1, 13, 3, 25, 22, 684, DateTimeKind.Local).AddTicks(6477), "mna14@yahoo.com", "904-688-0664 x868", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اجاره دار, دوار دکتر چمران, 058, وجدة, Montserrat", "حيفا", new DateTime(2024, 1, 13, 19, 24, 32, 23, DateTimeKind.Local).AddTicks(7001), "hajr_aarf50@hotmail.com", "889.486.5124", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دستغیب, ش راستوان, 455, الحسيمة, Bosnia and Herzegovina", "بنغازي", new DateTime(2024, 1, 13, 6, 56, 42, 814, DateTimeKind.Local).AddTicks(2647), "asamh5@hotmail.com", "1-857-925-3352", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع هویزه, 13, العيون, Jersey", "وجدة", new DateTime(2024, 1, 13, 13, 16, 10, 892, DateTimeKind.Local).AddTicks(4107), "frydh_amjd25@hotmail.com", "(872) 802-8746 x05407", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع فاطمی, 3, تنومة, Bahrain", "مدينة الصدر", new DateTime(2024, 1, 13, 6, 33, 50, 11, DateTimeKind.Local).AddTicks(9260), "salm.aarf@gmail.com", "1-539-928-7011", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق اقبال لاهوری, ميدان موحد دانش, 8072, الجفر, Bahrain", "مكة المكرمة", new DateTime(2024, 1, 13, 22, 25, 6, 59, DateTimeKind.Local).AddTicks(4552), "fryd56@yahoo.com", "298-895-0678", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش کارگر شمالی, 4, وزان, Mali", "سرت", new DateTime(2024, 1, 13, 5, 59, 18, 579, DateTimeKind.Local).AddTicks(8170), "sayd.slah91@yahoo.com", "478-800-6696", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دکتر چمران, دوار یادگار امام, 9563, السيب, Virgin Islands, U.S.", "ورقلة", new DateTime(2024, 1, 13, 5, 52, 59, 664, DateTimeKind.Local).AddTicks(8030), "arwa.asamh@hotmail.com", "1-666-798-7272", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, ش واعظی, 91, أسوان, Jamaica", "نجران", new DateTime(2024, 1, 13, 9, 28, 34, 558, DateTimeKind.Local).AddTicks(6811), "iynas94@gmail.com", "(649) 561-4239", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دستغیب, دوار حقانی, 7440, المناقل, Kiribati", "ريان", new DateTime(2024, 1, 13, 20, 33, 18, 230, DateTimeKind.Local).AddTicks(9848), "blal34@hotmail.com", "1-356-770-9510", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع استاد قریب, دوار اقبال لاهوری, 273, العيون, Denmark", "الباحة", new DateTime(2024, 1, 13, 19, 46, 47, 953, DateTimeKind.Local).AddTicks(9711), "jmanh.sayd80@hotmail.com", "1-924-613-6102 x190", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان یادگار امام, 314, نجران, Rwanda", "المرسى", new DateTime(2024, 1, 13, 12, 59, 1, 61, DateTimeKind.Local).AddTicks(4274), "mna0@yahoo.com", "700-205-2837 x302", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع راستوان, 34, بنجرير, Singapore", "تعز", new DateTime(2024, 1, 13, 3, 47, 20, 402, DateTimeKind.Local).AddTicks(2717), "salm_slah93@gmail.com", "1-257-551-6905 x09605", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1979, 4, 11, 4, 51, 8, 141, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 1, 13, 2, 8, 50, 105, DateTimeKind.Local).AddTicks(2882), "رقية حازم", "William Turner", 1, "إيهاب Inc", "5625301546257731677", "Ethiopia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1957, 6, 4, 5, 27, 50, 67, DateTimeKind.Local).AddTicks(2635), new DateTime(2024, 1, 13, 21, 6, 42, 364, DateTimeKind.Local).AddTicks(9263), "ربيع إيهاب", "Myra Simonis", 1, "طارق, عصار and عاشور", "5395903632433384261", "Cocos (Keeling) Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 2, 11, 15, 8, 35, 909, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 1, 13, 9, 51, 15, 879, DateTimeKind.Local).AddTicks(7903), "سعيد إيهاب", "Johathan Nader", 0, "سعيد - هاشم", "5486335178309391862", "Ethiopia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1994, 7, 1, 10, 22, 56, 743, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 1, 13, 9, 31, 30, 969, DateTimeKind.Local).AddTicks(8479), "أروى فريد", "Percy Hayes", 1, "آدم - إيهاب", "7611559267861524101", "Venezuela", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 3, 3, 5, 1, 41, 115, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 1, 13, 21, 23, 14, 387, DateTimeKind.Local).AddTicks(2831), "أمجد سالم", "Verner Kihn", "عارف, فؤاد and زيد", "79346185289504729", "Australia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 2, 14, 21, 45, 28, 433, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 1, 13, 22, 20, 11, 949, DateTimeKind.Local).AddTicks(1155), "فريد طارق", "Russell Altenwerth", "أمجد - أمجد", "3136177270017184609", "Micronesia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 10, 4, 11, 44, 2, 903, DateTimeKind.Local).AddTicks(3077), new DateTime(2024, 1, 13, 11, 1, 2, 603, DateTimeKind.Local).AddTicks(6982), "إيناس حسن", "Lori Blick", "هاشم, فؤاد and عقیل", "6703802566136727984", "Myanmar", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 1, 29, 17, 42, 38, 637, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 1, 13, 7, 19, 40, 887, DateTimeKind.Local).AddTicks(3055), "أمجد حسن", "America Goldner", "عزیز, آدم and سعيد", "1012066464713407016", "Australia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 3, 27, 19, 18, 40, 487, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 1, 13, 2, 46, 12, 657, DateTimeKind.Local).AddTicks(8698), "أمجد عارف", "Heath Greenholt", "آدم, فريد and آدم", "886943177427388658", "Bahamas", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 4, 16, 0, 58, 53, 335, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 1, 13, 21, 16, 41, 878, DateTimeKind.Local).AddTicks(9944), "حسن معروف", "Harry Adams", "عارف - فريد", "4569601249091316460", "Spain", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 3, 19, 21, 52, 53, 80, DateTimeKind.Local).AddTicks(456), new DateTime(2024, 1, 13, 3, 6, 36, 485, DateTimeKind.Local).AddTicks(4748), "زيد بلال", "Blanca Walter", "عراقی - عصار", "2165556225105784838", "Gibraltar", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 12, 21, 8, 43, 16, 442, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 1, 13, 19, 31, 27, 404, DateTimeKind.Local).AddTicks(6897), "رقية عارف", "Joannie Kautzer", 0, "ربيع, عاشور and عزیز", "2484921764549932543", "Singapore", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 9, 10, 22, 35, 51, 807, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 1, 13, 12, 9, 25, 878, DateTimeKind.Local).AddTicks(1204), "عبير عصار", "Jan Stamm", "إيهاب Group", "8365047099349264670", "Barbados", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 6, 4, 0, 7, 54, 706, DateTimeKind.Local).AddTicks(7466), new DateTime(2024, 1, 13, 19, 2, 43, 422, DateTimeKind.Local).AddTicks(3361), "جمانة أسامة", "Lupe Spinka", "طارق - طارق", "7562445059592796491", "Belize", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 2, 25, 2, 45, 50, 952, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 1, 13, 17, 49, 44, 989, DateTimeKind.Local).AddTicks(3744), "أروى هاشم", "Kianna Sanford", 0, "حازم Inc", "7707872797895255996", "Kyrgyz Republic", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 6, 24, 6, 50, 14, 969, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 1, 13, 10, 44, 15, 777, DateTimeKind.Local).AddTicks(574), "فاروق آدم", "Kaya Fahey", "ربيع and Sons", "5785742008114144048", "South Georgia and the South Sandwich Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 6, 26, 4, 38, 48, 410, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 1, 13, 8, 34, 57, 893, DateTimeKind.Local).AddTicks(271), "فاروق صلاح", "Bettye McGlynn", "عصار, عزیز and هاشم", "4431500735288608833", "Jamaica", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 1, 16, 2, 48, 14, 846, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 1, 13, 18, 41, 7, 927, DateTimeKind.Local).AddTicks(9064), "ريم زيد", "Tyrique Thiel", "معروف Group", "8155864038758042485", "Guernsey", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 11, 14, 0, 21, 2, 650, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 1, 13, 19, 4, 11, 73, DateTimeKind.Local).AddTicks(8573), "سارة فاروق", "Royal MacGyver", "سالم, فاروق and بلال", "8732365964885631684", "Greenland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 2, 10, 13, 14, 30, 103, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 1, 13, 1, 56, 13, 272, DateTimeKind.Local).AddTicks(2444), "أروى طارق", "Bryana Reichert", "زيد Group", "3920264118346107121", "Switzerland", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 4, 15, 17, 24, 52, 793, DateTimeKind.Local).AddTicks(2375), new DateTime(2024, 1, 13, 21, 34, 26, 368, DateTimeKind.Local).AddTicks(6773), "جمانة ربيع", "Julian Altenwerth", "عاشور Group", "4574865667896026345", "Italy", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 11, 15, 14, 12, 38, 122, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 1, 13, 23, 56, 57, 373, DateTimeKind.Local).AddTicks(3590), "آية عصار", "Kelley O'Reilly", 0, "حسن and Sons", "5787534655240366243", "France", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 11, 12, 23, 57, 16, 927, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 1, 13, 6, 33, 20, 374, DateTimeKind.Local).AddTicks(3131), "أروى عقیل", "Timmy Zieme", 1, "عقیل - بلال", "4513929664907826004", "Antarctica (the territory South of 60 deg S)", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1964, 7, 15, 8, 0, 23, 264, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 1, 13, 23, 47, 42, 862, DateTimeKind.Local).AddTicks(6834), "سعيد حازم", "Cordelia Crooks", "سالم, آدم and ربيع", "7679971038577600273", "Albania", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1974, 7, 7, 12, 23, 33, 678, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 1, 13, 9, 58, 4, 650, DateTimeKind.Local).AddTicks(3204), "هاجر حسن", "Ursula Carroll", "عصار Inc", "6992739292509353198", "Netherlands Antilles", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 7, 13, 23, 20, 18, 713, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 1, 13, 15, 8, 0, 442, DateTimeKind.Local).AddTicks(7192), "زينب هاشم", "Josiane Dach", "طارق - معروف", "4147419854772481742", "Andorra", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 9, 5, 11, 18, 45, 787, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 1, 13, 18, 18, 55, 848, DateTimeKind.Local).AddTicks(8610), "آية فؤاد", "Ettie Lubowitz", 1, "عارف, عراقی and سعيد", "3246666556618740099", "Panama", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 6, 6, 23, 49, 33, 672, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 1, 13, 11, 21, 30, 362, DateTimeKind.Local).AddTicks(8812), "آدم حسن", "Martine Jacobson", 0, "جابر‌ Inc", "8701060809040849621", "Guinea", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 11, 20, 3, 50, 47, 296, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 1, 13, 13, 22, 39, 131, DateTimeKind.Local).AddTicks(1027), "أمجد عزیز", "Maiya Hyatt", 0, "فريد - آدم", "249512423253378811", "New Zealand", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 8, 3, 21, 24, 54, 512, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 1, 13, 18, 35, 6, 514, DateTimeKind.Local).AddTicks(6227), "حسن سالم", "Maximo Zieme", "آدم, سالم and طارق", "1651256730787611387", "Rwanda", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 5, 10, 3, 1, 20, 744, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 1, 13, 0, 53, 7, 883, DateTimeKind.Local).AddTicks(5160), "عبير فاروق", "Earline Schmitt", 1, "هاشم and Sons", "7588206420193513628", "Saudi Arabia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1964, 8, 23, 10, 43, 42, 920, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 1, 13, 6, 29, 6, 84, DateTimeKind.Local).AddTicks(800), "لمى سعيد", "Lloyd Reynolds", "طارق - جابر‌", "8954910284713293629", "Trinidad and Tobago", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1989, 6, 19, 16, 3, 17, 91, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 1, 13, 10, 27, 56, 33, DateTimeKind.Local).AddTicks(8567), "إيهاب فاروق", "Etha Blick", "أمجد - عصار", "6310496831227004595", "Tunisia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 6, 13, 8, 35, 33, 396, DateTimeKind.Local).AddTicks(2536), new DateTime(2024, 1, 13, 20, 38, 53, 970, DateTimeKind.Local).AddTicks(489), "إيناس إيهاب", "Tavares Luettgen", 0, "آدم and Sons", "8296775349449474059", "Cape Verde", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 5, 23, 23, 42, 51, 47, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 1, 13, 0, 56, 36, 80, DateTimeKind.Local).AddTicks(9469), "زيد معروف", "Ima Blick", 0, "معروف Group", "8276581249255524554", "Ireland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 7, 27, 4, 7, 6, 908, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 1, 14, 0, 32, 13, 131, DateTimeKind.Local).AddTicks(5783), "سارة طارق", "Emmett Watsica", "حسن - عزیز", "4628095326359592644", "Croatia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1992, 5, 9, 8, 35, 10, 754, DateTimeKind.Local).AddTicks(6365), new DateTime(2024, 1, 13, 2, 40, 37, 310, DateTimeKind.Local).AddTicks(5065), "آدم آدم", "Orlo Kovacek", "سعيد - عزیز", "7383839133661367873", "Armenia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 8, 25, 21, 40, 34, 584, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 1, 13, 0, 38, 29, 650, DateTimeKind.Local).AddTicks(6894), "إيهاب فريد", "Queenie McGlynn", 0, "ربيع, جابر‌ and عصار", "2002223555926921337", "Saudi Arabia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 12, 28, 20, 6, 51, 304, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 1, 13, 12, 22, 52, 190, DateTimeKind.Local).AddTicks(6386), "آدم حازم", "Cordie Pouros", 1, "فريد, عقیل and فؤاد", "6269801347482472711", "Papua New Guinea", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 9, 26, 12, 17, 4, 28, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 1, 13, 22, 57, 26, 186, DateTimeKind.Local).AddTicks(1120), "سالم عاشور", "Asa Hauck", 1, "أمجد Inc", "7473441862606903943", "Malta", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 2, 7, 10, 38, 32, 602, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 1, 13, 22, 37, 23, 898, DateTimeKind.Local).AddTicks(2889), "أروى أمجد", "Sigmund Gleichner", "فؤاد - حازم", "8734044518411334319", "Mozambique", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 6, 15, 1, 42, 32, 785, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 1, 13, 23, 19, 3, 702, DateTimeKind.Local).AddTicks(4871), "حازم عارف", "Sonia Williamson", "عقیل, عقیل and أسامة", "4800456903268587889", "Kenya", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 7, 23, 17, 27, 0, 572, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 1, 13, 2, 37, 56, 218, DateTimeKind.Local).AddTicks(610), "زينب فريد", "Jewell Larson", 0, "فاروق - جابر‌", "100210191507577527", "Isle of Man", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 9, 27, 21, 20, 37, 819, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 1, 13, 3, 5, 43, 135, DateTimeKind.Local).AddTicks(54), "أروى أمجد", "Dominic Windler", 0, "أمجد - سالم", "3640686239366794672", "Morocco", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 5, 31, 0, 25, 0, 109, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 1, 13, 0, 44, 24, 299, DateTimeKind.Local).AddTicks(627), "آدم سالم", "Maegan Beahan", "هاشم Group", "2184702798080040283", "Malawi", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1963, 6, 18, 23, 13, 44, 146, DateTimeKind.Local).AddTicks(1316), new DateTime(2024, 1, 13, 16, 13, 50, 681, DateTimeKind.Local).AddTicks(649), "زينب فريد", "Johnny Runolfsdottir", "عقیل - عزیز", "5746858448338300084", "South Africa", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 3, 23, 12, 56, 34, 547, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 1, 13, 13, 21, 36, 250, DateTimeKind.Local).AddTicks(9422), "إيهاب ربيع", "Veronica Batz", "صلاح Group", "2446489679055788143", "Tanzania", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 9, 17, 10, 22, 26, 370, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 1, 13, 20, 11, 1, 692, DateTimeKind.Local).AddTicks(1498), "ربيع معروف", "Paige Ruecker", 0, "حازم, إيهاب and فريد", "1049802600579614208", "Swaziland", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 9, 22, 16, 10, 12, 594, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 1, 13, 9, 57, 21, 128, DateTimeKind.Local).AddTicks(3825), "سالم بلال", "Valerie Zemlak", 0, "آدم LLC", "3312050257259081487", "Pitcairn Islands", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 5, 9, 22, 42, 39, 785, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 1, 13, 14, 38, 34, 653, DateTimeKind.Local).AddTicks(7504), "آدم صلاح", "Otis Larson", 1, "سالم - فاروق", "6577180156141090880", "Italy", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 4, 19, 7, 55, 44, 549, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 1, 13, 15, 51, 25, 949, DateTimeKind.Local).AddTicks(7848), "بلال حازم", "Sylvia Hamill", 1, "أسامة - عصار", "13840963811862528", "Tajikistan", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 9, 22, 22, 34, 52, 327, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 1, 13, 23, 55, 10, 218, DateTimeKind.Local).AddTicks(9115), "فريدة فريد", "Lydia Schmidt", 1, "عصار Inc", "4208791514949670344", "Saudi Arabia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 8, 7, 13, 28, 46, 819, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 1, 13, 17, 30, 17, 592, DateTimeKind.Local).AddTicks(9923), "إيناس صلاح", "Erin Johns", "عزیز - جابر‌", "3143577175708175341", "Cyprus", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 3, 10, 6, 45, 56, 615, DateTimeKind.Local).AddTicks(604), new DateTime(2024, 1, 13, 6, 23, 1, 821, DateTimeKind.Local).AddTicks(3627), "سعيد هاشم", "Modesta Boyer", 1, "عاشور - عصار", "7924493622599386573", "South Georgia and the South Sandwich Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 1, 23, 11, 34, 15, 826, DateTimeKind.Local).AddTicks(9002), new DateTime(2024, 1, 13, 3, 56, 56, 345, DateTimeKind.Local).AddTicks(8297), "طارق عصار", "Kassandra Beahan", 0, "ربيع, حازم and إيهاب", "2715466872042946612", "Israel", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1960, 11, 11, 14, 31, 47, 218, DateTimeKind.Local).AddTicks(9257), new DateTime(2024, 1, 13, 15, 3, 7, 398, DateTimeKind.Local).AddTicks(2874), "أمجد سعيد", "Alberto Hudson", "سالم, فؤاد and أمجد", "962467798960144139", "Tuvalu", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 9, 16, 18, 39, 35, 311, DateTimeKind.Local).AddTicks(7893), new DateTime(2024, 1, 13, 10, 31, 56, 266, DateTimeKind.Local).AddTicks(5800), "بلال طارق", "Forrest Stroman", 0, "فاروق - فؤاد", "5717121070537508912", "Guinea-Bissau", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1989, 7, 23, 0, 16, 23, 45, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 1, 13, 10, 36, 46, 237, DateTimeKind.Local).AddTicks(5295), "جابر‌ صلاح", "Bernice Jaskolski", 0, "فريد LLC", "8902356184787763548", "Portugal", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 9, 16, 11, 2, 50, 178, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 1, 13, 23, 30, 47, 823, DateTimeKind.Local).AddTicks(4971), "هاجر حسن", "Magnolia Boyle", 0, "عراقی Inc", "2395331981019639299", "Colombia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1997, 1, 24, 7, 22, 43, 649, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 1, 13, 17, 57, 8, 520, DateTimeKind.Local).AddTicks(1303), "رقية سعيد", "Tyson Ledner", "سالم - إيهاب", "6901076044657921032", "Slovenia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 11, 27, 11, 42, 39, 363, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 1, 13, 10, 26, 29, 29, DateTimeKind.Local).AddTicks(4074), "فاروق عاشور", "Damien Klein", 1, "صلاح, آدم and عصار", "544733978208008275", "Sao Tome and Principe", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 9, 22, 13, 43, 43, 813, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 1, 13, 8, 12, 46, 73, DateTimeKind.Local).AddTicks(621), "شيماء حسن", "Enos Kunde", 0, "عزیز, طارق and أمجد", "2045074613971366595", "Iceland", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 8, 19, 17, 27, 31, 566, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 1, 13, 13, 26, 27, 956, DateTimeKind.Local).AddTicks(7249), "لمى هاشم", "Karolann Rogahn", 1, "ربيع - عراقی", "8712715260956494475", "Saint Kitts and Nevis", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 7, 14, 0, 46, 46, 684, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 1, 13, 14, 39, 20, 353, DateTimeKind.Local).AddTicks(7436), "فاروق زيد", "Bert Mosciski", "أمجد - عاشور", "4162893883906161886", "Sierra Leone", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 8, 24, 15, 52, 48, 60, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 1, 13, 12, 36, 24, 255, DateTimeKind.Local).AddTicks(2479), "آدم حازم", "Napoleon Kozey", "بلال, عقیل and طارق", "2732014894122887494", "Botswana", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1976, 6, 15, 0, 0, 10, 357, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 1, 13, 12, 56, 3, 484, DateTimeKind.Local).AddTicks(5532), "صلاح سالم", "Eric Fadel", "حسن Group", "153238353227035503", "Turks and Caicos Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 8, 27, 16, 10, 56, 131, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 1, 13, 9, 35, 49, 251, DateTimeKind.Local).AddTicks(3594), "هاجر أمجد", "Billie Bartoletti", "عراقی - بلال", "2049872286397336157", "New Zealand", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 9, 25, 9, 32, 46, 212, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 1, 14, 0, 30, 45, 308, DateTimeKind.Local).AddTicks(1431), "بلال عارف", "Gerard Powlowski", "عزیز and Sons", "1293477865214792027", "Aruba", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 7, 7, 14, 19, 53, 545, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 1, 13, 23, 50, 57, 677, DateTimeKind.Local).AddTicks(3589), "أروى أمجد", "Audra O'Conner", 0, "بلال LLC", "8519538635751659623", "Saint Pierre and Miquelon", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1963, 12, 14, 16, 41, 20, 274, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 1, 13, 15, 29, 9, 828, DateTimeKind.Local).AddTicks(7944), "آدم عراقی", "Demetrius Haag", 0, "فؤاد, عارف and حسن", "3266136391081843636", "Trinidad and Tobago", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 8, 29, 22, 37, 0, 498, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 1, 13, 22, 35, 39, 806, DateTimeKind.Local).AddTicks(8556), "فريد معروف", "Jacques Runolfsdottir", "فريد LLC", "2039121620982592361", "Maldives", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 5, 26, 10, 40, 19, 778, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 1, 13, 23, 14, 0, 656, DateTimeKind.Local).AddTicks(9790), "هاجر إيهاب", "Kacey Wisoky", "معروف Inc", "9146046519696728536", "Mauritania", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 6, 2, 22, 11, 26, 216, DateTimeKind.Local).AddTicks(7940), new DateTime(2024, 1, 13, 22, 23, 1, 374, DateTimeKind.Local).AddTicks(5236), "ربيع عصار", "Keshaun Dickinson", 0, "أسامة, بلال and طارق", "4354428013183814109", "Mauritius", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 2, 11, 13, 42, 57, 977, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 1, 13, 6, 20, 45, 732, DateTimeKind.Local).AddTicks(1798), "ربيع طارق", "Kelley Stokes", "عزیز, حازم and طارق", "3383418328520564336", "India", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1974, 10, 13, 7, 22, 51, 525, DateTimeKind.Local).AddTicks(7362), new DateTime(2024, 1, 13, 20, 21, 51, 178, DateTimeKind.Local).AddTicks(566), "إيناس بلال", "Zackary Waelchi", 0, "سعيد Group", "955789111159307057", "Greenland", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 1, 31, 11, 31, 41, 740, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 1, 13, 15, 11, 14, 768, DateTimeKind.Local).AddTicks(9396), "طارق فريد", "Aisha Klein", 0, "جابر‌ - هاشم", "5814757917677930319", "Norway", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 8, 28, 22, 24, 19, 77, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 1, 13, 16, 43, 15, 558, DateTimeKind.Local).AddTicks(5842), "زيد معروف", "Jed Abshire", "حازم and Sons", "3678527136619348854", "Kenya", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 4, 1, 16, 44, 30, 265, DateTimeKind.Local).AddTicks(3263), new DateTime(2024, 1, 13, 11, 24, 14, 596, DateTimeKind.Local).AddTicks(8652), "أسامة إيهاب", "Demetris Moen", "فريد - هاشم", "45875579040131091", "Indonesia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 10, 2, 12, 37, 28, 66, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 1, 13, 21, 10, 6, 665, DateTimeKind.Local).AddTicks(9971), "ريم فاروق", "Felicita Boehm", "عصار, سالم and صلاح", "9080860864837007340", "Georgia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1984, 12, 30, 9, 29, 53, 633, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 1, 13, 18, 5, 12, 853, DateTimeKind.Local).AddTicks(9829), "ريم عقیل", "Wendell Gaylord", "فريد - إيهاب", "2044771300523049005", "El Salvador", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 3, 8, 17, 5, 6, 413, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 1, 13, 14, 41, 5, 552, DateTimeKind.Local).AddTicks(3134), "فاروق صلاح", "Emory Ryan", 0, "معروف, بلال and حسن", "722747833051478819", "Jamaica", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 11, 22, 6, 5, 25, 819, DateTimeKind.Local).AddTicks(6119), new DateTime(2024, 1, 13, 0, 58, 20, 412, DateTimeKind.Local).AddTicks(6011), "لمى سالم", "Kavon Schultz", "معروف, سالم and بلال", "3823782195702811034", "Venezuela", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1984, 7, 30, 21, 44, 48, 817, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 13, 7, 31, 18, 479, DateTimeKind.Local).AddTicks(7336), "منى حسن", "Jess Lynch", "زيد, حسن and فريد", "607544238433020386", "Georgia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 7, 4, 19, 17, 51, 61, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 1, 13, 19, 1, 23, 366, DateTimeKind.Local).AddTicks(1857), "إيهاب عصار", "Randi Hayes", "عراقی and Sons", "6614798553342794790", "Brunei Darussalam", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 9, 19, 6, 3, 35, 58, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 1, 13, 4, 52, 20, 413, DateTimeKind.Local).AddTicks(6799), "منى سعيد", "Cassie Heidenreich", "حسن and Sons", "3429077359894034355", "United Arab Emirates", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1982, 11, 22, 18, 35, 1, 123, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 1, 13, 23, 1, 12, 794, DateTimeKind.Local).AddTicks(619), "أمجد آدم", "Lillian Larkin", 1, "حازم - عاشور", "7390394826019893403", "British Indian Ocean Territory (Chagos Archipelago)", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 10, 22, 11, 9, 27, 896, DateTimeKind.Local).AddTicks(257), new DateTime(2024, 1, 13, 16, 0, 37, 996, DateTimeKind.Local).AddTicks(6305), "رقية عارف", "Keon Krajcik", 0, "بلال - عصار", "722819126826228227", "Russian Federation", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 11, 30, 1, 30, 31, 265, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 1, 13, 14, 26, 52, 459, DateTimeKind.Local).AddTicks(7423), "حازم أمجد", "Jordan Paucek", "عصار and Sons", "3186054869502905067", "Liechtenstein", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 2, 2, 10, 43, 53, 349, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 1, 13, 10, 30, 4, 785, DateTimeKind.Local).AddTicks(4739), "جابر‌ عراقی", "Joanny Johnson", "جابر‌ and Sons", "5674204618281311189", "Portugal", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1987, 6, 4, 15, 9, 58, 510, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 1, 13, 5, 4, 29, 573, DateTimeKind.Local).AddTicks(8495), "هاجر حازم", "Quinton Franecki", "ربيع - فريد", "7908916367904053631", "Estonia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1969, 7, 18, 5, 35, 0, 418, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 1, 13, 3, 3, 5, 825, DateTimeKind.Local).AddTicks(4326), "آية عقیل", "Marianna Crooks", "فاروق - حازم", "2280120540618065989", "Norfolk Island", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 2, 4, 11, 47, 38, 660, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 1, 13, 11, 45, 40, 304, DateTimeKind.Local).AddTicks(9342), "صلاح عزیز", "Al Marks", "فاروق, عصار and بلال", "1697905198344363304", "Mauritania", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 6, 26, 0, 11, 15, 345, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 1, 13, 5, 44, 9, 601, DateTimeKind.Local).AddTicks(4439), "إيهاب عصار", "Gussie Torphy", "أمجد - حازم", "3353066428111473459", "Guam", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 4, 8, 23, 55, 39, 608, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 1, 13, 12, 49, 57, 385, DateTimeKind.Local).AddTicks(7306), "فريد زيد", "Destinee Mertz", "آدم LLC", "4919401230768728703", "Macao", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1999, 10, 8, 12, 42, 17, 509, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 1, 13, 8, 50, 7, 157, DateTimeKind.Local).AddTicks(3629), "فؤاد آدم", "Ken Howe", "آدم - عصار", "7861631623747118805", "Spain", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 3, 18, 13, 43, 23, 286, DateTimeKind.Local).AddTicks(7956), new DateTime(2024, 1, 13, 1, 44, 15, 673, DateTimeKind.Local).AddTicks(913), "حسن ربيع", "Presley Nicolas", "بلال - فؤاد", "2698621112058847162", "Benin", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 5, 22, 12, 11, 27, 401, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 13, 22, 36, 49, 904, DateTimeKind.Local).AddTicks(8276), "لمى عزیز", "Beryl Rempel", "عصار, سعيد and طارق", "6236409387049535988", "Taiwan", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 12, 13, 13, 12, 30, 42, DateTimeKind.Local).AddTicks(1514), new DateTime(2024, 1, 13, 5, 23, 30, 293, DateTimeKind.Local).AddTicks(5232), "إيهاب سعيد", "Leonel Zieme", "هاشم LLC", "8270492328076501310", "Switzerland", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 11, 22, 6, 12, 18, 457, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 1, 13, 7, 38, 21, 718, DateTimeKind.Local).AddTicks(3715), "حازم بلال", "Victoria Bradtke", "عقیل, ربيع and طارق", "6358638233480916641", "Burkina Faso", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 2, 28, 23, 32, 19, 97, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 1, 13, 6, 29, 4, 930, DateTimeKind.Local).AddTicks(9756), "حسن إيهاب", "Christina Tromp", 0, "ربيع - آدم", "1653984513098211342", "Grenada", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 4, 3, 8, 59, 59, 55, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 1, 13, 21, 51, 25, 856, DateTimeKind.Local).AddTicks(7167), "فؤاد فريد", "Cristal Larkin", 1, "عارف, فريد and عارف", "2424650040445889879", "Timor-Leste", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1999, 4, 15, 18, 57, 16, 798, DateTimeKind.Local).AddTicks(816), new DateTime(2024, 1, 13, 16, 25, 45, 978, DateTimeKind.Local).AddTicks(7975), "منى فريد", "Izabella Beier", "آدم Inc", "2384954068637204524", "Libyan Arab Jamahiriya", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 5, 18, 6, 0, 56, 665, DateTimeKind.Local).AddTicks(2639), new DateTime(2024, 1, 13, 11, 49, 33, 599, DateTimeKind.Local).AddTicks(1409), "جمانة حسن", "Sister Schowalter", "عزیز - معروف", "4984942829307824107", "Tuvalu", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 1, 4, 14, 15, 7, 329, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 1, 13, 4, 2, 34, 221, DateTimeKind.Local).AddTicks(7459), "فؤاد ربيع", "Arthur Olson", 0, "إيهاب - حازم", "4542259830908218022", "Iceland", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 12, 1, 3, 20, 47, 965, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 1, 13, 21, 39, 57, 993, DateTimeKind.Local).AddTicks(1813), "Jannie Grant", 1, "عاشور LLC", "3424854120738358140", "United States Minor Outlying Islands", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 1, 29, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(3043), new DateTime(2024, 1, 13, 4, 44, 7, 289, DateTimeKind.Local).AddTicks(2430), "سالم سالم", "Desmond Friesen", 0, "معروف, فؤاد and جابر‌", "599446534777254671", "Bhutan", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1980, 10, 19, 8, 0, 14, 93, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 1, 13, 23, 0, 32, 419, DateTimeKind.Local).AddTicks(2457), "رقية إيهاب", "Quentin Hermann", "أمجد, فريد and عزیز", "4682017896578517047", "Democratic People's Republic of Korea", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 2, 23, 14, 32, 59, 728, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 1, 13, 2, 40, 33, 95, DateTimeKind.Local).AddTicks(7576), "منى حسن", "Logan Keeling", "حسن - عاشور", "4512776222116281773", "Israel", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1995, 12, 23, 0, 31, 49, 226, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 1, 13, 14, 52, 11, 881, DateTimeKind.Local).AddTicks(8822), "عبير أمجد", "Jermain Bayer", 0, "طارق, عزیز and معروف", "9128768749794168734", "Saint Kitts and Nevis", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 2, 28, 19, 1, 0, 946, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 1, 13, 6, 36, 2, 439, DateTimeKind.Local).AddTicks(3676), "رقية فؤاد", "Jayde Kreiger", "عقیل LLC", "4681302211881223772", "Bahamas", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 5, 31, 16, 44, 31, 876, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 1, 13, 3, 44, 22, 457, DateTimeKind.Local).AddTicks(5251), "سارة هاشم", "Deshawn Streich", "آدم, عزیز and ربيع", "3908139926402048139", "Bangladesh", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 9, 16, 9, 8, 6, 21, DateTimeKind.Local).AddTicks(4527), new DateTime(2024, 1, 13, 9, 22, 11, 200, DateTimeKind.Local).AddTicks(8443), "زينب إيهاب", "Laney Bashirian", 0, "طارق Inc", "124810889830625391", "Germany", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 7, 19, 13, 25, 11, 896, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 1, 13, 17, 23, 55, 284, DateTimeKind.Local).AddTicks(6850), "حسن معروف", "Reid Russel", "حسن, صلاح and سعيد", "5604623827750052027", "India", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 9, 21, 11, 45, 58, 398, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 1, 13, 1, 58, 26, 219, DateTimeKind.Local).AddTicks(1094), "إيناس أسامة", "Carlee Shields", "ربيع, عاشور and حازم", "2265570578263926812", "Moldova", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 1, 5, 12, 16, 53, 988, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 1, 13, 6, 56, 0, 28, DateTimeKind.Local).AddTicks(7998), "بلال عراقی", "Madalyn Lynch", "زيد - عراقی", "9026509152332900678", "Serbia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 2, 5, 19, 20, 4, 764, DateTimeKind.Local).AddTicks(8069), new DateTime(2024, 1, 13, 8, 14, 49, 573, DateTimeKind.Local).AddTicks(9418), "أروى فاروق", "Frida Gulgowski", 0, "فاروق, طارق and حازم", "4151309542264227091", "Denmark", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1956, 9, 7, 5, 54, 56, 501, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 1, 13, 15, 57, 32, 231, DateTimeKind.Local).AddTicks(2626), "فاروق معروف", "Orville Feest", "عزیز Group", "3495538279957587713", "Ecuador", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 7, 30, 6, 12, 4, 799, DateTimeKind.Local).AddTicks(367), new DateTime(2024, 1, 13, 14, 43, 22, 287, DateTimeKind.Local).AddTicks(235), "فاروق فؤاد", "Ettie Kerluke", "أسامة - إيهاب", "2931037664292059930", "San Marino", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1989, 6, 13, 6, 16, 34, 37, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 1, 13, 5, 1, 11, 384, DateTimeKind.Local).AddTicks(2647), "شيماء صلاح", "Laney Fay", "فؤاد - سالم", "1201565073943510629", "Croatia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 2, 1, 11, 18, 21, 479, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 1, 13, 21, 11, 34, 91, DateTimeKind.Local).AddTicks(933), "فاطمة عاشور", "Gust Langosh", 0, "هاشم, فاروق and أسامة", "7518007007759014397", "Cocos (Keeling) Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1958, 10, 12, 18, 58, 37, 708, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 1, 14, 0, 30, 22, 664, DateTimeKind.Local).AddTicks(345), "عبير جابر‌", "Curtis Rowe", 1, "أسامة - عقیل", "1163245238668641294", "Montserrat", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 11, 19, 19, 37, 6, 839, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 1, 13, 9, 18, 5, 697, DateTimeKind.Local).AddTicks(3282), "جمانة هاشم", "Maggie Hammes", 1, "آدم LLC", "1376819970403949532", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 10, 25, 1, 53, 36, 980, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 1, 13, 18, 4, 42, 622, DateTimeKind.Local).AddTicks(6080), "فريدة حسن", "Enrico Dicki", "عارف, عقیل and حسن", "4423769270970488707", "American Samoa", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 1, 27, 8, 42, 40, 552, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 1, 13, 14, 53, 5, 294, DateTimeKind.Local).AddTicks(1530), "سارة عصار", "Kristofer Gerhold", 0, "عاشور - عاشور", "4791111254216445383", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 1, 1, 17, 41, 58, 152, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 1, 13, 6, 19, 50, 660, DateTimeKind.Local).AddTicks(8327), "إيهاب سعيد", "Rozella Block", 1, "جابر‌ - عاشور", "6948549352627093316", "Vietnam", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 2, 17, 6, 51, 30, 431, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 1, 13, 17, 15, 32, 880, DateTimeKind.Local).AddTicks(7508), "إيهاب أسامة", "Ana Maggio", "عقیل - طارق", "1932908762703903000", "Serbia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 11, 28, 12, 46, 45, 852, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 1, 13, 7, 44, 51, 746, DateTimeKind.Local).AddTicks(8039), "أروى معروف", "Santina Shanahan", "فريد, ربيع and حازم", "8811107893145235323", "New Zealand", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 7, 12, 21, 16, 2, 556, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 1, 13, 6, 46, 13, 211, DateTimeKind.Local).AddTicks(5742), "فريد سالم", "Emerald Fisher", "فاروق LLC", "8402433754811488382", "Bahrain", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 3, 13, 23, 18, 11, 248, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 1, 13, 5, 21, 42, 732, DateTimeKind.Local).AddTicks(5630), "جابر‌ عقیل", "Marisa Fay", "فؤاد - فاروق", "2678977557271767316", "Finland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 8, 28, 13, 47, 43, 392, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 1, 13, 19, 45, 43, 377, DateTimeKind.Local).AddTicks(8316), "إيهاب عارف", "Jovani Mills", 1, "إيهاب - أسامة", "3802699646696061462", "Anguilla", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 7, 25, 23, 40, 44, 473, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 1, 13, 15, 52, 39, 23, DateTimeKind.Local).AddTicks(9911), "حسن زيد", "Hulda Terry", "آدم and Sons", "5065440412683130300", "Malta", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 9, 6, 6, 32, 29, 654, DateTimeKind.Local).AddTicks(3511), new DateTime(2024, 1, 13, 6, 53, 49, 806, DateTimeKind.Local).AddTicks(6603), "جمانة سالم", "Allie Boyle", "عاشور, ربيع and إيهاب", "715655774030575314", "Peru", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 9, 23, 0, 50, 20, 540, DateTimeKind.Local).AddTicks(9614), new DateTime(2024, 1, 13, 13, 55, 19, 852, DateTimeKind.Local).AddTicks(6276), "رقية عزیز", "Zechariah Paucek", "أسامة and Sons", "8245066304934836221", "Rwanda", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 12, 1, 12, 45, 29, 743, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 1, 13, 2, 29, 8, 739, DateTimeKind.Local).AddTicks(5737), "إيهاب حسن", "Orlando Windler", 1, "عاشور, عارف and حازم", "6707182929821406913", "Congo", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 3, 15, 18, 13, 7, 532, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 13, 3, 47, 34, 302, DateTimeKind.Local).AddTicks(2205), "لمى سالم", "Alene Swaniawski", 1, "سالم, إيهاب and عارف", "7477590540444717571", "Oman", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1984, 5, 6, 6, 35, 6, 935, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 1, 13, 13, 44, 6, 623, DateTimeKind.Local).AddTicks(9135), "إيهاب طارق", "Pasquale Durgan", "بلال Group", "8906961052977618379", "Ireland", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 10, 31, 10, 26, 52, 841, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 1, 13, 5, 9, 4, 230, DateTimeKind.Local).AddTicks(3193), "سالم عقیل", "Kody Langosh", "عراقی - أسامة", "8413221729901389226", "Pitcairn Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 3, 4, 16, 20, 26, 992, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 1, 13, 4, 43, 24, 526, DateTimeKind.Local).AddTicks(1823), "رنا معروف", "Aniya Heidenreich", "سعيد, سعيد and عاشور", "2829924515202436894", "Taiwan", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 10, 30, 9, 16, 45, 755, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 1, 13, 2, 33, 14, 697, DateTimeKind.Local).AddTicks(3976), "لمى معروف", "Adrianna Little", "معروف LLC", "1646342221828857904", "Somalia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 5, 13, 18, 5, 29, 150, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 1, 13, 9, 47, 1, 253, DateTimeKind.Local).AddTicks(2360), "فريد حسن", "Retha Hahn", "آدم LLC", "1921915313892242963", "Central African Republic", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 7, 22, 21, 41, 31, 707, DateTimeKind.Local).AddTicks(2393), new DateTime(2024, 1, 13, 2, 27, 43, 736, DateTimeKind.Local).AddTicks(3569), "جابر‌ أمجد", "Gregorio Hudson", 0, "جابر‌ - طارق", "7031033051248482721", "Djibouti", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1991, 11, 21, 1, 22, 13, 657, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 1, 13, 22, 53, 9, 166, DateTimeKind.Local).AddTicks(2521), "شيماء عراقی", "Mark Wilderman", "سالم - فريد", "5217239442737758246", "Sri Lanka", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 7, 23, 11, 18, 33, 950, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 1, 13, 3, 53, 55, 839, DateTimeKind.Local).AddTicks(3123), "سالم آدم", "Ross Dare", 0, "فؤاد - سعيد", "8694082081317943162", "Andorra", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 7, 26, 4, 44, 30, 267, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 1, 13, 6, 1, 11, 415, DateTimeKind.Local).AddTicks(3814), "جابر‌ أسامة", "Skyla Bogisich", "آدم LLC", "335162850233923854", "Egypt", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 1, 27, 13, 55, 57, 521, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 1, 13, 2, 8, 1, 576, DateTimeKind.Local).AddTicks(8014), "سارة سالم", "Ken Bednar", 0, "عاشور Inc", "8800754560180363333", "Sao Tome and Principe", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1976, 2, 22, 5, 10, 41, 116, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 1, 13, 20, 17, 42, 135, DateTimeKind.Local).AddTicks(1838), "رنا عارف", "Jonas Ortiz", 1, "عقیل, عاشور and عارف", "1264462525571464948", "Mauritania", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 3, 16, 15, 35, 59, 523, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 1, 13, 11, 17, 17, 278, DateTimeKind.Local).AddTicks(167), "سارة أسامة", "Bobbie Pacocha", "صلاح Inc", "4969455282494063686", "United States of America", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1981, 10, 16, 22, 14, 40, 305, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 1, 14, 0, 30, 9, 786, DateTimeKind.Local).AddTicks(440), "زيد عصار", "Jayson Schmidt", "فريد and Sons", "6806664963840566793", "Samoa", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 8, 2, 15, 19, 0, 271, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 1, 13, 10, 32, 12, 839, DateTimeKind.Local).AddTicks(3598), "حازم عزیز", "Roxane Gibson", "طارق - حسن", "5620025216750850447", "Saudi Arabia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 10, 15, 7, 23, 37, 201, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 1, 13, 21, 43, 19, 179, DateTimeKind.Local).AddTicks(4157), "فريد حسن", "Vanessa Treutel", 0, "ربيع LLC", "1666814647990277314", "Zimbabwe", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 1, 31, 8, 34, 20, 512, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 1, 13, 11, 11, 37, 902, DateTimeKind.Local).AddTicks(6384), "طارق إيهاب", "Rosamond Littel", 0, "عارف - فؤاد", "6245377501074367457", "Greenland", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 9, 1, 7, 44, 2, 445, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 1, 13, 23, 54, 44, 63, DateTimeKind.Local).AddTicks(2515), "رقية آدم", "Halie Schulist", 0, "عقیل Group", "2713683405207239038", "Georgia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 5, 8, 19, 19, 55, 518, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 1, 13, 6, 42, 51, 480, DateTimeKind.Local).AddTicks(4390), "حازم عراقی", "Lincoln Johnson", "صلاح - صلاح", "6690534523800055459", "Puerto Rico", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 8, 9, 6, 6, 6, 936, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 1, 13, 12, 8, 12, 616, DateTimeKind.Local).AddTicks(4039), "آدم عزیز", "Emmanuel O'Keefe", 1, "حازم and Sons", "3108403843626856479", "Burkina Faso", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 5, 17, 10, 27, 54, 732, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 1, 13, 18, 57, 46, 774, DateTimeKind.Local).AddTicks(3340), "لمى بلال", "Myrl Rice", "صلاح, أمجد and حسن", "3226977285254643651", "Thailand", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1974, 7, 19, 18, 11, 11, 756, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 1, 13, 8, 39, 37, 56, DateTimeKind.Local).AddTicks(7840), "هاجر صلاح", "Rod Bahringer", 0, "فؤاد Inc", "4572351926628849131", "Lithuania", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 4, 2, 17, 52, 0, 420, DateTimeKind.Local).AddTicks(6193), new DateTime(2024, 1, 13, 0, 50, 57, 776, DateTimeKind.Local).AddTicks(8913), "رنا جابر‌", "Mae Abbott", "حازم and Sons", "1584755909514387119", "Norfolk Island", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 7, 16, 13, 56, 58, 482, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 1, 13, 1, 29, 1, 429, DateTimeKind.Local).AddTicks(2086), "أروى إيهاب", "Jamarcus Cormier", 0, "إيهاب - آدم", "3136668524708529659", "Rwanda", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1978, 7, 6, 4, 17, 7, 643, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 1, 13, 17, 20, 57, 111, DateTimeKind.Local).AddTicks(7455), "صلاح عقیل", "Erica Bergnaum", "فؤاد, بلال and ربيع", "5427566215137477641", "Indonesia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 1, 18, 17, 21, 50, 421, DateTimeKind.Local).AddTicks(6303), new DateTime(2024, 1, 13, 18, 55, 19, 977, DateTimeKind.Local).AddTicks(4859), "ريم عقیل", "Monserrat Sporer", "فؤاد Inc", "3316317410042251044", "Pakistan", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 9, 4, 5, 30, 17, 646, DateTimeKind.Local).AddTicks(6113), new DateTime(2024, 1, 13, 19, 54, 22, 946, DateTimeKind.Local).AddTicks(1835), "رنا حسن", "Gayle Schaefer", "سعيد - إيهاب", "2505686812772976019", "Kiribati", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1955, 10, 1, 1, 30, 23, 294, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 1, 13, 4, 0, 5, 600, DateTimeKind.Local).AddTicks(9886), "فريد عاشور", "April Gulgowski", "سالم, بلال and فريد", "8945153136355945696", "Marshall Islands", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1974, 1, 12, 19, 37, 37, 646, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 1, 13, 0, 37, 7, 375, DateTimeKind.Local).AddTicks(4950), "آية صلاح", "Kendall Zemlak", 1, "سعيد - عصار", "296374584724454717", "Mali", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 8, 11, 10, 1, 40, 914, DateTimeKind.Local).AddTicks(1234), new DateTime(2024, 1, 13, 15, 41, 21, 126, DateTimeKind.Local).AddTicks(3954), "دانا ربيع", "Graciela Okuneva", "عاشور, فؤاد and إيهاب", "9149188102042668300", "Puerto Rico", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 1, 6, 12, 29, 48, 607, DateTimeKind.Local).AddTicks(840), new DateTime(2024, 1, 13, 21, 59, 9, 69, DateTimeKind.Local).AddTicks(9580), "سالم فؤاد", "Kira Schmeler", "فؤاد, عقیل and فريد", "396236006754123771", "Timor-Leste", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 11, 12, 17, 25, 12, 57, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 1, 13, 15, 3, 12, 737, DateTimeKind.Local).AddTicks(7976), "رنا أمجد", "Ramiro Heaney", 1, "جابر‌, عارف and طارق", "8119263822679947013", "Ghana", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 2, 17, 17, 58, 5, 716, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 1, 13, 21, 44, 7, 861, DateTimeKind.Local).AddTicks(9529), "إيناس آدم", "Arianna Miller", "فؤاد, فاروق and عزیز", "6087421011660793931", "Somalia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 10, 30, 9, 24, 1, 55, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 1, 13, 1, 18, 48, 87, DateTimeKind.Local).AddTicks(2761), "أسامة عصار", "Lewis Bosco", "عقیل - هاشم", "3901808301069152229", "United Arab Emirates", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 2, 8, 12, 23, 49, 197, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 1, 13, 12, 11, 45, 31, DateTimeKind.Local).AddTicks(2370), "ريم بلال", "Eldora Welch", "بلال - ربيع", "2188683198824097728", "Puerto Rico", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1986, 11, 28, 4, 12, 12, 77, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 1, 13, 19, 12, 58, 302, DateTimeKind.Local).AddTicks(1992), "عبير حسن", "Stella Beahan", "فؤاد, بلال and ربيع", "928247307149834613", "Ghana", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 4, 22, 7, 26, 13, 920, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 1, 13, 20, 19, 49, 428, DateTimeKind.Local).AddTicks(5901), "فاطمة بلال", "Clark Wuckert", 1, "ربيع Inc", "9023514674800295100", "Cayman Islands", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 12, 4, 15, 30, 19, 457, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 1, 14, 0, 8, 44, 105, DateTimeKind.Local).AddTicks(7947), "فؤاد عاشور", "Deondre Schroeder", 0, "عاشور - فريد", "2824923062588116018", "Republic of Korea", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1988, 8, 7, 9, 18, 7, 401, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 1, 13, 4, 32, 24, 731, DateTimeKind.Local).AddTicks(7649), "منى عزیز", "Avery West", 0, "أمجد - بلال", "2615437195916163176", "South Georgia and the South Sandwich Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1974, 3, 16, 19, 32, 13, 695, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 1, 13, 22, 22, 38, 545, DateTimeKind.Local).AddTicks(8787), "عبير زيد", "Kayley Macejkovic", 1, "418202984639904040", "Marshall Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 4, 30, 5, 32, 3, 503, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 1, 13, 18, 28, 55, 959, DateTimeKind.Local).AddTicks(460), "ربيع هاشم", "Trystan Abshire", "عراقی - أسامة", "4558107239704580", "Moldova", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 12, 2, 9, 4, 55, 947, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 1, 13, 8, 23, 42, 359, DateTimeKind.Local).AddTicks(5549), "دانا عارف", "Mya Ratke", 1, "سعيد, سالم and زيد", "8246013530640864522", "Argentina", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1995, 5, 30, 14, 26, 14, 271, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 1, 13, 13, 52, 59, 891, DateTimeKind.Local).AddTicks(9425), "أمجد فريد", "Mohammad Dicki", 1, "عراقی - جابر‌", "7382994841249961329", "Eritrea", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 6, 26, 15, 2, 6, 392, DateTimeKind.Local).AddTicks(5038), new DateTime(2024, 1, 13, 10, 43, 39, 846, DateTimeKind.Local).AddTicks(832), "إيهاب معروف", "Kiera Christiansen", 0, "صلاح and Sons", "6416957820524130554", "Indonesia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 1, 5, 3, 10, 50, 978, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 1, 13, 15, 11, 46, 687, DateTimeKind.Local).AddTicks(4477), "صلاح إيهاب", "Danny Lang", "عارف Group", "6327430020986625240", "Saudi Arabia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 9, 21, 11, 50, 15, 344, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 1, 14, 0, 16, 26, 251, DateTimeKind.Local).AddTicks(5979), "دانا حازم", "Alanna Tromp", "آدم - فؤاد", "9113739363349024104", "Iran", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 8, 25, 9, 4, 46, 635, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 1, 13, 9, 23, 30, 699, DateTimeKind.Local).AddTicks(5073), "شيماء عصار", "Hanna Mayert", 1, "عصار Inc", "4756373926150425909", "Singapore", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1963, 2, 15, 15, 19, 26, 651, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 1, 13, 23, 48, 23, 435, DateTimeKind.Local).AddTicks(3642), "منى فاروق", "Marion Jacobs", "هاشم, طارق and آدم", "5496428403033885122", "Senegal", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1974, 2, 28, 5, 43, 11, 39, DateTimeKind.Local).AddTicks(7687), new DateTime(2024, 1, 13, 3, 40, 59, 710, DateTimeKind.Local).AddTicks(1821), "هاجر عراقی", "Blake Heller", "عزیز - فريد", "1939778745464733139", "Seychelles", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 10, 16, 8, 0, 39, 746, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 1, 13, 21, 31, 16, 54, DateTimeKind.Local).AddTicks(9497), "آية زيد", "Darren Rowe", "ربيع Inc", "2458946549586575213", "Sweden", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 2, 9, 14, 6, 26, 260, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 1, 13, 19, 34, 57, 144, DateTimeKind.Local).AddTicks(2020), "فؤاد معروف", "Jimmie Moen", 1, "عراقی, حازم and معروف", "5881199960681291959", "British Indian Ocean Territory (Chagos Archipelago)", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 12, 19, 16, 27, 29, 52, DateTimeKind.Local).AddTicks(2379), new DateTime(2024, 1, 13, 6, 50, 22, 30, DateTimeKind.Local).AddTicks(4775), "رنا سعيد", "Kaya Tromp", "أسامة, أمجد and عقیل", "7775016210268056127", "South Africa", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 12, 15, 21, 58, 6, 600, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 1, 13, 5, 57, 1, 542, DateTimeKind.Local).AddTicks(7552), "فاطمة عاشور", "Marianna Purdy", 1, "سالم - عارف", "5237340885599736446", "Cameroon", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 8, 8, 19, 47, 23, 934, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 1, 13, 4, 53, 4, 491, DateTimeKind.Local).AddTicks(4334), "هاجر عراقی", "Vernon Ondricka", "عقیل - أسامة", "2225622129493271840", "Grenada", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1960, 12, 23, 16, 17, 38, 215, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 1, 13, 1, 2, 53, 685, DateTimeKind.Local).AddTicks(3450), "ريم سالم", "Wayne Gutmann", 0, "بلال, بلال and فؤاد", "6235936012839001595", "Indonesia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 12, 8, 5, 56, 46, 177, DateTimeKind.Local).AddTicks(7266), new DateTime(2024, 1, 13, 22, 28, 40, 127, DateTimeKind.Local).AddTicks(1908), "آدم عراقی", "Louvenia Nader", 0, "عقیل, فريد and أسامة", "4324889341104803697", "Sierra Leone", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 12, 28, 14, 6, 15, 667, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 1, 13, 6, 16, 22, 316, DateTimeKind.Local).AddTicks(5281), "فاطمة هاشم", "Chadrick Ward", 0, "سعيد Group", "5292892425876303500", "New Zealand", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1985, 9, 26, 20, 8, 52, 298, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 1, 13, 1, 29, 25, 792, DateTimeKind.Local).AddTicks(7438), "لمى عارف", "Max Zboncak", "فريد Inc", "5840318397910578546", "Aruba", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 2, 7, 23, 15, 21, 199, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 1, 13, 15, 37, 35, 234, DateTimeKind.Local).AddTicks(8775), "أسامة صلاح", "Clare Casper", 1, "حسن Group", "5399706013852754750", "Angola", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 1, 25, 6, 23, 36, 610, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 1, 13, 23, 58, 56, 704, DateTimeKind.Local).AddTicks(8591), "أسامة حازم", "Constance Gusikowski", 1, "زيد - حسن", "5956789069056220720", "New Zealand", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 2, 6, 22, 0, 48, 239, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 1, 13, 19, 4, 7, 327, DateTimeKind.Local).AddTicks(4600), "سالم فؤاد", "Margot Bergnaum", "أمجد, سعيد and آدم", "6384523777382623982", "Faroe Islands", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1997, 5, 30, 17, 18, 50, 249, DateTimeKind.Local).AddTicks(6986), new DateTime(2024, 1, 13, 3, 32, 47, 847, DateTimeKind.Local).AddTicks(2955), "إيناس جابر‌", "Vance Welch", 0, "حسن LLC", "7631389338789174311", "Portugal", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 9, 16, 16, 36, 30, 565, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 1, 13, 21, 3, 38, 149, DateTimeKind.Local).AddTicks(3995), "بلال زيد", "Mittie Sanford", 1, "معروف Group", "8375322910236360963", "Montenegro", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1986, 5, 30, 10, 26, 47, 217, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 1, 13, 20, 2, 35, 637, DateTimeKind.Local).AddTicks(9991), "فؤاد بلال", "Stevie Moen", "حازم Group", "5605562316099625597", "Brazil", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 3, 14, 6, 26, 2, 397, DateTimeKind.Local).AddTicks(1836), new DateTime(2024, 1, 13, 3, 11, 14, 112, DateTimeKind.Local).AddTicks(2937), "صلاح صلاح", "Kelley Hintz", "عزیز Group", "4325729434065466140", "Sri Lanka", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 8, 22, 2, 26, 9, 908, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 1, 13, 23, 44, 25, 458, DateTimeKind.Local).AddTicks(872), "آدم ربيع", "Ignatius Daugherty", 1, "عراقی - فاروق", "7229044267475740635", "Mali", 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "TreatmentsHistory");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "MedicalFiles");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "FinancialInfos");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Examinations");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Attachments");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 090, قريات, Andorra", "هيت", new DateTime(2024, 1, 11, 0, 1, 35, 304, DateTimeKind.Local).AddTicks(3092), "frydh33@hotmail.com", "(551) 487-6110" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, دوار آفریقا, 5, الراشيدية, Kiribati", "سنجة", new DateTime(2024, 1, 11, 17, 42, 19, 700, DateTimeKind.Local).AddTicks(8096), "rym_aadm@gmail.com", "(565) 468-2062 x49246" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, ش هویزه, 35, القنيطرة, Guyana", "جالكاسيو", new DateTime(2024, 1, 11, 1, 34, 46, 133, DateTimeKind.Local).AddTicks(2429), "sayd15@gmail.com", "687.335.6062" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, 666, صور, Belize", "بقيق", new DateTime(2024, 1, 11, 18, 31, 38, 206, DateTimeKind.Local).AddTicks(9548), "dana24@hotmail.com", "1-729-303-6988" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, 39, كسلا, Cyprus", "الجزائر", new DateTime(2024, 1, 11, 15, 7, 47, 666, DateTimeKind.Local).AddTicks(6097), "salm_tarq61@yahoo.com", "886-334-7733 x69150" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, دوار کارگر شمالی, 242, الكسوة, Vanuatu", "بيت حانون", new DateTime(2024, 1, 11, 6, 55, 59, 314, DateTimeKind.Local).AddTicks(9973), "rbya_marwf19@hotmail.com", "(620) 979-2115" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, 6, القيصومة, Vietnam", "سكاكا", new DateTime(2024, 1, 10, 23, 36, 4, 25, DateTimeKind.Local).AddTicks(842), "sayd.fryd@hotmail.com", "583-317-2842" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق استاد قریب, 4156, العيينة, Timor-Leste", "حارم", new DateTime(2024, 1, 11, 16, 37, 23, 269, DateTimeKind.Local).AddTicks(548), "mna.farwq45@yahoo.com", "1-966-711-2103 x7720" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, تقاطع سباری, 54, أم درمان, Guadeloupe", "الإسماعيلية", new DateTime(2024, 1, 11, 3, 59, 34, 85, DateTimeKind.Local).AddTicks(8763), "fuad21@hotmail.com", "(814) 348-1652 x99601" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, دوار حقانی, 4, يريم, Haiti", "المزاحمية", new DateTime(2024, 1, 11, 20, 22, 14, 372, DateTimeKind.Local).AddTicks(3221), "hazm.rbya@gmail.com", "623.402.6207" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 09, القرداحة, Lesotho", "الأغواط", new DateTime(2024, 1, 11, 18, 36, 5, 132, DateTimeKind.Local).AddTicks(4141), "slah41@gmail.com", "1-423-543-1643 x3284" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, شارع اقبال لاهوری, 1021, كسلا, Aruba", "سحاب", new DateTime(2024, 1, 11, 3, 10, 13, 387, DateTimeKind.Local).AddTicks(6225), "fuad11@gmail.com", "(388) 667-3993" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع مالک اشتر, 3605, الإسكندرية, United Kingdom", "الشلف", new DateTime(2024, 1, 10, 20, 55, 11, 331, DateTimeKind.Local).AddTicks(9149), "jmanh_aarf59@gmail.com", "1-485-291-4023 x8687" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, شارع فاطمی, 9654, مدينة حمد, Hong Kong", "مستغانم", new DateTime(2024, 1, 11, 20, 11, 32, 142, DateTimeKind.Local).AddTicks(3826), "farwq.hsn78@yahoo.com", "1-804-413-7840" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, ش اجاره دار, 22, الجبيل, Saint Barthelemy", "سترة", new DateTime(2024, 1, 11, 8, 0, 6, 154, DateTimeKind.Local).AddTicks(9129), "rna.aqyl31@yahoo.com", "(997) 692-4794" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, ش هویزه, 03, اللاذقية, Honduras", "أوبوك", new DateTime(2024, 1, 10, 22, 50, 27, 548, DateTimeKind.Local).AddTicks(57), "shymaa47@yahoo.com", "225.211.3490" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, شارع آذربایجان, 882, دمشق, Cuba", "دير القمر", new DateTime(2024, 1, 10, 21, 49, 1, 363, DateTimeKind.Local).AddTicks(2734), "shymaa_tarq@hotmail.com", "1-306-799-5927" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اقبال لاهوری, تقاطع آفریقا, 2, أم القيوين, Tokelau", "مسيعيد", new DateTime(2024, 1, 11, 7, 35, 27, 918, DateTimeKind.Local).AddTicks(7064), "abyr54@hotmail.com", "(303) 379-0556" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, 3228, خور أنجار, Republic of Korea", "السبت اولاد النمة", new DateTime(2024, 1, 11, 14, 1, 50, 111, DateTimeKind.Local).AddTicks(860), "jmanh_marwf36@yahoo.com", "1-477-357-3082 x21633" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, دوار قدس, 7642, تدمر, Aruba", "أسفي", new DateTime(2024, 1, 11, 17, 37, 23, 698, DateTimeKind.Local).AddTicks(320), "amjd.fryd97@yahoo.com", "251.604.6025 x84714" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, طريق آذربایجان, 5, بالهو, Zambia", "جرسيف", new DateTime(2024, 1, 11, 7, 54, 6, 406, DateTimeKind.Local).AddTicks(724), "zyd.asar32@yahoo.com", "764-633-2974 x23536" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, 417, بدبد, Slovenia", "مدينة حمد", new DateTime(2024, 1, 11, 9, 15, 52, 103, DateTimeKind.Local).AddTicks(8046), "slah43@gmail.com", "956-863-4080" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, 30, برشيد, Bolivia", "خور فكان", new DateTime(2024, 1, 11, 19, 54, 1, 278, DateTimeKind.Local).AddTicks(5879), "jabr.aashwr@gmail.com", "929.423.6778 x240" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 23, عقوبة, Brazil", "بيروت", new DateTime(2024, 1, 11, 17, 15, 45, 736, DateTimeKind.Local).AddTicks(2947), "abyr84@gmail.com", "526-274-4657" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, 71, عنيزة, Afghanistan", "ضبا", new DateTime(2024, 1, 11, 2, 40, 39, 77, DateTimeKind.Local).AddTicks(2975), "aayh_aashwr27@gmail.com", "(468) 471-7343 x90626" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, دوار استاد قریب, 474, صحار, Vietnam", "صلخد", new DateTime(2024, 1, 11, 1, 6, 20, 147, DateTimeKind.Local).AddTicks(5314), "jabr.aashwr34@hotmail.com", "1-610-903-4942" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, ش آفریقا, 81, السيب, Northern Mariana Islands", "بيت الفقيه", new DateTime(2024, 1, 11, 12, 3, 11, 472, DateTimeKind.Local).AddTicks(4399), "jmanh74@gmail.com", "(988) 316-2041 x1572" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, ميدان رسالت, 34, بنغازي, Hungary", "السيب", new DateTime(2024, 1, 10, 21, 27, 55, 763, DateTimeKind.Local).AddTicks(2353), "abyr_hazm@yahoo.com", "574.561.7650 x0487" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, شارع سمیه, 2165, الفحيص, Tanzania", "قابس", new DateTime(2024, 1, 11, 18, 19, 44, 119, DateTimeKind.Local).AddTicks(8911), "jabr.zyd@hotmail.com", "(903) 258-0561 x17133" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 4, أريحا, Cuba", "صافيتا", new DateTime(2024, 1, 10, 21, 4, 50, 293, DateTimeKind.Local).AddTicks(3878), "sayd52@hotmail.com", "745-405-2317 x426" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 955, تدمر, Slovenia", "قلقيلية", new DateTime(2024, 1, 10, 23, 3, 34, 602, DateTimeKind.Local).AddTicks(1428), "asamh41@gmail.com", "1-347-544-8265" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, دوار شهید مطهری, 0241, صير بني ياس, Jordan", "راس العين", new DateTime(2024, 1, 11, 4, 9, 33, 101, DateTimeKind.Local).AddTicks(4453), "dana_jabr@hotmail.com", "498-513-2043" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش رسالت, 4, المراوعة, Kyrgyz Republic", "كسلا", new DateTime(2024, 1, 11, 17, 36, 8, 912, DateTimeKind.Local).AddTicks(7088), "hazm_marwf29@gmail.com", "467-639-2874 x154" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, 9, الإسماعيلية, Mayotte", "تدمر", new DateTime(2024, 1, 11, 12, 37, 18, 171, DateTimeKind.Local).AddTicks(1823), "sayd99@hotmail.com", "(559) 538-0162 x3734" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, 2, أوبوك, Heard Island and McDonald Islands", "عجلون", new DateTime(2024, 1, 11, 9, 18, 16, 569, DateTimeKind.Local).AddTicks(4328), "fryd_tarq@hotmail.com", "907-341-1389 x0574" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, 70, براقي, Belize", "دخيل", new DateTime(2024, 1, 11, 2, 2, 7, 597, DateTimeKind.Local).AddTicks(6027), "rqyh_tarq@gmail.com", "641-609-8859" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, 613, تعز, Niue", "رأس لفان", new DateTime(2024, 1, 11, 13, 35, 15, 723, DateTimeKind.Local).AddTicks(444), "zynb.fryd22@gmail.com", "767.638.9200 x7057" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, طريق اجاره دار, 95, السليمانية, Nauru", "ضبا", new DateTime(2024, 1, 11, 15, 3, 51, 206, DateTimeKind.Local).AddTicks(8702), "hajr90@yahoo.com", "840.840.5641 x510" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, 26, ريان, Vanuatu", "أريحا", new DateTime(2024, 1, 11, 19, 0, 41, 896, DateTimeKind.Local).AddTicks(1857), "dana.tarq5@gmail.com", "673-771-6523 x9637" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, 0, الشامية, Thailand", "مصياف", new DateTime(2024, 1, 11, 19, 0, 31, 910, DateTimeKind.Local).AddTicks(9688), "fuad_asar@yahoo.com", "202.992.2366 x0188" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, شارع امیرکبیر, 0, التل, Comoros", "جسر الشغور", new DateTime(2024, 1, 11, 8, 0, 36, 177, DateTimeKind.Local).AddTicks(3540), "rna.slah@hotmail.com", "953.578.6768" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 602, بربرة, South Africa", "عجمان", new DateTime(2024, 1, 10, 20, 57, 0, 880, DateTimeKind.Local).AddTicks(278), "frydh.aqyl38@yahoo.com", "729.622.6022" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, طريق آفریقا, 63, الدور, Barbados", "الأزرق", new DateTime(2024, 1, 11, 18, 3, 34, 943, DateTimeKind.Local).AddTicks(5877), "fatmh_azyz@gmail.com", "1-452-320-7535" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دیباجی, 971, الأبيض, Poland", "أم القيوين", new DateTime(2024, 1, 11, 0, 55, 49, 277, DateTimeKind.Local).AddTicks(8229), "lma_fuad73@gmail.com", "836.996.3371 x016" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, دوار قدس, 5, مدحاء, Belgium", "الجش", new DateTime(2024, 1, 11, 1, 23, 10, 467, DateTimeKind.Local).AddTicks(4716), "rna_azyz48@yahoo.com", "357.938.9820 x796" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, ميدان دستغیب, 41, الديوانية, Honduras", "خفجي", new DateTime(2024, 1, 11, 2, 41, 16, 325, DateTimeKind.Local).AddTicks(6598), "fuad.slah@gmail.com", "(203) 311-5360" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 7268, أعزاز, Lithuania", "الجديدة", new DateTime(2024, 1, 11, 11, 7, 33, 427, DateTimeKind.Local).AddTicks(1094), "fuad.rbya@gmail.com", "1-965-774-6363" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, ميدان یادگار امام, 10, الدوحة, Namibia", "صافيتا", new DateTime(2024, 1, 11, 2, 17, 12, 494, DateTimeKind.Local).AddTicks(4254), "slah.aqyl79@hotmail.com", "1-469-519-3910 x832" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 5509, طيبة الامام, Uzbekistan", "كفر كنا", new DateTime(2024, 1, 11, 12, 28, 49, 362, DateTimeKind.Local).AddTicks(5492), "mna43@yahoo.com", "487.800.8045" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, 03, ورزازات, United Kingdom", "بوكى", new DateTime(2024, 1, 11, 11, 46, 58, 217, DateTimeKind.Local).AddTicks(4193), "hajr_salm@hotmail.com", "(481) 261-9324 x0927" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, دوار ابوذر, 63, رأس لفان, Lithuania", "نزوى", new DateTime(2024, 1, 11, 10, 53, 50, 661, DateTimeKind.Local).AddTicks(1102), "mna13@gmail.com", "1-660-758-8953 x80489" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, شارع آفریقا, 4216, صير بني ياس, Cyprus", "زوارة", new DateTime(2024, 1, 11, 20, 24, 53, 450, DateTimeKind.Local).AddTicks(3714), "fuad.fuad@hotmail.com", "944.244.9198 x175" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, ميدان حقانی, 1075, الرفاع الغربي, Puerto Rico", "المقدادية", new DateTime(2024, 1, 11, 6, 40, 51, 195, DateTimeKind.Local).AddTicks(9879), "dana16@hotmail.com", "834.337.1215 x0628" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, 34, الخميسات, Virgin Islands, U.S.", "وزان", new DateTime(2024, 1, 11, 2, 10, 20, 783, DateTimeKind.Local).AddTicks(2818), "slah_araqy@yahoo.com", "863.922.9508" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, ش واعظی, 967, أبو كبير, Maldives", "كركوك", new DateTime(2024, 1, 11, 2, 45, 39, 553, DateTimeKind.Local).AddTicks(3880), "rna97@yahoo.com", "914.531.6386 x2230" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, 59, السليمانية, San Marino", "فاس", new DateTime(2024, 1, 11, 17, 16, 24, 168, DateTimeKind.Local).AddTicks(7791), "fryd81@hotmail.com", "(232) 932-6305 x7151" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, 03, صير بني ياس, Macedonia", "الموصل", new DateTime(2024, 1, 11, 11, 37, 19, 119, DateTimeKind.Local).AddTicks(7142), "frydh87@hotmail.com", "788-930-1666 x216" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, ميدان ابوذر, 538, خان شيخون, Ghana", "الوادي", new DateTime(2024, 1, 10, 21, 27, 17, 975, DateTimeKind.Local).AddTicks(3731), "salm_fryd@yahoo.com", "672.506.2703 x500" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 4, طبرق, Svalbard & Jan Mayen Islands", "المحمدية", new DateTime(2024, 1, 11, 4, 31, 0, 823, DateTimeKind.Local).AddTicks(5047), "rqyh84@yahoo.com", "(482) 237-4157 x9217" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, دوار دماوند, 59, مسيعيد, Tunisia", "النبك", new DateTime(2024, 1, 11, 11, 38, 57, 115, DateTimeKind.Local).AddTicks(8140), "mna_iyhab@gmail.com", "1-976-249-3801 x651" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, 7506, البغدادي, Philippines", "طرعان", new DateTime(2024, 1, 11, 17, 9, 18, 846, DateTimeKind.Local).AddTicks(5364), "fatmh_salm18@yahoo.com", "295-757-3922 x3476" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, 49, النماص, Madagascar", "القنفذة", new DateTime(2024, 1, 11, 3, 32, 20, 415, DateTimeKind.Local).AddTicks(5112), "asamh.azyz@yahoo.com", "(699) 798-6908 x72777" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, ميدان رسالت, 5, جدة, Mauritania", "القاهرة", new DateTime(2024, 1, 11, 5, 29, 33, 79, DateTimeKind.Local).AddTicks(790), "aadm.marwf28@yahoo.com", "816.784.5779" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, طريق یادگار امام, 20, العيون, Norfolk Island", "الجيزة", new DateTime(2024, 1, 11, 15, 23, 43, 162, DateTimeKind.Local).AddTicks(7219), "hsn67@hotmail.com", "665.839.4087 x944" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 6322, ابها, Nauru", "أسيلا", new DateTime(2024, 1, 10, 22, 15, 44, 858, DateTimeKind.Local).AddTicks(5246), "fatmh41@hotmail.com", "(584) 388-2844 x7742" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, 3460, غليلة, Japan", "السيب", new DateTime(2024, 1, 11, 11, 53, 36, 255, DateTimeKind.Local).AddTicks(2107), "dana.marwf87@yahoo.com", "1-526-433-6928" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, ش دستغیب, 7210, الشوف, Saint Martin", "الشلف", new DateTime(2024, 1, 11, 15, 57, 46, 646, DateTimeKind.Local).AddTicks(4964), "amjd.iyhab@yahoo.com", "212-930-3412 x341" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, تقاطع واعظی, 7, حمص, Ethiopia", "سرت", new DateTime(2024, 1, 11, 8, 44, 33, 592, DateTimeKind.Local).AddTicks(4168), "jmanh.marwf54@yahoo.com", "535.608.5758" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, تقاطع کارگر شمالی, 163, دمشق, Australia", "بركان", new DateTime(2024, 1, 11, 17, 22, 16, 489, DateTimeKind.Local).AddTicks(989), "fryd.aadm79@yahoo.com", "(786) 281-0310 x35545" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, 986, بركان, Dominica", "خور فكان", new DateTime(2024, 1, 11, 3, 32, 46, 249, DateTimeKind.Local).AddTicks(4800), "iynas52@hotmail.com", "(590) 378-8268 x7249" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, 7, الطينطان, Cambodia", "جرابلس", new DateTime(2024, 1, 11, 6, 33, 34, 744, DateTimeKind.Local).AddTicks(5528), "slah46@gmail.com", "654.685.8256 x192" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, 794, أدم, Burundi", "عين البيضاء", new DateTime(2024, 1, 11, 9, 4, 49, 472, DateTimeKind.Local).AddTicks(3750), "sarh_farwq31@gmail.com", "871.361.9304 x2940" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, تقاطع امیرکبیر, 6, خان يونس, Saint Pierre and Miquelon", "قريات", new DateTime(2024, 1, 11, 13, 17, 13, 16, DateTimeKind.Local).AddTicks(5437), "salm.araqy@hotmail.com", "1-556-717-3287 x4675" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, ميدان آذربایجان, 9611, حقل, Tajikistan", "الغردقة", new DateTime(2024, 1, 11, 2, 13, 23, 933, DateTimeKind.Local).AddTicks(5), "sayd84@gmail.com", "661.576.4716 x638" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, 84, بوتلميت, Iceland", "أخميم", new DateTime(2024, 1, 11, 5, 3, 17, 860, DateTimeKind.Local).AddTicks(1543), "mna_fuad@yahoo.com", "879.679.3250 x1151" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, طريق موحد دانش, 40, خريبة السوق, Sweden", "جالكاسيو", new DateTime(2024, 1, 11, 19, 14, 23, 769, DateTimeKind.Local).AddTicks(2584), "shymaa_fuad96@yahoo.com", "298-297-4710" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, دوار واعظی, 5, بن عروس, Ukraine", "دير البلح", new DateTime(2024, 1, 11, 6, 2, 1, 376, DateTimeKind.Local).AddTicks(3179), "iyhab_aashwr23@hotmail.com", "348-865-7123 x5275" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, 2, بهلا, Isle of Man", "المراوعة", new DateTime(2024, 1, 11, 16, 58, 22, 957, DateTimeKind.Local).AddTicks(6190), "rbya81@hotmail.com", "1-530-307-0500" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 252, أسيوط, Ethiopia", "قسنطينة", new DateTime(2024, 1, 11, 6, 55, 4, 336, DateTimeKind.Local).AddTicks(971), "fuad_aashwr@gmail.com", "1-436-715-2697 x376" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, 781, خور أنجار, El Salvador", "القحطانية", new DateTime(2024, 1, 11, 14, 31, 54, 777, DateTimeKind.Local).AddTicks(4759), "abyr.araqy61@hotmail.com", "415-260-2589 x183" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, 8, السفيرة, Bhutan", "جحفية", new DateTime(2024, 1, 11, 0, 45, 30, 153, DateTimeKind.Local).AddTicks(3190), "hajr.aarf72@yahoo.com", "1-823-427-0276" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, 013, الخبر, Macedonia", "بريدة‏", new DateTime(2024, 1, 11, 10, 16, 50, 722, DateTimeKind.Local).AddTicks(6197), "lma.sayd@gmail.com", "1-911-541-0101" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, 9, رام الله, Luxembourg", "نزوى", new DateTime(2024, 1, 11, 11, 55, 36, 7, DateTimeKind.Local).AddTicks(160), "farwq79@yahoo.com", "(512) 858-3324 x22200" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 21, صور, Brunei Darussalam", "المالكية", new DateTime(2024, 1, 11, 19, 15, 26, 75, DateTimeKind.Local).AddTicks(6002), "slah.aashwr49@gmail.com", "562-819-8791" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, ميدان اجاره دار, 87, أسيلا, Azerbaijan", "السلط", new DateTime(2024, 1, 11, 14, 57, 23, 587, DateTimeKind.Local).AddTicks(5399), "hsn43@gmail.com", "(699) 230-9519 x8682" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, 090, القطيفة, Tajikistan", "السليمانية", new DateTime(2024, 1, 11, 13, 44, 37, 402, DateTimeKind.Local).AddTicks(9893), "fuad14@yahoo.com", "703.738.4895 x08186" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اقبال لاهوری, ميدان ابوذر, 765, عمران, Indonesia", "النماص", new DateTime(2024, 1, 11, 1, 7, 20, 730, DateTimeKind.Local).AddTicks(9819), "zynb.jabr66@hotmail.com", "(927) 862-2511 x45817" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 404, باقة الغربية, Mayotte", "جحفية", new DateTime(2024, 1, 11, 20, 14, 19, 564, DateTimeKind.Local).AddTicks(4816), "zynb92@gmail.com", "446.595.0149" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 5556, السقيلبية, Algeria", "حجة", new DateTime(2024, 1, 11, 6, 32, 10, 898, DateTimeKind.Local).AddTicks(1352), "asamh_aarf35@hotmail.com", "1-668-234-0707 x585" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, 4, المجمعة, San Marino", "ادلب", new DateTime(2024, 1, 11, 9, 38, 9, 457, DateTimeKind.Local).AddTicks(5966), "shymaa.amjd60@hotmail.com", "793.997.9917" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, ش آزادی, 8443, تزنيت, Malaysia", "زليطن", new DateTime(2024, 1, 11, 14, 25, 55, 607, DateTimeKind.Local).AddTicks(283), "zyd_jabr@yahoo.com", "868.606.9441 x0330" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق راستوان, 0, كفر الشيخ, Mayotte", "بوكى", new DateTime(2024, 1, 11, 7, 47, 19, 822, DateTimeKind.Local).AddTicks(6652), "aadm.farwq@gmail.com", "704-391-2200 x9146" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, دوار هویزه, 789, اولاد التايمة, Lesotho", "العيون", new DateTime(2024, 1, 11, 1, 55, 4, 998, DateTimeKind.Local).AddTicks(6238), "tarq84@yahoo.com", "1-953-588-0966" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, دوار استاد قریب, 735, قصرين, Timor-Leste", "أرتا", new DateTime(2024, 1, 11, 3, 46, 3, 263, DateTimeKind.Local).AddTicks(8965), "amjd6@yahoo.com", "626-971-8513 x51002" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, 044, القائم, Tuvalu", "بني ملال", new DateTime(2024, 1, 11, 2, 30, 15, 773, DateTimeKind.Local).AddTicks(2615), "aayh.fryd@hotmail.com", "(615) 351-9880 x42210" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, ش دماوند, 286, خريبة السوق, Niue", "طرابلس", new DateTime(2024, 1, 11, 3, 41, 31, 545, DateTimeKind.Local).AddTicks(4678), "zyd68@gmail.com", "(854) 420-8300" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, 7, قنا, Slovakia (Slovak Republic)", "الناصرية", new DateTime(2024, 1, 10, 22, 1, 13, 109, DateTimeKind.Local).AddTicks(3859), "jmanh88@hotmail.com", "781-875-3642 x3826" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, تقاطع دیباجی, 348, حفر الباطن, Rwanda", "سترة", new DateTime(2024, 1, 11, 5, 27, 5, 867, DateTimeKind.Local).AddTicks(8268), "jmanh_fryd28@hotmail.com", "769.718.6457 x32948" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, ش ابوذر, 2540, دخيل, Malta", "طرعان", new DateTime(2024, 1, 11, 19, 22, 50, 368, DateTimeKind.Local).AddTicks(3648), "shymaa.aadm15@yahoo.com", "452.791.0248" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, 548, صفاقس, Comoros", "جبلة", new DateTime(2024, 1, 11, 20, 23, 26, 788, DateTimeKind.Local).AddTicks(7833), "rna55@gmail.com", "992.469.9511 x74175" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, 724, أبو ظبي, Palestinian Territory", "المقدادية", new DateTime(2024, 1, 11, 2, 21, 21, 323, DateTimeKind.Local).AddTicks(4815), "aayh_araqy30@yahoo.com", "(438) 636-4014 x2089" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, ش مالک اشتر, 8407, حلفا الجديدة, Philippines", "المراوعة", new DateTime(2024, 1, 11, 18, 55, 19, 944, DateTimeKind.Local).AddTicks(63), "sayd.hsn@hotmail.com", "1-402-403-0559 x84462" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, شارع موحد دانش, 589, النجف, Madagascar", "شندي", new DateTime(2024, 1, 11, 3, 21, 54, 742, DateTimeKind.Local).AddTicks(6827), "salm.asamh@yahoo.com", "(420) 866-5781 x632" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, 78, سطيف, Comoros", "بريدة‏", new DateTime(2024, 1, 11, 20, 34, 6, 316, DateTimeKind.Local).AddTicks(9195), "hazm45@gmail.com", "431.350.1738 x071" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, شارع کارگر شمالی, 5, دمازين, Madagascar", "البغدادي", new DateTime(2024, 1, 11, 15, 57, 33, 296, DateTimeKind.Local).AddTicks(2694), "rbya.amjd@yahoo.com", "412-485-4317 x83341" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, شارع سمیه, 338, طيبة الامام, Martinique", "سكيكدة", new DateTime(2024, 1, 11, 13, 57, 59, 82, DateTimeKind.Local).AddTicks(2495), "farwq.fuad@gmail.com", "641.563.3187 x3377" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, طريق دکتر چمران, 107, صيدا, Western Sahara", "الرقة", new DateTime(2024, 1, 11, 1, 26, 49, 135, DateTimeKind.Local).AddTicks(9607), "hajr_amjd@yahoo.com", "(805) 727-8144 x721" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, 6636, معرة النعمان, Fiji", "الباب", new DateTime(2024, 1, 11, 1, 37, 32, 500, DateTimeKind.Local).AddTicks(1293), "asamh.salm@yahoo.com", "(687) 552-7348" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, طريق دماوند, 672, النبطية, Djibouti", "بو سعادة", new DateTime(2024, 1, 10, 22, 1, 23, 908, DateTimeKind.Local).AddTicks(7695), "rym36@yahoo.com", "(704) 758-5760 x553" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, طريق سمیه, 3668, سرت, Georgia", "صرمان", new DateTime(2024, 1, 10, 21, 1, 54, 951, DateTimeKind.Local).AddTicks(8329), "rym_fuad86@gmail.com", "722.753.1444 x37230" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 2100, الضعين, Gambia", "كيهيدي", new DateTime(2024, 1, 11, 14, 42, 6, 158, DateTimeKind.Local).AddTicks(3426), "fryd_fryd73@yahoo.com", "1-976-274-3486" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, 8769, الجديدة, Hungary", "دهوك", new DateTime(2024, 1, 11, 4, 57, 31, 537, DateTimeKind.Local).AddTicks(7942), "lma_sayd4@yahoo.com", "1-812-726-1835 x085" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, 93, واو, Djibouti", "الفجيرة", new DateTime(2024, 1, 11, 0, 29, 18, 860, DateTimeKind.Local).AddTicks(749), "zynb_jabr94@hotmail.com", "(208) 911-5875 x587" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, 173, سوق أهراس, Cayman Islands", "ميت غمر", new DateTime(2024, 1, 11, 6, 54, 35, 893, DateTimeKind.Local).AddTicks(3105), "slah4@yahoo.com", "526-215-3758 x516" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, دوار موحد دانش, 3, القامشلي, Wallis and Futuna", "سلفيت", new DateTime(2024, 1, 11, 12, 48, 3, 220, DateTimeKind.Local).AddTicks(3932), "zyd_aashwr87@hotmail.com", "(846) 847-5849" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, ش استاد قریب, 03, أسوان, Vanuatu", "رفح", new DateTime(2024, 1, 11, 1, 57, 20, 698, DateTimeKind.Local).AddTicks(498), "rym_blal@hotmail.com", "1-221-938-0016" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, دوار دستغیب, 9729, صيدا, Swaziland", "بيت حانون", new DateTime(2024, 1, 11, 2, 8, 44, 598, DateTimeKind.Local).AddTicks(1908), "dana.amjd@yahoo.com", "1-290-934-2120" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 1, الحمرا, Belgium", "جزيرة الحمراء", new DateTime(2024, 1, 11, 5, 0, 21, 496, DateTimeKind.Local).AddTicks(1676), "asamh.iyhab@hotmail.com", "(738) 419-0588 x37115" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع استاد قریب, دوار دیباجی, 464, خنشلة, Reunion", "البصرة", new DateTime(2024, 1, 11, 15, 34, 54, 656, DateTimeKind.Local).AddTicks(1849), "zynb51@hotmail.com", "400-708-8021 x317" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان فاطمی, 2, الكوت, Ireland", "الشحر", new DateTime(2024, 1, 11, 6, 16, 16, 226, DateTimeKind.Local).AddTicks(4001), "hajr94@gmail.com", "(542) 304-8881" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, 66, مسعد, Italy", "سطيف", new DateTime(2024, 1, 11, 17, 34, 4, 991, DateTimeKind.Local).AddTicks(7802), "lma74@yahoo.com", "734.989.0585 x54864" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, تقاطع یادگار امام, 25, بانياس, Congo", "الناظور", new DateTime(2024, 1, 11, 1, 26, 19, 593, DateTimeKind.Local).AddTicks(6562), "fryd.aadm@yahoo.com", "948-647-4320 x327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, ش فاطمی, 8784, الجوف, Bahamas", "لحج", new DateTime(2024, 1, 11, 1, 38, 7, 356, DateTimeKind.Local).AddTicks(9626), "tarq89@gmail.com", "(870) 863-7031 x67912" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, ش شهید مطهری, 272, سعيدة, Madagascar", "دورا", new DateTime(2024, 1, 11, 13, 41, 9, 739, DateTimeKind.Local).AddTicks(4465), "rym_aashwr32@hotmail.com", "1-728-919-0637 x671" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, 6, طرابلس, Turkmenistan", "زليطن", new DateTime(2024, 1, 11, 5, 36, 18, 455, DateTimeKind.Local).AddTicks(3342), "rym.aadm@gmail.com", "608.293.1932 x021" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, 9707, سطات, Palestinian Territory", "ترهونة", new DateTime(2024, 1, 10, 21, 47, 33, 374, DateTimeKind.Local).AddTicks(1963), "rqyh73@yahoo.com", "1-709-311-0527" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, 47, شرورة, Kiribati", "لحج", new DateTime(2024, 1, 11, 3, 3, 58, 677, DateTimeKind.Local).AddTicks(1620), "farwq_aashwr@gmail.com", "(968) 302-6171 x298" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, 3395, إربد, Guatemala", "طيبة الامام", new DateTime(2024, 1, 11, 19, 37, 25, 647, DateTimeKind.Local).AddTicks(9533), "iynas.aarf@hotmail.com", "(346) 592-1772 x7870" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, ش موحد دانش, 901, جلافي, Wallis and Futuna", "عرعر", new DateTime(2024, 1, 10, 20, 59, 53, 221, DateTimeKind.Local).AddTicks(8293), "dana.marwf@yahoo.com", "491-284-0305 x288" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, ميدان رسالت, 1991, سوهاج, South Africa", "سلفيت", new DateTime(2024, 1, 11, 12, 22, 40, 217, DateTimeKind.Local).AddTicks(4231), "fatmh_asamh@yahoo.com", "796.421.8966 x271" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, ش دستغیب, 8, الأبيض, Japan", "سلفيت", new DateTime(2024, 1, 10, 22, 3, 5, 696, DateTimeKind.Local).AddTicks(534), "rbya_rbya@yahoo.com", "868-301-0396 x352" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, 92, الكسوة, Saint Vincent and the Grenadines", "سامراء", new DateTime(2024, 1, 11, 8, 3, 15, 395, DateTimeKind.Local).AddTicks(6355), "dana51@yahoo.com", "633.916.0646 x26709" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 214, تقورت, Rwanda", "تبوك", new DateTime(2024, 1, 11, 11, 17, 3, 63, DateTimeKind.Local).AddTicks(9616), "abyr65@gmail.com", "370-315-3331" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, 8638, الزيمة, Brunei Darussalam", "درعا", new DateTime(2024, 1, 10, 22, 33, 43, 629, DateTimeKind.Local).AddTicks(2508), "zynb_azyz94@hotmail.com", "1-649-545-6881 x5240" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, 8, خور فكان, Albania", "اوبيو", new DateTime(2024, 1, 11, 8, 45, 5, 641, DateTimeKind.Local).AddTicks(6822), "mna_iyhab@gmail.com", "918.627.9424 x81428" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, 0691, تربة البقوم, Saint Helena", "جبلة", new DateTime(2024, 1, 11, 8, 29, 56, 831, DateTimeKind.Local).AddTicks(2462), "jabr_zyd@gmail.com", "(845) 850-9973 x32657" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, ميدان راستوان, 921, جرش, Suriname", "عدل بكرو", new DateTime(2024, 1, 11, 5, 19, 22, 484, DateTimeKind.Local).AddTicks(6458), "frydh70@yahoo.com", "1-802-438-0618 x24418" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 3111, صير بني ياس, Cote d'Ivoire", "الكاظمية", new DateTime(2024, 1, 11, 1, 30, 42, 223, DateTimeKind.Local).AddTicks(9716), "fatmh.azyz94@hotmail.com", "1-211-757-1260" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, 76, الرويس, American Samoa", "بجاية", new DateTime(2024, 1, 11, 15, 4, 6, 867, DateTimeKind.Local).AddTicks(1294), "salm79@gmail.com", "628-219-7497 x3546" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, شارع سمیه, 0, قابس, Sudan", "جت", new DateTime(2024, 1, 11, 20, 7, 19, 133, DateTimeKind.Local).AddTicks(8801), "rqyh.aqyl74@yahoo.com", "(640) 934-1786" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, طريق آذربایجان, 5, بدر حنين, Gibraltar", "مصراتة", new DateTime(2024, 1, 11, 17, 10, 1, 830, DateTimeKind.Local).AddTicks(4271), "arwa_fryd85@hotmail.com", "(537) 625-5497" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, طريق آفریقا, 64, تبسة, Albania", "الديماس", new DateTime(2024, 1, 11, 3, 4, 38, 142, DateTimeKind.Local).AddTicks(1669), "slah_salm61@gmail.com", "486.537.4669 x33283" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, دوار کارگر شمالی, 5, ادلب, Niger", "شبين الكوم", new DateTime(2024, 1, 11, 0, 37, 33, 425, DateTimeKind.Local).AddTicks(2524), "fuad54@hotmail.com", "442-903-7133" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, تقاطع موحد دانش, 569, ضرما, Belgium", "الخمس", new DateTime(2024, 1, 11, 0, 21, 27, 177, DateTimeKind.Local).AddTicks(1930), "dana.asamh@hotmail.com", "(379) 627-1294 x3572" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دیباجی, 081, الدرعية, Jersey", "البيضاء", new DateTime(2024, 1, 11, 4, 33, 13, 417, DateTimeKind.Local).AddTicks(7319), "zyd.aarf@hotmail.com", "592.751.2949" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, 70, نزوى, Denmark", "توريرت", new DateTime(2024, 1, 11, 18, 49, 55, 851, DateTimeKind.Local).AddTicks(5794), "rbya.slah@hotmail.com", "799-400-8255 x738" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, ميدان استاد قریب, 36, كفرشوبا, Slovakia (Slovak Republic)", "طرطوس", new DateTime(2024, 1, 11, 13, 6, 38, 649, DateTimeKind.Local).AddTicks(6598), "rbya_aadm@yahoo.com", "793.339.6047 x0005" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 29, المدية, Iran", "سيدي سليمان", new DateTime(2024, 1, 11, 5, 35, 45, 949, DateTimeKind.Local).AddTicks(7136), "aadm.sayd14@hotmail.com", "720-759-4387 x615" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, دوار آفریقا, 8, دمشق, Gabon", "الخميسات", new DateTime(2024, 1, 11, 1, 1, 44, 66, DateTimeKind.Local).AddTicks(5247), "amjd.rbya62@yahoo.com", "1-297-453-7335 x7891" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, 8, سمائل, Saint Martin", "الإسكندرية", new DateTime(2024, 1, 11, 1, 14, 19, 507, DateTimeKind.Local).AddTicks(2903), "fatmh76@gmail.com", "1-416-482-2721 x2164" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, 884, بلجرشي, Nigeria", "بنها", new DateTime(2024, 1, 10, 21, 52, 5, 130, DateTimeKind.Local).AddTicks(4560), "tarq55@gmail.com", "628.245.4457" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 8, العيون, Bhutan", "قرية سار", new DateTime(2024, 1, 11, 18, 21, 57, 818, DateTimeKind.Local).AddTicks(3505), "hsn17@gmail.com", "833.749.3407 x02410" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, 4, صفاقس, Niger", "القائم", new DateTime(2024, 1, 11, 3, 8, 43, 770, DateTimeKind.Local).AddTicks(2668), "aadm_sayd@gmail.com", "1-322-886-1261" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, 4762, تطوان, Martinique", "أغادير", new DateTime(2024, 1, 11, 4, 39, 13, 947, DateTimeKind.Local).AddTicks(7964), "iynas64@yahoo.com", "(678) 896-6158 x7589" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, دوار رسالت, 890, السليل, Peru", "بغداد", new DateTime(2024, 1, 11, 2, 4, 5, 690, DateTimeKind.Local).AddTicks(4510), "blal31@gmail.com", "(957) 532-7930" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, دوار دماوند, 6044, مدينة الصدر, Costa Rica", "الرطبة", new DateTime(2024, 1, 11, 19, 29, 39, 864, DateTimeKind.Local).AddTicks(6769), "salm.jabr@hotmail.com", "(668) 952-3457 x85510" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 9, بنزرت, Malta", "أم الفحم", new DateTime(2024, 1, 11, 5, 51, 46, 512, DateTimeKind.Local).AddTicks(3691), "jabr89@hotmail.com", "540.410.6114 x189" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, طريق دیباجی, 4952, البديع, Cook Islands", "خريبة السوق", new DateTime(2024, 1, 11, 9, 3, 42, 425, DateTimeKind.Local).AddTicks(3987), "sayd.blal@hotmail.com", "452.424.5489" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, تقاطع رسالت, 51, المزاحمية, Belarus", "الناظور", new DateTime(2024, 1, 11, 5, 14, 43, 458, DateTimeKind.Local).AddTicks(9373), "frydh_azyz97@hotmail.com", "1-867-806-6769 x44558" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, 981, سطيف, Austria", "مقطع لحجار", new DateTime(2024, 1, 10, 20, 44, 44, 847, DateTimeKind.Local).AddTicks(3759), "jmanh57@gmail.com", "1-446-945-9336 x93510" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, 7, بيروت, Virgin Islands, U.S.", "حماة", new DateTime(2024, 1, 11, 9, 4, 8, 32, DateTimeKind.Local).AddTicks(6291), "salm_marwf81@hotmail.com", "(918) 209-1374" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, 221, ليلى, Germany", "المناقل", new DateTime(2024, 1, 11, 4, 20, 6, 755, DateTimeKind.Local).AddTicks(7521), "hajr67@gmail.com", "330-835-5187" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, 4281, قسنطينة, Isle of Man", "سلمية", new DateTime(2024, 1, 10, 22, 54, 16, 52, DateTimeKind.Local).AddTicks(5294), "jabr99@gmail.com", "(378) 945-9921 x986" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان فاطمی, شارع اقبال لاهوری, 5, سكاكا, Ecuador", "قصرين", new DateTime(2024, 1, 10, 22, 24, 5, 326, DateTimeKind.Local).AddTicks(7518), "fatmh_zyd89@yahoo.com", "1-512-776-5659 x0865" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, 6, الأبيض, Sao Tome and Principe", "القنفذة", new DateTime(2024, 1, 11, 20, 20, 20, 731, DateTimeKind.Local).AddTicks(6838), "jabr_amjd@yahoo.com", "781.559.6045 x88868" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, 364, إدلب, Spain", "العمران", new DateTime(2024, 1, 11, 18, 0, 42, 797, DateTimeKind.Local).AddTicks(4553), "dana.iyhab@hotmail.com", "564-615-0808 x977" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, شارع آذربایجان, 2, مسيعيد, Antigua and Barbuda", "القدموس", new DateTime(2024, 1, 11, 20, 27, 15, 988, DateTimeKind.Local).AddTicks(226), "amjd.azyz46@yahoo.com", "(603) 687-5427" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, ش حقانی, 05, العين, Guinea-Bissau", "مدينة الصدر", new DateTime(2024, 1, 11, 12, 22, 22, 817, DateTimeKind.Local).AddTicks(1327), "jmanh.fuad@yahoo.com", "419.507.1338 x160" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, 6669, زبيد, Uganda", "قنا", new DateTime(2024, 1, 11, 18, 3, 50, 189, DateTimeKind.Local).AddTicks(7164), "fuad.zyd39@hotmail.com", "383-385-8570 x90814" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, ش رسالت, 33, شيبه, Moldova", "الرباط", new DateTime(2024, 1, 11, 3, 6, 32, 544, DateTimeKind.Local).AddTicks(1308), "iynas_tarq@gmail.com", "1-777-317-1263 x5946" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, 9356, القنفذة, Cyprus", "الحديدة", new DateTime(2024, 1, 11, 19, 31, 47, 369, DateTimeKind.Local).AddTicks(709), "rna_azyz@gmail.com", "1-900-283-5127 x97239" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, ش موحد دانش, 1786, الفنيدق, Japan", "قرية الجهراء", new DateTime(2024, 1, 11, 4, 30, 48, 286, DateTimeKind.Local).AddTicks(2774), "zynb_slah9@yahoo.com", "345-893-8962" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, تقاطع آذربایجان, 8442, ازرع, Antigua and Barbuda", "اكجوجت", new DateTime(2024, 1, 10, 21, 56, 0, 689, DateTimeKind.Local).AddTicks(1647), "shymaa_aarf36@gmail.com", "(533) 778-7863" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 2, الحلة, India", "البصرة", new DateTime(2024, 1, 11, 5, 39, 45, 87, DateTimeKind.Local).AddTicks(3140), "rbya_aashwr75@yahoo.com", "254.510.4682" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, 08, صور, Hungary", "قرية سار", new DateTime(2024, 1, 11, 1, 33, 25, 111, DateTimeKind.Local).AddTicks(75), "salm_aqyl@gmail.com", "1-752-864-6393" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 0996, الحلة, Latvia", "عين العرب", new DateTime(2024, 1, 10, 22, 41, 13, 9, DateTimeKind.Local).AddTicks(2093), "fuad_rbya69@yahoo.com", "452-712-6210 x7476" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, 4434, نزوى, Jersey", "تونس", new DateTime(2024, 1, 11, 12, 7, 58, 133, DateTimeKind.Local).AddTicks(9311), "blal_aadm33@yahoo.com", "925-591-9997 x751" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, 7, تنبدغة, Afghanistan", "شهبا", new DateTime(2024, 1, 11, 5, 6, 46, 284, DateTimeKind.Local).AddTicks(5585), "arwa.tarq95@hotmail.com", "968.319.0696 x92672" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, ميدان ابوذر, 4, نابلس, Montserrat", "القصر الكبير", new DateTime(2024, 1, 11, 11, 7, 4, 514, DateTimeKind.Local).AddTicks(8329), "farwq33@hotmail.com", "1-724-851-3850" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, 4017, يامبيو, Holy See (Vatican City State)", "وزان", new DateTime(2024, 1, 11, 4, 56, 23, 111, DateTimeKind.Local).AddTicks(4686), "blal_aarf@hotmail.com", "682.624.9509" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 72, علي صبيح, Liechtenstein", "صور", new DateTime(2024, 1, 11, 10, 9, 39, 247, DateTimeKind.Local).AddTicks(3146), "mna.asar4@hotmail.com", "933.272.8910" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, دوار استاد قریب, 3366, الجلفة, French Southern Territories", "الحمرا", new DateTime(2024, 1, 11, 11, 29, 31, 809, DateTimeKind.Local).AddTicks(4416), "arwa52@yahoo.com", "788.303.3145" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 86, بلجرشي, Liberia", "بركاء", new DateTime(2024, 1, 11, 4, 16, 8, 335, DateTimeKind.Local).AddTicks(975), "iynas.amjd@hotmail.com", "717.736.0531" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, شارع آزادی, 8, جوبا, Cyprus", "صلالة", new DateTime(2024, 1, 11, 9, 3, 59, 784, DateTimeKind.Local).AddTicks(4913), "zyd29@hotmail.com", "752.785.5560 x06293" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, 7647, سيان, Qatar", "ملكال", new DateTime(2024, 1, 11, 18, 34, 15, 469, DateTimeKind.Local).AddTicks(102), "zynb.fuad@hotmail.com", "(533) 332-4697" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, 4275, دمازين, Niger", "المنستير", new DateTime(2024, 1, 10, 20, 43, 18, 824, DateTimeKind.Local).AddTicks(6), "sayd.zyd@hotmail.com", "(865) 625-9019" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, ش مالک اشتر, 10, القضيمة, Saint Kitts and Nevis", "بيروت", new DateTime(2024, 1, 11, 9, 56, 38, 222, DateTimeKind.Local).AddTicks(2037), "dana.aadm45@yahoo.com", "(485) 816-7423 x563" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق رسالت, ميدان آزادی, 4, أم القيوين, India", "صنعاء", new DateTime(2024, 1, 11, 20, 5, 10, 550, DateTimeKind.Local).AddTicks(8716), "fuad23@gmail.com", "361.968.4866" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, 479, تبوك, Tuvalu", "جيجل", new DateTime(2024, 1, 11, 3, 48, 24, 152, DateTimeKind.Local).AddTicks(3146), "jmanh_aashwr65@yahoo.com", "1-327-965-8370" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, 3, بيروت, Falkland Islands (Malvinas)", "بنزرت", new DateTime(2024, 1, 11, 9, 28, 52, 222, DateTimeKind.Local).AddTicks(6096), "zyd.jabr44@yahoo.com", "894.798.5823" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سباری, 84, قرية الجهراء, Guadeloupe", "قرية سار", new DateTime(2024, 1, 11, 12, 38, 47, 50, DateTimeKind.Local).AddTicks(8902), "arwa_araqy@hotmail.com", "1-702-680-3526 x394" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, 9, خريبكة, Equatorial Guinea", "الوكرة", new DateTime(2024, 1, 11, 16, 10, 7, 683, DateTimeKind.Local).AddTicks(8123), "asamh_zyd@yahoo.com", "763-621-2378 x0556" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 02, طرطوس, Vietnam", "سطيف", new DateTime(2024, 1, 11, 6, 0, 31, 8, DateTimeKind.Local).AddTicks(2230), "fatmh_amjd@hotmail.com", "688.720.3995 x84359" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, 613, بعبدا, Mauritania", "جدة", new DateTime(2024, 1, 11, 15, 41, 52, 541, DateTimeKind.Local).AddTicks(7441), "jmanh_blal@hotmail.com", "325-218-0473 x86123" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, طريق واعظی, 634, انواديبو, Belarus", "سيدي سليمان", new DateTime(2024, 1, 10, 23, 28, 12, 383, DateTimeKind.Local).AddTicks(6633), "rbya26@gmail.com", "268-609-2618 x758" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, 3649, طولكرم, Benin", "تعز", new DateTime(2024, 1, 10, 22, 9, 55, 55, DateTimeKind.Local).AddTicks(6512), "rbya_rbya75@yahoo.com", "(844) 286-6920 x57567" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع ابوذر, طريق کارگر شمالی, 58, بركان, Oman", "شرورة", new DateTime(2024, 1, 11, 5, 8, 4, 198, DateTimeKind.Local).AddTicks(2065), "aadm.iyhab21@yahoo.com", "627-885-1691 x324" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, ش استاد قریب, 80, شلالة العذاورة, Philippines", "عين اعبيد", new DateTime(2024, 1, 11, 2, 40, 51, 643, DateTimeKind.Local).AddTicks(9569), "fryd.sayd@yahoo.com", "668-234-4104 x103" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, 969, دورا, Myanmar", "نابل", new DateTime(2024, 1, 11, 16, 1, 51, 709, DateTimeKind.Local).AddTicks(1143), "aadm.tarq81@hotmail.com", "644.544.1407 x44921" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, شارع رسالت, 774, المقدادية, Saudi Arabia", "دير القمر", new DateTime(2024, 1, 11, 9, 34, 45, 89, DateTimeKind.Local).AddTicks(6293), "rna_hazm64@yahoo.com", "(853) 554-4239 x23111" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 1, 8, 16, 2, 37, 854, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 1, 11, 2, 50, 56, 762, DateTimeKind.Local).AddTicks(8835), "دانا عقیل", "Elian Moen", 0, "إيهاب, طارق and آدم", "9071105467005408354", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1984, 6, 19, 0, 49, 2, 314, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 1, 10, 23, 0, 54, 576, DateTimeKind.Local).AddTicks(4878), "ريم هاشم", "Mervin Kunze", 0, "عراقی - سعيد", "3163600396146096247", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 1, 13, 3, 20, 52, 823, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 1, 11, 18, 18, 8, 843, DateTimeKind.Local).AddTicks(3661), "عبير فاروق", "Zackary Mraz", 1, "عاشور - عزیز", "5946911129520932446", "Turkmenistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2001, 6, 16, 6, 55, 23, 900, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 1, 11, 7, 52, 52, 607, DateTimeKind.Local).AddTicks(7973), "أسامة آدم", "Watson Ledner", 0, "آدم Group", "2407230456735101376", "United States Minor Outlying Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 11, 17, 15, 32, 33, 393, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 1, 11, 14, 30, 57, 860, DateTimeKind.Local).AddTicks(6143), "عبير عاشور", "Ricardo Hagenes", "هاشم - بلال", "291154248207542165", "Papua New Guinea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 11, 6, 17, 57, 3, 577, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 1, 11, 10, 58, 28, 117, DateTimeKind.Local).AddTicks(8219), "سارة عصار", "Adrien Torp", "عزیز, حازم and إيهاب", "2819313326515113161", "Holy See (Vatican City State)", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 6, 11, 19, 50, 58, 207, DateTimeKind.Local).AddTicks(4521), new DateTime(2024, 1, 11, 11, 23, 56, 371, DateTimeKind.Local).AddTicks(8773), "حسن هاشم", "Florida Hermann", "فاروق - زيد", "3055576660539934782", "Croatia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 5, 27, 14, 28, 10, 742, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 1, 11, 0, 35, 27, 575, DateTimeKind.Local).AddTicks(8017), "سالم فاروق", "Vanessa Boehm", "عراقی, ربيع and سالم", "7361469411915736283", "Democratic People's Republic of Korea", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 14, 16, 27, 24, 984, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 1, 11, 4, 35, 30, 256, DateTimeKind.Local).AddTicks(1763), "دانا إيهاب", "Kaela Prosacco", "زيد LLC", "5168399304173916764", "Jordan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 6, 15, 22, 41, 12, 328, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 1, 10, 20, 56, 20, 882, DateTimeKind.Local).AddTicks(3741), "فؤاد سعيد", "Waino Koch", "أسامة Group", "7866161929868549925", "United Arab Emirates", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 7, 2, 23, 9, 43, 36, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 1, 11, 3, 52, 43, 272, DateTimeKind.Local).AddTicks(9035), "رنا سعيد", "Jaiden Walker", "سالم, سعيد and فريد", "2217423006530207633", "Saint Helena", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 9, 12, 23, 14, 10, 439, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 1, 11, 6, 25, 40, 661, DateTimeKind.Local).AddTicks(3200), "فؤاد أمجد", "Dawson Schmeler", 1, "آدم and Sons", "4462039747190360654", "Heard Island and McDonald Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 5, 12, 9, 5, 4, 24, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 1, 11, 3, 4, 14, 539, DateTimeKind.Local).AddTicks(5832), "فاطمة سالم", "Salvador Gerlach", "فاروق - عراقی", "5910206501063446069", "Uganda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 12, 14, 12, 29, 10, 988, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 1, 11, 20, 10, 50, 177, DateTimeKind.Local).AddTicks(3247), "آدم عزیز", "Bryce Jast", "هاشم - زيد", "5616275606074549803", "India", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 7, 9, 6, 40, 36, 963, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 1, 11, 2, 19, 45, 175, DateTimeKind.Local).AddTicks(4840), "أسامة أسامة", "Heloise Boyer", 1, "حسن - عاشور", "3323719247719833537", "Oman", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 8, 23, 10, 45, 21, 639, DateTimeKind.Local).AddTicks(1771), new DateTime(2024, 1, 11, 1, 22, 41, 235, DateTimeKind.Local).AddTicks(608), "بلال زيد", "Aryanna Daniel", "فؤاد, عارف and عقیل", "4243299439844619041", "Cape Verde", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 24, 4, 49, 10, 505, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 1, 11, 20, 14, 35, 378, DateTimeKind.Local).AddTicks(7004), "زيد أمجد", "Kenna Osinski", "سعيد - عاشور", "714001114997294336", "Belarus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 6, 6, 22, 14, 22, 704, DateTimeKind.Local).AddTicks(8240), new DateTime(2024, 1, 11, 3, 43, 49, 245, DateTimeKind.Local).AddTicks(5299), "رنا آدم", "Tressa Watsica", "فريد, فاروق and أسامة", "2064082616397339903", "Argentina", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 10, 23, 5, 50, 16, 487, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 1, 11, 12, 46, 35, 878, DateTimeKind.Local).AddTicks(9812), "فؤاد عاشور", "Max Watsica", "سعيد - سعيد", "6338521481751809030", "Sudan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 9, 18, 16, 27, 16, 38, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 1, 10, 22, 16, 53, 271, DateTimeKind.Local).AddTicks(4874), "حسن صلاح", "Watson Wuckert", "فؤاد - حازم", "5021625015739959972", "Liechtenstein", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 3, 28, 14, 33, 32, 209, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 1, 11, 8, 14, 42, 571, DateTimeKind.Local).AddTicks(4045), "ريم عصار", "Owen Kub", "صلاح, آدم and هاشم", "2474415728294528996", "El Salvador", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 2, 19, 12, 17, 13, 114, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 1, 11, 7, 57, 50, 740, DateTimeKind.Local).AddTicks(150), "أمجد أمجد", "Reta Steuber", 1, "آدم, معروف and عاشور", "6054428367541960783", "Egypt", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 10, 8, 21, 57, 0, 673, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 1, 11, 20, 32, 38, 273, DateTimeKind.Local).AddTicks(4314), "جابر‌ فريد", "Ottis Lockman", 0, "عزیز, عاشور and طارق", "2972925339202190388", "Solomon Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 17, 18, 39, 19, 681, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 1, 11, 9, 12, 5, 711, DateTimeKind.Local).AddTicks(6446), "أمجد صلاح", "Andy Rodriguez", "أسامة - أسامة", "1884498268770474051", "Italy", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 1, 28, 2, 13, 51, 879, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 1, 11, 2, 9, 44, 529, DateTimeKind.Local).AddTicks(8607), "أروى أسامة", "Bryce Armstrong", "زيد and Sons", "2648012875036075844", "Saint Pierre and Miquelon" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 5, 10, 9, 57, 34, 402, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 1, 10, 20, 42, 17, 655, DateTimeKind.Local).AddTicks(8281), "حازم ربيع", "Ethelyn Breitenberg", "عاشور Inc", "5647794766211140369", "Zimbabwe", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 5, 22, 10, 17, 3, 867, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 1, 11, 14, 24, 19, 916, DateTimeKind.Local).AddTicks(8303), "فاطمة عصار", "Roberta Nitzsche", 0, "ربيع and Sons", "8844375118854204493", "Sudan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 1, 21, 16, 37, 8, 404, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 1, 11, 2, 44, 32, 565, DateTimeKind.Local).AddTicks(169), "فاطمة فاروق", "Maegan McCullough", 1, "جابر‌ - أسامة", "5474005920416995672", "Cameroon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 4, 7, 6, 58, 22, 456, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 1, 11, 19, 18, 26, 631, DateTimeKind.Local).AddTicks(4610), "أروى حازم", "Quincy Ebert", 1, "سالم, جابر‌ and آدم", "9133923359811715732", "Liechtenstein", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 28, 17, 4, 43, 442, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 1, 11, 3, 17, 15, 333, DateTimeKind.Local).AddTicks(9856), "سارة أسامة", "Kim Orn", "ربيع - بلال", "4954650597171414969", "Timor-Leste", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 9, 13, 16, 48, 52, 605, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 1, 11, 1, 12, 16, 780, DateTimeKind.Local).AddTicks(6988), "حازم طارق", "Warren Breitenberg", 0, "حسن - أمجد", "5134659423716825096", "Brazil", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 12, 18, 9, 45, 42, 175, DateTimeKind.Local).AddTicks(6393), new DateTime(2024, 1, 11, 10, 23, 28, 659, DateTimeKind.Local).AddTicks(9743), "دانا بلال", "Mathew Quitzon", "أسامة LLC", "1795552770321383537", "Wallis and Futuna", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 7, 30, 18, 13, 22, 514, DateTimeKind.Local).AddTicks(3090), new DateTime(2024, 1, 10, 21, 56, 44, 734, DateTimeKind.Local).AddTicks(9437), "حسن سالم", "Susie Schultz", "زيد Group", "4379624292006392501", "Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 12, 7, 21, 45, 51, 774, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 1, 11, 4, 20, 20, 586, DateTimeKind.Local).AddTicks(2474), "رقية ربيع", "Luisa Marquardt", 1, "بلال, زيد and عقیل", "7897706832125676939", "Luxembourg", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 2, 24, 22, 54, 16, 328, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 1, 11, 9, 22, 52, 129, DateTimeKind.Local).AddTicks(8140), "رقية صلاح", "Thaddeus Heller", 1, "عاشور and Sons", "8930860406060870419", "Saint Helena", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 11, 27, 5, 37, 14, 540, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 1, 11, 14, 23, 32, 145, DateTimeKind.Local).AddTicks(7970), "عبير حسن", "Kraig O'Keefe", "فؤاد, عاشور and عصار", "5820799969395704001", "British Indian Ocean Territory (Chagos Archipelago)", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2002, 9, 6, 23, 43, 1, 883, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 1, 11, 20, 32, 35, 334, DateTimeKind.Local).AddTicks(8104), "فؤاد هاشم", "Roselyn Kerluke", "آدم LLC", "5525017299172270615", "Kyrgyz Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 9, 2, 16, 8, 19, 221, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 1, 11, 4, 25, 31, 206, DateTimeKind.Local).AddTicks(9747), "جابر‌ عصار", "Cullen Roberts", 1, "عقیل Group", "4246377726145640654", "Tokelau", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 22, 4, 45, 45, 862, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 1, 11, 10, 39, 8, 432, DateTimeKind.Local).AddTicks(5509), "أمجد عارف", "Patience Howell", 0, "طارق and Sons", "8020306943023275382", "French Polynesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 3, 13, 21, 56, 41, 910, DateTimeKind.Local).AddTicks(6687), new DateTime(2024, 1, 11, 16, 6, 58, 72, DateTimeKind.Local).AddTicks(432), "طارق فاروق", "Diamond Abernathy", 0, "بلال Group", "4397664843833871437", "Malaysia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 30, 8, 0, 20, 785, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 1, 11, 3, 36, 2, 274, DateTimeKind.Local).AddTicks(2025), "جمانة معروف", "Nettie Romaguera", "فؤاد and Sons", "5048787359111831175", "Albania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 12, 16, 12, 32, 57, 12, DateTimeKind.Local).AddTicks(2404), new DateTime(2024, 1, 11, 18, 54, 21, 818, DateTimeKind.Local).AddTicks(1181), "ربيع أسامة", "Kaia Becker", "حسن, أمجد and حازم", "4798644851503946856", "Turkmenistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 10, 13, 8, 56, 33, 982, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 1, 11, 10, 59, 8, 528, DateTimeKind.Local).AddTicks(838), "إيهاب معروف", "Agnes Reichert", 1, "عاشور, أسامة and هاشم", "8360775614613744167", "Bolivia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 4, 13, 11, 51, 58, 361, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 11, 10, 53, 53, 747, DateTimeKind.Local).AddTicks(4149), "دانا آدم", "Dasia Hirthe", 1, "جابر‌, أسامة and بلال", "4265462397918410638", "Antarctica (the territory South of 60 deg S)", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 9, 4, 4, 22, 18, 886, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 1, 11, 10, 5, 11, 823, DateTimeKind.Local).AddTicks(2593), "حسن صلاح", "Cassandre Conroy", "عزیز, حسن and آدم", "9155825527668289995", "Myanmar", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 7, 1, 19, 34, 53, 746, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 1, 11, 4, 19, 54, 569, DateTimeKind.Local).AddTicks(4704), "أسامة عاشور", "Geoffrey Koepp", "حسن LLC", "9163918563354590756", "Macao" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 20, 2, 13, 3, 417, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 1, 11, 18, 49, 4, 581, DateTimeKind.Local).AddTicks(7630), "رنا صلاح", "Bud Moore", "عصار and Sons", "7470552526551536574", "Finland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 1, 21, 17, 39, 38, 805, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 1, 11, 12, 18, 28, 569, DateTimeKind.Local).AddTicks(2906), "فاطمة ربيع", "Edmond Cummerata", 1, "بلال - عقیل", "2736004772281638218", "Georgia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 3, 8, 58, 6, 203, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 1, 11, 20, 37, 35, 855, DateTimeKind.Local).AddTicks(3040), "فاروق أسامة", "Nikolas Dooley", 1, "عارف Group", "9192403229786858859", "Nauru", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 23, 20, 27, 19, 664, DateTimeKind.Local).AddTicks(7916), new DateTime(2024, 1, 11, 4, 48, 0, 300, DateTimeKind.Local).AddTicks(9904), "فاروق فاروق", "Dulce Bartell", 0, "عارف LLC", "1333796323201717375", "Guernsey", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 5, 24, 22, 28, 55, 501, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 1, 11, 11, 19, 22, 50, DateTimeKind.Local).AddTicks(38), "زيد آدم", "Adrien Emmerich", 0, "معروف, زيد and عقیل", "3449948972740265343", "Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 3, 6, 22, 51, 26, 111, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 1, 11, 4, 8, 44, 453, DateTimeKind.Local).AddTicks(110), "شيماء حازم", "Eddie Waters", 0, "هاشم - معروف", "882212355857885138", "Isle of Man", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 9, 5, 18, 42, 35, 537, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 1, 11, 19, 37, 50, 328, DateTimeKind.Local).AddTicks(873), "لمى عزیز", "Mohammad Tillman", "ربيع - عزیز", "3768999044402969756", "Hong Kong", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 7, 26, 22, 30, 4, 264, DateTimeKind.Local).AddTicks(1675), new DateTime(2024, 1, 11, 7, 29, 29, 879, DateTimeKind.Local).AddTicks(866), "جمانة حازم", "Duane Murazik", 0, "عارف - هاشم", "4770172228585887976", "Angola", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 10, 3, 11, 45, 53, 699, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 1, 11, 15, 10, 22, 503, DateTimeKind.Local).AddTicks(8223), "أسامة سالم", "Nadia Boehm", 1, "معروف LLC", "2752569149486167487", "Montenegro", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 8, 28, 0, 35, 45, 789, DateTimeKind.Local).AddTicks(5032), new DateTime(2024, 1, 11, 13, 3, 21, 342, DateTimeKind.Local).AddTicks(3029), "ربيع آدم", "Maryam Abernathy", "أمجد LLC", "7981707600039668218", "Dominica" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 20, 15, 13, 50, 897, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 1, 11, 18, 52, 15, 864, DateTimeKind.Local).AddTicks(8286), "أسامة ربيع", "Clara Corkery", 1, "فؤاد - جابر‌", "8184224740518858321", "Suriname", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2001, 8, 26, 9, 2, 6, 970, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 1, 11, 16, 47, 15, 455, DateTimeKind.Local).AddTicks(3574), "سالم زيد", "Anastasia Nolan", 1, "حسن LLC", "3237696571732411138", "Equatorial Guinea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 12, 19, 14, 17, 38, 212, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 1, 11, 10, 37, 17, 70, DateTimeKind.Local).AddTicks(1153), "إيناس معروف", "Adelle Marvin", 1, "حسن, ربيع and سعيد", "108486704838436004", "Macao", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 2, 17, 16, 38, 35, 267, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 1, 11, 5, 33, 34, 239, DateTimeKind.Local).AddTicks(9082), "زينب فريد", "Wyman Bechtelar", "حسن and Sons", "609639303708407823", "Trinidad and Tobago" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 2, 3, 16, 5, 57, 433, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 1, 11, 20, 17, 58, 330, DateTimeKind.Local).AddTicks(6477), "منى عزیز", "Abagail Parisian", 0, "طارق, زيد and عاشور", "5186685774758631510", "Nigeria", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 12, 18, 8, 1, 39, 775, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 1, 11, 7, 19, 59, 325, DateTimeKind.Local).AddTicks(865), "فريدة عراقی", "Jennifer Wintheiser", 1, "إيهاب - عراقی", "6177155365792934124", "Tunisia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 4, 11, 16, 16, 19, 87, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 1, 11, 19, 35, 2, 914, DateTimeKind.Local).AddTicks(8741), "سعيد عارف", "Shayne Bahringer", 0, "فؤاد, معروف and ربيع", "983648405141393075", "Tajikistan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 8, 3, 14, 40, 2, 929, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 1, 10, 21, 13, 26, 227, DateTimeKind.Local).AddTicks(2902), "سالم أمجد", "Astrid Tromp", "فريد, سالم and صلاح", "8412760191697455504", "Spain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 22, 19, 53, 11, 190, DateTimeKind.Local).AddTicks(5006), new DateTime(2024, 1, 11, 0, 41, 46, 0, DateTimeKind.Local).AddTicks(3846), "فريدة عراقی", "Lauretta Kunze", "بلال LLC", "5973570977850425117", "Argentina", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 4, 13, 11, 53, 31, 348, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 1, 11, 7, 19, 34, 547, DateTimeKind.Local).AddTicks(2731), "آدم حازم", "Raul Heaney", "أمجد, أمجد and عراقی", "5291854310010892755", "Antigua and Barbuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 6, 5, 4, 49, 53, 292, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 1, 11, 16, 55, 30, 981, DateTimeKind.Local).AddTicks(9848), "بلال زيد", "Mohammed Konopelski", "إيهاب, هاشم and عاشور", "4150415391679666294", "Maldives", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 7, 11, 11, 44, 9, 578, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 1, 11, 13, 55, 41, 408, DateTimeKind.Local).AddTicks(5793), "آية عارف", "Malachi Jerde", "إيهاب, إيهاب and عارف", "315017078357902250", "Micronesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 7, 17, 10, 10, 24, 202, DateTimeKind.Local).AddTicks(4311), new DateTime(2024, 1, 11, 13, 12, 53, 627, DateTimeKind.Local).AddTicks(1839), "بلال جابر‌", "Olin Nikolaus", 1, "سعيد LLC", "150735852943088437", "Guadeloupe", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1985, 10, 28, 14, 3, 53, 209, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 1, 11, 1, 44, 38, 569, DateTimeKind.Local).AddTicks(4867), "هاجر إيهاب", "Alberto Ernser", 1, "معروف and Sons", "1999055682970490860", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 10, 6, 7, 6, 18, 410, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 1, 11, 10, 50, 16, 811, DateTimeKind.Local).AddTicks(2745), "صلاح إيهاب", "Aaron Sporer", "جابر‌ - زيد", "2940461979656145414", "Singapore", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 12, 18, 2, 3, 43, 606, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 1, 11, 19, 28, 18, 780, DateTimeKind.Local).AddTicks(2025), "فريد طارق", "Lula Halvorson", "عزیز and Sons", "6225090047506961810", "United States of America", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 11, 22, 16, 51, 24, 469, DateTimeKind.Local).AddTicks(5369), new DateTime(2024, 1, 10, 21, 48, 34, 217, DateTimeKind.Local).AddTicks(6544), "فاروق أمجد", "Karl Murray", 1, "إيهاب - آدم", "816853333488286063", "Christmas Island", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 1, 4, 17, 24, 20, 539, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 1, 11, 2, 36, 36, 610, DateTimeKind.Local).AddTicks(4688), "دانا جابر‌", "Melissa Mayer", "بلال Inc", "7371670911074859096", "Kuwait", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 6, 1, 13, 48, 38, 85, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 1, 11, 15, 32, 1, 914, DateTimeKind.Local).AddTicks(7410), "سعيد طارق", "Glen Morar", 1, "عراقی LLC", "5090767080887640953", "Libyan Arab Jamahiriya" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 9, 3, 11, 37, 9, 850, DateTimeKind.Local).AddTicks(9258), new DateTime(2024, 1, 11, 2, 1, 9, 619, DateTimeKind.Local).AddTicks(5029), "سارة زيد", "Brennon West", 1, "هاشم, معروف and فاروق", "2210341884588245609", "Cote d'Ivoire", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 6, 28, 4, 28, 26, 125, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 1, 11, 12, 33, 22, 900, DateTimeKind.Local).AddTicks(3414), "فريدة حازم", "Adalberto Gaylord", "طارق and Sons", "2864116035519156814", "Wallis and Futuna", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 7, 15, 21, 33, 52, 692, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 1, 11, 15, 27, 51, 240, DateTimeKind.Local).AddTicks(5031), "عبير حازم", "Marques Crooks", "سالم Group", "5948577347375724794", "Luxembourg", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 9, 16, 16, 13, 43, 597, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 1, 11, 0, 50, 41, 195, DateTimeKind.Local).AddTicks(1783), "جمانة هاشم", "Odie Hickle", "فؤاد - عصار", "5726471943947085618", "Chile", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 10, 13, 23, 16, 59, 202, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 1, 11, 2, 48, 33, 555, DateTimeKind.Local).AddTicks(7151), "منى زيد", "Romaine Torp", "معروف, أسامة and زيد", "8983175101018095596", "Ecuador", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 19, 20, 15, 38, 67, DateTimeKind.Local).AddTicks(845), new DateTime(2024, 1, 10, 20, 58, 1, 91, DateTimeKind.Local).AddTicks(2300), "جابر‌ حازم", "Eliza Berge", 1, "عصار - حازم", "5462186326543481891", "Vanuatu", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 19, 20, 34, 47, 184, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 1, 11, 14, 5, 31, 59, DateTimeKind.Local).AddTicks(544), "رنا أمجد", "Gloria Hilll", "أسامة Inc", "4653589231553145970", "American Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 9, 25, 17, 3, 37, 683, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 1, 11, 11, 22, 54, 679, DateTimeKind.Local).AddTicks(8149), "فريدة أسامة", "Xavier Gusikowski", "أسامة Inc", "250201570521906342", "Iraq", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 12, 20, 23, 53, 21, 677, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 1, 10, 23, 4, 53, 917, DateTimeKind.Local).AddTicks(6261), "هاجر عزیز", "Rolando Grimes", "عصار - معروف", "5376006247303943908", "Ireland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 8, 27, 6, 39, 10, 106, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 1, 11, 10, 9, 45, 183, DateTimeKind.Local).AddTicks(6467), "دانا عصار", "Weldon Kuhlman", "عقیل - عصار", "8424436407971380424", "Virgin Islands, British", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 12, 16, 22, 51, 6, 676, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 1, 11, 17, 24, 52, 313, DateTimeKind.Local).AddTicks(9757), "إيهاب عقیل", "Kelton Hackett", 0, "فريد Group", "8401417070385166835", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 12, 9, 11, 38, 31, 131, DateTimeKind.Local).AddTicks(4712), new DateTime(2024, 1, 11, 5, 32, 17, 602, DateTimeKind.Local).AddTicks(1616), "منى فاروق", "Carolina Reinger", 1, "عزیز LLC", "9006934702911002159", "Iraq", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 8, 18, 6, 19, 15, 53, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 1, 11, 0, 2, 26, 691, DateTimeKind.Local).AddTicks(3288), "زينب عاشور", "Delores Kassulke", "إيهاب Inc", "6798653668847357279", "Macedonia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 4, 24, 8, 26, 16, 960, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 1, 11, 3, 25, 5, 376, DateTimeKind.Local).AddTicks(2428), "دانا طارق", "Bria Zemlak", "فريد Group", "7838463433278218194", "Chad", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 9, 12, 5, 10, 40, 124, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 1, 11, 11, 34, 48, 353, DateTimeKind.Local).AddTicks(9880), "زينب سالم", "Gracie Altenwerth", "أمجد, صلاح and فريد", "4455146786542534690", "Cambodia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 1, 26, 12, 39, 26, 373, DateTimeKind.Local).AddTicks(3429), new DateTime(2024, 1, 11, 16, 38, 59, 774, DateTimeKind.Local).AddTicks(6095), "فريدة عراقی", "Delia Cole", "حازم, ربيع and أمجد", "1889821248376583593", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 1, 16, 19, 21, 18, 4, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 1, 11, 4, 51, 24, 262, DateTimeKind.Local).AddTicks(6763), "سالم حازم", "Tressie Gerlach", "ربيع - طارق", "1785776344300505300", "Mongolia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 8, 21, 18, 24, 48, 188, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 1, 11, 19, 27, 51, 358, DateTimeKind.Local).AddTicks(4179), "آدم فؤاد", "Beth Baumbach", "فاروق, زيد and هاشم", "2469154144521751350", "Djibouti", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 16, 4, 36, 54, 451, DateTimeKind.Local).AddTicks(1029), new DateTime(2024, 1, 11, 16, 55, 4, 704, DateTimeKind.Local).AddTicks(1200), "أمجد فاروق", "Ned Sauer", "زيد - جابر‌", "3074590491590449133", "Saint Barthelemy", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 7, 23, 5, 35, 45, 586, DateTimeKind.Local).AddTicks(1904), new DateTime(2024, 1, 11, 14, 12, 33, 673, DateTimeKind.Local).AddTicks(6023), "فريد معروف", "Marjorie Kulas", "صلاح - آدم", "2464075015125223947", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 6, 21, 13, 36, 5, 902, DateTimeKind.Local).AddTicks(7313), new DateTime(2024, 1, 10, 23, 1, 10, 130, DateTimeKind.Local).AddTicks(5091), "أروى فريد", "Santino Orn", "جابر‌, معروف and زيد", "1113771818019692036", "El Salvador", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 5, 18, 21, 21, 6, 842, DateTimeKind.Local).AddTicks(979), new DateTime(2024, 1, 10, 20, 40, 6, 621, DateTimeKind.Local).AddTicks(8563), "طارق فؤاد", "Stacey Ziemann", "آدم, عصار and معروف", "2455675751111037744", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 5, 11, 23, 53, 28, 974, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 1, 11, 10, 41, 52, 169, DateTimeKind.Local).AddTicks(3516), "زيد حسن", "Grant Corkery", "صلاح - أسامة", "2513433659934640690", "Tonga", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 7, 25, 15, 0, 38, 735, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 1, 11, 8, 30, 32, 632, DateTimeKind.Local).AddTicks(3916), "أروى عراقی", "Carli Erdman", "طارق Group", "5437119659003048278", "Macedonia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 9, 3, 0, 29, 34, DateTimeKind.Local).AddTicks(7545), new DateTime(2024, 1, 11, 18, 37, 4, 541, DateTimeKind.Local).AddTicks(8316), "رنا عزیز", "Krista Christiansen", 1, "عقیل - عاشور", "3606803206525785350", "Paraguay", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 12, 21, 11, 56, 17, 689, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 1, 11, 3, 56, 28, 194, DateTimeKind.Local).AddTicks(6746), "منى عزیز", "Ima Kutch", 0, "فؤاد - عراقی", "8769118690530500056", "Saint Lucia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2003, 1, 8, 8, 52, 29, 277, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 1, 10, 23, 39, 56, 78, DateTimeKind.Local).AddTicks(9570), "فاطمة إيهاب", "Hugh Lesch", "عاشور, حازم and أسامة", "2516545690871357071", "Zimbabwe" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 11, 20, 10, 22, 0, 489, DateTimeKind.Local).AddTicks(9742), new DateTime(2024, 1, 11, 14, 25, 27, 652, DateTimeKind.Local).AddTicks(3797), "ريم عزیز", "Chadd Wilderman", "بلال, إيهاب and فؤاد", "7280665918079930220", "Gabon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 29, 7, 54, 49, 337, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 1, 11, 11, 19, 16, 464, DateTimeKind.Local).AddTicks(4374), "ربيع عاشور", "Liam Green", 1, "عصار - ربيع", "4196681804098887542", "Bahamas", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 6, 7, 17, 40, 10, 762, DateTimeKind.Local).AddTicks(6026), new DateTime(2024, 1, 11, 18, 54, 41, 443, DateTimeKind.Local).AddTicks(8568), "Pearl Mayer", 0, "صلاح, عزیز and ربيع", "7700266412336108577", "Haiti", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 2, 11, 22, 47, 6, 727, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 1, 11, 9, 22, 33, 324, DateTimeKind.Local).AddTicks(1411), "فريدة سعيد", "Pascale Borer", 1, "صلاح Group", "7562466086014351927", "Lebanon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 5, 17, 6, 46, 23, 234, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 1, 10, 23, 34, 43, 841, DateTimeKind.Local).AddTicks(6304), "سالم عزیز", "Emiliano Lang", "جابر‌ - إيهاب", "2304248750905404951", "Nicaragua" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 23, 12, 12, 48, 613, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 1, 11, 3, 57, 51, 903, DateTimeKind.Local).AddTicks(285), "زينب عزیز", "Jarrett Goyette", "عارف LLC", "2413787315773441889", "Japan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 7, 5, 6, 41, 5, 239, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 1, 10, 22, 51, 31, 741, DateTimeKind.Local).AddTicks(5060), "أروى فريد", "Isac Toy", 1, "عاشور - سالم", "4146601335780838729", "French Polynesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 28, 1, 2, 45, 483, DateTimeKind.Local).AddTicks(5023), new DateTime(2024, 1, 10, 23, 28, 10, 898, DateTimeKind.Local).AddTicks(8096), "إيهاب زيد", "Alexie Schuppe", "آدم, فريد and فاروق", "1011246246116112249", "Puerto Rico", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 8, 23, 21, 43, 0, 204, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 1, 11, 4, 14, 41, 728, DateTimeKind.Local).AddTicks(4546), "طارق حسن", "Ayla Feest", "سعيد, أمجد and عراقی", "691148185885462783", "Marshall Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 5, 27, 10, 22, 49, 974, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 1, 10, 23, 12, 11, 25, DateTimeKind.Local).AddTicks(4761), "إيهاب عراقی", "Hudson Jacobs", 1, "سعيد - معروف", "3756825549476619696", "Vanuatu", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 7, 12, 14, 12, 54, 730, DateTimeKind.Local).AddTicks(2283), new DateTime(2024, 1, 11, 4, 44, 16, 491, DateTimeKind.Local).AddTicks(6180), "جابر‌ إيهاب", "Gerald Gottlieb", "جابر‌ - أسامة", "9157067050317404588", "Lesotho", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 7, 30, 2, 23, 4, 77, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 1, 11, 4, 40, 34, 652, DateTimeKind.Local).AddTicks(1736), "منى أمجد", "Kenton Casper", "سعيد - سعيد", "2989638710960124465", "Turkmenistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 24, 8, 34, 36, 708, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 1, 11, 0, 52, 45, 408, DateTimeKind.Local).AddTicks(4870), "آية أمجد", "Berniece Pouros", "صلاح, عزیز and عزیز", "1708595185757070649", "Iraq", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 4, 30, 3, 19, 23, 691, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 1, 11, 7, 37, 55, 231, DateTimeKind.Local).AddTicks(3467), "عبير أسامة", "Margarete Zieme", 1, "آدم - أمجد", "1794715398241766036", "Belgium", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 5, 19, 10, 11, 0, 214, DateTimeKind.Local).AddTicks(4333), new DateTime(2024, 1, 11, 5, 41, 34, 215, DateTimeKind.Local).AddTicks(971), "طارق طارق", "Tiana Medhurst", "ربيع - عارف", "8047675559294422657", "Swaziland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 8, 23, 0, 29, 34, 771, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 1, 11, 15, 7, 3, 94, DateTimeKind.Local).AddTicks(3784), "حسن آدم", "Jaquan Mosciski", "أسامة Group", "6624692081510405441", "Macedonia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 10, 21, 6, 24, 51, 970, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 1, 11, 15, 9, 13, 654, DateTimeKind.Local).AddTicks(9740), "بلال حسن", "Austen Pfannerstill", "حازم - عاشور", "8665897487869945297", "Saint Pierre and Miquelon", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 10, 22, 17, 45, 38, 188, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 1, 11, 8, 40, 0, 774, DateTimeKind.Local).AddTicks(2467), "عبير معروف", "Gregoria Sawayn", 1, "فاروق, أسامة and فريد", "4051698102085247074", "Pakistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1974, 4, 5, 5, 40, 15, 446, DateTimeKind.Local).AddTicks(8101), new DateTime(2024, 1, 11, 2, 27, 27, 753, DateTimeKind.Local).AddTicks(9507), "ريم صلاح", "Shayna Monahan", 0, "جابر‌ - عارف", "4801832419582331430", "Guernsey" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1976, 6, 5, 14, 21, 33, 585, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 1, 11, 14, 11, 46, 924, DateTimeKind.Local).AddTicks(8426), "دانا آدم", "Cade Gleichner", 0, "معروف and Sons", "934913683560564996", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 12, 29, 20, 55, 43, 274, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 1, 11, 5, 21, 54, 362, DateTimeKind.Local).AddTicks(9231), "فاروق عقیل", "Luisa Fritsch", "فؤاد - آدم", "8238651794960255828", "Rwanda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1971, 5, 21, 13, 21, 11, 564, DateTimeKind.Local).AddTicks(5003), new DateTime(2024, 1, 11, 6, 17, 49, 818, DateTimeKind.Local).AddTicks(4625), "رقية حسن", "Kris Hermiston", 1, "فاروق and Sons", "287976674337852229", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 11, 17, 19, 59, 40, 175, DateTimeKind.Local).AddTicks(9957), new DateTime(2024, 1, 10, 21, 36, 37, 80, DateTimeKind.Local).AddTicks(3171), "ريم إيهاب", "Julius VonRueden", 0, "عقیل, فاروق and عزیز", "7393232556779708067", "Mozambique", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 5, 7, 5, 26, 41, 623, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 1, 11, 0, 20, 21, 836, DateTimeKind.Local).AddTicks(5253), "زيد عاشور", "Makenzie Stiedemann", "فاروق - طارق", "4323224280225040393", "Cameroon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 14, 17, 23, 53, 875, DateTimeKind.Local).AddTicks(2097), new DateTime(2024, 1, 10, 23, 26, 34, 350, DateTimeKind.Local).AddTicks(3247), "هاجر هاشم", "Abbie Ruecker", "سالم LLC", "7177393581728983652", "Nicaragua", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 9, 16, 3, 58, 6, 463, DateTimeKind.Local).AddTicks(9793), new DateTime(2024, 1, 11, 12, 58, 13, 340, DateTimeKind.Local).AddTicks(4590), "سالم عارف", "Valentina Kautzer", "فريد, زيد and حسن", "6407611510514033724", "Mayotte", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 5, 8, 25, 22, 969, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 1, 11, 18, 25, 32, 789, DateTimeKind.Local).AddTicks(8510), "إيهاب جابر‌", "Santino Greenholt", "عصار Group", "3611161252727895476", "Lesotho", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 11, 9, 6, 57, 37, 260, DateTimeKind.Local).AddTicks(6348), new DateTime(2024, 1, 11, 17, 31, 42, 60, DateTimeKind.Local).AddTicks(3813), "طارق فريد", "Cayla Little", 0, "أسامة - آدم", "8976393155896999366", "Estonia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 11, 12, 19, 1, 12, 177, DateTimeKind.Local).AddTicks(6614), new DateTime(2024, 1, 11, 4, 46, 13, 867, DateTimeKind.Local).AddTicks(466), "سالم سالم", "Jamie Dooley", "سالم - سالم", "357417620302037323", "American Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 7, 19, 22, 45, 37, 791, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 1, 11, 18, 0, 14, 257, DateTimeKind.Local).AddTicks(3820), "سالم عارف", "Marvin Hand", "حازم, زيد and فريد", "785638308724225760", "Nigeria", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 10, 18, 19, 3, 21, 382, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 1, 11, 13, 24, 39, 195, DateTimeKind.Local).AddTicks(7903), "فاطمة حسن", "Kennedy Nitzsche", "حازم - بلال", "388028965865222614", "Brunei Darussalam", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 1, 31, 23, 36, 4, 714, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 1, 11, 3, 10, 37, 122, DateTimeKind.Local).AddTicks(1690), "زينب بلال", "Larissa Schmitt", 0, "حسن Group", "8422012267001892430", "Chad", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 4, 12, 4, 30, 23, 969, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 1, 11, 13, 43, 41, 216, DateTimeKind.Local).AddTicks(1872), "دانا بلال", "Frederique Mosciski", 0, "هاشم and Sons", "3696665777639239385", "Holy See (Vatican City State)", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 11, 2, 11, 48, 57, 125, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 1, 11, 6, 38, 5, 415, DateTimeKind.Local).AddTicks(447), "رنا سعيد", "Johann Stark", "إيهاب, عقیل and عصار", "4319117960287178874", "Cuba", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 1, 20, 20, 15, 39, 180, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 1, 10, 21, 29, 30, 828, DateTimeKind.Local).AddTicks(8025), "رنا إيهاب", "Vern Grimes", "أسامة, حسن and عقیل", "9151473654600222441", "Micronesia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 7, 21, 6, 29, 7, 400, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 1, 11, 20, 18, 31, 716, DateTimeKind.Local).AddTicks(4655), "جابر‌ زيد", "Theron Conn", "بلال Group", "1891821775881972814", "Ethiopia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 2, 8, 13, 28, 24, 463, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 1, 11, 8, 26, 48, 497, DateTimeKind.Local).AddTicks(3386), "جمانة صلاح", "Adelle Batz", "حسن Group", "6421249621855788753", "Belgium", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 5, 12, 6, 24, 21, 696, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 1, 11, 18, 2, 22, 998, DateTimeKind.Local).AddTicks(6795), "لمى حازم", "Nyasia Fisher", "جابر‌ - حازم", "4252217795586116393", "Bosnia and Herzegovina", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 9, 29, 16, 30, 27, 3, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 1, 11, 20, 5, 48, 232, DateTimeKind.Local).AddTicks(3543), "طارق فريد", "Irving Lebsack", 1, "عراقی Inc", "7303458793283757018", "Gibraltar", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 10, 25, 9, 44, 41, 600, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 1, 11, 12, 40, 27, 616, DateTimeKind.Local).AddTicks(8987), "حسن جابر‌", "Lucio Blanda", "عراقی, عزیز and فؤاد", "1367453039109467387", "Kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 3, 8, 18, 54, 44, 194, DateTimeKind.Local).AddTicks(3047), new DateTime(2024, 1, 11, 6, 49, 8, 483, DateTimeKind.Local).AddTicks(7427), "جمانة زيد", "Christine Conroy", 1, "فؤاد and Sons", "771247788340620277", "Hong Kong", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 1, 2, 15, 46, 26, 194, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 1, 11, 14, 4, 51, 838, DateTimeKind.Local).AddTicks(7445), "زيد معروف", "Ahmed Jacobi", "سالم, عزیز and فؤاد", "7144153550173271350", "Kazakhstan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 11, 15, 12, 33, 43, 843, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 1, 11, 7, 27, 39, 167, DateTimeKind.Local).AddTicks(7884), "جمانة عصار", "Tara Marquardt", 1, "فريد - حسن", "2956084059508892113", "Romania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1984, 4, 15, 8, 42, 56, 883, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 1, 11, 17, 13, 37, 515, DateTimeKind.Local).AddTicks(3043), "جمانة جابر‌", "Ayla Skiles", 0, "بلال and Sons", "6632352758683786632", "Dominica" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 5, 11, 23, 8, 33, 570, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 1, 11, 12, 2, 22, 726, DateTimeKind.Local).AddTicks(7089), "هاجر زيد", "Martin Kerluke", "عاشور, عزیز and عارف", "5593222305939990102", "Libyan Arab Jamahiriya", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 11, 19, 14, 48, 4, 955, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 1, 11, 18, 48, 49, 545, DateTimeKind.Local).AddTicks(294), "فاروق عارف", "Cecil Stiedemann", "ربيع - فاروق", "6825153200068379736", "Cocos (Keeling) Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 8, 9, 14, 17, 17, 985, DateTimeKind.Local).AddTicks(6496), new DateTime(2024, 1, 11, 13, 13, 51, 645, DateTimeKind.Local).AddTicks(4156), "جابر‌ طارق", "Freddy Schmidt", "فاروق and Sons", "5684885756708595450", "Slovakia (Slovak Republic)", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 3, 2, 32, 56, 184, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 1, 11, 7, 36, 57, 428, DateTimeKind.Local).AddTicks(2511), "ربيع إيهاب", "Jerad Pfannerstill", 1, "أسامة - عصار", "6625033129427338059", "Brunei Darussalam", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 11, 24, 18, 28, 8, 460, DateTimeKind.Local).AddTicks(6036), new DateTime(2024, 1, 11, 12, 45, 47, 75, DateTimeKind.Local).AddTicks(4490), "إيناس عصار", "Jaleel Beatty", 1, "بلال LLC", "7657410458663491101", "Gambia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 12, 1, 22, 36, 38, 40, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 1, 11, 15, 27, 2, 481, DateTimeKind.Local).AddTicks(7824), "أروى جابر‌", "Andreanne Spencer", 1, "عاشور and Sons", "7159245106575680939", "Montserrat", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 5, 8, 14, 22, 33, 107, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 1, 11, 13, 47, 45, 285, DateTimeKind.Local).AddTicks(6454), "فريدة صلاح", "Thea Kling", "جابر‌ Group", "564429754649372582", "Honduras", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 11, 17, 18, 26, 14, 681, DateTimeKind.Local).AddTicks(8476), new DateTime(2024, 1, 11, 17, 45, 2, 405, DateTimeKind.Local).AddTicks(5220), "أمجد عقیل", "Preston Boehm", 0, "حازم, حسن and ربيع", "8678415142331324316", "New Zealand", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 12, 6, 10, 49, 22, 231, DateTimeKind.Local).AddTicks(4489), new DateTime(2024, 1, 11, 4, 49, 1, 662, DateTimeKind.Local).AddTicks(4844), "رنا عصار", "Laurine Reilly", "عقیل - أسامة", "8146193092870438496", "Faroe Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 8, 12, 17, 22, 59, 203, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 1, 11, 8, 29, 2, 676, DateTimeKind.Local).AddTicks(878), "ربيع أسامة", "Kiera Ryan", 1, "حسن LLC", "6520138983723824907", "United States of America" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 1, 7, 22, 8, 28, 129, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 1, 11, 18, 55, 39, 715, DateTimeKind.Local).AddTicks(2960), "فريد آدم", "Marge Parisian", "فؤاد - عارف", "5293604075376987669", "Peru", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 8, 0, 0, 23, 581, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 1, 11, 2, 49, 15, 102, DateTimeKind.Local).AddTicks(5361), "هاجر جابر‌", "Gracie Rutherford", 1, "حسن Group", "8774663522717340537", "Moldova", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 8, 31, 9, 9, 0, 885, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 1, 11, 11, 44, 27, 245, DateTimeKind.Local).AddTicks(6492), "أمجد فريد", "Eve Hirthe", "حازم - سعيد", "8380165462031275574", "Turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 11, 4, 18, 3, 18, 535, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 1, 11, 11, 16, 15, 298, DateTimeKind.Local).AddTicks(342), "أروى إيهاب", "Parker Romaguera", "معروف, فريد and صلاح", "6013118155729662634", "Angola", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 11, 26, 1, 42, 8, 986, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 1, 11, 9, 45, 46, 904, DateTimeKind.Local).AddTicks(4158), "ربيع فاروق", "Kimberly Renner", "أمجد, عزیز and إيهاب", "7331852465810217098", "New Caledonia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 6, 18, 18, 20, 12, 336, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 1, 11, 9, 43, 8, 786, DateTimeKind.Local).AddTicks(214), "هاجر فريد", "Margaretta Quigley", "عصار, آدم and عارف", "1301034723210508265", "Norway", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 9, 28, 0, 26, 1, 84, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 1, 11, 5, 16, 13, 905, DateTimeKind.Local).AddTicks(2919), "هاجر صلاح", "Marcia Muller", 0, "هاشم - معروف", "1448466143817486528", "San Marino" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 1, 9, 5, 55, 24, 41, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 1, 11, 3, 14, 27, 548, DateTimeKind.Local).AddTicks(5656), "آية أمجد", "Jorge Satterfield", "فاروق, زيد and معروف", "6872022802287258707", "Norfolk Island", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 11, 29, 20, 11, 38, 34, DateTimeKind.Local).AddTicks(1701), new DateTime(2024, 1, 11, 13, 11, 38, 905, DateTimeKind.Local).AddTicks(8745), "سعيد طارق", "Kale Ullrich", "زيد, جابر‌ and إيهاب", "1991186414789021625", "Niger", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 12, 31, 9, 58, 44, 369, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 1, 10, 22, 34, 49, 378, DateTimeKind.Local).AddTicks(6545), "عبير ربيع", "Kurt Schowalter", 0, "صلاح - أسامة", "4101182991219092921", "Antigua and Barbuda", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 4, 5, 7, 11, 24, 187, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 1, 11, 19, 31, 32, 654, DateTimeKind.Local).AddTicks(6156), "هاجر سعيد", "Bernhard Walter", "إيهاب and Sons", "4354760585248250570", "Liberia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 8, 10, 4, 45, 13, 384, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 1, 11, 9, 32, 47, 129, DateTimeKind.Local).AddTicks(441), "جمانة حسن", "Fiona O'Conner", "حازم Group", "4895849718185256738", "United States Minor Outlying Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 3, 17, 12, 57, 16, 515, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 1, 11, 17, 53, 56, 179, DateTimeKind.Local).AddTicks(4183), "جمانة بلال", "Douglas Aufderhar", "طارق - بلال", "1200763746464717355", "Bolivia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 11, 2, 21, 3, 42, 84, DateTimeKind.Local).AddTicks(5086), new DateTime(2024, 1, 11, 10, 45, 6, 309, DateTimeKind.Local).AddTicks(4912), "فاطمة سعيد", "Kirstin Ondricka", "حازم - إيهاب", "3758067515421165895", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 4, 5, 3, 53, 16, 66, DateTimeKind.Local).AddTicks(3259), new DateTime(2024, 1, 11, 14, 27, 22, 720, DateTimeKind.Local).AddTicks(4042), "إيناس عزیز", "Brando Hackett", 0, "بلال and Sons", "4772305947148134197", "Uzbekistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 5, 10, 12, 49, 0, 981, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 1, 11, 3, 43, 20, 868, DateTimeKind.Local).AddTicks(7193), "جمانة أسامة", "Scotty Johns", 1, "أسامة LLC", "2899440884940764161", "Turkmenistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 3, 5, 22, 57, 52, 974, DateTimeKind.Local).AddTicks(5832), new DateTime(2024, 1, 11, 11, 2, 10, 520, DateTimeKind.Local).AddTicks(9093), "ربيع صلاح", "Eulalia Stehr", 1, "سالم Inc", "2555740545892400807", "Turks and Caicos Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 12, 14, 9, 26, 20, 260, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 1, 11, 13, 25, 22, 736, DateTimeKind.Local).AddTicks(8219), "لمى عصار", "Reed Kirlin", 0, "4174073808811608485", "Malta" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 22, 17, 26, 42, 611, DateTimeKind.Local).AddTicks(3708), new DateTime(2024, 1, 11, 20, 1, 32, 213, DateTimeKind.Local).AddTicks(8919), "دانا فريد", "Jonatan Hand", "زيد, عارف and حازم", "6050445332433812873", "Burkina Faso", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 12, 14, 19, 20, 51, 179, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 1, 11, 6, 11, 51, 81, DateTimeKind.Local).AddTicks(5135), "زينب عاشور", "Letitia Haag", 0, "بلال - آدم", "3340566061997208732", "Saint Vincent and the Grenadines", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 4, 16, 9, 57, 1, 945, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 1, 11, 12, 46, 33, 380, DateTimeKind.Local).AddTicks(9748), "لمى أسامة", "Juston Bradtke", 0, "فريد - حسن", "2547908874777995689", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 12, 7, 5, 51, 9, 884, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 1, 11, 18, 41, 53, 995, DateTimeKind.Local).AddTicks(6812), "بلال أسامة", "Jarred Reynolds", 1, "عاشور - عصار", "2378304369859150848", "Lao People's Democratic Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 9, 26, 13, 26, 43, 694, DateTimeKind.Local).AddTicks(6381), new DateTime(2024, 1, 11, 19, 31, 22, 276, DateTimeKind.Local).AddTicks(110), "زينب عصار", "Christelle Hettinger", "بلال - عراقی", "8904218673354366193", "Mongolia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 3, 31, 19, 50, 1, 177, DateTimeKind.Local).AddTicks(2898), new DateTime(2024, 1, 11, 1, 2, 59, 569, DateTimeKind.Local).AddTicks(9816), "فريدة فريد", "Mabelle Grant", "فريد Inc", "8277277556394708130", "Israel", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 10, 14, 5, 18, 4, 493, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 1, 11, 17, 41, 43, 736, DateTimeKind.Local).AddTicks(4123), "دانا أسامة", "Dawson Cruickshank", 0, "سالم LLC", "6050638395022859473", "Afghanistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 6, 28, 8, 52, 33, 762, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 1, 11, 14, 28, 44, 735, DateTimeKind.Local).AddTicks(3427), "زيد جابر‌", "Roberto MacGyver", "سعيد - سعيد", "1279821754793663026", "Cote d'Ivoire" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 8, 9, 20, 25, 54, 407, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 1, 11, 10, 38, 15, 573, DateTimeKind.Local).AddTicks(417), "أمجد سالم", "Maybell Pacocha", "طارق Inc", "2400030958208958770", "Niue" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 10, 12, 18, 1, 35, 834, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 1, 11, 15, 47, 45, 999, DateTimeKind.Local).AddTicks(3429), "آدم عزیز", "Abe Thiel", "حازم, أمجد and ربيع", "4314764726458390266", "Switzerland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 12, 26, 2, 15, 40, 631, DateTimeKind.Local).AddTicks(2888), new DateTime(2024, 1, 11, 10, 20, 56, 246, DateTimeKind.Local).AddTicks(7275), "رنا عاشور", "Idella O'Hara", 0, "زيد, سالم and جابر‌", "7246058628610574676", "France", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 6, 20, 8, 29, 34, 171, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 1, 10, 22, 56, 21, 177, DateTimeKind.Local).AddTicks(4316), "أروى عاشور", "Tressie Maggio", "حازم and Sons", "1939513928471421093", "Austria", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 2, 28, 17, 8, 56, 913, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 1, 11, 17, 12, 4, 788, DateTimeKind.Local).AddTicks(4467), "أمجد زيد", "Tito Stiedemann", 0, "أمجد - أسامة", "6569850771113580023", "Saudi Arabia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 4, 20, 16, 35, 4, 703, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 1, 10, 22, 32, 1, 806, DateTimeKind.Local).AddTicks(9844), "دانا سعيد", "Salvador Upton", "عصار, فاروق and زيد", "8174502093089934326", "Republic of Korea", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 7, 9, 15, 53, 25, 916, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 1, 11, 18, 31, 51, 8, DateTimeKind.Local).AddTicks(6744), "ربيع بلال", "Asha Schmeler", 1, "أسامة - زيد", "7059461320464325934", "Turks and Caicos Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 10, 19, 16, 57, 38, 733, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 1, 11, 18, 59, 44, 864, DateTimeKind.Local).AddTicks(2151), "شيماء أمجد", "Julian Streich", 1, "معروف, جابر‌ and فاروق", "7244563270681090656", "Venezuela", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 15, 15, 6, 31, 406, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 1, 11, 6, 44, 28, 805, DateTimeKind.Local).AddTicks(2047), "آية صلاح", "Raleigh Nader", 1, "عاشور LLC", "6068645799134117171", "Gambia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 4, 20, 5, 49, 49, 307, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 1, 11, 17, 36, 36, 853, DateTimeKind.Local).AddTicks(1911), "لمى عصار", "Jazmyne Beier", "فريد Group", "5641352637396799349", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 1, 30, 0, 19, 38, 442, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 1, 11, 20, 28, 4, 217, DateTimeKind.Local).AddTicks(7852), "منى عزیز", "Moises Pollich", 0, "سالم Inc", "1090206449269472535", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 1, 16, 6, 37, 14, 225, DateTimeKind.Local).AddTicks(1699), new DateTime(2024, 1, 11, 0, 32, 1, 358, DateTimeKind.Local).AddTicks(4598), "منى عقیل", "Harry Lowe", 0, "عارف, أسامة and صلاح", "7869060743058054044", "Mauritius", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 5, 15, 12, 6, 28, 352, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 1, 11, 2, 38, 30, 238, DateTimeKind.Local).AddTicks(7328), "زينب طارق", "Hardy Price", "حازم, عقیل and عارف", "8064293677575587500", "Lao People's Democratic Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1988, 11, 9, 15, 42, 37, 935, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 1, 11, 17, 2, 28, 174, DateTimeKind.Local).AddTicks(4929), "ربيع عاشور", "Gisselle Bins", 1, "عزیز and Sons", "8056284977399997241", "Jersey" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 2, 17, 11, 3, 796, DateTimeKind.Local).AddTicks(7841), new DateTime(2024, 1, 11, 0, 24, 48, 492, DateTimeKind.Local).AddTicks(4446), "إيهاب فؤاد", "Lynn Rutherford", 0, "معروف LLC", "5377516724553888632", "Germany", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 6, 12, 11, 8, 12, 10, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 1, 11, 9, 2, 52, 402, DateTimeKind.Local).AddTicks(4058), "زيد عارف", "Missouri Koelpin", "أمجد and Sons", "3924665230796860669", "Gambia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 3, 5, 12, 1, 17, 925, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 1, 11, 10, 44, 29, 130, DateTimeKind.Local).AddTicks(5053), "آية عارف", "Baron Hackett", "إيهاب - عصار", "2464978231995067558", "Macao", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 8, 23, 21, 25, 48, 876, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 1, 11, 10, 47, 16, 563, DateTimeKind.Local).AddTicks(8805), "ريم أسامة", "Spencer Marks", 0, "عزیز LLC", "5720955285169730173", "Georgia", 2 });
        }
    }
}
