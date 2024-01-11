using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedExtraIdFieldstopatientmodel : Migration
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
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalFiles",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FinancialInfos",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Examinations",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ContactInfos",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Attachments",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 1, 8, 16, 2, 37, 854, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 1, 11, 2, 50, 56, 762, DateTimeKind.Local).AddTicks(8835), "دانا عقیل", "Elian Moen", "إيهاب, طارق and آدم", "9071105467005408354", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 6, 19, 0, 49, 2, 314, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 1, 10, 23, 0, 54, 576, DateTimeKind.Local).AddTicks(4878), "ريم هاشم", "Mervin Kunze", "عراقی - سعيد", "3163600396146096247", "Mexico", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 6, 16, 6, 55, 23, 900, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 1, 11, 7, 52, 52, 607, DateTimeKind.Local).AddTicks(7973), "أسامة آدم", "Watson Ledner", "آدم Group", "2407230456735101376", "United States Minor Outlying Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1967, 11, 17, 15, 32, 33, 393, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 1, 11, 14, 30, 57, 860, DateTimeKind.Local).AddTicks(6143), "عبير عاشور", "Ricardo Hagenes", "هاشم - بلال", "291154248207542165", "Papua New Guinea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 11, 6, 17, 57, 3, 577, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 1, 11, 10, 58, 28, 117, DateTimeKind.Local).AddTicks(8219), "سارة عصار", "Adrien Torp", 1, "عزیز, حازم and إيهاب", "2819313326515113161", "Holy See (Vatican City State)", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 5, 27, 14, 28, 10, 742, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 1, 11, 0, 35, 27, 575, DateTimeKind.Local).AddTicks(8017), "سالم فاروق", "Vanessa Boehm", 1, "عراقی, ربيع and سالم", "7361469411915736283", "Democratic People's Republic of Korea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 14, 16, 27, 24, 984, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 1, 11, 4, 35, 30, 256, DateTimeKind.Local).AddTicks(1763), "دانا إيهاب", "Kaela Prosacco", 1, "زيد LLC", "5168399304173916764", "Jordan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 6, 15, 22, 41, 12, 328, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 1, 10, 20, 56, 20, 882, DateTimeKind.Local).AddTicks(3741), "فؤاد سعيد", "Waino Koch", 1, "أسامة Group", "7866161929868549925", "United Arab Emirates" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 5, 12, 9, 5, 4, 24, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 1, 11, 3, 4, 14, 539, DateTimeKind.Local).AddTicks(5832), "فاطمة سالم", "Salvador Gerlach", 0, "فاروق - عراقی", "5910206501063446069", "Uganda", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 7, 9, 6, 40, 36, 963, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 1, 11, 2, 19, 45, 175, DateTimeKind.Local).AddTicks(4840), "أسامة أسامة", "Heloise Boyer", "حسن - عاشور", "3323719247719833537", "Oman", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 10, 23, 5, 50, 16, 487, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 1, 11, 12, 46, 35, 878, DateTimeKind.Local).AddTicks(9812), "فؤاد عاشور", "Max Watsica", 0, "سعيد - سعيد", "6338521481751809030", "Sudan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 9, 18, 16, 27, 16, 38, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 1, 10, 22, 16, 53, 271, DateTimeKind.Local).AddTicks(4874), "حسن صلاح", "Watson Wuckert", 0, "فؤاد - حازم", "5021625015739959972", "Liechtenstein", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 2, 19, 12, 17, 13, 114, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 1, 11, 7, 57, 50, 740, DateTimeKind.Local).AddTicks(150), "أمجد أمجد", "Reta Steuber", "آدم, معروف and عاشور", "6054428367541960783", "Egypt", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 10, 8, 21, 57, 0, 673, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 1, 11, 20, 32, 38, 273, DateTimeKind.Local).AddTicks(4314), "جابر‌ فريد", "Ottis Lockman", 0, "عزیز, عاشور and طارق", "2972925339202190388", "Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 17, 18, 39, 19, 681, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 1, 11, 9, 12, 5, 711, DateTimeKind.Local).AddTicks(6446), "أمجد صلاح", "Andy Rodriguez", 1, "أسامة - أسامة", "1884498268770474051", "Italy", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 1, 28, 2, 13, 51, 879, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 1, 11, 2, 9, 44, 529, DateTimeKind.Local).AddTicks(8607), "أروى أسامة", "Bryce Armstrong", 1, "زيد and Sons", "2648012875036075844", "Saint Pierre and Miquelon", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 5, 10, 9, 57, 34, 402, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 1, 10, 20, 42, 17, 655, DateTimeKind.Local).AddTicks(8281), "حازم ربيع", "Ethelyn Breitenberg", 1, "عاشور Inc", "5647794766211140369", "Zimbabwe", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 1, 21, 16, 37, 8, 404, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 1, 11, 2, 44, 32, 565, DateTimeKind.Local).AddTicks(169), "فاطمة فاروق", "Maegan McCullough", "جابر‌ - أسامة", "5474005920416995672", "Cameroon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 4, 7, 6, 58, 22, 456, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 1, 11, 19, 18, 26, 631, DateTimeKind.Local).AddTicks(4610), "أروى حازم", "Quincy Ebert", "سالم, جابر‌ and آدم", "9133923359811715732", "Liechtenstein", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 28, 17, 4, 43, 442, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 1, 11, 3, 17, 15, 333, DateTimeKind.Local).AddTicks(9856), "سارة أسامة", "Kim Orn", 1, "ربيع - بلال", "4954650597171414969", "Timor-Leste", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 9, 13, 16, 48, 52, 605, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 1, 11, 1, 12, 16, 780, DateTimeKind.Local).AddTicks(6988), "حازم طارق", "Warren Breitenberg", "حسن - أمجد", "5134659423716825096", "Brazil", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 12, 18, 9, 45, 42, 175, DateTimeKind.Local).AddTicks(6393), new DateTime(2024, 1, 11, 10, 23, 28, 659, DateTimeKind.Local).AddTicks(9743), "دانا بلال", "Mathew Quitzon", 1, "أسامة LLC", "1795552770321383537", "Wallis and Futuna" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 2, 24, 22, 54, 16, 328, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 1, 11, 9, 22, 52, 129, DateTimeKind.Local).AddTicks(8140), "رقية صلاح", "Thaddeus Heller", "عاشور and Sons", "8930860406060870419", "Saint Helena", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 9, 6, 23, 43, 1, 883, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 1, 11, 20, 32, 35, 334, DateTimeKind.Local).AddTicks(8104), "فؤاد هاشم", "Roselyn Kerluke", 1, "آدم LLC", "5525017299172270615", "Kyrgyz Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 9, 2, 16, 8, 19, 221, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 1, 11, 4, 25, 31, 206, DateTimeKind.Local).AddTicks(9747), "جابر‌ عصار", "Cullen Roberts", "عقیل Group", "4246377726145640654", "Tokelau", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 30, 8, 0, 20, 785, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 1, 11, 3, 36, 2, 274, DateTimeKind.Local).AddTicks(2025), "جمانة معروف", "Nettie Romaguera", 0, "فؤاد and Sons", "5048787359111831175", "Albania", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 4, 13, 11, 51, 58, 361, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 11, 10, 53, 53, 747, DateTimeKind.Local).AddTicks(4149), "دانا آدم", "Dasia Hirthe", "جابر‌, أسامة and بلال", "4265462397918410638", "Antarctica (the territory South of 60 deg S)", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 7, 1, 19, 34, 53, 746, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 1, 11, 4, 19, 54, 569, DateTimeKind.Local).AddTicks(4704), "أسامة عاشور", "Geoffrey Koepp", "9163918563354590756", "Macao" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 20, 2, 13, 3, 417, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 1, 11, 18, 49, 4, 581, DateTimeKind.Local).AddTicks(7630), "رنا صلاح", "Bud Moore", 0, "عصار and Sons", "7470552526551536574", "Finland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 1, 21, 17, 39, 38, 805, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 1, 11, 12, 18, 28, 569, DateTimeKind.Local).AddTicks(2906), "فاطمة ربيع", "Edmond Cummerata", "بلال - عقیل", "2736004772281638218", "Georgia", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 23, 20, 27, 19, 664, DateTimeKind.Local).AddTicks(7916), new DateTime(2024, 1, 11, 4, 48, 0, 300, DateTimeKind.Local).AddTicks(9904), "فاروق فاروق", "Dulce Bartell", "عارف LLC", "1333796323201717375", "Guernsey", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 5, 24, 22, 28, 55, 501, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 1, 11, 11, 19, 22, 50, DateTimeKind.Local).AddTicks(38), "زيد آدم", "Adrien Emmerich", "معروف, زيد and عقیل", "3449948972740265343", "Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1975, 3, 6, 22, 51, 26, 111, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 1, 11, 4, 8, 44, 453, DateTimeKind.Local).AddTicks(110), "شيماء حازم", "Eddie Waters", "هاشم - معروف", "882212355857885138", "Isle of Man" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 9, 5, 18, 42, 35, 537, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 1, 11, 19, 37, 50, 328, DateTimeKind.Local).AddTicks(873), "لمى عزیز", "Mohammad Tillman", 0, "ربيع - عزیز", "3768999044402969756", "Hong Kong", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 8, 28, 0, 35, 45, 789, DateTimeKind.Local).AddTicks(5032), new DateTime(2024, 1, 11, 13, 3, 21, 342, DateTimeKind.Local).AddTicks(3029), "ربيع آدم", "Maryam Abernathy", 1, "أمجد LLC", "7981707600039668218", "Dominica", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 20, 15, 13, 50, 897, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 1, 11, 18, 52, 15, 864, DateTimeKind.Local).AddTicks(8286), "أسامة ربيع", "Clara Corkery", "فؤاد - جابر‌", "8184224740518858321", "Suriname", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 8, 26, 9, 2, 6, 970, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 1, 11, 16, 47, 15, 455, DateTimeKind.Local).AddTicks(3574), "سالم زيد", "Anastasia Nolan", 1, "حسن LLC", "3237696571732411138", "Equatorial Guinea", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 12, 19, 14, 17, 38, 212, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 1, 11, 10, 37, 17, 70, DateTimeKind.Local).AddTicks(1153), "إيناس معروف", "Adelle Marvin", "حسن, ربيع and سعيد", "108486704838436004", "Macao", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 2, 17, 16, 38, 35, 267, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 1, 11, 5, 33, 34, 239, DateTimeKind.Local).AddTicks(9082), "زينب فريد", "Wyman Bechtelar", 1, "حسن and Sons", "609639303708407823", "Trinidad and Tobago", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 2, 3, 16, 5, 57, 433, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 1, 11, 20, 17, 58, 330, DateTimeKind.Local).AddTicks(6477), "منى عزیز", "Abagail Parisian", 0, "طارق, زيد and عاشور", "5186685774758631510", "Nigeria" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 12, 18, 8, 1, 39, 775, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 1, 11, 7, 19, 59, 325, DateTimeKind.Local).AddTicks(865), "فريدة عراقی", "Jennifer Wintheiser", "إيهاب - عراقی", "6177155365792934124", "Tunisia" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 8, 3, 14, 40, 2, 929, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 1, 10, 21, 13, 26, 227, DateTimeKind.Local).AddTicks(2902), "سالم أمجد", "Astrid Tromp", 1, "فريد, سالم and صلاح", "8412760191697455504", "Spain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 22, 19, 53, 11, 190, DateTimeKind.Local).AddTicks(5006), new DateTime(2024, 1, 11, 0, 41, 46, 0, DateTimeKind.Local).AddTicks(3846), "فريدة عراقی", "Lauretta Kunze", 0, "بلال LLC", "5973570977850425117", "Argentina", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 4, 13, 11, 53, 31, 348, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 1, 11, 7, 19, 34, 547, DateTimeKind.Local).AddTicks(2731), "آدم حازم", "Raul Heaney", "أمجد, أمجد and عراقی", "5291854310010892755", "Antigua and Barbuda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 6, 5, 4, 49, 53, 292, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 1, 11, 16, 55, 30, 981, DateTimeKind.Local).AddTicks(9848), "بلال زيد", "Mohammed Konopelski", "إيهاب, هاشم and عاشور", "4150415391679666294", "Maldives" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 7, 11, 11, 44, 9, 578, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 1, 11, 13, 55, 41, 408, DateTimeKind.Local).AddTicks(5793), "آية عارف", "Malachi Jerde", 0, "إيهاب, إيهاب and عارف", "315017078357902250", "Micronesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 7, 17, 10, 10, 24, 202, DateTimeKind.Local).AddTicks(4311), new DateTime(2024, 1, 11, 13, 12, 53, 627, DateTimeKind.Local).AddTicks(1839), "بلال جابر‌", "Olin Nikolaus", "سعيد LLC", "150735852943088437", "Guadeloupe", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 10, 28, 14, 3, 53, 209, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 1, 11, 1, 44, 38, 569, DateTimeKind.Local).AddTicks(4867), "هاجر إيهاب", "Alberto Ernser", "معروف and Sons", "1999055682970490860", "Singapore", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 10, 6, 7, 6, 18, 410, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 1, 11, 10, 50, 16, 811, DateTimeKind.Local).AddTicks(2745), "صلاح إيهاب", "Aaron Sporer", 1, "جابر‌ - زيد", "2940461979656145414", "Singapore", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 12, 18, 2, 3, 43, 606, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 1, 11, 19, 28, 18, 780, DateTimeKind.Local).AddTicks(2025), "فريد طارق", "Lula Halvorson", "عزیز and Sons", "6225090047506961810", "United States of America" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 11, 22, 16, 51, 24, 469, DateTimeKind.Local).AddTicks(5369), new DateTime(2024, 1, 10, 21, 48, 34, 217, DateTimeKind.Local).AddTicks(6544), "فاروق أمجد", "Karl Murray", 1, "إيهاب - آدم", "816853333488286063", "Christmas Island" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 6, 1, 13, 48, 38, 85, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 1, 11, 15, 32, 1, 914, DateTimeKind.Local).AddTicks(7410), "سعيد طارق", "Glen Morar", "عراقی LLC", "5090767080887640953", "Libyan Arab Jamahiriya", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 6, 28, 4, 28, 26, 125, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 1, 11, 12, 33, 22, 900, DateTimeKind.Local).AddTicks(3414), "فريدة حازم", "Adalberto Gaylord", 0, "طارق and Sons", "2864116035519156814", "Wallis and Futuna", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 7, 15, 21, 33, 52, 692, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 1, 11, 15, 27, 51, 240, DateTimeKind.Local).AddTicks(5031), "عبير حازم", "Marques Crooks", 1, "سالم Group", "5948577347375724794", "Luxembourg", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 10, 13, 23, 16, 59, 202, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 1, 11, 2, 48, 33, 555, DateTimeKind.Local).AddTicks(7151), "منى زيد", "Romaine Torp", 1, "معروف, أسامة and زيد", "8983175101018095596", "Ecuador", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 5, 19, 20, 15, 38, 67, DateTimeKind.Local).AddTicks(845), new DateTime(2024, 1, 10, 20, 58, 1, 91, DateTimeKind.Local).AddTicks(2300), "جابر‌ حازم", "Eliza Berge", 1, "عصار - حازم", "5462186326543481891", "Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 19, 20, 34, 47, 184, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 1, 11, 14, 5, 31, 59, DateTimeKind.Local).AddTicks(544), "رنا أمجد", "Gloria Hilll", 0, "أسامة Inc", "4653589231553145970", "American Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 9, 25, 17, 3, 37, 683, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 1, 11, 11, 22, 54, 679, DateTimeKind.Local).AddTicks(8149), "فريدة أسامة", "Xavier Gusikowski", 0, "أسامة Inc", "250201570521906342", "Iraq" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 8, 27, 6, 39, 10, 106, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 1, 11, 10, 9, 45, 183, DateTimeKind.Local).AddTicks(6467), "دانا عصار", "Weldon Kuhlman", 0, "عقیل - عصار", "8424436407971380424", "Virgin Islands, British", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 12, 16, 22, 51, 6, 676, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 1, 11, 17, 24, 52, 313, DateTimeKind.Local).AddTicks(9757), "إيهاب عقیل", "Kelton Hackett", "فريد Group", "8401417070385166835", "Indonesia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 12, 9, 11, 38, 31, 131, DateTimeKind.Local).AddTicks(4712), new DateTime(2024, 1, 11, 5, 32, 17, 602, DateTimeKind.Local).AddTicks(1616), "منى فاروق", "Carolina Reinger", "عزیز LLC", "9006934702911002159", "Iraq", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 9, 12, 5, 10, 40, 124, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 1, 11, 11, 34, 48, 353, DateTimeKind.Local).AddTicks(9880), "زينب سالم", "Gracie Altenwerth", "أمجد, صلاح and فريد", "4455146786542534690", "Cambodia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 1, 26, 12, 39, 26, 373, DateTimeKind.Local).AddTicks(3429), new DateTime(2024, 1, 11, 16, 38, 59, 774, DateTimeKind.Local).AddTicks(6095), "فريدة عراقی", "Delia Cole", "حازم, ربيع and أمجد", "1889821248376583593", "Bermuda", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 1, 16, 19, 21, 18, 4, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 1, 11, 4, 51, 24, 262, DateTimeKind.Local).AddTicks(6763), "سالم حازم", "Tressie Gerlach", 0, "ربيع - طارق", "1785776344300505300", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 8, 21, 18, 24, 48, 188, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 1, 11, 19, 27, 51, 358, DateTimeKind.Local).AddTicks(4179), "آدم فؤاد", "Beth Baumbach", "فاروق, زيد and هاشم", "2469154144521751350", "Djibouti" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 16, 4, 36, 54, 451, DateTimeKind.Local).AddTicks(1029), new DateTime(2024, 1, 11, 16, 55, 4, 704, DateTimeKind.Local).AddTicks(1200), "أمجد فاروق", "Ned Sauer", 0, "زيد - جابر‌", "3074590491590449133", "Saint Barthelemy", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 7, 23, 5, 35, 45, 586, DateTimeKind.Local).AddTicks(1904), new DateTime(2024, 1, 11, 14, 12, 33, 673, DateTimeKind.Local).AddTicks(6023), "فريد معروف", "Marjorie Kulas", 1, "صلاح - آدم", "2464075015125223947", "Venezuela" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 7, 25, 15, 0, 38, 735, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 1, 11, 8, 30, 32, 632, DateTimeKind.Local).AddTicks(3916), "أروى عراقی", "Carli Erdman", 0, "طارق Group", "5437119659003048278", "Macedonia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 9, 3, 0, 29, 34, DateTimeKind.Local).AddTicks(7545), new DateTime(2024, 1, 11, 18, 37, 4, 541, DateTimeKind.Local).AddTicks(8316), "رنا عزیز", "Krista Christiansen", "عقیل - عاشور", "3606803206525785350", "Paraguay", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2002, 12, 21, 11, 56, 17, 689, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 1, 11, 3, 56, 28, 194, DateTimeKind.Local).AddTicks(6746), "منى عزیز", "Ima Kutch", "فؤاد - عراقی", "8769118690530500056", "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 1, 8, 8, 52, 29, 277, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 1, 10, 23, 39, 56, 78, DateTimeKind.Local).AddTicks(9570), "فاطمة إيهاب", "Hugh Lesch", 0, "عاشور, حازم and أسامة", "2516545690871357071", "Zimbabwe", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 6, 7, 17, 40, 10, 762, DateTimeKind.Local).AddTicks(6026), new DateTime(2024, 1, 11, 18, 54, 41, 443, DateTimeKind.Local).AddTicks(8568), "لمى أمجد", "Pearl Mayer", 0, "صلاح, عزیز and ربيع", "7700266412336108577", "Haiti", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 5, 17, 6, 46, 23, 234, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 1, 10, 23, 34, 43, 841, DateTimeKind.Local).AddTicks(6304), "سالم عزیز", "Emiliano Lang", "جابر‌ - إيهاب", "2304248750905404951", "Nicaragua", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 23, 12, 12, 48, 613, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 1, 11, 3, 57, 51, 903, DateTimeKind.Local).AddTicks(285), "زينب عزیز", "Jarrett Goyette", 0, "عارف LLC", "2413787315773441889", "Japan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 7, 5, 6, 41, 5, 239, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 1, 10, 22, 51, 31, 741, DateTimeKind.Local).AddTicks(5060), "أروى فريد", "Isac Toy", 1, "عاشور - سالم", "4146601335780838729", "French Polynesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 28, 1, 2, 45, 483, DateTimeKind.Local).AddTicks(5023), new DateTime(2024, 1, 10, 23, 28, 10, 898, DateTimeKind.Local).AddTicks(8096), "إيهاب زيد", "Alexie Schuppe", 1, "آدم, فريد and فاروق", "1011246246116112249", "Puerto Rico", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 8, 23, 21, 43, 0, 204, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 1, 11, 4, 14, 41, 728, DateTimeKind.Local).AddTicks(4546), "طارق حسن", "Ayla Feest", 1, "سعيد, أمجد and عراقی", "691148185885462783", "Marshall Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 5, 27, 10, 22, 49, 974, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 1, 10, 23, 12, 11, 25, DateTimeKind.Local).AddTicks(4761), "إيهاب عراقی", "Hudson Jacobs", "سعيد - معروف", "3756825549476619696", "Vanuatu", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1972, 7, 30, 2, 23, 4, 77, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 1, 11, 4, 40, 34, 652, DateTimeKind.Local).AddTicks(1736), "منى أمجد", "Kenton Casper", "سعيد - سعيد", "2989638710960124465", "Turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 24, 8, 34, 36, 708, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 1, 11, 0, 52, 45, 408, DateTimeKind.Local).AddTicks(4870), "آية أمجد", "Berniece Pouros", 0, "صلاح, عزیز and عزیز", "1708595185757070649", "Iraq", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 5, 19, 10, 11, 0, 214, DateTimeKind.Local).AddTicks(4333), new DateTime(2024, 1, 11, 5, 41, 34, 215, DateTimeKind.Local).AddTicks(971), "طارق طارق", "Tiana Medhurst", 0, "ربيع - عارف", "8047675559294422657", "Swaziland", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 10, 21, 6, 24, 51, 970, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 1, 11, 15, 9, 13, 654, DateTimeKind.Local).AddTicks(9740), "بلال حسن", "Austen Pfannerstill", "حازم - عاشور", "8665897487869945297", "Saint Pierre and Miquelon" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 6, 5, 14, 21, 33, 585, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 1, 11, 14, 11, 46, 924, DateTimeKind.Local).AddTicks(8426), "دانا آدم", "Cade Gleichner", "معروف and Sons", "934913683560564996", "Svalbard & Jan Mayen Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 12, 29, 20, 55, 43, 274, DateTimeKind.Local).AddTicks(7899), new DateTime(2024, 1, 11, 5, 21, 54, 362, DateTimeKind.Local).AddTicks(9231), "فاروق عقیل", "Luisa Fritsch", 1, "فؤاد - آدم", "8238651794960255828", "Rwanda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 5, 21, 13, 21, 11, 564, DateTimeKind.Local).AddTicks(5003), new DateTime(2024, 1, 11, 6, 17, 49, 818, DateTimeKind.Local).AddTicks(4625), "رقية حسن", "Kris Hermiston", 1, "فاروق and Sons", "287976674337852229", "China", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 11, 17, 19, 59, 40, 175, DateTimeKind.Local).AddTicks(9957), new DateTime(2024, 1, 10, 21, 36, 37, 80, DateTimeKind.Local).AddTicks(3171), "ريم إيهاب", "Julius VonRueden", "عقیل, فاروق and عزیز", "7393232556779708067", "Mozambique", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 5, 7, 5, 26, 41, 623, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 1, 11, 0, 20, 21, 836, DateTimeKind.Local).AddTicks(5253), "زيد عاشور", "Makenzie Stiedemann", 0, "فاروق - طارق", "4323224280225040393", "Cameroon", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 9, 16, 3, 58, 6, 463, DateTimeKind.Local).AddTicks(9793), new DateTime(2024, 1, 11, 12, 58, 13, 340, DateTimeKind.Local).AddTicks(4590), "سالم عارف", "Valentina Kautzer", "فريد, زيد and حسن", "6407611510514033724", "Mayotte" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 5, 8, 25, 22, 969, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 1, 11, 18, 25, 32, 789, DateTimeKind.Local).AddTicks(8510), "إيهاب جابر‌", "Santino Greenholt", 1, "عصار Group", "3611161252727895476", "Lesotho", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 7, 19, 22, 45, 37, 791, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 1, 11, 18, 0, 14, 257, DateTimeKind.Local).AddTicks(3820), "سالم عارف", "Marvin Hand", 0, "حازم, زيد and فريد", "785638308724225760", "Nigeria" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 10, 18, 19, 3, 21, 382, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 1, 11, 13, 24, 39, 195, DateTimeKind.Local).AddTicks(7903), "فاطمة حسن", "Kennedy Nitzsche", 1, "حازم - بلال", "388028965865222614", "Brunei Darussalam", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 1, 31, 23, 36, 4, 714, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 1, 11, 3, 10, 37, 122, DateTimeKind.Local).AddTicks(1690), "زينب بلال", "Larissa Schmitt", "حسن Group", "8422012267001892430", "Chad" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 4, 12, 4, 30, 23, 969, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 1, 11, 13, 43, 41, 216, DateTimeKind.Local).AddTicks(1872), "دانا بلال", "Frederique Mosciski", "هاشم and Sons", "3696665777639239385", "Holy See (Vatican City State)", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 11, 2, 11, 48, 57, 125, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 1, 11, 6, 38, 5, 415, DateTimeKind.Local).AddTicks(447), "رنا سعيد", "Johann Stark", "إيهاب, عقیل and عصار", "4319117960287178874", "Cuba" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1963, 2, 8, 13, 28, 24, 463, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 1, 11, 8, 26, 48, 497, DateTimeKind.Local).AddTicks(3386), "جمانة صلاح", "Adelle Batz", 0, "حسن Group", "6421249621855788753", "Belgium" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 5, 12, 6, 24, 21, 696, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 1, 11, 18, 2, 22, 998, DateTimeKind.Local).AddTicks(6795), "لمى حازم", "Nyasia Fisher", 1, "جابر‌ - حازم", "4252217795586116393", "Bosnia and Herzegovina", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 9, 29, 16, 30, 27, 3, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 1, 11, 20, 5, 48, 232, DateTimeKind.Local).AddTicks(3543), "طارق فريد", "Irving Lebsack", "عراقی Inc", "7303458793283757018", "Gibraltar", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 10, 25, 9, 44, 41, 600, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 1, 11, 12, 40, 27, 616, DateTimeKind.Local).AddTicks(8987), "حسن جابر‌", "Lucio Blanda", "عراقی, عزیز and فؤاد", "1367453039109467387", "Kazakhstan", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 11, 15, 12, 33, 43, 843, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 1, 11, 7, 27, 39, 167, DateTimeKind.Local).AddTicks(7884), "جمانة عصار", "Tara Marquardt", "فريد - حسن", "2956084059508892113", "Romania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 4, 15, 8, 42, 56, 883, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 1, 11, 17, 13, 37, 515, DateTimeKind.Local).AddTicks(3043), "جمانة جابر‌", "Ayla Skiles", 0, "بلال and Sons", "6632352758683786632", "Dominica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 5, 11, 23, 8, 33, 570, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 1, 11, 12, 2, 22, 726, DateTimeKind.Local).AddTicks(7089), "هاجر زيد", "Martin Kerluke", 1, "عاشور, عزیز and عارف", "5593222305939990102", "Libyan Arab Jamahiriya", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 11, 19, 14, 48, 4, 955, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 1, 11, 18, 48, 49, 545, DateTimeKind.Local).AddTicks(294), "فاروق عارف", "Cecil Stiedemann", 1, "ربيع - فاروق", "6825153200068379736", "Cocos (Keeling) Islands" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 12, 1, 22, 36, 38, 40, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 1, 11, 15, 27, 2, 481, DateTimeKind.Local).AddTicks(7824), "أروى جابر‌", "Andreanne Spencer", "عاشور and Sons", "7159245106575680939", "Montserrat", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 5, 8, 14, 22, 33, 107, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 1, 11, 13, 47, 45, 285, DateTimeKind.Local).AddTicks(6454), "فريدة صلاح", "Thea Kling", 1, "جابر‌ Group", "564429754649372582", "Honduras", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 11, 17, 18, 26, 14, 681, DateTimeKind.Local).AddTicks(8476), new DateTime(2024, 1, 11, 17, 45, 2, 405, DateTimeKind.Local).AddTicks(5220), "أمجد عقیل", "Preston Boehm", "حازم, حسن and ربيع", "8678415142331324316", "New Zealand", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 12, 6, 10, 49, 22, 231, DateTimeKind.Local).AddTicks(4489), new DateTime(2024, 1, 11, 4, 49, 1, 662, DateTimeKind.Local).AddTicks(4844), "رنا عصار", "Laurine Reilly", 0, "عقیل - أسامة", "8146193092870438496", "Faroe Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 8, 12, 17, 22, 59, 203, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 1, 11, 8, 29, 2, 676, DateTimeKind.Local).AddTicks(878), "ربيع أسامة", "Kiera Ryan", 1, "حسن LLC", "6520138983723824907", "United States of America", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1967, 1, 7, 22, 8, 28, 129, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 1, 11, 18, 55, 39, 715, DateTimeKind.Local).AddTicks(2960), "فريد آدم", "Marge Parisian", 1, "فؤاد - عارف", "5293604075376987669", "Peru" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 8, 0, 0, 23, 581, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 1, 11, 2, 49, 15, 102, DateTimeKind.Local).AddTicks(5361), "هاجر جابر‌", "Gracie Rutherford", "حسن Group", "8774663522717340537", "Moldova", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 8, 31, 9, 9, 0, 885, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 1, 11, 11, 44, 27, 245, DateTimeKind.Local).AddTicks(6492), "أمجد فريد", "Eve Hirthe", 1, "حازم - سعيد", "8380165462031275574", "Turkmenistan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 11, 4, 18, 3, 18, 535, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 1, 11, 11, 16, 15, 298, DateTimeKind.Local).AddTicks(342), "أروى إيهاب", "Parker Romaguera", 1, "معروف, فريد and صلاح", "6013118155729662634", "Angola", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 11, 26, 1, 42, 8, 986, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 1, 11, 9, 45, 46, 904, DateTimeKind.Local).AddTicks(4158), "ربيع فاروق", "Kimberly Renner", 0, "أمجد, عزیز and إيهاب", "7331852465810217098", "New Caledonia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 6, 18, 18, 20, 12, 336, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 1, 11, 9, 43, 8, 786, DateTimeKind.Local).AddTicks(214), "هاجر فريد", "Margaretta Quigley", 0, "عصار, آدم and عارف", "1301034723210508265", "Norway", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 28, 0, 26, 1, 84, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 1, 11, 5, 16, 13, 905, DateTimeKind.Local).AddTicks(2919), "هاجر صلاح", "Marcia Muller", 0, "هاشم - معروف", "1448466143817486528", "San Marino", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 1, 9, 5, 55, 24, 41, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 1, 11, 3, 14, 27, 548, DateTimeKind.Local).AddTicks(5656), "آية أمجد", "Jorge Satterfield", 0, "فاروق, زيد and معروف", "6872022802287258707", "Norfolk Island", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 4, 5, 7, 11, 24, 187, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 1, 11, 19, 31, 32, 654, DateTimeKind.Local).AddTicks(6156), "هاجر سعيد", "Bernhard Walter", 1, "إيهاب and Sons", "4354760585248250570", "Liberia", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 11, 2, 21, 3, 42, 84, DateTimeKind.Local).AddTicks(5086), new DateTime(2024, 1, 11, 10, 45, 6, 309, DateTimeKind.Local).AddTicks(4912), "فاطمة سعيد", "Kirstin Ondricka", "حازم - إيهاب", "3758067515421165895", "Vietnam", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 5, 10, 12, 49, 0, 981, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 1, 11, 3, 43, 20, 868, DateTimeKind.Local).AddTicks(7193), "جمانة أسامة", "Scotty Johns", "أسامة LLC", "2899440884940764161", "Turkmenistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 3, 5, 22, 57, 52, 974, DateTimeKind.Local).AddTicks(5832), new DateTime(2024, 1, 11, 11, 2, 10, 520, DateTimeKind.Local).AddTicks(9093), "ربيع صلاح", "Eulalia Stehr", "سالم Inc", "2555740545892400807", "Turks and Caicos Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 12, 14, 9, 26, 20, 260, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 1, 11, 13, 25, 22, 736, DateTimeKind.Local).AddTicks(8219), "لمى عصار", "Reed Kirlin", "سعيد - عارف", "4174073808811608485", "Malta", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 4, 16, 9, 57, 1, 945, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 1, 11, 12, 46, 33, 380, DateTimeKind.Local).AddTicks(9748), "لمى أسامة", "Juston Bradtke", 0, "فريد - حسن", "2547908874777995689", "Jamaica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 12, 7, 5, 51, 9, 884, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 1, 11, 18, 41, 53, 995, DateTimeKind.Local).AddTicks(6812), "بلال أسامة", "Jarred Reynolds", "عاشور - عصار", "2378304369859150848", "Lao People's Democratic Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 9, 26, 13, 26, 43, 694, DateTimeKind.Local).AddTicks(6381), new DateTime(2024, 1, 11, 19, 31, 22, 276, DateTimeKind.Local).AddTicks(110), "زينب عصار", "Christelle Hettinger", "بلال - عراقی", "8904218673354366193", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 3, 31, 19, 50, 1, 177, DateTimeKind.Local).AddTicks(2898), new DateTime(2024, 1, 11, 1, 2, 59, 569, DateTimeKind.Local).AddTicks(9816), "فريدة فريد", "Mabelle Grant", 0, "فريد Inc", "8277277556394708130", "Israel", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 10, 14, 5, 18, 4, 493, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 1, 11, 17, 41, 43, 736, DateTimeKind.Local).AddTicks(4123), "دانا أسامة", "Dawson Cruickshank", "سالم LLC", "6050638395022859473", "Afghanistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 6, 28, 8, 52, 33, 762, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 1, 11, 14, 28, 44, 735, DateTimeKind.Local).AddTicks(3427), "زيد جابر‌", "Roberto MacGyver", "سعيد - سعيد", "1279821754793663026", "Cote d'Ivoire", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 8, 9, 20, 25, 54, 407, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 1, 11, 10, 38, 15, 573, DateTimeKind.Local).AddTicks(417), "أمجد سالم", "Maybell Pacocha", "طارق Inc", "2400030958208958770", "Niue", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 12, 26, 2, 15, 40, 631, DateTimeKind.Local).AddTicks(2888), new DateTime(2024, 1, 11, 10, 20, 56, 246, DateTimeKind.Local).AddTicks(7275), "رنا عاشور", "Idella O'Hara", "زيد, سالم and جابر‌", "7246058628610574676", "France", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 4, 20, 16, 35, 4, 703, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 1, 10, 22, 32, 1, 806, DateTimeKind.Local).AddTicks(9844), "دانا سعيد", "Salvador Upton", "عصار, فاروق and زيد", "8174502093089934326", "Republic of Korea" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 10, 19, 16, 57, 38, 733, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 1, 11, 18, 59, 44, 864, DateTimeKind.Local).AddTicks(2151), "شيماء أمجد", "Julian Streich", "معروف, جابر‌ and فاروق", "7244563270681090656", "Venezuela", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 15, 15, 6, 31, 406, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 1, 11, 6, 44, 28, 805, DateTimeKind.Local).AddTicks(2047), "آية صلاح", "Raleigh Nader", "عاشور LLC", "6068645799134117171", "Gambia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 4, 20, 5, 49, 49, 307, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 1, 11, 17, 36, 36, 853, DateTimeKind.Local).AddTicks(1911), "لمى عصار", "Jazmyne Beier", 0, "فريد Group", "5641352637396799349", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 1, 30, 0, 19, 38, 442, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 1, 11, 20, 28, 4, 217, DateTimeKind.Local).AddTicks(7852), "منى عزیز", "Moises Pollich", "سالم Inc", "1090206449269472535", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 1, 16, 6, 37, 14, 225, DateTimeKind.Local).AddTicks(1699), new DateTime(2024, 1, 11, 0, 32, 1, 358, DateTimeKind.Local).AddTicks(4598), "منى عقیل", "Harry Lowe", "عارف, أسامة and صلاح", "7869060743058054044", "Mauritius", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 5, 15, 12, 6, 28, 352, DateTimeKind.Local).AddTicks(2564), new DateTime(2024, 1, 11, 2, 38, 30, 238, DateTimeKind.Local).AddTicks(7328), "زينب طارق", "Hardy Price", 1, "حازم, عقیل and عارف", "8064293677575587500", "Lao People's Democratic Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 11, 9, 15, 42, 37, 935, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 1, 11, 17, 2, 28, 174, DateTimeKind.Local).AddTicks(4929), "ربيع عاشور", "Gisselle Bins", "عزیز and Sons", "8056284977399997241", "Jersey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 2, 17, 11, 3, 796, DateTimeKind.Local).AddTicks(7841), new DateTime(2024, 1, 11, 0, 24, 48, 492, DateTimeKind.Local).AddTicks(4446), "إيهاب فؤاد", "Lynn Rutherford", "معروف LLC", "5377516724553888632", "Germany", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 6, 12, 11, 8, 12, 10, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 1, 11, 9, 2, 52, 402, DateTimeKind.Local).AddTicks(4058), "زيد عارف", "Missouri Koelpin", 0, "أمجد and Sons", "3924665230796860669", "Gambia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 3, 5, 12, 1, 17, 925, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 1, 11, 10, 44, 29, 130, DateTimeKind.Local).AddTicks(5053), "آية عارف", "Baron Hackett", 0, "إيهاب - عصار", "2464978231995067558", "Macao", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1959, 8, 23, 21, 25, 48, 876, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 1, 11, 10, 47, 16, 563, DateTimeKind.Local).AddTicks(8805), "ريم أسامة", "Spencer Marks", 0, "عزیز LLC", "5720955285169730173", "Georgia" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "TreatmentsHistory",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalFiles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "FinancialInfos",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Examinations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ContactInfos",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Attachments",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, شارع سباری, 6424, ينبع, Pakistan", "العقير", new DateTime(2024, 1, 11, 4, 56, 31, 506, DateTimeKind.Local).AddTicks(1261), "rym_blal27@yahoo.com", "1-416-970-2487" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, دوار سباری, 23, الوادي, Morocco", "تجكجة", new DateTime(2024, 1, 10, 18, 37, 17, 751, DateTimeKind.Local).AddTicks(5486), "abyr80@yahoo.com", "207-590-2464" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, 4, عجمان, Vietnam", "حمص", new DateTime(2024, 1, 11, 6, 18, 23, 478, DateTimeKind.Local).AddTicks(2847), "arwa_hazm35@hotmail.com", "407.793.0167 x14594" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, ش اقبال لاهوری, 15, خنشلة, Nicaragua", "الكوت", new DateTime(2024, 1, 11, 9, 12, 2, 874, DateTimeKind.Local).AddTicks(9126), "frydh.blal35@hotmail.com", "1-659-835-0044" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, 8, صفاقس, Tonga", "سرت", new DateTime(2024, 1, 11, 16, 57, 50, 894, DateTimeKind.Local).AddTicks(2791), "tarq66@gmail.com", "512.929.7682 x483" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, دوار آفریقا, 24, بني ملال, Luxembourg", "عنابة", new DateTime(2024, 1, 10, 21, 1, 2, 390, DateTimeKind.Local).AddTicks(5837), "sayd59@hotmail.com", "370-890-6719" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, 6, خان شيخون, Armenia", "تيارت", new DateTime(2024, 1, 11, 11, 4, 27, 875, DateTimeKind.Local).AddTicks(809), "zyd11@gmail.com", "1-819-396-4156 x07498" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 368, داريا, Guinea", "الدرعية", new DateTime(2024, 1, 11, 11, 48, 6, 836, DateTimeKind.Local).AddTicks(4435), "sarh.slah82@yahoo.com", "538.929.3942" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, ش راستوان, 5, حارم, Cote d'Ivoire", "أم القيوين", new DateTime(2024, 1, 11, 3, 3, 59, 630, DateTimeKind.Local).AddTicks(6526), "hajr33@gmail.com", "398.538.6076" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, طريق مالک اشتر, 34, صبراتة, American Samoa", "الجلفة", new DateTime(2024, 1, 10, 20, 6, 5, 998, DateTimeKind.Local).AddTicks(3109), "iyhab58@gmail.com", "678-820-9473" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 743, صور, Grenada", "مكة المكرمة", new DateTime(2024, 1, 11, 10, 10, 25, 705, DateTimeKind.Local).AddTicks(3751), "rbya50@yahoo.com", "1-718-863-2934" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, تقاطع هویزه, 8, منح, Russian Federation", "نوى", new DateTime(2024, 1, 10, 19, 11, 3, 161, DateTimeKind.Local).AddTicks(3866), "rqyh_blal@gmail.com", "1-457-725-6670 x327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, تقاطع واعظی, 8, حلبجة, Brunei Darussalam", "بن عروس", new DateTime(2024, 1, 10, 18, 34, 20, 727, DateTimeKind.Local).AddTicks(712), "arwa.asamh28@yahoo.com", "411-310-0507" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 5, جد حفص, Vanuatu", "البيضاء", new DateTime(2024, 1, 11, 6, 36, 34, 570, DateTimeKind.Local).AddTicks(6536), "blal_aqyl52@gmail.com", "(907) 344-4081" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, ميدان دکتر چمران, 242, دير عطية, Haiti", "الدمام", new DateTime(2024, 1, 10, 20, 49, 12, 743, DateTimeKind.Local).AddTicks(3155), "hsn.rbya@yahoo.com", "273-506-8175 x41059" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, 985, بريدة, Saint Vincent and the Grenadines", "مدينة ستة أكتوبر", new DateTime(2024, 1, 11, 13, 39, 9, 586, DateTimeKind.Local).AddTicks(3125), "aayh4@hotmail.com", "451-384-6013 x2826" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, ش یادگار امام, 1999, اللد, Netherlands", "سيدي قاسم", new DateTime(2024, 1, 11, 3, 11, 47, 247, DateTimeKind.Local).AddTicks(5232), "frydh32@yahoo.com", "(445) 695-4658" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, 42, البصرة, Samoa", "الخروب", new DateTime(2024, 1, 10, 21, 37, 7, 360, DateTimeKind.Local).AddTicks(2384), "farwq_azyz@yahoo.com", "(555) 955-4882 x8781" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, 626, عجلون, Namibia", "عفك", new DateTime(2024, 1, 11, 10, 13, 58, 83, DateTimeKind.Local).AddTicks(1107), "arwa82@gmail.com", "(265) 726-7230" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 6047, الديماس, Svalbard & Jan Mayen Islands", "الجوف", new DateTime(2024, 1, 11, 7, 15, 54, 441, DateTimeKind.Local).AddTicks(1399), "rbya.sayd51@hotmail.com", "784-464-9742 x9601" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, شارع آزادی, 171, أسيوط, Nicaragua", "ربك", new DateTime(2024, 1, 10, 17, 6, 10, 916, DateTimeKind.Local).AddTicks(3233), "amjd_sayd67@yahoo.com", "(545) 327-3222 x575" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, 25, رفحا, Tokelau", "السويداء", new DateTime(2024, 1, 11, 8, 0, 40, 0, DateTimeKind.Local).AddTicks(6043), "fatmh_aashwr56@yahoo.com", "1-891-610-4047 x889" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 4967, بوتلميت, Ukraine", "مدينة عيسى", new DateTime(2024, 1, 10, 21, 3, 37, 967, DateTimeKind.Local).AddTicks(7033), "zyd.asar@yahoo.com", "807.418.9266 x8996" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, شارع رسالت, 2593, براقي, Holy See (Vatican City State)", "الزقازيق", new DateTime(2024, 1, 11, 9, 56, 20, 999, DateTimeKind.Local).AddTicks(4227), "rym_rbya54@gmail.com", "612.258.1740 x845" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, 98, تلعفر, Fiji", "الفحيحيل", new DateTime(2024, 1, 11, 0, 39, 3, 16, DateTimeKind.Local).AddTicks(645), "dana86@yahoo.com", "409-262-5464" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, ميدان دیباجی, 868, زليطن, Chad", "جد حفص", new DateTime(2024, 1, 11, 11, 0, 7, 113, DateTimeKind.Local).AddTicks(5933), "iynas63@gmail.com", "1-244-368-7157 x9551" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, طريق شهید مطهری, 393, صور, Cuba", "أبو ظبي", new DateTime(2024, 1, 11, 5, 0, 3, 216, DateTimeKind.Local).AddTicks(5130), "fatmh94@gmail.com", "1-315-777-5062 x190" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, 67, عنيزة, Vietnam", "دهبان", new DateTime(2024, 1, 11, 8, 25, 54, 763, DateTimeKind.Local).AddTicks(6438), "lma_iyhab39@hotmail.com", "(949) 547-3232 x741" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, طريق فاطمی, 3, القنفذة, Guadeloupe", "تيماء", new DateTime(2024, 1, 11, 10, 45, 0, 527, DateTimeKind.Local).AddTicks(9166), "abyr33@yahoo.com", "1-646-832-2231 x429" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 0, الطريف, Cape Verde", "عين العرب", new DateTime(2024, 1, 11, 3, 45, 56, 244, DateTimeKind.Local).AddTicks(7129), "arwa_hsn@hotmail.com", "851-369-7543" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, ميدان فاطمی, 613, بنت جبيل, Sri Lanka", "الضعين", new DateTime(2024, 1, 11, 7, 39, 33, 812, DateTimeKind.Local).AddTicks(4151), "tarq_marwf69@yahoo.com", "669-987-2857 x55232" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, 6188, خور فكان, Spain", "الجبيل", new DateTime(2024, 1, 10, 20, 42, 50, 780, DateTimeKind.Local).AddTicks(7201), "rna.aqyl@yahoo.com", "383-273-2843 x70313" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, طريق یادگار امام, 0, القطيف, Burkina Faso", "الرس", new DateTime(2024, 1, 10, 20, 8, 9, 602, DateTimeKind.Local).AddTicks(2527), "lma_amjd95@gmail.com", "995.289.0565 x147" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, تقاطع دستغیب, 4406, سيلبابي, Saint Lucia", "ريسوت", new DateTime(2024, 1, 11, 13, 0, 39, 357, DateTimeKind.Local).AddTicks(4349), "aadm20@hotmail.com", "(543) 243-3980 x244" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, طريق ابوذر, 181, مراكش, Bangladesh", "الناظور", new DateTime(2024, 1, 11, 6, 53, 17, 562, DateTimeKind.Local).AddTicks(3167), "iynas.zyd68@gmail.com", "(881) 207-5125" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, 7291, نيالا, New Zealand", "سوسه", new DateTime(2024, 1, 11, 12, 7, 53, 524, DateTimeKind.Local).AddTicks(9875), "arwa_asar@yahoo.com", "518-618-6200" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, شارع مالک اشتر, 54, نيالا, Gibraltar", "حلفا الجديدة", new DateTime(2024, 1, 10, 20, 59, 49, 924, DateTimeKind.Local).AddTicks(5383), "hsn62@hotmail.com", "682.498.2786" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, شارع دیباجی, 294, طرعان, Palestinian Territory", "سلفيت", new DateTime(2024, 1, 11, 4, 20, 51, 967, DateTimeKind.Local).AddTicks(5365), "farwq.hashm@gmail.com", "382-284-8475 x966" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 13, يي, Barbados", "دهبان", new DateTime(2024, 1, 11, 13, 14, 19, 994, DateTimeKind.Local).AddTicks(3924), "mna79@gmail.com", "1-420-694-2414 x17870" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, طريق سمیه, 263, قابس, Liechtenstein", "جرش", new DateTime(2024, 1, 11, 12, 59, 14, 336, DateTimeKind.Local).AddTicks(8793), "salm85@yahoo.com", "793.937.5986 x9390" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, ميدان آفریقا, 5652, القاهرة, Djibouti", "الخرطوم", new DateTime(2024, 1, 11, 14, 1, 47, 466, DateTimeKind.Local).AddTicks(759), "slah43@hotmail.com", "807-317-6191" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, تقاطع هویزه, 64, بنى سويف, Sao Tome and Principe", "دير الزور", new DateTime(2024, 1, 10, 18, 26, 23, 29, DateTimeKind.Local).AddTicks(1833), "zynb_aashwr48@yahoo.com", "956.584.8890 x40790" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, ش حقانی, 97, العين, Papua New Guinea", "غارو", new DateTime(2024, 1, 10, 18, 54, 46, 756, DateTimeKind.Local).AddTicks(8281), "frydh_hashm15@hotmail.com", "(862) 330-0970 x3048" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, ميدان امیرکبیر, 60, ثادق, British Indian Ocean Territory (Chagos Archipelago)", "جبلة", new DateTime(2024, 1, 11, 5, 25, 47, 942, DateTimeKind.Local).AddTicks(121), "rqyh_aqyl62@gmail.com", "1-889-915-6848" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, ميدان اجاره دار, 9, البغدادي, Chad", "صنعاء", new DateTime(2024, 1, 11, 2, 33, 9, 720, DateTimeKind.Local).AddTicks(1261), "jabr.slah@yahoo.com", "534-605-2414 x84537" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, 4, صرمان, Peru", "الحريق", new DateTime(2024, 1, 11, 0, 6, 52, 277, DateTimeKind.Local).AddTicks(3520), "iynas12@hotmail.com", "1-678-613-6398 x44972" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, 445, القاهرة, Jordan", "هيت", new DateTime(2024, 1, 10, 22, 24, 54, 867, DateTimeKind.Local).AddTicks(6694), "arwa_jabr@hotmail.com", "(663) 626-6401" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, ش آفریقا, 59, بسكرة, Niue", "حقل", new DateTime(2024, 1, 10, 20, 37, 13, 932, DateTimeKind.Local).AddTicks(347), "frydh63@hotmail.com", "482.284.6892 x111" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 6648, سيلبابي, Aruba", "ملوى", new DateTime(2024, 1, 11, 8, 26, 24, 396, DateTimeKind.Local).AddTicks(6858), "blal_fryd70@hotmail.com", "(251) 722-4936 x1595" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, دوار دستغیب, 80, دوما, Wallis and Futuna", "عدل بكرو", new DateTime(2024, 1, 11, 0, 56, 35, 966, DateTimeKind.Local).AddTicks(1923), "hsn46@yahoo.com", "(656) 674-9847 x8151" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, تقاطع حقانی, 514, السويق, Gabon", "التل", new DateTime(2024, 1, 11, 15, 6, 45, 497, DateTimeKind.Local).AddTicks(3876), "abyr81@gmail.com", "1-861-499-6796 x67122" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, شارع حقانی, 114, سيدي سليمان, Liberia", "العوجا", new DateTime(2024, 1, 11, 8, 45, 31, 710, DateTimeKind.Local).AddTicks(6941), "asamh.marwf19@yahoo.com", "1-451-792-2672" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, طريق دیباجی, 175, ريان, Pakistan", "العقبة", new DateTime(2024, 1, 10, 21, 25, 52, 908, DateTimeKind.Local).AddTicks(2785), "farwq62@hotmail.com", "540-477-8912 x20122" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, ميدان کارگر شمالی, 590, صفوى, Rwanda", "المرج", new DateTime(2024, 1, 11, 10, 22, 23, 134, DateTimeKind.Local).AddTicks(2539), "hsn.sayd64@yahoo.com", "686-530-6756" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, ش آذربایجان, 2, جازان, Serbia", "نواكشوط", new DateTime(2024, 1, 10, 21, 15, 24, 85, DateTimeKind.Local).AddTicks(2558), "zynb_hsn@hotmail.com", "1-364-527-5069" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, تقاطع راستوان, 1, عشرة رمضان, Saint Helena", "بن عروس", new DateTime(2024, 1, 11, 3, 58, 3, 355, DateTimeKind.Local).AddTicks(9099), "hazm19@hotmail.com", "564.563.4982 x031" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, 1, الدقم, Kyrgyz Republic", "الرفاع الغربي", new DateTime(2024, 1, 11, 0, 24, 9, 33, DateTimeKind.Local).AddTicks(1524), "salm_tarq80@gmail.com", "(438) 415-1853 x37617" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, طريق اجاره دار, 8015, سيدي بلعباس, Poland", "صلالة", new DateTime(2024, 1, 11, 0, 49, 20, 521, DateTimeKind.Local).AddTicks(6733), "jabr_fryd@yahoo.com", "1-201-463-5814 x9963" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, 863, الفحيص, New Caledonia", "بيت لاهيا", new DateTime(2024, 1, 11, 3, 47, 49, 630, DateTimeKind.Local).AddTicks(3984), "sayd41@yahoo.com", "(723) 888-1866 x997" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, 687, صحم, Mongolia", "هيت", new DateTime(2024, 1, 11, 12, 7, 58, 17, DateTimeKind.Local).AddTicks(3464), "farwq87@gmail.com", "730.426.5050 x81954" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, 5954, بوكى, Saudi Arabia", "البغدادي", new DateTime(2024, 1, 11, 14, 29, 27, 925, DateTimeKind.Local).AddTicks(6472), "zynb_fuad@gmail.com", "751.852.2897 x08200" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, تقاطع قدس, 25, خان يونس, Greece", "كفرشوبا", new DateTime(2024, 1, 11, 16, 46, 44, 698, DateTimeKind.Local).AddTicks(8979), "frydh_hsn38@yahoo.com", "(719) 865-6856" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, 025, أم القيوين, India", "وجدة", new DateTime(2024, 1, 10, 23, 40, 58, 438, DateTimeKind.Local).AddTicks(3078), "salm_azyz85@hotmail.com", "422-594-7763" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, 996, الرقة, Cape Verde", "ثقبة", new DateTime(2024, 1, 10, 18, 9, 29, 768, DateTimeKind.Local).AddTicks(2326), "blal57@gmail.com", "560-529-1780" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع استاد قریب, شارع شهید مطهری, 2334, إب, Heard Island and McDonald Islands", "جاردو", new DateTime(2024, 1, 10, 21, 49, 14, 355, DateTimeKind.Local).AddTicks(5064), "fatmh26@yahoo.com", "433-358-8785 x3973" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, 5, الرمثا, Liechtenstein", "مال", new DateTime(2024, 1, 11, 5, 5, 9, 126, DateTimeKind.Local).AddTicks(3449), "sarh69@yahoo.com", "(250) 613-3586 x49030" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, 901, جبلة, Iraq", "قابس", new DateTime(2024, 1, 11, 6, 44, 55, 780, DateTimeKind.Local).AddTicks(8003), "lma66@gmail.com", "528.668.7940 x217" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, 57, السليمانية, Sri Lanka", "العين", new DateTime(2024, 1, 11, 2, 34, 13, 431, DateTimeKind.Local).AddTicks(6204), "rqyh.tarq21@hotmail.com", "1-828-988-8169" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, 72, الدقم, Egypt", "المدينة المنورة", new DateTime(2024, 1, 10, 22, 49, 31, 325, DateTimeKind.Local).AddTicks(3159), "frydh.hashm@gmail.com", "511.450.6694 x79487" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, 55, العقير, Dominican Republic", "السويداء", new DateTime(2024, 1, 11, 13, 23, 39, 482, DateTimeKind.Local).AddTicks(3900), "tarq23@yahoo.com", "374.815.9414" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, 96, الديماس, Sri Lanka", "فرسان", new DateTime(2024, 1, 10, 23, 57, 3, 638, DateTimeKind.Local).AddTicks(8995), "zyd.blal@hotmail.com", "(240) 546-7781 x529" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق استاد قریب, 4046, سنار, Panama", "جونية", new DateTime(2024, 1, 11, 7, 22, 8, 96, DateTimeKind.Local).AddTicks(5007), "fryd_fryd@gmail.com", "1-269-819-6053 x1226" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 8256, بليث وين, Iceland", "دسوق", new DateTime(2024, 1, 11, 14, 3, 44, 656, DateTimeKind.Local).AddTicks(9449), "amjd.fuad@hotmail.com", "840.599.7902 x88274" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 386, جلافي, Ghana", "صلالة", new DateTime(2024, 1, 10, 23, 51, 5, 556, DateTimeKind.Local).AddTicks(8247), "iyhab_iyhab17@yahoo.com", "301.730.3542 x5236" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, 7, جسر الشغور, Slovakia (Slovak Republic)", "عين وسارة", new DateTime(2024, 1, 10, 23, 50, 50, 810, DateTimeKind.Local).AddTicks(6502), "hazm26@yahoo.com", "333.743.7975 x27444" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, شارع شهید مطهری, 502, أخميم, Belarus", "بنها", new DateTime(2024, 1, 11, 15, 56, 29, 851, DateTimeKind.Local).AddTicks(1315), "jabr_farwq53@gmail.com", "(467) 576-2963" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, ميدان حقانی, 58, العين, Bouvet Island (Bouvetoya)", "الأبيض", new DateTime(2024, 1, 11, 16, 28, 57, 506, DateTimeKind.Local).AddTicks(5687), "abyr16@hotmail.com", "(216) 317-0603" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, 97, السليل, Lithuania", "شيبه", new DateTime(2024, 1, 11, 6, 24, 18, 108, DateTimeKind.Local).AddTicks(1722), "hazm.asar@yahoo.com", "753-922-2371 x4238" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, تقاطع یادگار امام, 20, خور فكان, Timor-Leste", "الدمام", new DateTime(2024, 1, 11, 4, 33, 11, 996, DateTimeKind.Local).AddTicks(7164), "slah.aarf@hotmail.com", "701.303.6431 x85591" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, تقاطع دیباجی, 836, نيالا, Tokelau", "منبج", new DateTime(2024, 1, 11, 14, 24, 9, 665, DateTimeKind.Local).AddTicks(6283), "iyhab_azyz92@gmail.com", "(663) 785-8165" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, 058, حلبجة, Turkmenistan", "الرمثا", new DateTime(2024, 1, 11, 10, 14, 27, 922, DateTimeKind.Local).AddTicks(5408), "rqyh.farwq@yahoo.com", "677.212.4406" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, تقاطع دستغیب, 1, وادي زم, Ghana", "كسلا", new DateTime(2024, 1, 10, 23, 0, 27, 640, DateTimeKind.Local).AddTicks(7978), "hsn89@yahoo.com", "649-865-0630 x163" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, ش امیرکبیر, 719, تيارت, India", "مدينة ستة أكتوبر", new DateTime(2024, 1, 11, 2, 25, 24, 549, DateTimeKind.Local).AddTicks(5384), "hazm_aadm9@hotmail.com", "349-843-6462 x47216" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, تقاطع ابوذر, 14, المحرق, Tuvalu", "سامراء", new DateTime(2024, 1, 11, 16, 27, 7, 478, DateTimeKind.Local).AddTicks(9803), "hajr.blal@gmail.com", "1-364-860-2824 x1520" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, 16, اولاد التايمة, Iceland", "تنبدغة", new DateTime(2024, 1, 10, 17, 22, 4, 74, DateTimeKind.Local).AddTicks(8354), "lma11@gmail.com", "699-246-3586 x33475" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, طريق دکتر چمران, 7, النعمة, Guernsey", "عدن", new DateTime(2024, 1, 11, 4, 41, 11, 267, DateTimeKind.Local).AddTicks(5554), "rym25@yahoo.com", "313.285.5240" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, ميدان اجاره دار, 97, الجنينة, Cape Verde", "مدينة ستة أكتوبر", new DateTime(2024, 1, 11, 7, 34, 48, 175, DateTimeKind.Local).AddTicks(5835), "asamh_farwq79@yahoo.com", "(866) 668-9334" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, ش آفریقا, 6, تعز, Papua New Guinea", "صور", new DateTime(2024, 1, 11, 4, 27, 3, 106, DateTimeKind.Local).AddTicks(3564), "sarh_aqyl@hotmail.com", "465-861-6043 x2390" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 7, القبة, Bulgaria", "رأس الخيمة", new DateTime(2024, 1, 11, 3, 19, 26, 547, DateTimeKind.Local).AddTicks(3156), "rbya.aadm84@gmail.com", "1-730-895-8098 x0914" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, دوار رسالت, 97, بعبدا, French Guiana", "عمان", new DateTime(2024, 1, 11, 10, 21, 9, 698, DateTimeKind.Local).AddTicks(3652), "iynas_zyd71@yahoo.com", "(827) 987-5605" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, 2032, الجفر, Denmark", "جالكاسيو", new DateTime(2024, 1, 10, 18, 28, 49, 764, DateTimeKind.Local).AddTicks(6053), "arwa.zyd@yahoo.com", "1-790-698-6960" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 49, القنيطرة, Rwanda", "حارم", new DateTime(2024, 1, 11, 16, 14, 29, 905, DateTimeKind.Local).AddTicks(6773), "rbya22@gmail.com", "(365) 557-9296 x0834" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, دوار آزادی, 325, قالمة, Burundi", "الدار البيضاء", new DateTime(2024, 1, 10, 22, 51, 57, 13, DateTimeKind.Local).AddTicks(6469), "farwq_marwf14@gmail.com", "241-655-0244" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, طريق حقانی, 40, خفجي, Republic of Korea", "المناقل", new DateTime(2024, 1, 11, 6, 27, 21, 990, DateTimeKind.Local).AddTicks(8871), "arwa.aarf68@hotmail.com", "521-728-1172 x162" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, طريق حقانی, 2, يافا, Svalbard & Jan Mayen Islands", "جد حفص", new DateTime(2024, 1, 11, 2, 43, 49, 592, DateTimeKind.Local).AddTicks(8528), "iyhab.jabr20@gmail.com", "514.380.6277 x2726" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, ميدان قدس, 8, سمائل, Turks and Caicos Islands", "عدل بكرو", new DateTime(2024, 1, 10, 23, 43, 58, 484, DateTimeKind.Local).AddTicks(9429), "rbya.sayd@yahoo.com", "(902) 725-2152 x5468" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, ميدان امیرکبیر, 9669, جرجا, Costa Rica", "سيدي بلعباس", new DateTime(2024, 1, 10, 17, 47, 4, 521, DateTimeKind.Local).AddTicks(5278), "sayd.hsn86@gmail.com", "(474) 344-9380" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, دوار دماوند, 7798, طولكرم, Western Sahara", "مسقط", new DateTime(2024, 1, 10, 20, 4, 41, 909, DateTimeKind.Local).AddTicks(6621), "amjd.iyhab46@gmail.com", "596-549-9695" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, 9, سامراء, Senegal", "الوادي", new DateTime(2024, 1, 11, 7, 14, 43, 816, DateTimeKind.Local).AddTicks(8090), "frydh.jabr19@gmail.com", "627.939.8910" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, طريق حقانی, 1, سلفيت, Monaco", "الهفوف", new DateTime(2024, 1, 11, 7, 28, 18, 538, DateTimeKind.Local).AddTicks(6627), "mna.asamh53@gmail.com", "(912) 667-7904" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, شارع شهید مطهری, 4, دسوق, Poland", "الجبيل", new DateTime(2024, 1, 11, 13, 20, 55, 282, DateTimeKind.Local).AddTicks(4324), "arwa_iyhab99@hotmail.com", "860.554.9506 x47807" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, 3218, تطوان, Mozambique", "المحرق", new DateTime(2024, 1, 10, 23, 17, 5, 967, DateTimeKind.Local).AddTicks(8992), "salm84@yahoo.com", "268-812-5082 x7456" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, طريق قدس, 15, خفجي, Cameroon", "تازة", new DateTime(2024, 1, 10, 22, 16, 36, 997, DateTimeKind.Local).AddTicks(5086), "mna3@hotmail.com", "364-626-6475 x59757" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, 8472, القنفذة, Dominican Republic", "مصياف", new DateTime(2024, 1, 11, 15, 41, 29, 953, DateTimeKind.Local).AddTicks(8282), "shymaa66@hotmail.com", "666.308.7452" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, 7358, هرجيسة, Saint Martin", "أم القيوين", new DateTime(2024, 1, 11, 14, 55, 9, 643, DateTimeKind.Local).AddTicks(3755), "rqyh_amjd@yahoo.com", "967-628-3813 x12788" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, شارع راستوان, 243, بيت لحم, Jamaica", "بركان", new DateTime(2024, 1, 10, 19, 51, 31, 102, DateTimeKind.Local).AddTicks(31), "arwa.hsn89@yahoo.com", "(631) 565-3992" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, دوار دماوند, 640, ميت غمر, Belize", "بيروت", new DateTime(2024, 1, 11, 16, 38, 19, 700, DateTimeKind.Local).AddTicks(6427), "sarh_hsn65@hotmail.com", "(341) 763-0857" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, ش اقبال لاهوری, 45, تنومة, Iran", "صيدا", new DateTime(2024, 1, 10, 23, 55, 26, 505, DateTimeKind.Local).AddTicks(9494), "tarq_hashm11@yahoo.com", "(610) 847-2135" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, ميدان هویزه, 5, حديثة, United States Minor Outlying Islands", "الدار البيضاء", new DateTime(2024, 1, 10, 18, 33, 15, 632, DateTimeKind.Local).AddTicks(5130), "rqyh5@gmail.com", "(909) 974-3527 x975" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, 10, دخيل, Samoa", "السليمانية", new DateTime(2024, 1, 11, 2, 45, 3, 937, DateTimeKind.Local).AddTicks(8703), "lma_fuad69@hotmail.com", "(563) 481-2960 x24058" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, طريق راستوان, 18, العيون, Reunion", "النهود", new DateTime(2024, 1, 11, 2, 18, 11, 118, DateTimeKind.Local).AddTicks(501), "zynb_aashwr71@yahoo.com", "(986) 685-5317 x13879" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 7, دمازين, Republic of Korea", "صوران", new DateTime(2024, 1, 11, 16, 6, 28, 104, DateTimeKind.Local).AddTicks(1665), "rym43@hotmail.com", "(876) 616-3991 x666" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, طريق حقانی, 946, الأبيض, Bermuda", "بجاية", new DateTime(2024, 1, 11, 2, 0, 59, 655, DateTimeKind.Local).AddTicks(2379), "salm.azyz65@yahoo.com", "854.703.2533" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, 2215, تارودانت, Dominican Republic", "دهبان", new DateTime(2024, 1, 11, 7, 26, 52, 686, DateTimeKind.Local).AddTicks(4537), "lma_aadm@yahoo.com", "885.852.4271" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, شارع فاطمی, 126, الناصرة, Cape Verde", "قلعة السراغنة", new DateTime(2024, 1, 11, 6, 6, 52, 801, DateTimeKind.Local).AddTicks(6255), "slah_aarf@hotmail.com", "(396) 634-3969 x599" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, تقاطع آزادی, 8, الرباط, Gambia", "عفك", new DateTime(2024, 1, 10, 21, 2, 59, 282, DateTimeKind.Local).AddTicks(1333), "rbya_aadm61@hotmail.com", "1-220-862-6109" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 7646, ورقلة, Romania", "الزرقاء", new DateTime(2024, 1, 10, 18, 58, 16, 963, DateTimeKind.Local).AddTicks(854), "farwq.blal@hotmail.com", "1-419-792-1850 x831" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, 32, بيجي, Switzerland", "دمياط", new DateTime(2024, 1, 10, 23, 39, 28, 268, DateTimeKind.Local).AddTicks(8306), "iyhab.sayd25@gmail.com", "930-838-2518 x39912" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, 8, دهوك, Yemen", "العمران", new DateTime(2024, 1, 10, 18, 58, 17, 634, DateTimeKind.Local).AddTicks(9091), "dana_slah59@gmail.com", "729.800.6142 x21695" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 61, فاس, Brazil", "سيهات", new DateTime(2024, 1, 11, 7, 38, 57, 95, DateTimeKind.Local).AddTicks(8278), "hsn74@gmail.com", "1-585-511-3328 x98320" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, شارع سمیه, 800, المسيلة, Virgin Islands, U.S.", "تدمر", new DateTime(2024, 1, 11, 8, 5, 4, 396, DateTimeKind.Local).AddTicks(4030), "hajr_amjd@gmail.com", "848.576.3193 x9807" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, ميدان سمیه, 81, القائم, Cook Islands", "تقورت", new DateTime(2024, 1, 11, 14, 40, 38, 318, DateTimeKind.Local).AddTicks(2519), "asamh92@hotmail.com", "275.491.8056" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, 261, وزان, Marshall Islands", "عشرة رمضان", new DateTime(2024, 1, 11, 0, 44, 44, 598, DateTimeKind.Local).AddTicks(7522), "zyd.iyhab@hotmail.com", "681-273-3383" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, ميدان امیرکبیر, 3969, سيلبابي, Anguilla", "الفلوجة", new DateTime(2024, 1, 11, 9, 46, 3, 278, DateTimeKind.Local).AddTicks(5798), "abyr_slah@gmail.com", "(930) 496-4509 x614" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, 55, القطيف, Dominica", "برشيد", new DateTime(2024, 1, 11, 9, 53, 38, 394, DateTimeKind.Local).AddTicks(7704), "mna.salm@gmail.com", "868.251.9397" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, 2, العضيلية, Armenia", "العضيلية", new DateTime(2024, 1, 11, 2, 27, 52, 342, DateTimeKind.Local).AddTicks(4565), "sayd_marwf79@hotmail.com", "875-697-3294" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, 43, البغدادي, Armenia", "مدينة ستة أكتوبر", new DateTime(2024, 1, 10, 22, 19, 25, 141, DateTimeKind.Local).AddTicks(4231), "jmanh_aarf39@gmail.com", "903.711.6664 x390" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, دوار آفریقا, 58, القطيفة, South Georgia and the South Sandwich Islands", "حائل", new DateTime(2024, 1, 11, 9, 53, 53, 576, DateTimeKind.Local).AddTicks(3621), "hsn_marwf@gmail.com", "(240) 413-5384" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, ميدان راستوان, 71, بلبيس, Jordan", "منح", new DateTime(2024, 1, 11, 10, 22, 58, 320, DateTimeKind.Local).AddTicks(8774), "hazm_iyhab41@hotmail.com", "719-885-9229 x31167" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, شارع ابوذر, 5, رأس الخيمة, Vietnam", "سكيكدة", new DateTime(2024, 1, 10, 21, 20, 19, 808, DateTimeKind.Local).AddTicks(6961), "iyhab0@yahoo.com", "1-645-894-8929 x55093" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, تقاطع دکتر چمران, 4, سيهات, Lao People's Democratic Republic", "سرت", new DateTime(2024, 1, 10, 21, 52, 43, 382, DateTimeKind.Local).AddTicks(5472), "rym.iyhab@gmail.com", "480.978.6013 x594" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, شارع قدس, 0, مدينة الكويت, Saint Kitts and Nevis", "غليزان", new DateTime(2024, 1, 11, 7, 51, 14, 122, DateTimeKind.Local).AddTicks(9877), "farwq_aashwr@hotmail.com", "(718) 205-6239 x0250" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 5, لؤلؤة قطر, Virgin Islands, U.S.", "الكسوة", new DateTime(2024, 1, 10, 19, 2, 43, 279, DateTimeKind.Local).AddTicks(2474), "jabr.slah49@gmail.com", "558.830.5087" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, طريق آذربایجان, 71, زحلة, Sudan", "عرعر", new DateTime(2024, 1, 11, 14, 55, 35, 716, DateTimeKind.Local).AddTicks(6825), "abyr44@gmail.com", "(600) 813-2578 x1365" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, ميدان سمیه, 1342, خان يونس, Cambodia", "أعزاز", new DateTime(2024, 1, 11, 9, 37, 21, 132, DateTimeKind.Local).AddTicks(3135), "hsn_iyhab@hotmail.com", "(200) 306-0205" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, ش آذربایجان, 932, البديع, Montserrat", "قرية الجهراء", new DateTime(2024, 1, 11, 12, 5, 39, 36, DateTimeKind.Local).AddTicks(629), "frydh_aashwr44@yahoo.com", "1-665-698-8107" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, تقاطع استاد قریب, 3285, بعبدا, Niue", "دمازين", new DateTime(2024, 1, 11, 16, 14, 57, 279, DateTimeKind.Local).AddTicks(8130), "dana62@yahoo.com", "202-936-7276 x57845" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, 0, إب, Lithuania", "بنت جبيل", new DateTime(2024, 1, 11, 9, 40, 11, 468, DateTimeKind.Local).AddTicks(758), "amjd_hazm58@hotmail.com", "566-320-5635 x6669" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, تقاطع رسالت, 0207, حمص, Somalia", "بو سعادة", new DateTime(2024, 1, 10, 22, 52, 46, 381, DateTimeKind.Local).AddTicks(3145), "fatmh.amjd@hotmail.com", "454-856-1034 x11878" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, دوار واعظی, 7, واو, Papua New Guinea", "السيب", new DateTime(2024, 1, 10, 20, 16, 25, 341, DateTimeKind.Local).AddTicks(8016), "fryd62@yahoo.com", "(346) 806-2624" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, 49, النبطية, Rwanda", "ضرما", new DateTime(2024, 1, 11, 3, 47, 31, 308, DateTimeKind.Local).AddTicks(4531), "abyr.hashm@yahoo.com", "(321) 431-2569 x3314" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, 936, الباب, Chile", "إربد", new DateTime(2024, 1, 11, 6, 16, 20, 226, DateTimeKind.Local).AddTicks(4967), "sayd_asamh@gmail.com", "1-331-748-5025" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, 8, كربلاء, Algeria", "الخرج", new DateTime(2024, 1, 10, 20, 36, 52, 561, DateTimeKind.Local).AddTicks(8099), "jabr22@gmail.com", "(583) 783-8899" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, شارع یادگار امام, 4764, قريات, Cameroon", "العضيلية", new DateTime(2024, 1, 11, 13, 9, 23, 948, DateTimeKind.Local).AddTicks(6313), "aadm14@hotmail.com", "(379) 901-6786 x6025" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, تقاطع اجاره دار, 033, عفك, Nepal", "المرسى", new DateTime(2024, 1, 11, 8, 24, 21, 510, DateTimeKind.Local).AddTicks(1703), "salm.sayd74@hotmail.com", "646-937-8786 x18170" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 47, مسعد, Svalbard & Jan Mayen Islands", "السيب", new DateTime(2024, 1, 11, 1, 59, 39, 78, DateTimeKind.Local).AddTicks(5929), "hsn_hashm@yahoo.com", "(629) 797-2385 x2816" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, 1479, الجديدة, New Zealand", "غارو", new DateTime(2024, 1, 11, 4, 43, 35, 169, DateTimeKind.Local).AddTicks(5511), "hajr28@hotmail.com", "510.398.1564" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, 1, يريم, India", "ودمدني", new DateTime(2024, 1, 11, 7, 54, 20, 794, DateTimeKind.Local).AddTicks(603), "hsn26@yahoo.com", "875-238-2461 x55107" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, ميدان سباری, 3623, جت, Pakistan", "ارمناز", new DateTime(2024, 1, 11, 13, 1, 0, 963, DateTimeKind.Local).AddTicks(4198), "salm60@yahoo.com", "(733) 373-2594 x11402" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, 721, بوكادوم, Benin", "الرس", new DateTime(2024, 1, 11, 0, 53, 11, 431, DateTimeKind.Local).AddTicks(4894), "lma.aqyl@gmail.com", "381-723-2890 x555" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, 757, سيدي سليمان, Dominica", "توريرت", new DateTime(2024, 1, 11, 15, 13, 45, 317, DateTimeKind.Local).AddTicks(8454), "rna.slah54@hotmail.com", "720.286.6353" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, ميدان آذربایجان, 126, عكا, Cote d'Ivoire", "المحلة الكبرى", new DateTime(2024, 1, 11, 8, 10, 48, 198, DateTimeKind.Local).AddTicks(6242), "mna_araqy@yahoo.com", "299-656-3217" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, دوار دیباجی, 2504, تاروت, Ethiopia", "نوى", new DateTime(2024, 1, 10, 20, 34, 37, 623, DateTimeKind.Local).AddTicks(8529), "rym43@gmail.com", "455.804.7015 x57880" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, 3, الدامور, Andorra", "يي", new DateTime(2024, 1, 11, 13, 39, 4, 999, DateTimeKind.Local).AddTicks(9434), "rym83@hotmail.com", "1-729-650-0908 x17553" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, دوار امیرکبیر, 0162, الأتارب, Central African Republic", "عدن", new DateTime(2024, 1, 11, 8, 38, 2, 968, DateTimeKind.Local).AddTicks(7748), "sarh_slah@hotmail.com", "1-564-557-6501" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 5720, الميادين, Maldives", "السويس", new DateTime(2024, 1, 11, 16, 56, 19, 709, DateTimeKind.Local).AddTicks(2885), "farwq_amjd77@yahoo.com", "1-330-227-1088 x4463" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش رسالت, شارع آذربایجان, 084, دير القمر, United Arab Emirates", "العيينة", new DateTime(2024, 1, 11, 13, 41, 11, 938, DateTimeKind.Local).AddTicks(65), "tarq55@gmail.com", "1-375-802-9672 x28243" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, ميدان ابوذر, 9050, قصرين, Western Sahara", "يريم", new DateTime(2024, 1, 10, 19, 34, 20, 224, DateTimeKind.Local).AddTicks(7291), "rym_asamh@yahoo.com", "832.972.7724 x70245" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, 036, سنجة, Congo", "تطوان", new DateTime(2024, 1, 11, 5, 20, 50, 259, DateTimeKind.Local).AddTicks(2689), "fatmh.jabr@yahoo.com", "1-907-367-5814" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, دوار موحد دانش, 5, شمسطار, Hungary", "سيان", new DateTime(2024, 1, 11, 14, 10, 11, 341, DateTimeKind.Local).AddTicks(7378), "mna_aqyl45@hotmail.com", "333-255-0145 x7543" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق راستوان, 8, فيفاء, Israel", "سطيف", new DateTime(2024, 1, 11, 11, 7, 18, 349, DateTimeKind.Local).AddTicks(34), "iyhab_fuad97@gmail.com", "1-627-902-0844 x561" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, 1103, جالكاسيو, Armenia", "الرستن", new DateTime(2024, 1, 11, 0, 4, 6, 449, DateTimeKind.Local).AddTicks(2170), "sarh_hsn74@hotmail.com", "1-704-236-3200 x806" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, 86, العمران, Greenland", "الفيوم", new DateTime(2024, 1, 10, 22, 42, 45, 608, DateTimeKind.Local).AddTicks(2764), "shymaa_aadm@hotmail.com", "(606) 853-0535" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, دوار امیرکبیر, 2517, الجيزة, Botswana", "بابابى", new DateTime(2024, 1, 11, 6, 12, 0, 789, DateTimeKind.Local).AddTicks(802), "fryd.iyhab@yahoo.com", "(662) 655-9219 x3723" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 78, جاردو, Andorra", "الطريف", new DateTime(2024, 1, 11, 13, 15, 38, 148, DateTimeKind.Local).AddTicks(8468), "tarq60@gmail.com", "(515) 484-7210" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, ميدان امیرکبیر, 29, المناقل, Guinea-Bissau", "بيت لاهيا", new DateTime(2024, 1, 11, 9, 38, 19, 547, DateTimeKind.Local).AddTicks(1732), "slah58@hotmail.com", "398-779-3162 x84013" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, 88, الخبر, Austria", "عطبرة", new DateTime(2024, 1, 10, 21, 22, 53, 450, DateTimeKind.Local).AddTicks(7180), "slah27@yahoo.com", "268-246-0196 x164" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, دوار راستوان, 3835, نزوى, Indonesia", "القويعية", new DateTime(2024, 1, 11, 12, 20, 51, 729, DateTimeKind.Local).AddTicks(3773), "jmanh_tarq50@gmail.com", "(383) 661-0031" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 10, الدقم, Sierra Leone", "تونس", new DateTime(2024, 1, 10, 19, 33, 49, 416, DateTimeKind.Local).AddTicks(5016), "rbya.hsn@gmail.com", "375-914-7063" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, ش آفریقا, 458, الرويس, Christmas Island", "المناقل", new DateTime(2024, 1, 11, 15, 7, 35, 622, DateTimeKind.Local).AddTicks(1933), "hazm5@hotmail.com", "549-677-2534 x92518" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 23, المالكية, Vanuatu", "خور أنجار", new DateTime(2024, 1, 11, 9, 1, 23, 525, DateTimeKind.Local).AddTicks(2563), "tarq.aqyl1@hotmail.com", "(228) 905-0028" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, 3, مقديشو, Madagascar", "خان يونس", new DateTime(2024, 1, 10, 19, 3, 21, 622, DateTimeKind.Local).AddTicks(669), "zyd.fuad@yahoo.com", "(577) 492-7393" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, ش آزادی, 89, الوجه, Papua New Guinea", "الجبيل", new DateTime(2024, 1, 11, 12, 40, 58, 267, DateTimeKind.Local).AddTicks(5290), "jmanh.salm@yahoo.com", "(907) 867-1842 x3260" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, 8, مدينة عيسى, Zimbabwe", "حوطة بني تميم", new DateTime(2024, 1, 11, 16, 23, 57, 18, DateTimeKind.Local).AddTicks(5962), "rym_tarq71@yahoo.com", "424.237.4228 x49554" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, تقاطع راستوان, 4, الجنينة, Malta", "يافا", new DateTime(2024, 1, 11, 16, 16, 46, 379, DateTimeKind.Local).AddTicks(2168), "rym.blal@yahoo.com", "(743) 527-5960" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, 35, دمازين, Ecuador", "كربلاء", new DateTime(2024, 1, 11, 6, 28, 11, 158, DateTimeKind.Local).AddTicks(1158), "rqyh_asar94@hotmail.com", "995.996.3982 x387" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, دوار استاد قریب, 25, جاردو, Niger", "بابابى", new DateTime(2024, 1, 11, 13, 1, 16, 248, DateTimeKind.Local).AddTicks(8847), "hajr_azyz@gmail.com", "580-612-3285 x81841" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, 26, أم درمان, Zambia", "عنابة", new DateTime(2024, 1, 11, 7, 1, 28, 930, DateTimeKind.Local).AddTicks(1127), "lma48@gmail.com", "1-868-366-8908" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, 94, بورتسودان, Mauritius", "جبلة", new DateTime(2024, 1, 11, 14, 24, 11, 525, DateTimeKind.Local).AddTicks(8900), "hajr56@yahoo.com", "726-261-1545 x2446" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 298, قليوب, Saint Kitts and Nevis", "الناعورة", new DateTime(2024, 1, 11, 3, 46, 41, 50, DateTimeKind.Local).AddTicks(9687), "fuad.sayd@yahoo.com", "719.462.3058 x575" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 96, الخرج, Tanzania", "دهوك", new DateTime(2024, 1, 11, 7, 54, 11, 447, DateTimeKind.Local).AddTicks(611), "fatmh_tarq@gmail.com", "326-411-7708" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 317, القدموس, Indonesia", "خان شيخون", new DateTime(2024, 1, 11, 8, 47, 16, 165, DateTimeKind.Local).AddTicks(3460), "mna.fuad32@hotmail.com", "(753) 415-4638" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, 9, البيضاء, Tanzania", "بربرة", new DateTime(2024, 1, 10, 17, 57, 42, 594, DateTimeKind.Local).AddTicks(5776), "aayh68@yahoo.com", "561-408-1193" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, دوار آفریقا, 2611, أبو كمال, Dominica", "أطار", new DateTime(2024, 1, 11, 1, 30, 32, 448, DateTimeKind.Local).AddTicks(3146), "fuad.iyhab28@hotmail.com", "(303) 810-8979 x7750" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, شارع دیباجی, 56, جدة, French Southern Territories", "رأس لفان", new DateTime(2024, 1, 11, 12, 35, 39, 417, DateTimeKind.Local).AddTicks(5275), "sayd_fuad@hotmail.com", "810.387.6694 x410" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, دوار فاطمی, 549, فيفاء, Saint Lucia", "القنفذة", new DateTime(2024, 1, 10, 21, 37, 39, 194, DateTimeKind.Local).AddTicks(4068), "blal.fryd@gmail.com", "403.277.2361" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, ميدان قدس, 5002, سكيكدة, Christmas Island", "بريدة", new DateTime(2024, 1, 10, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(5007), "asamh.salm27@gmail.com", "378.390.4090" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 6, الإسماعيلية, Norway", "مرزق", new DateTime(2024, 1, 11, 3, 32, 37, 736, DateTimeKind.Local).AddTicks(7467), "shymaa19@hotmail.com", "573.392.2801" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, 9765, رابغ, Turkey", "زحلة", new DateTime(2024, 1, 10, 23, 1, 16, 296, DateTimeKind.Local).AddTicks(5657), "rbya50@gmail.com", "(541) 433-5611" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, ش اقبال لاهوری, 467, سحار, Western Sahara", "درعا", new DateTime(2024, 1, 11, 5, 6, 42, 32, DateTimeKind.Local).AddTicks(1973), "iynas_salm@yahoo.com", "1-481-816-0487 x201" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, ميدان قدس, 56, الحسيمة, Ethiopia", "الثورة", new DateTime(2024, 1, 11, 12, 15, 17, 322, DateTimeKind.Local).AddTicks(5962), "tarq73@hotmail.com", "1-760-589-7576" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, دوار شهید مطهری, 243, صفاقس, Poland", "نواكشوط", new DateTime(2024, 1, 10, 18, 24, 35, 537, DateTimeKind.Local).AddTicks(3313), "zynb75@yahoo.com", "733.963.2873 x8997" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, 9299, راس العين, Germany", "بيت حانون", new DateTime(2024, 1, 10, 21, 4, 2, 175, DateTimeKind.Local).AddTicks(4764), "blal92@gmail.com", "(829) 328-1712" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 2630, جاردو, Turks and Caicos Islands", "الهفوف", new DateTime(2024, 1, 10, 23, 7, 16, 205, DateTimeKind.Local).AddTicks(3420), "jmanh5@yahoo.com", "(805) 686-9611 x219" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, 818, بسكرة, Luxembourg", "اللاذقية", new DateTime(2024, 1, 10, 20, 5, 10, 579, DateTimeKind.Local).AddTicks(1809), "fatmh58@yahoo.com", "402.834.1658" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, 4080, مدينة الملك عبد الله الاقتصادية, Canada", "عبري", new DateTime(2024, 1, 11, 8, 2, 54, 6, DateTimeKind.Local).AddTicks(5111), "asamh99@hotmail.com", "(764) 806-9228 x1185" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, ميدان دستغیب, 280, ميت غمر, Saudi Arabia", "جلب", new DateTime(2024, 1, 11, 16, 37, 48, 233, DateTimeKind.Local).AddTicks(2321), "amjd_salm@hotmail.com", "1-974-989-7521" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, 59, دمياط, Gibraltar", "الفحيحيل", new DateTime(2024, 1, 11, 1, 46, 7, 351, DateTimeKind.Local).AddTicks(5279), "dana46@gmail.com", "850-320-5626 x3640" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, طريق آذربایجان, 84, الديماس, Aruba", "المنيا", new DateTime(2024, 1, 10, 21, 27, 29, 199, DateTimeKind.Local).AddTicks(7736), "rqyh2@gmail.com", "1-249-892-7649 x85863" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, دوار دکتر چمران, 119, صرمان, Bulgaria", "قلقيلية", new DateTime(2024, 1, 10, 23, 30, 43, 157, DateTimeKind.Local).AddTicks(1357), "fatmh_zyd70@hotmail.com", "1-938-215-1527" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 4, 30, 14, 46, 39, 107, DateTimeKind.Local).AddTicks(775), new DateTime(2024, 1, 11, 14, 38, 40, 859, DateTimeKind.Local).AddTicks(1139), "منى طارق", "Willa Terry", "طارق - معروف", "1023152364523601961", "Ecuador" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 8, 1, 11, 12, 58, 352, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 1, 10, 22, 50, 24, 270, DateTimeKind.Local).AddTicks(7975), "سعيد سعيد", "Griffin Zboncak", "ربيع LLC", "6202631589343463205", "Guatemala", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 7, 2, 0, 40, 3, 655, DateTimeKind.Local).AddTicks(668), new DateTime(2024, 1, 11, 5, 50, 43, 570, DateTimeKind.Local).AddTicks(2100), "سعيد سعيد", "Cheyenne Rath", 0, "جابر‌, إيهاب and فاروق", "504298094251892940", "Colombia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 3, 31, 20, 58, 58, 757, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 1, 10, 23, 30, 3, 15, DateTimeKind.Local).AddTicks(8840), "فاطمة بلال", "Marquis O'Connell", "أسامة - أسامة", "5658708872312747729", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 9, 11, 1, 4, 8, 438, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 1, 11, 0, 35, 7, 624, DateTimeKind.Local).AddTicks(2198), "زينب فريد", "Ken King", "صلاح - عقیل", "3461115212078594893", "Christmas Island" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 2, 6, 5, 38, 8, 633, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 1, 11, 8, 41, 17, 979, DateTimeKind.Local).AddTicks(109), "عبير عصار", "Glen Ankunding", 0, "أمجد, سالم and إيهاب", "3972804928257287786", "Guam", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 4, 13, 19, 30, 3, 609, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 1, 11, 7, 20, 18, 861, DateTimeKind.Local).AddTicks(6673), "سالم عارف", "Nakia VonRueden", "حسن Inc", "5559790658735940056", "Cuba", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1977, 5, 15, 19, 0, 20, 513, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 1, 10, 18, 15, 40, 903, DateTimeKind.Local).AddTicks(7335), "سارة إيهاب", "Pierre Langworth", 0, "إيهاب, عارف and أسامة", "2698118860778496328", "Australia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 5, 30, 15, 24, 46, 969, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 1, 11, 12, 49, 17, 21, DateTimeKind.Local).AddTicks(7967), "ريم عقیل", "Letha Padberg", 0, "سعيد - فؤاد", "1557172414655775001", "Heard Island and McDonald Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 10, 30, 20, 31, 42, 28, DateTimeKind.Local).AddTicks(4209), new DateTime(2024, 1, 11, 0, 27, 23, 952, DateTimeKind.Local).AddTicks(2466), "رنا صلاح", "Carter Carroll", 0, "سعيد LLC", "8958041532578253417", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 9, 30, 16, 53, 31, 525, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 1, 10, 23, 36, 21, 712, DateTimeKind.Local).AddTicks(8160), "آية عراقی", "Jordan Heidenreich", "آدم and Sons", "2178512799291571957", "Angola", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 3, 7, 22, 13, 1, 247, DateTimeKind.Local).AddTicks(2115), new DateTime(2024, 1, 11, 8, 54, 15, 924, DateTimeKind.Local).AddTicks(3683), "سارة عزیز", "Rusty Blick", 0, "إيهاب - حسن", "1073789447846291958", "Saint Helena", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 8, 12, 16, 52, 47, 994, DateTimeKind.Local).AddTicks(7433), new DateTime(2024, 1, 11, 6, 28, 41, 852, DateTimeKind.Local).AddTicks(964), "حازم عراقی", "Perry Murphy", 1, "عصار - عقیل", "4079678716398852496", "Bulgaria", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 12, 3, 13, 54, 31, 344, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 1, 11, 4, 41, 5, 430, DateTimeKind.Local).AddTicks(9724), "زينب طارق", "Stanford McGlynn", "حسن Inc", "5936047401943705630", "Falkland Islands (Malvinas)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 10, 14, 6, 13, 41, 630, DateTimeKind.Local).AddTicks(3441), new DateTime(2024, 1, 10, 18, 29, 18, 611, DateTimeKind.Local).AddTicks(6386), "فريدة إيهاب", "Isabel Brown", "عارف and Sons", "4439430063930739865", "Lao People's Democratic Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 4, 16, 22, 54, 37, 203, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 1, 10, 19, 35, 56, 255, DateTimeKind.Local).AddTicks(3537), "بلال أمجد", "Rick Kshlerin", "طارق - ربيع", "9037525580730105065", "Liechtenstein", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 7, 4, 16, 26, 48, 217, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 1, 11, 12, 3, 20, 594, DateTimeKind.Local).AddTicks(2210), "سالم ربيع", "Linnie Gaylord", "عراقی, فؤاد and عصار", "8819303319151973745", "Bouvet Island (Bouvetoya)", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 1, 7, 22, 3, 26, 69, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 1, 10, 20, 36, 24, 907, DateTimeKind.Local).AddTicks(1262), "بلال عزیز", "Otho Keebler", "عراقی - عقیل", "1660202556699106390", "Taiwan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 11, 6, 18, 47, 28, 224, DateTimeKind.Local).AddTicks(5764), new DateTime(2024, 1, 11, 4, 56, 18, 833, DateTimeKind.Local).AddTicks(6037), "إيناس أسامة", "Mayra Keebler", 1, "سعيد - عقیل", "7494383066788464052", "Pitcairn Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 2, 26, 4, 7, 23, 890, DateTimeKind.Local).AddTicks(6322), new DateTime(2024, 1, 11, 14, 51, 30, 867, DateTimeKind.Local).AddTicks(6407), "صلاح حسن", "Faye Baumbach", 1, "عاشور - عارف", "8713783127467134104", "Turkey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 4, 12, 1, 2, 40, 828, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 1, 10, 18, 41, 43, 992, DateTimeKind.Local).AddTicks(7339), "رنا بلال", "Franz Hammes", "ربيع, حسن and فريد", "1082424359845488462", "New Zealand", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 6, 11, 16, 32, 42, 859, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 1, 11, 10, 26, 59, 298, DateTimeKind.Local).AddTicks(2820), "زيد حسن", "Amelia Wolf", "عراقی, آدم and زيد", "4257085054893891441", "Trinidad and Tobago", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1966, 8, 15, 11, 9, 55, 250, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 1, 10, 21, 16, 13, 930, DateTimeKind.Local).AddTicks(4514), "إيناس جابر‌", "Lorena Mraz", 1, "هاشم - معروف", "1264977098037420285", "Cape Verde" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 6, 26, 19, 47, 5, 915, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 1, 11, 2, 44, 48, 772, DateTimeKind.Local).AddTicks(5684), "ربيع جابر‌", "Britney Rippin", 0, "عاشور - طارق", "6643596023651956558", "Bolivia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 10, 29, 11, 18, 9, 90, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 1, 11, 13, 42, 5, 113, DateTimeKind.Local).AddTicks(1080), "فاروق ربيع", "Arvid Stoltenberg", 0, "هاشم, فاروق and طارق", "673713524781735170", "El Salvador", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 1, 25, 23, 19, 58, 72, DateTimeKind.Local).AddTicks(8229), new DateTime(2024, 1, 11, 11, 0, 39, 314, DateTimeKind.Local).AddTicks(6023), "سعيد هاشم", "Elmo Hackett", 0, "عزیز - بلال", "3482921063878348678", "Belize", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 5, 30, 4, 13, 24, 361, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 1, 11, 5, 29, 17, 994, DateTimeKind.Local).AddTicks(6317), "أمجد حازم", "Jordane Kunde", 1, "أسامة LLC", "111825668264137312", "Tajikistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 8, 21, 8, 53, 20, 881, DateTimeKind.Local).AddTicks(3377), new DateTime(2024, 1, 10, 18, 58, 48, 4, DateTimeKind.Local).AddTicks(186), "سالم أسامة", "Kennedy Lindgren", "جابر‌ Inc", "6689826923613264414", "United Arab Emirates", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 7, 24, 10, 3, 36, 699, DateTimeKind.Local).AddTicks(1607), new DateTime(2024, 1, 11, 10, 9, 43, 586, DateTimeKind.Local).AddTicks(3819), "فاطمة حازم", "Jameson Huel", "صلاح LLC", "6577560414048686534", "Northern Mariana Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 5, 18, 16, 44, 14, 700, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 1, 11, 14, 46, 22, 958, DateTimeKind.Local).AddTicks(1684), "آدم فاروق", "Nellie Ferry", 0, "آدم, طارق and آدم", "160854852002348006", "Romania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 1, 9, 7, 11, 5, 623, DateTimeKind.Local).AddTicks(4824), new DateTime(2024, 1, 11, 3, 21, 51, 942, DateTimeKind.Local).AddTicks(6100), "دانا فاروق", "Kyra Bins", "فاروق, بلال and فؤاد", "4207090932659733408", "Lebanon", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 2, 2, 23, 47, 16, 939, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 1, 11, 15, 18, 37, 502, DateTimeKind.Local).AddTicks(3207), "أروى حسن", "Bell Mitchell", 0, "معروف Group", "1464094774338881786", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 8, 31, 6, 24, 50, 948, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 1, 10, 20, 14, 0, 911, DateTimeKind.Local).AddTicks(1570), "آدم فريد", "Dorthy Armstrong", "سعيد, حازم and فؤاد", "5444697899065807284", "American Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 10, 17, 13, 14, 37, 790, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 1, 11, 10, 4, 33, 192, DateTimeKind.Local).AddTicks(9631), "جابر‌ حسن", "Andreane Kertzmann", 0, "آدم - عصار", "1876287271698893268", "Saint Kitts and Nevis", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 11, 12, 9, 10, 52, 600, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 1, 10, 23, 12, 27, 262, DateTimeKind.Local).AddTicks(7784), "دانا آدم", "Bertha Krajcik", "سعيد, معروف and طارق", "873610022256200997", "Christmas Island", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 5, 2, 16, 23, 28, 389, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 1, 11, 3, 54, 37, 370, DateTimeKind.Local).AddTicks(964), "جابر‌ عراقی", "Elias Kling", "ربيع - حازم", "7985360757762152818", "Honduras", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 22, 6, 0, 27, 134, DateTimeKind.Local).AddTicks(1592), new DateTime(2024, 1, 11, 12, 4, 5, 498, DateTimeKind.Local).AddTicks(6285), "إيهاب صلاح", "Ned Parisian", 0, "زيد - عراقی", "4465636857483821297", "Malawi", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 12, 8, 18, 57, 5, 87, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 1, 10, 22, 51, 55, 633, DateTimeKind.Local).AddTicks(6676), "لمى عراقی", "Mustafa Murazik", "أسامة, أمجد and عزیز", "8698503391536147959", "Portugal", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 2, 2, 12, 7, 3, 95, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 1, 11, 7, 2, 38, 875, DateTimeKind.Local).AddTicks(6711), "رنا هاشم", "Norval Gerhold", 1, "أمجد - صلاح", "1482202039801783701", "Slovenia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 12, 20, 15, 20, 29, 22, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 1, 11, 10, 20, 58, 192, DateTimeKind.Local).AddTicks(8275), "فؤاد عصار", "Bulah Harris", 1, "عاشور, آدم and زيد", "8783087946097752198", "Bosnia and Herzegovina", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 4, 1, 8, 6, 21, 860, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 1, 10, 23, 33, 5, 85, DateTimeKind.Local).AddTicks(8400), "شيماء زيد", "Queen Shanahan", 1, "سعيد - عقیل", "5074970392800715927", "Seychelles", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 22, 6, 22, 26, 357, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 1, 10, 23, 59, 30, 964, DateTimeKind.Local).AddTicks(460), "آية عراقی", "Bernice Walsh", "عراقی - صلاح", "1794080881391700235", "Costa Rica", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 4, 27, 0, 50, 56, 587, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 1, 11, 7, 35, 13, 234, DateTimeKind.Local).AddTicks(289), "أروى فؤاد", "Deshawn Powlowski", 0, "آدم, عاشور and سعيد", "1051389522857518981", "Yemen", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 12, 2, 21, 28, 38, 769, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 1, 11, 4, 27, 51, 910, DateTimeKind.Local).AddTicks(4043), "منى فريد", "Narciso Reynolds", "فاروق, سعيد and آدم", "4316618059466802832", "Papua New Guinea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 2, 14, 58, 36, 733, DateTimeKind.Local).AddTicks(2411), new DateTime(2024, 1, 10, 20, 47, 6, 956, DateTimeKind.Local).AddTicks(7817), "حازم عزیز", "Jordi Koss", "عراقی, عقیل and أمجد", "6414225137339196600", "Marshall Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 6, 19, 4, 58, 10, 647, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 1, 10, 22, 3, 55, 698, DateTimeKind.Local).AddTicks(825), "أروى بلال", "Claudie Torphy", "7202080127734616052", "Norfolk Island" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2004, 1, 4, 14, 48, 47, 472, DateTimeKind.Local).AddTicks(1766), new DateTime(2024, 1, 11, 7, 8, 45, 575, DateTimeKind.Local).AddTicks(9906), "فاروق عارف", "Jalyn Bartell", 1, "صلاح, زيد and عاشور", "6314163697921115701", "Mauritius", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 7, 30, 16, 42, 7, 849, DateTimeKind.Local).AddTicks(9463), new DateTime(2024, 1, 11, 5, 44, 41, 300, DateTimeKind.Local).AddTicks(2766), "سارة عراقی", "Darrel Keeling", "صلاح LLC", "7084510505283952462", "Dominican Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 6, 23, 8, 23, 14, 24, DateTimeKind.Local).AddTicks(6674), new DateTime(2024, 1, 11, 15, 48, 21, 308, DateTimeKind.Local).AddTicks(3956), "إيهاب صلاح", "Jazmyn Walker", 0, "عارف, عزیز and عزیز", "5734437851361964433", "Indonesia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 1, 19, 11, 6, 50, 295, DateTimeKind.Local).AddTicks(5323), new DateTime(2024, 1, 11, 14, 6, 2, 366, DateTimeKind.Local).AddTicks(7053), "جابر‌ أمجد", "Maggie Parker", "عزیز - عاشور", "3411489088778874832", "Central African Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 7, 6, 2, 38, 14, 638, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 1, 11, 14, 16, 58, 226, DateTimeKind.Local).AddTicks(1207), "فاروق هاشم", "Jaquan Lowe", "بلال, أسامة and فريد", "8759803833839991972", "Mauritius", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 9, 14, 20, 52, 28, 822, DateTimeKind.Local).AddTicks(2417), new DateTime(2024, 1, 11, 4, 20, 0, 565, DateTimeKind.Local).AddTicks(1157), "فريدة جابر‌", "Oran Robel", "حسن - زيد", "3530718334915898502", "Panama" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 8, 25, 7, 44, 6, 963, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 1, 11, 15, 7, 22, 746, DateTimeKind.Local).AddTicks(8191), "حسن فريد", "Amaya Barrows", 1, "عزیز - فريد", "4460415086502979906", "Paraguay", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 5, 18, 17, 3, 11, 668, DateTimeKind.Local).AddTicks(5386), new DateTime(2024, 1, 10, 23, 52, 30, 815, DateTimeKind.Local).AddTicks(209), "ربيع إيهاب", "Horacio Luettgen", 1, "أسامة, عارف and آدم", "1507033313836719232", "Sweden", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 2, 28, 5, 44, 36, 136, DateTimeKind.Local).AddTicks(9023), new DateTime(2024, 1, 11, 3, 53, 53, 793, DateTimeKind.Local).AddTicks(3141), "سالم سالم", "Benjamin Beatty", 0, "زيد Inc", "339278395539509061", "Liberia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 3, 6, 17, 43, 11, 664, DateTimeKind.Local).AddTicks(8877), new DateTime(2024, 1, 11, 14, 17, 42, 601, DateTimeKind.Local).AddTicks(8898), "إيهاب صلاح", "Emilia Brown", 0, "أمجد, معروف and سعيد", "6442690991695610582", "El Salvador", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 3, 1, 7, 20, 49, 369, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 1, 11, 9, 2, 42, 437, DateTimeKind.Local).AddTicks(5377), "ريم عاشور", "Braden Nitzsche", "معروف and Sons", "2047598443556643121", "Tonga", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 3, 18, 14, 28, 47, 855, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 1, 10, 19, 20, 56, 548, DateTimeKind.Local).AddTicks(2860), "حسن أمجد", "Mckenna Rippin", 0, "عراقی, زيد and أمجد", "1608236049121661664", "Ukraine", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 19, 3, 29, 57, 660, DateTimeKind.Local).AddTicks(3024), new DateTime(2024, 1, 10, 19, 15, 47, 654, DateTimeKind.Local).AddTicks(5699), "إيناس حازم", "Benny Marks", "زيد, حسن and حسن", "3567524146676475399", "Uzbekistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 8, 1, 18, 56, 27, 576, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 1, 11, 6, 17, 3, 92, DateTimeKind.Local).AddTicks(8371), "بلال فؤاد", "Alfreda Hyatt", 0, "عراقی LLC", "2193501910980201483", "Saint Kitts and Nevis", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 1, 6, 21, 12, 11, 363, DateTimeKind.Local).AddTicks(602), new DateTime(2024, 1, 11, 6, 50, 57, 831, DateTimeKind.Local).AddTicks(4862), "آية ربيع", "Sabina Quitzon", 1, "بلال, عقیل and صلاح", "4764250084936728442", "Mali" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 1, 21, 13, 36, 58, 490, DateTimeKind.Local).AddTicks(3296), new DateTime(2024, 1, 11, 16, 52, 19, 281, DateTimeKind.Local).AddTicks(9899), "سعيد أسامة", "Pearline Reichert", "فريد, عقیل and فريد", "696177763379708125", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 6, 3, 23, 11, 676, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 1, 11, 16, 41, 2, 255, DateTimeKind.Local).AddTicks(7023), "فؤاد حسن", "Johnathon Dooley", 1, "معروف, سعيد and عزیز", "1461809152662539746", "Japan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 2, 25, 10, 1, 54, 486, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 1, 11, 16, 55, 45, 751, DateTimeKind.Local).AddTicks(357), "فاروق فاروق", "Larry Farrell", 0, "عارف Inc", "4338780492238012998", "Gabon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 10, 27, 12, 1, 53, 610, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 1, 11, 6, 52, 56, 679, DateTimeKind.Local).AddTicks(6485), "حسن حسن", "Jennyfer Wiza", 1, "جابر‌, حسن and عارف", "5243148846312049250", "Venezuela", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 9, 23, 21, 34, 24, 656, DateTimeKind.Local).AddTicks(1612), new DateTime(2024, 1, 10, 23, 58, 3, 190, DateTimeKind.Local).AddTicks(464), "فؤاد معروف", "Mellie Kuhic", "معروف - فؤاد", "7783884336724700492", "Italy", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 3, 26, 12, 56, 36, 877, DateTimeKind.Local).AddTicks(6125), new DateTime(2024, 1, 11, 0, 53, 0, 111, DateTimeKind.Local).AddTicks(6929), "رقية عزیز", "Annamarie Beier", "جابر‌, عصار and فريد", "5619712386696311394", "Luxembourg" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 3, 29, 22, 21, 4, 737, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 1, 11, 8, 10, 22, 931, DateTimeKind.Local).AddTicks(7581), "سالم طارق", "Omer Hilpert", 1, "عزیز Group", "3078982265167155982", "Bermuda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 2, 8, 17, 32, 29, 180, DateTimeKind.Local).AddTicks(7434), new DateTime(2024, 1, 11, 12, 46, 59, 160, DateTimeKind.Local).AddTicks(1720), "آدم إيهاب", "Maude Krajcik", "صلاح - فاروق", "4105313978569203476", "Mauritania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 2, 2, 13, 49, 48, 766, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 1, 11, 11, 46, 41, 263, DateTimeKind.Local).AddTicks(4401), "إيهاب جابر‌", "Chloe Collier", "سالم - فؤاد", "4227082203218656573", "Guernsey", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 3, 7, 9, 39, 2, 86, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 1, 10, 21, 14, 35, 307, DateTimeKind.Local).AddTicks(2589), "حسن سعيد", "Trenton Krajcik", 0, "بلال LLC", "6874927273666209114", "Uruguay", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 5, 2, 11, 43, 1, 727, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 1, 11, 6, 48, 55, 212, DateTimeKind.Local).AddTicks(9359), "منى ربيع", "Earnestine Pagac", "حازم LLC", "4949873933825724025", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1967, 6, 11, 9, 48, 16, 169, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 1, 11, 8, 22, 45, 244, DateTimeKind.Local).AddTicks(9493), "صلاح حازم", "Edythe Kerluke", 0, "سالم, عقیل and ربيع", "1902456805129070325", "Fiji" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 2, 14, 11, 52, 48, 305, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 1, 11, 12, 48, 46, 778, DateTimeKind.Local).AddTicks(4849), "آية فاروق", "Zechariah Pfannerstill", "سعيد, أمجد and زيد", "3166061875958225733", "Antigua and Barbuda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 6, 10, 16, 57, 5, 385, DateTimeKind.Local).AddTicks(2790), new DateTime(2024, 1, 11, 2, 21, 37, 854, DateTimeKind.Local).AddTicks(5169), "ريم زيد", "Vaughn Kuhlman", "عاشور Group", "4238080270100199760", "Sri Lanka", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 8, 7, 5, 23, 47, 756, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 1, 11, 11, 56, 54, 862, DateTimeKind.Local).AddTicks(7831), "فؤاد فؤاد", "Ellis Buckridge", 0, "عصار LLC", "4756503262366944028", "Angola", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 12, 6, 7, 8, 0, 365, DateTimeKind.Local).AddTicks(3878), new DateTime(2024, 1, 11, 15, 5, 37, 147, DateTimeKind.Local).AddTicks(9844), "فريدة زيد", "Giuseppe Ankunding", 1, "طارق LLC", "1599404123266257584", "New Zealand", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 10, 17, 23, 34, 21, 413, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 1, 10, 20, 2, 12, 812, DateTimeKind.Local).AddTicks(9486), "هاجر معروف", "Althea Bahringer", 0, "سالم - فؤاد", "4575193729710332251", "Afghanistan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 2, 8, 17, 11, 34, 137, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 1, 11, 4, 33, 32, 364, DateTimeKind.Local).AddTicks(4922), "سعيد بلال", "Paige Kassulke", "فريد - طارق", "5658991481665095339", "Nauru", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 4, 12, 9, 46, 51, 469, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 1, 11, 4, 19, 29, 817, DateTimeKind.Local).AddTicks(672), "حازم أسامة", "Trystan Klein", 0, "بلال, عقیل and سعيد", "8791071481183618045", "Svalbard & Jan Mayen Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 10, 7, 9, 44, 56, 841, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 1, 11, 12, 9, 13, 535, DateTimeKind.Local).AddTicks(5642), "جمانة معروف", "Orland Barton", 0, "عزیز LLC", "535216396162406938", "Micronesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 2, 18, 9, 37, 2, 667, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 1, 11, 7, 35, 53, 707, DateTimeKind.Local).AddTicks(5999), "زيد حسن", "William Kuvalis", 1, "صلاح - صلاح", "3877567007601423644", "Democratic People's Republic of Korea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 11, 3, 0, 0, 36, 641, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 1, 11, 11, 50, 26, 436, DateTimeKind.Local).AddTicks(8702), "شيماء عاشور", "Geoffrey Mills", 1, "جابر‌ - حسن", "3389945060074152519", "British Indian Ocean Territory (Chagos Archipelago)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 10, 8, 17, 20, 41, 140, DateTimeKind.Local).AddTicks(5699), new DateTime(2024, 1, 11, 5, 23, 59, 317, DateTimeKind.Local).AddTicks(8733), "حسن بلال", "Rosa Deckow", "معروف and Sons", "4500959046503426877", "Sweden", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 5, 26, 15, 49, 22, 314, DateTimeKind.Local).AddTicks(3767), new DateTime(2024, 1, 11, 3, 49, 53, 892, DateTimeKind.Local).AddTicks(840), "رنا جابر‌", "Tevin Graham", 1, "عاشور - هاشم", "4163442485294984460", "Georgia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 2, 4, 22, 59, 8, 28, DateTimeKind.Local).AddTicks(2235), new DateTime(2024, 1, 11, 13, 37, 29, 5, DateTimeKind.Local).AddTicks(4962), "فاروق فاروق", "Hayden Hahn", "فريد LLC", "4956187159375215823", "Puerto Rico", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 8, 13, 8, 28, 18, 397, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 1, 11, 0, 27, 57, 683, DateTimeKind.Local).AddTicks(3957), "أسامة بلال", "Lyric Abernathy", "عقیل and Sons", "6245335603197935553", "Mali", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 3, 19, 19, 14, 41, 133, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 1, 11, 9, 59, 7, 42, DateTimeKind.Local).AddTicks(9086), "حسن طارق", "Kiara Nienow", "حازم LLC", "5899078801056221353", "Barbados", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 2, 2, 9, 7, 55, 903, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 1, 11, 4, 52, 47, 692, DateTimeKind.Local).AddTicks(44), "بلال بلال", "Bryana Schuster", "عصار, عقیل and عاشور", "4587711897435624702", "Azerbaijan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 12, 28, 16, 2, 35, 296, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 1, 11, 14, 41, 40, 755, DateTimeKind.Local).AddTicks(5799), "ربيع عاشور", "Retta Leannon", "فؤاد, سالم and طارق", "6928648537498401555", "Russian Federation", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 8, 7, 19, 15, 199, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 1, 11, 7, 56, 55, 904, DateTimeKind.Local).AddTicks(4365), "آية عاشور", "Kasandra Rolfson", "معروف, أمجد and عراقی", "2292168972069013528", "Monaco", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1964, 5, 18, 6, 18, 37, 149, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 1, 11, 12, 12, 30, 486, DateTimeKind.Local).AddTicks(5246), "أمجد عقیل", "Dereck Koepp", 1, "آدم, أسامة and حازم", "6354093539822607376", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 4, 26, 22, 24, 9, 227, DateTimeKind.Local).AddTicks(2693), new DateTime(2024, 1, 11, 5, 4, 30, 292, DateTimeKind.Local).AddTicks(1285), "زيد سعيد", "Peyton Harris", "فريد - عصار", "2345822628700242737", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 2, 9, 22, 14, 53, 680, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 1, 11, 3, 25, 34, 311, DateTimeKind.Local).AddTicks(7335), "زينب صلاح", "Mohammad Schamberger", 1, "فاروق, حسن and عاشور", "6402486817755226062", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 1, 16, 13, 45, 46, 472, DateTimeKind.Local).AddTicks(7855), new DateTime(2024, 1, 10, 22, 9, 41, 102, DateTimeKind.Local).AddTicks(2689), "أمجد زيد", "Larue Mayert", 0, "سعيد LLC", "436014685796422605", "Niger" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 7, 7, 23, 10, 6, 687, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 1, 11, 7, 16, 53, 995, DateTimeKind.Local).AddTicks(4909), "جابر‌ هاشم", "Libby Donnelly", "عاشور LLC", "2433340293260621229", "Iran", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 5, 14, 13, 11, 41, 908, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 1, 11, 5, 18, 51, 5, DateTimeKind.Local).AddTicks(7432), "إيناس عزیز", "Verlie Hilll", "سالم - فريد", "1857754914979114940", "Antigua and Barbuda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 3, 24, 23, 51, 22, 605, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 1, 11, 4, 26, 33, 422, DateTimeKind.Local).AddTicks(2866), "جمانة فؤاد", "Vivien Russel", "زيد, فاروق and فاروق", "6454400961633085267", "Nicaragua", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 7, 12, 14, 19, 53, 309, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 1, 11, 13, 35, 41, 43, DateTimeKind.Local).AddTicks(8136), "ريم حسن", "Effie Schmeler", 1, "حازم LLC", "4594560989860284348", "France", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 5, 10, 22, 59, 17, 306, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 1, 11, 12, 50, 46, 145, DateTimeKind.Local).AddTicks(5406), "آدم بلال", "Timmy Conroy", "زيد - ربيع", "7968735476473444652", "Monaco", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1987, 6, 21, 21, 15, 33, 536, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 1, 10, 17, 40, 36, 803, DateTimeKind.Local).AddTicks(382), "أمجد فؤاد", "Ollie Weber", "صلاح, أسامة and فاروق", "1890153289351722676", "Serbia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 3, 29, 4, 26, 0, 899, DateTimeKind.Local).AddTicks(1764), new DateTime(2024, 1, 11, 2, 25, 12, 338, DateTimeKind.Local).AddTicks(8026), "سالم عصار", "Eleazar Brekke", 1, "عصار, طارق and عاشور", "3604267652289754013", "Liberia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 8, 21, 21, 44, 30, 565, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 1, 11, 7, 50, 37, 328, DateTimeKind.Local).AddTicks(9489), "زينب طارق", "Freeda Brown", "سعيد - زيد", "9189417184505868348", "Oman", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 8, 19, 23, 50, 19, 13, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 1, 11, 2, 56, 54, 676, DateTimeKind.Local).AddTicks(7968), "أروى عقیل", "Rubie Wisozk", 0, "هاشم - جابر‌", "429160115495511903", "Micronesia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 19, 11, 4, 9, 310, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 1, 10, 18, 27, 50, 837, DateTimeKind.Local).AddTicks(8275), "إيناس عراقی", "Norma Parker", 1, "حسن - عارف", "112541162853502167", "Yemen", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 11, 26, 14, 58, 16, 433, DateTimeKind.Local).AddTicks(5754), new DateTime(2024, 1, 10, 19, 14, 59, 207, DateTimeKind.Local).AddTicks(4865), "بلال حازم", "Ward Larson", 0, "عقیل, جابر‌ and هاشم", "8512015241488640789", "Zimbabwe", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 5, 0, 38, 43, 603, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 1, 10, 22, 46, 1, 413, DateTimeKind.Local).AddTicks(4956), "فريد جابر‌", "Dennis Kilback", "حازم - صلاح", "1132506985483453577", "Guadeloupe", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 5, 1, 17, 55, 59, 699, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 1, 11, 2, 33, 57, 970, DateTimeKind.Local).AddTicks(4996), "جابر‌ إيهاب", "Jewel Hartmann", 1, "ربيع, عصار and زيد", "8223365728308557083", "Mauritania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 9, 29, 11, 56, 53, 98, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 1, 11, 13, 21, 25, 297, DateTimeKind.Local).AddTicks(8137), "رقية عزیز", "Carolyne Sawayn", 0, "هاشم - عزیز", "7048923905347651516", "Pitcairn Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 1, 12, 0, 42, 19, 864, DateTimeKind.Local).AddTicks(7364), new DateTime(2024, 1, 11, 14, 3, 6, 805, DateTimeKind.Local).AddTicks(1291), "أسامة زيد", "Modesto Sanford", 0, "حازم - طارق", "64277252979465263", "Poland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 9, 11, 22, 17, 22, 850, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 1, 11, 2, 21, 25, 804, DateTimeKind.Local).AddTicks(1911), "رقية إيهاب", "Barry Schinner", 0, "عراقی - إيهاب", "5070425589086133923", "Latvia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 10, 8, 7, 39, 57, 489, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 1, 10, 18, 0, 45, 278, DateTimeKind.Local).AddTicks(3313), "عبير صلاح", "German Shanahan", "ربيع - صلاح", "2400398938179950144", "Guyana", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 1, 9, 15, 33, 23, 554, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 1, 11, 0, 26, 20, 372, DateTimeKind.Local).AddTicks(5156), "رنا فريد", "Summer Kuhic", "هاشم - سعيد", "6636833342048172898", "Marshall Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 6, 12, 18, 59, 57, 269, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 1, 11, 1, 43, 20, 219, DateTimeKind.Local).AddTicks(9714), "سارة عارف", "Friedrich Weissnat", "آدم, عقیل and عصار", "5917895438693619887", "Bahamas" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 3, 12, 8, 23, 28, 628, DateTimeKind.Local).AddTicks(9731), new DateTime(2024, 1, 11, 1, 54, 12, 347, DateTimeKind.Local).AddTicks(9602), "فريد عصار", "Clement Schmeler", 1, "أسامة - حازم", "4245904448867848757", "Kiribati", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 2, 5, 1, 46, 51, 21, DateTimeKind.Local).AddTicks(9923), new DateTime(2024, 1, 11, 8, 7, 31, 555, DateTimeKind.Local).AddTicks(3152), "إيهاب فؤاد", "Lela Gutkowski", 0, "طارق LLC", "379818218151732841", "Nigeria", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 3, 29, 2, 56, 46, 418, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 1, 11, 6, 41, 47, 620, DateTimeKind.Local).AddTicks(1491), "فريدة صلاح", "Shanny Sanford", 1, "أسامة Inc", "7751225788015720291", "Senegal", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 3, 8, 19, 24, 33, 47, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 1, 11, 15, 12, 55, 715, DateTimeKind.Local).AddTicks(3426), "رقية سالم", "Jonatan Rohan", "عزیز Group", "6650319592280820804", "Kazakhstan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 9, 26, 16, 24, 58, 35, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 1, 11, 11, 20, 27, 325, DateTimeKind.Local).AddTicks(9621), "رنا عارف", "Ernestina Zemlak", "معروف - عاشور", "363535578896499264", "Sao Tome and Principe" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 3, 17, 21, 5, 50, 926, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 1, 10, 22, 31, 27, 286, DateTimeKind.Local).AddTicks(105), "لمى فريد", "Frederique Mayer", 0, "عصار - آدم", "8325141021177226640", "Sudan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 3, 31, 13, 26, 53, 115, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 1, 10, 17, 23, 41, 474, DateTimeKind.Local).AddTicks(2243), "صلاح صلاح", "Raina Prosacco", 1, "ربيع Inc", "2342856650579881617", "Cook Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 2, 28, 19, 54, 17, 905, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 1, 11, 14, 51, 34, 491, DateTimeKind.Local).AddTicks(5911), "بلال طارق", "Theresa Torphy", "فريد Group", "4759052256451842847", "Albania", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 7, 7, 17, 15, 0, 777, DateTimeKind.Local).AddTicks(1432), new DateTime(2024, 1, 10, 19, 18, 23, 628, DateTimeKind.Local).AddTicks(5799), "أمجد فاروق", "Peggie Wisoky", 0, "بلال Group", "6616876860411802370", "Guatemala", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 11, 18, 12, 58, 16, 748, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 1, 11, 7, 0, 51, 191, DateTimeKind.Local).AddTicks(8050), "رقية زيد", "Marcellus Mitchell", 0, "سالم LLC", "2253189270648488075", "Liberia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 5, 8, 1, 33, 26, 998, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 11, 3, 48, 27, 893, DateTimeKind.Local).AddTicks(6689), "أسامة فؤاد", "Nathanial Dare", "أمجد Inc", "4986849876933157696", "Cote d'Ivoire", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 7, 4, 17, 35, 59, 585, DateTimeKind.Local).AddTicks(1449), new DateTime(2024, 1, 11, 7, 35, 58, 441, DateTimeKind.Local).AddTicks(2179), "فاطمة سالم", "Nia Weissnat", 1, "فريد LLC", "254984944572570622", "Iran", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 10, 17, 2, 0, 31, 530, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 1, 11, 6, 23, 32, 412, DateTimeKind.Local).AddTicks(6504), "بلال بلال", "Cornelius Mayer", "معروف, صلاح and فؤاد", "2689588360838796517", "Italy", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1964, 7, 31, 14, 27, 21, 274, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 1, 11, 5, 23, 9, 118, DateTimeKind.Local).AddTicks(5364), "رقية عاشور", "Josh Hermiston", "حسن - عزیز", "5144547444538618213", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 6, 13, 5, 58, 6, 659, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 1, 11, 4, 56, 24, 107, DateTimeKind.Local).AddTicks(1614), "طارق عراقی", "Edwina Grimes", 0, "سالم, أسامة and عراقی", "5138092720165887292", "Jamaica", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 6, 25, 12, 37, 5, 742, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 1, 11, 12, 19, 47, 594, DateTimeKind.Local).AddTicks(9005), "آدم عزیز", "Chance Grant", 1, "صلاح - عصار", "6875272497350839763", "Ecuador", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 11, 19, 15, 8, 37, 162, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 1, 10, 22, 12, 29, 157, DateTimeKind.Local).AddTicks(3802), "بلال هاشم", "Eve Hessel", "بلال Group", "9174746659032822723", "Norfolk Island", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1958, 11, 6, 21, 37, 46, 489, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 1, 11, 10, 6, 33, 592, DateTimeKind.Local).AddTicks(554), "سارة عاشور", "Filomena Langosh", 1, "حازم - هاشم", "8294218593695733802", "American Samoa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 7, 31, 6, 5, 40, 677, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 1, 10, 21, 44, 27, 621, DateTimeKind.Local).AddTicks(6838), "صلاح هاشم", "Everett Grady", 0, "طارق - معروف", "3894304694402298065", "Seychelles", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 5, 19, 16, 2, 20, 425, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 1, 11, 15, 20, 42, 500, DateTimeKind.Local).AddTicks(9402), "جمانة عقیل", "D'angelo Flatley", "عاشور - عاشور", "948865480812845672", "Antigua and Barbuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 2, 13, 6, 51, 54, 562, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 1, 11, 7, 46, 32, 164, DateTimeKind.Local).AddTicks(3770), "فاروق عصار", "Raul Fahey", "سالم - عقیل", "6135819331729315617", "Pakistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1954, 8, 7, 17, 29, 46, 497, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 1, 11, 10, 51, 30, 40, DateTimeKind.Local).AddTicks(4571), "جابر‌ إيهاب", "Katrine Hammes", "هاشم and Sons", "7188396508040680831", "Democratic People's Republic of Korea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 2, 11, 5, 39, 47, 319, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 1, 11, 14, 8, 50, 336, DateTimeKind.Local).AddTicks(6864), "ريم حازم", "Ruth Lehner", "بلال Group", "215004142832228652", "Monaco", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 1, 30, 6, 5, 45, 102, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 1, 10, 23, 3, 46, 228, DateTimeKind.Local).AddTicks(5616), "فؤاد آدم", "Jennings Stehr", "أسامة LLC", "5077142513840817870", "Spain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 6, 22, 14, 44, 41, 286, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 1, 11, 10, 56, 6, 736, DateTimeKind.Local).AddTicks(6527), "زينب طارق", "Fern Franecki", 1, "طارق Inc", "750582937972018429", "Aruba" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 26, 8, 1, 39, 321, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 1, 11, 14, 30, 33, 684, DateTimeKind.Local).AddTicks(8933), "فريد حازم", "Frederik Schmeler", 0, "صلاح, فاروق and حسن", "1500056217726924140", "Malta", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 4, 7, 6, 7, 1, 805, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 1, 10, 19, 49, 8, 147, DateTimeKind.Local).AddTicks(6118), "أمجد عاشور", "Demond Rogahn", "معروف, آدم and فريد", "7786372818970170326", "Spain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 5, 28, 19, 34, 51, 288, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 1, 11, 0, 39, 6, 35, DateTimeKind.Local).AddTicks(3850), "آدم سعيد", "Adell Fisher", "عصار Group", "2933965592018410655", "Aruba", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 6, 13, 13, 3, 14, 791, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 1, 11, 9, 55, 4, 921, DateTimeKind.Local).AddTicks(8431), "بلال حازم", "Federico Parisian", 0, "أمجد, طارق and هاشم", "5998562916088781923", "Brunei Darussalam", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 8, 22, 14, 32, 37, 483, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 1, 11, 15, 20, 12, 573, DateTimeKind.Local).AddTicks(2037), "آية حسن", "Waino Rath", "إيهاب, عارف and صلاح", "1893827764967462382", "Dominica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 6, 24, 20, 4, 29, 262, DateTimeKind.Local).AddTicks(2752), new DateTime(2024, 1, 10, 19, 12, 42, 155, DateTimeKind.Local).AddTicks(1759), "دانا عراقی", "Filiberto Greenfelder", "زيد, جابر‌ and عاشور", "540908909625555820", "Mozambique", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 4, 18, 6, 47, 33, 893, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 1, 10, 18, 54, 15, 107, DateTimeKind.Local).AddTicks(9631), "حازم ربيع", "Karolann McCullough", 1, "جابر‌ LLC", "1340509523646459438", "Antarctica (the territory South of 60 deg S)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 6, 2, 22, 23, 12, 40, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 1, 11, 3, 23, 45, 523, DateTimeKind.Local).AddTicks(734), "رنا عصار", "Marjory Bernier", 0, "إيهاب Group", "4338275193499416968", "Paraguay", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 5, 25, 20, 19, 30, 721, DateTimeKind.Local).AddTicks(3062), new DateTime(2024, 1, 11, 2, 33, 58, 154, DateTimeKind.Local).AddTicks(2284), "آية سالم", "Maximillia Heller", 0, "عاشور Group", "7384170133003296232", "French Polynesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 10, 3, 16, 39, 7, 183, DateTimeKind.Local).AddTicks(3571), new DateTime(2024, 1, 11, 3, 38, 1, 796, DateTimeKind.Local).AddTicks(7165), "رنا طارق", "Brad Nikolaus", "أسامة, طارق and أسامة", "2521080529508627681", "Palestinian Territory", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 8, 26, 4, 9, 55, 754, DateTimeKind.Local).AddTicks(6653), new DateTime(2024, 1, 11, 16, 8, 29, 93, DateTimeKind.Local).AddTicks(7926), "عبير بلال", "Cordie Block", 0, "سعيد LLC", "3926558515240419967", "Seychelles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 6, 6, 18, 32, 33, 92, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 1, 11, 10, 45, 42, 581, DateTimeKind.Local).AddTicks(1098), "شيماء عاشور", "Colton Reinger", 0, "فاروق LLC", "897912734804018071", "Virgin Islands, British", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 8, 27, 22, 38, 46, 405, DateTimeKind.Local).AddTicks(1619), new DateTime(2024, 1, 11, 15, 34, 58, 594, DateTimeKind.Local).AddTicks(6524), "رقية طارق", "Lauren Bergstrom", "هاشم, عراقی and سالم", "8948191814265018090", "Guernsey", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 1, 15, 9, 40, 29, 636, DateTimeKind.Local).AddTicks(8575), new DateTime(2024, 1, 11, 11, 48, 36, 129, DateTimeKind.Local).AddTicks(9379), "منى سالم", "Lilian Huels", 0, "عقیل, عاشور and عقیل", "8331848266003253056", "Papua New Guinea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 2, 17, 18, 35, 22, 399, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 1, 11, 4, 51, 54, 246, DateTimeKind.Local).AddTicks(4063), "أمجد بلال", "Glenna Bogisich", "طارق LLC", "644669181875770356", "Reunion", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 5, 31, 8, 22, 36, 591, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 1, 11, 5, 24, 32, 674, DateTimeKind.Local).AddTicks(3527), "زينب عقیل", "Caesar McGlynn", 1, "معروف, بلال and أمجد", "5379893995752009626", "United States of America", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 7, 30, 10, 7, 12, 974, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 1, 11, 13, 9, 22, 147, DateTimeKind.Local).AddTicks(2683), "فاروق بلال", "Mallie Kshlerin", 0, "عقیل and Sons", "6747239471910332346", "Democratic People's Republic of Korea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 8, 29, 4, 54, 46, 429, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 1, 11, 13, 3, 10, 20, DateTimeKind.Local).AddTicks(8730), "جابر‌ إيهاب", "Eriberto Shanahan", 0, "عاشور - سالم", "226102114674598182", "Aruba" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 5, 28, 16, 47, 44, 577, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 1, 11, 7, 16, 4, 772, DateTimeKind.Local).AddTicks(7118), "صلاح فاروق", "Amelie Rogahn", "سالم - عارف", "3582699605858448193", "Uruguay", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 11, 15, 5, 29, 40, 748, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 1, 11, 11, 14, 25, 445, DateTimeKind.Local).AddTicks(517), "زينب فاروق", "Nick Trantow", 0, "حسن - صلاح", "1484666597210310500", "Guinea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 8, 6, 8, 49, 33, 149, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 1, 11, 9, 25, 38, 511, DateTimeKind.Local).AddTicks(8353), "طارق هاشم", "Karianne Ondricka", 0, "حازم Inc", "5446353848432735899", "Armenia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 9, 7, 0, 40, 6, 474, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 1, 11, 0, 9, 38, 203, DateTimeKind.Local).AddTicks(2292), "زينب حسن", "Blake Sanford", 1, "عارف - حسن", "2571499606207056685", "Germany", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 8, 7, 22, 10, 53, 442, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 1, 11, 10, 40, 11, 234, DateTimeKind.Local).AddTicks(1643), "حسن أمجد", "Eldred Rice", 1, "عاشور, سالم and عاشور", "6702885580357811098", "Spain", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 11, 8, 16, 19, 42, 168, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 1, 11, 10, 22, 45, 117, DateTimeKind.Local).AddTicks(2993), "فاروق فريد", "Maryse Hand", 1, "عقیل, معروف and بلال", "945638807711767033", "Senegal", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 4, 25, 9, 54, 45, 735, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 1, 11, 16, 20, 51, 252, DateTimeKind.Local).AddTicks(4306), "شيماء سالم", "Macey Huels", 1, "هاشم - ربيع", "3810465504841925461", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 5, 10, 21, 35, 27, 472, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 1, 10, 20, 21, 12, 145, DateTimeKind.Local).AddTicks(3641), "زيد عاشور", "Florence Boyle", "هاشم LLC", "1354904377094199289", "Saint Helena", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 10, 23, 9, 9, 849, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 1, 11, 10, 51, 54, 1, DateTimeKind.Local).AddTicks(9388), "حسن آدم", "Pasquale Borer", 1, "عراقی and Sons", "5858587470678475827", "Ukraine", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 23, 17, 57, 21, 120, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 1, 10, 23, 45, 22, 733, DateTimeKind.Local).AddTicks(1125), "سارة حسن", "Sheldon King", 0, "عقیل, عارف and حازم", "3450737805886641864", "Qatar", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 6, 26, 5, 59, 0, 214, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 1, 11, 0, 25, 41, 16, DateTimeKind.Local).AddTicks(9011), "لمى طارق", "Lucienne Braun", "آدم - طارق", "1276996710967908332", "France", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 3, 14, 11, 25, 48, 970, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 1, 11, 0, 11, 45, 416, DateTimeKind.Local).AddTicks(4046), "بلال عزیز", "Coby Altenwerth", "عقیل, إيهاب and عراقی", "2065497496319820883", "Pitcairn Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 7, 19, 5, 24, 31, 445, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 1, 11, 14, 58, 7, 16, DateTimeKind.Local).AddTicks(7535), "سارة زيد", "Kari Borer", "جابر‌ and Sons", "7510747523748410987", "Guatemala", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 3, 12, 16, 25, 30, 83, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 1, 11, 14, 1, 9, 143, DateTimeKind.Local).AddTicks(3148), "إيهاب إيهاب", "Karine Sawayn", 1, "معروف, حازم and أسامة", "2764649633337619199", "Mauritius", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 1, 20, 18, 36, 11, 239, DateTimeKind.Local).AddTicks(9626), new DateTime(2024, 1, 11, 10, 17, 10, 329, DateTimeKind.Local).AddTicks(3276), "ربيع سالم", "Deontae Mertz", "هاشم LLC", "2155561962322673810", "Kenya", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 12, 7, 16, 38, 28, 489, DateTimeKind.Local).AddTicks(8181), new DateTime(2024, 1, 11, 3, 58, 21, 486, DateTimeKind.Local).AddTicks(6745), "أروى صلاح", "Emmanuel Krajcik", "آدم Group", "286105041651238949", "Grenada", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 15, 16, 57, 2, 703, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 1, 11, 6, 16, 33, 739, DateTimeKind.Local).AddTicks(2926), "زينب أسامة", "Luther Wiza", "حازم, ربيع and سالم", "4955587024140623587", "Moldova", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 2, 18, 5, 34, 27, 860, DateTimeKind.Local).AddTicks(4407), new DateTime(2024, 1, 11, 13, 13, 0, 439, DateTimeKind.Local).AddTicks(3208), "فاطمة حازم", "Keyshawn Bernier", "بلال - أسامة", "641685786233153485", "Gabon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 4, 9, 18, 42, 34, 228, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 1, 11, 3, 24, 14, 93, DateTimeKind.Local).AddTicks(8792), "منى عراقی", "Jarret King", 1, "هاشم - صلاح", "1635244520451450945", "Croatia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 9, 26, 10, 3, 8, 747, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 1, 11, 11, 25, 46, 826, DateTimeKind.Local).AddTicks(2053), "سالم فاروق", "Geovanni Funk", 1, "معروف, معروف and عراقی", "1857075258851807325", "Antarctica (the territory South of 60 deg S)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 6, 3, 49, 35, 75, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 1, 11, 10, 13, 47, 651, DateTimeKind.Local).AddTicks(8369), "ريم فريد", "Albina Bins", "جابر‌, زيد and بلال", "5010902830773515972", "Pakistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2002, 4, 2, 6, 21, 21, 664, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 1, 10, 21, 15, 8, 30, DateTimeKind.Local).AddTicks(3185), "ربيع عارف", "Jamison Reichert", "سالم - إيهاب", "4815694505614188130", "Tunisia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 12, 4, 20, 38, 18, 630, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 1, 11, 12, 52, 1, 863, DateTimeKind.Local).AddTicks(8405), "فاطمة زيد", "Gerda Sipes", 1, "هاشم Inc", "1186504506696327483", "United States of America", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 24, 10, 19, 6, 66, DateTimeKind.Local).AddTicks(5850), new DateTime(2024, 1, 10, 22, 5, 48, 572, DateTimeKind.Local).AddTicks(8291), "لمى عارف", "Ian Conroy", "أمجد Group", "3346896048210856313", "Kiribati", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 2, 16, 16, 21, 10, 661, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 1, 10, 17, 40, 27, 151, DateTimeKind.Local).AddTicks(8681), "جمانة أمجد", "Novella Torphy", "عاشور Group", "2635145651883166585", "Norway", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 25, 4, 38, 2, 925, DateTimeKind.Local).AddTicks(1768), new DateTime(2024, 1, 11, 6, 36, 54, 385, DateTimeKind.Local).AddTicks(303), "سارة عقیل", "Hettie Gislason", "عاشور, عزیز and عارف", "4598996230845280891", "Saint Helena", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 11, 3, 23, 47, 45, 974, DateTimeKind.Local).AddTicks(1612), new DateTime(2024, 1, 11, 4, 36, 48, 961, DateTimeKind.Local).AddTicks(3422), "منى حازم", "Devante Purdy", "جابر‌ - فؤاد", "6811898671190314670", "Bhutan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 5, 15, 14, 43, 23, 808, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 1, 11, 4, 49, 52, 23, DateTimeKind.Local).AddTicks(7550), "هاجر سالم", "Ralph Dooley", "عصار, زيد and فريد", "8485051089050723717", "Equatorial Guinea", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 2, 23, 9, 58, 52, 985, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 1, 10, 19, 16, 9, 665, DateTimeKind.Local).AddTicks(9954), "رقية إيهاب", "Lillian Block", "فاروق and Sons", "5213354799024580011", "Lesotho", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 8, 7, 16, 39, 9, 774, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 1, 10, 21, 58, 44, 374, DateTimeKind.Local).AddTicks(702), "إيناس معروف", "Adela Grant", 1, "عاشور, عقیل and فريد", "121663917291654927", "Martinique", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 5, 30, 10, 25, 51, 322, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 1, 11, 15, 24, 35, 770, DateTimeKind.Local).AddTicks(5204), "أمجد أسامة", "Emerson Lowe", "حازم LLC", "6354487356899547156", "Macedonia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 3, 21, 2, 34, 46, 979, DateTimeKind.Local).AddTicks(4296), new DateTime(2024, 1, 11, 2, 11, 3, 896, DateTimeKind.Local).AddTicks(5000), "صلاح عارف", "Wilson Mohr", 0, "عقیل - إيهاب", "5567094453960391953", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 21, 5, 44, 10, 351, DateTimeKind.Local).AddTicks(941), new DateTime(2024, 1, 11, 10, 10, 59, 262, DateTimeKind.Local).AddTicks(9081), "زينب جابر‌", "Crystel Swift", "إيهاب Inc", "7549957583141063949", "India", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 1, 23, 11, 38, 11, 160, DateTimeKind.Local).AddTicks(8258), new DateTime(2024, 1, 11, 14, 5, 26, 610, DateTimeKind.Local).AddTicks(5775), "شيماء فاروق", "Genesis McGlynn", "زيد, سالم and هاشم", "2062608056857540259", "Falkland Islands (Malvinas)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1988, 2, 4, 5, 54, 17, 202, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 1, 11, 9, 59, 6, 696, DateTimeKind.Local).AddTicks(8573), "فؤاد فؤاد", "Brock Goodwin", 1, "سعيد and Sons", "5282000135434930224", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 11, 14, 9, 44, 58, 664, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 1, 11, 15, 20, 26, 933, DateTimeKind.Local).AddTicks(7852), "شيماء آدم", "Sydney Hyatt", "زيد - هاشم", "5577678896647176394", "Saudi Arabia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 5, 31, 8, 2, 49, 743, DateTimeKind.Local).AddTicks(1767), new DateTime(2024, 1, 11, 11, 47, 47, 727, DateTimeKind.Local).AddTicks(9673), "فاروق فؤاد", "Charlotte Feeney", "معروف - إيهاب", "465561003502046175", "Saint Barthelemy", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 3, 13, 14, 2, 50, 537, DateTimeKind.Local).AddTicks(2693), new DateTime(2024, 1, 10, 22, 16, 3, 283, DateTimeKind.Local).AddTicks(141), "سارة إيهاب", "Keyon Feeney", 0, "سعيد - أسامة", "1251402488629665412", "Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 5, 19, 22, 45, 47, 111, DateTimeKind.Local).AddTicks(5578), new DateTime(2024, 1, 11, 4, 3, 54, 233, DateTimeKind.Local).AddTicks(5392), "حازم آدم", "Nella Robel", "إيهاب, آدم and زيد", "5523009019985632930", "Isle of Man", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 10, 28, 13, 40, 21, 201, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 1, 10, 22, 46, 22, 824, DateTimeKind.Local).AddTicks(9603), "رقية أمجد", "Myra Bins", "ربيع, عراقی and آدم", "8337672171947339717", "Uganda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 3, 21, 11, 59, 3, 197, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 1, 10, 20, 24, 11, 53, DateTimeKind.Local).AddTicks(8129), "رقية إيهاب", "Julia Runolfsdottir", 1, "سعيد - أمجد", "2896541910013906576", "Dominica" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 7, 8, 8, 27, 35, 771, DateTimeKind.Local).AddTicks(7380), new DateTime(2024, 1, 11, 8, 6, 12, 496, DateTimeKind.Local).AddTicks(2930), "حازم زيد", "Everette Fay", 1, "طارق Inc", "2848930605887857933", "Guatemala", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1972, 2, 1, 11, 14, 18, 31, DateTimeKind.Local).AddTicks(6936), new DateTime(2024, 1, 11, 10, 14, 54, 246, DateTimeKind.Local).AddTicks(3694), "سارة عراقی", "Obie Strosin", 1, "أمجد Inc", "3888679941834426288", "Sweden" });
        }
    }
}
