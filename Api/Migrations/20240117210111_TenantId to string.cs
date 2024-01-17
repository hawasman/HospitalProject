using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class TenantIdtostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TreatmentsHistory",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TreatmentsHistory",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tenants",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Tenants",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tenants",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Patients",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Patients",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Patients",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalFiles",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "MedicalFiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalFiles",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FinancialInfos",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "FinancialInfos",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsuranceExp",
                table: "FinancialInfos",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinancialInfos",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Examinations",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Examinations",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Examinations",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ContactInfos",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "ContactInfos",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Attachments",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Attachments",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Attachments",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سمیه, 005, جلاجل, United Kingdom", "خان شيخون", new DateTime(2024, 1, 17, 6, 0, 49, 686, DateTimeKind.Local).AddTicks(584), "dana.araqy9@hotmail.com", "251-702-2516 x9089", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, 29, سنار, Germany", "إب", new DateTime(2024, 1, 17, 4, 27, 24, 66, DateTimeKind.Local).AddTicks(3259), "blal.amjd@gmail.com", "(963) 380-9111 x5423", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش واعظی, 050, المنصورة, Belarus", "حلفا الجديدة", new DateTime(2024, 1, 17, 5, 46, 13, 88, DateTimeKind.Local).AddTicks(6175), "arwa_slah@gmail.com", "687-272-3600", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دستغیب, 0, بيت حانون, Cape Verde", "حارم", new DateTime(2024, 1, 17, 9, 15, 13, 791, DateTimeKind.Local).AddTicks(7279), "aadm33@gmail.com", "1-760-503-0452", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار راستوان, دوار فاطمی, 7, خان يونس, Heard Island and McDonald Islands", "تلكلخ", new DateTime(2024, 1, 17, 19, 48, 23, 800, DateTimeKind.Local).AddTicks(8046), "aayh_hazm@gmail.com", "(534) 888-4115 x701", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آزادی, شارع موحد دانش, 2, بور سعيد, Cambodia", "صور", new DateTime(2024, 1, 17, 17, 9, 11, 297, DateTimeKind.Local).AddTicks(1965), "hazm18@hotmail.com", "(956) 375-9561 x266", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, 3, أبو كبير, Romania", "عين اعبيد", new DateTime(2024, 1, 17, 3, 36, 2, 676, DateTimeKind.Local).AddTicks(4670), "sayd_fuad68@gmail.com", "1-980-336-4132", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دیباجی, تقاطع یادگار امام, 25, سطيف, Gambia", "طرابلس", new DateTime(2024, 1, 17, 4, 56, 13, 450, DateTimeKind.Local).AddTicks(2210), "arwa.salm19@gmail.com", "315-353-7005 x187", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آزادی, 9801, بريكة, Kyrgyz Republic", "برشيد", new DateTime(2024, 1, 17, 19, 38, 11, 89, DateTimeKind.Local).AddTicks(6296), "mna87@hotmail.com", "(207) 815-8012 x237", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اقبال لاهوری, ش ابوذر, 46, مدينة الصدر, Netherlands", "آلاك", new DateTime(2024, 1, 17, 2, 0, 11, 477, DateTimeKind.Local).AddTicks(3266), "blal.aashwr@yahoo.com", "(361) 561-4724", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق یادگار امام, شارع اقبال لاهوری, 545, بيت حانون, Gambia", "اكجوجت", new DateTime(2024, 1, 17, 20, 20, 0, 647, DateTimeKind.Local).AddTicks(1349), "jmanh.tarq69@hotmail.com", "(398) 427-6305", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دیباجی, طريق آفریقا, 010, المالكية, Uzbekistan", "سطيف", new DateTime(2024, 1, 17, 9, 7, 53, 516, DateTimeKind.Local).AddTicks(785), "lma.sayd@hotmail.com", "373.348.3807 x4187", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, طريق شهید مطهری, 080, كفر الشيخ, Mauritania", "دمياط", new DateTime(2024, 1, 17, 21, 1, 55, 792, DateTimeKind.Local).AddTicks(2244), "rbya27@gmail.com", "808-557-8630 x11362", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق واعظی, 35, بسكرة, Falkland Islands (Malvinas)", "بجاية", new DateTime(2024, 1, 17, 12, 47, 37, 380, DateTimeKind.Local).AddTicks(7393), "salm.iyhab52@gmail.com", "(843) 806-3473 x06527", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق کارگر شمالی, شارع استاد قریب, 4, البصرة, Belarus", "قليوب", new DateTime(2024, 1, 17, 5, 29, 15, 14, DateTimeKind.Local).AddTicks(9143), "lma65@yahoo.com", "883.838.6165", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع حقانی, ش آزادی, 6077, اوبيو, New Caledonia", "مدحاء", new DateTime(2024, 1, 17, 22, 37, 26, 298, DateTimeKind.Local).AddTicks(9111), "asamh59@yahoo.com", "(338) 798-5466 x7680", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار کارگر شمالی, دوار مالک اشتر, 51, الرمثا, Aruba", "الحسيمة", new DateTime(2024, 1, 17, 15, 39, 12, 274, DateTimeKind.Local).AddTicks(7075), "hazm_hsn@yahoo.com", "1-617-791-3284", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, 950, البليدة, Gambia", "تجكجة", new DateTime(2024, 1, 17, 10, 39, 33, 50, DateTimeKind.Local).AddTicks(6773), "abyr.araqy95@yahoo.com", "(635) 801-8600", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار هویزه, دوار سمیه, 5765, القحطانية, Samoa", "الدوحة", new DateTime(2024, 1, 17, 18, 27, 1, 336, DateTimeKind.Local).AddTicks(912), "asamh34@gmail.com", "996.741.4284", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آزادی, دوار سباری, 7766, السويداء, Anguilla", "باب الزوار", new DateTime(2024, 1, 17, 18, 26, 46, 507, DateTimeKind.Local).AddTicks(7200), "fatmh.hazm@yahoo.com", "619.244.6955 x452", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق رسالت, ش حقانی, 4189, السماوة, French Southern Territories", "سيدي بلعباس", new DateTime(2024, 1, 16, 23, 50, 25, 306, DateTimeKind.Local).AddTicks(4236), "zynb.fryd@hotmail.com", "488.785.0083", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آزادی, 6772, النبطية, Netherlands", "طرابلس", new DateTime(2024, 1, 17, 18, 33, 52, 87, DateTimeKind.Local).AddTicks(8577), "rna.araqy@gmail.com", "778.406.9224 x5370", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دکتر چمران, 764, غريان, Solomon Islands", "الرملة", new DateTime(2024, 1, 17, 9, 53, 52, 764, DateTimeKind.Local).AddTicks(1784), "rqyh_amjd88@hotmail.com", "540.662.4102", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار یادگار امام, 932, تلكلخ, Tanzania", "بور سعيد", new DateTime(2024, 1, 17, 8, 3, 27, 180, DateTimeKind.Local).AddTicks(301), "shymaa.hazm@hotmail.com", "(960) 608-7998", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آذربایجان, 0150, المالكية, Kazakhstan", "حلبجة", new DateTime(2024, 1, 17, 21, 13, 30, 439, DateTimeKind.Local).AddTicks(9939), "hajr_asar0@hotmail.com", "434-457-1448", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, 4708, الوجه, Maldives", "المسيلة", new DateTime(2024, 1, 17, 3, 6, 29, 948, DateTimeKind.Local).AddTicks(5186), "asamh89@gmail.com", "1-456-990-5912 x1598", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دستغیب, 5458, الرس, Bulgaria", "أم درمان", new DateTime(2024, 1, 16, 23, 46, 14, 468, DateTimeKind.Local).AddTicks(9390), "rqyh_hsn14@hotmail.com", "336-277-7186 x485", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, 9, الخميسات, Barbados", "عين اعبيد", new DateTime(2024, 1, 17, 12, 29, 14, 563, DateTimeKind.Local).AddTicks(8143), "farwq_fryd@yahoo.com", "1-564-398-8859", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع موحد دانش, طريق آزادی, 6377, زلفي, Mauritius", "الفيوم", new DateTime(2024, 1, 17, 20, 26, 40, 722, DateTimeKind.Local).AddTicks(4062), "farwq.hashm28@yahoo.com", "1-370-463-4574 x627", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار شهید مطهری, 177, بوكى, Burkina Faso", "غليزان", new DateTime(2024, 1, 17, 3, 47, 50, 784, DateTimeKind.Local).AddTicks(7484), "zyd.asar@gmail.com", "1-708-907-9811", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان امیرکبیر, دوار دستغیب, 8556, الزاوية, Moldova", "الإسماعيلية", new DateTime(2024, 1, 17, 18, 25, 14, 973, DateTimeKind.Local).AddTicks(677), "zynb_rbya@yahoo.com", "802.519.4031 x02026", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان شهید مطهری, 39, القنيطرة, Tuvalu", "السويداء", new DateTime(2024, 1, 17, 4, 58, 2, 677, DateTimeKind.Local).AddTicks(4526), "hajr.salm@yahoo.com", "(224) 630-1426", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش هویزه, 3, تبوك, Jamaica", "دسوق", new DateTime(2024, 1, 17, 8, 25, 5, 613, DateTimeKind.Local).AddTicks(7717), "rna60@yahoo.com", "1-677-404-5669 x91633", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق واعظی, ش رسالت, 22, العمران, Uruguay", "شرورة", new DateTime(2024, 1, 17, 0, 52, 39, 265, DateTimeKind.Local).AddTicks(4249), "mna25@hotmail.com", "490.663.4503 x844", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان حقانی, طريق یادگار امام, 9, يافا, Belize", "القائم", new DateTime(2024, 1, 17, 1, 12, 26, 365, DateTimeKind.Local).AddTicks(3386), "amjd.hashm@hotmail.com", "999.210.7452 x8327", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار رسالت, 624, سيان, Tuvalu", "الفجيرة", new DateTime(2024, 1, 17, 14, 55, 17, 296, DateTimeKind.Local).AddTicks(3027), "dana.farwq78@yahoo.com", "1-343-840-4167 x754", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, تقاطع یادگار امام, 2871, العقير, Tuvalu", "الوادي", new DateTime(2024, 1, 17, 16, 3, 11, 157, DateTimeKind.Local).AddTicks(1696), "fuad.farwq@gmail.com", "632.418.6768 x829", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق واعظی, 0, سلفيت, Algeria", "عدن", new DateTime(2024, 1, 17, 1, 1, 30, 473, DateTimeKind.Local).AddTicks(2551), "arwa96@hotmail.com", "663-909-0158", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع کارگر شمالی, ميدان ابوذر, 01, أم رواب, Macedonia", "المنستير", new DateTime(2024, 1, 17, 12, 30, 58, 334, DateTimeKind.Local).AddTicks(8946), "amjd67@gmail.com", "1-592-666-8470 x9252", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق رسالت, تقاطع اقبال لاهوری, 66, القبة, Bhutan", "رابغ", new DateTime(2024, 1, 17, 15, 17, 39, 765, DateTimeKind.Local).AddTicks(7816), "sarh99@hotmail.com", "(628) 332-9148 x99194", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 6, العقبة, Dominican Republic", "مادبا", new DateTime(2024, 1, 17, 8, 42, 19, 598, DateTimeKind.Local).AddTicks(478), "amjd.sayd74@hotmail.com", "(459) 270-4387 x64296", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دماوند, 96, مسعد, Bermuda", "بنها", new DateTime(2024, 1, 17, 20, 0, 59, 676, DateTimeKind.Local).AddTicks(8295), "asamh_aadm49@hotmail.com", "666-961-9716 x187", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, ميدان راستوان, 8, بورتسودان, Rwanda", "تعز", new DateTime(2024, 1, 17, 12, 35, 58, 598, DateTimeKind.Local).AddTicks(8144), "arwa1@yahoo.com", "1-596-839-2358", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, شارع آزادی, 5, عين وسارة, Somalia", "الفحيص", new DateTime(2024, 1, 17, 15, 34, 41, 858, DateTimeKind.Local).AddTicks(741), "hsn_hsn55@gmail.com", "1-946-954-9574 x3552", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دماوند, ش کارگر شمالی, 369, مقطع لحجار, Croatia", "دسوق", new DateTime(2024, 1, 17, 5, 15, 53, 30, DateTimeKind.Local).AddTicks(6660), "abyr.hsn60@hotmail.com", "(830) 382-8788 x996", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق راستوان, 16, أسيوط, Reunion", "الفلوجة", new DateTime(2024, 1, 17, 21, 28, 38, 882, DateTimeKind.Local).AddTicks(4606), "aadm_fryd60@hotmail.com", "(536) 690-6674", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, طريق سمیه, 3, الفيوم, Latvia", "زوارة", new DateTime(2024, 1, 17, 13, 4, 6, 169, DateTimeKind.Local).AddTicks(9507), "iynas11@yahoo.com", "1-509-600-5979 x7907", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دکتر چمران, طريق قدس, 67, الصويرة, Kenya", "خميس مشيط", new DateTime(2024, 1, 17, 1, 51, 19, 935, DateTimeKind.Local).AddTicks(4248), "zyd.aqyl57@yahoo.com", "665-921-0445 x43059", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, 843, كركوك, Turkmenistan", "بنغازي", new DateTime(2024, 1, 17, 9, 25, 58, 43, DateTimeKind.Local).AddTicks(4001), "zynb48@hotmail.com", "315-691-6836", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سمیه, 0, حديثة, Vanuatu", "بركاء", new DateTime(2024, 1, 17, 10, 21, 7, 44, DateTimeKind.Local).AddTicks(6279), "shymaa_zyd15@gmail.com", "(219) 743-9736 x9921", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع یادگار امام, ميدان دستغیب, 97, علي صبيح, Sierra Leone", "مطرح", new DateTime(2024, 1, 17, 1, 6, 31, 941, DateTimeKind.Local).AddTicks(7087), "shymaa.farwq40@hotmail.com", "1-832-488-7823", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش مالک اشتر, تقاطع سمیه, 5, القدس, Brunei Darussalam", "سكيكدة", new DateTime(2024, 1, 17, 9, 9, 23, 909, DateTimeKind.Local).AddTicks(500), "iyhab.hazm@gmail.com", "334.706.5051", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار هویزه, طريق آذربایجان, 7, غريان, Faroe Islands", "بور سعيد", new DateTime(2024, 1, 17, 6, 4, 17, 408, DateTimeKind.Local).AddTicks(9833), "tarq8@hotmail.com", "954.664.2310 x43071", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سباری, 3, العقبة, Pakistan", "الدامر", new DateTime(2024, 1, 17, 4, 15, 45, 867, DateTimeKind.Local).AddTicks(828), "lma_hazm38@gmail.com", "330-631-3231 x15912", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سمیه, دوار شهید مطهری, 713, مدينة الملك عبد الله الاقتصادية, Cocos (Keeling) Islands", "اوبيو", new DateTime(2024, 1, 17, 16, 13, 3, 893, DateTimeKind.Local).AddTicks(8517), "sarh_asamh15@gmail.com", "1-933-451-4305", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, 0, الأغواط, Mayotte", "القريات", new DateTime(2024, 1, 17, 18, 39, 41, 330, DateTimeKind.Local).AddTicks(8620), "rna.marwf48@hotmail.com", "1-481-994-7494 x12645", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سمیه, 1936, أسيوط, Thailand", "روصو", new DateTime(2024, 1, 16, 23, 55, 37, 688, DateTimeKind.Local).AddTicks(4668), "tarq_aarf67@hotmail.com", "219-740-3500", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار امیرکبیر, ميدان دماوند, 0459, سكاكا, French Southern Territories", "أرتا", new DateTime(2024, 1, 17, 19, 44, 47, 36, DateTimeKind.Local).AddTicks(5204), "hazm.rbya60@gmail.com", "1-802-843-7478 x10728", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, ميدان مالک اشتر, 11, الباحة, Tunisia", "سيان", new DateTime(2024, 1, 17, 15, 18, 1, 290, DateTimeKind.Local).AddTicks(1412), "shymaa58@yahoo.com", "(250) 762-4411", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان امیرکبیر, 062, صفاقس, French Guiana", "جنين", new DateTime(2024, 1, 17, 20, 28, 57, 975, DateTimeKind.Local).AddTicks(2841), "hsn37@gmail.com", "811-515-2757 x88146", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع امیرکبیر, 846, تزنيت, Saint Barthelemy", "حمص", new DateTime(2024, 1, 17, 6, 32, 58, 490, DateTimeKind.Local).AddTicks(1582), "zynb.aadm@yahoo.com", "445.653.4072 x89839", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار امیرکبیر, دوار استاد قریب, 076, كلميم, Egypt", "قلعة السراغنة", new DateTime(2024, 1, 17, 12, 28, 24, 168, DateTimeKind.Local).AddTicks(3793), "sarh_tarq32@yahoo.com", "1-350-668-6117", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق راستوان, 9, أسوان, Japan", "يافا", new DateTime(2024, 1, 17, 5, 0, 49, 627, DateTimeKind.Local).AddTicks(8125), "aayh85@yahoo.com", "598.280.9882 x3919", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سمیه, 24, يي, Canada", "ازويرات", new DateTime(2024, 1, 17, 19, 5, 23, 520, DateTimeKind.Local).AddTicks(4164), "farwq.azyz@yahoo.com", "1-298-988-9605 x32581", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, ميدان اقبال لاهوری, 1, الوادي, Western Sahara", "بورو", new DateTime(2024, 1, 17, 6, 35, 23, 33, DateTimeKind.Local).AddTicks(1723), "blal_azyz21@gmail.com", "661.537.1438", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان حقانی, 60, الحجرة, Virgin Islands, U.S.", "بنجرير", new DateTime(2024, 1, 17, 4, 24, 24, 606, DateTimeKind.Local).AddTicks(5593), "tarq99@hotmail.com", "929-282-2718 x51988", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دماوند, طريق اقبال لاهوری, 823, مدينة ستة أكتوبر, Botswana", "القبة", new DateTime(2024, 1, 17, 22, 5, 45, 769, DateTimeKind.Local).AddTicks(3948), "rbya.salm@yahoo.com", "(414) 567-7241", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آفریقا, 85, القائم, United Arab Emirates", "مكة المكرمة", new DateTime(2024, 1, 17, 0, 55, 36, 181, DateTimeKind.Local).AddTicks(191), "rym_hashm3@yahoo.com", "306.415.8141 x44046", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اجاره دار, شارع راستوان, 6, جالكاسيو, South Georgia and the South Sandwich Islands", "الصويرة", new DateTime(2024, 1, 17, 2, 1, 42, 548, DateTimeKind.Local).AddTicks(7625), "aadm.jabr@yahoo.com", "(337) 797-9247 x27313", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار مالک اشتر, 51, اللد, Liberia", "البيضاء", new DateTime(2024, 1, 17, 13, 39, 51, 117, DateTimeKind.Local).AddTicks(4089), "fuad12@hotmail.com", "1-918-347-5970 x422", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار مالک اشتر, ش اقبال لاهوری, 1, مدينة عيسى, Turkmenistan", "الأبيض", new DateTime(2024, 1, 17, 0, 9, 28, 7, DateTimeKind.Local).AddTicks(9851), "iynas_iyhab41@yahoo.com", "584-929-8319 x46185", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دستغیب, طريق آذربایجان, 9601, صحار, Eritrea", "السيب", new DateTime(2024, 1, 17, 17, 5, 36, 656, DateTimeKind.Local).AddTicks(9374), "fatmh84@gmail.com", "921-660-4456 x233", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار شهید مطهری, تقاطع دکتر چمران, 6126, الأغواط, British Indian Ocean Territory (Chagos Archipelago)", "القرداحة", new DateTime(2024, 1, 17, 1, 19, 38, 269, DateTimeKind.Local).AddTicks(4260), "iyhab54@yahoo.com", "1-305-221-0468 x00490", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار فاطمی, 38, الخمس, New Zealand", "المزاحمية", new DateTime(2024, 1, 17, 20, 47, 10, 400, DateTimeKind.Local).AddTicks(7870), "slah_farwq@hotmail.com", "650.487.2806", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, 461, درنة, Gambia", "ملكال", new DateTime(2024, 1, 17, 15, 55, 30, 900, DateTimeKind.Local).AddTicks(9878), "jmanh43@hotmail.com", "1-517-437-2705 x75215", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دکتر چمران, ش رسالت, 9220, الرويس, Cuba", "ازويرات", new DateTime(2024, 1, 16, 23, 1, 24, 594, DateTimeKind.Local).AddTicks(2137), "fatmh77@hotmail.com", "1-699-880-2388 x5574", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, ش فاطمی, 68, الأبيض, Cameroon", "الوجه", new DateTime(2024, 1, 17, 2, 15, 16, 181, DateTimeKind.Local).AddTicks(4149), "aadm11@yahoo.com", "1-889-523-4257 x052", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق قدس, دوار هویزه, 9, يي, Saint Kitts and Nevis", "المنامة", new DateTime(2024, 1, 17, 13, 6, 14, 52, DateTimeKind.Local).AddTicks(1306), "rbya_jabr16@yahoo.com", "1-666-786-9023", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع شهید مطهری, 957, عدن, Hong Kong", "ترهونة", new DateTime(2024, 1, 17, 6, 37, 36, 573, DateTimeKind.Local).AddTicks(8093), "asamh.jabr@yahoo.com", "1-289-299-1540 x8980", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, 933, جرجا, Solomon Islands", "الفاشر", new DateTime(2024, 1, 17, 12, 15, 2, 853, DateTimeKind.Local).AddTicks(1410), "fuad93@yahoo.com", "(233) 932-1804 x05820", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار یادگار امام, شارع استاد قریب, 313, العريش, Slovakia (Slovak Republic)", "سلمية", new DateTime(2024, 1, 17, 18, 31, 40, 83, DateTimeKind.Local).AddTicks(4471), "arwa.aqyl@gmail.com", "803-804-9002", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع حقانی, تقاطع واعظی, 0, عشرة رمضان, Turks and Caicos Islands", "أبو كبير", new DateTime(2024, 1, 17, 7, 53, 40, 664, DateTimeKind.Local).AddTicks(2451), "hsn34@hotmail.com", "(326) 252-3283", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آزادی, 50, دبا, Democratic People's Republic of Korea", "راس العين", new DateTime(2024, 1, 16, 23, 29, 59, 931, DateTimeKind.Local).AddTicks(7428), "amjd.tarq@gmail.com", "1-348-822-8868", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, 6, درعا, Suriname", "الوادي", new DateTime(2024, 1, 17, 11, 24, 35, 194, DateTimeKind.Local).AddTicks(7837), "sarh.asamh43@hotmail.com", "(395) 788-9149", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق ابوذر, 93, القيصومة, Egypt", "السيب", new DateTime(2024, 1, 17, 1, 50, 16, 793, DateTimeKind.Local).AddTicks(768), "arwa52@hotmail.com", "(893) 503-3425 x54897", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق اقبال لاهوری, تقاطع دکتر چمران, 58, دير القمر, Mauritius", "الرطبة", new DateTime(2024, 1, 17, 14, 7, 11, 26, DateTimeKind.Local).AddTicks(2785), "lma.farwq26@gmail.com", "1-784-735-3821 x1087", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار استاد قریب, 293, بالهو, Montenegro", "الثورة", new DateTime(2024, 1, 17, 15, 41, 17, 121, DateTimeKind.Local).AddTicks(387), "blal70@hotmail.com", "1-955-815-7465", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع شهید مطهری, دوار مالک اشتر, 6238, اليوسفية, India", "رندا", new DateTime(2024, 1, 17, 2, 43, 4, 708, DateTimeKind.Local).AddTicks(6158), "abyr_aarf@gmail.com", "736.533.0486 x29878", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش استاد قریب, 4780, الحسيمة, Egypt", "جرابلس", new DateTime(2024, 1, 17, 18, 53, 24, 682, DateTimeKind.Local).AddTicks(186), "abyr_marwf47@yahoo.com", "261.841.8811 x339", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آفریقا, ميدان آذربایجان, 681, بنجرير, Northern Mariana Islands", "الحريق", new DateTime(2024, 1, 17, 17, 33, 11, 859, DateTimeKind.Local).AddTicks(2226), "mna_hashm57@yahoo.com", "(717) 827-2736", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان واعظی, طريق دستغیب, 2, أخميم, Turkmenistan", "العلا", new DateTime(2024, 1, 17, 17, 25, 4, 259, DateTimeKind.Local).AddTicks(7732), "amjd_blal@yahoo.com", "1-759-440-1540 x425", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آفریقا, 18, الميادين, Finland", "سبها", new DateTime(2024, 1, 17, 11, 36, 55, 860, DateTimeKind.Local).AddTicks(5153), "blal_araqy16@gmail.com", "(321) 579-6228 x9140", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق ابوذر, ميدان موحد دانش, 2, مدينة عيسى, Czech Republic", "بيشة", new DateTime(2024, 1, 17, 3, 24, 27, 653, DateTimeKind.Local).AddTicks(4182), "blal89@hotmail.com", "1-917-695-9447", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سباری, 5867, الأغواط, Niue", "السبت اولاد النمة", new DateTime(2024, 1, 17, 16, 24, 49, 109, DateTimeKind.Local).AddTicks(9895), "salm71@hotmail.com", "(794) 803-5108 x454", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار استاد قریب, 7570, طنجة, Bulgaria", "عفيف", new DateTime(2024, 1, 17, 6, 13, 31, 528, DateTimeKind.Local).AddTicks(6032), "abyr_aadm94@gmail.com", "945-423-4116 x30600", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 02, سطات, Iraq", "صافيتا", new DateTime(2024, 1, 17, 14, 23, 42, 629, DateTimeKind.Local).AddTicks(7207), "asamh_farwq@yahoo.com", "1-550-938-7598", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آفریقا, طريق آفریقا, 57, برشيد, Grenada", "خان شيخون", new DateTime(2024, 1, 17, 19, 52, 18, 321, DateTimeKind.Local).AddTicks(2138), "hajr53@gmail.com", "1-977-987-0259 x5685", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار هویزه, طريق دیباجی, 63, بنى سويف, Dominican Republic", "أبو كمال", new DateTime(2024, 1, 16, 23, 33, 30, 861, DateTimeKind.Local).AddTicks(1525), "fuad_hashm62@hotmail.com", "381-593-0784", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار شهید مطهری, تقاطع آذربایجان, 8584, المطرية, Israel", "الحسيمة", new DateTime(2024, 1, 17, 15, 6, 49, 658, DateTimeKind.Local).AddTicks(8039), "slah22@yahoo.com", "(627) 684-9055", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آزادی, 9, العيون, Bulgaria", "الشامية", new DateTime(2024, 1, 17, 2, 57, 6, 455, DateTimeKind.Local).AddTicks(7679), "shymaa68@gmail.com", "1-728-338-3171", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان یادگار امام, ميدان دکتر چمران, 597, بسكرة, Belize", "دورا", new DateTime(2024, 1, 17, 20, 48, 12, 511, DateTimeKind.Local).AddTicks(8409), "hazm.fryd79@hotmail.com", "1-870-654-3588 x915", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آفریقا, 3920, بريدة‏, Namibia", "طرطوس", new DateTime(2024, 1, 17, 12, 50, 36, 502, DateTimeKind.Local).AddTicks(9202), "shymaa24@gmail.com", "1-915-306-0177 x60776", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, 308, يريم, Djibouti", "القطيف", new DateTime(2024, 1, 17, 14, 36, 39, 931, DateTimeKind.Local).AddTicks(2434), "rna_slah@gmail.com", "404.556.2786 x4224", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق کارگر شمالی, طريق واعظی, 65, تل رفعت, Oman", "مدينة الحرير", new DateTime(2024, 1, 16, 23, 19, 5, 965, DateTimeKind.Local).AddTicks(1564), "slah.rbya@gmail.com", "1-853-998-5232", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع امیرکبیر, طريق سمیه, 851, الحلة, Colombia", "الرياض", new DateTime(2024, 1, 17, 10, 36, 54, 299, DateTimeKind.Local).AddTicks(2836), "hajr.salm@yahoo.com", "383-789-2891 x77610", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش یادگار امام, 4, حائل, Macao", "صوران", new DateTime(2024, 1, 17, 15, 28, 33, 710, DateTimeKind.Local).AddTicks(1627), "rbya.aarf@hotmail.com", "(402) 657-3848 x0125", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دماوند, ميدان استاد قریب, 6337, قصرين, Saudi Arabia", "طرطوس", new DateTime(2024, 1, 17, 7, 31, 20, 682, DateTimeKind.Local).AddTicks(3220), "blal_zyd76@gmail.com", "361.894.0261 x270", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, 8, البصرة, Sao Tome and Principe", "جبلة", new DateTime(2024, 1, 17, 15, 43, 0, 134, DateTimeKind.Local).AddTicks(8857), "fryd_jabr@yahoo.com", "258.265.0857 x51110", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سباری, دوار آفریقا, 3803, بريدة‏, New Caledonia", "ازرع", new DateTime(2024, 1, 17, 5, 41, 49, 773, DateTimeKind.Local).AddTicks(3973), "salm.sayd@gmail.com", "936-877-0614 x67664", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان موحد دانش, طريق راستوان, 2035, مصيرة, Switzerland", "عدل بكرو", new DateTime(2024, 1, 17, 10, 9, 13, 40, DateTimeKind.Local).AddTicks(9488), "blal77@gmail.com", "1-357-552-7455 x25921", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سمیه, تقاطع سمیه, 24, أسوان, Sierra Leone", "البيرة", new DateTime(2024, 1, 17, 6, 28, 55, 172, DateTimeKind.Local).AddTicks(2181), "sarh13@gmail.com", "572.939.5744 x54547", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, ميدان واعظی, 4291, طرابلس, Namibia", "سترة", new DateTime(2024, 1, 17, 5, 8, 7, 698, DateTimeKind.Local).AddTicks(1703), "lma38@hotmail.com", "851-280-5090 x15956", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق اجاره دار, ميدان سمیه, 8, جت, Hong Kong", "فيفاء", new DateTime(2024, 1, 17, 6, 44, 11, 494, DateTimeKind.Local).AddTicks(8990), "hajr37@gmail.com", "1-225-286-5322 x37849", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آفریقا, طريق واعظی, 2711, الغردقة, Antarctica (the territory South of 60 deg S)", "جسر الشغور", new DateTime(2024, 1, 17, 6, 9, 41, 26, DateTimeKind.Local).AddTicks(8339), "aayh.slah9@hotmail.com", "314.246.9428", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سباری, طريق امیرکبیر, 5, جيجل, Gabon", "غزة", new DateTime(2024, 1, 17, 7, 34, 43, 577, DateTimeKind.Local).AddTicks(2291), "abyr87@gmail.com", "(945) 887-3620", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, دوار امیرکبیر, 599, عين البيضاء, United Arab Emirates", "كفر قاسم", new DateTime(2024, 1, 17, 12, 27, 8, 381, DateTimeKind.Local).AddTicks(3024), "mna_blal@gmail.com", "1-529-703-2243", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق ابوذر, شارع مالک اشتر, 12, غريان, Malawi", "مسيعيد", new DateTime(2024, 1, 17, 22, 22, 29, 144, DateTimeKind.Local).AddTicks(2984), "zynb_rbya@yahoo.com", "(869) 845-2764", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دیباجی, تقاطع دیباجی, 9156, القطيف, Latvia", "نجران", new DateTime(2024, 1, 17, 8, 9, 16, 268, DateTimeKind.Local).AddTicks(3909), "sayd50@gmail.com", "249-248-9858", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اقبال لاهوری, 1, صلالة, Chile", "دير عطية", new DateTime(2024, 1, 17, 6, 52, 29, 469, DateTimeKind.Local).AddTicks(241), "sayd24@yahoo.com", "245.802.6903 x33446", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار واعظی, 76, شلالة العذاورة, Palau", "جونية", new DateTime(2024, 1, 17, 5, 58, 19, 843, DateTimeKind.Local).AddTicks(5849), "sarh_hsn@gmail.com", "574-594-1716", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سمیه, دوار فاطمی, 5551, صحم, Syrian Arab Republic", "حجة", new DateTime(2024, 1, 17, 12, 43, 23, 924, DateTimeKind.Local).AddTicks(7783), "tarq.zyd@yahoo.com", "1-826-587-5501", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, تقاطع دکتر چمران, 119, ميت غمر, Vietnam", "الدامر", new DateTime(2024, 1, 17, 9, 41, 15, 78, DateTimeKind.Local).AddTicks(9250), "aadm41@hotmail.com", "202-387-9418", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 687, ثادق, Swaziland", "مدحاء", new DateTime(2024, 1, 17, 11, 21, 1, 24, DateTimeKind.Local).AddTicks(7444), "iynas53@yahoo.com", "(295) 712-6937", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع راستوان, طريق امیرکبیر, 67, مصراتة, United States Minor Outlying Islands", "إب", new DateTime(2024, 1, 17, 19, 48, 18, 435, DateTimeKind.Local).AddTicks(4803), "rqyh_salm@hotmail.com", "797.926.3732", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق کارگر شمالی, ميدان اجاره دار, 5, خان يونس, Syrian Arab Republic", "الفحيص", new DateTime(2024, 1, 17, 3, 54, 50, 606, DateTimeKind.Local).AddTicks(9463), "iynas.jabr50@gmail.com", "1-367-789-2586 x0010", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دستغیب, 79, سمائل, Oman", "الإسماعيلية", new DateTime(2024, 1, 17, 12, 18, 37, 875, DateTimeKind.Local).AddTicks(1314), "aayh.salm7@hotmail.com", "806-338-7332 x6232", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دستغیب, طريق هویزه, 670, سلفيت, Netherlands Antilles", "أوبوك", new DateTime(2024, 1, 17, 11, 4, 28, 309, DateTimeKind.Local).AddTicks(5251), "fuad.fryd@hotmail.com", "1-973-732-0636 x24482", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دکتر چمران, 419, بنجرير, Democratic People's Republic of Korea", "القائم", new DateTime(2024, 1, 17, 13, 5, 49, 908, DateTimeKind.Local).AddTicks(413), "aadm_blal@gmail.com", "619-577-8744 x15160", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سباری, 626, دبى, Jersey", "بن عروس", new DateTime(2024, 1, 17, 18, 54, 59, 130, DateTimeKind.Local).AddTicks(3924), "hajr2@hotmail.com", "1-533-296-8508 x3502", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق امیرکبیر, دوار کارگر شمالی, 8, المنطقة الخضراء, Saint Helena", "الرميلة", new DateTime(2024, 1, 17, 3, 30, 14, 168, DateTimeKind.Local).AddTicks(4945), "hazm.aarf67@hotmail.com", "830.949.3360", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع مالک اشتر, 61, سوهاج, Cote d'Ivoire", "المحلة الكبرى", new DateTime(2024, 1, 17, 4, 37, 4, 322, DateTimeKind.Local).AddTicks(7950), "lma0@gmail.com", "647.223.3150", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سباری, 172, رام الله, Belgium", "ابراء", new DateTime(2024, 1, 17, 13, 3, 15, 249, DateTimeKind.Local).AddTicks(2553), "fryd_aadm@gmail.com", "(807) 323-4432", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع رسالت, 15, الناصرة, Pitcairn Islands", "مرسى مطروح", new DateTime(2024, 1, 17, 1, 13, 57, 910, DateTimeKind.Local).AddTicks(5919), "amjd88@hotmail.com", "1-346-911-6642", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع مالک اشتر, ميدان دیباجی, 2, باتنة, Canada", "السويداء", new DateTime(2024, 1, 17, 17, 3, 28, 112, DateTimeKind.Local).AddTicks(2590), "jabr.sayd56@gmail.com", "(796) 229-9375 x070", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آفریقا, دوار اجاره دار, 790, شمسطار, Poland", "مصراتة", new DateTime(2024, 1, 17, 21, 55, 29, 364, DateTimeKind.Local).AddTicks(3116), "arwa_tarq90@gmail.com", "791.911.1662 x78714", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش قدس, طريق فاطمی, 6, أم درمان, Gibraltar", "جدة", new DateTime(2024, 1, 17, 22, 35, 35, 73, DateTimeKind.Local).AddTicks(348), "aayh_hashm31@gmail.com", "(755) 389-8402 x996", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان قدس, 8278, القبة, Greenland", "القدس", new DateTime(2024, 1, 17, 13, 26, 22, 270, DateTimeKind.Local).AddTicks(8353), "farwq79@yahoo.com", "320.530.8813 x3535", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, دوار شهید مطهری, 9560, بلد, Brazil", "أوبوك", new DateTime(2024, 1, 17, 21, 14, 3, 39, DateTimeKind.Local).AddTicks(5094), "fryd90@gmail.com", "419.513.7179", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سمیه, ش دستغیب, 9, مسعد, Vietnam", "بنت جبيل", new DateTime(2024, 1, 17, 16, 11, 32, 762, DateTimeKind.Local).AddTicks(5224), "amjd68@gmail.com", "545.687.1377 x2501", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دکتر چمران, تقاطع سمیه, 6210, الفحيحيل, Cook Islands", "السويداء", new DateTime(2024, 1, 16, 23, 14, 3, 110, DateTimeKind.Local).AddTicks(8889), "hsn.asamh@gmail.com", "1-820-457-4258", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق حقانی, 7129, النبطية, Syrian Arab Republic", "السيب", new DateTime(2024, 1, 17, 8, 1, 58, 276, DateTimeKind.Local).AddTicks(3897), "shymaa30@hotmail.com", "(420) 232-3135", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع رسالت, تقاطع آفریقا, 042, نابلس, Kyrgyz Republic", "البغدادي", new DateTime(2024, 1, 17, 4, 20, 56, 880, DateTimeKind.Local).AddTicks(2224), "fatmh_aqyl@gmail.com", "560-939-3809", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان استاد قریب, 560, الرستاق, Kenya", "الطريف", new DateTime(2024, 1, 17, 0, 12, 12, 804, DateTimeKind.Local).AddTicks(9604), "fatmh71@yahoo.com", "698.868.6698 x889", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق امیرکبیر, 83, الرمادي, Guernsey", "بنزرت", new DateTime(2024, 1, 17, 19, 43, 47, 489, DateTimeKind.Local).AddTicks(7325), "salm.azyz37@gmail.com", "501.445.5872 x42957", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار شهید مطهری, 45, الخرطوم, Gibraltar", "كسماوي", new DateTime(2024, 1, 17, 21, 5, 22, 897, DateTimeKind.Local).AddTicks(2327), "fryd_azyz18@gmail.com", "379-203-1043 x02194", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سباری, 24, قرية سار, Malaysia", "المسيلة", new DateTime(2024, 1, 17, 19, 32, 14, 3, DateTimeKind.Local).AddTicks(2102), "jabr63@hotmail.com", "621-697-0311", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آفریقا, طريق رسالت, 9600, القيروان, Uruguay", "الديوانية", new DateTime(2024, 1, 17, 16, 58, 4, 45, DateTimeKind.Local).AddTicks(2565), "rym53@yahoo.com", "865-818-1975 x9643", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, طريق اقبال لاهوری, 8, البديع, Austria", "بريكة", new DateTime(2024, 1, 17, 4, 48, 34, 966, DateTimeKind.Local).AddTicks(8439), "asamh.jabr40@hotmail.com", "965-488-1025 x954", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, 6756, إدفو, Montserrat", "غريان", new DateTime(2024, 1, 17, 4, 57, 37, 447, DateTimeKind.Local).AddTicks(7495), "iynas8@gmail.com", "1-980-889-7247 x749", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آزادی, شارع سمیه, 77, رداع, Ecuador", "الجوف", new DateTime(2024, 1, 17, 15, 39, 30, 89, DateTimeKind.Local).AddTicks(3258), "blal_tarq@yahoo.com", "797.977.7519 x2284", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دیباجی, طريق سمیه, 2642, الخبر, Morocco", "العزيزية", new DateTime(2024, 1, 17, 14, 1, 1, 152, DateTimeKind.Local).AddTicks(5235), "shymaa91@gmail.com", "(215) 408-8580 x186", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 686, الوادي, Zimbabwe", "الرستاق", new DateTime(2024, 1, 17, 13, 55, 11, 993, DateTimeKind.Local).AddTicks(2252), "aadm_hashm@hotmail.com", "370-956-7769", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آزادی, تقاطع اقبال لاهوری, 6594, جاردو, Colombia", "الرطبة", new DateTime(2024, 1, 17, 12, 59, 23, 643, DateTimeKind.Local).AddTicks(4263), "farwq41@yahoo.com", "651-578-4167 x555", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار استاد قریب, 962, عين العرب, Palestinian Territory", "أسيلا", new DateTime(2024, 1, 17, 22, 52, 37, 775, DateTimeKind.Local).AddTicks(8155), "sarh30@gmail.com", "1-431-828-1222 x225", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دکتر چمران, ش سباری, 6, المزاحمية, Martinique", "عبري", new DateTime(2024, 1, 17, 15, 34, 36, 120, DateTimeKind.Local).AddTicks(6199), "aayh63@yahoo.com", "645-291-5064 x04774", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار قدس, 139, أبو ظبي, Ethiopia", "أربيل", new DateTime(2024, 1, 17, 17, 16, 53, 2, DateTimeKind.Local).AddTicks(4343), "abyr_iyhab@yahoo.com", "(521) 246-8171", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش استاد قریب, طريق دیباجی, 23, المقدادية, Macao", "رفحا", new DateTime(2024, 1, 17, 19, 10, 50, 707, DateTimeKind.Local).AddTicks(8643), "fatmh_rbya@gmail.com", "1-568-728-3600", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دستغیب, تقاطع کارگر شمالی, 7, عجلون, Heard Island and McDonald Islands", "بلد", new DateTime(2024, 1, 17, 16, 33, 16, 332, DateTimeKind.Local).AddTicks(2272), "fryd56@hotmail.com", "492.837.7565", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان استاد قریب, 72, بيت لحم, Colombia", "العقبة", new DateTime(2024, 1, 17, 4, 42, 20, 70, DateTimeKind.Local).AddTicks(5788), "slah15@hotmail.com", "671.281.1562", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار کارگر شمالی, ش دماوند, 3177, هيت, Montserrat", "نابلس", new DateTime(2024, 1, 17, 19, 44, 8, 581, DateTimeKind.Local).AddTicks(4946), "dana6@hotmail.com", "270.853.1396 x8677", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دیباجی, شارع دکتر چمران, 144, جسر الشغور, Mali", "اوبيو", new DateTime(2024, 1, 17, 7, 20, 46, 27, DateTimeKind.Local).AddTicks(6485), "blal_marwf31@hotmail.com", "892.678.2903", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع قدس, دوار امیرکبیر, 97, الديوانية, Gambia", "خنيفرة", new DateTime(2024, 1, 17, 7, 42, 12, 42, DateTimeKind.Local).AddTicks(8620), "fatmh6@hotmail.com", "325.444.2693", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آفریقا, 549, السيب, Mauritius", "الرطبة", new DateTime(2024, 1, 17, 7, 42, 38, 281, DateTimeKind.Local).AddTicks(540), "fatmh_asar14@hotmail.com", "(920) 535-5660", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار امیرکبیر, 73, دبى, Philippines", "بيت الفقيه", new DateTime(2024, 1, 17, 7, 11, 27, 42, DateTimeKind.Local).AddTicks(388), "zyd_asar@hotmail.com", "1-517-704-1072", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, شارع قدس, 855, الجفر, Belarus", "طولكرم", new DateTime(2024, 1, 17, 17, 34, 27, 300, DateTimeKind.Local).AddTicks(1696), "sarh.azyz@yahoo.com", "1-554-567-9948 x60469", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار سمیه, شارع موحد دانش, 2, ثادق, Falkland Islands (Malvinas)", "الدوحة", new DateTime(2024, 1, 17, 10, 41, 2, 356, DateTimeKind.Local).AddTicks(404), "sayd_aqyl73@gmail.com", "1-364-788-2422", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق یادگار امام, 3129, ثقبة, Palau", "تلكلخ", new DateTime(2024, 1, 17, 0, 33, 15, 317, DateTimeKind.Local).AddTicks(616), "shymaa_azyz@yahoo.com", "376-910-3051", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق رسالت, ش یادگار امام, 345, الرويس, Sweden", "بوكى", new DateTime(2024, 1, 17, 10, 7, 10, 528, DateTimeKind.Local).AddTicks(5036), "slah19@yahoo.com", "1-750-655-1388 x1686", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دماوند, 1811, مصراتة, Armenia", "سطات", new DateTime(2024, 1, 17, 5, 3, 54, 677, DateTimeKind.Local).AddTicks(9179), "sayd11@hotmail.com", "373.348.1303 x955", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, شارع اقبال لاهوری, 13, الليث, Eritrea", "ذمار", new DateTime(2024, 1, 17, 6, 58, 56, 468, DateTimeKind.Local).AddTicks(895), "asamh_salm6@hotmail.com", "838-386-8100 x7896", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, 9, نزوى, Tajikistan", "الجفر", new DateTime(2024, 1, 17, 21, 41, 2, 242, DateTimeKind.Local).AddTicks(2126), "hajr_blal@hotmail.com", "364-476-9438 x42658", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, 4880, نابل, Guinea", "الوجه", new DateTime(2024, 1, 17, 22, 7, 43, 217, DateTimeKind.Local).AddTicks(1857), "fryd55@gmail.com", "1-619-947-7702 x6263", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش ابوذر, 397, صلالة, Slovakia (Slovak Republic)", "برج بو عريريج", new DateTime(2024, 1, 17, 2, 57, 58, 961, DateTimeKind.Local).AddTicks(2165), "rqyh46@gmail.com", "338-855-2750", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, شارع سمیه, 919, الدوحة, Israel", "ملكال", new DateTime(2024, 1, 17, 5, 53, 41, 310, DateTimeKind.Local).AddTicks(2260), "aadm.araqy@gmail.com", "971.467.2091 x38157", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, 299, خريبكة, Belize", "داريا", new DateTime(2024, 1, 17, 11, 33, 48, 761, DateTimeKind.Local).AddTicks(9886), "asamh.araqy@gmail.com", "1-325-576-7687 x190", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دستغیب, 4761, ليوا, Holy See (Vatican City State)", "سنجة", new DateTime(2024, 1, 17, 14, 6, 38, 602, DateTimeKind.Local).AddTicks(1482), "hajr25@hotmail.com", "268-255-0243 x5594", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان رسالت, طريق سمیه, 2, غريان, Montenegro", "المرج", new DateTime(2024, 1, 17, 2, 52, 28, 434, DateTimeKind.Local).AddTicks(3911), "mna_araqy@yahoo.com", "(478) 864-9711", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع واعظی, دوار دیباجی, 305, القنفذة, United Arab Emirates", "تيماء", new DateTime(2024, 1, 17, 2, 58, 15, 510, DateTimeKind.Local).AddTicks(9685), "jmanh_hsn@hotmail.com", "1-317-273-8297 x30917", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دکتر چمران, تقاطع اقبال لاهوری, 75, الليث, Lao People's Democratic Republic", "بغداد", new DateTime(2024, 1, 17, 20, 42, 55, 559, DateTimeKind.Local).AddTicks(8919), "shymaa_azyz@yahoo.com", "842.872.6385 x80122", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آزادی, 16, صلخد, Northern Mariana Islands", "دمشق", new DateTime(2024, 1, 17, 10, 34, 21, 963, DateTimeKind.Local).AddTicks(8241), "dana_aarf@yahoo.com", "768.567.3762", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دکتر چمران, طريق آزادی, 295, القرداحة, Central African Republic", "السويق", new DateTime(2024, 1, 16, 23, 20, 50, 795, DateTimeKind.Local).AddTicks(5239), "zyd_fuad39@gmail.com", "419-386-4037 x18090", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان واعظی, 0, الجزائر, Togo", "ذمار", new DateTime(2024, 1, 17, 16, 11, 8, 875, DateTimeKind.Local).AddTicks(8276), "rym14@yahoo.com", "1-315-355-1462 x1236", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع قدس, تقاطع ابوذر, 8145, سيهات, Saint Martin", "العضيلية", new DateTime(2024, 1, 17, 11, 17, 22, 494, DateTimeKind.Local).AddTicks(6404), "arwa_araqy10@gmail.com", "927-488-7538", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع استاد قریب, ميدان سباری, 3054, زبيد, Germany", "اكجوجت", new DateTime(2024, 1, 17, 13, 37, 25, 597, DateTimeKind.Local).AddTicks(6159), "lma_fuad22@hotmail.com", "467.812.9670 x1485", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش قدس, 9, الجوف, New Caledonia", "عطبرة", new DateTime(2024, 1, 17, 20, 26, 28, 255, DateTimeKind.Local).AddTicks(6530), "frydh.slah84@gmail.com", "1-911-273-9225", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع رسالت, طريق موحد دانش, 13, سيلبابي, Republic of Korea", "خان شيخون", new DateTime(2024, 1, 17, 20, 32, 57, 393, DateTimeKind.Local).AddTicks(228), "mna.zyd@hotmail.com", "1-492-245-6330", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, شارع موحد دانش, 1420, القرداحة, Austria", "رأس تنورة", new DateTime(2024, 1, 17, 13, 50, 45, 132, DateTimeKind.Local).AddTicks(2481), "farwq_marwf80@hotmail.com", "(605) 299-7040 x6107", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دکتر چمران, دوار آزادی, 4265, دمياط, South Georgia and the South Sandwich Islands", "النبطية", new DateTime(2024, 1, 17, 5, 14, 21, 5, DateTimeKind.Local).AddTicks(1393), "iynas36@hotmail.com", "884-350-6329", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار مالک اشتر, شارع شهید مطهری, 60, خور أنجار, Israel", "الرفاع الغربي", new DateTime(2024, 1, 17, 22, 9, 52, 310, DateTimeKind.Local).AddTicks(658), "hazm21@hotmail.com", "(495) 940-8776", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سباری, طريق دیباجی, 60, ثادق, Tunisia", "مدينة الكويت", new DateTime(2024, 1, 17, 1, 58, 35, 978, DateTimeKind.Local).AddTicks(455), "zynb.araqy@hotmail.com", "834.219.4694 x0579", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار حقانی, 723, جنين, Spain", "راس العين", new DateTime(2024, 1, 17, 17, 36, 17, 838, DateTimeKind.Local).AddTicks(706), "tarq51@yahoo.com", "311-557-2421", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع واعظی, 6822, حائل, Canada", "النهود", new DateTime(2024, 1, 17, 12, 37, 49, 859, DateTimeKind.Local).AddTicks(9800), "arwa_marwf@yahoo.com", "1-658-827-1412", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دکتر چمران, 888, تنومة, Romania", "القحطانية", new DateTime(2024, 1, 17, 3, 5, 40, 228, DateTimeKind.Local).AddTicks(4363), "shymaa_asar@hotmail.com", "257.556.4723 x74343", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق حقانی, 7233, خور أنجار, Somalia", "لوك", new DateTime(2024, 1, 17, 18, 37, 41, 480, DateTimeKind.Local).AddTicks(9350), "dana_farwq57@hotmail.com", "694-681-6794 x4170", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق موحد دانش, طريق موحد دانش, 1430, حلبجة, Martinique", "بغداد", new DateTime(2024, 1, 17, 20, 0, 45, 313, DateTimeKind.Local).AddTicks(527), "hsn_aashwr61@hotmail.com", "1-276-515-5010", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش موحد دانش, 6, الخميسات, Peru", "حماة", new DateTime(2024, 1, 17, 7, 30, 29, 703, DateTimeKind.Local).AddTicks(435), "zynb.jabr@hotmail.com", "(286) 366-4874", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, 59, ليوا, Moldova", "بنزرت", new DateTime(2024, 1, 17, 5, 5, 34, 895, DateTimeKind.Local).AddTicks(4952), "blal_zyd44@hotmail.com", "275.400.4004 x167", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, 7, دير البلح, Kiribati", "السويداء", new DateTime(2024, 1, 17, 16, 53, 58, 290, DateTimeKind.Local).AddTicks(7074), "salm_fuad@gmail.com", "1-979-394-2959 x2406", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع کارگر شمالی, دوار ابوذر, 5135, جيجل, Guernsey", "بجاية", new DateTime(2024, 1, 17, 0, 3, 30, 587, DateTimeKind.Local).AddTicks(3773), "aayh53@yahoo.com", "(372) 510-2241 x911", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, ميدان دیباجی, 1, طرابلس, Timor-Leste", "قليوب", new DateTime(2024, 1, 17, 22, 51, 51, 590, DateTimeKind.Local).AddTicks(1559), "fatmh_hazm@yahoo.com", "213-369-8632 x70726", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1979, 12, 16, 7, 58, 8, 264, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 1, 17, 18, 12, 1, 54, DateTimeKind.Local).AddTicks(5253), "هاجر عقیل", "Maurine Johnson", "حسن - بلال", "5985754388186182036", "British Indian Ocean Territory (Chagos Archipelago)", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 1, 25, 19, 44, 31, 414, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 1, 17, 17, 2, 8, 616, DateTimeKind.Local).AddTicks(8590), "أسامة صلاح", "Charles Swift", "صلاح - هاشم", "1359854063692730569", "Greenland", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 1, 18, 0, 27, 26, 127, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 1, 17, 11, 51, 28, 655, DateTimeKind.Local).AddTicks(6925), "فاطمة سعيد", "Alfonzo Langosh", 0, "حازم Inc", "3707863386276435061", "Guinea-Bissau", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 2, 22, 15, 37, 42, 144, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 1, 17, 16, 55, 30, 700, DateTimeKind.Local).AddTicks(1824), "ريم زيد", "Thea Nolan", 0, "بلال - سالم", "6419030982280666373", "Hungary", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1995, 7, 26, 17, 7, 9, 604, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 1, 17, 13, 40, 14, 0, DateTimeKind.Local).AddTicks(9677), "حازم زيد", "Kyra Goldner", "جابر‌, بلال and ربيع", "956050596043819028", "Bouvet Island (Bouvetoya)", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 8, 10, 13, 4, 29, 711, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 1, 17, 15, 12, 40, 278, DateTimeKind.Local).AddTicks(8434), "فاطمة حسن", "Evalyn Witting", 1, "طارق, طارق and عارف", "1610058304136315229", "Cuba", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 8, 30, 8, 17, 53, 717, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 1, 17, 16, 8, 28, 870, DateTimeKind.Local).AddTicks(9660), "أسامة طارق", "Betsy Veum", 1, "عاشور - عصار", "1525452084708244109", "Argentina", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 7, 11, 1, 30, 45, 65, DateTimeKind.Local).AddTicks(7864), new DateTime(2024, 1, 17, 10, 33, 24, 20, DateTimeKind.Local).AddTicks(6664), "فريد أمجد", "Joshua Schinner", 0, "فؤاد, ربيع and هاشم", "2147631745784710774", "Kiribati", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1984, 7, 10, 17, 20, 47, 754, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 1, 17, 16, 21, 7, 838, DateTimeKind.Local).AddTicks(7026), "سارة عراقی", "Tanya Gorczany", 0, "زيد - بلال", "3721770933432684278", "Philippines", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1989, 8, 1, 5, 31, 52, 789, DateTimeKind.Local).AddTicks(9389), new DateTime(2024, 1, 17, 19, 17, 25, 623, DateTimeKind.Local).AddTicks(5866), "إيهاب فاروق", "Kira Towne", 0, "هاشم, زيد and صلاح", "565123317574309494", "Panama", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 10, 6, 22, 37, 48, 584, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 1, 17, 20, 55, 18, 728, DateTimeKind.Local).AddTicks(6079), "ريم جابر‌", "Lavada Glover", 0, "جابر‌, أسامة and صلاح", "8733429393573979396", "Costa Rica", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1970, 12, 28, 13, 44, 58, 993, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 1, 17, 21, 55, 6, 321, DateTimeKind.Local).AddTicks(566), "زينب حازم", "Tina Wunsch", 0, "فريد Inc", "9036999857793170422", "Tanzania", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 9, 26, 5, 25, 36, 148, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 1, 17, 13, 34, 34, 758, DateTimeKind.Local).AddTicks(4076), "شيماء هاشم", "Bethel Koch", "صلاح - أسامة", "100343125027572781", "Kyrgyz Republic", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 4, 13, 23, 17, 4, 817, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 1, 17, 19, 3, 32, 278, DateTimeKind.Local).AddTicks(9065), "فريد سعيد", "Kristin Kautzer", "حازم, صلاح and معروف", "5927791240000874181", "Ecuador", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 1, 16, 20, 5, 57, 458, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 1, 17, 22, 29, 6, 161, DateTimeKind.Local).AddTicks(5809), "حازم عراقی", "Penelope Reilly", "فؤاد, عراقی and آدم", "6404058997613676576", "Saint Helena", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 11, 15, 14, 37, 15, 950, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 1, 17, 21, 40, 44, 991, DateTimeKind.Local).AddTicks(1568), "إيهاب معروف", "Clifford Huel", "عقیل - جابر‌", "5213733810326612330", "Latvia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1983, 11, 8, 19, 48, 33, 325, DateTimeKind.Local).AddTicks(7889), new DateTime(2024, 1, 17, 17, 40, 28, 390, DateTimeKind.Local).AddTicks(1934), "حسن عراقی", "Fanny Grady", 1, "عصار Group", "4225649035166855077", "Yemen", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 10, 10, 19, 38, 5, 615, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 1, 17, 9, 7, 21, 43, DateTimeKind.Local).AddTicks(4411), "لمى معروف", "Donald Osinski", "عاشور Group", "2529575193526000451", "Greece", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1972, 12, 24, 6, 48, 12, 730, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 1, 17, 5, 2, 54, 679, DateTimeKind.Local).AddTicks(2907), "فؤاد بلال", "Amie Kub", "زيد - بلال", "853642300746668195", "Turks and Caicos Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 3, 21, 15, 2, 47, 638, DateTimeKind.Local).AddTicks(591), new DateTime(2024, 1, 17, 6, 7, 42, 266, DateTimeKind.Local).AddTicks(8337), "أسامة آدم", "Louie Vandervort", "طارق - عزیز", "9109051123747753651", "French Polynesia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 6, 28, 8, 29, 16, 214, DateTimeKind.Local).AddTicks(3132), new DateTime(2024, 1, 17, 3, 38, 48, 172, DateTimeKind.Local).AddTicks(4987), "فريد سالم", "Libby MacGyver", "ربيع Group", "4296512997878825398", "Congo", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 5, 8, 1, 46, 30, 296, DateTimeKind.Local).AddTicks(1773), new DateTime(2024, 1, 17, 19, 5, 12, 278, DateTimeKind.Local).AddTicks(3035), "زينب آدم", "Lilian Harris", "زيد - حازم", "9077842100602356484", "Montenegro", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 4, 2, 9, 26, 23, 287, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 1, 17, 5, 28, 11, 867, DateTimeKind.Local).AddTicks(2983), "دانا إيهاب", "Nadia Rau", 1, "معروف - سعيد", "5491462134809439198", "Uzbekistan", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1990, 3, 22, 21, 29, 27, 574, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 1, 17, 21, 58, 20, 541, DateTimeKind.Local).AddTicks(7074), "ربيع ربيع", "Fred Ryan", "عارف, حسن and فؤاد", "5457829582835893394", "Isle of Man", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 1, 28, 14, 47, 21, 555, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 1, 17, 14, 44, 15, 693, DateTimeKind.Local).AddTicks(5500), "فؤاد حسن", "Abdiel Hauck", 0, "آدم - فاروق", "1520048838586609610", "Lithuania", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 8, 21, 8, 27, 17, 845, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 1, 17, 21, 4, 16, 221, DateTimeKind.Local).AddTicks(9508), "رقية عقیل", "Oma O'Hara", "عزیز - سالم", "3847181504556897642", "Iraq", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1993, 8, 14, 14, 40, 54, 754, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 1, 17, 2, 51, 9, 116, DateTimeKind.Local).AddTicks(3080), "صلاح عاشور", "Joyce Zemlak", "معروف Group", "650046530000106408", "Armenia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 2, 15, 16, 8, 15, 780, DateTimeKind.Local).AddTicks(6382), new DateTime(2024, 1, 17, 3, 51, 19, 702, DateTimeKind.Local).AddTicks(6175), "جابر‌ عراقی", "Diego Flatley", 1, "عقیل LLC", "2946782872589065289", "Pakistan", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 6, 8, 11, 39, 45, 390, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 1, 17, 6, 33, 30, 303, DateTimeKind.Local).AddTicks(5025), "إيهاب عزیز", "Giovanni Littel", 0, "أمجد Inc", "1488582529523134531", "Japan", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 5, 16, 18, 16, 21, 275, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 1, 17, 22, 48, 31, 755, DateTimeKind.Local).AddTicks(8038), "آدم عقیل", "Carmine Nader", "عقیل - جابر‌", "9198860600748706478", "Yemen", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 9, 22, 8, 51, 19, 92, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 1, 17, 9, 49, 35, 912, DateTimeKind.Local).AddTicks(5040), "آية هاشم", "Luisa Luettgen", 1, "فريد LLC", "5947245147914632761", "Egypt", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 7, 31, 2, 11, 55, 4, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 1, 17, 21, 15, 3, 401, DateTimeKind.Local).AddTicks(9444), "إيناس بلال", "Gerald Schaden", "آدم - عزیز", "5125450155578364976", "Grenada", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 6, 22, 20, 36, 9, 749, DateTimeKind.Local).AddTicks(7941), new DateTime(2024, 1, 17, 3, 17, 57, 431, DateTimeKind.Local).AddTicks(9864), "أسامة زيد", "Valentina Schroeder", 0, "عاشور Inc", "4192390815266274591", "Aruba", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 2, 14, 16, 1, 31, 110, DateTimeKind.Local).AddTicks(256), new DateTime(2024, 1, 17, 17, 3, 27, 713, DateTimeKind.Local).AddTicks(6674), "طارق زيد", "Alek VonRueden", "زيد, بلال and أمجد", "1255834386920382260", "South Georgia and the South Sandwich Islands", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 7, 21, 4, 33, 23, 703, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 1, 16, 23, 54, 45, 884, DateTimeKind.Local).AddTicks(6229), "رنا فاروق", "Nat Brown", "سعيد LLC", "4347284642027653151", "Nicaragua", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 2, 13, 11, 4, 32, 188, DateTimeKind.Local).AddTicks(7574), new DateTime(2024, 1, 16, 23, 21, 53, 990, DateTimeKind.Local).AddTicks(986), "آية صلاح", "Jensen Jerde", 1, "حازم Group", "8822876109346794896", "Anguilla", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 1, 12, 5, 54, 50, 228, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 1, 17, 5, 44, 11, 203, DateTimeKind.Local).AddTicks(2650), "رنا هاشم", "Alvis Kuhic", 1, "فاروق Group", "605187918639000460", "Andorra", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1972, 3, 7, 11, 9, 53, 764, DateTimeKind.Local).AddTicks(2467), new DateTime(2024, 1, 17, 13, 19, 39, 629, DateTimeKind.Local).AddTicks(5037), "ريم زيد", "Bridgette Heathcote", "عقیل - فريد", "3864226403197079140", "Saint Barthelemy", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1982, 9, 19, 15, 40, 49, 259, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 1, 17, 18, 25, 8, 989, DateTimeKind.Local).AddTicks(1503), "طارق عقیل", "Clarabelle O'Hara", "حسن LLC", "7795325310601891136", "Virgin Islands, U.S.", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1994, 12, 26, 8, 35, 33, 290, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 1, 17, 7, 18, 52, 178, DateTimeKind.Local).AddTicks(9845), "زيد عارف", "Eileen Ernser", "ربيع - سعيد", "5915231400364081660", "Australia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 1, 8, 10, 47, 9, 155, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 1, 17, 12, 5, 38, 407, DateTimeKind.Local).AddTicks(5057), "سارة زيد", "Jessika Beer", "عراقی - سعيد", "7407869950602189249", "United Arab Emirates", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 9, 27, 0, 53, 59, 338, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 1, 17, 11, 6, 34, 559, DateTimeKind.Local).AddTicks(1439), "سالم فؤاد", "Garland Wiegand", 0, "جابر‌, عقیل and ربيع", "7295696783627940253", "Benin", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1954, 8, 11, 23, 0, 57, 927, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 1, 17, 22, 15, 59, 899, DateTimeKind.Local).AddTicks(1631), "بلال فريد", "Yadira Littel", 0, "عاشور, إيهاب and معروف", "8998493104145037350", "Tajikistan", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 5, 12, 19, 9, 30, 881, DateTimeKind.Local).AddTicks(3622), new DateTime(2024, 1, 17, 2, 40, 3, 900, DateTimeKind.Local).AddTicks(4067), "إيهاب حسن", "Graham Moore", 1, "عقیل Group", "5456588080719812736", "Pakistan", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1984, 4, 16, 23, 20, 5, 302, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 1, 17, 21, 17, 36, 678, DateTimeKind.Local).AddTicks(2256), "فاروق سالم", "Lizzie Moore", 0, "حسن, عاشور and حسن", "976271009197089210", "Equatorial Guinea", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 9, 21, 15, 52, 56, 57, DateTimeKind.Local).AddTicks(2305), new DateTime(2024, 1, 17, 4, 34, 31, 67, DateTimeKind.Local).AddTicks(9834), "عبير جابر‌", "Aimee Morissette", "عصار, سعيد and فاروق", "798910865445837931", "Jordan", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 9, 29, 22, 23, 25, 140, DateTimeKind.Local).AddTicks(3339), new DateTime(2024, 1, 17, 21, 51, 32, 494, DateTimeKind.Local).AddTicks(6766), "آية زيد", "Mossie Klocko", 0, "طارق Group", "8606847716985146632", "Svalbard & Jan Mayen Islands", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 4, 12, 4, 50, 7, 370, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 1, 17, 9, 50, 2, 836, DateTimeKind.Local).AddTicks(8250), "زينب عارف", "Tate Connelly", "جابر‌, صلاح and حازم", "3635847533840505810", "Andorra", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 5, 21, 6, 58, 50, 313, DateTimeKind.Local).AddTicks(9862), new DateTime(2024, 1, 16, 23, 2, 15, 308, DateTimeKind.Local).AddTicks(4522), "طارق آدم", "Nannie Kutch", 1, "معروف Inc", "7115328165567525376", "French Guiana", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 3, 26, 8, 10, 5, 709, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 1, 17, 15, 58, 55, 215, DateTimeKind.Local).AddTicks(5662), "سالم عاشور", "Jovany Lang", "جابر‌, فريد and سالم", "1634665475813179485", "Nepal", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1986, 10, 9, 23, 5, 53, 969, DateTimeKind.Local).AddTicks(7123), new DateTime(2024, 1, 17, 18, 27, 32, 298, DateTimeKind.Local).AddTicks(4166), "إيناس فؤاد", "Elias VonRueden", 1, "آدم and Sons", "3265263549930565965", "South Georgia and the South Sandwich Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 3, 11, 9, 45, 27, 214, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 1, 17, 20, 49, 18, 91, DateTimeKind.Local).AddTicks(3885), "جابر‌ عارف", "Ulices Padberg", "حازم, عارف and إيهاب", "4789504200097963347", "Greenland", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 7, 20, 2, 19, 47, 944, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 1, 17, 22, 52, 36, 870, DateTimeKind.Local).AddTicks(3257), "دانا ربيع", "Madelynn Bode", "آدم, أمجد and حسن", "2651123957967331543", "Western Sahara", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 2, 2, 11, 38, 45, 714, DateTimeKind.Local).AddTicks(9854), new DateTime(2024, 1, 17, 2, 19, 0, 914, DateTimeKind.Local).AddTicks(9407), "أسامة بلال", "Adelia Waters", "عقیل - صلاح", "6804464633379144576", "Cyprus", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 1, 26, 13, 57, 7, 366, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 1, 17, 19, 53, 24, 198, DateTimeKind.Local).AddTicks(5294), "آية جابر‌", "Rhianna Kozey", "عراقی Inc", "2242428554710524039", "Palestinian Territory", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 7, 23, 21, 21, 33, 305, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 1, 17, 14, 5, 1, 598, DateTimeKind.Local).AddTicks(4100), "أسامة هاشم", "Rebekah Friesen", 1, "فريد - حازم", "3104451137735283201", "Puerto Rico", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 9, 11, 6, 3, 4, 937, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 1, 17, 1, 52, 29, 398, DateTimeKind.Local).AddTicks(4429), "إيناس فاروق", "Nicole Hartmann", "فؤاد - آدم", "6812712187653446266", "Cayman Islands", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1956, 6, 8, 6, 3, 19, 738, DateTimeKind.Local).AddTicks(4532), new DateTime(2024, 1, 17, 14, 19, 43, 56, DateTimeKind.Local).AddTicks(1928), "جمانة زيد", "Maryse Bailey", 0, "بلال - معروف", "6175855109095109764", "Argentina", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 5, 30, 12, 21, 21, 489, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 1, 17, 10, 36, 32, 282, DateTimeKind.Local).AddTicks(1388), "آية هاشم", "Elta Welch", 1, "آدم, معروف and عقیل", "433945013921156185", "Thailand", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 3, 14, 4, 41, 25, 63, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 1, 17, 15, 53, 24, 831, DateTimeKind.Local).AddTicks(8392), "فريد عاشور", "Carlo Brakus", "أسامة and Sons", "1145164059507785022", "Belgium", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 9, 26, 4, 31, 13, 149, DateTimeKind.Local).AddTicks(6581), new DateTime(2024, 1, 17, 6, 37, 12, 217, DateTimeKind.Local).AddTicks(4292), "أمجد جابر‌", "Lillian Feeney", "أمجد Group", "7818220763041322475", "Uganda", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 3, 10, 8, 50, 49, 747, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 1, 17, 6, 13, 13, 688, DateTimeKind.Local).AddTicks(1836), "فؤاد عراقی", "Alanna Smitham", 1, "فريد - آدم", "1555685843087342225", "South Africa", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 12, 30, 2, 59, 29, 496, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 1, 17, 21, 34, 14, 764, DateTimeKind.Local).AddTicks(9902), "أمجد أسامة", "Kendrick Kshlerin", 1, "حازم - أمجد", "587625963796559328", "Nepal", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 11, 20, 5, 29, 30, 105, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 1, 17, 10, 5, 30, 614, DateTimeKind.Local).AddTicks(3923), "ربيع إيهاب", "Dominic Baumbach", 1, "معروف - آدم", "8452280895024770479", "Holy See (Vatican City State)", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1987, 7, 2, 11, 16, 35, 47, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 1, 17, 5, 23, 48, 953, DateTimeKind.Local).AddTicks(3505), "آية فؤاد", "Gerhard Legros", "عزیز - عصار", "7458076060865852059", "Bouvet Island (Bouvetoya)", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 9, 3, 0, 30, 34, 448, DateTimeKind.Local).AddTicks(7286), new DateTime(2024, 1, 17, 13, 34, 23, 682, DateTimeKind.Local).AddTicks(2310), "إيهاب حازم", "Edgardo Carroll", "عارف, عصار and هاشم", "2975948688025136807", "Ireland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1956, 12, 18, 19, 29, 56, 405, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 1, 17, 13, 20, 18, 150, DateTimeKind.Local).AddTicks(9204), "إيناس سعيد", "Adelia Bogisich", "عقیل Inc", "6055722712938551253", "Gambia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 9, 19, 19, 19, 39, 922, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 1, 17, 18, 38, 27, 403, DateTimeKind.Local).AddTicks(6947), "صلاح سعيد", "Joe Sauer", "عقیل Inc", "4378662712682187689", "Bolivia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 10, 2, 21, 55, 15, 50, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 1, 17, 6, 6, 14, 963, DateTimeKind.Local).AddTicks(3123), "سعيد حازم", "Kaycee Hegmann", "طارق, بلال and صلاح", "7036300357123085506", "Cote d'Ivoire", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 1, 31, 12, 54, 53, 212, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 1, 17, 11, 11, 55, 953, DateTimeKind.Local).AddTicks(5945), "آدم فاروق", "Betty Hirthe", "أمجد and Sons", "5087678090117310453", "United Kingdom", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(2002, 1, 7, 9, 10, 59, 156, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 1, 17, 21, 52, 7, 927, DateTimeKind.Local).AddTicks(8044), "طارق عراقی", "Clement Brown", 1, "سالم Group", "8048026574024551403", "Jersey", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 1, 17, 11, 14, 27, 555, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 1, 17, 11, 26, 24, 555, DateTimeKind.Local).AddTicks(6981), "منى بلال", "Bethany Price", 0, "بلال, أمجد and إيهاب", "7549033000861236981", "Luxembourg", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 6, 28, 7, 12, 21, 870, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 1, 17, 1, 55, 26, 748, DateTimeKind.Local).AddTicks(7583), "جابر‌ حسن", "Rhoda Kutch", "فريد Inc", "477012155487583255", "Germany", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 1, 25, 1, 9, 45, 214, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 1, 17, 22, 55, 1, 517, DateTimeKind.Local).AddTicks(2273), "فاطمة طارق", "Janick Moen", "فريد Group", "5485634915901810170", "Mongolia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 4, 20, 3, 24, 28, 524, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 1, 17, 12, 31, 44, 205, DateTimeKind.Local).AddTicks(429), "سعيد سالم", "Michale Roob", "إيهاب - عراقی", "3346949831821035142", "Nauru", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 9, 8, 1, 4, 0, 11, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 1, 17, 1, 1, 53, 15, DateTimeKind.Local).AddTicks(5730), "عبير عاشور", "Trenton Greenholt", "عزیز - فاروق", "8612182209936466858", "Antigua and Barbuda", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 9, 24, 18, 43, 30, 558, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 1, 17, 1, 25, 14, 535, DateTimeKind.Local).AddTicks(3421), "إيناس سعيد", "Brannon Bernhard", 1, "زيد Inc", "5415825262688214593", "China", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1989, 9, 28, 9, 33, 26, 908, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 1, 17, 7, 37, 58, 516, DateTimeKind.Local).AddTicks(9042), "جابر‌ فؤاد", "Jesse Senger", 0, "إيهاب and Sons", "8148142477934457317", "Bolivia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 12, 25, 0, 44, 52, 308, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 1, 17, 16, 9, 59, 340, DateTimeKind.Local).AddTicks(7618), "فريدة عزیز", "Hazel Boyle", 1, "صلاح LLC", "2721717600309810150", "Bulgaria", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 6, 28, 11, 11, 7, 952, DateTimeKind.Local).AddTicks(5848), new DateTime(2024, 1, 17, 4, 32, 16, 400, DateTimeKind.Local).AddTicks(5701), "جابر‌ هاشم", "Robert Murphy", 1, "هاشم LLC", "1559501415495896229", "Tajikistan", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 1, 9, 9, 4, 20, 695, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 1, 17, 16, 27, 26, 504, DateTimeKind.Local).AddTicks(3330), "أمجد أمجد", "Jaquelin Runolfsson", "فؤاد Group", "4932309664365053299", "Fiji", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 8, 25, 10, 21, 10, 483, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 1, 17, 19, 13, 34, 459, DateTimeKind.Local).AddTicks(2309), "سارة ربيع", "Burdette Grimes", "بلال, فاروق and عصار", "7145910086776121093", "Seychelles", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 9, 18, 16, 23, 58, 98, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 1, 17, 10, 6, 23, 518, DateTimeKind.Local).AddTicks(9204), "رقية زيد", "Carole Nikolaus", "عزیز - زيد", "7851832034890786708", "Reunion", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 8, 25, 18, 15, 56, 432, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 1, 17, 3, 25, 42, 728, DateTimeKind.Local).AddTicks(487), "زينب بلال", "Deven Rempel", 0, "عاشور - عقیل", "6297909947747150238", "Portugal", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 2, 11, 22, 31, 14, 118, DateTimeKind.Local).AddTicks(4632), new DateTime(2024, 1, 17, 3, 14, 7, 983, DateTimeKind.Local).AddTicks(8437), "سالم هاشم", "Moshe Pollich", 0, "أسامة, فاروق and سالم", "4685306528230283702", "Swaziland", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 7, 12, 2, 56, 9, 913, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 1, 17, 17, 1, 0, 856, DateTimeKind.Local).AddTicks(5395), "حسن ربيع", "Cicero Ziemann", 1, "حسن - صلاح", "1861611705745521476", "Norfolk Island", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 7, 29, 0, 37, 36, 89, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 1, 17, 19, 57, 53, 419, DateTimeKind.Local).AddTicks(230), "فريد عزیز", "Alaina Ratke", "آدم, عراقی and عاشور", "1029705264641660881", "Madagascar", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1985, 8, 13, 0, 47, 11, 791, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 1, 17, 6, 39, 35, 841, DateTimeKind.Local).AddTicks(3192), "حازم بلال", "Lorine Armstrong", 1, "عارف - عزیز", "8208467964389405785", "Cyprus", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 3, 18, 18, 26, 12, 308, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 1, 17, 7, 31, 51, 118, DateTimeKind.Local).AddTicks(7726), "دانا بلال", "Ethel Heidenreich", "زيد Group", "4063327943965395659", "Equatorial Guinea", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 3, 16, 8, 15, 14, 801, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 1, 17, 1, 15, 9, 800, DateTimeKind.Local).AddTicks(7634), "حسن سالم", "Lorena Feil", "عصار Inc", "1042224137766563671", "Togo", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 11, 17, 11, 39, 39, 741, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 1, 17, 15, 54, 4, 176, DateTimeKind.Local).AddTicks(2320), "فاروق عزیز", "Delphia Aufderhar", 1, "عارف LLC", "50338650039599130", "Morocco", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 4, 9, 3, 19, 24, 204, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 1, 17, 18, 17, 49, 691, DateTimeKind.Local).AddTicks(719), "ربيع فاروق", "Summer Nolan", 1, "عزیز - عاشور", "4892064853703485130", "French Polynesia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 4, 22, 2, 15, 40, 743, DateTimeKind.Local).AddTicks(1528), new DateTime(2024, 1, 17, 1, 1, 56, 997, DateTimeKind.Local).AddTicks(7645), "شيماء ربيع", "Darren Lehner", "حازم, جابر‌ and سعيد", "5842854666231482289", "Israel", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 6, 26, 16, 45, 28, 582, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 1, 17, 3, 52, 6, 258, DateTimeKind.Local).AddTicks(1223), "جمانة عارف", "Theron Torp", "سعيد - سالم", "676766247509890606", "Thailand", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 10, 31, 2, 52, 15, 101, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 1, 17, 8, 34, 22, 56, DateTimeKind.Local).AddTicks(1301), "أمجد عقیل", "Ebony Connelly", "إيهاب, ربيع and عراقی", "2761325563726858311", "Sao Tome and Principe", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 1, 10, 20, 10, 59, 23, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 1, 17, 7, 45, 9, 807, DateTimeKind.Local).AddTicks(4628), "لمى فريد", "Maximo Streich", "معروف, حازم and سعيد", "7011506696561554582", "Gambia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 5, 15, 3, 29, 51, 388, DateTimeKind.Local).AddTicks(1224), new DateTime(2024, 1, 17, 2, 26, 39, 915, DateTimeKind.Local).AddTicks(5156), "حازم حسن", "Lelah Boehm", 1, "عراقی - معروف", "5826733165966093648", "Brunei Darussalam", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 4, 26, 9, 46, 23, 439, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 1, 17, 20, 8, 58, 237, DateTimeKind.Local).AddTicks(1145), "حازم حسن", "Michel Barton", 1, "عقیل - هاشم", "7625693248453907464", "Uganda", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 3, 11, 9, 21, 6, 870, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 1, 17, 19, 25, 57, 299, DateTimeKind.Local).AddTicks(1641), "حسن فؤاد", "Sallie Lehner", 1, "سالم and Sons", "6258628970652945605", "Dominica", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 4, 1, 23, 30, 28, 627, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 1, 17, 23, 1, 0, 361, DateTimeKind.Local).AddTicks(7589), "جابر‌ طارق", "Libby Mosciski", 1, "زيد, فؤاد and هاشم", "163264268286517023", "Syrian Arab Republic", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 9, 22, 17, 9, 48, 594, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 1, 17, 0, 16, 4, 676, DateTimeKind.Local).AddTicks(2411), "طارق فاروق", "Marley Bauch", 1, "حازم, هاشم and عاشور", "1351796024270376611", "Nepal", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 8, 27, 22, 10, 55, 777, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 1, 17, 8, 8, 35, 846, DateTimeKind.Local).AddTicks(2005), "آدم آدم", "Leo Watsica", 0, "سالم Inc", "5063982195472593270", "Romania", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 9, 22, 21, 40, 10, 603, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 1, 17, 9, 47, 27, 405, DateTimeKind.Local).AddTicks(3592), "أسامة عاشور", "Hyman Schiller", "عصار, عقیل and سالم", "3560163117969214897", "Sudan", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 5, 17, 21, 33, 27, 796, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 1, 17, 15, 8, 39, 745, DateTimeKind.Local).AddTicks(9384), "شيماء حازم", "Chanel Paucek", 0, "آدم, حازم and بلال", "5160112764897322464", "Indonesia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 1, 14, 19, 50, 24, 847, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 1, 17, 10, 5, 10, 622, DateTimeKind.Local).AddTicks(9249), "إيناس عقیل", "Mitchel Kihn", "سعيد - طارق", "6192635612606389384", "Lesotho", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 9, 26, 21, 57, 30, 742, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 1, 17, 14, 26, 13, 204, DateTimeKind.Local).AddTicks(1854), "دانا عصار", "Heloise Beer", "أمجد, معروف and عصار", "6693332818992763683", "Gabon", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 12, 9, 7, 48, 0, 276, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 1, 17, 13, 13, 13, 857, DateTimeKind.Local).AddTicks(7534), "بلال جابر‌", "Rubie Graham", "سالم - زيد", "5094376440878064990", "Netherlands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 11, 14, 18, 18, 59, 400, DateTimeKind.Local).AddTicks(5076), new DateTime(2024, 1, 17, 17, 49, 56, 640, DateTimeKind.Local).AddTicks(4289), "زيد سالم", "Esther Hamill", 1, "زيد Inc", "6329740735814143717", "French Southern Territories", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 3, 3, 22, 54, 44, 8, DateTimeKind.Local).AddTicks(1808), new DateTime(2024, 1, 17, 8, 25, 15, 31, DateTimeKind.Local).AddTicks(3677), "آدم فؤاد", "Ariel Cartwright", "عارف, سالم and عزیز", "5049400060627579965", "Heard Island and McDonald Islands", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 3, 7, 5, 50, 7, 687, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 1, 17, 10, 14, 23, 392, DateTimeKind.Local).AddTicks(4879), "فاروق أسامة", "Guido Dach", 0, "عقیل LLC", "8649661302090742430", "Netherlands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 2, 27, 22, 14, 9, 663, DateTimeKind.Local).AddTicks(8937), new DateTime(2024, 1, 17, 22, 36, 40, 809, DateTimeKind.Local).AddTicks(2663), "إيناس سعيد", "Bryana O'Hara", "عاشور, فاروق and حازم", "3132169762657151080", "Poland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1964, 7, 4, 2, 49, 31, 270, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 1, 17, 15, 36, 39, 552, DateTimeKind.Local).AddTicks(6644), "آدم سعيد", "Lyla Gusikowski", 1, "هاشم and Sons", "3575381718128080196", "Yemen", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1964, 3, 12, 3, 37, 10, 150, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 1, 17, 9, 30, 53, 678, DateTimeKind.Local).AddTicks(3564), "أمجد جابر‌", "Erika Metz", 1, "عقیل - طارق", "6132649533379722337", "Iceland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 3, 22, 2, 11, 8, 607, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 1, 17, 10, 56, 10, 360, DateTimeKind.Local).AddTicks(4833), "جمانة ربيع", "Bill Christiansen", "حسن - فاروق", "4431422982921375750", "Bulgaria", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1960, 7, 3, 13, 53, 43, 267, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 1, 17, 3, 24, 1, 594, DateTimeKind.Local).AddTicks(5210), "زيد أسامة", "Annabelle Wolf", "أمجد, عارف and عراقی", "2714071822080131469", "Sierra Leone", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 2, 19, 1, 42, 11, 395, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 1, 17, 1, 45, 8, 129, DateTimeKind.Local).AddTicks(6330), "فؤاد عراقی", "Florida Adams", 1, "أمجد - ربيع", "8702055609882372949", "Mozambique", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 2, 6, 18, 16, 31, 130, DateTimeKind.Local).AddTicks(1742), new DateTime(2024, 1, 16, 23, 4, 7, 472, DateTimeKind.Local).AddTicks(4289), "فاروق ربيع", "Felicita Hoeger", "أمجد Inc", "8672689531759332038", "Liechtenstein", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 5, 4, 0, 28, 46, 524, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 1, 17, 17, 39, 14, 489, DateTimeKind.Local).AddTicks(1488), "إيهاب فريد", "Ivah Willms", 0, "بلال Group", "1598910816461785976", "Cote d'Ivoire", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 6, 6, 1, 4, 46, 624, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 1, 17, 12, 6, 19, 660, DateTimeKind.Local).AddTicks(4359), "منى حسن", "Rusty Dietrich", "بلال Group", "6017965384747339467", "Mauritania", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 11, 26, 11, 12, 18, 643, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 1, 17, 2, 0, 13, 793, DateTimeKind.Local).AddTicks(6147), "فريد عاشور", "Dena Kassulke", 1, "هاشم - آدم", "1198083830765296593", "Guernsey", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 8, 19, 6, 6, 11, 549, DateTimeKind.Local).AddTicks(8942), new DateTime(2024, 1, 17, 17, 0, 30, 346, DateTimeKind.Local).AddTicks(7659), "حازم فاروق", "Ervin Denesik", "حسن Inc", "6934258437387364671", "Libyan Arab Jamahiriya", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 8, 26, 11, 11, 43, 615, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 1, 17, 21, 26, 5, 135, DateTimeKind.Local).AddTicks(7146), "إيهاب بلال", "Shanel Lindgren", 0, "إيهاب, عاشور and أمجد", "9124370986837183192", "China", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1955, 4, 11, 11, 23, 33, 445, DateTimeKind.Local).AddTicks(4537), new DateTime(2024, 1, 17, 20, 35, 23, 914, DateTimeKind.Local).AddTicks(3660), "فؤاد فريد", "Clyde Hegmann", "سعيد - بلال", "5697494083940196496", "Suriname", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 12, 25, 14, 39, 47, 93, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 1, 17, 21, 58, 41, 934, DateTimeKind.Local).AddTicks(1735), "شيماء صلاح", "Vernie Crist", "فريد, أمجد and معروف", "2190568086550512354", "Singapore", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1964, 5, 27, 3, 6, 29, 556, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 1, 17, 3, 44, 52, 265, DateTimeKind.Local).AddTicks(4523), "رنا فاروق", "Maymie Ebert", "أسامة and Sons", "5354371732726660487", "Ecuador", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 3, 6, 0, 52, 24, 395, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 1, 17, 14, 19, 7, 102, DateTimeKind.Local).AddTicks(5495), "جابر‌ حازم", "Faustino Graham", "حازم and Sons", "5559388927351246835", "Cyprus", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 11, 10, 16, 19, 27, 305, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 1, 16, 23, 8, 45, 135, DateTimeKind.Local).AddTicks(9332), "آدم عارف", "Lenore Gerhold", 0, "هاشم and Sons", "5216499722462312365", "Saint Barthelemy", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 10, 4, 21, 32, 17, 190, DateTimeKind.Local).AddTicks(7801), new DateTime(2024, 1, 17, 20, 25, 12, 562, DateTimeKind.Local).AddTicks(4637), "شيماء أمجد", "Yvette Kub", 0, "صلاح, صلاح and حازم", "6656420384954346308", "Croatia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 6, 5, 10, 59, 3, 136, DateTimeKind.Local).AddTicks(6169), new DateTime(2024, 1, 17, 10, 58, 35, 900, DateTimeKind.Local).AddTicks(1403), "حسن عصار", "Haylie Goodwin", 1, "طارق Group", "310408269971472082", "Mexico", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1994, 1, 24, 5, 1, 42, 919, DateTimeKind.Local).AddTicks(7471), new DateTime(2024, 1, 17, 11, 59, 18, 388, DateTimeKind.Local).AddTicks(8295), "فريدة بلال", "Aurelie Kautzer", "عاشور - فاروق", "2980580872897563952", "Ethiopia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 9, 3, 15, 49, 19, 795, DateTimeKind.Local).AddTicks(8902), new DateTime(2024, 1, 17, 21, 35, 5, 205, DateTimeKind.Local).AddTicks(9676), "أسامة إيهاب", "Israel Kreiger", 0, "جابر‌ - إيهاب", "5509477849788880588", "Cyprus", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 1, 6, 16, 0, 17, 475, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 1, 17, 17, 52, 53, 651, DateTimeKind.Local).AddTicks(5436), "ريم آدم", "Piper Wisozk", "فؤاد - ربيع", "7134575252445013622", "Dominican Republic", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 12, 11, 0, 8, 10, 148, DateTimeKind.Local).AddTicks(3665), new DateTime(2024, 1, 17, 3, 13, 2, 451, DateTimeKind.Local).AddTicks(5890), "حازم أمجد", "Esther Dickinson", "معروف - سعيد", "8866041576550777747", "Singapore", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1955, 1, 6, 3, 32, 59, 347, DateTimeKind.Local).AddTicks(1596), new DateTime(2024, 1, 17, 5, 42, 41, 289, DateTimeKind.Local).AddTicks(7998), "آدم ربيع", "Meta Sporer", 1, "عاشور - عزیز", "5795991045484292433", "Saudi Arabia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1955, 8, 9, 23, 46, 38, 633, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 1, 17, 11, 17, 16, 218, DateTimeKind.Local).AddTicks(6519), "زينب عزیز", "Beverly Reichert", "فاروق and Sons", "8068145869746513850", "Saint Pierre and Miquelon", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 9, 6, 1, 47, 54, 20, DateTimeKind.Local).AddTicks(1322), new DateTime(2024, 1, 16, 23, 10, 20, 56, DateTimeKind.Local).AddTicks(974), "أسامة أسامة", "Mallie Hermann", 1, "عصار - أمجد", "5209804747195153834", "Namibia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 5, 16, 22, 27, 7, 676, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 1, 17, 5, 36, 37, 65, DateTimeKind.Local).AddTicks(2449), "فريد عقیل", "Demetris Armstrong", "بلال - هاشم", "2669724011670387205", "Jordan", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1980, 1, 8, 20, 38, 51, 239, DateTimeKind.Local).AddTicks(1332), new DateTime(2024, 1, 17, 17, 39, 45, 634, DateTimeKind.Local).AddTicks(2040), "ربيع فؤاد", "Berneice Treutel", 0, "أمجد, صلاح and سعيد", "7132122611628343840", "Guinea-Bissau", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 10, 25, 10, 42, 0, 423, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 1, 17, 0, 59, 4, 645, DateTimeKind.Local).AddTicks(9164), "ربيع فؤاد", "Hermann Okuneva", 0, "فريد Inc", "2048297230248310749", "Iran", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 5, 21, 18, 21, 57, 192, DateTimeKind.Local).AddTicks(7894), new DateTime(2024, 1, 17, 16, 12, 34, 375, DateTimeKind.Local).AddTicks(9913), "رنا فاروق", "Bell Smitham", 0, "صلاح LLC", "8041490494628626060", "Ireland", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 7, 28, 16, 7, 22, 514, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 1, 17, 12, 38, 58, 949, DateTimeKind.Local).AddTicks(8989), "رقية عقیل", "Noe Keebler", 0, "سعيد - فريد", "4522082734647997718", "French Polynesia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1991, 5, 18, 17, 11, 36, 58, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 1, 17, 17, 9, 3, 418, DateTimeKind.Local).AddTicks(5471), "سعيد فؤاد", "Sandra Purdy", "عاشور, عقیل and أسامة", "2447933026044074059", "Tonga", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 7, 30, 19, 18, 8, 134, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 1, 17, 7, 38, 6, 481, DateTimeKind.Local).AddTicks(1289), "إيهاب بلال", "Antonetta Baumbach", 0, "بلال, عاشور and سالم", "3543144507366194090", "Saint Kitts and Nevis", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 5, 3, 17, 59, 36, 709, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 1, 17, 0, 50, 25, 743, DateTimeKind.Local).AddTicks(8106), "ريم سالم", "Era Satterfield", 1, "عارف Inc", "2225174410476884710", "Australia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 7, 1, 16, 42, 36, 794, DateTimeKind.Local).AddTicks(752), new DateTime(2024, 1, 17, 3, 31, 28, 21, DateTimeKind.Local).AddTicks(7397), "ريم عراقی", "Ava Larkin", "فؤاد, زيد and زيد", "7693233318328051746", "Congo", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 9, 9, 14, 50, 7, 815, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 1, 17, 18, 5, 22, 842, DateTimeKind.Local).AddTicks(1716), "عبير عقیل", "Thora Corwin", "آدم, هاشم and ربيع", "2637543743758309698", "Namibia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 7, 4, 10, 46, 9, 255, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 1, 17, 1, 20, 49, 640, DateTimeKind.Local).AddTicks(425), "زينب سالم", "Arlie Dietrich", "عاشور Inc", "1046554584555068674", "Heard Island and McDonald Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1970, 2, 8, 16, 36, 8, 484, DateTimeKind.Local).AddTicks(1969), new DateTime(2024, 1, 17, 12, 0, 54, 364, DateTimeKind.Local).AddTicks(8202), "حسن فاروق", "Yvette Shanahan", "عراقی, هاشم and عاشور", "6062853626225356502", "Solomon Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 9, 17, 15, 36, 38, 79, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 1, 17, 13, 20, 0, 661, DateTimeKind.Local).AddTicks(5723), "جابر‌ حسن", "Roger Johns", "حسن LLC", "1264026323933945795", "Saudi Arabia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 11, 24, 17, 18, 19, 743, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 1, 17, 0, 50, 27, 439, DateTimeKind.Local).AddTicks(2150), "رنا إيهاب", "Lolita Herzog", 0, "عارف, أمجد and عراقی", "7795461989197904538", "Ukraine", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 4, 5, 13, 12, 54, 842, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 1, 17, 21, 59, 41, 559, DateTimeKind.Local).AddTicks(4991), "عبير فؤاد", "Sadie Runolfsdottir", "فريد Group", "4728602172611089990", "Guinea-Bissau", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 2, 3, 17, 8, 14, 262, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 1, 17, 9, 2, 51, 267, DateTimeKind.Local).AddTicks(3282), "سارة إيهاب", "Clyde Abernathy", "أمجد - هاشم", "532419920586024955", "Spain", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 4, 20, 5, 57, 35, 796, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 1, 17, 0, 21, 14, 988, DateTimeKind.Local).AddTicks(8818), "آدم فؤاد", "Lazaro Streich", "عصار Group", "7566733536680322493", "Bahrain", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 5, 9, 0, 28, 58, 424, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 1, 17, 22, 38, 40, 429, DateTimeKind.Local).AddTicks(3683), "حسن سالم", "Janiya Feeney", "فاروق Inc", "7140418955643325289", "Palau", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 10, 20, 4, 41, 28, 413, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 1, 17, 4, 46, 40, 855, DateTimeKind.Local).AddTicks(6587), "فريد عقیل", "Deshawn Tromp", "بلال - إيهاب", "6333366124532540287", "Palestinian Territory", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 7, 8, 0, 21, 39, 232, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 1, 17, 8, 5, 40, 92, DateTimeKind.Local).AddTicks(7579), "أسامة صلاح", "Etha Thiel", "عقیل Inc", "6689923838984204057", "Turkmenistan", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(2002, 2, 17, 11, 55, 43, 80, DateTimeKind.Local).AddTicks(134), new DateTime(2024, 1, 16, 23, 21, 58, 427, DateTimeKind.Local).AddTicks(2805), "آدم عارف", "Dominique Altenwerth", 0, "طارق - سعيد", "3337175993748024200", "Belarus", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1967, 6, 16, 4, 2, 37, 799, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 1, 17, 14, 14, 39, 845, DateTimeKind.Local).AddTicks(2005), "زينب فاروق", "Esmeralda Upton", 0, "عزیز, زيد and حسن", "4415602829126914208", "Guam", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 7, 23, 18, 28, 44, 779, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 1, 17, 3, 54, 28, 171, DateTimeKind.Local).AddTicks(6393), "فريدة عارف", "Laura Wintheiser", "فاروق Group", "702614583408220202", "Holy See (Vatican City State)", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 2, 20, 22, 5, 18, 557, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 1, 17, 16, 9, 29, 431, DateTimeKind.Local).AddTicks(8451), "إيهاب إيهاب", "Elvis Herman", 0, "عارف and Sons", "2190399770952323087", "Saint Pierre and Miquelon", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 5, 27, 20, 5, 54, 163, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 1, 17, 0, 16, 50, 891, DateTimeKind.Local).AddTicks(3861), "لمى حازم", "Emilia Carter", "إيهاب - هاشم", "5931878448355402032", "Yemen", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 2, 11, 22, 1, 3, 979, DateTimeKind.Local).AddTicks(5806), new DateTime(2024, 1, 17, 3, 23, 16, 887, DateTimeKind.Local).AddTicks(5882), "شيماء إيهاب", "Grady Wuckert", 1, "ربيع and Sons", "1162018260845113842", "Paraguay", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 9, 21, 0, 49, 37, 525, DateTimeKind.Local).AddTicks(1538), new DateTime(2024, 1, 17, 10, 19, 51, 509, DateTimeKind.Local).AddTicks(8417), "زينب أمجد", "Marietta Gorczany", 1, "حسن - آدم", "7946308690367189097", "Turkey", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 7, 13, 21, 0, 34, 639, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 1, 17, 11, 59, 12, 927, DateTimeKind.Local).AddTicks(4610), "هاجر بلال", "Lera Hartmann", "بلال Group", "7047989257055417487", "Turkey", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1971, 12, 5, 1, 57, 23, 108, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 1, 17, 22, 48, 43, 899, DateTimeKind.Local).AddTicks(9590), "ربيع هاشم", "Alta Kemmer", "عراقی Group", "7903523252226351762", "Nauru", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 8, 18, 4, 44, 36, 534, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 1, 17, 17, 9, 52, 887, DateTimeKind.Local).AddTicks(9602), "جابر‌ عصار", "Alivia Considine", 1, "عزیز, عقیل and حسن", "8526526640054705137", "Brazil", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 5, 7, 13, 19, 22, 353, DateTimeKind.Local).AddTicks(883), new DateTime(2024, 1, 17, 10, 50, 51, 149, DateTimeKind.Local).AddTicks(2736), "أمجد صلاح", "Keith Hettinger", 0, "زيد, سعيد and فاروق", "2644248871076634819", "Guyana", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 9, 24, 6, 3, 39, 728, DateTimeKind.Local).AddTicks(6025), new DateTime(2024, 1, 17, 13, 41, 3, 414, DateTimeKind.Local).AddTicks(9351), "فريد طارق", "Vicente Towne", 1, "عصار, عقیل and صلاح", "8826205000283672496", "Dominica", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 7, 13, 23, 27, 12, 184, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 1, 17, 7, 37, 28, 684, DateTimeKind.Local).AddTicks(7296), "هاجر فاروق", "Gracie Kirlin", "بلال Group", "1031012624009665607", "Lithuania", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 8, 2, 14, 31, 2, 211, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 1, 17, 0, 29, 53, 727, DateTimeKind.Local).AddTicks(7571), "جابر‌ ربيع", "Kenton Schumm", 1, "زيد LLC", "3109121485355065064", "Czech Republic", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 3, 6, 11, 15, 35, 710, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 1, 17, 9, 56, 56, 523, DateTimeKind.Local).AddTicks(5001), "سالم حازم", "Linnie Larson", "جابر‌, فاروق and أسامة", "2260914451282233743", "Barbados", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 8, 12, 3, 50, 45, 272, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 1, 17, 21, 26, 54, 372, DateTimeKind.Local).AddTicks(7809), "ريم عصار", "Catharine Hane", 1, "زيد - فريد", "4310025653983492882", "Liberia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 5, 17, 21, 3, 16, 124, DateTimeKind.Local).AddTicks(3752), new DateTime(2024, 1, 16, 23, 55, 36, 105, DateTimeKind.Local).AddTicks(7473), "فاروق عصار", "Colten Ruecker", "بلال - زيد", "6930065357821716797", "Algeria", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 1, 30, 16, 48, 14, 100, DateTimeKind.Local).AddTicks(4709), new DateTime(2024, 1, 16, 23, 24, 53, 123, DateTimeKind.Local).AddTicks(608), "منى آدم", "Eloy Witting", 1, "عراقی LLC", "5636631067664694388", "Malawi", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1977, 8, 5, 7, 12, 34, 164, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 1, 17, 0, 33, 7, 887, DateTimeKind.Local).AddTicks(4044), "حسن أسامة", "Milan O'Conner", 0, "عصار, آدم and صلاح", "2459083832416316075", "Armenia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 9, 10, 7, 24, 36, 651, DateTimeKind.Local).AddTicks(2504), new DateTime(2024, 1, 17, 5, 16, 36, 13, DateTimeKind.Local).AddTicks(8718), "زينب سعيد", "Keshawn Bartoletti", "هاشم Group", "3350948124644422708", "Central African Republic", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(2001, 5, 1, 9, 36, 45, 890, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 1, 17, 8, 56, 23, 671, DateTimeKind.Local).AddTicks(3447), "آية طارق", "Jadon Upton", 0, "آدم and Sons", "264378989049160316", "Mexico", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 10, 7, 21, 17, 43, 421, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 1, 17, 11, 39, 32, 742, DateTimeKind.Local).AddTicks(3965), "عبير أمجد", "Evalyn Jacobi", 0, "عراقی LLC", "545173187066839782", "Ethiopia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1971, 3, 1, 14, 2, 15, 281, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 1, 17, 6, 47, 35, 797, DateTimeKind.Local).AddTicks(6620), "سارة حازم", "Maurice Emard", "فؤاد - بلال", "2770925461229202742", "Bahamas", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 10, 13, 19, 39, 41, 136, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 1, 17, 1, 24, 22, 697, DateTimeKind.Local).AddTicks(7684), "دانا بلال", "Kaylee Koch", 0, "سعيد, أسامة and سعيد", "7387259984918516213", "Svalbard & Jan Mayen Islands", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1956, 12, 7, 11, 31, 58, 101, DateTimeKind.Local).AddTicks(7067), new DateTime(2024, 1, 17, 14, 30, 27, 391, DateTimeKind.Local).AddTicks(4552), "سعيد حسن", "Robin Thompson", "عقیل - عصار", "1032136694617111558", "Rwanda", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 12, 29, 21, 55, 48, 143, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 1, 17, 3, 12, 13, 657, DateTimeKind.Local).AddTicks(6993), "منى سعيد", "Idell Altenwerth", 1, "معروف - عصار", "7537292900683158635", "Canada", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 5, 11, 23, 46, 36, 538, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 1, 17, 13, 22, 56, 308, DateTimeKind.Local).AddTicks(5879), "شيماء سالم", "Rosanna Brakus", 0, "فاروق - جابر‌", "1092010710980805855", "Guernsey", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 8, 18, 22, 15, 53, 62, DateTimeKind.Local).AddTicks(4310), new DateTime(2024, 1, 17, 12, 36, 41, 271, DateTimeKind.Local).AddTicks(7940), "أمجد فريد", "Dejah Ruecker", 1, "معروف, أمجد and بلال", "614969065002803548", "Senegal", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 3, 15, 11, 42, 18, 93, DateTimeKind.Local).AddTicks(6880), new DateTime(2024, 1, 16, 23, 55, 54, 174, DateTimeKind.Local).AddTicks(4658), "هاجر عارف", "Heaven Brakus", "أمجد, فؤاد and عصار", "2738258646430504740", "China", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 9, 17, 21, 50, 2, 112, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 1, 17, 14, 55, 39, 591, DateTimeKind.Local).AddTicks(2959), "رقية عقیل", "Fannie Jacobs", 1, "أسامة, آدم and معروف", "5001651598709780090", "Vanuatu", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 8, 9, 2, 13, 31, 371, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 1, 17, 13, 10, 12, 453, DateTimeKind.Local).AddTicks(5140), "ريم سعيد", "Reid Blick", "سعيد - حسن", "2439328103676272095", "Libyan Arab Jamahiriya", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 11, 13, 9, 14, 10, 80, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 1, 17, 2, 21, 7, 829, DateTimeKind.Local).AddTicks(3914), "زيد عاشور", "Xavier Ledner", 1, "بلال, آدم and عارف", "6333887109883515086", "India", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 8, 20, 12, 15, 59, 63, DateTimeKind.Local).AddTicks(2730), new DateTime(2024, 1, 17, 7, 12, 15, 31, DateTimeKind.Local).AddTicks(5170), "أمجد أمجد", "Christina Bode", 1, "معروف LLC", "2592109442884928451", "Marshall Islands", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1970, 10, 4, 1, 41, 3, 496, DateTimeKind.Local).AddTicks(6889), new DateTime(2024, 1, 17, 22, 22, 29, 947, DateTimeKind.Local).AddTicks(5887), "أسامة معروف", "Emily Halvorson", "فريد Inc", "4449039867085814524", "Greenland", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1992, 7, 5, 15, 29, 41, 725, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 1, 17, 2, 27, 22, 252, DateTimeKind.Local).AddTicks(2582), "لمى فريد", "Gordon Considine", "هاشم - عصار", "8423145210199796253", "Andorra", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1967, 7, 17, 17, 21, 25, 152, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 1, 17, 18, 24, 23, 701, DateTimeKind.Local).AddTicks(1759), "فؤاد حسن", "Cicero Tillman", "عصار, هاشم and عصار", "4474643592651122908", "Virgin Islands, British", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 2, 5, 11, 19, 56, 3, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 1, 17, 17, 41, 57, 551, DateTimeKind.Local).AddTicks(9681), "جابر‌ عقیل", "Bruce Wyman", 0, "عزیز - آدم", "8446956046890538220", "Cameroon", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 11, 7, 1, 12, 45, 191, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 1, 17, 2, 0, 56, 896, DateTimeKind.Local).AddTicks(5531), "رنا أسامة", "Adolphus Bosco", "عراقی, فؤاد and فاروق", "4243445195781519373", "Tuvalu", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 4, 26, 2, 34, 40, 253, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 1, 16, 23, 40, 30, 791, DateTimeKind.Local).AddTicks(1086), "سالم سعيد", "Abdul Okuneva", "زيد - عراقی", "2476662911887414274", "Bangladesh", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1972, 7, 13, 20, 19, 38, 560, DateTimeKind.Local).AddTicks(3189), new DateTime(2024, 1, 17, 21, 39, 19, 50, DateTimeKind.Local).AddTicks(4657), "سارة عارف", "Nannie Schultz", "بلال, هاشم and أسامة", "3054319205508365725", "Christmas Island", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 4, 11, 1, 2, 28, 789, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 1, 17, 6, 48, 4, 60, DateTimeKind.Local).AddTicks(9167), "حسن عزیز", "Jeremie O'Kon", "عزیز - معروف", "1816187520801805686", "Cyprus", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 4, 19, 6, 52, 27, 147, DateTimeKind.Local).AddTicks(5243), new DateTime(2024, 1, 17, 15, 5, 39, 366, DateTimeKind.Local).AddTicks(257), "طارق ربيع", "Clifton Stiedemann", "طارق - سعيد", "4783650768464754875", "Guernsey", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 8, 30, 12, 52, 11, 375, DateTimeKind.Local).AddTicks(9232), new DateTime(2024, 1, 17, 17, 18, 20, 75, DateTimeKind.Local).AddTicks(2755), "سعيد جابر‌", "Freda Nienow", "أسامة, عاشور and عصار", "94366039967206292", "India", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 2, 12, 15, 41, 41, 123, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 1, 17, 2, 10, 0, 277, DateTimeKind.Local).AddTicks(7139), "إيهاب عراقی", "Jillian Moen", 0, "حسن - معروف", "6490779214450446527", "Iceland", 4, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TreatmentsHistory",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TreatmentsHistory",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tenants",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "Tenants",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tenants",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "Patients",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Patients",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Patients",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalFiles",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "MedicalFiles",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalFiles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FinancialInfos",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "FinancialInfos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsuranceExp",
                table: "FinancialInfos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinancialInfos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Examinations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "Examinations",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Examinations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ContactInfos",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "ContactInfos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactInfos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Attachments",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: "Attachments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Attachments",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار راستوان, 025, نوى, Turkmenistan", "أريحا", new DateTime(2024, 1, 17, 0, 30, 2, 106, DateTimeKind.Local).AddTicks(2438), "arwa.blal74@gmail.com", "727.490.0608 x45035", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش ابوذر, ميدان دماوند, 5, حلبا, Eritrea", "الطريف", new DateTime(2024, 1, 17, 0, 54, 25, 562, DateTimeKind.Local).AddTicks(5566), "iynas_fryd2@gmail.com", "(455) 874-2510", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع شهید مطهری, 7, انواديبو, Burundi", "عجلون", new DateTime(2024, 1, 17, 3, 52, 37, 372, DateTimeKind.Local).AddTicks(9339), "iynas_fuad@yahoo.com", "558-472-1415 x4387", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش ابوذر, تقاطع مالک اشتر, 0618, زليطن, Cameroon", "جرابلس", new DateTime(2024, 1, 17, 5, 49, 30, 229, DateTimeKind.Local).AddTicks(8378), "slah_asamh98@yahoo.com", "1-304-974-8673 x414", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آذربایجان, 61, الرس, Burkina Faso", "مكة المكرمة", new DateTime(2024, 1, 17, 14, 43, 55, 276, DateTimeKind.Local).AddTicks(5135), "tarq.jabr@gmail.com", "523.971.8923", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, ش سباری, 249, المالكية, Macedonia", "ودمدني", new DateTime(2024, 1, 16, 21, 39, 37, 112, DateTimeKind.Local).AddTicks(3022), "fuad_jabr@hotmail.com", "1-322-812-2548", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سمیه, تقاطع رسالت, 259, تزنيت, Mongolia", "السلط", new DateTime(2024, 1, 17, 4, 23, 48, 596, DateTimeKind.Local).AddTicks(7688), "blal60@yahoo.com", "587-784-9569", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, ش اجاره دار, 3, طرطوس, Oman", "وزان", new DateTime(2024, 1, 16, 23, 41, 4, 772, DateTimeKind.Local).AddTicks(8908), "arwa_fryd@gmail.com", "1-446-814-9916", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش مالک اشتر, 238, بدبد, Democratic People's Republic of Korea", "مسقط", new DateTime(2024, 1, 17, 2, 19, 31, 912, DateTimeKind.Local).AddTicks(9542), "abyr57@hotmail.com", "(385) 773-7154", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار راستوان, 5, سيدي قاسم, Kyrgyz Republic", "المقدادية", new DateTime(2024, 1, 17, 12, 41, 14, 722, DateTimeKind.Local).AddTicks(7406), "jmanh_amjd@hotmail.com", "720.881.8908 x2703", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار استاد قریب, 34, العرائش, Virgin Islands, British", "الإسكندرية", new DateTime(2024, 1, 17, 7, 19, 41, 875, DateTimeKind.Local).AddTicks(169), "slah.zyd84@yahoo.com", "1-989-398-0952 x462", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دیباجی, تقاطع راستوان, 520, يوبوكي, Canada", "ورقلة", new DateTime(2024, 1, 17, 18, 57, 18, 156, DateTimeKind.Local).AddTicks(151), "sarh75@gmail.com", "1-866-438-2457 x21900", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش واعظی, 2, وجدة, Brazil", "دخيل", new DateTime(2024, 1, 17, 13, 38, 46, 739, DateTimeKind.Local).AddTicks(8208), "sayd.tarq@hotmail.com", "305.308.4053 x49512", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار رسالت, تقاطع سمیه, 0, الخليل, British Indian Ocean Territory (Chagos Archipelago)", "العيون", new DateTime(2024, 1, 17, 13, 31, 0, 422, DateTimeKind.Local).AddTicks(8474), "rbya_hashm@yahoo.com", "685-502-8968 x73546", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار حقانی, تقاطع مالک اشتر, 3241, جدة, Ireland", "الديوانية", new DateTime(2024, 1, 17, 14, 40, 9, 902, DateTimeKind.Local).AddTicks(2790), "rna56@gmail.com", "575.866.2333 x36672", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سباری, 6981, خور أنجار, Algeria", "صوران", new DateTime(2024, 1, 17, 11, 22, 50, 749, DateTimeKind.Local).AddTicks(408), "farwq_aadm@gmail.com", "(535) 282-0943", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دکتر چمران, طريق موحد دانش, 2478, القويسمة, Faroe Islands", "بدر حنين", new DateTime(2024, 1, 17, 0, 26, 50, 56, DateTimeKind.Local).AddTicks(5080), "rym30@yahoo.com", "910-534-3260", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار راستوان, ش فاطمی, 1924, دخيل, Congo", "العزيزية", new DateTime(2024, 1, 17, 12, 9, 7, 713, DateTimeKind.Local).AddTicks(7646), "aadm_salm46@hotmail.com", "1-337-742-8441 x057", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع رسالت, 3530, غرداية, Ethiopia", "سبها", new DateTime(2024, 1, 17, 14, 42, 10, 380, DateTimeKind.Local).AddTicks(9429), "iynas_hazm@hotmail.com", "644-295-2744 x75700", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع شهید مطهری, طريق امیرکبیر, 4415, القامشلي, Malta", "تل كيف", new DateTime(2024, 1, 17, 16, 48, 56, 320, DateTimeKind.Local).AddTicks(7289), "zyd.sayd52@gmail.com", "(606) 921-5102", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دیباجی, ميدان آزادی, 7214, تبوك, Vietnam", "سلفيت", new DateTime(2024, 1, 17, 13, 32, 0, 77, DateTimeKind.Local).AddTicks(556), "aayh.salm92@yahoo.com", "571-761-2408 x053", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان یادگار امام, ش رسالت, 4023, حلبجة, Nepal", "جنين", new DateTime(2024, 1, 17, 13, 26, 21, 121, DateTimeKind.Local).AddTicks(6468), "salm.hazm@gmail.com", "251.923.5909 x3880", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آفریقا, دوار سباری, 72, كوستي, Iran", "جوبا", new DateTime(2024, 1, 17, 0, 38, 43, 164, DateTimeKind.Local).AddTicks(2766), "lma.salm@gmail.com", "1-530-539-3900", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان فاطمی, 4, بيت لاهيا, Jordan", "شرورة", new DateTime(2024, 1, 17, 18, 20, 53, 700, DateTimeKind.Local).AddTicks(7531), "sayd.asar@gmail.com", "566.204.3615", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع حقانی, 62, دير القمر, Niger", "الظهران", new DateTime(2024, 1, 17, 15, 12, 28, 404, DateTimeKind.Local).AddTicks(3270), "fatmh58@hotmail.com", "1-833-350-7186 x8613", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دستغیب, 7077, أم درمان, Isle of Man", "اليوسفية", new DateTime(2024, 1, 17, 18, 14, 42, 747, DateTimeKind.Local).AddTicks(8146), "amjd79@hotmail.com", "864-505-0783", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع واعظی, 9690, إدلب, Iraq", "برديرا", new DateTime(2024, 1, 17, 9, 40, 41, 938, DateTimeKind.Local).AddTicks(8348), "sayd21@gmail.com", "(277) 910-3627", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع فاطمی, طريق استاد قریب, 73, رداع, Iceland", "البريمي", new DateTime(2024, 1, 17, 7, 45, 21, 191, DateTimeKind.Local).AddTicks(4122), "fryd70@gmail.com", "(948) 208-3976", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق واعظی, ميدان راستوان, 65, أبو ظبي, Togo", "واو", new DateTime(2024, 1, 17, 12, 20, 22, 592, DateTimeKind.Local).AddTicks(7610), "sarh54@gmail.com", "336.615.0522 x964", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع راستوان, 1, تاروت, Belarus", "يامبيو", new DateTime(2024, 1, 16, 21, 24, 16, 824, DateTimeKind.Local).AddTicks(6051), "shymaa.rbya96@yahoo.com", "1-387-504-1663 x4548", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سمیه, دوار اقبال لاهوری, 6077, نوى, Morocco", "مدينة الملك عبد الله الاقتصادية", new DateTime(2024, 1, 17, 1, 37, 10, 488, DateTimeKind.Local).AddTicks(2749), "tarq96@hotmail.com", "(549) 973-9093 x225", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع فاطمی, 71, سيدي سليمان, Sudan", "توريرت", new DateTime(2024, 1, 16, 20, 43, 13, 596, DateTimeKind.Local).AddTicks(8366), "fatmh.asamh77@gmail.com", "1-873-343-6393 x55818", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, 2951, جت, Oman", "الكاظمية", new DateTime(2024, 1, 16, 23, 35, 41, 214, DateTimeKind.Local).AddTicks(4694), "arwa_aarf@hotmail.com", "1-986-579-0938 x65851", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دیباجی, 54, الرويس, Ethiopia", "أبو ظبي", new DateTime(2024, 1, 17, 18, 58, 43, 63, DateTimeKind.Local).AddTicks(4427), "slah_sayd26@gmail.com", "1-491-985-9273", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان امیرکبیر, دوار فاطمی, 063, حلفا الجديدة, Hungary", "سيدي بلعباس", new DateTime(2024, 1, 16, 23, 12, 46, 852, DateTimeKind.Local).AddTicks(7925), "iynas.marwf@yahoo.com", "1-803-510-3773 x589", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار موحد دانش, 71, ريسوت, Italy", "دير القمر", new DateTime(2024, 1, 17, 9, 23, 13, 864, DateTimeKind.Local).AddTicks(5051), "sayd_salm8@hotmail.com", "830.417.6657", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق فاطمی, طريق سمیه, 0, أم درمان, Guinea", "البليدة", new DateTime(2024, 1, 17, 19, 34, 42, 715, DateTimeKind.Local).AddTicks(4529), "iyhab.aarf34@gmail.com", "301.549.5815 x3404", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سباری, ميدان ابوذر, 73, ثول, Mali", "خريبة السوق", new DateTime(2024, 1, 17, 0, 6, 19, 683, DateTimeKind.Local).AddTicks(7641), "hsn_aqyl@yahoo.com", "836.652.5004", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, 3, قسنطينة, Montenegro", "الأزرق", new DateTime(2024, 1, 17, 9, 40, 41, 37, DateTimeKind.Local).AddTicks(7987), "fuad_tarq@hotmail.com", "467.271.3981 x011", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان واعظی, 2845, نوى, Djibouti", "شناص", new DateTime(2024, 1, 17, 5, 15, 59, 887, DateTimeKind.Local).AddTicks(3800), "frydh_hashm@hotmail.com", "(749) 706-2273 x1417", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش قدس, ميدان فاطمی, 6, ضبا, Dominica", "سنار", new DateTime(2024, 1, 17, 18, 56, 7, 157, DateTimeKind.Local).AddTicks(7803), "zynb9@yahoo.com", "705.714.0143 x622", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سباری, 5223, مقديشو, Mexico", "ميت غمر", new DateTime(2024, 1, 17, 16, 28, 53, 501, DateTimeKind.Local).AddTicks(1276), "iynas37@hotmail.com", "1-893-298-6836 x142", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق کارگر شمالی, دوار یادگار امام, 17, دهبان, Cuba", "مدينة حمد", new DateTime(2024, 1, 17, 0, 12, 25, 295, DateTimeKind.Local).AddTicks(7627), "lma_jabr47@yahoo.com", "1-551-938-3450 x2134", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سباری, شارع سباری, 98, بنغازي, Niue", "الخليل", new DateTime(2024, 1, 17, 0, 37, 41, 657, DateTimeKind.Local).AddTicks(6052), "asamh_amjd34@yahoo.com", "417-485-3630 x46449", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دستغیب, ميدان موحد دانش, 862, التل, Bosnia and Herzegovina", "المقدادية", new DateTime(2024, 1, 16, 21, 26, 4, 434, DateTimeKind.Local).AddTicks(4446), "frydh94@hotmail.com", "287-840-0695 x8348", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق واعظی, شارع یادگار امام, 4, مدنين, Palestinian Territory", "مسيعيد", new DateTime(2024, 1, 17, 14, 41, 39, 12, DateTimeKind.Local).AddTicks(5566), "mna59@yahoo.com", "(866) 628-2672", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دماوند, 6896, الحديدة, Bouvet Island (Bouvetoya)", "بور سعيد", new DateTime(2024, 1, 17, 4, 55, 6, 960, DateTimeKind.Local).AddTicks(3051), "lma45@yahoo.com", "628-261-0721", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آذربایجان, طريق اجاره دار, 140, يريم, Kenya", "نوى", new DateTime(2024, 1, 17, 14, 45, 29, 908, DateTimeKind.Local).AddTicks(5076), "slah.hazm@gmail.com", "(664) 433-5625 x842", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق شهید مطهری, طريق دیباجی, 8, أبو كمال, Djibouti", "مال", new DateTime(2024, 1, 17, 12, 19, 45, 67, DateTimeKind.Local).AddTicks(7025), "sayd.aashwr25@hotmail.com", "299-770-3394 x83132", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, 1788, خور فكان, Monaco", "نابلس", new DateTime(2024, 1, 17, 9, 52, 42, 674, DateTimeKind.Local).AddTicks(1593), "zynb.marwf70@hotmail.com", "(512) 252-9657 x3001", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دستغیب, ميدان سمیه, 57, البريمي, Vanuatu", "بريدة‏", new DateTime(2024, 1, 17, 16, 47, 36, 182, DateTimeKind.Local).AddTicks(2573), "dana3@gmail.com", "(460) 778-7910", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آذربایجان, شارع هویزه, 7436, بريدة‏, Cyprus", "سمائل", new DateTime(2024, 1, 17, 17, 27, 41, 156, DateTimeKind.Local).AddTicks(2659), "fatmh_aadm89@gmail.com", "385.267.2575", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دستغیب, ميدان ابوذر, 59, الحسكة, Turkmenistan", "دمازين", new DateTime(2024, 1, 16, 20, 51, 5, 929, DateTimeKind.Local).AddTicks(9090), "rna91@gmail.com", "272.463.4394", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آزادی, ميدان موحد دانش, 0, أسيلا, Romania", "بريدة", new DateTime(2024, 1, 17, 8, 25, 49, 888, DateTimeKind.Local).AddTicks(9168), "aadm.blal@hotmail.com", "1-867-570-7451", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اجاره دار, ش استاد قریب, 67, جازان, Portugal", "تدمر", new DateTime(2024, 1, 17, 19, 42, 19, 333, DateTimeKind.Local).AddTicks(9653), "frydh.hazm91@gmail.com", "835-656-5756", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آزادی, 0, دمازين, Andorra", "الناصرية", new DateTime(2024, 1, 17, 16, 30, 26, 145, DateTimeKind.Local).AddTicks(5414), "tarq.blal@gmail.com", "1-703-941-0247 x967", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار شهید مطهری, 840, بوكى, Mongolia", "التل", new DateTime(2024, 1, 16, 22, 51, 42, 623, DateTimeKind.Local).AddTicks(4428), "iyhab_araqy88@gmail.com", "450.938.7973 x2392", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش مالک اشتر, شارع شهید مطهری, 41, رأس لفان, Cape Verde", "باقة الغربية", new DateTime(2024, 1, 16, 22, 37, 55, 436, DateTimeKind.Local).AddTicks(7003), "jabr.tarq2@hotmail.com", "(334) 281-2302 x861", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش استاد قریب, ش استاد قریب, 3, بليث وين, Guam", "الوادي", new DateTime(2024, 1, 17, 0, 28, 45, 896, DateTimeKind.Local).AddTicks(4102), "hajr_aashwr@hotmail.com", "(613) 405-5540 x32865", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آزادی, ش راستوان, 8, ترهونة, Latvia", "وادي الدواسر", new DateTime(2024, 1, 17, 4, 14, 22, 250, DateTimeKind.Local).AddTicks(619), "hajr.rbya@gmail.com", "(444) 286-4969", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, ميدان دکتر چمران, 34, تنبدغة, Bolivia", "مادبا", new DateTime(2024, 1, 17, 8, 16, 27, 508, DateTimeKind.Local).AddTicks(3001), "rym_jabr59@gmail.com", "(952) 325-4426 x9103", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع اجاره دار, 586, صفرو, Ireland", "وهران", new DateTime(2024, 1, 16, 23, 23, 20, 703, DateTimeKind.Local).AddTicks(6890), "asamh.jabr@yahoo.com", "601.249.3597 x44947", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع راستوان, ميدان سمیه, 84, باقة الغربية, Senegal", "بوكى", new DateTime(2024, 1, 17, 9, 13, 41, 883, DateTimeKind.Local).AddTicks(1388), "fuad_fryd@gmail.com", "295.559.7393", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, دوار یادگار امام, 37, رداع, Western Sahara", "خصب", new DateTime(2024, 1, 16, 23, 31, 0, 368, DateTimeKind.Local).AddTicks(5175), "jabr.iyhab@hotmail.com", "545.534.2362", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آزادی, دوار راستوان, 48, نالوت, Fiji", "أغادير", new DateTime(2024, 1, 17, 3, 41, 0, 638, DateTimeKind.Local).AddTicks(9399), "sayd_hazm44@gmail.com", "747.442.0334", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان مالک اشتر, 9, القاهرة, Grenada", "الخروب", new DateTime(2024, 1, 17, 11, 50, 12, 117, DateTimeKind.Local).AddTicks(8846), "zynb80@hotmail.com", "1-533-472-9014 x35798", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آزادی, 23, عشرة رمضان, South Africa", "الشارقة", new DateTime(2024, 1, 17, 12, 39, 26, 442, DateTimeKind.Local).AddTicks(7040), "zyd.hashm17@hotmail.com", "568-692-1790", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سمیه, طريق ابوذر, 7730, الحجرة, Gabon", "الناصرة", new DateTime(2024, 1, 17, 1, 22, 11, 367, DateTimeKind.Local).AddTicks(4923), "aayh73@hotmail.com", "997-518-3466 x604", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش حقانی, طريق دستغیب, 4096, كسلا, Nigeria", "الفيوم", new DateTime(2024, 1, 17, 0, 2, 24, 337, DateTimeKind.Local).AddTicks(8429), "aayh_farwq19@gmail.com", "(847) 306-7110", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع ابوذر, 986, مدحاء, Ethiopia", "بلد", new DateTime(2024, 1, 17, 4, 15, 3, 745, DateTimeKind.Local).AddTicks(6776), "fatmh54@yahoo.com", "1-833-665-9905", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان واعظی, طريق کارگر شمالی, 1, الناصرية, Belize", "بنجرير", new DateTime(2024, 1, 17, 2, 59, 56, 650, DateTimeKind.Local).AddTicks(9813), "farwq30@yahoo.com", "1-256-342-2018", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, طريق قدس, 55, خور أنجار, Saudi Arabia", "جازان", new DateTime(2024, 1, 16, 23, 50, 33, 951, DateTimeKind.Local).AddTicks(4947), "zynb.jabr@gmail.com", "1-468-251-9495", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دستغیب, 73, صفاقس, Northern Mariana Islands", "المقدادية", new DateTime(2024, 1, 17, 3, 45, 38, 760, DateTimeKind.Local).AddTicks(1586), "salm.aarf1@yahoo.com", "1-336-503-8841 x69667", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان اقبال لاهوری, 209, سيهات, Romania", "إدفو", new DateTime(2024, 1, 17, 9, 54, 34, 328, DateTimeKind.Local).AddTicks(8786), "sayd_sayd@hotmail.com", "499-370-4824 x13121", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع شهید مطهری, ش قدس, 103, القصر الكبير, Kiribati", "دمياط", new DateTime(2024, 1, 17, 2, 12, 14, 949, DateTimeKind.Local).AddTicks(5875), "shymaa.tarq@gmail.com", "1-729-766-5486 x5547", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار رسالت, 1, عشرة رمضان, Canada", "الدوادمي", new DateTime(2024, 1, 16, 22, 15, 47, 491, DateTimeKind.Local).AddTicks(5369), "sarh.asar@hotmail.com", "1-419-649-2896 x21917", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع حقانی, ميدان ابوذر, 30, جباليا, Guyana", "الرميلة", new DateTime(2024, 1, 17, 2, 33, 21, 933, DateTimeKind.Local).AddTicks(9394), "lma_sayd72@hotmail.com", "634-382-4234 x2259", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, طريق شهید مطهری, 9, عدن, Democratic People's Republic of Korea", "الأقصر", new DateTime(2024, 1, 17, 15, 49, 53, 491, DateTimeKind.Local).AddTicks(8080), "jabr41@hotmail.com", "506.877.7009", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, ش استاد قریب, 206, عطبرة, Peru", "القدس", new DateTime(2024, 1, 16, 21, 21, 0, 270, DateTimeKind.Local).AddTicks(829), "salm.hashm@hotmail.com", "(769) 279-8239", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آذربایجان, شارع استاد قریب, 623, المرج, Lebanon", "ارمناز", new DateTime(2024, 1, 17, 0, 20, 18, 338, DateTimeKind.Local).AddTicks(2146), "sarh29@hotmail.com", "830-431-2331", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع واعظی, طريق آذربایجان, 3079, بلجرشي, Guernsey", "خور أنجار", new DateTime(2024, 1, 16, 20, 34, 21, 556, DateTimeKind.Local).AddTicks(3936), "aadm.iyhab@yahoo.com", "(292) 204-1662", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آفریقا, 1998, زوارة, Samoa", "صلنفة", new DateTime(2024, 1, 16, 23, 53, 44, 519, DateTimeKind.Local).AddTicks(9485), "iyhab.farwq@gmail.com", "842.540.3727 x416", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دستغیب, 117, دمازين, Malaysia", "إدفو", new DateTime(2024, 1, 17, 4, 28, 55, 9, DateTimeKind.Local).AddTicks(3214), "aayh.asamh@yahoo.com", "653-858-7078 x93401", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش ابوذر, 5, بو سعادة, Wallis and Futuna", "صفرو", new DateTime(2024, 1, 16, 22, 21, 40, 181, DateTimeKind.Local).AddTicks(4135), "salm.azyz19@hotmail.com", "(484) 621-2920 x99804", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آزادی, دوار ابوذر, 8236, حارم, Benin", "المالكية", new DateTime(2024, 1, 17, 14, 22, 5, 174, DateTimeKind.Local).AddTicks(810), "hajr25@yahoo.com", "1-837-471-9924", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان رسالت, شارع استاد قریب, 2829, كيهيدي, Antarctica (the territory South of 60 deg S)", "بورو", new DateTime(2024, 1, 16, 21, 32, 58, 636, DateTimeKind.Local).AddTicks(5960), "slah_salm24@hotmail.com", "1-664-279-9584 x6958", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آذربایجان, 30, المحمدية, Ethiopia", "عمران", new DateTime(2024, 1, 17, 15, 38, 9, 291, DateTimeKind.Local).AddTicks(8606), "asamh.hazm66@hotmail.com", "310.755.0388 x153", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دستغیب, شارع دستغیب, 5, الحلة, Liechtenstein", "جيجل", new DateTime(2024, 1, 17, 3, 14, 39, 982, DateTimeKind.Local).AddTicks(9706), "asamh_salm@hotmail.com", "(748) 426-7610", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار فاطمی, 2, بالهو, South Africa", "ريان", new DateTime(2024, 1, 17, 10, 42, 21, 759, DateTimeKind.Local).AddTicks(1958), "zynb.aadm9@hotmail.com", "1-647-794-3044", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, دوار استاد قریب, 9761, قريات, Turkey", "هرجيسة", new DateTime(2024, 1, 16, 21, 46, 54, 71, DateTimeKind.Local).AddTicks(8449), "blal29@gmail.com", "700-661-7797 x69392", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق موحد دانش, طريق دکتر چمران, 6370, غرداية, American Samoa", "عفرين", new DateTime(2024, 1, 17, 1, 55, 3, 913, DateTimeKind.Local).AddTicks(8647), "slah_zyd@hotmail.com", "837-486-7536 x6366", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, طريق دستغیب, 4, مستغانم, Denmark", "طوباس", new DateTime(2024, 1, 17, 0, 23, 30, 468, DateTimeKind.Local).AddTicks(3405), "iyhab.rbya42@yahoo.com", "(571) 835-3282 x254", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, طريق امیرکبیر, 3, آلاك, Northern Mariana Islands", "بانياس", new DateTime(2024, 1, 16, 20, 19, 6, 910, DateTimeKind.Local).AddTicks(7234), "salm.hazm@hotmail.com", "(705) 240-3405", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار یادگار امام, 91, القيروان, Norfolk Island", "الخبر", new DateTime(2024, 1, 17, 19, 39, 28, 402, DateTimeKind.Local).AddTicks(2972), "fryd87@hotmail.com", "(807) 531-9076", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, دوار دماوند, 7963, الميادين, Malta", "زاخو", new DateTime(2024, 1, 17, 14, 19, 39, 230, DateTimeKind.Local).AddTicks(7642), "jmanh43@hotmail.com", "1-685-826-5847 x37587", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق موحد دانش, 8, طيبة الامام, Honduras", "الرميلة", new DateTime(2024, 1, 17, 2, 23, 32, 674, DateTimeKind.Local).AddTicks(2932), "shymaa17@hotmail.com", "355-241-6345 x521", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار کارگر شمالی, 0, الشلف, United States of America", "برج بو عريريج", new DateTime(2024, 1, 17, 16, 58, 13, 529, DateTimeKind.Local).AddTicks(5784), "mna96@yahoo.com", "868.637.3984 x78850", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع اقبال لاهوری, 4998, كلميم, Bahamas", "غزة", new DateTime(2024, 1, 17, 18, 43, 19, 963, DateTimeKind.Local).AddTicks(6886), "abyr.zyd@gmail.com", "367.959.2905 x184", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار اقبال لاهوری, 3, القريات, Falkland Islands (Malvinas)", "هرجيسة", new DateTime(2024, 1, 17, 12, 24, 1, 272, DateTimeKind.Local).AddTicks(8179), "farwq.rbya@yahoo.com", "1-432-336-9090", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار استاد قریب, 8, بنزرت, Croatia", "كفر قاسم", new DateTime(2024, 1, 17, 0, 40, 23, 73, DateTimeKind.Local).AddTicks(2608), "rna12@gmail.com", "240.833.7632", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع قدس, شارع دستغیب, 5, المالكية, Cameroon", "خصب", new DateTime(2024, 1, 17, 12, 59, 16, 824, DateTimeKind.Local).AddTicks(608), "rbya.blal@gmail.com", "753-965-3851 x537", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع کارگر شمالی, 5, الزيمة, Sweden", "جبلة", new DateTime(2024, 1, 17, 13, 19, 36, 720, DateTimeKind.Local).AddTicks(4637), "tarq_salm65@hotmail.com", "(977) 502-8753 x94327", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آزادی, 4, البديع, Greenland", "أم رواب", new DateTime(2024, 1, 17, 11, 9, 33, 758, DateTimeKind.Local).AddTicks(767), "iynas.zyd@yahoo.com", "569-509-9166", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار رسالت, 187, غرداية, Saint Martin", "صحم", new DateTime(2024, 1, 17, 7, 26, 53, 697, DateTimeKind.Local).AddTicks(8352), "fuad.blal@yahoo.com", "811.320.1739 x2633", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار موحد دانش, 1, النماص, Albania", "سوق أهراس", new DateTime(2024, 1, 16, 20, 26, 35, 648, DateTimeKind.Local).AddTicks(7265), "rna52@hotmail.com", "1-543-776-1931", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دماوند, تقاطع قدس, 0871, بانياس, Uganda", "أبو ظبي", new DateTime(2024, 1, 16, 22, 12, 6, 720, DateTimeKind.Local).AddTicks(6832), "zyd38@gmail.com", "733-922-5320 x2172", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سباری, 06, المرج, Bhutan", "الناعورة", new DateTime(2024, 1, 17, 4, 27, 58, 381, DateTimeKind.Local).AddTicks(7115), "lma48@yahoo.com", "789.918.3150 x769", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, 1, خور أنجار, British Indian Ocean Territory (Chagos Archipelago)", "بجاية", new DateTime(2024, 1, 17, 18, 11, 38, 339, DateTimeKind.Local).AddTicks(363), "rqyh77@yahoo.com", "331-454-6595 x80257", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, طريق فاطمی, 31, الفنيدق, Kyrgyz Republic", "سيان", new DateTime(2024, 1, 17, 18, 31, 29, 908, DateTimeKind.Local).AddTicks(7335), "slah_asamh@hotmail.com", "257-398-5203", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, ميدان شهید مطهری, 31, كيفة, Anguilla", "أم درمان", new DateTime(2024, 1, 17, 7, 50, 28, 209, DateTimeKind.Local).AddTicks(6979), "rqyh.zyd46@gmail.com", "794.789.4672", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع واعظی, 503, غارو, French Guiana", "الفنيدق", new DateTime(2024, 1, 17, 8, 53, 59, 46, DateTimeKind.Local).AddTicks(1840), "iyhab10@yahoo.com", "928.508.4099", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع آزادی, تقاطع شهید مطهری, 26, إجدابيا, Aruba", "سنجة", new DateTime(2024, 1, 17, 14, 11, 25, 186, DateTimeKind.Local).AddTicks(1110), "dana53@hotmail.com", "(509) 330-3796", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دماوند, 7, كفر قاسم, Tajikistan", "حلبا", new DateTime(2024, 1, 17, 15, 5, 25, 84, DateTimeKind.Local).AddTicks(8580), "abyr17@gmail.com", "(638) 741-1828 x500", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع راستوان, 2747, بركان, Mauritius", "جرجا", new DateTime(2024, 1, 17, 18, 35, 43, 532, DateTimeKind.Local).AddTicks(6245), "asamh.salm84@yahoo.com", "882.933.4425 x51866", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 70, أم قصر, Andorra", "صفرو", new DateTime(2024, 1, 17, 10, 18, 51, 451, DateTimeKind.Local).AddTicks(1603), "sayd19@yahoo.com", "452.511.9748 x00701", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دماوند, 24, حمص, Thailand", "شبين الكوم", new DateTime(2024, 1, 17, 5, 14, 18, 153, DateTimeKind.Local).AddTicks(2490), "rqyh.fuad@hotmail.com", "474-278-8146 x38820", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان یادگار امام, ميدان مالک اشتر, 2, يافا, Gabon", "الجزائر", new DateTime(2024, 1, 17, 2, 23, 5, 972, DateTimeKind.Local).AddTicks(6906), "iynas32@hotmail.com", "564-800-3954 x08156", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آذربایجان, ش قدس, 39, قسنطينة, Czech Republic", "بور سعيد", new DateTime(2024, 1, 17, 13, 28, 56, 909, DateTimeKind.Local).AddTicks(9728), "iynas_farwq@hotmail.com", "1-419-839-5660 x9733", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دستغیب, 3, البتراء, Burkina Faso", "عالي", new DateTime(2024, 1, 17, 9, 47, 23, 336, DateTimeKind.Local).AddTicks(8300), "fuad_iyhab@hotmail.com", "425-742-7373 x2321", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دستغیب, 95, سنار, Sudan", "نابلس", new DateTime(2024, 1, 16, 21, 5, 21, 577, DateTimeKind.Local).AddTicks(6778), "blal_sayd99@hotmail.com", "1-618-340-2089 x784", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان حقانی, 4, أم قصر, Nigeria", "أعزاز", new DateTime(2024, 1, 17, 3, 31, 54, 109, DateTimeKind.Local).AddTicks(5033), "fatmh2@yahoo.com", "1-502-690-3352", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آذربایجان, 8263, الحريق, Comoros", "رأس الخيمة", new DateTime(2024, 1, 17, 16, 27, 58, 454, DateTimeKind.Local).AddTicks(1390), "amjd.asar63@hotmail.com", "1-649-596-1646", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دیباجی, ش سباری, 85, الشارقة, Afghanistan", "شرورة", new DateTime(2024, 1, 17, 14, 16, 9, 270, DateTimeKind.Local).AddTicks(840), "hsn_asamh@yahoo.com", "1-777-520-0132 x5698", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, ش دماوند, 282, الخليل, Netherlands Antilles", "الجفر", new DateTime(2024, 1, 17, 18, 44, 50, 164, DateTimeKind.Local).AddTicks(2854), "tarq84@yahoo.com", "1-245-947-3341 x8800", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آزادی, 9862, جلافي, Kazakhstan", "دهبان", new DateTime(2024, 1, 17, 19, 37, 52, 630, DateTimeKind.Local).AddTicks(5757), "rqyh_farwq83@yahoo.com", "(321) 410-9570 x4859", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع استاد قریب, 5409, أسيوط, Falkland Islands (Malvinas)", "مدينة الحرير", new DateTime(2024, 1, 17, 15, 17, 55, 675, DateTimeKind.Local).AddTicks(4610), "zynb38@yahoo.com", "804-598-6780 x04834", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اقبال لاهوری, 042, عطبرة, Switzerland", "بني ملال", new DateTime(2024, 1, 17, 5, 5, 15, 624, DateTimeKind.Local).AddTicks(7900), "hajr41@yahoo.com", "479-667-0998 x8579", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع هویزه, دوار استاد قریب, 835, حقل, Tonga", "تقورت", new DateTime(2024, 1, 17, 14, 46, 53, 573, DateTimeKind.Local).AddTicks(8035), "blal.blal17@yahoo.com", "318.747.4646", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق موحد دانش, تقاطع سمیه, 475, عرعر, Papua New Guinea", "منبج", new DateTime(2024, 1, 17, 13, 7, 51, 783, DateTimeKind.Local).AddTicks(1156), "rbya.aadm@gmail.com", "858-433-0387 x5685", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع فاطمی, 395, الرستاق, Dominican Republic", "بعلبك", new DateTime(2024, 1, 17, 19, 9, 37, 802, DateTimeKind.Local).AddTicks(7487), "abyr_farwq22@hotmail.com", "422.754.7738 x833", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش یادگار امام, تقاطع مالک اشتر, 3, بنها, Holy See (Vatican City State)", "جيجل", new DateTime(2024, 1, 17, 1, 57, 23, 297, DateTimeKind.Local).AddTicks(5343), "jmanh_tarq74@yahoo.com", "1-586-418-2758 x03613", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آفریقا, شارع سمیه, 37, العمران, Anguilla", "بوكى", new DateTime(2024, 1, 17, 7, 35, 54, 80, DateTimeKind.Local).AddTicks(667), "mna_rbya38@hotmail.com", "(924) 527-9275 x76109", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دکتر چمران, تقاطع رسالت, 5903, سحاب, India", "بو سعادة", new DateTime(2024, 1, 17, 5, 27, 24, 781, DateTimeKind.Local).AddTicks(2691), "zynb_rbya@hotmail.com", "(822) 540-0268 x459", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, 4024, بربرة, Oman", "القامشلي", new DateTime(2024, 1, 17, 8, 18, 15, 929, DateTimeKind.Local).AddTicks(4693), "jmanh_blal@yahoo.com", "551-599-9067 x4720", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع استاد قریب, 5, الراشيدية, Armenia", "الظهران", new DateTime(2024, 1, 17, 11, 37, 15, 318, DateTimeKind.Local).AddTicks(4377), "fryd45@hotmail.com", "(818) 490-4108", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش اجاره دار, 151, بربرة, Sweden", "قنا", new DateTime(2024, 1, 17, 5, 38, 36, 601, DateTimeKind.Local).AddTicks(1054), "salm_hazm49@yahoo.com", "(490) 799-6304 x522", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان موحد دانش, 0, صور, Tanzania", "بوكادوم", new DateTime(2024, 1, 17, 12, 22, 31, 246, DateTimeKind.Local).AddTicks(1324), "salm_aadm@gmail.com", "(299) 862-7462 x65374", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, 173, السيب, Haiti", "نواكشوط", new DateTime(2024, 1, 17, 1, 50, 19, 314, DateTimeKind.Local).AddTicks(4999), "iynas47@hotmail.com", "1-318-776-5499", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق آذربایجان, طريق آفریقا, 0, الرستن, Angola", "يريم", new DateTime(2024, 1, 17, 2, 57, 48, 284, DateTimeKind.Local).AddTicks(9668), "hsn7@yahoo.com", "334.332.2348", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, ميدان اجاره دار, 769, الظهران, Holy See (Vatican City State)", "قرية سار", new DateTime(2024, 1, 17, 18, 22, 11, 926, DateTimeKind.Local).AddTicks(9388), "dana_sayd68@hotmail.com", "484-425-5406 x61618", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, 8, جرسيف, Israel", "حقل", new DateTime(2024, 1, 17, 5, 27, 27, 38, DateTimeKind.Local).AddTicks(8847), "hajr_azyz8@yahoo.com", "1-412-901-2260 x566", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار مالک اشتر, 34, القويسمة, Ireland", "مدحاء", new DateTime(2024, 1, 17, 17, 54, 56, 963, DateTimeKind.Local).AddTicks(6773), "rbya92@hotmail.com", "(935) 773-0415", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق واعظی, تقاطع ابوذر, 1, يبرود, Cambodia", "بنها", new DateTime(2024, 1, 17, 2, 57, 26, 546, DateTimeKind.Local).AddTicks(5622), "mna_zyd@yahoo.com", "784.542.8632", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع ابوذر, 2, مدينة الصدر, Paraguay", "الطائف", new DateTime(2024, 1, 16, 20, 50, 41, 586, DateTimeKind.Local).AddTicks(9411), "aadm_aqyl@hotmail.com", "490-353-2308", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع استاد قریب, 4, جلاجل, Myanmar", "بيروت", new DateTime(2024, 1, 17, 4, 39, 36, 428, DateTimeKind.Local).AddTicks(2403), "lma.azyz14@yahoo.com", "1-341-702-8143 x33991", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق هویزه, ش استاد قریب, 99, جيبوتي, Latvia", "دبا", new DateTime(2024, 1, 17, 5, 50, 18, 249, DateTimeKind.Local).AddTicks(8540), "slah_hashm@gmail.com", "418.921.9515", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار راستوان, 91, البتراء, Venezuela", "أبو كبير", new DateTime(2024, 1, 17, 12, 1, 36, 846, DateTimeKind.Local).AddTicks(3507), "jmanh_aqyl@hotmail.com", "1-412-701-8544 x596", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع دکتر چمران, 90, طيبة الامام, Congo", "القنفذة", new DateTime(2024, 1, 16, 22, 15, 14, 860, DateTimeKind.Local).AddTicks(4228), "mna.tarq@yahoo.com", "1-658-602-6626 x19758", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان آذربایجان, 6831, الزرقاء, Saint Lucia", "الثورة", new DateTime(2024, 1, 17, 19, 5, 41, 255, DateTimeKind.Local).AddTicks(5198), "jmanh_hashm12@yahoo.com", "(887) 621-5503 x12837", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش آزادی, تقاطع سباری, 883, بنجرير, Oman", "جلافي", new DateTime(2024, 1, 17, 3, 35, 13, 202, DateTimeKind.Local).AddTicks(6744), "arwa.hashm57@hotmail.com", "(258) 918-8279", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق سباری, طريق حقانی, 11, تجكجة, Niger", "المرسى", new DateTime(2024, 1, 17, 14, 51, 34, 496, DateTimeKind.Local).AddTicks(9254), "sarh89@gmail.com", "1-298-865-0611 x97498", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع آزادی, تقاطع استاد قریب, 283, شرورة, Jersey", "راس العين", new DateTime(2024, 1, 17, 0, 21, 31, 39, DateTimeKind.Local).AddTicks(9995), "iyhab_blal@yahoo.com", "1-731-667-2254 x92653", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان ابوذر, تقاطع آذربایجان, 7526, عشرة رمضان, Cambodia", "سكاكا", new DateTime(2024, 1, 17, 13, 3, 50, 873, DateTimeKind.Local).AddTicks(3933), "hazm95@gmail.com", "1-339-794-4888", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان رسالت, ش استاد قریب, 5, اكجوجت, Saint Barthelemy", "الباب", new DateTime(2024, 1, 17, 0, 10, 15, 491, DateTimeKind.Local).AddTicks(8425), "arwa27@gmail.com", "355.601.4944", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق کارگر شمالی, تقاطع موحد دانش, 0, تل كيف, Venezuela", "الرملة", new DateTime(2024, 1, 17, 19, 43, 48, 656, DateTimeKind.Local).AddTicks(994), "rbya_aadm16@yahoo.com", "477.583.1521 x804", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان استاد قریب, تقاطع راستوان, 4492, الزرقاء, Tanzania", "إزكي", new DateTime(2024, 1, 17, 11, 3, 58, 923, DateTimeKind.Local).AddTicks(6946), "jabr60@hotmail.com", "322.741.8579 x674", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش شهید مطهری, 300, القطيفة, Serbia", "الجفر", new DateTime(2024, 1, 17, 5, 36, 46, 175, DateTimeKind.Local).AddTicks(1219), "lma95@yahoo.com", "731.288.7930", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق موحد دانش, 282, عنيزة, Equatorial Guinea", "الناصرة", new DateTime(2024, 1, 17, 14, 15, 2, 483, DateTimeKind.Local).AddTicks(2323), "jabr_sayd@gmail.com", "(339) 629-6354", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان قدس, طريق آذربایجان, 3, رفحا, Guinea-Bissau", "روصو", new DateTime(2024, 1, 17, 9, 31, 10, 114, DateTimeKind.Local).AddTicks(4198), "fatmh33@gmail.com", "208.618.3501 x56907", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار امیرکبیر, دوار امیرکبیر, 1923, داريا, Papua New Guinea", "بوكى", new DateTime(2024, 1, 17, 3, 14, 56, 760, DateTimeKind.Local).AddTicks(3686), "frydh.amjd@gmail.com", "777.767.7622", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دماوند, طريق واعظی, 5, ثقبة, Malawi", "النبك", new DateTime(2024, 1, 17, 3, 19, 55, 932, DateTimeKind.Local).AddTicks(7243), "zynb_fryd@hotmail.com", "1-936-953-6399 x3152", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع راستوان, دوار دماوند, 633, الفيوم, Indonesia", "تلكلخ", new DateTime(2024, 1, 17, 15, 40, 32, 69, DateTimeKind.Local).AddTicks(5441), "sayd59@yahoo.com", "901-524-5252 x6853", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان کارگر شمالی, طريق یادگار امام, 7, بوكى, Saint Kitts and Nevis", "يوبوكي", new DateTime(2024, 1, 17, 9, 8, 57, 973, DateTimeKind.Local).AddTicks(1290), "shymaa.salm@gmail.com", "1-697-208-8253 x751", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان سباری, 694, ثادق, Cyprus", "المدينة المنورة", new DateTime(2024, 1, 17, 0, 18, 53, 23, DateTimeKind.Local).AddTicks(5074), "jmanh.blal@yahoo.com", "(411) 773-5337", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق مالک اشتر, 38, القضارف, Bhutan", "إب", new DateTime(2024, 1, 17, 8, 13, 34, 6, DateTimeKind.Local).AddTicks(7613), "zynb_asar9@gmail.com", "(621) 868-6812 x894", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق رسالت, ميدان آفریقا, 6377, ضرما, Jersey", "طنطا", new DateTime(2024, 1, 17, 4, 39, 35, 584, DateTimeKind.Local).AddTicks(8646), "amjd.asar@gmail.com", "349.358.3484 x3991", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان حقانی, 326, سوسه, French Guiana", "حديثة", new DateTime(2024, 1, 17, 8, 23, 48, 294, DateTimeKind.Local).AddTicks(4804), "frydh.slah46@hotmail.com", "837.498.1572 x941", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع دیباجی, 0, خريبكة, Democratic People's Republic of Korea", "إزكي", new DateTime(2024, 1, 17, 10, 51, 59, 615, DateTimeKind.Local).AddTicks(5422), "hajr.fuad@yahoo.com", "413.818.1213", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش سباری, 884, عمان, Hong Kong", "بو سعادة", new DateTime(2024, 1, 17, 1, 29, 21, 603, DateTimeKind.Local).AddTicks(7985), "zyd_slah72@yahoo.com", "1-495-798-2926", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع امیرکبیر, ش شهید مطهری, 4818, القنفذة, Syrian Arab Republic", "الزرقاء", new DateTime(2024, 1, 17, 9, 4, 56, 14, DateTimeKind.Local).AddTicks(3506), "sarh60@gmail.com", "931.434.9295", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سمیه, 722, الباحة, Dominica", "زلفي", new DateTime(2024, 1, 17, 11, 20, 49, 314, DateTimeKind.Local).AddTicks(9547), "iynas_salm@gmail.com", "746-759-5826", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان مالک اشتر, 255, المزاحمية, Senegal", "كفرنجة", new DateTime(2024, 1, 17, 1, 58, 18, 225, DateTimeKind.Local).AddTicks(1582), "hazm_sayd18@hotmail.com", "515.436.2785 x345", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان واعظی, تقاطع استاد قریب, 31, الموصل, Rwanda", "دير الزور", new DateTime(2024, 1, 16, 21, 50, 55, 517, DateTimeKind.Local).AddTicks(3566), "hazm_blal61@yahoo.com", "(643) 557-5761", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار موحد دانش, دوار راستوان, 0, الشارقة, Turks and Caicos Islands", "الكوت", new DateTime(2024, 1, 17, 12, 43, 1, 81, DateTimeKind.Local).AddTicks(3124), "abyr7@hotmail.com", "1-622-679-5159 x4516", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دیباجی, 257, شلالة العذاورة, Martinique", "صير بني ياس", new DateTime(2024, 1, 17, 4, 36, 6, 253, DateTimeKind.Local).AddTicks(9951), "rym.iyhab@yahoo.com", "(288) 989-8553 x556", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق امیرکبیر, 5, الأقصر, Sudan", "النبك", new DateTime(2024, 1, 17, 10, 29, 37, 699, DateTimeKind.Local).AddTicks(2922), "sayd_amjd34@hotmail.com", "450-221-0455", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع استاد قریب, تقاطع دکتر چمران, 015, دومة الجندل, Venezuela", "الخرج", new DateTime(2024, 1, 17, 6, 1, 39, 949, DateTimeKind.Local).AddTicks(1693), "jabr_asamh96@hotmail.com", "1-970-379-3743 x983", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش هویزه, ش دماوند, 026, سلمية, South Georgia and the South Sandwich Islands", "القاهرة", new DateTime(2024, 1, 17, 15, 58, 55, 434, DateTimeKind.Local).AddTicks(1113), "rna.asar@gmail.com", "1-886-491-8374", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سمیه, دوار اقبال لاهوری, 937, الدار البيضاء, Senegal", "العيون", new DateTime(2024, 1, 17, 16, 22, 8, 932, DateTimeKind.Local).AddTicks(5683), "arwa.araqy@yahoo.com", "578-422-3330 x764", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دستغیب, ميدان یادگار امام, 41, السقيلبية, Tanzania", "رأس لفان", new DateTime(2024, 1, 17, 15, 14, 33, 957, DateTimeKind.Local).AddTicks(4809), "salm10@yahoo.com", "1-634-624-5323", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع استاد قریب, ميدان رسالت, 46, طبرق, Tuvalu", "قصرين", new DateTime(2024, 1, 17, 19, 5, 32, 956, DateTimeKind.Local).AddTicks(1268), "jabr_araqy91@yahoo.com", "485.301.3069 x4839", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, 28, حلبا, Bulgaria", "عدن", new DateTime(2024, 1, 17, 13, 42, 14, 554, DateTimeKind.Local).AddTicks(2754), "mna.zyd34@hotmail.com", "643.825.9741 x32424", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع واعظی, شارع موحد دانش, 04, طرطوس, Spain", "الكوت", new DateTime(2024, 1, 16, 23, 4, 35, 927, DateTimeKind.Local).AddTicks(2062), "frydh.hazm11@hotmail.com", "789-896-0261", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سباری, 71, القضيمة, Djibouti", "سامراء", new DateTime(2024, 1, 17, 18, 35, 38, 506, DateTimeKind.Local).AddTicks(4436), "asamh_jabr@yahoo.com", "(205) 411-1368 x0595", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع اجاره دار, تقاطع آذربایجان, 05, إزكي, Saint Martin", "طرابلس", new DateTime(2024, 1, 17, 16, 54, 35, 987, DateTimeKind.Local).AddTicks(3322), "rym39@gmail.com", "808-914-5738 x001", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آزادی, 912, المحمدية, Uganda", "نجران", new DateTime(2024, 1, 17, 4, 3, 10, 687, DateTimeKind.Local).AddTicks(6827), "dana.aashwr63@yahoo.com", "(973) 816-5669 x710", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق اقبال لاهوری, 64, أسيلا, Burkina Faso", "الطينطان", new DateTime(2024, 1, 17, 16, 3, 46, 120, DateTimeKind.Local).AddTicks(5846), "amjd84@hotmail.com", "706-837-9245 x6769", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دیباجی, طريق استاد قریب, 499, شقراء, Central African Republic", "سيدي قاسم", new DateTime(2024, 1, 17, 15, 50, 39, 842, DateTimeKind.Local).AddTicks(8558), "asamh_salm0@yahoo.com", "1-702-950-1283", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان هویزه, 750, تزنيت, Lao People's Democratic Republic", "ودمدني", new DateTime(2024, 1, 17, 17, 59, 49, 712, DateTimeKind.Local).AddTicks(2227), "zyd55@gmail.com", "698.955.4923 x56785", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دماوند, 0, خفجي, Jamaica", "صير بني ياس", new DateTime(2024, 1, 17, 16, 8, 3, 42, DateTimeKind.Local).AddTicks(9852), "hajr.amjd39@gmail.com", "(911) 241-3980", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "طريق دکتر چمران, تقاطع دستغیب, 80, جنين, Mauritius", "يريم", new DateTime(2024, 1, 17, 6, 4, 46, 728, DateTimeKind.Local).AddTicks(6859), "hsn_fuad@yahoo.com", "570-305-6934 x56333", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دستغیب, ميدان رسالت, 003, سعيدة, Puerto Rico", "صير بني ياس", new DateTime(2024, 1, 17, 10, 31, 40, 333, DateTimeKind.Local).AddTicks(952), "amjd15@yahoo.com", "1-948-355-0356", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش دکتر چمران, 696, بنغازي, Palestinian Territory", "مسيعيد", new DateTime(2024, 1, 16, 23, 21, 6, 836, DateTimeKind.Local).AddTicks(3656), "shymaa_aashwr70@hotmail.com", "1-520-361-5164", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "تقاطع سمیه, 983, روصو, Luxembourg", "العلا", new DateTime(2024, 1, 17, 5, 14, 29, 230, DateTimeKind.Local).AddTicks(980), "asamh93@yahoo.com", "701.765.4322", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "شارع سباری, 6602, سيدي قاسم, Uruguay", "تيفلت", new DateTime(2024, 1, 17, 8, 36, 30, 951, DateTimeKind.Local).AddTicks(7368), "arwa.aadm@yahoo.com", "417.632.5687", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ميدان دستغیب, دوار اجاره دار, 1878, فرسان, Guam", "برج بو عريريج", new DateTime(2024, 1, 17, 14, 51, 11, 846, DateTimeKind.Local).AddTicks(7248), "rqyh.marwf@hotmail.com", "390-867-8731 x8060", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش رسالت, ميدان استاد قریب, 6, بيت لحم, Eritrea", "دهبان", new DateTime(2024, 1, 17, 8, 39, 56, 246, DateTimeKind.Local).AddTicks(9284), "amjd_jabr@hotmail.com", "(610) 446-9224", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "ش راستوان, تقاطع موحد دانش, 2, عالي, Ethiopia", "الهفوف", new DateTime(2024, 1, 17, 5, 4, 54, 164, DateTimeKind.Local).AddTicks(1278), "frydh79@gmail.com", "893-982-2361", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار دستغیب, ميدان آزادی, 3, تقورت, Kyrgyz Republic", "جاردو", new DateTime(2024, 1, 17, 1, 32, 38, 727, DateTimeKind.Local).AddTicks(1779), "frydh27@hotmail.com", "445.658.4649 x2205", null });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1", "TenantId" },
                values: new object[] { "دوار آذربایجان, 68, القريات, Malaysia", "الباحة", new DateTime(2024, 1, 17, 0, 23, 5, 664, DateTimeKind.Local).AddTicks(4333), "fatmh.marwf11@yahoo.com", "(583) 887-4841", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1989, 10, 25, 19, 55, 24, 812, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 1, 17, 0, 56, 9, 857, DateTimeKind.Local).AddTicks(7008), "أمجد فاروق", "Emanuel Russel", "سالم Group", "2401005135207616390", "Kuwait", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 8, 6, 3, 40, 22, 288, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 1, 17, 7, 50, 36, 22, DateTimeKind.Local).AddTicks(7281), "سعيد عارف", "Immanuel Zboncak", "ربيع and Sons", "4050296269122040831", "Lesotho", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 6, 24, 23, 10, 2, 301, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 1, 16, 23, 47, 52, 111, DateTimeKind.Local).AddTicks(6145), "فاروق معروف", "Randal DuBuque", 1, "عراقی, آدم and آدم", "6847255678993886951", "Namibia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 3, 12, 18, 54, 32, 886, DateTimeKind.Local).AddTicks(6491), new DateTime(2024, 1, 17, 12, 33, 4, 995, DateTimeKind.Local).AddTicks(8345), "شيماء سالم", "Heidi DuBuque", 1, "صلاح Group", "4564558044045715885", "Sao Tome and Principe", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1991, 11, 2, 12, 27, 25, 582, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 1, 17, 10, 46, 42, 274, DateTimeKind.Local).AddTicks(9640), "حازم طارق", "Efrain Abshire", "عراقی LLC", "884167215144639000", "Trinidad and Tobago", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 8, 9, 13, 27, 13, 266, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 1, 16, 22, 36, 12, 723, DateTimeKind.Local).AddTicks(8775), "رنا سعيد", "Andrew Nicolas", 0, "طارق, معروف and عراقی", "6634254118678338350", "Svalbard & Jan Mayen Islands", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 3, 28, 8, 0, 21, 97, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 1, 16, 21, 33, 47, 68, DateTimeKind.Local).AddTicks(6900), "شيماء هاشم", "Jadyn Haley", 0, "سعيد, طارق and ربيع", "6251951030136471681", "Hong Kong", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 7, 9, 5, 30, 57, 438, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 1, 17, 13, 5, 52, 152, DateTimeKind.Local).AddTicks(6596), "منى حسن", "Oma Nicolas", 1, "عصار - عاشور", "2095018412073093755", "Wallis and Futuna", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1991, 5, 12, 19, 18, 14, 251, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 1, 17, 3, 36, 51, 86, DateTimeKind.Local).AddTicks(5274), "فريدة حسن", "Guido Christiansen", 1, "أمجد, بلال and حسن", "8474066724662596443", "Syrian Arab Republic", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 7, 20, 20, 48, 53, 833, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 1, 16, 21, 19, 55, 56, DateTimeKind.Local).AddTicks(4055), "عبير فاروق", "Elvera Bednar", 1, "معروف, معروف and سالم", "8369752402919128349", "Dominican Republic", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1989, 8, 5, 19, 27, 15, 263, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 1, 17, 2, 24, 53, 145, DateTimeKind.Local).AddTicks(2932), "فريد حسن", "Ashly Champlin", 1, "عزیز and Sons", "448657273378935737", "Papua New Guinea", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1971, 2, 3, 15, 1, 42, 808, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 1, 16, 22, 26, 47, 586, DateTimeKind.Local).AddTicks(2789), "فريد عارف", "Silas Deckow", 1, "عقیل - فريد", "3864225337586984160", "Republic of Korea", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1956, 5, 30, 10, 54, 17, 164, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 1, 17, 17, 27, 32, 383, DateTimeKind.Local).AddTicks(1810), "ريم عزیز", "Jermaine Roberts", "أسامة and Sons", "1894087302591552286", "Swaziland", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1956, 10, 15, 0, 20, 24, 878, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 1, 17, 17, 5, 17, 596, DateTimeKind.Local).AddTicks(4274), "سارة إيهاب", "Effie Cormier", "أسامة Inc", "7142085038752261460", "Czech Republic", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 1, 28, 23, 44, 11, 847, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 1, 17, 9, 23, 17, 460, DateTimeKind.Local).AddTicks(5686), "فؤاد بلال", "Clemmie Feeney", "آدم, ربيع and عقیل", "47059122358483975", "Zambia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 6, 23, 12, 36, 49, 629, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 1, 17, 1, 35, 5, 906, DateTimeKind.Local).AddTicks(4692), "سعيد عصار", "Bernardo Hessel", "فريد - أمجد", "6134583882586625480", "Thailand", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1978, 4, 2, 16, 15, 46, 870, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 1, 16, 20, 53, 30, 992, DateTimeKind.Local).AddTicks(788), "حسن زيد", "Zelma Luettgen", 0, "أسامة, فاروق and أسامة", "1729398786512732813", "Russian Federation", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 8, 19, 1, 39, 15, 735, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 1, 17, 0, 59, 1, 861, DateTimeKind.Local).AddTicks(448), "فاطمة عصار", "Mayra Gerhold", "عاشور - حازم", "5624461795309388902", "Indonesia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1975, 10, 13, 5, 36, 55, 392, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 1, 17, 6, 21, 0, 940, DateTimeKind.Local).AddTicks(7600), "فؤاد ربيع", "Maurine McKenzie", "فؤاد, حازم and عزیز", "1201849235830941379", "Yemen", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 11, 18, 10, 44, 19, 880, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 1, 17, 14, 49, 11, 682, DateTimeKind.Local).AddTicks(197), "صلاح زيد", "Brianne Considine", "طارق - عصار", "932825511975066472", "Senegal", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 2, 13, 12, 37, 50, 801, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 1, 17, 16, 51, 53, 772, DateTimeKind.Local).AddTicks(6341), "حازم هاشم", "Izaiah Hackett", "حسن, صلاح and عاشور", "706213941595714679", "Saint Martin", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 3, 20, 0, 19, 58, 666, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 1, 17, 2, 23, 35, 939, DateTimeKind.Local).AddTicks(2042), "رنا فاروق", "Giovani Dach", "آدم, عراقی and فاروق", "4369025228476897830", "Barbados", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 6, 24, 10, 4, 18, 864, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 1, 17, 19, 30, 10, 544, DateTimeKind.Local).AddTicks(8572), "سعيد عاشور", "Ophelia Parisian", 0, "أسامة and Sons", "2084116817553896253", "Togo", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1972, 2, 20, 23, 5, 31, 126, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 1, 17, 11, 32, 43, 629, DateTimeKind.Local).AddTicks(6057), "جمانة عصار", "Jasen Goyette", "بلال - معروف", "6614424775535228722", "Serbia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 3, 22, 11, 20, 59, 355, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 1, 17, 16, 28, 32, 390, DateTimeKind.Local).AddTicks(2979), "سالم فريد", "Stanley Nitzsche", 1, "صلاح, أسامة and أسامة", "7914909835186740596", "Tuvalu", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 1, 19, 17, 15, 29, 760, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 1, 17, 15, 11, 39, 709, DateTimeKind.Local).AddTicks(3236), "فريد أمجد", "Florian Gleason", "عاشور - إيهاب", "1209218150096501769", "Holy See (Vatican City State)", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1989, 10, 7, 10, 47, 13, 246, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 1, 17, 13, 59, 51, 992, DateTimeKind.Local).AddTicks(292), "أروى أمجد", "Letha Dibbert", "أسامة Group", "5327308973894352124", "Cocos (Keeling) Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 8, 4, 17, 9, 50, 370, DateTimeKind.Local).AddTicks(4728), new DateTime(2024, 1, 17, 11, 14, 30, 184, DateTimeKind.Local).AddTicks(7433), "هاجر آدم", "Odie McClure", 0, "طارق Group", "5692234240647421463", "Marshall Islands", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 8, 12, 10, 13, 1, 181, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 1, 17, 2, 15, 24, 835, DateTimeKind.Local).AddTicks(9066), "هاجر عارف", "Annamarie Reynolds", 1, "عاشور and Sons", "3229657110414594477", "Cambodia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 3, 2, 10, 52, 27, 943, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 1, 16, 23, 38, 18, 280, DateTimeKind.Local).AddTicks(9668), "هاجر صلاح", "Lowell Williamson", "حسن LLC", "4878533045912253139", "Samoa", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 2, 12, 19, 51, 4, 550, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 1, 17, 14, 41, 14, 593, DateTimeKind.Local).AddTicks(843), "زيد عصار", "Katherine Abernathy", 0, "سالم and Sons", "4860921647481749360", "Solomon Islands", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 7, 30, 0, 25, 31, 236, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 1, 17, 20, 0, 4, 655, DateTimeKind.Local).AddTicks(4389), "فاروق سالم", "Iliana Doyle", "صلاح - فريد", "4700911739269063655", "Botswana", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 2, 27, 6, 56, 53, 602, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 1, 17, 15, 43, 26, 468, DateTimeKind.Local).AddTicks(7027), "ريم حازم", "Gilberto Reichert", 1, "بلال - إيهاب", "7282038371729546841", "Fiji", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 6, 24, 11, 34, 36, 666, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 1, 17, 4, 35, 43, 395, DateTimeKind.Local).AddTicks(8308), "شيماء فريد", "Darius Breitenberg", "عاشور - حسن", "29466323575136290", "Uganda", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 6, 16, 19, 53, 2, 799, DateTimeKind.Local).AddTicks(1191), new DateTime(2024, 1, 17, 7, 3, 43, 610, DateTimeKind.Local).AddTicks(3893), "جابر‌ عزیز", "Savion Oberbrunner", "سالم, هاشم and حازم", "209952256709620620", "Nauru", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 4, 7, 2, 42, 42, 601, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 1, 16, 22, 49, 7, 267, DateTimeKind.Local).AddTicks(8545), "لمى بلال", "Monty Bogan", 0, "فؤاد and Sons", "2600013935888344361", "Northern Mariana Islands", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 7, 8, 2, 10, 42, 468, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 1, 17, 8, 42, 3, 179, DateTimeKind.Local).AddTicks(8034), "فاروق فؤاد", "Bettye Brakus", 0, "عقیل - إيهاب", "8628310788500022349", "New Zealand", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1992, 3, 22, 21, 41, 9, 152, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 1, 16, 20, 22, 48, 862, DateTimeKind.Local).AddTicks(7869), "آدم حسن", "Benton Bartoletti", "حسن Inc", "1992914582855568319", "Macao", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1970, 8, 17, 21, 55, 17, 779, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 1, 17, 6, 59, 49, 739, DateTimeKind.Local).AddTicks(692), "فريدة عاشور", "Richmond Luettgen", "طارق, آدم and حسن", "7086304548898411283", "Bangladesh", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1978, 12, 12, 17, 23, 29, 822, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 1, 17, 15, 47, 39, 833, DateTimeKind.Local).AddTicks(1714), "ربيع هاشم", "Luisa Donnelly", "سعيد Inc", "3711855201276628545", "Taiwan", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 11, 12, 16, 36, 6, 273, DateTimeKind.Local).AddTicks(2573), new DateTime(2024, 1, 17, 16, 19, 22, 110, DateTimeKind.Local).AddTicks(9787), "زيد ربيع", "Hermann Paucek", "فؤاد, ربيع and فاروق", "3259081322435924402", "Lebanon", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 7, 2, 5, 56, 3, 984, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 1, 17, 5, 55, 40, 909, DateTimeKind.Local).AddTicks(4658), "فاطمة سعيد", "Cameron Tremblay", 1, "جابر‌, آدم and أمجد", "2240086984295653889", "Oman", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1970, 6, 4, 20, 15, 45, 274, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 1, 16, 22, 27, 55, 105, DateTimeKind.Local).AddTicks(4183), "جابر‌ عراقی", "Opal Collins", 1, "عقیل Group", "7862948038696646203", "Martinique", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 8, 26, 21, 4, 45, 700, DateTimeKind.Local).AddTicks(5043), new DateTime(2024, 1, 17, 11, 53, 56, 483, DateTimeKind.Local).AddTicks(5995), "ريم عارف", "Kailyn Padberg", 0, "حازم, فريد and عصار", "6279720390884088642", "Ukraine", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1986, 8, 1, 0, 29, 7, 534, DateTimeKind.Local).AddTicks(2075), new DateTime(2024, 1, 17, 18, 18, 41, 732, DateTimeKind.Local).AddTicks(2888), "ربيع زيد", "Dalton Kris", 1, "جابر‌ - أمجد", "3413237345389156936", "Maldives", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 10, 28, 11, 27, 55, 989, DateTimeKind.Local).AddTicks(1795), new DateTime(2024, 1, 16, 20, 11, 47, 290, DateTimeKind.Local).AddTicks(1577), "جابر‌ سالم", "Barbara Turcotte", "عقیل, فريد and طارق", "401703701819204687", "Turks and Caicos Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 2, 28, 19, 16, 28, 919, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 1, 16, 21, 4, 1, 638, DateTimeKind.Local).AddTicks(195), "ربيع حازم", "Sylvester Goodwin", 1, "أسامة LLC", "1593710988122643467", "Macao", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 4, 27, 18, 25, 53, 257, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 1, 17, 3, 2, 51, 75, DateTimeKind.Local).AddTicks(966), "سارة عراقی", "Dakota Yost", "سالم, عزیز and زيد", "5804875365256773596", "Netherlands Antilles", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 6, 22, 8, 4, 30, 574, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 17, 2, 49, 25, 466, DateTimeKind.Local).AddTicks(1198), "رقية عصار", "Joshua Wolf", 0, "عقیل Group", "5693481893581946537", "Oman", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 6, 21, 15, 38, 13, 788, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 1, 17, 14, 7, 18, 98, DateTimeKind.Local).AddTicks(63), "شيماء فؤاد", "Pinkie Dietrich", "طارق, زيد and بلال", "5546709395356466777", "Jamaica", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1987, 10, 2, 21, 14, 0, 594, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 1, 17, 19, 25, 17, 294, DateTimeKind.Local).AddTicks(2391), "عبير هاشم", "Lydia Hayes", 0, "حازم, سالم and ربيع", "3038285427568087323", "Trinidad and Tobago", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 12, 24, 10, 39, 50, 835, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 1, 17, 18, 44, 59, 405, DateTimeKind.Local).AddTicks(3493), "فريد صلاح", "Alexandrea Adams", "عراقی, آدم and عراقی", "5222370016839724797", "Czech Republic", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 7, 20, 4, 34, 58, 965, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 1, 17, 9, 27, 52, 822, DateTimeKind.Local).AddTicks(8792), "صلاح معروف", "Americo Stark", "ربيع, إيهاب and عقیل", "6266011204102728708", "British Indian Ocean Territory (Chagos Archipelago)", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 10, 15, 6, 53, 37, 87, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 1, 17, 12, 18, 39, 168, DateTimeKind.Local).AddTicks(8731), "لمى أسامة", "Kelsi O'Conner", "معروف - عارف", "8247369988266095542", "Nigeria", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 7, 12, 3, 36, 3, 9, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 1, 16, 21, 39, 25, 206, DateTimeKind.Local).AddTicks(4548), "ريم زيد", "Craig Dickens", "صلاح - عراقی", "707674410795803992", "Christmas Island", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 8, 10, 16, 6, 26, 195, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 1, 17, 7, 48, 23, 703, DateTimeKind.Local).AddTicks(7000), "زينب عزیز", "Nicola Schinner", 0, "عزیز - سالم", "5626087966036918570", "Greenland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 8, 25, 9, 42, 22, 628, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 1, 17, 3, 54, 46, 906, DateTimeKind.Local).AddTicks(6390), "حازم عراقی", "Nelda Hamill", "فريد LLC", "1550888389175037376", "El Salvador", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(2001, 11, 25, 6, 35, 55, 381, DateTimeKind.Local).AddTicks(9824), new DateTime(2024, 1, 17, 4, 38, 25, 245, DateTimeKind.Local).AddTicks(784), "حسن فاروق", "Ahmed Shanahan", 1, "إيهاب, حسن and أمجد", "2612224567216808149", "Singapore", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 8, 13, 23, 32, 51, 912, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 1, 17, 16, 45, 38, 200, DateTimeKind.Local).AddTicks(6062), "فاروق أمجد", "Cletus Jakubowski", 0, "زيد - عزیز", "285799790540914850", "Czech Republic", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 3, 5, 3, 18, 9, 227, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 1, 17, 14, 59, 37, 5, DateTimeKind.Local).AddTicks(5633), "منى عصار", "Alan Schiller", "عاشور LLC", "488095116064525517", "Mali", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 5, 11, 7, 54, 6, 521, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 1, 17, 5, 0, 0, 331, DateTimeKind.Local).AddTicks(3822), "هاجر فؤاد", "Jeramie Russel", "عزیز LLC", "1320952951441330894", "Russian Federation", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 10, 5, 19, 23, 11, 966, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 1, 17, 2, 6, 18, 458, DateTimeKind.Local).AddTicks(7327), "زينب هاشم", "Demetrius Kuhlman", 0, "جابر‌ - أسامة", "3019040145672501589", "Japan", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 9, 10, 14, 12, 46, 307, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 1, 17, 18, 12, 10, 599, DateTimeKind.Local).AddTicks(9365), "إيناس فؤاد", "Nathaniel Runte", 0, "صلاح Group", "4659351010697933212", "Togo", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 2, 24, 21, 16, 42, 599, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 1, 17, 0, 44, 43, 259, DateTimeKind.Local).AddTicks(886), "حازم عقیل", "Eriberto Stark", 0, "زيد Inc", "3642421652681090679", "Azerbaijan", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1968, 12, 8, 5, 27, 56, 297, DateTimeKind.Local).AddTicks(2156), new DateTime(2024, 1, 17, 2, 16, 31, 576, DateTimeKind.Local).AddTicks(5365), "إيهاب سعيد", "Evalyn Ledner", "سعيد - عصار", "225791160244075209", "Kazakhstan", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 11, 17, 0, 45, 55, 466, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 1, 17, 4, 33, 43, 480, DateTimeKind.Local).AddTicks(5039), "سالم هاشم", "Whitney Walker", "هاشم and Sons", "8805638513496082036", "French Polynesia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 4, 10, 7, 36, 15, 656, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 1, 16, 23, 20, 57, 510, DateTimeKind.Local).AddTicks(1754), "رقية حسن", "Marcelo Kunde", "بلال Group", "4899236436353799323", "Cameroon", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 6, 8, 5, 42, 55, 507, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 1, 17, 18, 19, 49, 590, DateTimeKind.Local).AddTicks(8310), "فؤاد حازم", "Haven Larkin", "جابر‌ Group", "1920874930740165225", "Kiribati", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 4, 21, 2, 45, 36, 288, DateTimeKind.Local).AddTicks(7923), new DateTime(2024, 1, 17, 12, 9, 56, 168, DateTimeKind.Local).AddTicks(5374), "دانا عزیز", "Curt Watsica", "عقیل Inc", "8581669837397836574", "France", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 7, 25, 14, 41, 15, 591, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 1, 17, 13, 52, 2, 380, DateTimeKind.Local).AddTicks(7531), "حازم عاشور", "Jacynthe Gusikowski", "ربيع and Sons", "2041005573101861250", "Serbia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1955, 5, 31, 3, 52, 10, 272, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 1, 17, 15, 26, 46, 781, DateTimeKind.Local).AddTicks(1778), "لمى عارف", "Noemie Lakin", 0, "بلال, فريد and عقیل", "1041189183130540745", "Latvia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1955, 11, 19, 21, 50, 46, 453, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 1, 17, 1, 10, 26, 862, DateTimeKind.Local).AddTicks(3375), "جمانة بلال", "Jody Mitchell", 1, "أسامة - فريد", "5845762231375631773", "Iraq", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 3, 23, 18, 4, 7, 382, DateTimeKind.Local).AddTicks(6398), new DateTime(2024, 1, 16, 21, 1, 53, 951, DateTimeKind.Local).AddTicks(8045), "حسن عراقی", "Tina Rodriguez", "سعيد, معروف and سعيد", "3464488388336225844", "Saint Lucia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1962, 4, 4, 6, 31, 55, 223, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 1, 17, 15, 29, 47, 402, DateTimeKind.Local).AddTicks(8297), "جمانة معروف", "Caden Mraz", "هاشم - عزیز", "4480651786257234772", "Belarus", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 4, 1, 12, 21, 18, 832, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 1, 17, 18, 21, 5, 706, DateTimeKind.Local).AddTicks(2618), "فاروق عقیل", "Onie Dickens", "عقیل, عراقی and عارف", "7785036928993119607", "Liberia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 4, 4, 10, 51, 59, 480, DateTimeKind.Local).AddTicks(1311), new DateTime(2024, 1, 17, 17, 26, 43, 75, DateTimeKind.Local).AddTicks(1009), "أروى عارف", "Camron Murphy", "أمجد and Sons", "3283212282142814117", "Barbados", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 7, 25, 20, 58, 9, 462, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 1, 16, 20, 59, 34, 902, DateTimeKind.Local).AddTicks(6085), "شيماء عقیل", "May Fadel", 0, "عزیز - طارق", "2425245576540841425", "American Samoa", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 12, 10, 15, 54, 55, 622, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 1, 17, 6, 16, 41, 224, DateTimeKind.Local).AddTicks(9913), "إيهاب إيهاب", "Grayson Bartoletti", 1, "صلاح Group", "7454437822584889069", "Malta", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2003, 4, 28, 16, 15, 35, 102, DateTimeKind.Local).AddTicks(7317), new DateTime(2024, 1, 17, 7, 23, 49, 952, DateTimeKind.Local).AddTicks(7550), "جابر‌ هاشم", "Priscilla Hettinger", 0, "سعيد, معروف and معروف", "7609964903327530224", "Montserrat", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 8, 8, 14, 26, 25, 444, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 1, 17, 1, 4, 48, 834, DateTimeKind.Local).AddTicks(6617), "صلاح عارف", "Eloy Wilderman", 0, "عقیل LLC", "4658958043991462518", "Mongolia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 6, 18, 5, 18, 15, 831, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 1, 17, 14, 18, 18, 857, DateTimeKind.Local).AddTicks(3010), "بلال آدم", "Aron Mayer", "فاروق, زيد and صلاح", "5025450213857652776", "El Salvador", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 5, 5, 12, 30, 26, 179, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 1, 17, 11, 58, 17, 537, DateTimeKind.Local).AddTicks(6821), "بلال ربيع", "Andreanne Sporer", "معروف - سعيد", "8202917515901090792", "United Arab Emirates", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 9, 12, 1, 16, 19, 201, DateTimeKind.Local).AddTicks(7612), new DateTime(2024, 1, 17, 12, 17, 34, 810, DateTimeKind.Local).AddTicks(7204), "ريم جابر‌", "Zane Stanton", "أمجد, عزیز and عزیز", "2897901823350918186", "Northern Mariana Islands", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 10, 30, 18, 37, 53, 953, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 1, 17, 4, 43, 47, 755, DateTimeKind.Local).AddTicks(7325), "زيد فؤاد", "Estell Blanda", 1, "عقیل - عصار", "1003907712402884169", "South Africa", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1975, 10, 3, 9, 21, 39, 371, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 1, 17, 11, 54, 21, 112, DateTimeKind.Local).AddTicks(8344), "طارق جابر‌", "Brant Bartoletti", 1, "طارق, ربيع and إيهاب", "6559499414360925989", "El Salvador", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1996, 4, 17, 5, 24, 34, 428, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 1, 17, 18, 34, 49, 994, DateTimeKind.Local).AddTicks(5330), "حسن حازم", "Grover Jast", 0, "عزیز Inc", "577786809660277035", "Belgium", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1973, 5, 21, 7, 26, 55, 797, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 1, 17, 10, 2, 13, 851, DateTimeKind.Local).AddTicks(1503), "أمجد عاشور", "Edna Murazik", "إيهاب LLC", "8534920489139546068", "Bouvet Island (Bouvetoya)", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1956, 4, 20, 1, 12, 38, 891, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 1, 16, 23, 41, 38, 682, DateTimeKind.Local).AddTicks(4913), "شيماء عراقی", "Jaeden Ward", 0, "ربيع, جابر‌ and ربيع", "7845369942039756498", "Saint Pierre and Miquelon", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 10, 20, 0, 53, 36, 730, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 1, 17, 17, 14, 44, 980, DateTimeKind.Local).AddTicks(6152), "هاجر فؤاد", "Marcelle Boehm", "سالم - صلاح", "5356864033705116723", "China", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 8, 1, 4, 21, 20, 417, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 1, 17, 5, 12, 8, 703, DateTimeKind.Local).AddTicks(8614), "أمجد عراقی", "Kaley Koepp", "سعيد, سالم and عراقی", "1178820165497987569", "British Indian Ocean Territory (Chagos Archipelago)", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 11, 9, 18, 7, 2, 125, DateTimeKind.Local).AddTicks(1459), new DateTime(2024, 1, 17, 15, 52, 20, 939, DateTimeKind.Local).AddTicks(4621), "إيناس حازم", "Danyka Shields", 0, "سعيد - إيهاب", "4503500773166907478", "Hungary", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1963, 6, 6, 22, 20, 11, 298, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 1, 17, 19, 32, 43, 301, DateTimeKind.Local).AddTicks(6840), "ربيع سعيد", "Connor Kris", 0, "سالم, فؤاد and صلاح", "4429679104670591965", "Sudan", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 12, 12, 12, 1, 10, 682, DateTimeKind.Local).AddTicks(8919), new DateTime(2024, 1, 17, 17, 55, 1, 656, DateTimeKind.Local).AddTicks(6031), "عبير حسن", "Velma Huel", "هاشم Inc", "7729085788303700777", "Cape Verde", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1969, 5, 18, 18, 29, 8, 891, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 1, 17, 17, 1, 30, 846, DateTimeKind.Local).AddTicks(1741), "فريد إيهاب", "Rosalinda Sporer", "إيهاب, فاروق and زيد", "2783220318303240030", "Timor-Leste", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 8, 28, 1, 17, 8, 226, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 1, 17, 4, 4, 31, 618, DateTimeKind.Local).AddTicks(4617), "شيماء عقیل", "Tyson Donnelly", "هاشم - طارق", "4423049952922460698", "Austria", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 1, 25, 11, 1, 38, 351, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 1, 17, 12, 39, 26, 245, DateTimeKind.Local).AddTicks(8437), "جمانة فاروق", "Raquel Schneider", "سعيد Group", "4338880356749335444", "Liberia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 5, 7, 13, 39, 27, 68, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 1, 17, 6, 41, 53, 455, DateTimeKind.Local).AddTicks(9760), "زيد حسن", "Katelynn Goldner", 0, "سالم Inc", "8577552934146095786", "Saint Pierre and Miquelon", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 9, 3, 23, 30, 40, 787, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 1, 17, 13, 4, 17, 867, DateTimeKind.Local).AddTicks(7716), "أسامة حسن", "Godfrey Runolfsson", 0, "زيد, معروف and إيهاب", "90607050483667982", "Brunei Darussalam", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1970, 12, 19, 14, 22, 42, 700, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 1, 17, 15, 1, 56, 582, DateTimeKind.Local).AddTicks(7949), "ريم ربيع", "Reuben Ebert", 0, "عارف - فريد", "5441221930739834956", "Sierra Leone", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 11, 4, 5, 34, 26, 921, DateTimeKind.Local).AddTicks(3180), new DateTime(2024, 1, 16, 23, 20, 36, 953, DateTimeKind.Local).AddTicks(2569), "عبير أمجد", "Kayley O'Connell", 0, "عراقی - أسامة", "8016649340234185768", "French Southern Territories", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 3, 31, 11, 40, 56, 21, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 1, 17, 2, 3, 54, 492, DateTimeKind.Local).AddTicks(4738), "دانا عزیز", "Cameron Gleichner", 0, "حسن, عقیل and هاشم", "1134212114451939126", "Bolivia", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 2, 17, 12, 23, 59, 849, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 1, 17, 10, 3, 15, 121, DateTimeKind.Local).AddTicks(556), "إيهاب إيهاب", "Mary Harris", 1, "زيد, آدم and عصار", "5518805231371050592", "Zambia", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 5, 8, 17, 31, 46, 565, DateTimeKind.Local).AddTicks(6418), new DateTime(2024, 1, 16, 22, 26, 12, 381, DateTimeKind.Local).AddTicks(7753), "جمانة سالم", "Zola Hahn", "عاشور - عاشور", "3564310419530575786", "Christmas Island", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 8, 9, 3, 21, 35, 709, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 1, 17, 0, 54, 4, 327, DateTimeKind.Local).AddTicks(7402), "سارة عاشور", "Edwina Wolff", 1, "أمجد, فؤاد and أسامة", "3680968953290386188", "Malta", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1959, 1, 28, 8, 59, 30, 866, DateTimeKind.Local).AddTicks(1901), new DateTime(2024, 1, 17, 10, 37, 31, 559, DateTimeKind.Local).AddTicks(8872), "إيناس أسامة", "Bette Upton", "صلاح Group", "7416614213151254334", "Georgia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1987, 2, 5, 18, 9, 31, 977, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 1, 17, 14, 8, 36, 380, DateTimeKind.Local).AddTicks(3172), "حازم عزیز", "Tessie Weber", "صلاح - فاروق", "6111070357305997211", "Chile", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 9, 27, 7, 10, 52, 428, DateTimeKind.Local).AddTicks(4828), new DateTime(2024, 1, 17, 16, 3, 27, 609, DateTimeKind.Local).AddTicks(6412), "ريم بلال", "William Orn", "طارق and Sons", "3328398652167547674", "Somalia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 11, 29, 1, 32, 33, 982, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 1, 17, 0, 26, 4, 97, DateTimeKind.Local).AddTicks(8064), "سالم فريد", "Alfredo Ward", 0, "إيهاب, معروف and طارق", "1130792660159479140", "Sudan", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 4, 23, 0, 42, 5, 397, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 1, 17, 19, 0, 23, 538, DateTimeKind.Local).AddTicks(4771), "فريد سعيد", "Eduardo Bahringer", "أسامة - عزیز", "1691428818883000549", "Timor-Leste", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 11, 23, 20, 51, 39, 458, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 1, 17, 2, 46, 56, 558, DateTimeKind.Local).AddTicks(7497), "فريدة فاروق", "Estevan Renner", 1, "فريد - هاشم", "5524264718735054318", "Myanmar", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1958, 5, 17, 23, 58, 55, 350, DateTimeKind.Local).AddTicks(6136), new DateTime(2024, 1, 17, 7, 41, 11, 523, DateTimeKind.Local).AddTicks(962), "فريد آدم", "Breanna Rowe", "حسن - معروف", "723514111554907208", "Moldova", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 2, 26, 8, 26, 22, 441, DateTimeKind.Local).AddTicks(3421), new DateTime(2024, 1, 17, 18, 3, 22, 108, DateTimeKind.Local).AddTicks(6910), "طارق صلاح", "Franz Lesch", 0, "حازم - بلال", "875011163018802919", "Djibouti", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 3, 14, 23, 45, 36, 507, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 1, 16, 21, 45, 36, 428, DateTimeKind.Local).AddTicks(4212), "فؤاد أسامة", "Jimmie Mayer", 0, "آدم LLC", "5266493658983911330", "Guernsey", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 12, 15, 12, 52, 12, 799, DateTimeKind.Local).AddTicks(7386), new DateTime(2024, 1, 17, 12, 19, 54, 646, DateTimeKind.Local).AddTicks(5785), "آدم عاشور", "Clara Runolfsson", "هاشم, فريد and عراقی", "4193382580320060606", "Saint Helena", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1982, 10, 13, 8, 11, 48, 757, DateTimeKind.Local).AddTicks(3571), new DateTime(2024, 1, 17, 10, 23, 11, 84, DateTimeKind.Local).AddTicks(5897), "بلال جابر‌", "Demetris Schroeder", "حازم, أسامة and صلاح", "2562991404977019645", "Heard Island and McDonald Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 12, 2, 16, 45, 20, 785, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 1, 16, 21, 39, 9, 517, DateTimeKind.Local).AddTicks(6184), "فاروق هاشم", "Haskell Leannon", 0, "هاشم, سعيد and سعيد", "5428875527222663468", "Pakistan", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 9, 27, 22, 41, 48, 508, DateTimeKind.Local).AddTicks(528), new DateTime(2024, 1, 17, 10, 20, 54, 280, DateTimeKind.Local).AddTicks(4408), "لمى معروف", "Frederic Stoltenberg", "حازم, سعيد and سالم", "8267498266054730734", "Wallis and Futuna", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1985, 3, 8, 15, 6, 6, 453, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 1, 17, 1, 30, 45, 986, DateTimeKind.Local).AddTicks(136), "صلاح عزیز", "Rhiannon Hansen", 1, "عزیز - فؤاد", "1939313918381473685", "Seychelles", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 4, 14, 2, 16, 2, 666, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 1, 17, 0, 10, 34, 4, DateTimeKind.Local).AddTicks(466), "إيهاب صلاح", "Alexie Durgan", "جابر‌ - آدم", "4839743678095530494", "Bermuda", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1977, 3, 23, 0, 0, 9, 382, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 1, 17, 2, 50, 51, 954, DateTimeKind.Local).AddTicks(9906), "أروى إيهاب", "Kris Weissnat", 0, "إيهاب, عاشور and هاشم", "5175343445561634431", "Israel", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 3, 21, 13, 46, 3, 9, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 1, 17, 18, 3, 44, 39, DateTimeKind.Local).AddTicks(8673), "فاطمة طارق", "Winona Hessel", "آدم - عزیز", "4628629009105526947", "Qatar", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1968, 5, 9, 9, 16, 7, 929, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 1, 17, 4, 44, 12, 225, DateTimeKind.Local).AddTicks(1518), "هاجر فاروق", "Terrell Cartwright", 1, "ربيع Inc", "281490186205621499", "Democratic People's Republic of Korea", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2002, 3, 13, 13, 49, 2, 708, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 1, 17, 15, 55, 26, 726, DateTimeKind.Local).AddTicks(6529), "أسامة أمجد", "Dakota Bednar", "عاشور Group", "2889085065275765184", "Guam", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1984, 12, 20, 23, 42, 17, 391, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 1, 17, 16, 43, 17, 498, DateTimeKind.Local).AddTicks(7396), "شيماء عاشور", "Adriana Erdman", "إيهاب, فؤاد and طارق", "1149744704569245088", "Guinea", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 12, 19, 17, 56, 46, 522, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 1, 16, 23, 10, 42, 929, DateTimeKind.Local).AddTicks(748), "آدم بلال", "Bette Carter", "عراقی, آدم and عقیل", "1789617290628507310", "Moldova", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 9, 3, 16, 7, 14, 89, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 1, 17, 6, 2, 9, 990, DateTimeKind.Local).AddTicks(8123), "جابر‌ عاشور", "Gregorio Schimmel", "أسامة, بلال and معروف", "3977124945275998031", "Norway", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 2, 13, 11, 12, 15, 326, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 1, 17, 5, 55, 29, 131, DateTimeKind.Local).AddTicks(1760), "سالم بلال", "Elinor Schultz", 1, "ربيع Inc", "7147443195550870596", "Samoa", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 4, 12, 16, 15, 42, 845, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 1, 17, 8, 40, 44, 227, DateTimeKind.Local).AddTicks(8527), "زينب فاروق", "Augusta Hegmann", 1, "معروف LLC", "607213334259964234", "Belgium", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 3, 21, 1, 57, 43, 849, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 1, 17, 14, 51, 31, 133, DateTimeKind.Local).AddTicks(5604), "آية بلال", "Alda Harber", 0, "صلاح - عارف", "1264150759493866059", "Bouvet Island (Bouvetoya)", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1990, 10, 19, 2, 1, 13, 218, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 1, 17, 13, 39, 23, 859, DateTimeKind.Local).AddTicks(1690), "ربيع إيهاب", "Jimmie Lakin", "حسن, أمجد and زيد", "4871819666672730065", "British Indian Ocean Territory (Chagos Archipelago)", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2000, 3, 7, 10, 42, 22, 548, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 1, 17, 13, 14, 3, 293, DateTimeKind.Local).AddTicks(4856), "ريم فؤاد", "Shanon Hegmann", 1, "إيهاب - معروف", "3160672021825436556", "China", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 1, 23, 18, 16, 43, 997, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 1, 17, 19, 12, 11, 291, DateTimeKind.Local).AddTicks(4111), "فاطمة عارف", "Ramiro Torphy", "جابر‌ - عصار", "793931066932248267", "Antarctica (the territory South of 60 deg S)", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1971, 2, 6, 11, 54, 3, 338, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 1, 17, 8, 53, 16, 113, DateTimeKind.Local).AddTicks(4609), "آية آدم", "Jacques Rice", "عاشور LLC", "1720643358459062394", "Suriname", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1990, 10, 17, 17, 5, 58, 609, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 1, 17, 8, 26, 35, 500, DateTimeKind.Local).AddTicks(7182), "عبير عراقی", "Javonte Kautzer", 0, "إيهاب - هاشم", "5244076327804670447", "Algeria", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 2, 3, 21, 31, 4, 632, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 1, 17, 5, 10, 26, 674, DateTimeKind.Local).AddTicks(608), "رقية عراقی", "Shayna Bode", "عقیل - أسامة", "5761177591497356578", "Burundi", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 8, 12, 13, 11, 41, 889, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 1, 17, 1, 37, 17, 868, DateTimeKind.Local).AddTicks(7173), "أروى سعيد", "Albina Ankunding", 0, "آدم Group", "2218918868452861807", "Jamaica", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 4, 25, 17, 24, 35, 292, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 1, 17, 17, 25, 46, 420, DateTimeKind.Local).AddTicks(6775), "سعيد عصار", "Geraldine Kuhlman", "أسامة Group", "3903196733608388934", "Taiwan", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1965, 1, 6, 3, 14, 16, 157, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 1, 17, 15, 33, 9, 654, DateTimeKind.Local).AddTicks(6997), "سعيد فاروق", "Crawford Pouros", 1, "حسن, صلاح and سعيد", "5150489030401808435", "Iran", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 6, 27, 16, 51, 43, 370, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 1, 17, 3, 38, 49, 86, DateTimeKind.Local).AddTicks(8151), "طارق عقیل", "Judah Lubowitz", 1, "عصار, صلاح and آدم", "8959693068748850733", "Central African Republic", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1994, 6, 3, 3, 53, 7, 556, DateTimeKind.Local).AddTicks(4201), new DateTime(2024, 1, 16, 22, 30, 39, 738, DateTimeKind.Local).AddTicks(703), "زيد إيهاب", "Brice Aufderhar", 1, "فؤاد - طارق", "8999025968519774363", "Russian Federation", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1995, 4, 17, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 1, 16, 22, 44, 57, 277, DateTimeKind.Local).AddTicks(343), "فاطمة صلاح", "Mervin Quitzon", 1, "آدم - أسامة", "7353001004114152806", "Thailand", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1997, 3, 4, 8, 42, 23, 78, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 1, 16, 21, 36, 56, 807, DateTimeKind.Local).AddTicks(3386), "أروى آدم", "Mia Terry", "عصار, عاشور and عراقی", "449666030861216675", "Saint Barthelemy", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1983, 2, 12, 22, 44, 43, 273, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 1, 16, 21, 20, 15, 959, DateTimeKind.Local).AddTicks(1012), "فريدة فريد", "Maximo Howell", 1, "ربيع Inc", "1986570133286554044", "Saint Vincent and the Grenadines", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1991, 3, 29, 1, 24, 29, 874, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 1, 17, 4, 26, 51, 699, DateTimeKind.Local).AddTicks(2014), "إيهاب جابر‌", "Lillie Lemke", 0, "سالم - صلاح", "3178846994739912483", "France", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 7, 26, 18, 12, 2, 528, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 1, 16, 21, 59, 39, 556, DateTimeKind.Local).AddTicks(7117), "أسامة سعيد", "Idell Satterfield", "آدم - سعيد", "5626661539113215200", "Cyprus", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 2, 16, 12, 50, 15, 706, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 1, 17, 1, 48, 20, 250, DateTimeKind.Local).AddTicks(7124), "صلاح أمجد", "Durward Turcotte", "عقیل LLC", "1025411967129962496", "Slovenia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1964, 11, 23, 13, 59, 9, 323, DateTimeKind.Local).AddTicks(7673), new DateTime(2024, 1, 17, 18, 38, 10, 145, DateTimeKind.Local).AddTicks(9129), "شيماء إيهاب", "Estrella Adams", "آدم LLC", "4969104632142350724", "Panama", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1994, 9, 10, 2, 38, 49, 413, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 1, 17, 18, 15, 49, 604, DateTimeKind.Local).AddTicks(4426), "إيهاب عارف", "Audreanne Sauer", "طارق, عاشور and حسن", "5777054233123464499", "Svalbard & Jan Mayen Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1972, 3, 28, 13, 31, 4, 562, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 1, 17, 0, 3, 56, 217, DateTimeKind.Local).AddTicks(990), "جابر‌ فؤاد", "Katarina Romaguera", "عقیل LLC", "945466307513246631", "Zimbabwe", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 11, 19, 12, 14, 22, 32, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 1, 17, 0, 44, 1, 429, DateTimeKind.Local).AddTicks(4936), "حسن فاروق", "Reyes Bayer", 1, "زيد - إيهاب", "5007327161058104263", "Solomon Islands", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 10, 2, 15, 41, 37, 475, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 1, 16, 21, 54, 15, 681, DateTimeKind.Local).AddTicks(1320), "فاروق هاشم", "Tatum Welch", "بلال - عراقی", "4522301024676284084", "Switzerland", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 12, 24, 1, 16, 55, 23, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 1, 17, 10, 35, 59, 14, DateTimeKind.Local).AddTicks(9933), "سعيد ربيع", "Ressie Kunde", "عاشور, ربيع and أسامة", "201140334926075463", "Saudi Arabia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 1, 23, 8, 25, 37, 185, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 1, 17, 7, 37, 35, 292, DateTimeKind.Local).AddTicks(9843), "سالم فؤاد", "Lempi Ondricka", "حسن LLC", "6365358896937452392", "Mozambique", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 5, 24, 5, 13, 41, 959, DateTimeKind.Local).AddTicks(293), new DateTime(2024, 1, 16, 22, 41, 55, 447, DateTimeKind.Local).AddTicks(7630), "فؤاد عصار", "Nelle Abshire", "بلال - آدم", "2442184949710143524", "Portugal", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1960, 4, 3, 5, 36, 13, 608, DateTimeKind.Local).AddTicks(1830), new DateTime(2024, 1, 17, 5, 33, 50, 928, DateTimeKind.Local).AddTicks(6647), "أمجد معروف", "Justina Bahringer", "سالم and Sons", "942892820365020774", "Bhutan", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1954, 3, 16, 21, 28, 43, 899, DateTimeKind.Local).AddTicks(833), new DateTime(2024, 1, 16, 23, 27, 12, 790, DateTimeKind.Local).AddTicks(1226), "أروى صلاح", "Akeem Dicki", "عزیز, حازم and جابر‌", "7239837732882135084", "Seychelles", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1964, 12, 23, 20, 1, 34, 982, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 1, 17, 17, 36, 15, 658, DateTimeKind.Local).AddTicks(2107), "ربيع حازم", "Richie Hayes", 1, "زيد, عراقی and فاروق", "2506825424647263243", "Afghanistan", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(2001, 2, 6, 7, 18, 20, 337, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 1, 17, 3, 38, 57, 842, DateTimeKind.Local).AddTicks(1091), "زينب آدم", "Rogers Fahey", 1, "طارق - جابر‌", "3474662284707557341", "Iceland", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 8, 20, 9, 28, 26, 331, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 1, 16, 22, 53, 49, 509, DateTimeKind.Local).AddTicks(7170), "دانا فؤاد", "Mateo Brakus", "أسامة, معروف and زيد", "5221552773291209544", "Jordan", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1993, 8, 19, 11, 19, 49, 506, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 1, 17, 4, 44, 49, 138, DateTimeKind.Local).AddTicks(3958), "ريم زيد", "Marlin Tremblay", 1, "هاشم, حسن and فؤاد", "6695356412076100115", "Suriname", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1976, 11, 5, 21, 20, 32, 985, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 1, 17, 4, 11, 34, 191, DateTimeKind.Local).AddTicks(531), "طارق معروف", "Cristobal Connelly", "معروف, بلال and فريد", "7692351262913674880", "United States of America", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1979, 7, 20, 0, 45, 59, 369, DateTimeKind.Local).AddTicks(277), new DateTime(2024, 1, 17, 10, 6, 28, 641, DateTimeKind.Local).AddTicks(6487), "لمى هاشم", "Bradley Gislason", 0, "إيهاب Group", "4842436547483577246", "Honduras", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 5, 4, 17, 32, 31, 951, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 1, 17, 17, 25, 11, 697, DateTimeKind.Local).AddTicks(8621), "منى عراقی", "Lenore Schumm", 0, "آدم - سعيد", "5574271577246689405", "Mali", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1997, 8, 22, 20, 56, 25, 753, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 1, 17, 16, 43, 59, 238, DateTimeKind.Local).AddTicks(8435), "عبير طارق", "Mason Larson", "عقیل and Sons", "6964681543648195374", "Australia", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1989, 5, 23, 14, 47, 58, 12, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 1, 17, 1, 8, 50, 327, DateTimeKind.Local).AddTicks(3635), "رنا أسامة", "Tanya Tillman", "فريد Inc", "1962842345475868811", "Montserrat", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 3, 4, 15, 44, 59, 740, DateTimeKind.Local).AddTicks(8167), new DateTime(2024, 1, 17, 13, 4, 14, 109, DateTimeKind.Local).AddTicks(2159), "لمى عراقی", "Gussie Stiedemann", 0, "جابر‌ - عاشور", "8887426886769578284", "Belgium", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 5, 29, 16, 11, 13, 477, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 1, 17, 14, 41, 52, 215, DateTimeKind.Local).AddTicks(7019), "جابر‌ فؤاد", "Braden Ziemann", 1, "هاشم, فريد and عزیز", "1897071946769179834", "Rwanda", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 3, 23, 16, 15, 51, 52, DateTimeKind.Local).AddTicks(7712), new DateTime(2024, 1, 17, 3, 59, 40, 542, DateTimeKind.Local).AddTicks(7633), "ريم فؤاد", "Dariana Tillman", 0, "عقیل Inc", "3052868434785720793", "Yemen", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 4, 20, 16, 25, 37, 281, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 1, 17, 15, 8, 55, 92, DateTimeKind.Local).AddTicks(6821), "صلاح فريد", "Monroe Olson", "عراقی, سعيد and إيهاب", "3627777351674691176", "United Arab Emirates", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 2, 1, 15, 45, 34, 68, DateTimeKind.Local).AddTicks(9201), new DateTime(2024, 1, 17, 6, 31, 7, 157, DateTimeKind.Local).AddTicks(9465), "فريدة ربيع", "Sister Balistreri", 0, "ربيع, أمجد and زيد", "2595822703204099990", "Cameroon", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 12, 11, 11, 55, 54, 269, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 17, 4, 28, 36, 380, DateTimeKind.Local).AddTicks(9059), "أمجد عاشور", "Leanne Stamm", "سعيد, حسن and فريد", "4057013047272803450", "Republic of Korea", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 7, 25, 15, 9, 32, 874, DateTimeKind.Local).AddTicks(3712), new DateTime(2024, 1, 17, 13, 49, 12, 109, DateTimeKind.Local).AddTicks(1039), "أروى بلال", "Erich Parisian", 0, "عقیل - عراقی", "4575698359723031580", "Republic of Korea", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 8, 18, 5, 7, 57, 339, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 1, 17, 1, 30, 18, 617, DateTimeKind.Local).AddTicks(8923), "أسامة عقیل", "Carter Bergstrom", "عصار Inc", "4517495507976611857", "Jersey", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1986, 9, 28, 20, 54, 14, 30, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 1, 17, 13, 16, 29, 849, DateTimeKind.Local).AddTicks(2506), "جمانة عاشور", "Marquise Bruen", 0, "زيد and Sons", "1395596238068910490", "Italy", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1977, 4, 2, 23, 19, 13, 540, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 1, 17, 10, 28, 42, 218, DateTimeKind.Local).AddTicks(3587), "ربيع جابر‌", "Dayton McClure", 1, "جابر‌ Inc", "6423594412572839256", "Puerto Rico", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 1, 11, 0, 48, 0, 403, DateTimeKind.Local).AddTicks(4500), new DateTime(2024, 1, 17, 13, 50, 33, 713, DateTimeKind.Local).AddTicks(4431), "عبير جابر‌", "Rosanna Jenkins", "سعيد, أسامة and هاشم", "4152206247279225572", "Turks and Caicos Islands", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1988, 4, 29, 19, 18, 33, 389, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 1, 16, 22, 7, 49, 790, DateTimeKind.Local).AddTicks(4844), "جمانة فريد", "Stacey Effertz", 1, "عقیل - عزیز", "8362807151210152756", "Aruba", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 12, 15, 21, 37, 45, 594, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 1, 17, 2, 36, 58, 285, DateTimeKind.Local).AddTicks(1699), "سالم عقیل", "Dejah Brakus", 1, "حازم - جابر‌", "9018089750738192986", "Djibouti", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1986, 10, 9, 1, 54, 7, 992, DateTimeKind.Local).AddTicks(9749), new DateTime(2024, 1, 17, 4, 55, 59, 48, DateTimeKind.Local).AddTicks(4575), "سعيد فؤاد", "Phoebe Wiza", "هاشم - أسامة", "587423898264459568", "Cyprus", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 1, 23, 20, 43, 22, 394, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 1, 17, 10, 49, 34, 471, DateTimeKind.Local).AddTicks(8741), "دانا زيد", "Darrell Frami", 1, "سعيد LLC", "7501813372673631154", "Bolivia", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1992, 8, 12, 14, 41, 49, 507, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 1, 17, 3, 31, 34, 122, DateTimeKind.Local).AddTicks(9189), "عبير طارق", "Krystal Jast", "بلال, صلاح and بلال", "8021179794332787634", "Russian Federation", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1978, 7, 16, 9, 8, 31, 927, DateTimeKind.Local).AddTicks(7362), new DateTime(2024, 1, 16, 22, 39, 8, 965, DateTimeKind.Local).AddTicks(8145), "آدم سالم", "Antwan Heidenreich", 0, "فريد - معروف", "2785022136638469494", "Dominica", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1980, 10, 19, 4, 52, 50, 170, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 1, 17, 15, 12, 15, 957, DateTimeKind.Local).AddTicks(5571), "طارق جابر‌", "Violette Kub", 1, "زيد - أسامة", "8047017451067813712", "American Samoa", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1982, 5, 15, 5, 19, 23, 597, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 1, 17, 16, 42, 50, 112, DateTimeKind.Local).AddTicks(3331), "آدم جابر‌", "Marge Ortiz", 0, "سالم Group", "1766244821699453585", "France", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(2001, 9, 19, 19, 12, 20, 576, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 1, 17, 1, 37, 28, 685, DateTimeKind.Local).AddTicks(2240), "آية بلال", "Jeramy Jacobson", "سالم and Sons", "4351442975735188936", "Austria", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1974, 1, 3, 22, 52, 59, 395, DateTimeKind.Local).AddTicks(4521), new DateTime(2024, 1, 17, 16, 7, 48, 255, DateTimeKind.Local).AddTicks(3194), "جابر‌ إيهاب", "Roman Monahan", 0, "حازم - بلال", "9009046482786227056", "Saint Vincent and the Grenadines", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 5, 30, 23, 36, 51, 876, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 1, 17, 5, 7, 10, 552, DateTimeKind.Local).AddTicks(8819), "فريدة عصار", "Eve Kshlerin", "فاروق - فريد", "2333868889726847279", "Dominica", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1988, 3, 28, 4, 9, 0, 489, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 1, 17, 15, 35, 18, 238, DateTimeKind.Local).AddTicks(4239), "حسن عراقی", "Darrel Krajcik", 0, "زيد - بلال", "422727952902241286", "Cameroon", 0, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1999, 4, 29, 6, 53, 41, 885, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 1, 17, 1, 58, 25, 138, DateTimeKind.Local).AddTicks(5019), "أمجد عزیز", "Bradley Considine", 0, "أمجد Group", "2864280014465299700", "Saint Vincent and the Grenadines", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1997, 11, 3, 16, 56, 5, 616, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 1, 16, 23, 17, 45, 641, DateTimeKind.Local).AddTicks(6765), "دانا أسامة", "Taya Aufderhar", "طارق LLC", "6365347137195567010", "Vietnam", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1990, 4, 7, 8, 22, 17, 542, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 1, 17, 0, 7, 5, 835, DateTimeKind.Local).AddTicks(3513), "حسن فاروق", "Deon Braun", "ربيع - آدم", "5569096625158115709", "Cameroon", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1982, 7, 10, 9, 3, 44, 845, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 1, 17, 13, 31, 47, 885, DateTimeKind.Local).AddTicks(7447), "زينب عارف", "Mandy Green", "ربيع, حازم and أمجد", "4531290418143451580", "China", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1961, 5, 30, 2, 45, 53, 31, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 1, 17, 7, 14, 51, 35, DateTimeKind.Local).AddTicks(4946), "سعيد حسن", "Hayley Kilback", 1, "فاروق, ربيع and عقیل", "7833544439595375981", "Luxembourg", 2, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1967, 10, 6, 10, 50, 55, 586, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 1, 17, 10, 9, 1, 256, DateTimeKind.Local).AddTicks(1604), "صلاح سالم", "Dorothea Skiles", "بلال - سعيد", "2091715133036057992", "Montserrat", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1981, 1, 2, 14, 29, 55, 832, DateTimeKind.Local).AddTicks(3027), new DateTime(2024, 1, 17, 0, 21, 39, 958, DateTimeKind.Local).AddTicks(6076), "أمجد فؤاد", "Mallie Ferry", "حسن - عراقی", "6951282858577801622", "Timor-Leste", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "TenantId" },
                values: new object[] { new DateTime(1959, 3, 16, 18, 12, 54, 343, DateTimeKind.Local).AddTicks(5143), new DateTime(2024, 1, 17, 12, 9, 49, 616, DateTimeKind.Local).AddTicks(2729), "فاروق عارف", "Rafael Bailey", "زيد - عاشور", "1978998011650254922", "Israel", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1966, 8, 20, 5, 51, 56, 994, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 1, 17, 4, 30, 10, 168, DateTimeKind.Local).AddTicks(9001), "فاطمة ربيع", "Wyman Quigley", "عاشور and Sons", "6462662086814191423", "Hungary", 4, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1998, 12, 17, 5, 38, 43, 413, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 1, 17, 13, 23, 41, 975, DateTimeKind.Local).AddTicks(6895), "فريدة عارف", "Mariam Walsh", "صلاح Group", "4985443143467531486", "Argentina", 1, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1957, 1, 1, 4, 53, 25, 18, DateTimeKind.Local).AddTicks(188), new DateTime(2024, 1, 17, 0, 55, 44, 111, DateTimeKind.Local).AddTicks(4634), "صلاح طارق", "Earlene Connelly", "أمجد, فؤاد and عصار", "2180779696196266049", "French Polynesia", 3, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState", "TenantId" },
                values: new object[] { new DateTime(1965, 6, 9, 15, 58, 45, 307, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 1, 17, 6, 32, 0, 969, DateTimeKind.Local).AddTicks(303), "عبير بلال", "Rocky Adams", 1, "عارف - فريد", "602672796042395944", "Paraguay", 2, null });
        }
    }
}
