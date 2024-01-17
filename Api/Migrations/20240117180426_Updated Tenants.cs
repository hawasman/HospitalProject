using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTenants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "TreatmentsHistory");

            migrationBuilder.RenameColumn(
                name: "CompanyCode",
                table: "Tenants",
                newName: "TID");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tenants",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<string>(
                name: "ConnectionString",
                table: "Tenants",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
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
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, 025, نوى, Turkmenistan", "أريحا", new DateTime(2024, 1, 17, 0, 30, 2, 106, DateTimeKind.Local).AddTicks(2438), "arwa.blal74@gmail.com", "727.490.0608 x45035" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, ميدان دماوند, 5, حلبا, Eritrea", "الطريف", new DateTime(2024, 1, 17, 0, 54, 25, 562, DateTimeKind.Local).AddTicks(5566), "iynas_fryd2@gmail.com", "(455) 874-2510" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, 7, انواديبو, Burundi", "عجلون", new DateTime(2024, 1, 17, 3, 52, 37, 372, DateTimeKind.Local).AddTicks(9339), "iynas_fuad@yahoo.com", "558-472-1415 x4387" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, تقاطع مالک اشتر, 0618, زليطن, Cameroon", "جرابلس", new DateTime(2024, 1, 17, 5, 49, 30, 229, DateTimeKind.Local).AddTicks(8378), "slah_asamh98@yahoo.com", "1-304-974-8673 x414" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آذربایجان, 61, الرس, Burkina Faso", "مكة المكرمة", new DateTime(2024, 1, 17, 14, 43, 55, 276, DateTimeKind.Local).AddTicks(5135), "tarq.jabr@gmail.com", "523.971.8923" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, ش سباری, 249, المالكية, Macedonia", "ودمدني", new DateTime(2024, 1, 16, 21, 39, 37, 112, DateTimeKind.Local).AddTicks(3022), "fuad_jabr@hotmail.com", "1-322-812-2548" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, تقاطع رسالت, 259, تزنيت, Mongolia", "السلط", new DateTime(2024, 1, 17, 4, 23, 48, 596, DateTimeKind.Local).AddTicks(7688), "blal60@yahoo.com", "587-784-9569" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, ش اجاره دار, 3, طرطوس, Oman", "وزان", new DateTime(2024, 1, 16, 23, 41, 4, 772, DateTimeKind.Local).AddTicks(8908), "arwa_fryd@gmail.com", "1-446-814-9916" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, 238, بدبد, Democratic People's Republic of Korea", "مسقط", new DateTime(2024, 1, 17, 2, 19, 31, 912, DateTimeKind.Local).AddTicks(9542), "abyr57@hotmail.com", "(385) 773-7154" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, 5, سيدي قاسم, Kyrgyz Republic", "المقدادية", new DateTime(2024, 1, 17, 12, 41, 14, 722, DateTimeKind.Local).AddTicks(7406), "jmanh_amjd@hotmail.com", "720.881.8908 x2703" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 34, العرائش, Virgin Islands, British", "الإسكندرية", new DateTime(2024, 1, 17, 7, 19, 41, 875, DateTimeKind.Local).AddTicks(169), "slah.zyd84@yahoo.com", "1-989-398-0952 x462" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, تقاطع راستوان, 520, يوبوكي, Canada", "ورقلة", new DateTime(2024, 1, 17, 18, 57, 18, 156, DateTimeKind.Local).AddTicks(151), "sarh75@gmail.com", "1-866-438-2457 x21900" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, 2, وجدة, Brazil", "دخيل", new DateTime(2024, 1, 17, 13, 38, 46, 739, DateTimeKind.Local).AddTicks(8208), "sayd.tarq@hotmail.com", "305.308.4053 x49512" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, تقاطع سمیه, 0, الخليل, British Indian Ocean Territory (Chagos Archipelago)", "العيون", new DateTime(2024, 1, 17, 13, 31, 0, 422, DateTimeKind.Local).AddTicks(8474), "rbya_hashm@yahoo.com", "685-502-8968 x73546" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, تقاطع مالک اشتر, 3241, جدة, Ireland", "الديوانية", new DateTime(2024, 1, 17, 14, 40, 9, 902, DateTimeKind.Local).AddTicks(2790), "rna56@gmail.com", "575.866.2333 x36672" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 6981, خور أنجار, Algeria", "صوران", new DateTime(2024, 1, 17, 11, 22, 50, 749, DateTimeKind.Local).AddTicks(408), "farwq_aadm@gmail.com", "(535) 282-0943" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, طريق موحد دانش, 2478, القويسمة, Faroe Islands", "بدر حنين", new DateTime(2024, 1, 17, 0, 26, 50, 56, DateTimeKind.Local).AddTicks(5080), "rym30@yahoo.com", "910-534-3260" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, ش فاطمی, 1924, دخيل, Congo", "العزيزية", new DateTime(2024, 1, 17, 12, 9, 7, 713, DateTimeKind.Local).AddTicks(7646), "aadm_salm46@hotmail.com", "1-337-742-8441 x057" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, 3530, غرداية, Ethiopia", "سبها", new DateTime(2024, 1, 17, 14, 42, 10, 380, DateTimeKind.Local).AddTicks(9429), "iynas_hazm@hotmail.com", "644-295-2744 x75700" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, طريق امیرکبیر, 4415, القامشلي, Malta", "تل كيف", new DateTime(2024, 1, 17, 16, 48, 56, 320, DateTimeKind.Local).AddTicks(7289), "zyd.sayd52@gmail.com", "(606) 921-5102" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, ميدان آزادی, 7214, تبوك, Vietnam", "سلفيت", new DateTime(2024, 1, 17, 13, 32, 0, 77, DateTimeKind.Local).AddTicks(556), "aayh.salm92@yahoo.com", "571-761-2408 x053" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, ش رسالت, 4023, حلبجة, Nepal", "جنين", new DateTime(2024, 1, 17, 13, 26, 21, 121, DateTimeKind.Local).AddTicks(6468), "salm.hazm@gmail.com", "251.923.5909 x3880" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, دوار سباری, 72, كوستي, Iran", "جوبا", new DateTime(2024, 1, 17, 0, 38, 43, 164, DateTimeKind.Local).AddTicks(2766), "lma.salm@gmail.com", "1-530-539-3900" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان فاطمی, 4, بيت لاهيا, Jordan", "شرورة", new DateTime(2024, 1, 17, 18, 20, 53, 700, DateTimeKind.Local).AddTicks(7531), "sayd.asar@gmail.com", "566.204.3615" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, 62, دير القمر, Niger", "الظهران", new DateTime(2024, 1, 17, 15, 12, 28, 404, DateTimeKind.Local).AddTicks(3270), "fatmh58@hotmail.com", "1-833-350-7186 x8613" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, 7077, أم درمان, Isle of Man", "اليوسفية", new DateTime(2024, 1, 17, 18, 14, 42, 747, DateTimeKind.Local).AddTicks(8146), "amjd79@hotmail.com", "864-505-0783" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, 9690, إدلب, Iraq", "برديرا", new DateTime(2024, 1, 17, 9, 40, 41, 938, DateTimeKind.Local).AddTicks(8348), "sayd21@gmail.com", "(277) 910-3627" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, طريق استاد قریب, 73, رداع, Iceland", "البريمي", new DateTime(2024, 1, 17, 7, 45, 21, 191, DateTimeKind.Local).AddTicks(4122), "fryd70@gmail.com", "(948) 208-3976" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, ميدان راستوان, 65, أبو ظبي, Togo", "واو", new DateTime(2024, 1, 17, 12, 20, 22, 592, DateTimeKind.Local).AddTicks(7610), "sarh54@gmail.com", "336.615.0522 x964" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, 1, تاروت, Belarus", "يامبيو", new DateTime(2024, 1, 16, 21, 24, 16, 824, DateTimeKind.Local).AddTicks(6051), "shymaa.rbya96@yahoo.com", "1-387-504-1663 x4548" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, دوار اقبال لاهوری, 6077, نوى, Morocco", "مدينة الملك عبد الله الاقتصادية", new DateTime(2024, 1, 17, 1, 37, 10, 488, DateTimeKind.Local).AddTicks(2749), "tarq96@hotmail.com", "(549) 973-9093 x225" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, 71, سيدي سليمان, Sudan", "توريرت", new DateTime(2024, 1, 16, 20, 43, 13, 596, DateTimeKind.Local).AddTicks(8366), "fatmh.asamh77@gmail.com", "1-873-343-6393 x55818" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 2951, جت, Oman", "الكاظمية", new DateTime(2024, 1, 16, 23, 35, 41, 214, DateTimeKind.Local).AddTicks(4694), "arwa_aarf@hotmail.com", "1-986-579-0938 x65851" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 54, الرويس, Ethiopia", "أبو ظبي", new DateTime(2024, 1, 17, 18, 58, 43, 63, DateTimeKind.Local).AddTicks(4427), "slah_sayd26@gmail.com", "1-491-985-9273" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, دوار فاطمی, 063, حلفا الجديدة, Hungary", "سيدي بلعباس", new DateTime(2024, 1, 16, 23, 12, 46, 852, DateTimeKind.Local).AddTicks(7925), "iynas.marwf@yahoo.com", "1-803-510-3773 x589" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار موحد دانش, 71, ريسوت, Italy", "دير القمر", new DateTime(2024, 1, 17, 9, 23, 13, 864, DateTimeKind.Local).AddTicks(5051), "sayd_salm8@hotmail.com", "830.417.6657" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, طريق سمیه, 0, أم درمان, Guinea", "البليدة", new DateTime(2024, 1, 17, 19, 34, 42, 715, DateTimeKind.Local).AddTicks(4529), "iyhab.aarf34@gmail.com", "301.549.5815 x3404" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, ميدان ابوذر, 73, ثول, Mali", "خريبة السوق", new DateTime(2024, 1, 17, 0, 6, 19, 683, DateTimeKind.Local).AddTicks(7641), "hsn_aqyl@yahoo.com", "836.652.5004" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 3, قسنطينة, Montenegro", "الأزرق", new DateTime(2024, 1, 17, 9, 40, 41, 37, DateTimeKind.Local).AddTicks(7987), "fuad_tarq@hotmail.com", "467.271.3981 x011" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, 2845, نوى, Djibouti", "شناص", new DateTime(2024, 1, 17, 5, 15, 59, 887, DateTimeKind.Local).AddTicks(3800), "frydh_hashm@hotmail.com", "(749) 706-2273 x1417" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, ميدان فاطمی, 6, ضبا, Dominica", "سنار", new DateTime(2024, 1, 17, 18, 56, 7, 157, DateTimeKind.Local).AddTicks(7803), "zynb9@yahoo.com", "705.714.0143 x622" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, 5223, مقديشو, Mexico", "ميت غمر", new DateTime(2024, 1, 17, 16, 28, 53, 501, DateTimeKind.Local).AddTicks(1276), "iynas37@hotmail.com", "1-893-298-6836 x142" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, دوار یادگار امام, 17, دهبان, Cuba", "مدينة حمد", new DateTime(2024, 1, 17, 0, 12, 25, 295, DateTimeKind.Local).AddTicks(7627), "lma_jabr47@yahoo.com", "1-551-938-3450 x2134" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, شارع سباری, 98, بنغازي, Niue", "الخليل", new DateTime(2024, 1, 17, 0, 37, 41, 657, DateTimeKind.Local).AddTicks(6052), "asamh_amjd34@yahoo.com", "417-485-3630 x46449" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, ميدان موحد دانش, 862, التل, Bosnia and Herzegovina", "المقدادية", new DateTime(2024, 1, 16, 21, 26, 4, 434, DateTimeKind.Local).AddTicks(4446), "frydh94@hotmail.com", "287-840-0695 x8348" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, شارع یادگار امام, 4, مدنين, Palestinian Territory", "مسيعيد", new DateTime(2024, 1, 17, 14, 41, 39, 12, DateTimeKind.Local).AddTicks(5566), "mna59@yahoo.com", "(866) 628-2672" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, 6896, الحديدة, Bouvet Island (Bouvetoya)", "بور سعيد", new DateTime(2024, 1, 17, 4, 55, 6, 960, DateTimeKind.Local).AddTicks(3051), "lma45@yahoo.com", "628-261-0721" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, طريق اجاره دار, 140, يريم, Kenya", "نوى", new DateTime(2024, 1, 17, 14, 45, 29, 908, DateTimeKind.Local).AddTicks(5076), "slah.hazm@gmail.com", "(664) 433-5625 x842" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, طريق دیباجی, 8, أبو كمال, Djibouti", "مال", new DateTime(2024, 1, 17, 12, 19, 45, 67, DateTimeKind.Local).AddTicks(7025), "sayd.aashwr25@hotmail.com", "299-770-3394 x83132" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 1788, خور فكان, Monaco", "نابلس", new DateTime(2024, 1, 17, 9, 52, 42, 674, DateTimeKind.Local).AddTicks(1593), "zynb.marwf70@hotmail.com", "(512) 252-9657 x3001" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, ميدان سمیه, 57, البريمي, Vanuatu", "بريدة‏", new DateTime(2024, 1, 17, 16, 47, 36, 182, DateTimeKind.Local).AddTicks(2573), "dana3@gmail.com", "(460) 778-7910" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آذربایجان, شارع هویزه, 7436, بريدة‏, Cyprus", "سمائل", new DateTime(2024, 1, 17, 17, 27, 41, 156, DateTimeKind.Local).AddTicks(2659), "fatmh_aadm89@gmail.com", "385.267.2575" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, ميدان ابوذر, 59, الحسكة, Turkmenistan", "دمازين", new DateTime(2024, 1, 16, 20, 51, 5, 929, DateTimeKind.Local).AddTicks(9090), "rna91@gmail.com", "272.463.4394" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, ميدان موحد دانش, 0, أسيلا, Romania", "بريدة", new DateTime(2024, 1, 17, 8, 25, 49, 888, DateTimeKind.Local).AddTicks(9168), "aadm.blal@hotmail.com", "1-867-570-7451" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, ش استاد قریب, 67, جازان, Portugal", "تدمر", new DateTime(2024, 1, 17, 19, 42, 19, 333, DateTimeKind.Local).AddTicks(9653), "frydh.hazm91@gmail.com", "835-656-5756" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, 0, دمازين, Andorra", "الناصرية", new DateTime(2024, 1, 17, 16, 30, 26, 145, DateTimeKind.Local).AddTicks(5414), "tarq.blal@gmail.com", "1-703-941-0247 x967" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 840, بوكى, Mongolia", "التل", new DateTime(2024, 1, 16, 22, 51, 42, 623, DateTimeKind.Local).AddTicks(4428), "iyhab_araqy88@gmail.com", "450.938.7973 x2392" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, شارع شهید مطهری, 41, رأس لفان, Cape Verde", "باقة الغربية", new DateTime(2024, 1, 16, 22, 37, 55, 436, DateTimeKind.Local).AddTicks(7003), "jabr.tarq2@hotmail.com", "(334) 281-2302 x861" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, ش استاد قریب, 3, بليث وين, Guam", "الوادي", new DateTime(2024, 1, 17, 0, 28, 45, 896, DateTimeKind.Local).AddTicks(4102), "hajr_aashwr@hotmail.com", "(613) 405-5540 x32865" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, ش راستوان, 8, ترهونة, Latvia", "وادي الدواسر", new DateTime(2024, 1, 17, 4, 14, 22, 250, DateTimeKind.Local).AddTicks(619), "hajr.rbya@gmail.com", "(444) 286-4969" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, ميدان دکتر چمران, 34, تنبدغة, Bolivia", "مادبا", new DateTime(2024, 1, 17, 8, 16, 27, 508, DateTimeKind.Local).AddTicks(3001), "rym_jabr59@gmail.com", "(952) 325-4426 x9103" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, 586, صفرو, Ireland", "وهران", new DateTime(2024, 1, 16, 23, 23, 20, 703, DateTimeKind.Local).AddTicks(6890), "asamh.jabr@yahoo.com", "601.249.3597 x44947" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, ميدان سمیه, 84, باقة الغربية, Senegal", "بوكى", new DateTime(2024, 1, 17, 9, 13, 41, 883, DateTimeKind.Local).AddTicks(1388), "fuad_fryd@gmail.com", "295.559.7393" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, دوار یادگار امام, 37, رداع, Western Sahara", "خصب", new DateTime(2024, 1, 16, 23, 31, 0, 368, DateTimeKind.Local).AddTicks(5175), "jabr.iyhab@hotmail.com", "545.534.2362" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, دوار راستوان, 48, نالوت, Fiji", "أغادير", new DateTime(2024, 1, 17, 3, 41, 0, 638, DateTimeKind.Local).AddTicks(9399), "sayd_hazm44@gmail.com", "747.442.0334" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, 9, القاهرة, Grenada", "الخروب", new DateTime(2024, 1, 17, 11, 50, 12, 117, DateTimeKind.Local).AddTicks(8846), "zynb80@hotmail.com", "1-533-472-9014 x35798" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, 23, عشرة رمضان, South Africa", "الشارقة", new DateTime(2024, 1, 17, 12, 39, 26, 442, DateTimeKind.Local).AddTicks(7040), "zyd.hashm17@hotmail.com", "568-692-1790" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, طريق ابوذر, 7730, الحجرة, Gabon", "الناصرة", new DateTime(2024, 1, 17, 1, 22, 11, 367, DateTimeKind.Local).AddTicks(4923), "aayh73@hotmail.com", "997-518-3466 x604" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, طريق دستغیب, 4096, كسلا, Nigeria", "الفيوم", new DateTime(2024, 1, 17, 0, 2, 24, 337, DateTimeKind.Local).AddTicks(8429), "aayh_farwq19@gmail.com", "(847) 306-7110" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 986, مدحاء, Ethiopia", "بلد", new DateTime(2024, 1, 17, 4, 15, 3, 745, DateTimeKind.Local).AddTicks(6776), "fatmh54@yahoo.com", "1-833-665-9905" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, طريق کارگر شمالی, 1, الناصرية, Belize", "بنجرير", new DateTime(2024, 1, 17, 2, 59, 56, 650, DateTimeKind.Local).AddTicks(9813), "farwq30@yahoo.com", "1-256-342-2018" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, طريق قدس, 55, خور أنجار, Saudi Arabia", "جازان", new DateTime(2024, 1, 16, 23, 50, 33, 951, DateTimeKind.Local).AddTicks(4947), "zynb.jabr@gmail.com", "1-468-251-9495" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, 73, صفاقس, Northern Mariana Islands", "المقدادية", new DateTime(2024, 1, 17, 3, 45, 38, 760, DateTimeKind.Local).AddTicks(1586), "salm.aarf1@yahoo.com", "1-336-503-8841 x69667" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 209, سيهات, Romania", "إدفو", new DateTime(2024, 1, 17, 9, 54, 34, 328, DateTimeKind.Local).AddTicks(8786), "sayd_sayd@hotmail.com", "499-370-4824 x13121" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, ش قدس, 103, القصر الكبير, Kiribati", "دمياط", new DateTime(2024, 1, 17, 2, 12, 14, 949, DateTimeKind.Local).AddTicks(5875), "shymaa.tarq@gmail.com", "1-729-766-5486 x5547" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, 1, عشرة رمضان, Canada", "الدوادمي", new DateTime(2024, 1, 16, 22, 15, 47, 491, DateTimeKind.Local).AddTicks(5369), "sarh.asar@hotmail.com", "1-419-649-2896 x21917" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, ميدان ابوذر, 30, جباليا, Guyana", "الرميلة", new DateTime(2024, 1, 17, 2, 33, 21, 933, DateTimeKind.Local).AddTicks(9394), "lma_sayd72@hotmail.com", "634-382-4234 x2259" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, طريق شهید مطهری, 9, عدن, Democratic People's Republic of Korea", "الأقصر", new DateTime(2024, 1, 17, 15, 49, 53, 491, DateTimeKind.Local).AddTicks(8080), "jabr41@hotmail.com", "506.877.7009" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, ش استاد قریب, 206, عطبرة, Peru", "القدس", new DateTime(2024, 1, 16, 21, 21, 0, 270, DateTimeKind.Local).AddTicks(829), "salm.hashm@hotmail.com", "(769) 279-8239" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, شارع استاد قریب, 623, المرج, Lebanon", "ارمناز", new DateTime(2024, 1, 17, 0, 20, 18, 338, DateTimeKind.Local).AddTicks(2146), "sarh29@hotmail.com", "830-431-2331" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, طريق آذربایجان, 3079, بلجرشي, Guernsey", "خور أنجار", new DateTime(2024, 1, 16, 20, 34, 21, 556, DateTimeKind.Local).AddTicks(3936), "aadm.iyhab@yahoo.com", "(292) 204-1662" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, 1998, زوارة, Samoa", "صلنفة", new DateTime(2024, 1, 16, 23, 53, 44, 519, DateTimeKind.Local).AddTicks(9485), "iyhab.farwq@gmail.com", "842.540.3727 x416" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, 117, دمازين, Malaysia", "إدفو", new DateTime(2024, 1, 17, 4, 28, 55, 9, DateTimeKind.Local).AddTicks(3214), "aayh.asamh@yahoo.com", "653-858-7078 x93401" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 5, بو سعادة, Wallis and Futuna", "صفرو", new DateTime(2024, 1, 16, 22, 21, 40, 181, DateTimeKind.Local).AddTicks(4135), "salm.azyz19@hotmail.com", "(484) 621-2920 x99804" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, دوار ابوذر, 8236, حارم, Benin", "المالكية", new DateTime(2024, 1, 17, 14, 22, 5, 174, DateTimeKind.Local).AddTicks(810), "hajr25@yahoo.com", "1-837-471-9924" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, شارع استاد قریب, 2829, كيهيدي, Antarctica (the territory South of 60 deg S)", "بورو", new DateTime(2024, 1, 16, 21, 32, 58, 636, DateTimeKind.Local).AddTicks(5960), "slah_salm24@hotmail.com", "1-664-279-9584 x6958" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, 30, المحمدية, Ethiopia", "عمران", new DateTime(2024, 1, 17, 15, 38, 9, 291, DateTimeKind.Local).AddTicks(8606), "asamh.hazm66@hotmail.com", "310.755.0388 x153" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, شارع دستغیب, 5, الحلة, Liechtenstein", "جيجل", new DateTime(2024, 1, 17, 3, 14, 39, 982, DateTimeKind.Local).AddTicks(9706), "asamh_salm@hotmail.com", "(748) 426-7610" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 2, بالهو, South Africa", "ريان", new DateTime(2024, 1, 17, 10, 42, 21, 759, DateTimeKind.Local).AddTicks(1958), "zynb.aadm9@hotmail.com", "1-647-794-3044" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, دوار استاد قریب, 9761, قريات, Turkey", "هرجيسة", new DateTime(2024, 1, 16, 21, 46, 54, 71, DateTimeKind.Local).AddTicks(8449), "blal29@gmail.com", "700-661-7797 x69392" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, طريق دکتر چمران, 6370, غرداية, American Samoa", "عفرين", new DateTime(2024, 1, 17, 1, 55, 3, 913, DateTimeKind.Local).AddTicks(8647), "slah_zyd@hotmail.com", "837-486-7536 x6366" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, طريق دستغیب, 4, مستغانم, Denmark", "طوباس", new DateTime(2024, 1, 17, 0, 23, 30, 468, DateTimeKind.Local).AddTicks(3405), "iyhab.rbya42@yahoo.com", "(571) 835-3282 x254" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, طريق امیرکبیر, 3, آلاك, Northern Mariana Islands", "بانياس", new DateTime(2024, 1, 16, 20, 19, 6, 910, DateTimeKind.Local).AddTicks(7234), "salm.hazm@hotmail.com", "(705) 240-3405" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, 91, القيروان, Norfolk Island", "الخبر", new DateTime(2024, 1, 17, 19, 39, 28, 402, DateTimeKind.Local).AddTicks(2972), "fryd87@hotmail.com", "(807) 531-9076" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, دوار دماوند, 7963, الميادين, Malta", "زاخو", new DateTime(2024, 1, 17, 14, 19, 39, 230, DateTimeKind.Local).AddTicks(7642), "jmanh43@hotmail.com", "1-685-826-5847 x37587" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, 8, طيبة الامام, Honduras", "الرميلة", new DateTime(2024, 1, 17, 2, 23, 32, 674, DateTimeKind.Local).AddTicks(2932), "shymaa17@hotmail.com", "355-241-6345 x521" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, 0, الشلف, United States of America", "برج بو عريريج", new DateTime(2024, 1, 17, 16, 58, 13, 529, DateTimeKind.Local).AddTicks(5784), "mna96@yahoo.com", "868.637.3984 x78850" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, 4998, كلميم, Bahamas", "غزة", new DateTime(2024, 1, 17, 18, 43, 19, 963, DateTimeKind.Local).AddTicks(6886), "abyr.zyd@gmail.com", "367.959.2905 x184" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, 3, القريات, Falkland Islands (Malvinas)", "هرجيسة", new DateTime(2024, 1, 17, 12, 24, 1, 272, DateTimeKind.Local).AddTicks(8179), "farwq.rbya@yahoo.com", "1-432-336-9090" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 8, بنزرت, Croatia", "كفر قاسم", new DateTime(2024, 1, 17, 0, 40, 23, 73, DateTimeKind.Local).AddTicks(2608), "rna12@gmail.com", "240.833.7632" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع قدس, شارع دستغیب, 5, المالكية, Cameroon", "خصب", new DateTime(2024, 1, 17, 12, 59, 16, 824, DateTimeKind.Local).AddTicks(608), "rbya.blal@gmail.com", "753-965-3851 x537" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, 5, الزيمة, Sweden", "جبلة", new DateTime(2024, 1, 17, 13, 19, 36, 720, DateTimeKind.Local).AddTicks(4637), "tarq_salm65@hotmail.com", "(977) 502-8753 x94327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, 4, البديع, Greenland", "أم رواب", new DateTime(2024, 1, 17, 11, 9, 33, 758, DateTimeKind.Local).AddTicks(767), "iynas.zyd@yahoo.com", "569-509-9166" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, 187, غرداية, Saint Martin", "صحم", new DateTime(2024, 1, 17, 7, 26, 53, 697, DateTimeKind.Local).AddTicks(8352), "fuad.blal@yahoo.com", "811.320.1739 x2633" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار موحد دانش, 1, النماص, Albania", "سوق أهراس", new DateTime(2024, 1, 16, 20, 26, 35, 648, DateTimeKind.Local).AddTicks(7265), "rna52@hotmail.com", "1-543-776-1931" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, تقاطع قدس, 0871, بانياس, Uganda", "أبو ظبي", new DateTime(2024, 1, 16, 22, 12, 6, 720, DateTimeKind.Local).AddTicks(6832), "zyd38@gmail.com", "733-922-5320 x2172" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, 06, المرج, Bhutan", "الناعورة", new DateTime(2024, 1, 17, 4, 27, 58, 381, DateTimeKind.Local).AddTicks(7115), "lma48@yahoo.com", "789.918.3150 x769" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 1, خور أنجار, British Indian Ocean Territory (Chagos Archipelago)", "بجاية", new DateTime(2024, 1, 17, 18, 11, 38, 339, DateTimeKind.Local).AddTicks(363), "rqyh77@yahoo.com", "331-454-6595 x80257" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, طريق فاطمی, 31, الفنيدق, Kyrgyz Republic", "سيان", new DateTime(2024, 1, 17, 18, 31, 29, 908, DateTimeKind.Local).AddTicks(7335), "slah_asamh@hotmail.com", "257-398-5203" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, ميدان شهید مطهری, 31, كيفة, Anguilla", "أم درمان", new DateTime(2024, 1, 17, 7, 50, 28, 209, DateTimeKind.Local).AddTicks(6979), "rqyh.zyd46@gmail.com", "794.789.4672" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, 503, غارو, French Guiana", "الفنيدق", new DateTime(2024, 1, 17, 8, 53, 59, 46, DateTimeKind.Local).AddTicks(1840), "iyhab10@yahoo.com", "928.508.4099" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, تقاطع شهید مطهری, 26, إجدابيا, Aruba", "سنجة", new DateTime(2024, 1, 17, 14, 11, 25, 186, DateTimeKind.Local).AddTicks(1110), "dana53@hotmail.com", "(509) 330-3796" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 7, كفر قاسم, Tajikistan", "حلبا", new DateTime(2024, 1, 17, 15, 5, 25, 84, DateTimeKind.Local).AddTicks(8580), "abyr17@gmail.com", "(638) 741-1828 x500" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, 2747, بركان, Mauritius", "جرجا", new DateTime(2024, 1, 17, 18, 35, 43, 532, DateTimeKind.Local).AddTicks(6245), "asamh.salm84@yahoo.com", "882.933.4425 x51866" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 70, أم قصر, Andorra", "صفرو", new DateTime(2024, 1, 17, 10, 18, 51, 451, DateTimeKind.Local).AddTicks(1603), "sayd19@yahoo.com", "452.511.9748 x00701" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 24, حمص, Thailand", "شبين الكوم", new DateTime(2024, 1, 17, 5, 14, 18, 153, DateTimeKind.Local).AddTicks(2490), "rqyh.fuad@hotmail.com", "474-278-8146 x38820" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, ميدان مالک اشتر, 2, يافا, Gabon", "الجزائر", new DateTime(2024, 1, 17, 2, 23, 5, 972, DateTimeKind.Local).AddTicks(6906), "iynas32@hotmail.com", "564-800-3954 x08156" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, ش قدس, 39, قسنطينة, Czech Republic", "بور سعيد", new DateTime(2024, 1, 17, 13, 28, 56, 909, DateTimeKind.Local).AddTicks(9728), "iynas_farwq@hotmail.com", "1-419-839-5660 x9733" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, 3, البتراء, Burkina Faso", "عالي", new DateTime(2024, 1, 17, 9, 47, 23, 336, DateTimeKind.Local).AddTicks(8300), "fuad_iyhab@hotmail.com", "425-742-7373 x2321" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, 95, سنار, Sudan", "نابلس", new DateTime(2024, 1, 16, 21, 5, 21, 577, DateTimeKind.Local).AddTicks(6778), "blal_sayd99@hotmail.com", "1-618-340-2089 x784" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, 4, أم قصر, Nigeria", "أعزاز", new DateTime(2024, 1, 17, 3, 31, 54, 109, DateTimeKind.Local).AddTicks(5033), "fatmh2@yahoo.com", "1-502-690-3352" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, 8263, الحريق, Comoros", "رأس الخيمة", new DateTime(2024, 1, 17, 16, 27, 58, 454, DateTimeKind.Local).AddTicks(1390), "amjd.asar63@hotmail.com", "1-649-596-1646" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, ش سباری, 85, الشارقة, Afghanistan", "شرورة", new DateTime(2024, 1, 17, 14, 16, 9, 270, DateTimeKind.Local).AddTicks(840), "hsn_asamh@yahoo.com", "1-777-520-0132 x5698" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, ش دماوند, 282, الخليل, Netherlands Antilles", "الجفر", new DateTime(2024, 1, 17, 18, 44, 50, 164, DateTimeKind.Local).AddTicks(2854), "tarq84@yahoo.com", "1-245-947-3341 x8800" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, 9862, جلافي, Kazakhstan", "دهبان", new DateTime(2024, 1, 17, 19, 37, 52, 630, DateTimeKind.Local).AddTicks(5757), "rqyh_farwq83@yahoo.com", "(321) 410-9570 x4859" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, 5409, أسيوط, Falkland Islands (Malvinas)", "مدينة الحرير", new DateTime(2024, 1, 17, 15, 17, 55, 675, DateTimeKind.Local).AddTicks(4610), "zynb38@yahoo.com", "804-598-6780 x04834" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 042, عطبرة, Switzerland", "بني ملال", new DateTime(2024, 1, 17, 5, 5, 15, 624, DateTimeKind.Local).AddTicks(7900), "hajr41@yahoo.com", "479-667-0998 x8579" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, دوار استاد قریب, 835, حقل, Tonga", "تقورت", new DateTime(2024, 1, 17, 14, 46, 53, 573, DateTimeKind.Local).AddTicks(8035), "blal.blal17@yahoo.com", "318.747.4646" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, تقاطع سمیه, 475, عرعر, Papua New Guinea", "منبج", new DateTime(2024, 1, 17, 13, 7, 51, 783, DateTimeKind.Local).AddTicks(1156), "rbya.aadm@gmail.com", "858-433-0387 x5685" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, 395, الرستاق, Dominican Republic", "بعلبك", new DateTime(2024, 1, 17, 19, 9, 37, 802, DateTimeKind.Local).AddTicks(7487), "abyr_farwq22@hotmail.com", "422.754.7738 x833" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, تقاطع مالک اشتر, 3, بنها, Holy See (Vatican City State)", "جيجل", new DateTime(2024, 1, 17, 1, 57, 23, 297, DateTimeKind.Local).AddTicks(5343), "jmanh_tarq74@yahoo.com", "1-586-418-2758 x03613" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, شارع سمیه, 37, العمران, Anguilla", "بوكى", new DateTime(2024, 1, 17, 7, 35, 54, 80, DateTimeKind.Local).AddTicks(667), "mna_rbya38@hotmail.com", "(924) 527-9275 x76109" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, تقاطع رسالت, 5903, سحاب, India", "بو سعادة", new DateTime(2024, 1, 17, 5, 27, 24, 781, DateTimeKind.Local).AddTicks(2691), "zynb_rbya@hotmail.com", "(822) 540-0268 x459" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 4024, بربرة, Oman", "القامشلي", new DateTime(2024, 1, 17, 8, 18, 15, 929, DateTimeKind.Local).AddTicks(4693), "jmanh_blal@yahoo.com", "551-599-9067 x4720" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, 5, الراشيدية, Armenia", "الظهران", new DateTime(2024, 1, 17, 11, 37, 15, 318, DateTimeKind.Local).AddTicks(4377), "fryd45@hotmail.com", "(818) 490-4108" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, 151, بربرة, Sweden", "قنا", new DateTime(2024, 1, 17, 5, 38, 36, 601, DateTimeKind.Local).AddTicks(1054), "salm_hazm49@yahoo.com", "(490) 799-6304 x522" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, 0, صور, Tanzania", "بوكادوم", new DateTime(2024, 1, 17, 12, 22, 31, 246, DateTimeKind.Local).AddTicks(1324), "salm_aadm@gmail.com", "(299) 862-7462 x65374" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 173, السيب, Haiti", "نواكشوط", new DateTime(2024, 1, 17, 1, 50, 19, 314, DateTimeKind.Local).AddTicks(4999), "iynas47@hotmail.com", "1-318-776-5499" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آذربایجان, طريق آفریقا, 0, الرستن, Angola", "يريم", new DateTime(2024, 1, 17, 2, 57, 48, 284, DateTimeKind.Local).AddTicks(9668), "hsn7@yahoo.com", "334.332.2348" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, ميدان اجاره دار, 769, الظهران, Holy See (Vatican City State)", "قرية سار", new DateTime(2024, 1, 17, 18, 22, 11, 926, DateTimeKind.Local).AddTicks(9388), "dana_sayd68@hotmail.com", "484-425-5406 x61618" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, 8, جرسيف, Israel", "حقل", new DateTime(2024, 1, 17, 5, 27, 27, 38, DateTimeKind.Local).AddTicks(8847), "hajr_azyz8@yahoo.com", "1-412-901-2260 x566" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, 34, القويسمة, Ireland", "مدحاء", new DateTime(2024, 1, 17, 17, 54, 56, 963, DateTimeKind.Local).AddTicks(6773), "rbya92@hotmail.com", "(935) 773-0415" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, تقاطع ابوذر, 1, يبرود, Cambodia", "بنها", new DateTime(2024, 1, 17, 2, 57, 26, 546, DateTimeKind.Local).AddTicks(5622), "mna_zyd@yahoo.com", "784.542.8632" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع ابوذر, 2, مدينة الصدر, Paraguay", "الطائف", new DateTime(2024, 1, 16, 20, 50, 41, 586, DateTimeKind.Local).AddTicks(9411), "aadm_aqyl@hotmail.com", "490-353-2308" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, 4, جلاجل, Myanmar", "بيروت", new DateTime(2024, 1, 17, 4, 39, 36, 428, DateTimeKind.Local).AddTicks(2403), "lma.azyz14@yahoo.com", "1-341-702-8143 x33991" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, ش استاد قریب, 99, جيبوتي, Latvia", "دبا", new DateTime(2024, 1, 17, 5, 50, 18, 249, DateTimeKind.Local).AddTicks(8540), "slah_hashm@gmail.com", "418.921.9515" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, 91, البتراء, Venezuela", "أبو كبير", new DateTime(2024, 1, 17, 12, 1, 36, 846, DateTimeKind.Local).AddTicks(3507), "jmanh_aqyl@hotmail.com", "1-412-701-8544 x596" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دکتر چمران, 90, طيبة الامام, Congo", "القنفذة", new DateTime(2024, 1, 16, 22, 15, 14, 860, DateTimeKind.Local).AddTicks(4228), "mna.tarq@yahoo.com", "1-658-602-6626 x19758" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 6831, الزرقاء, Saint Lucia", "الثورة", new DateTime(2024, 1, 17, 19, 5, 41, 255, DateTimeKind.Local).AddTicks(5198), "jmanh_hashm12@yahoo.com", "(887) 621-5503 x12837" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, تقاطع سباری, 883, بنجرير, Oman", "جلافي", new DateTime(2024, 1, 17, 3, 35, 13, 202, DateTimeKind.Local).AddTicks(6744), "arwa.hashm57@hotmail.com", "(258) 918-8279" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, طريق حقانی, 11, تجكجة, Niger", "المرسى", new DateTime(2024, 1, 17, 14, 51, 34, 496, DateTimeKind.Local).AddTicks(9254), "sarh89@gmail.com", "1-298-865-0611 x97498" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, تقاطع استاد قریب, 283, شرورة, Jersey", "راس العين", new DateTime(2024, 1, 17, 0, 21, 31, 39, DateTimeKind.Local).AddTicks(9995), "iyhab_blal@yahoo.com", "1-731-667-2254 x92653" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, تقاطع آذربایجان, 7526, عشرة رمضان, Cambodia", "سكاكا", new DateTime(2024, 1, 17, 13, 3, 50, 873, DateTimeKind.Local).AddTicks(3933), "hazm95@gmail.com", "1-339-794-4888" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, ش استاد قریب, 5, اكجوجت, Saint Barthelemy", "الباب", new DateTime(2024, 1, 17, 0, 10, 15, 491, DateTimeKind.Local).AddTicks(8425), "arwa27@gmail.com", "355.601.4944" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, تقاطع موحد دانش, 0, تل كيف, Venezuela", "الرملة", new DateTime(2024, 1, 17, 19, 43, 48, 656, DateTimeKind.Local).AddTicks(994), "rbya_aadm16@yahoo.com", "477.583.1521 x804" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, تقاطع راستوان, 4492, الزرقاء, Tanzania", "إزكي", new DateTime(2024, 1, 17, 11, 3, 58, 923, DateTimeKind.Local).AddTicks(6946), "jabr60@hotmail.com", "322.741.8579 x674" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 300, القطيفة, Serbia", "الجفر", new DateTime(2024, 1, 17, 5, 36, 46, 175, DateTimeKind.Local).AddTicks(1219), "lma95@yahoo.com", "731.288.7930" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, 282, عنيزة, Equatorial Guinea", "الناصرة", new DateTime(2024, 1, 17, 14, 15, 2, 483, DateTimeKind.Local).AddTicks(2323), "jabr_sayd@gmail.com", "(339) 629-6354" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, طريق آذربایجان, 3, رفحا, Guinea-Bissau", "روصو", new DateTime(2024, 1, 17, 9, 31, 10, 114, DateTimeKind.Local).AddTicks(4198), "fatmh33@gmail.com", "208.618.3501 x56907" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, دوار امیرکبیر, 1923, داريا, Papua New Guinea", "بوكى", new DateTime(2024, 1, 17, 3, 14, 56, 760, DateTimeKind.Local).AddTicks(3686), "frydh.amjd@gmail.com", "777.767.7622" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, طريق واعظی, 5, ثقبة, Malawi", "النبك", new DateTime(2024, 1, 17, 3, 19, 55, 932, DateTimeKind.Local).AddTicks(7243), "zynb_fryd@hotmail.com", "1-936-953-6399 x3152" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, دوار دماوند, 633, الفيوم, Indonesia", "تلكلخ", new DateTime(2024, 1, 17, 15, 40, 32, 69, DateTimeKind.Local).AddTicks(5441), "sayd59@yahoo.com", "901-524-5252 x6853" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, طريق یادگار امام, 7, بوكى, Saint Kitts and Nevis", "يوبوكي", new DateTime(2024, 1, 17, 9, 8, 57, 973, DateTimeKind.Local).AddTicks(1290), "shymaa.salm@gmail.com", "1-697-208-8253 x751" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, 694, ثادق, Cyprus", "المدينة المنورة", new DateTime(2024, 1, 17, 0, 18, 53, 23, DateTimeKind.Local).AddTicks(5074), "jmanh.blal@yahoo.com", "(411) 773-5337" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 38, القضارف, Bhutan", "إب", new DateTime(2024, 1, 17, 8, 13, 34, 6, DateTimeKind.Local).AddTicks(7613), "zynb_asar9@gmail.com", "(621) 868-6812 x894" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق رسالت, ميدان آفریقا, 6377, ضرما, Jersey", "طنطا", new DateTime(2024, 1, 17, 4, 39, 35, 584, DateTimeKind.Local).AddTicks(8646), "amjd.asar@gmail.com", "349.358.3484 x3991" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, 326, سوسه, French Guiana", "حديثة", new DateTime(2024, 1, 17, 8, 23, 48, 294, DateTimeKind.Local).AddTicks(4804), "frydh.slah46@hotmail.com", "837.498.1572 x941" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 0, خريبكة, Democratic People's Republic of Korea", "إزكي", new DateTime(2024, 1, 17, 10, 51, 59, 615, DateTimeKind.Local).AddTicks(5422), "hajr.fuad@yahoo.com", "413.818.1213" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 884, عمان, Hong Kong", "بو سعادة", new DateTime(2024, 1, 17, 1, 29, 21, 603, DateTimeKind.Local).AddTicks(7985), "zyd_slah72@yahoo.com", "1-495-798-2926" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, ش شهید مطهری, 4818, القنفذة, Syrian Arab Republic", "الزرقاء", new DateTime(2024, 1, 17, 9, 4, 56, 14, DateTimeKind.Local).AddTicks(3506), "sarh60@gmail.com", "931.434.9295" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, 722, الباحة, Dominica", "زلفي", new DateTime(2024, 1, 17, 11, 20, 49, 314, DateTimeKind.Local).AddTicks(9547), "iynas_salm@gmail.com", "746-759-5826" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, 255, المزاحمية, Senegal", "كفرنجة", new DateTime(2024, 1, 17, 1, 58, 18, 225, DateTimeKind.Local).AddTicks(1582), "hazm_sayd18@hotmail.com", "515.436.2785 x345" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, تقاطع استاد قریب, 31, الموصل, Rwanda", "دير الزور", new DateTime(2024, 1, 16, 21, 50, 55, 517, DateTimeKind.Local).AddTicks(3566), "hazm_blal61@yahoo.com", "(643) 557-5761" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار موحد دانش, دوار راستوان, 0, الشارقة, Turks and Caicos Islands", "الكوت", new DateTime(2024, 1, 17, 12, 43, 1, 81, DateTimeKind.Local).AddTicks(3124), "abyr7@hotmail.com", "1-622-679-5159 x4516" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 257, شلالة العذاورة, Martinique", "صير بني ياس", new DateTime(2024, 1, 17, 4, 36, 6, 253, DateTimeKind.Local).AddTicks(9951), "rym.iyhab@yahoo.com", "(288) 989-8553 x556" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, 5, الأقصر, Sudan", "النبك", new DateTime(2024, 1, 17, 10, 29, 37, 699, DateTimeKind.Local).AddTicks(2922), "sayd_amjd34@hotmail.com", "450-221-0455" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, تقاطع دکتر چمران, 015, دومة الجندل, Venezuela", "الخرج", new DateTime(2024, 1, 17, 6, 1, 39, 949, DateTimeKind.Local).AddTicks(1693), "jabr_asamh96@hotmail.com", "1-970-379-3743 x983" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, ش دماوند, 026, سلمية, South Georgia and the South Sandwich Islands", "القاهرة", new DateTime(2024, 1, 17, 15, 58, 55, 434, DateTimeKind.Local).AddTicks(1113), "rna.asar@gmail.com", "1-886-491-8374" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, دوار اقبال لاهوری, 937, الدار البيضاء, Senegal", "العيون", new DateTime(2024, 1, 17, 16, 22, 8, 932, DateTimeKind.Local).AddTicks(5683), "arwa.araqy@yahoo.com", "578-422-3330 x764" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, ميدان یادگار امام, 41, السقيلبية, Tanzania", "رأس لفان", new DateTime(2024, 1, 17, 15, 14, 33, 957, DateTimeKind.Local).AddTicks(4809), "salm10@yahoo.com", "1-634-624-5323" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع استاد قریب, ميدان رسالت, 46, طبرق, Tuvalu", "قصرين", new DateTime(2024, 1, 17, 19, 5, 32, 956, DateTimeKind.Local).AddTicks(1268), "jabr_araqy91@yahoo.com", "485.301.3069 x4839" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, 28, حلبا, Bulgaria", "عدن", new DateTime(2024, 1, 17, 13, 42, 14, 554, DateTimeKind.Local).AddTicks(2754), "mna.zyd34@hotmail.com", "643.825.9741 x32424" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, شارع موحد دانش, 04, طرطوس, Spain", "الكوت", new DateTime(2024, 1, 16, 23, 4, 35, 927, DateTimeKind.Local).AddTicks(2062), "frydh.hazm11@hotmail.com", "789-896-0261" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سباری, 71, القضيمة, Djibouti", "سامراء", new DateTime(2024, 1, 17, 18, 35, 38, 506, DateTimeKind.Local).AddTicks(4436), "asamh_jabr@yahoo.com", "(205) 411-1368 x0595" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, تقاطع آذربایجان, 05, إزكي, Saint Martin", "طرابلس", new DateTime(2024, 1, 17, 16, 54, 35, 987, DateTimeKind.Local).AddTicks(3322), "rym39@gmail.com", "808-914-5738 x001" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, 912, المحمدية, Uganda", "نجران", new DateTime(2024, 1, 17, 4, 3, 10, 687, DateTimeKind.Local).AddTicks(6827), "dana.aashwr63@yahoo.com", "(973) 816-5669 x710" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اقبال لاهوری, 64, أسيلا, Burkina Faso", "الطينطان", new DateTime(2024, 1, 17, 16, 3, 46, 120, DateTimeKind.Local).AddTicks(5846), "amjd84@hotmail.com", "706-837-9245 x6769" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, طريق استاد قریب, 499, شقراء, Central African Republic", "سيدي قاسم", new DateTime(2024, 1, 17, 15, 50, 39, 842, DateTimeKind.Local).AddTicks(8558), "asamh_salm0@yahoo.com", "1-702-950-1283" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, 750, تزنيت, Lao People's Democratic Republic", "ودمدني", new DateTime(2024, 1, 17, 17, 59, 49, 712, DateTimeKind.Local).AddTicks(2227), "zyd55@gmail.com", "698.955.4923 x56785" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, 0, خفجي, Jamaica", "صير بني ياس", new DateTime(2024, 1, 17, 16, 8, 3, 42, DateTimeKind.Local).AddTicks(9852), "hajr.amjd39@gmail.com", "(911) 241-3980" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, تقاطع دستغیب, 80, جنين, Mauritius", "يريم", new DateTime(2024, 1, 17, 6, 4, 46, 728, DateTimeKind.Local).AddTicks(6859), "hsn_fuad@yahoo.com", "570-305-6934 x56333" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, ميدان رسالت, 003, سعيدة, Puerto Rico", "صير بني ياس", new DateTime(2024, 1, 17, 10, 31, 40, 333, DateTimeKind.Local).AddTicks(952), "amjd15@yahoo.com", "1-948-355-0356" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 696, بنغازي, Palestinian Territory", "مسيعيد", new DateTime(2024, 1, 16, 23, 21, 6, 836, DateTimeKind.Local).AddTicks(3656), "shymaa_aashwr70@hotmail.com", "1-520-361-5164" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, 983, روصو, Luxembourg", "العلا", new DateTime(2024, 1, 17, 5, 14, 29, 230, DateTimeKind.Local).AddTicks(980), "asamh93@yahoo.com", "701.765.4322" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, 6602, سيدي قاسم, Uruguay", "تيفلت", new DateTime(2024, 1, 17, 8, 36, 30, 951, DateTimeKind.Local).AddTicks(7368), "arwa.aadm@yahoo.com", "417.632.5687" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, دوار اجاره دار, 1878, فرسان, Guam", "برج بو عريريج", new DateTime(2024, 1, 17, 14, 51, 11, 846, DateTimeKind.Local).AddTicks(7248), "rqyh.marwf@hotmail.com", "390-867-8731 x8060" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش رسالت, ميدان استاد قریب, 6, بيت لحم, Eritrea", "دهبان", new DateTime(2024, 1, 17, 8, 39, 56, 246, DateTimeKind.Local).AddTicks(9284), "amjd_jabr@hotmail.com", "(610) 446-9224" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, تقاطع موحد دانش, 2, عالي, Ethiopia", "الهفوف", new DateTime(2024, 1, 17, 5, 4, 54, 164, DateTimeKind.Local).AddTicks(1278), "frydh79@gmail.com", "893-982-2361" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, ميدان آزادی, 3, تقورت, Kyrgyz Republic", "جاردو", new DateTime(2024, 1, 17, 1, 32, 38, 727, DateTimeKind.Local).AddTicks(1779), "frydh27@hotmail.com", "445.658.4649 x2205" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, 68, القريات, Malaysia", "الباحة", new DateTime(2024, 1, 17, 0, 23, 5, 664, DateTimeKind.Local).AddTicks(4333), "fatmh.marwf11@yahoo.com", "(583) 887-4841" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 10, 25, 19, 55, 24, 812, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 1, 17, 0, 56, 9, 857, DateTimeKind.Local).AddTicks(7008), "أمجد فاروق", "Emanuel Russel", 0, "سالم Group", "2401005135207616390", "Kuwait", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 6, 3, 40, 22, 288, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 1, 17, 7, 50, 36, 22, DateTimeKind.Local).AddTicks(7281), "سعيد عارف", "Immanuel Zboncak", 0, "ربيع and Sons", "4050296269122040831", "Lesotho", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 6, 24, 23, 10, 2, 301, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 1, 16, 23, 47, 52, 111, DateTimeKind.Local).AddTicks(6145), "فاروق معروف", "Randal DuBuque", 1, "عراقی, آدم and آدم", "6847255678993886951", "Namibia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 3, 12, 18, 54, 32, 886, DateTimeKind.Local).AddTicks(6491), new DateTime(2024, 1, 17, 12, 33, 4, 995, DateTimeKind.Local).AddTicks(8345), "شيماء سالم", "Heidi DuBuque", "صلاح Group", "4564558044045715885", "Sao Tome and Principe" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 11, 2, 12, 27, 25, 582, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 1, 17, 10, 46, 42, 274, DateTimeKind.Local).AddTicks(9640), "حازم طارق", "Efrain Abshire", "عراقی LLC", "884167215144639000", "Trinidad and Tobago", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 8, 9, 13, 27, 13, 266, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 1, 16, 22, 36, 12, 723, DateTimeKind.Local).AddTicks(8775), "رنا سعيد", "Andrew Nicolas", 0, "طارق, معروف and عراقی", "6634254118678338350", "Svalbard & Jan Mayen Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 3, 28, 8, 0, 21, 97, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 1, 16, 21, 33, 47, 68, DateTimeKind.Local).AddTicks(6900), "شيماء هاشم", "Jadyn Haley", "سعيد, طارق and ربيع", "6251951030136471681", "Hong Kong", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 7, 9, 5, 30, 57, 438, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 1, 17, 13, 5, 52, 152, DateTimeKind.Local).AddTicks(6596), "منى حسن", "Oma Nicolas", "عصار - عاشور", "2095018412073093755", "Wallis and Futuna", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 5, 12, 19, 18, 14, 251, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 1, 17, 3, 36, 51, 86, DateTimeKind.Local).AddTicks(5274), "فريدة حسن", "Guido Christiansen", "أمجد, بلال and حسن", "8474066724662596443", "Syrian Arab Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 7, 20, 20, 48, 53, 833, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 1, 16, 21, 19, 55, 56, DateTimeKind.Local).AddTicks(4055), "عبير فاروق", "Elvera Bednar", "معروف, معروف and سالم", "8369752402919128349", "Dominican Republic", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 8, 5, 19, 27, 15, 263, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 1, 17, 2, 24, 53, 145, DateTimeKind.Local).AddTicks(2932), "فريد حسن", "Ashly Champlin", "عزیز and Sons", "448657273378935737", "Papua New Guinea", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 2, 3, 15, 1, 42, 808, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 1, 16, 22, 26, 47, 586, DateTimeKind.Local).AddTicks(2789), "فريد عارف", "Silas Deckow", 1, "عقیل - فريد", "3864225337586984160", "Republic of Korea", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 5, 30, 10, 54, 17, 164, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 1, 17, 17, 27, 32, 383, DateTimeKind.Local).AddTicks(1810), "ريم عزیز", "Jermaine Roberts", 1, "أسامة and Sons", "1894087302591552286", "Swaziland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 10, 15, 0, 20, 24, 878, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 1, 17, 17, 5, 17, 596, DateTimeKind.Local).AddTicks(4274), "سارة إيهاب", "Effie Cormier", "أسامة Inc", "7142085038752261460", "Czech Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 1, 28, 23, 44, 11, 847, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 1, 17, 9, 23, 17, 460, DateTimeKind.Local).AddTicks(5686), "فؤاد بلال", "Clemmie Feeney", 1, "آدم, ربيع and عقیل", "47059122358483975", "Zambia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1959, 6, 23, 12, 36, 49, 629, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 1, 17, 1, 35, 5, 906, DateTimeKind.Local).AddTicks(4692), "سعيد عصار", "Bernardo Hessel", "فريد - أمجد", "6134583882586625480", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 4, 2, 16, 15, 46, 870, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 1, 16, 20, 53, 30, 992, DateTimeKind.Local).AddTicks(788), "حسن زيد", "Zelma Luettgen", 0, "أسامة, فاروق and أسامة", "1729398786512732813", "Russian Federation", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 8, 19, 1, 39, 15, 735, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 1, 17, 0, 59, 1, 861, DateTimeKind.Local).AddTicks(448), "فاطمة عصار", "Mayra Gerhold", 1, "عاشور - حازم", "5624461795309388902", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 10, 13, 5, 36, 55, 392, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 1, 17, 6, 21, 0, 940, DateTimeKind.Local).AddTicks(7600), "فؤاد ربيع", "Maurine McKenzie", 1, "فؤاد, حازم and عزیز", "1201849235830941379", "Yemen", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 11, 18, 10, 44, 19, 880, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 1, 17, 14, 49, 11, 682, DateTimeKind.Local).AddTicks(197), "صلاح زيد", "Brianne Considine", "طارق - عصار", "932825511975066472", "Senegal", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 2, 13, 12, 37, 50, 801, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 1, 17, 16, 51, 53, 772, DateTimeKind.Local).AddTicks(6341), "حازم هاشم", "Izaiah Hackett", "حسن, صلاح and عاشور", "706213941595714679", "Saint Martin" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 3, 20, 0, 19, 58, 666, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 1, 17, 2, 23, 35, 939, DateTimeKind.Local).AddTicks(2042), "رنا فاروق", "Giovani Dach", "آدم, عراقی and فاروق", "4369025228476897830", "Barbados", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1974, 6, 24, 10, 4, 18, 864, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 1, 17, 19, 30, 10, 544, DateTimeKind.Local).AddTicks(8572), "سعيد عاشور", "Ophelia Parisian", 0, "أسامة and Sons", "2084116817553896253", "Togo" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 2, 20, 23, 5, 31, 126, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 1, 17, 11, 32, 43, 629, DateTimeKind.Local).AddTicks(6057), "جمانة عصار", "Jasen Goyette", 0, "بلال - معروف", "6614424775535228722", "Serbia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 3, 22, 11, 20, 59, 355, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 1, 17, 16, 28, 32, 390, DateTimeKind.Local).AddTicks(2979), "سالم فريد", "Stanley Nitzsche", "صلاح, أسامة and أسامة", "7914909835186740596", "Tuvalu" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 1, 19, 17, 15, 29, 760, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 1, 17, 15, 11, 39, 709, DateTimeKind.Local).AddTicks(3236), "فريد أمجد", "Florian Gleason", "عاشور - إيهاب", "1209218150096501769", "Holy See (Vatican City State)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 10, 7, 10, 47, 13, 246, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 1, 17, 13, 59, 51, 992, DateTimeKind.Local).AddTicks(292), "أروى أمجد", "Letha Dibbert", 0, "أسامة Group", "5327308973894352124", "Cocos (Keeling) Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 8, 4, 17, 9, 50, 370, DateTimeKind.Local).AddTicks(4728), new DateTime(2024, 1, 17, 11, 14, 30, 184, DateTimeKind.Local).AddTicks(7433), "هاجر آدم", "Odie McClure", "طارق Group", "5692234240647421463", "Marshall Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 12, 10, 13, 1, 181, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 1, 17, 2, 15, 24, 835, DateTimeKind.Local).AddTicks(9066), "هاجر عارف", "Annamarie Reynolds", 1, "عاشور and Sons", "3229657110414594477", "Cambodia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 3, 2, 10, 52, 27, 943, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 1, 16, 23, 38, 18, 280, DateTimeKind.Local).AddTicks(9668), "هاجر صلاح", "Lowell Williamson", 0, "حسن LLC", "4878533045912253139", "Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 2, 12, 19, 51, 4, 550, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 1, 17, 14, 41, 14, 593, DateTimeKind.Local).AddTicks(843), "زيد عصار", "Katherine Abernathy", 0, "سالم and Sons", "4860921647481749360", "Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 7, 30, 0, 25, 31, 236, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 1, 17, 20, 0, 4, 655, DateTimeKind.Local).AddTicks(4389), "فاروق سالم", "Iliana Doyle", 0, "صلاح - فريد", "4700911739269063655", "Botswana", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 2, 27, 6, 56, 53, 602, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 1, 17, 15, 43, 26, 468, DateTimeKind.Local).AddTicks(7027), "ريم حازم", "Gilberto Reichert", 1, "بلال - إيهاب", "7282038371729546841", "Fiji", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 24, 11, 34, 36, 666, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 1, 17, 4, 35, 43, 395, DateTimeKind.Local).AddTicks(8308), "شيماء فريد", "Darius Breitenberg", 1, "عاشور - حسن", "29466323575136290", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 6, 16, 19, 53, 2, 799, DateTimeKind.Local).AddTicks(1191), new DateTime(2024, 1, 17, 7, 3, 43, 610, DateTimeKind.Local).AddTicks(3893), "جابر‌ عزیز", "Savion Oberbrunner", 1, "سالم, هاشم and حازم", "209952256709620620", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 4, 7, 2, 42, 42, 601, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 1, 16, 22, 49, 7, 267, DateTimeKind.Local).AddTicks(8545), "لمى بلال", "Monty Bogan", "فؤاد and Sons", "2600013935888344361", "Northern Mariana Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 7, 8, 2, 10, 42, 468, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 1, 17, 8, 42, 3, 179, DateTimeKind.Local).AddTicks(8034), "فاروق فؤاد", "Bettye Brakus", 0, "عقیل - إيهاب", "8628310788500022349", "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 3, 22, 21, 41, 9, 152, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 1, 16, 20, 22, 48, 862, DateTimeKind.Local).AddTicks(7869), "آدم حسن", "Benton Bartoletti", 1, "حسن Inc", "1992914582855568319", "Macao", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 8, 17, 21, 55, 17, 779, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 1, 17, 6, 59, 49, 739, DateTimeKind.Local).AddTicks(692), "فريدة عاشور", "Richmond Luettgen", "طارق, آدم and حسن", "7086304548898411283", "Bangladesh", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 12, 12, 17, 23, 29, 822, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 1, 17, 15, 47, 39, 833, DateTimeKind.Local).AddTicks(1714), "ربيع هاشم", "Luisa Donnelly", 0, "سعيد Inc", "3711855201276628545", "Taiwan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 11, 12, 16, 36, 6, 273, DateTimeKind.Local).AddTicks(2573), new DateTime(2024, 1, 17, 16, 19, 22, 110, DateTimeKind.Local).AddTicks(9787), "زيد ربيع", "Hermann Paucek", 1, "فؤاد, ربيع and فاروق", "3259081322435924402", "Lebanon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 7, 2, 5, 56, 3, 984, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 1, 17, 5, 55, 40, 909, DateTimeKind.Local).AddTicks(4658), "فاطمة سعيد", "Cameron Tremblay", "جابر‌, آدم and أمجد", "2240086984295653889", "Oman", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 6, 4, 20, 15, 45, 274, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 1, 16, 22, 27, 55, 105, DateTimeKind.Local).AddTicks(4183), "جابر‌ عراقی", "Opal Collins", 1, "عقیل Group", "7862948038696646203", "Martinique", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 8, 26, 21, 4, 45, 700, DateTimeKind.Local).AddTicks(5043), new DateTime(2024, 1, 17, 11, 53, 56, 483, DateTimeKind.Local).AddTicks(5995), "ريم عارف", "Kailyn Padberg", "حازم, فريد and عصار", "6279720390884088642", "Ukraine", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 8, 1, 0, 29, 7, 534, DateTimeKind.Local).AddTicks(2075), new DateTime(2024, 1, 17, 18, 18, 41, 732, DateTimeKind.Local).AddTicks(2888), "ربيع زيد", "Dalton Kris", 1, "جابر‌ - أمجد", "3413237345389156936", "Maldives", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 10, 28, 11, 27, 55, 989, DateTimeKind.Local).AddTicks(1795), new DateTime(2024, 1, 16, 20, 11, 47, 290, DateTimeKind.Local).AddTicks(1577), "جابر‌ سالم", "Barbara Turcotte", 0, "عقیل, فريد and طارق", "401703701819204687", "Turks and Caicos Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 2, 28, 19, 16, 28, 919, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 1, 16, 21, 4, 1, 638, DateTimeKind.Local).AddTicks(195), "ربيع حازم", "Sylvester Goodwin", 1, "أسامة LLC", "1593710988122643467", "Macao", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 4, 27, 18, 25, 53, 257, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 1, 17, 3, 2, 51, 75, DateTimeKind.Local).AddTicks(966), "سارة عراقی", "Dakota Yost", 1, "سالم, عزیز and زيد", "5804875365256773596", "Netherlands Antilles", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 6, 22, 8, 4, 30, 574, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 17, 2, 49, 25, 466, DateTimeKind.Local).AddTicks(1198), "رقية عصار", "Joshua Wolf", "عقیل Group", "5693481893581946537", "Oman", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 6, 21, 15, 38, 13, 788, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 1, 17, 14, 7, 18, 98, DateTimeKind.Local).AddTicks(63), "شيماء فؤاد", "Pinkie Dietrich", 0, "طارق, زيد and بلال", "5546709395356466777", "Jamaica", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 10, 2, 21, 14, 0, 594, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 1, 17, 19, 25, 17, 294, DateTimeKind.Local).AddTicks(2391), "عبير هاشم", "Lydia Hayes", 0, "حازم, سالم and ربيع", "3038285427568087323", "Trinidad and Tobago", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 12, 24, 10, 39, 50, 835, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 1, 17, 18, 44, 59, 405, DateTimeKind.Local).AddTicks(3493), "فريد صلاح", "Alexandrea Adams", 0, "عراقی, آدم and عراقی", "5222370016839724797", "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 7, 20, 4, 34, 58, 965, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 1, 17, 9, 27, 52, 822, DateTimeKind.Local).AddTicks(8792), "صلاح معروف", "Americo Stark", 1, "ربيع, إيهاب and عقیل", "6266011204102728708", "British Indian Ocean Territory (Chagos Archipelago)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 10, 15, 6, 53, 37, 87, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 1, 17, 12, 18, 39, 168, DateTimeKind.Local).AddTicks(8731), "لمى أسامة", "Kelsi O'Conner", "معروف - عارف", "8247369988266095542", "Nigeria", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 7, 12, 3, 36, 3, 9, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 1, 16, 21, 39, 25, 206, DateTimeKind.Local).AddTicks(4548), "ريم زيد", "Craig Dickens", "صلاح - عراقی", "707674410795803992", "Christmas Island" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 8, 10, 16, 6, 26, 195, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 1, 17, 7, 48, 23, 703, DateTimeKind.Local).AddTicks(7000), "زينب عزیز", "Nicola Schinner", 0, "عزیز - سالم", "5626087966036918570", "Greenland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 8, 25, 9, 42, 22, 628, DateTimeKind.Local).AddTicks(4179), new DateTime(2024, 1, 17, 3, 54, 46, 906, DateTimeKind.Local).AddTicks(6390), "حازم عراقی", "Nelda Hamill", 1, "فريد LLC", "1550888389175037376", "El Salvador", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 11, 25, 6, 35, 55, 381, DateTimeKind.Local).AddTicks(9824), new DateTime(2024, 1, 17, 4, 38, 25, 245, DateTimeKind.Local).AddTicks(784), "حسن فاروق", "Ahmed Shanahan", 1, "إيهاب, حسن and أمجد", "2612224567216808149", "Singapore", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 8, 13, 23, 32, 51, 912, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 1, 17, 16, 45, 38, 200, DateTimeKind.Local).AddTicks(6062), "فاروق أمجد", "Cletus Jakubowski", "زيد - عزیز", "285799790540914850", "Czech Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 3, 5, 3, 18, 9, 227, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 1, 17, 14, 59, 37, 5, DateTimeKind.Local).AddTicks(5633), "منى عصار", "Alan Schiller", 0, "عاشور LLC", "488095116064525517", "Mali" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 5, 11, 7, 54, 6, 521, DateTimeKind.Local).AddTicks(860), new DateTime(2024, 1, 17, 5, 0, 0, 331, DateTimeKind.Local).AddTicks(3822), "هاجر فؤاد", "Jeramie Russel", "عزیز LLC", "1320952951441330894", "Russian Federation", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 10, 5, 19, 23, 11, 966, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 1, 17, 2, 6, 18, 458, DateTimeKind.Local).AddTicks(7327), "زينب هاشم", "Demetrius Kuhlman", "جابر‌ - أسامة", "3019040145672501589", "Japan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 9, 10, 14, 12, 46, 307, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 1, 17, 18, 12, 10, 599, DateTimeKind.Local).AddTicks(9365), "إيناس فؤاد", "Nathaniel Runte", 0, "صلاح Group", "4659351010697933212", "Togo" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 2, 24, 21, 16, 42, 599, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 1, 17, 0, 44, 43, 259, DateTimeKind.Local).AddTicks(886), "حازم عقیل", "Eriberto Stark", 0, "زيد Inc", "3642421652681090679", "Azerbaijan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 12, 8, 5, 27, 56, 297, DateTimeKind.Local).AddTicks(2156), new DateTime(2024, 1, 17, 2, 16, 31, 576, DateTimeKind.Local).AddTicks(5365), "إيهاب سعيد", "Evalyn Ledner", "سعيد - عصار", "225791160244075209", "Kazakhstan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 11, 17, 0, 45, 55, 466, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 1, 17, 4, 33, 43, 480, DateTimeKind.Local).AddTicks(5039), "سالم هاشم", "Whitney Walker", "هاشم and Sons", "8805638513496082036", "French Polynesia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 4, 10, 7, 36, 15, 656, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 1, 16, 23, 20, 57, 510, DateTimeKind.Local).AddTicks(1754), "رقية حسن", "Marcelo Kunde", "بلال Group", "4899236436353799323", "Cameroon" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 6, 8, 5, 42, 55, 507, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 1, 17, 18, 19, 49, 590, DateTimeKind.Local).AddTicks(8310), "فؤاد حازم", "Haven Larkin", "جابر‌ Group", "1920874930740165225", "Kiribati", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 4, 21, 2, 45, 36, 288, DateTimeKind.Local).AddTicks(7923), new DateTime(2024, 1, 17, 12, 9, 56, 168, DateTimeKind.Local).AddTicks(5374), "دانا عزیز", "Curt Watsica", 1, "عقیل Inc", "8581669837397836574", "France", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 7, 25, 14, 41, 15, 591, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 1, 17, 13, 52, 2, 380, DateTimeKind.Local).AddTicks(7531), "حازم عاشور", "Jacynthe Gusikowski", "ربيع and Sons", "2041005573101861250", "Serbia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 5, 31, 3, 52, 10, 272, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 1, 17, 15, 26, 46, 781, DateTimeKind.Local).AddTicks(1778), "لمى عارف", "Noemie Lakin", 0, "بلال, فريد and عقیل", "1041189183130540745", "Latvia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 11, 19, 21, 50, 46, 453, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 1, 17, 1, 10, 26, 862, DateTimeKind.Local).AddTicks(3375), "جمانة بلال", "Jody Mitchell", 1, "أسامة - فريد", "5845762231375631773", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 3, 23, 18, 4, 7, 382, DateTimeKind.Local).AddTicks(6398), new DateTime(2024, 1, 16, 21, 1, 53, 951, DateTimeKind.Local).AddTicks(8045), "حسن عراقی", "Tina Rodriguez", 1, "سعيد, معروف and سعيد", "3464488388336225844", "Saint Lucia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 4, 4, 6, 31, 55, 223, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 1, 17, 15, 29, 47, 402, DateTimeKind.Local).AddTicks(8297), "جمانة معروف", "Caden Mraz", "هاشم - عزیز", "4480651786257234772", "Belarus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 4, 1, 12, 21, 18, 832, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 1, 17, 18, 21, 5, 706, DateTimeKind.Local).AddTicks(2618), "فاروق عقیل", "Onie Dickens", 1, "عقیل, عراقی and عارف", "7785036928993119607", "Liberia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 4, 4, 10, 51, 59, 480, DateTimeKind.Local).AddTicks(1311), new DateTime(2024, 1, 17, 17, 26, 43, 75, DateTimeKind.Local).AddTicks(1009), "أروى عارف", "Camron Murphy", "أمجد and Sons", "3283212282142814117", "Barbados", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 25, 20, 58, 9, 462, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 1, 16, 20, 59, 34, 902, DateTimeKind.Local).AddTicks(6085), "شيماء عقیل", "May Fadel", "عزیز - طارق", "2425245576540841425", "American Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 12, 10, 15, 54, 55, 622, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 1, 17, 6, 16, 41, 224, DateTimeKind.Local).AddTicks(9913), "إيهاب إيهاب", "Grayson Bartoletti", "صلاح Group", "7454437822584889069", "Malta", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 4, 28, 16, 15, 35, 102, DateTimeKind.Local).AddTicks(7317), new DateTime(2024, 1, 17, 7, 23, 49, 952, DateTimeKind.Local).AddTicks(7550), "جابر‌ هاشم", "Priscilla Hettinger", "سعيد, معروف and معروف", "7609964903327530224", "Montserrat", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 8, 8, 14, 26, 25, 444, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 1, 17, 1, 4, 48, 834, DateTimeKind.Local).AddTicks(6617), "صلاح عارف", "Eloy Wilderman", 0, "عقیل LLC", "4658958043991462518", "Mongolia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 6, 18, 5, 18, 15, 831, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 1, 17, 14, 18, 18, 857, DateTimeKind.Local).AddTicks(3010), "بلال آدم", "Aron Mayer", 1, "فاروق, زيد and صلاح", "5025450213857652776", "El Salvador", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 5, 5, 12, 30, 26, 179, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 1, 17, 11, 58, 17, 537, DateTimeKind.Local).AddTicks(6821), "بلال ربيع", "Andreanne Sporer", "معروف - سعيد", "8202917515901090792", "United Arab Emirates" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 9, 12, 1, 16, 19, 201, DateTimeKind.Local).AddTicks(7612), new DateTime(2024, 1, 17, 12, 17, 34, 810, DateTimeKind.Local).AddTicks(7204), "ريم جابر‌", "Zane Stanton", "أمجد, عزیز and عزیز", "2897901823350918186", "Northern Mariana Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 10, 30, 18, 37, 53, 953, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 1, 17, 4, 43, 47, 755, DateTimeKind.Local).AddTicks(7325), "زيد فؤاد", "Estell Blanda", 1, "عقیل - عصار", "1003907712402884169", "South Africa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 10, 3, 9, 21, 39, 371, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 1, 17, 11, 54, 21, 112, DateTimeKind.Local).AddTicks(8344), "طارق جابر‌", "Brant Bartoletti", 1, "طارق, ربيع and إيهاب", "6559499414360925989", "El Salvador", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 4, 17, 5, 24, 34, 428, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 1, 17, 18, 34, 49, 994, DateTimeKind.Local).AddTicks(5330), "حسن حازم", "Grover Jast", 0, "عزیز Inc", "577786809660277035", "Belgium" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 5, 21, 7, 26, 55, 797, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 1, 17, 10, 2, 13, 851, DateTimeKind.Local).AddTicks(1503), "أمجد عاشور", "Edna Murazik", 1, "إيهاب LLC", "8534920489139546068", "Bouvet Island (Bouvetoya)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 4, 20, 1, 12, 38, 891, DateTimeKind.Local).AddTicks(734), new DateTime(2024, 1, 16, 23, 41, 38, 682, DateTimeKind.Local).AddTicks(4913), "شيماء عراقی", "Jaeden Ward", 0, "ربيع, جابر‌ and ربيع", "7845369942039756498", "Saint Pierre and Miquelon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 10, 20, 0, 53, 36, 730, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 1, 17, 17, 14, 44, 980, DateTimeKind.Local).AddTicks(6152), "هاجر فؤاد", "Marcelle Boehm", "سالم - صلاح", "5356864033705116723", "China", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 8, 1, 4, 21, 20, 417, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 1, 17, 5, 12, 8, 703, DateTimeKind.Local).AddTicks(8614), "أمجد عراقی", "Kaley Koepp", 1, "سعيد, سالم and عراقی", "1178820165497987569", "British Indian Ocean Territory (Chagos Archipelago)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 9, 18, 7, 2, 125, DateTimeKind.Local).AddTicks(1459), new DateTime(2024, 1, 17, 15, 52, 20, 939, DateTimeKind.Local).AddTicks(4621), "إيناس حازم", "Danyka Shields", "سعيد - إيهاب", "4503500773166907478", "Hungary", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 6, 6, 22, 20, 11, 298, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 1, 17, 19, 32, 43, 301, DateTimeKind.Local).AddTicks(6840), "ربيع سعيد", "Connor Kris", "سالم, فؤاد and صلاح", "4429679104670591965", "Sudan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 12, 12, 12, 1, 10, 682, DateTimeKind.Local).AddTicks(8919), new DateTime(2024, 1, 17, 17, 55, 1, 656, DateTimeKind.Local).AddTicks(6031), "عبير حسن", "Velma Huel", "هاشم Inc", "7729085788303700777", "Cape Verde", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 5, 18, 18, 29, 8, 891, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 1, 17, 17, 1, 30, 846, DateTimeKind.Local).AddTicks(1741), "فريد إيهاب", "Rosalinda Sporer", 1, "إيهاب, فاروق and زيد", "2783220318303240030", "Timor-Leste" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 8, 28, 1, 17, 8, 226, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 1, 17, 4, 4, 31, 618, DateTimeKind.Local).AddTicks(4617), "شيماء عقیل", "Tyson Donnelly", 0, "هاشم - طارق", "4423049952922460698", "Austria", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 1, 25, 11, 1, 38, 351, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 1, 17, 12, 39, 26, 245, DateTimeKind.Local).AddTicks(8437), "جمانة فاروق", "Raquel Schneider", 1, "سعيد Group", "4338880356749335444", "Liberia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 5, 7, 13, 39, 27, 68, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 1, 17, 6, 41, 53, 455, DateTimeKind.Local).AddTicks(9760), "زيد حسن", "Katelynn Goldner", "سالم Inc", "8577552934146095786", "Saint Pierre and Miquelon", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 9, 3, 23, 30, 40, 787, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 1, 17, 13, 4, 17, 867, DateTimeKind.Local).AddTicks(7716), "أسامة حسن", "Godfrey Runolfsson", 0, "زيد, معروف and إيهاب", "90607050483667982", "Brunei Darussalam", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 12, 19, 14, 22, 42, 700, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 1, 17, 15, 1, 56, 582, DateTimeKind.Local).AddTicks(7949), "ريم ربيع", "Reuben Ebert", "عارف - فريد", "5441221930739834956", "Sierra Leone", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 11, 4, 5, 34, 26, 921, DateTimeKind.Local).AddTicks(3180), new DateTime(2024, 1, 16, 23, 20, 36, 953, DateTimeKind.Local).AddTicks(2569), "عبير أمجد", "Kayley O'Connell", "عراقی - أسامة", "8016649340234185768", "French Southern Territories", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1987, 3, 31, 11, 40, 56, 21, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 1, 17, 2, 3, 54, 492, DateTimeKind.Local).AddTicks(4738), "دانا عزیز", "Cameron Gleichner", 0, "حسن, عقیل and هاشم", "1134212114451939126", "Bolivia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 2, 17, 12, 23, 59, 849, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 1, 17, 10, 3, 15, 121, DateTimeKind.Local).AddTicks(556), "إيهاب إيهاب", "Mary Harris", 1, "زيد, آدم and عصار", "5518805231371050592", "Zambia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 5, 8, 17, 31, 46, 565, DateTimeKind.Local).AddTicks(6418), new DateTime(2024, 1, 16, 22, 26, 12, 381, DateTimeKind.Local).AddTicks(7753), "جمانة سالم", "Zola Hahn", "عاشور - عاشور", "3564310419530575786", "Christmas Island", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 8, 9, 3, 21, 35, 709, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 1, 17, 0, 54, 4, 327, DateTimeKind.Local).AddTicks(7402), "سارة عاشور", "Edwina Wolff", 1, "أمجد, فؤاد and أسامة", "3680968953290386188", "Malta", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 1, 28, 8, 59, 30, 866, DateTimeKind.Local).AddTicks(1901), new DateTime(2024, 1, 17, 10, 37, 31, 559, DateTimeKind.Local).AddTicks(8872), "إيناس أسامة", "Bette Upton", "صلاح Group", "7416614213151254334", "Georgia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 2, 5, 18, 9, 31, 977, DateTimeKind.Local).AddTicks(2781), new DateTime(2024, 1, 17, 14, 8, 36, 380, DateTimeKind.Local).AddTicks(3172), "حازم عزیز", "Tessie Weber", "صلاح - فاروق", "6111070357305997211", "Chile", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 9, 27, 7, 10, 52, 428, DateTimeKind.Local).AddTicks(4828), new DateTime(2024, 1, 17, 16, 3, 27, 609, DateTimeKind.Local).AddTicks(6412), "ريم بلال", "William Orn", 1, "طارق and Sons", "3328398652167547674", "Somalia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 11, 29, 1, 32, 33, 982, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 1, 17, 0, 26, 4, 97, DateTimeKind.Local).AddTicks(8064), "سالم فريد", "Alfredo Ward", "إيهاب, معروف and طارق", "1130792660159479140", "Sudan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1954, 4, 23, 0, 42, 5, 397, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 1, 17, 19, 0, 23, 538, DateTimeKind.Local).AddTicks(4771), "فريد سعيد", "Eduardo Bahringer", 1, "أسامة - عزیز", "1691428818883000549", "Timor-Leste" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 11, 23, 20, 51, 39, 458, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 1, 17, 2, 46, 56, 558, DateTimeKind.Local).AddTicks(7497), "فريدة فاروق", "Estevan Renner", "فريد - هاشم", "5524264718735054318", "Myanmar", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 5, 17, 23, 58, 55, 350, DateTimeKind.Local).AddTicks(6136), new DateTime(2024, 1, 17, 7, 41, 11, 523, DateTimeKind.Local).AddTicks(962), "فريد آدم", "Breanna Rowe", "حسن - معروف", "723514111554907208", "Moldova", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 2, 26, 8, 26, 22, 441, DateTimeKind.Local).AddTicks(3421), new DateTime(2024, 1, 17, 18, 3, 22, 108, DateTimeKind.Local).AddTicks(6910), "طارق صلاح", "Franz Lesch", "حازم - بلال", "875011163018802919", "Djibouti", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 3, 14, 23, 45, 36, 507, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 1, 16, 21, 45, 36, 428, DateTimeKind.Local).AddTicks(4212), "فؤاد أسامة", "Jimmie Mayer", 0, "آدم LLC", "5266493658983911330", "Guernsey", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 12, 15, 12, 52, 12, 799, DateTimeKind.Local).AddTicks(7386), new DateTime(2024, 1, 17, 12, 19, 54, 646, DateTimeKind.Local).AddTicks(5785), "آدم عاشور", "Clara Runolfsson", "هاشم, فريد and عراقی", "4193382580320060606", "Saint Helena", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 10, 13, 8, 11, 48, 757, DateTimeKind.Local).AddTicks(3571), new DateTime(2024, 1, 17, 10, 23, 11, 84, DateTimeKind.Local).AddTicks(5897), "بلال جابر‌", "Demetris Schroeder", "حازم, أسامة and صلاح", "2562991404977019645", "Heard Island and McDonald Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 12, 2, 16, 45, 20, 785, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 1, 16, 21, 39, 9, 517, DateTimeKind.Local).AddTicks(6184), "فاروق هاشم", "Haskell Leannon", "هاشم, سعيد and سعيد", "5428875527222663468", "Pakistan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 9, 27, 22, 41, 48, 508, DateTimeKind.Local).AddTicks(528), new DateTime(2024, 1, 17, 10, 20, 54, 280, DateTimeKind.Local).AddTicks(4408), "لمى معروف", "Frederic Stoltenberg", 1, "حازم, سعيد and سالم", "8267498266054730734", "Wallis and Futuna", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 3, 8, 15, 6, 6, 453, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 1, 17, 1, 30, 45, 986, DateTimeKind.Local).AddTicks(136), "صلاح عزیز", "Rhiannon Hansen", "عزیز - فؤاد", "1939313918381473685", "Seychelles", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 4, 14, 2, 16, 2, 666, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 1, 17, 0, 10, 34, 4, DateTimeKind.Local).AddTicks(466), "إيهاب صلاح", "Alexie Durgan", "جابر‌ - آدم", "4839743678095530494", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 3, 23, 0, 0, 9, 382, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 1, 17, 2, 50, 51, 954, DateTimeKind.Local).AddTicks(9906), "أروى إيهاب", "Kris Weissnat", "إيهاب, عاشور and هاشم", "5175343445561634431", "Israel", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 21, 13, 46, 3, 9, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 1, 17, 18, 3, 44, 39, DateTimeKind.Local).AddTicks(8673), "فاطمة طارق", "Winona Hessel", 0, "آدم - عزیز", "4628629009105526947", "Qatar", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 5, 9, 9, 16, 7, 929, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 1, 17, 4, 44, 12, 225, DateTimeKind.Local).AddTicks(1518), "هاجر فاروق", "Terrell Cartwright", "ربيع Inc", "281490186205621499", "Democratic People's Republic of Korea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 3, 13, 13, 49, 2, 708, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 1, 17, 15, 55, 26, 726, DateTimeKind.Local).AddTicks(6529), "أسامة أمجد", "Dakota Bednar", "عاشور Group", "2889085065275765184", "Guam", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 12, 20, 23, 42, 17, 391, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 1, 17, 16, 43, 17, 498, DateTimeKind.Local).AddTicks(7396), "شيماء عاشور", "Adriana Erdman", "إيهاب, فؤاد and طارق", "1149744704569245088", "Guinea", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 12, 19, 17, 56, 46, 522, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 1, 16, 23, 10, 42, 929, DateTimeKind.Local).AddTicks(748), "آدم بلال", "Bette Carter", 0, "عراقی, آدم and عقیل", "1789617290628507310", "Moldova", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 9, 3, 16, 7, 14, 89, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 1, 17, 6, 2, 9, 990, DateTimeKind.Local).AddTicks(8123), "جابر‌ عاشور", "Gregorio Schimmel", "أسامة, بلال and معروف", "3977124945275998031", "Norway", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 2, 13, 11, 12, 15, 326, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 1, 17, 5, 55, 29, 131, DateTimeKind.Local).AddTicks(1760), "سالم بلال", "Elinor Schultz", 1, "ربيع Inc", "7147443195550870596", "Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 4, 12, 16, 15, 42, 845, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 1, 17, 8, 40, 44, 227, DateTimeKind.Local).AddTicks(8527), "زينب فاروق", "Augusta Hegmann", "معروف LLC", "607213334259964234", "Belgium", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 3, 21, 1, 57, 43, 849, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 1, 17, 14, 51, 31, 133, DateTimeKind.Local).AddTicks(5604), "آية بلال", "Alda Harber", 0, "صلاح - عارف", "1264150759493866059", "Bouvet Island (Bouvetoya)", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 10, 19, 2, 1, 13, 218, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 1, 17, 13, 39, 23, 859, DateTimeKind.Local).AddTicks(1690), "ربيع إيهاب", "Jimmie Lakin", "حسن, أمجد and زيد", "4871819666672730065", "British Indian Ocean Territory (Chagos Archipelago)", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 3, 7, 10, 42, 22, 548, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 1, 17, 13, 14, 3, 293, DateTimeKind.Local).AddTicks(4856), "ريم فؤاد", "Shanon Hegmann", 1, "إيهاب - معروف", "3160672021825436556", "China", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 1, 23, 18, 16, 43, 997, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 1, 17, 19, 12, 11, 291, DateTimeKind.Local).AddTicks(4111), "فاطمة عارف", "Ramiro Torphy", "جابر‌ - عصار", "793931066932248267", "Antarctica (the territory South of 60 deg S)", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 2, 6, 11, 54, 3, 338, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 1, 17, 8, 53, 16, 113, DateTimeKind.Local).AddTicks(4609), "آية آدم", "Jacques Rice", "عاشور LLC", "1720643358459062394", "Suriname", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 10, 17, 17, 5, 58, 609, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 1, 17, 8, 26, 35, 500, DateTimeKind.Local).AddTicks(7182), "عبير عراقی", "Javonte Kautzer", 0, "إيهاب - هاشم", "5244076327804670447", "Algeria" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 2, 3, 21, 31, 4, 632, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 1, 17, 5, 10, 26, 674, DateTimeKind.Local).AddTicks(608), "رقية عراقی", "Shayna Bode", "عقیل - أسامة", "5761177591497356578", "Burundi", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 8, 12, 13, 11, 41, 889, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 1, 17, 1, 37, 17, 868, DateTimeKind.Local).AddTicks(7173), "أروى سعيد", "Albina Ankunding", "آدم Group", "2218918868452861807", "Jamaica", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 4, 25, 17, 24, 35, 292, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 1, 17, 17, 25, 46, 420, DateTimeKind.Local).AddTicks(6775), "سعيد عصار", "Geraldine Kuhlman", 0, "أسامة Group", "3903196733608388934", "Taiwan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 1, 6, 3, 14, 16, 157, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 1, 17, 15, 33, 9, 654, DateTimeKind.Local).AddTicks(6997), "سعيد فاروق", "Crawford Pouros", "حسن, صلاح and سعيد", "5150489030401808435", "Iran", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 6, 27, 16, 51, 43, 370, DateTimeKind.Local).AddTicks(8180), new DateTime(2024, 1, 17, 3, 38, 49, 86, DateTimeKind.Local).AddTicks(8151), "طارق عقیل", "Judah Lubowitz", 1, "عصار, صلاح and آدم", "8959693068748850733", "Central African Republic", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 6, 3, 3, 53, 7, 556, DateTimeKind.Local).AddTicks(4201), new DateTime(2024, 1, 16, 22, 30, 39, 738, DateTimeKind.Local).AddTicks(703), "زيد إيهاب", "Brice Aufderhar", "فؤاد - طارق", "8999025968519774363", "Russian Federation", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 4, 17, 21, 13, 32, 166, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 1, 16, 22, 44, 57, 277, DateTimeKind.Local).AddTicks(343), "فاطمة صلاح", "Mervin Quitzon", 1, "آدم - أسامة", "7353001004114152806", "Thailand", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 3, 4, 8, 42, 23, 78, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 1, 16, 21, 36, 56, 807, DateTimeKind.Local).AddTicks(3386), "أروى آدم", "Mia Terry", "عصار, عاشور and عراقی", "449666030861216675", "Saint Barthelemy", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 2, 12, 22, 44, 43, 273, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 1, 16, 21, 20, 15, 959, DateTimeKind.Local).AddTicks(1012), "فريدة فريد", "Maximo Howell", 1, "ربيع Inc", "1986570133286554044", "Saint Vincent and the Grenadines", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 3, 29, 1, 24, 29, 874, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 1, 17, 4, 26, 51, 699, DateTimeKind.Local).AddTicks(2014), "إيهاب جابر‌", "Lillie Lemke", "سالم - صلاح", "3178846994739912483", "France", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 7, 26, 18, 12, 2, 528, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 1, 16, 21, 59, 39, 556, DateTimeKind.Local).AddTicks(7117), "أسامة سعيد", "Idell Satterfield", "آدم - سعيد", "5626661539113215200", "Cyprus" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 2, 16, 12, 50, 15, 706, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 1, 17, 1, 48, 20, 250, DateTimeKind.Local).AddTicks(7124), "صلاح أمجد", "Durward Turcotte", 0, "عقیل LLC", "1025411967129962496", "Slovenia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1964, 11, 23, 13, 59, 9, 323, DateTimeKind.Local).AddTicks(7673), new DateTime(2024, 1, 17, 18, 38, 10, 145, DateTimeKind.Local).AddTicks(9129), "شيماء إيهاب", "Estrella Adams", "آدم LLC", "4969104632142350724", "Panama" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 9, 10, 2, 38, 49, 413, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 1, 17, 18, 15, 49, 604, DateTimeKind.Local).AddTicks(4426), "إيهاب عارف", "Audreanne Sauer", "طارق, عاشور and حسن", "5777054233123464499", "Svalbard & Jan Mayen Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 28, 13, 31, 4, 562, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 1, 17, 0, 3, 56, 217, DateTimeKind.Local).AddTicks(990), "جابر‌ فؤاد", "Katarina Romaguera", "عقیل LLC", "945466307513246631", "Zimbabwe", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 11, 19, 12, 14, 22, 32, DateTimeKind.Local).AddTicks(2784), new DateTime(2024, 1, 17, 0, 44, 1, 429, DateTimeKind.Local).AddTicks(4936), "حسن فاروق", "Reyes Bayer", 1, "زيد - إيهاب", "5007327161058104263", "Solomon Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 10, 2, 15, 41, 37, 475, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 1, 16, 21, 54, 15, 681, DateTimeKind.Local).AddTicks(1320), "فاروق هاشم", "Tatum Welch", 1, "بلال - عراقی", "4522301024676284084", "Switzerland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 12, 24, 1, 16, 55, 23, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 1, 17, 10, 35, 59, 14, DateTimeKind.Local).AddTicks(9933), "سعيد ربيع", "Ressie Kunde", "عاشور, ربيع and أسامة", "201140334926075463", "Saudi Arabia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 1, 23, 8, 25, 37, 185, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 1, 17, 7, 37, 35, 292, DateTimeKind.Local).AddTicks(9843), "سالم فؤاد", "Lempi Ondricka", 0, "حسن LLC", "6365358896937452392", "Mozambique", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 5, 24, 5, 13, 41, 959, DateTimeKind.Local).AddTicks(293), new DateTime(2024, 1, 16, 22, 41, 55, 447, DateTimeKind.Local).AddTicks(7630), "فؤاد عصار", "Nelle Abshire", "بلال - آدم", "2442184949710143524", "Portugal", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 4, 3, 5, 36, 13, 608, DateTimeKind.Local).AddTicks(1830), new DateTime(2024, 1, 17, 5, 33, 50, 928, DateTimeKind.Local).AddTicks(6647), "أمجد معروف", "Justina Bahringer", "سالم and Sons", "942892820365020774", "Bhutan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 3, 16, 21, 28, 43, 899, DateTimeKind.Local).AddTicks(833), new DateTime(2024, 1, 16, 23, 27, 12, 790, DateTimeKind.Local).AddTicks(1226), "أروى صلاح", "Akeem Dicki", "عزیز, حازم and جابر‌", "7239837732882135084", "Seychelles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 12, 23, 20, 1, 34, 982, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 1, 17, 17, 36, 15, 658, DateTimeKind.Local).AddTicks(2107), "ربيع حازم", "Richie Hayes", "زيد, عراقی and فاروق", "2506825424647263243", "Afghanistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 2, 6, 7, 18, 20, 337, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 1, 17, 3, 38, 57, 842, DateTimeKind.Local).AddTicks(1091), "زينب آدم", "Rogers Fahey", 1, "طارق - جابر‌", "3474662284707557341", "Iceland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 8, 20, 9, 28, 26, 331, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 1, 16, 22, 53, 49, 509, DateTimeKind.Local).AddTicks(7170), "دانا فؤاد", "Mateo Brakus", 0, "أسامة, معروف and زيد", "5221552773291209544", "Jordan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 8, 19, 11, 19, 49, 506, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 1, 17, 4, 44, 49, 138, DateTimeKind.Local).AddTicks(3958), "ريم زيد", "Marlin Tremblay", "هاشم, حسن and فؤاد", "6695356412076100115", "Suriname", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 11, 5, 21, 20, 32, 985, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 1, 17, 4, 11, 34, 191, DateTimeKind.Local).AddTicks(531), "طارق معروف", "Cristobal Connelly", "معروف, بلال and فريد", "7692351262913674880", "United States of America" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 7, 20, 0, 45, 59, 369, DateTimeKind.Local).AddTicks(277), new DateTime(2024, 1, 17, 10, 6, 28, 641, DateTimeKind.Local).AddTicks(6487), "لمى هاشم", "Bradley Gislason", "إيهاب Group", "4842436547483577246", "Honduras", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1974, 5, 4, 17, 32, 31, 951, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 1, 17, 17, 25, 11, 697, DateTimeKind.Local).AddTicks(8621), "منى عراقی", "Lenore Schumm", 0, "آدم - سعيد", "5574271577246689405", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 8, 22, 20, 56, 25, 753, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 1, 17, 16, 43, 59, 238, DateTimeKind.Local).AddTicks(8435), "عبير طارق", "Mason Larson", "عقیل and Sons", "6964681543648195374", "Australia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 5, 23, 14, 47, 58, 12, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 1, 17, 1, 8, 50, 327, DateTimeKind.Local).AddTicks(3635), "رنا أسامة", "Tanya Tillman", "فريد Inc", "1962842345475868811", "Montserrat", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 3, 4, 15, 44, 59, 740, DateTimeKind.Local).AddTicks(8167), new DateTime(2024, 1, 17, 13, 4, 14, 109, DateTimeKind.Local).AddTicks(2159), "لمى عراقی", "Gussie Stiedemann", 0, "جابر‌ - عاشور", "8887426886769578284", "Belgium", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1974, 5, 29, 16, 11, 13, 477, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 1, 17, 14, 41, 52, 215, DateTimeKind.Local).AddTicks(7019), "جابر‌ فؤاد", "Braden Ziemann", "هاشم, فريد and عزیز", "1897071946769179834", "Rwanda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 3, 23, 16, 15, 51, 52, DateTimeKind.Local).AddTicks(7712), new DateTime(2024, 1, 17, 3, 59, 40, 542, DateTimeKind.Local).AddTicks(7633), "ريم فؤاد", "Dariana Tillman", "عقیل Inc", "3052868434785720793", "Yemen", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 4, 20, 16, 25, 37, 281, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 1, 17, 15, 8, 55, 92, DateTimeKind.Local).AddTicks(6821), "صلاح فريد", "Monroe Olson", "عراقی, سعيد and إيهاب", "3627777351674691176", "United Arab Emirates" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 2, 1, 15, 45, 34, 68, DateTimeKind.Local).AddTicks(9201), new DateTime(2024, 1, 17, 6, 31, 7, 157, DateTimeKind.Local).AddTicks(9465), "فريدة ربيع", "Sister Balistreri", 0, "ربيع, أمجد and زيد", "2595822703204099990", "Cameroon", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 12, 11, 11, 55, 54, 269, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 17, 4, 28, 36, 380, DateTimeKind.Local).AddTicks(9059), "أمجد عاشور", "Leanne Stamm", 0, "سعيد, حسن and فريد", "4057013047272803450", "Republic of Korea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1966, 7, 25, 15, 9, 32, 874, DateTimeKind.Local).AddTicks(3712), new DateTime(2024, 1, 17, 13, 49, 12, 109, DateTimeKind.Local).AddTicks(1039), "أروى بلال", "Erich Parisian", "عقیل - عراقی", "4575698359723031580", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 8, 18, 5, 7, 57, 339, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 1, 17, 1, 30, 18, 617, DateTimeKind.Local).AddTicks(8923), "أسامة عقیل", "Carter Bergstrom", "عصار Inc", "4517495507976611857", "Jersey", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 9, 28, 20, 54, 14, 30, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 1, 17, 13, 16, 29, 849, DateTimeKind.Local).AddTicks(2506), "جمانة عاشور", "Marquise Bruen", 0, "زيد and Sons", "1395596238068910490", "Italy", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 4, 2, 23, 19, 13, 540, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 1, 17, 10, 28, 42, 218, DateTimeKind.Local).AddTicks(3587), "ربيع جابر‌", "Dayton McClure", "جابر‌ Inc", "6423594412572839256", "Puerto Rico", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 1, 11, 0, 48, 0, 403, DateTimeKind.Local).AddTicks(4500), new DateTime(2024, 1, 17, 13, 50, 33, 713, DateTimeKind.Local).AddTicks(4431), "عبير جابر‌", "Rosanna Jenkins", 0, "سعيد, أسامة and هاشم", "4152206247279225572", "Turks and Caicos Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 4, 29, 19, 18, 33, 389, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 1, 16, 22, 7, 49, 790, DateTimeKind.Local).AddTicks(4844), "جمانة فريد", "Stacey Effertz", "عقیل - عزیز", "8362807151210152756", "Aruba", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 12, 15, 21, 37, 45, 594, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 1, 17, 2, 36, 58, 285, DateTimeKind.Local).AddTicks(1699), "سالم عقیل", "Dejah Brakus", 1, "حازم - جابر‌", "9018089750738192986", "Djibouti" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 10, 9, 1, 54, 7, 992, DateTimeKind.Local).AddTicks(9749), new DateTime(2024, 1, 17, 4, 55, 59, 48, DateTimeKind.Local).AddTicks(4575), "سعيد فؤاد", "Phoebe Wiza", 1, "هاشم - أسامة", "587423898264459568", "Cyprus", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 1, 23, 20, 43, 22, 394, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 1, 17, 10, 49, 34, 471, DateTimeKind.Local).AddTicks(8741), "دانا زيد", "Darrell Frami", 1, "سعيد LLC", "7501813372673631154", "Bolivia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 8, 12, 14, 41, 49, 507, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 1, 17, 3, 31, 34, 122, DateTimeKind.Local).AddTicks(9189), "عبير طارق", "Krystal Jast", "بلال, صلاح and بلال", "8021179794332787634", "Russian Federation" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 7, 16, 9, 8, 31, 927, DateTimeKind.Local).AddTicks(7362), new DateTime(2024, 1, 16, 22, 39, 8, 965, DateTimeKind.Local).AddTicks(8145), "آدم سالم", "Antwan Heidenreich", "فريد - معروف", "2785022136638469494", "Dominica", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 10, 19, 4, 52, 50, 170, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 1, 17, 15, 12, 15, 957, DateTimeKind.Local).AddTicks(5571), "طارق جابر‌", "Violette Kub", 1, "زيد - أسامة", "8047017451067813712", "American Samoa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 5, 15, 5, 19, 23, 597, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 1, 17, 16, 42, 50, 112, DateTimeKind.Local).AddTicks(3331), "آدم جابر‌", "Marge Ortiz", 0, "سالم Group", "1766244821699453585", "France", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 9, 19, 19, 12, 20, 576, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 1, 17, 1, 37, 28, 685, DateTimeKind.Local).AddTicks(2240), "آية بلال", "Jeramy Jacobson", "سالم and Sons", "4351442975735188936", "Austria", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1974, 1, 3, 22, 52, 59, 395, DateTimeKind.Local).AddTicks(4521), new DateTime(2024, 1, 17, 16, 7, 48, 255, DateTimeKind.Local).AddTicks(3194), "جابر‌ إيهاب", "Roman Monahan", 0, "حازم - بلال", "9009046482786227056", "Saint Vincent and the Grenadines" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 5, 30, 23, 36, 51, 876, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 1, 17, 5, 7, 10, 552, DateTimeKind.Local).AddTicks(8819), "فريدة عصار", "Eve Kshlerin", 0, "فاروق - فريد", "2333868889726847279", "Dominica", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 3, 28, 4, 9, 0, 489, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 1, 17, 15, 35, 18, 238, DateTimeKind.Local).AddTicks(4239), "حسن عراقی", "Darrel Krajcik", 0, "زيد - بلال", "422727952902241286", "Cameroon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 4, 29, 6, 53, 41, 885, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 1, 17, 1, 58, 25, 138, DateTimeKind.Local).AddTicks(5019), "أمجد عزیز", "Bradley Considine", "أمجد Group", "2864280014465299700", "Saint Vincent and the Grenadines", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 11, 3, 16, 56, 5, 616, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 1, 16, 23, 17, 45, 641, DateTimeKind.Local).AddTicks(6765), "دانا أسامة", "Taya Aufderhar", "طارق LLC", "6365347137195567010", "Vietnam", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 4, 7, 8, 22, 17, 542, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 1, 17, 0, 7, 5, 835, DateTimeKind.Local).AddTicks(3513), "حسن فاروق", "Deon Braun", 1, "ربيع - آدم", "5569096625158115709", "Cameroon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 7, 10, 9, 3, 44, 845, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 1, 17, 13, 31, 47, 885, DateTimeKind.Local).AddTicks(7447), "زينب عارف", "Mandy Green", "ربيع, حازم and أمجد", "4531290418143451580", "China", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 5, 30, 2, 45, 53, 31, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 1, 17, 7, 14, 51, 35, DateTimeKind.Local).AddTicks(4946), "سعيد حسن", "Hayley Kilback", "فاروق, ربيع and عقیل", "7833544439595375981", "Luxembourg", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 10, 6, 10, 50, 55, 586, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 1, 17, 10, 9, 1, 256, DateTimeKind.Local).AddTicks(1604), "صلاح سالم", "Dorothea Skiles", "بلال - سعيد", "2091715133036057992", "Montserrat", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 1, 2, 14, 29, 55, 832, DateTimeKind.Local).AddTicks(3027), new DateTime(2024, 1, 17, 0, 21, 39, 958, DateTimeKind.Local).AddTicks(6076), "أمجد فؤاد", "Mallie Ferry", "حسن - عراقی", "6951282858577801622", "Timor-Leste", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 16, 18, 12, 54, 343, DateTimeKind.Local).AddTicks(5143), new DateTime(2024, 1, 17, 12, 9, 49, 616, DateTimeKind.Local).AddTicks(2729), "فاروق عارف", "Rafael Bailey", "زيد - عاشور", "1978998011650254922", "Israel", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 8, 20, 5, 51, 56, 994, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 1, 17, 4, 30, 10, 168, DateTimeKind.Local).AddTicks(9001), "فاطمة ربيع", "Wyman Quigley", 0, "عاشور and Sons", "6462662086814191423", "Hungary", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 12, 17, 5, 38, 43, 413, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 1, 17, 13, 23, 41, 975, DateTimeKind.Local).AddTicks(6895), "فريدة عارف", "Mariam Walsh", "صلاح Group", "4985443143467531486", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 1, 1, 4, 53, 25, 18, DateTimeKind.Local).AddTicks(188), new DateTime(2024, 1, 17, 0, 55, 44, 111, DateTimeKind.Local).AddTicks(4634), "صلاح طارق", "Earlene Connelly", 1, "أمجد, فؤاد and عصار", "2180779696196266049", "French Polynesia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 9, 15, 58, 45, 307, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 1, 17, 6, 32, 0, 969, DateTimeKind.Local).AddTicks(303), "عبير بلال", "Rocky Adams", "عارف - فريد", "602672796042395944", "Paraguay", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectionString",
                table: "Tenants");

            migrationBuilder.RenameColumn(
                name: "TID",
                table: "Tenants",
                newName: "CompanyCode");

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

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "TreatmentsHistory",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tenants",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
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
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 64, انواديبو, Japan", "جاردو", new DateTime(2024, 1, 13, 1, 31, 39, 911, DateTimeKind.Local).AddTicks(6587), "rym.farwq@gmail.com", "205-581-2515 x59758" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, طريق یادگار امام, 09, دبا, Peru", "سيان", new DateTime(2024, 1, 13, 11, 57, 4, 482, DateTimeKind.Local).AddTicks(4563), "zynb.zyd50@hotmail.com", "940-478-8786 x72256" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, تقاطع قدس, 045, جد حفص, Swaziland", "المحرق", new DateTime(2024, 1, 13, 10, 58, 37, 703, DateTimeKind.Local).AddTicks(9704), "farwq_asamh@gmail.com", "(614) 241-6657" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق امیرکبیر, 95, كربلاء, Guadeloupe", "بن عروس", new DateTime(2024, 1, 13, 6, 39, 7, 425, DateTimeKind.Local).AddTicks(7735), "fryd_aarf@yahoo.com", "(260) 480-8396" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, 01, القضيمة, Tonga", "سيدي سليمان", new DateTime(2024, 1, 13, 13, 15, 9, 466, DateTimeKind.Local).AddTicks(1309), "rqyh_asar@gmail.com", "850.846.6799" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, طريق راستوان, 52, عين اعبيد, Tunisia", "عفيف", new DateTime(2024, 1, 13, 12, 29, 38, 167, DateTimeKind.Local).AddTicks(8672), "fryd.slah@gmail.com", "972-493-0252" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 434, عفرين, Belarus", "خان شيخون", new DateTime(2024, 1, 13, 13, 37, 39, 133, DateTimeKind.Local).AddTicks(1316), "jabr.tarq@gmail.com", "951.948.0941" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, دوار هویزه, 1, يوبوكي, Hungary", "راس العين", new DateTime(2024, 1, 13, 19, 11, 35, 861, DateTimeKind.Local).AddTicks(7771), "hajr32@yahoo.com", "1-697-498-0968 x75648" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, 587, القرداحة, Austria", "سخنين", new DateTime(2024, 1, 13, 8, 18, 38, 698, DateTimeKind.Local).AddTicks(8376), "zyd.hashm@hotmail.com", "(316) 287-8280" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, 2527, دهبان, Guam", "جحفية", new DateTime(2024, 1, 13, 7, 18, 10, 16, DateTimeKind.Local).AddTicks(2677), "abyr.asamh23@yahoo.com", "1-487-290-1295 x39164" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, 4, إربد, Paraguay", "المالكية", new DateTime(2024, 1, 13, 5, 45, 39, 876, DateTimeKind.Local).AddTicks(4933), "sarh_araqy@gmail.com", "1-775-930-5807" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, شارع دماوند, 2, الفيوم, Turks and Caicos Islands", "زاخو", new DateTime(2024, 1, 13, 22, 4, 26, 732, DateTimeKind.Local).AddTicks(715), "fuad71@gmail.com", "965-478-7410 x6783" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, ش دماوند, 67, منبج, India", "شرورة", new DateTime(2024, 1, 13, 13, 6, 6, 934, DateTimeKind.Local).AddTicks(6692), "rqyh22@yahoo.com", "670.468.5809 x99912" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, 6192, أسوان, Greece", "رداع", new DateTime(2024, 1, 13, 16, 29, 38, 841, DateTimeKind.Local).AddTicks(3274), "hazm_aqyl40@yahoo.com", "572-381-0231" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, تقاطع فاطمی, 5839, قليوب, Svalbard & Jan Mayen Islands", "الدار البيضاء", new DateTime(2024, 1, 13, 14, 11, 49, 419, DateTimeKind.Local).AddTicks(1545), "abyr38@hotmail.com", "(484) 247-0792 x87666" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 61, أم رواب, Belarus", "سبها", new DateTime(2024, 1, 13, 20, 59, 30, 292, DateTimeKind.Local).AddTicks(2410), "frydh99@hotmail.com", "312-740-4158" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش رسالت, طريق رسالت, 1, صلالة, France", "نابلس", new DateTime(2024, 1, 13, 0, 41, 28, 699, DateTimeKind.Local).AddTicks(2165), "fatmh.hashm@hotmail.com", "1-433-497-2197 x1949" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, ش سباری, 03, عكا, Liberia", "نجران", new DateTime(2024, 1, 13, 16, 35, 24, 399, DateTimeKind.Local).AddTicks(9123), "asamh36@yahoo.com", "837.443.9107 x789" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, 885, طرابلس, Vanuatu", "العين", new DateTime(2024, 1, 13, 16, 52, 48, 252, DateTimeKind.Local).AddTicks(9332), "dana_asamh78@hotmail.com", "824-417-9145 x05457" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, طريق اقبال لاهوری, 866, الخرج, Slovakia (Slovak Republic)", "أبو كبير", new DateTime(2024, 1, 13, 1, 19, 23, 817, DateTimeKind.Local).AddTicks(9963), "shymaa70@yahoo.com", "1-267-395-1457" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, تقاطع اقبال لاهوری, 3542, ينبع, Eritrea", "الفلوجة", new DateTime(2024, 1, 13, 18, 5, 22, 652, DateTimeKind.Local).AddTicks(6820), "frydh_amjd@hotmail.com", "1-610-472-8311" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, 5521, تعز, Belize", "جلب", new DateTime(2024, 1, 13, 17, 36, 52, 862, DateTimeKind.Local).AddTicks(7403), "blal20@yahoo.com", "1-586-882-3210" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, تقاطع رسالت, 637, اليوسفية, Burundi", "حلبا", new DateTime(2024, 1, 13, 5, 35, 41, 248, DateTimeKind.Local).AddTicks(9212), "lma97@yahoo.com", "694-713-6425 x13842" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, ميدان شهید مطهری, 6, الدور, Nepal", "الصويرة", new DateTime(2024, 1, 13, 8, 14, 33, 878, DateTimeKind.Local).AddTicks(4620), "salm33@hotmail.com", "565.784.2466 x07189" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, 52, الحسيمة, Trinidad and Tobago", "سيان", new DateTime(2024, 1, 13, 9, 17, 32, 820, DateTimeKind.Local).AddTicks(747), "zynb48@gmail.com", "631-571-9066" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, ميدان قدس, 889, فاس, Ethiopia", "طرابلس", new DateTime(2024, 1, 13, 2, 52, 25, 274, DateTimeKind.Local).AddTicks(4595), "hazm37@gmail.com", "703.294.5410 x286" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, 338, القحطانية, Burundi", "صير بني ياس", new DateTime(2024, 1, 13, 12, 8, 30, 6, DateTimeKind.Local).AddTicks(2527), "hsn_sayd43@hotmail.com", "1-218-248-2375" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 3, الجلفة, Serbia", "مراكش", new DateTime(2024, 1, 14, 0, 26, 32, 219, DateTimeKind.Local).AddTicks(1649), "rym.slah35@yahoo.com", "(445) 506-0692" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, طريق دستغیب, 7876, الرطبة, Guinea-Bissau", "عطبرة", new DateTime(2024, 1, 13, 1, 17, 26, 811, DateTimeKind.Local).AddTicks(9824), "rbya.farwq86@gmail.com", "1-601-466-3636 x59748" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, ش واعظی, 196, خريبة السوق, Jersey", "الجوف", new DateTime(2024, 1, 13, 22, 15, 16, 850, DateTimeKind.Local).AddTicks(6818), "dana79@hotmail.com", "866.272.5984" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, طريق آفریقا, 54, يامبيو, Sao Tome and Principe", "الموصل", new DateTime(2024, 1, 13, 21, 28, 30, 925, DateTimeKind.Local).AddTicks(6524), "blal.salm4@gmail.com", "1-663-341-2088 x6593" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, طريق سمیه, 38, بيشة, Guinea", "نابلس", new DateTime(2024, 1, 13, 23, 38, 29, 947, DateTimeKind.Local).AddTicks(6679), "hazm_iyhab1@gmail.com", "1-782-429-1294 x7441" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, 8989, جحفية, Zimbabwe", "القريات", new DateTime(2024, 1, 13, 5, 13, 4, 513, DateTimeKind.Local).AddTicks(8168), "slah_aashwr@hotmail.com", "562-909-0002" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 9, دورا, Jordan", "الفجيرة", new DateTime(2024, 1, 13, 6, 24, 26, 567, DateTimeKind.Local).AddTicks(6347), "farwq39@yahoo.com", "408-886-0975 x333" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, ميدان سمیه, 0161, ملوى, Bhutan", "يبرود", new DateTime(2024, 1, 13, 7, 54, 53, 380, DateTimeKind.Local).AddTicks(1867), "amjd_araqy@yahoo.com", "546-442-0701 x1634" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اقبال لاهوری, شارع رسالت, 12, أربيل, Russian Federation", "القنيطرة", new DateTime(2024, 1, 13, 5, 31, 51, 676, DateTimeKind.Local).AddTicks(7342), "salm.farwq58@gmail.com", "1-512-777-0981 x278" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, 9, العيون, United States of America", "باقة الغربية", new DateTime(2024, 1, 13, 5, 27, 54, 446, DateTimeKind.Local).AddTicks(2590), "fryd.aadm@yahoo.com", "1-628-390-5105 x7981" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 018, مدنين, Seychelles", "سكاكا", new DateTime(2024, 1, 13, 9, 51, 9, 248, DateTimeKind.Local).AddTicks(219), "fuad_blal23@gmail.com", "250-320-1611" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, دوار دیباجی, 449, العلا, Cambodia", "الدور", new DateTime(2024, 1, 13, 19, 29, 27, 327, DateTimeKind.Local).AddTicks(7904), "asamh84@hotmail.com", "262-935-0958" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, طريق دماوند, 4062, زليطن, New Zealand", "الحجرة", new DateTime(2024, 1, 14, 0, 18, 25, 217, DateTimeKind.Local).AddTicks(9846), "rbya.fuad@gmail.com", "530-245-8424" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, دوار کارگر شمالی, 6100, مقطع لحجار, Moldova", "جاردو", new DateTime(2024, 1, 13, 2, 31, 50, 939, DateTimeKind.Local).AddTicks(7275), "abyr.aarf12@hotmail.com", "(848) 790-3923 x04635" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, شارع آذربایجان, 0204, سترة, Bahrain", "التل", new DateTime(2024, 1, 13, 2, 6, 38, 77, DateTimeKind.Local).AddTicks(1366), "abyr37@hotmail.com", "559.819.9364 x58491" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, 21, البغدادي, Saint Kitts and Nevis", "إدلب", new DateTime(2024, 1, 13, 14, 28, 54, 272, DateTimeKind.Local).AddTicks(8613), "aadm.zyd@gmail.com", "583.663.2375 x537" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, 7, معرة النعمان, Vietnam", "الكاظمية", new DateTime(2024, 1, 13, 7, 42, 8, 149, DateTimeKind.Local).AddTicks(4736), "sarh.tarq@yahoo.com", "454-999-2855" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, طريق کارگر شمالی, 0, صلخد, Mauritania", "البريمي", new DateTime(2024, 1, 13, 20, 34, 24, 329, DateTimeKind.Local).AddTicks(9911), "zynb.asar24@yahoo.com", "208-745-9425" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, ش سمیه, 1121, أطار, Luxembourg", "رفحا", new DateTime(2024, 1, 13, 17, 0, 59, 617, DateTimeKind.Local).AddTicks(9302), "aadm.asamh73@hotmail.com", "819.318.0569" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, شارع ابوذر, 72, الزقازيق, Belize", "أدم", new DateTime(2024, 1, 13, 15, 3, 58, 285, DateTimeKind.Local).AddTicks(2349), "mna30@yahoo.com", "1-899-830-4248 x306" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, 9, بوكادوم, Cambodia", "العيون", new DateTime(2024, 1, 13, 20, 54, 10, 718, DateTimeKind.Local).AddTicks(8211), "amjd_salm@hotmail.com", "972.976.4562 x68161" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, شارع سباری, 6650, خان يونس, South Georgia and the South Sandwich Islands", "دخيل", new DateTime(2024, 1, 13, 7, 26, 38, 873, DateTimeKind.Local).AddTicks(3417), "blal.tarq@yahoo.com", "(566) 282-1183 x9067" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, ميدان دماوند, 9, باب الزوار, Ireland", "الرمادي", new DateTime(2024, 1, 13, 18, 25, 58, 743, DateTimeKind.Local).AddTicks(861), "zyd_zyd73@hotmail.com", "674.339.1427 x948" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, 93, عشرة رمضان, San Marino", "مادبا", new DateTime(2024, 1, 13, 16, 47, 53, 809, DateTimeKind.Local).AddTicks(7596), "frydh2@hotmail.com", "391.972.8765" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, دوار امیرکبیر, 08, أم قصر, Ethiopia", "دسوق", new DateTime(2024, 1, 13, 11, 28, 31, 24, DateTimeKind.Local).AddTicks(6984), "dana_asamh94@hotmail.com", "1-310-271-8084 x91085" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, 8872, صلنفة, Equatorial Guinea", "سيدي بلعباس", new DateTime(2024, 1, 13, 14, 9, 19, 603, DateTimeKind.Local).AddTicks(4600), "zyd.araqy8@hotmail.com", "322.347.9281 x643" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, 953, إب, Finland", "المحرق", new DateTime(2024, 1, 13, 13, 40, 52, 420, DateTimeKind.Local).AddTicks(9705), "aadm_araqy77@gmail.com", "(267) 997-4512 x657" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, ش استاد قریب, 154, العيينة, Moldova", "الأتارب", new DateTime(2024, 1, 13, 12, 6, 36, 127, DateTimeKind.Local).AddTicks(4366), "hsn.iyhab48@yahoo.com", "1-444-222-9995" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 7367, جيجل, Cook Islands", "سوق أهراس", new DateTime(2024, 1, 13, 5, 45, 55, 500, DateTimeKind.Local).AddTicks(8274), "frydh.hsn@hotmail.com", "(734) 729-2986 x328" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, 40, أسفي, Croatia", "كفرشوبا", new DateTime(2024, 1, 13, 5, 7, 5, 72, DateTimeKind.Local).AddTicks(4558), "mna.fuad32@gmail.com", "509.281.4963 x600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, 166, دخيل, San Marino", "القطيف", new DateTime(2024, 1, 14, 0, 4, 40, 149, DateTimeKind.Local).AddTicks(1736), "zynb98@hotmail.com", "200-549-3076 x89398" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, طريق یادگار امام, 9021, سيلبابي, Turks and Caicos Islands", "الكسوة", new DateTime(2024, 1, 13, 6, 8, 9, 113, DateTimeKind.Local).AddTicks(7866), "shymaa.amjd@yahoo.com", "594.563.1098 x9403" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, 34, قسنطينة, Madagascar", "الزقازيق", new DateTime(2024, 1, 13, 22, 49, 37, 65, DateTimeKind.Local).AddTicks(5633), "zyd_fryd53@hotmail.com", "901-685-2611 x258" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, 2332, القريات, Sao Tome and Principe", "البريمي", new DateTime(2024, 1, 13, 22, 51, 44, 479, DateTimeKind.Local).AddTicks(5245), "fatmh.hashm@gmail.com", "1-480-743-2849 x06586" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, ش آزادی, 9155, الإسماعيلية, Cambodia", "أبو ظبي", new DateTime(2024, 1, 13, 20, 32, 2, 15, DateTimeKind.Local).AddTicks(7292), "zynb21@gmail.com", "(527) 800-4151 x0718" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 36, مقطع لحجار, Sri Lanka", "جت", new DateTime(2024, 1, 13, 3, 26, 10, 397, DateTimeKind.Local).AddTicks(7307), "hajr_zyd@yahoo.com", "1-289-822-5993 x63702" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 169, الجديدة, Saint Helena", "دير البلح", new DateTime(2024, 1, 13, 3, 46, 58, 789, DateTimeKind.Local).AddTicks(9594), "lma.iyhab@hotmail.com", "623-616-5284 x3380" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, شارع ابوذر, 23, أبو كمال, Mauritania", "العين", new DateTime(2024, 1, 13, 5, 46, 23, 399, DateTimeKind.Local).AddTicks(740), "amjd12@gmail.com", "351-848-4009" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, طريق دیباجی, 32, أسيوط, Grenada", "باتنة", new DateTime(2024, 1, 13, 5, 5, 21, 689, DateTimeKind.Local).AddTicks(5613), "jabr.aashwr@hotmail.com", "1-555-544-4201 x87423" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, دوار هویزه, 339, بلد, Nigeria", "مدينة الحرير", new DateTime(2024, 1, 13, 22, 46, 50, 57, DateTimeKind.Local).AddTicks(3141), "jmanh_asamh@gmail.com", "(301) 729-7791" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, تقاطع یادگار امام, 61, السليمانية, Portugal", "العيينة", new DateTime(2024, 1, 13, 18, 12, 30, 937, DateTimeKind.Local).AddTicks(8012), "zyd_aarf@gmail.com", "1-915-532-5090" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 6, سلفيت, Thailand", "صلخد", new DateTime(2024, 1, 13, 11, 23, 48, 450, DateTimeKind.Local).AddTicks(8759), "hazm_salm@hotmail.com", "654-892-8558" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, ميدان شهید مطهری, 390, المالكية, Philippines", "السويق", new DateTime(2024, 1, 13, 21, 22, 40, 69, DateTimeKind.Local).AddTicks(4737), "jabr57@gmail.com", "1-346-375-6296" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, شارع سمیه, 290, دهبان, Pitcairn Islands", "جرسيف", new DateTime(2024, 1, 13, 7, 47, 3, 822, DateTimeKind.Local).AddTicks(5627), "blal.araqy@gmail.com", "638.280.3299 x9923" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 6, عقوبة, Martinique", "التل", new DateTime(2024, 1, 13, 17, 39, 34, 447, DateTimeKind.Local).AddTicks(3738), "fuad.asamh36@gmail.com", "1-312-861-4914 x82402" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 2490, القبة, Nauru", "صلخد", new DateTime(2024, 1, 13, 20, 34, 51, 69, DateTimeKind.Local).AddTicks(7425), "abyr.jabr71@hotmail.com", "602-838-0883" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, دوار استاد قریب, 531, باب الزوار, Iran", "طرعان", new DateTime(2024, 1, 13, 2, 45, 14, 747, DateTimeKind.Local).AddTicks(2149), "aadm43@hotmail.com", "1-459-361-1927" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, تقاطع سمیه, 05, مقطع لحجار, Burundi", "سيدي قاسم", new DateTime(2024, 1, 13, 13, 5, 54, 449, DateTimeKind.Local).AddTicks(3005), "slah.aashwr44@gmail.com", "599.613.6846" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, ميدان فاطمی, 7, الخرطوم, Niue", "غرداية", new DateTime(2024, 1, 13, 23, 27, 11, 329, DateTimeKind.Local).AddTicks(2881), "rbya.aashwr@yahoo.com", "581.590.2397 x94293" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, طريق واعظی, 16, عفرين, American Samoa", "ينبع", new DateTime(2024, 1, 13, 12, 9, 21, 375, DateTimeKind.Local).AddTicks(8713), "sayd.jabr@hotmail.com", "(726) 362-1860" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, شارع اجاره دار, 1, الجش, Israel", "تل كيف", new DateTime(2024, 1, 13, 13, 8, 58, 385, DateTimeKind.Local).AddTicks(9655), "slah.slah64@gmail.com", "1-750-571-8872 x3402" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, دوار فاطمی, 5, الطينطان, Germany", "الدمام", new DateTime(2024, 1, 14, 0, 0, 58, 965, DateTimeKind.Local).AddTicks(5383), "sayd.salm42@yahoo.com", "(487) 479-5759 x444" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 7, اللد, American Samoa", "مسعد", new DateTime(2024, 1, 13, 15, 51, 19, 957, DateTimeKind.Local).AddTicks(4856), "fryd.marwf@gmail.com", "(895) 457-9788 x5658" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, 2, أدم, Bulgaria", "تقورت", new DateTime(2024, 1, 13, 6, 6, 56, 881, DateTimeKind.Local).AddTicks(4777), "fryd1@hotmail.com", "211-562-3720" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 1, ازويرات, Mali", "عفرين", new DateTime(2024, 1, 13, 18, 35, 48, 586, DateTimeKind.Local).AddTicks(43), "abyr.salm@hotmail.com", "640-673-4294 x846" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, 157, جاردو, Gibraltar", "كربلاء", new DateTime(2024, 1, 13, 14, 46, 44, 418, DateTimeKind.Local).AddTicks(4116), "rbya_hsn@hotmail.com", "988.677.3022 x4843" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, طريق اجاره دار, 3, الفاشر, Saint Pierre and Miquelon", "بوكادوم", new DateTime(2024, 1, 13, 13, 16, 0, 111, DateTimeKind.Local).AddTicks(6526), "lma.zyd@hotmail.com", "315-763-0038" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, شارع سمیه, 814, صلنفة, Antarctica (the territory South of 60 deg S)", "عكا", new DateTime(2024, 1, 13, 12, 45, 35, 85, DateTimeKind.Local).AddTicks(7700), "hsn.aarf@gmail.com", "825-751-2399 x96485" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, ش ابوذر, 8, الرستن, Iceland", "الأغواط", new DateTime(2024, 1, 13, 0, 53, 50, 573, DateTimeKind.Local).AddTicks(2437), "aayh_rbya@hotmail.com", "914-499-3905" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, 9913, بركان, Burundi", "خريبكة", new DateTime(2024, 1, 13, 10, 18, 40, 504, DateTimeKind.Local).AddTicks(6091), "mna_farwq59@gmail.com", "302.930.3428 x884" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, تقاطع آذربایجان, 1, جحفية, Ukraine", "عين البيضاء", new DateTime(2024, 1, 13, 4, 2, 39, 266, DateTimeKind.Local).AddTicks(738), "zyd.hashm40@gmail.com", "988.901.5685" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, دوار اجاره دار, 8, عين العرب, Italy", "السويداء", new DateTime(2024, 1, 13, 3, 55, 41, 785, DateTimeKind.Local).AddTicks(7821), "tarq_farwq87@gmail.com", "874-406-0720" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, 3, ريسوت, Western Sahara", "بور سعيد", new DateTime(2024, 1, 13, 11, 40, 10, 545, DateTimeKind.Local).AddTicks(5403), "zynb_blal31@hotmail.com", "984.397.7270 x968" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, تقاطع سمیه, 52, العزيزية, Isle of Man", "مدينة ستة أكتوبر", new DateTime(2024, 1, 13, 2, 20, 17, 510, DateTimeKind.Local).AddTicks(1194), "tarq.marwf8@hotmail.com", "352.707.9034" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, 8546, الجيزة, Virgin Islands, U.S.", "الرمادي", new DateTime(2024, 1, 13, 22, 5, 9, 159, DateTimeKind.Local).AddTicks(239), "salm.fryd@gmail.com", "1-853-697-0885" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, شارع ابوذر, 6105, ولاتة, Costa Rica", "اكجوجت", new DateTime(2024, 1, 13, 14, 14, 18, 291, DateTimeKind.Local).AddTicks(3166), "lma69@hotmail.com", "1-837-685-3057" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, شارع سباری, 18, الخمس, Palau", "غرداية", new DateTime(2024, 1, 13, 17, 15, 38, 163, DateTimeKind.Local).AddTicks(1715), "farwq62@yahoo.com", "882-398-1902" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اقبال لاهوری, ش آذربایجان, 1, أوبوك, Brazil", "الدقم", new DateTime(2024, 1, 14, 0, 31, 16, 194, DateTimeKind.Local).AddTicks(6700), "amjd16@hotmail.com", "941-235-9465 x28380" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, دوار کارگر شمالی, 416, هيت, Armenia", "أسفي", new DateTime(2024, 1, 13, 10, 44, 4, 184, DateTimeKind.Local).AddTicks(4722), "rna_aadm26@hotmail.com", "692-792-5977 x36069" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, 4933, خنشلة, Angola", "شيبه", new DateTime(2024, 1, 13, 4, 25, 18, 991, DateTimeKind.Local).AddTicks(9648), "iyhab60@gmail.com", "336.247.0303 x354" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, ميدان واعظی, 66, خنيفرة, Panama", "دمازين", new DateTime(2024, 1, 13, 18, 17, 14, 148, DateTimeKind.Local).AddTicks(5415), "rna36@hotmail.com", "672.741.5394 x186" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان امیرکبیر, 8532, حلبا, Turkey", "خريبكة", new DateTime(2024, 1, 13, 6, 59, 28, 611, DateTimeKind.Local).AddTicks(6541), "zyd.amjd@yahoo.com", "(913) 861-0792" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, طريق دیباجی, 151, قرية سار, Malta", "خنيفرة", new DateTime(2024, 1, 13, 18, 31, 32, 112, DateTimeKind.Local).AddTicks(8619), "shymaa.salm50@hotmail.com", "575.543.9174" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, 622, مدينة الملك عبد الله الاقتصادية, Mongolia", "الحوامدية", new DateTime(2024, 1, 13, 9, 25, 42, 549, DateTimeKind.Local).AddTicks(2741), "mna.aashwr61@gmail.com", "(977) 676-6897 x8459" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, تقاطع موحد دانش, 2, النهود, Senegal", "سرت", new DateTime(2024, 1, 14, 0, 30, 35, 656, DateTimeKind.Local).AddTicks(1766), "frydh72@gmail.com", "(219) 235-6542" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, 891, رداع, Libyan Arab Jamahiriya", "مراكش", new DateTime(2024, 1, 13, 18, 57, 1, 693, DateTimeKind.Local).AddTicks(5866), "dana_sayd@hotmail.com", "901.317.8364" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, ش دماوند, 5, العيون, Ireland", "أرتا", new DateTime(2024, 1, 13, 19, 51, 16, 752, DateTimeKind.Local).AddTicks(7748), "iynas_hashm42@gmail.com", "1-809-736-8090 x89918" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, 2992, السويق, Dominican Republic", "صفرو", new DateTime(2024, 1, 13, 12, 1, 20, 180, DateTimeKind.Local).AddTicks(780), "rym.aadm@hotmail.com", "240.800.1536" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 575, الشوف, Bhutan", "سيدي سليمان", new DateTime(2024, 1, 13, 6, 53, 43, 420, DateTimeKind.Local).AddTicks(8418), "jmanh_iyhab27@yahoo.com", "948-235-2432 x3949" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, ش مالک اشتر, 63, الفلوجة, Denmark", "بوكادوم", new DateTime(2024, 1, 13, 6, 25, 31, 204, DateTimeKind.Local).AddTicks(1519), "jmanh_hazm94@hotmail.com", "715.796.4056 x531" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, 5780, حديثة, Lebanon", "أسوان", new DateTime(2024, 1, 14, 0, 11, 26, 942, DateTimeKind.Local).AddTicks(2903), "mna50@hotmail.com", "999-805-2967 x62002" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, 5, اللد, Dominican Republic", "جرابلس", new DateTime(2024, 1, 13, 23, 32, 49, 593, DateTimeKind.Local).AddTicks(1140), "dana_iyhab@yahoo.com", "798.334.4334 x7707" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 31, حقل, Papua New Guinea", "القريات", new DateTime(2024, 1, 13, 2, 59, 25, 172, DateTimeKind.Local).AddTicks(2517), "mna3@hotmail.com", "1-330-802-1519 x09188" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, ش مالک اشتر, 7, كفر الدوار, China", "نواكشوط", new DateTime(2024, 1, 13, 14, 33, 3, 701, DateTimeKind.Local).AddTicks(5981), "slah.azyz@gmail.com", "627.316.8348 x202" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 5, بجاية, Chile", "مطرح", new DateTime(2024, 1, 13, 23, 33, 13, 20, DateTimeKind.Local).AddTicks(1691), "rbya_asamh10@gmail.com", "1-740-236-6068 x1848" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, 9009, الجلفة, Cape Verde", "الشحر", new DateTime(2024, 1, 13, 1, 59, 41, 49, DateTimeKind.Local).AddTicks(1011), "lma_aadm@yahoo.com", "(670) 625-6601" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 8, بقيق, Colombia", "العين", new DateTime(2024, 1, 13, 3, 24, 2, 326, DateTimeKind.Local).AddTicks(2144), "tarq.slah@hotmail.com", "705-943-3811 x214" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, ميدان آفریقا, 68, قابس, Serbia", "حوطة بني تميم", new DateTime(2024, 1, 13, 19, 51, 59, 682, DateTimeKind.Local).AddTicks(5514), "hazm18@hotmail.com", "927-579-6583" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, شارع امیرکبیر, 3717, جرسيف, Azerbaijan", "سوق أهراس", new DateTime(2024, 1, 13, 8, 45, 12, 952, DateTimeKind.Local).AddTicks(5427), "fuad_araqy99@hotmail.com", "878.813.8496" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, 1058, السويس, Bolivia", "الرس", new DateTime(2024, 1, 13, 14, 22, 26, 431, DateTimeKind.Local).AddTicks(2321), "lma_tarq@hotmail.com", "1-294-856-8516 x75449" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دیباجی, شارع واعظی, 266, صحم, Solomon Islands", "الكسوة", new DateTime(2024, 1, 13, 17, 15, 4, 184, DateTimeKind.Local).AddTicks(1866), "salm15@gmail.com", "(286) 501-7232 x6954" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, ش راستوان, 15, عقوبة, Faroe Islands", "خان يونس", new DateTime(2024, 1, 13, 13, 29, 58, 304, DateTimeKind.Local).AddTicks(5306), "dana.zyd49@hotmail.com", "491-728-6397 x02941" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 758, البيضاء, Lithuania", "مادبا", new DateTime(2024, 1, 13, 20, 22, 37, 357, DateTimeKind.Local).AddTicks(9018), "fryd_hazm96@yahoo.com", "(497) 282-7267" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, 371, يبرود, Cambodia", "وجدة", new DateTime(2024, 1, 13, 14, 40, 4, 266, DateTimeKind.Local).AddTicks(5371), "rbya_sayd@yahoo.com", "(443) 789-5519" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, 63, يافا, Bhutan", "بور سعيد", new DateTime(2024, 1, 13, 23, 39, 33, 790, DateTimeKind.Local).AddTicks(6483), "rym_slah@yahoo.com", "(603) 590-8627 x775" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, شارع دستغیب, 5, الوادي, Timor-Leste", "أسيوط", new DateTime(2024, 1, 13, 18, 24, 17, 126, DateTimeKind.Local).AddTicks(7703), "arwa_amjd@hotmail.com", "265-621-8922" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, ميدان سباری, 9376, أسيلا, Cape Verde", "كسماوي", new DateTime(2024, 1, 13, 7, 33, 20, 945, DateTimeKind.Local).AddTicks(7108), "sayd_aadm7@hotmail.com", "(413) 443-9642" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, طريق امیرکبیر, 1356, الناصرة, Grenada", "برج الكيفان", new DateTime(2024, 1, 13, 2, 16, 40, 489, DateTimeKind.Local).AddTicks(3183), "sarh.salm@gmail.com", "492.668.0846 x553" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, طريق آذربایجان, 6722, الخرج, Bouvet Island (Bouvetoya)", "بيت لحم", new DateTime(2024, 1, 13, 14, 1, 40, 227, DateTimeKind.Local).AddTicks(1206), "rqyh_sayd6@yahoo.com", "1-549-774-3276 x59571" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, 6964, الدور, Aruba", "البديع", new DateTime(2024, 1, 13, 1, 57, 26, 906, DateTimeKind.Local).AddTicks(5511), "sarh28@yahoo.com", "798.643.5934 x28904" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, ش حقانی, 7233, تيارت, Guadeloupe", "درنة", new DateTime(2024, 1, 13, 17, 2, 36, 480, DateTimeKind.Local).AddTicks(6976), "rna_asar@yahoo.com", "(467) 332-3142" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 7224, سطات, Antarctica (the territory South of 60 deg S)", "بابابى", new DateTime(2024, 1, 13, 7, 11, 20, 675, DateTimeKind.Local).AddTicks(42), "hajr49@gmail.com", "(852) 563-8315" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, طريق یادگار امام, 10, بو سعادة, Guinea", "الدور", new DateTime(2024, 1, 13, 15, 43, 57, 376, DateTimeKind.Local).AddTicks(3803), "fatmh.fuad15@gmail.com", "1-800-613-0885" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, 801, السويس, Guyana", "حيفا", new DateTime(2024, 1, 13, 20, 7, 48, 145, DateTimeKind.Local).AddTicks(1486), "aadm.tarq@hotmail.com", "950.544.8874 x793" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, 55, ضرما, Cook Islands", "القدس", new DateTime(2024, 1, 14, 0, 24, 7, 425, DateTimeKind.Local).AddTicks(4506), "fatmh_amjd54@yahoo.com", "617-581-9074" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, طريق دیباجی, 9, الوكرة, Tuvalu", "الدقم", new DateTime(2024, 1, 13, 16, 18, 23, 585, DateTimeKind.Local).AddTicks(9057), "amjd.blal@hotmail.com", "981.968.4699 x367" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, ميدان اقبال لاهوری, 335, قالمة, British Indian Ocean Territory (Chagos Archipelago)", "صحم", new DateTime(2024, 1, 13, 4, 43, 3, 808, DateTimeKind.Local).AddTicks(34), "tarq.asar@yahoo.com", "551-935-7591 x30433" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, 658, كفرشوبا, French Polynesia", "ازرع", new DateTime(2024, 1, 13, 15, 18, 27, 929, DateTimeKind.Local).AddTicks(9373), "iyhab87@hotmail.com", "1-445-934-2400 x29179" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, 17, ريان, Thailand", "كركوك", new DateTime(2024, 1, 13, 7, 49, 8, 467, DateTimeKind.Local).AddTicks(1839), "jabr.asamh@gmail.com", "687-625-2716 x617" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, دوار ابوذر, 43, المحرق, Pitcairn Islands", "الفنيدق", new DateTime(2024, 1, 13, 14, 24, 26, 29, DateTimeKind.Local).AddTicks(6052), "amjd_hazm18@hotmail.com", "(324) 984-2597 x15296" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, ميدان دستغیب, 94, ازرع, Colombia", "السيب", new DateTime(2024, 1, 13, 6, 29, 39, 481, DateTimeKind.Local).AddTicks(4584), "iynas_slah@gmail.com", "1-373-429-7463" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 8024, الشوف, Antarctica (the territory South of 60 deg S)", "شمسطار", new DateTime(2024, 1, 13, 6, 26, 27, 41, DateTimeKind.Local).AddTicks(6370), "mna_amjd12@yahoo.com", "1-691-720-1874" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 1, منبج, Dominica", "ودمدني", new DateTime(2024, 1, 13, 2, 18, 24, 948, DateTimeKind.Local).AddTicks(4218), "hajr_blal34@gmail.com", "560-769-2168 x37327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, 6857, زلفي, Azerbaijan", "الأبيض", new DateTime(2024, 1, 13, 13, 14, 54, 194, DateTimeKind.Local).AddTicks(806), "hazm.aqyl69@hotmail.com", "1-302-697-3456 x047" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, ش اجاره دار, 411, مراكش, Vanuatu", "ملوى", new DateTime(2024, 1, 13, 21, 24, 6, 509, DateTimeKind.Local).AddTicks(8733), "arwa.araqy8@hotmail.com", "378-524-4153 x32541" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 605, الباب, Namibia", "كربلاء", new DateTime(2024, 1, 13, 11, 11, 45, 677, DateTimeKind.Local).AddTicks(5755), "farwq20@gmail.com", "946.255.3132" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, 234, ريسوت, Cocos (Keeling) Islands", "البديع", new DateTime(2024, 1, 13, 5, 19, 7, 534, DateTimeKind.Local).AddTicks(9181), "dana_iyhab@hotmail.com", "1-604-845-3095 x351" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, ش قدس, 9379, عدن, Pitcairn Islands", "مراكش", new DateTime(2024, 1, 13, 23, 43, 28, 388, DateTimeKind.Local).AddTicks(7471), "rqyh95@hotmail.com", "(295) 952-2680 x3556" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, طريق امیرکبیر, 757, طبرق, Isle of Man", "تنومة", new DateTime(2024, 1, 13, 20, 19, 59, 483, DateTimeKind.Local).AddTicks(1834), "fryd.araqy@yahoo.com", "411.399.8354 x3510" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, تقاطع راستوان, 22, وادي الدواسر, Croatia", "المالكية", new DateTime(2024, 1, 13, 1, 55, 14, 337, DateTimeKind.Local).AddTicks(722), "sayd.marwf93@gmail.com", "322.843.4498 x46288" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, شارع مالک اشتر, 570, ازرع, Timor-Leste", "قسنطينة", new DateTime(2024, 1, 13, 5, 31, 39, 833, DateTimeKind.Local).AddTicks(9048), "hajr.aashwr50@hotmail.com", "411.394.0509" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, 9, تلمسان, Senegal", "مصياف", new DateTime(2024, 1, 13, 19, 29, 14, 160, DateTimeKind.Local).AddTicks(6501), "iynas.aadm@gmail.com", "269.290.8763" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, تقاطع حقانی, 2288, جد حفص, Samoa", "الرملة", new DateTime(2024, 1, 13, 13, 27, 54, 219, DateTimeKind.Local).AddTicks(4141), "aadm33@hotmail.com", "266-958-4443 x79806" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 941, صلالة, Mayotte", "سخنين", new DateTime(2024, 1, 13, 2, 36, 41, 222, DateTimeKind.Local).AddTicks(6372), "rym_aarf@gmail.com", "1-879-798-9595 x8566" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع مالک اشتر, 0574, مكة المكرمة, Guyana", "الدوادمي", new DateTime(2024, 1, 13, 13, 52, 39, 297, DateTimeKind.Local).AddTicks(9738), "jabr_fryd97@hotmail.com", "900-597-7064 x018" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, 2, لوك, Netherlands Antilles", "بعبدا", new DateTime(2024, 1, 13, 5, 0, 8, 922, DateTimeKind.Local).AddTicks(6705), "lma_tarq@yahoo.com", "588.601.3175" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, 51, بيت الفقيه, Martinique", "بغداد", new DateTime(2024, 1, 13, 1, 34, 10, 809, DateTimeKind.Local).AddTicks(5611), "rym_tarq82@hotmail.com", "735-682-5707 x09977" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, 94, النجف, Niger", "الجفر", new DateTime(2024, 1, 13, 22, 39, 17, 631, DateTimeKind.Local).AddTicks(4303), "hsn.fuad91@hotmail.com", "(424) 734-7098 x0094" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, 1687, المقدادية, Central African Republic", "طانطان", new DateTime(2024, 1, 13, 7, 8, 31, 136, DateTimeKind.Local).AddTicks(5096), "tarq_hsn@hotmail.com", "1-308-710-7573 x709" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع استاد قریب, 0, بغداد, Vanuatu", "نيالا", new DateTime(2024, 1, 13, 5, 15, 36, 836, DateTimeKind.Local).AddTicks(9194), "salm30@hotmail.com", "347-676-4492 x860" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, طريق هویزه, 82, رأس لفان, Angola", "بعبدا", new DateTime(2024, 1, 13, 4, 18, 54, 779, DateTimeKind.Local).AddTicks(4926), "sarh39@yahoo.com", "1-591-777-6548 x41021" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 6, قنا, French Polynesia", "السيب", new DateTime(2024, 1, 13, 9, 20, 41, 540, DateTimeKind.Local).AddTicks(2668), "rqyh.araqy@gmail.com", "373.218.1125 x840" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, شارع راستوان, 9, برج الكيفان, Paraguay", "حلبا", new DateTime(2024, 1, 13, 10, 46, 21, 354, DateTimeKind.Local).AddTicks(9563), "fryd66@gmail.com", "744-292-2063 x724" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, شارع سمیه, 9, جرسيف, Bahrain", "الجلفة", new DateTime(2024, 1, 13, 18, 19, 31, 165, DateTimeKind.Local).AddTicks(3781), "iyhab_sayd@hotmail.com", "419-248-0296 x4924" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, ميدان شهید مطهری, 418, الجوف, Northern Mariana Islands", "جد حفص", new DateTime(2024, 1, 13, 7, 15, 5, 849, DateTimeKind.Local).AddTicks(8513), "aadm90@yahoo.com", "412-331-9910 x8873" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, 232, بريكة, Comoros", "مقديشو", new DateTime(2024, 1, 13, 17, 42, 36, 174, DateTimeKind.Local).AddTicks(1765), "asamh_araqy6@yahoo.com", "1-907-913-2644" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق استاد قریب, 35, الرمثا, Saint Helena", "جرش", new DateTime(2024, 1, 13, 6, 29, 44, 64, DateTimeKind.Local).AddTicks(6233), "hsn1@gmail.com", "(981) 619-5369 x4624" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, 408, الحسيمة, Lesotho", "أبو كمال", new DateTime(2024, 1, 13, 19, 39, 48, 998, DateTimeKind.Local).AddTicks(6206), "sarh8@gmail.com", "(599) 380-1900 x527" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 63, مصياف, Mexico", "زوارة", new DateTime(2024, 1, 13, 8, 10, 29, 623, DateTimeKind.Local).AddTicks(5068), "aadm_sayd62@hotmail.com", "(809) 404-8957 x67270" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, طريق فاطمی, 013, أم درمان, Turkey", "نابل", new DateTime(2024, 1, 13, 21, 20, 19, 588, DateTimeKind.Local).AddTicks(8128), "hazm.hsn2@hotmail.com", "487-614-8742 x15233" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, تقاطع یادگار امام, 100, بنغازي, Zambia", "الشارقة", new DateTime(2024, 1, 13, 2, 5, 24, 253, DateTimeKind.Local).AddTicks(1911), "iynas.asar@gmail.com", "762.854.5694 x81457" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, 5483, اللاذقية, Falkland Islands (Malvinas)", "التل", new DateTime(2024, 1, 13, 9, 24, 10, 835, DateTimeKind.Local).AddTicks(4503), "arwa.azyz92@gmail.com", "1-299-941-4097" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, 8, الليث, India", "الجيزة", new DateTime(2024, 1, 13, 2, 22, 1, 22, DateTimeKind.Local).AddTicks(3146), "jmanh.aqyl7@yahoo.com", "834.686.3266 x6487" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, ش مالک اشتر, 70, حجة, Saint Lucia", "مسيعيد", new DateTime(2024, 1, 13, 18, 26, 11, 838, DateTimeKind.Local).AddTicks(1622), "rbya_fryd27@gmail.com", "1-565-521-4892 x792" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, دوار دکتر چمران, 6, سطات, Madagascar", "النماص", new DateTime(2024, 1, 13, 3, 10, 4, 400, DateTimeKind.Local).AddTicks(9272), "iyhab_rbya83@hotmail.com", "414-632-8500" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, شارع موحد دانش, 44, مقديشو, Turkey", "وجدة", new DateTime(2024, 1, 13, 21, 21, 16, 838, DateTimeKind.Local).AddTicks(6638), "hajr_hsn@yahoo.com", "992.589.4856 x022" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, 57, وادي حلفا, Belize", "كسلا", new DateTime(2024, 1, 13, 2, 10, 10, 398, DateTimeKind.Local).AddTicks(1718), "arwa_sayd62@hotmail.com", "766-690-1453 x15200" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, 35, السماوة, Uganda", "منح", new DateTime(2024, 1, 13, 6, 25, 13, 343, DateTimeKind.Local).AddTicks(9424), "rym.farwq@gmail.com", "578.840.9487 x5795" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, 67, بو سعادة, Luxembourg", "جدة", new DateTime(2024, 1, 13, 9, 49, 38, 983, DateTimeKind.Local).AddTicks(3566), "salm.blal@yahoo.com", "(703) 349-5772" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, 6, كركوك, French Polynesia", "الرطبة", new DateTime(2024, 1, 13, 10, 3, 18, 677, DateTimeKind.Local).AddTicks(2290), "mna.slah@hotmail.com", "(380) 745-4919" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, دوار شهید مطهری, 07, مرزق, Zimbabwe", "كفر الشيخ", new DateTime(2024, 1, 13, 15, 13, 6, 192, DateTimeKind.Local).AddTicks(4991), "sayd_aqyl@gmail.com", "567.383.7183" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, دوار دکتر چمران, 3842, المحلة الكبرى, South Africa", "ورزازات", new DateTime(2024, 1, 13, 16, 39, 52, 693, DateTimeKind.Local).AddTicks(2317), "frydh.amjd@hotmail.com", "403-532-6716" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, شارع مالک اشتر, 81, بالهو, Saint Martin", "أم القيوين", new DateTime(2024, 1, 13, 3, 9, 3, 315, DateTimeKind.Local).AddTicks(7911), "fuad.rbya35@yahoo.com", "349.302.9805 x6247" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اقبال لاهوری, 3, سنجة, Jamaica", "حجة", new DateTime(2024, 1, 13, 7, 44, 48, 329, DateTimeKind.Local).AddTicks(4477), "rna.araqy66@hotmail.com", "1-210-591-0724 x60504" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, دوار دستغیب, 48, ودمدني, Palestinian Territory", "جلب", new DateTime(2024, 1, 13, 19, 5, 11, 156, DateTimeKind.Local).AddTicks(9182), "jmanh73@gmail.com", "1-492-236-0646 x421" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, 87, صفرو, Sao Tome and Principe", "قرية سار", new DateTime(2024, 1, 13, 19, 5, 33, 506, DateTimeKind.Local).AddTicks(2103), "jabr_slah76@gmail.com", "302-469-6612" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, 8774, الدامور, Bhutan", "تزنيت", new DateTime(2024, 1, 13, 12, 31, 5, 793, DateTimeKind.Local).AddTicks(8715), "rna_fryd48@hotmail.com", "530-325-3384 x214" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, طريق سباری, 21, تبسة, Cook Islands", "هيت", new DateTime(2024, 1, 13, 2, 46, 38, 7, DateTimeKind.Local).AddTicks(7114), "lma_rbya35@yahoo.com", "223.472.0196 x542" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, 47, أسفي, Nigeria", "حائل", new DateTime(2024, 1, 13, 21, 40, 42, 740, DateTimeKind.Local).AddTicks(7852), "sarh37@yahoo.com", "1-928-695-4613" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 8517, الرمثا, Saint Martin", "وادي حلفا", new DateTime(2024, 1, 13, 16, 19, 53, 993, DateTimeKind.Local).AddTicks(7154), "frydh62@hotmail.com", "1-432-559-7496 x965" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, تقاطع موحد دانش, 8496, القصر الكبير, French Guiana", "سوق أهراس", new DateTime(2024, 1, 13, 3, 25, 22, 684, DateTimeKind.Local).AddTicks(6477), "mna14@yahoo.com", "904-688-0664 x868" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, دوار دکتر چمران, 058, وجدة, Montserrat", "حيفا", new DateTime(2024, 1, 13, 19, 24, 32, 23, DateTimeKind.Local).AddTicks(7001), "hajr_aarf50@hotmail.com", "889.486.5124" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دستغیب, ش راستوان, 455, الحسيمة, Bosnia and Herzegovina", "بنغازي", new DateTime(2024, 1, 13, 6, 56, 42, 814, DateTimeKind.Local).AddTicks(2647), "asamh5@hotmail.com", "1-857-925-3352" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, 13, العيون, Jersey", "وجدة", new DateTime(2024, 1, 13, 13, 16, 10, 892, DateTimeKind.Local).AddTicks(4107), "frydh_amjd25@hotmail.com", "(872) 802-8746 x05407" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, 3, تنومة, Bahrain", "مدينة الصدر", new DateTime(2024, 1, 13, 6, 33, 50, 11, DateTimeKind.Local).AddTicks(9260), "salm.aarf@gmail.com", "1-539-928-7011" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اقبال لاهوری, ميدان موحد دانش, 8072, الجفر, Bahrain", "مكة المكرمة", new DateTime(2024, 1, 13, 22, 25, 6, 59, DateTimeKind.Local).AddTicks(4552), "fryd56@yahoo.com", "298-895-0678" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, 4, وزان, Mali", "سرت", new DateTime(2024, 1, 13, 5, 59, 18, 579, DateTimeKind.Local).AddTicks(8170), "sayd.slah91@yahoo.com", "478-800-6696" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, دوار یادگار امام, 9563, السيب, Virgin Islands, U.S.", "ورقلة", new DateTime(2024, 1, 13, 5, 52, 59, 664, DateTimeKind.Local).AddTicks(8030), "arwa.asamh@hotmail.com", "1-666-798-7272" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, ش واعظی, 91, أسوان, Jamaica", "نجران", new DateTime(2024, 1, 13, 9, 28, 34, 558, DateTimeKind.Local).AddTicks(6811), "iynas94@gmail.com", "(649) 561-4239" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دستغیب, دوار حقانی, 7440, المناقل, Kiribati", "ريان", new DateTime(2024, 1, 13, 20, 33, 18, 230, DateTimeKind.Local).AddTicks(9848), "blal34@hotmail.com", "1-356-770-9510" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, دوار اقبال لاهوری, 273, العيون, Denmark", "الباحة", new DateTime(2024, 1, 13, 19, 46, 47, 953, DateTimeKind.Local).AddTicks(9711), "jmanh.sayd80@hotmail.com", "1-924-613-6102 x190" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, 314, نجران, Rwanda", "المرسى", new DateTime(2024, 1, 13, 12, 59, 1, 61, DateTimeKind.Local).AddTicks(4274), "mna0@yahoo.com", "700-205-2837 x302" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, 34, بنجرير, Singapore", "تعز", new DateTime(2024, 1, 13, 3, 47, 20, 402, DateTimeKind.Local).AddTicks(2717), "salm_slah93@gmail.com", "1-257-551-6905 x09605" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 4, 11, 4, 51, 8, 141, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 1, 13, 2, 8, 50, 105, DateTimeKind.Local).AddTicks(2882), "رقية حازم", "William Turner", 1, "إيهاب Inc", "5625301546257731677", "Ethiopia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 6, 4, 5, 27, 50, 67, DateTimeKind.Local).AddTicks(2635), new DateTime(2024, 1, 13, 21, 6, 42, 364, DateTimeKind.Local).AddTicks(9263), "ربيع إيهاب", "Myra Simonis", 1, "طارق, عصار and عاشور", "5395903632433384261", "Cocos (Keeling) Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 2, 11, 15, 8, 35, 909, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 1, 13, 9, 51, 15, 879, DateTimeKind.Local).AddTicks(7903), "سعيد إيهاب", "Johathan Nader", 0, "سعيد - هاشم", "5486335178309391862", "Ethiopia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 7, 1, 10, 22, 56, 743, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 1, 13, 9, 31, 30, 969, DateTimeKind.Local).AddTicks(8479), "أروى فريد", "Percy Hayes", "آدم - إيهاب", "7611559267861524101", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 3, 3, 5, 1, 41, 115, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 1, 13, 21, 23, 14, 387, DateTimeKind.Local).AddTicks(2831), "أمجد سالم", "Verner Kihn", "عارف, فؤاد and زيد", "79346185289504729", "Australia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 2, 14, 21, 45, 28, 433, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 1, 13, 22, 20, 11, 949, DateTimeKind.Local).AddTicks(1155), "فريد طارق", "Russell Altenwerth", 1, "أمجد - أمجد", "3136177270017184609", "Micronesia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 10, 4, 11, 44, 2, 903, DateTimeKind.Local).AddTicks(3077), new DateTime(2024, 1, 13, 11, 1, 2, 603, DateTimeKind.Local).AddTicks(6982), "إيناس حسن", "Lori Blick", "هاشم, فؤاد and عقیل", "6703802566136727984", "Myanmar", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 1, 29, 17, 42, 38, 637, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 1, 13, 7, 19, 40, 887, DateTimeKind.Local).AddTicks(3055), "أمجد حسن", "America Goldner", "عزیز, آدم and سعيد", "1012066464713407016", "Australia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 3, 27, 19, 18, 40, 487, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 1, 13, 2, 46, 12, 657, DateTimeKind.Local).AddTicks(8698), "أمجد عارف", "Heath Greenholt", "آدم, فريد and آدم", "886943177427388658", "Bahamas", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 4, 16, 0, 58, 53, 335, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 1, 13, 21, 16, 41, 878, DateTimeKind.Local).AddTicks(9944), "حسن معروف", "Harry Adams", "عارف - فريد", "4569601249091316460", "Spain", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 3, 19, 21, 52, 53, 80, DateTimeKind.Local).AddTicks(456), new DateTime(2024, 1, 13, 3, 6, 36, 485, DateTimeKind.Local).AddTicks(4748), "زيد بلال", "Blanca Walter", "عراقی - عصار", "2165556225105784838", "Gibraltar", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 12, 21, 8, 43, 16, 442, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 1, 13, 19, 31, 27, 404, DateTimeKind.Local).AddTicks(6897), "رقية عارف", "Joannie Kautzer", 0, "ربيع, عاشور and عزیز", "2484921764549932543", "Singapore", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 9, 10, 22, 35, 51, 807, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 1, 13, 12, 9, 25, 878, DateTimeKind.Local).AddTicks(1204), "عبير عصار", "Jan Stamm", 0, "إيهاب Group", "8365047099349264670", "Barbados", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 4, 0, 7, 54, 706, DateTimeKind.Local).AddTicks(7466), new DateTime(2024, 1, 13, 19, 2, 43, 422, DateTimeKind.Local).AddTicks(3361), "جمانة أسامة", "Lupe Spinka", "طارق - طارق", "7562445059592796491", "Belize", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 25, 2, 45, 50, 952, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 1, 13, 17, 49, 44, 989, DateTimeKind.Local).AddTicks(3744), "أروى هاشم", "Kianna Sanford", 0, "حازم Inc", "7707872797895255996", "Kyrgyz Republic", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1972, 6, 24, 6, 50, 14, 969, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 1, 13, 10, 44, 15, 777, DateTimeKind.Local).AddTicks(574), "فاروق آدم", "Kaya Fahey", "ربيع and Sons", "5785742008114144048", "South Georgia and the South Sandwich Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 6, 26, 4, 38, 48, 410, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 1, 13, 8, 34, 57, 893, DateTimeKind.Local).AddTicks(271), "فاروق صلاح", "Bettye McGlynn", 1, "عصار, عزیز and هاشم", "4431500735288608833", "Jamaica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 1, 16, 2, 48, 14, 846, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 1, 13, 18, 41, 7, 927, DateTimeKind.Local).AddTicks(9064), "ريم زيد", "Tyrique Thiel", 0, "معروف Group", "8155864038758042485", "Guernsey" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 11, 14, 0, 21, 2, 650, DateTimeKind.Local).AddTicks(317), new DateTime(2024, 1, 13, 19, 4, 11, 73, DateTimeKind.Local).AddTicks(8573), "سارة فاروق", "Royal MacGyver", 0, "سالم, فاروق and بلال", "8732365964885631684", "Greenland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 2, 10, 13, 14, 30, 103, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 1, 13, 1, 56, 13, 272, DateTimeKind.Local).AddTicks(2444), "أروى طارق", "Bryana Reichert", "زيد Group", "3920264118346107121", "Switzerland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 4, 15, 17, 24, 52, 793, DateTimeKind.Local).AddTicks(2375), new DateTime(2024, 1, 13, 21, 34, 26, 368, DateTimeKind.Local).AddTicks(6773), "جمانة ربيع", "Julian Altenwerth", "عاشور Group", "4574865667896026345", "Italy" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 11, 15, 14, 12, 38, 122, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 1, 13, 23, 56, 57, 373, DateTimeKind.Local).AddTicks(3590), "آية عصار", "Kelley O'Reilly", "حسن and Sons", "5787534655240366243", "France", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1987, 11, 12, 23, 57, 16, 927, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 1, 13, 6, 33, 20, 374, DateTimeKind.Local).AddTicks(3131), "أروى عقیل", "Timmy Zieme", 1, "عقیل - بلال", "4513929664907826004", "Antarctica (the territory South of 60 deg S)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 7, 15, 8, 0, 23, 264, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 1, 13, 23, 47, 42, 862, DateTimeKind.Local).AddTicks(6834), "سعيد حازم", "Cordelia Crooks", 1, "سالم, آدم and ربيع", "7679971038577600273", "Albania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1974, 7, 7, 12, 23, 33, 678, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 1, 13, 9, 58, 4, 650, DateTimeKind.Local).AddTicks(3204), "هاجر حسن", "Ursula Carroll", "عصار Inc", "6992739292509353198", "Netherlands Antilles" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 13, 23, 20, 18, 713, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 1, 13, 15, 8, 0, 442, DateTimeKind.Local).AddTicks(7192), "زينب هاشم", "Josiane Dach", "طارق - معروف", "4147419854772481742", "Andorra", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 5, 11, 18, 45, 787, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 1, 13, 18, 18, 55, 848, DateTimeKind.Local).AddTicks(8610), "آية فؤاد", "Ettie Lubowitz", 1, "عارف, عراقی and سعيد", "3246666556618740099", "Panama", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 6, 23, 49, 33, 672, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 1, 13, 11, 21, 30, 362, DateTimeKind.Local).AddTicks(8812), "آدم حسن", "Martine Jacobson", "جابر‌ Inc", "8701060809040849621", "Guinea", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 11, 20, 3, 50, 47, 296, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 1, 13, 13, 22, 39, 131, DateTimeKind.Local).AddTicks(1027), "أمجد عزیز", "Maiya Hyatt", 0, "فريد - آدم", "249512423253378811", "New Zealand", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 8, 3, 21, 24, 54, 512, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 1, 13, 18, 35, 6, 514, DateTimeKind.Local).AddTicks(6227), "حسن سالم", "Maximo Zieme", 1, "آدم, سالم and طارق", "1651256730787611387", "Rwanda", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1966, 5, 10, 3, 1, 20, 744, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 1, 13, 0, 53, 7, 883, DateTimeKind.Local).AddTicks(5160), "عبير فاروق", "Earline Schmitt", 1, "هاشم and Sons", "7588206420193513628", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 23, 10, 43, 42, 920, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 1, 13, 6, 29, 6, 84, DateTimeKind.Local).AddTicks(800), "لمى سعيد", "Lloyd Reynolds", 1, "طارق - جابر‌", "8954910284713293629", "Trinidad and Tobago", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 6, 19, 16, 3, 17, 91, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 1, 13, 10, 27, 56, 33, DateTimeKind.Local).AddTicks(8567), "إيهاب فاروق", "Etha Blick", 0, "أمجد - عصار", "6310496831227004595", "Tunisia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 13, 8, 35, 33, 396, DateTimeKind.Local).AddTicks(2536), new DateTime(2024, 1, 13, 20, 38, 53, 970, DateTimeKind.Local).AddTicks(489), "إيناس إيهاب", "Tavares Luettgen", 0, "آدم and Sons", "8296775349449474059", "Cape Verde", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 5, 23, 23, 42, 51, 47, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 1, 13, 0, 56, 36, 80, DateTimeKind.Local).AddTicks(9469), "زيد معروف", "Ima Blick", 0, "معروف Group", "8276581249255524554", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 7, 27, 4, 7, 6, 908, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 1, 14, 0, 32, 13, 131, DateTimeKind.Local).AddTicks(5783), "سارة طارق", "Emmett Watsica", "حسن - عزیز", "4628095326359592644", "Croatia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 5, 9, 8, 35, 10, 754, DateTimeKind.Local).AddTicks(6365), new DateTime(2024, 1, 13, 2, 40, 37, 310, DateTimeKind.Local).AddTicks(5065), "آدم آدم", "Orlo Kovacek", 1, "سعيد - عزیز", "7383839133661367873", "Armenia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 8, 25, 21, 40, 34, 584, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 1, 13, 0, 38, 29, 650, DateTimeKind.Local).AddTicks(6894), "إيهاب فريد", "Queenie McGlynn", 0, "ربيع, جابر‌ and عصار", "2002223555926921337", "Saudi Arabia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 12, 28, 20, 6, 51, 304, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 1, 13, 12, 22, 52, 190, DateTimeKind.Local).AddTicks(6386), "آدم حازم", "Cordie Pouros", "فريد, عقیل and فؤاد", "6269801347482472711", "Papua New Guinea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 9, 26, 12, 17, 4, 28, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 1, 13, 22, 57, 26, 186, DateTimeKind.Local).AddTicks(1120), "سالم عاشور", "Asa Hauck", 1, "أمجد Inc", "7473441862606903943", "Malta", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 2, 7, 10, 38, 32, 602, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 1, 13, 22, 37, 23, 898, DateTimeKind.Local).AddTicks(2889), "أروى أمجد", "Sigmund Gleichner", 0, "فؤاد - حازم", "8734044518411334319", "Mozambique", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 6, 15, 1, 42, 32, 785, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 1, 13, 23, 19, 3, 702, DateTimeKind.Local).AddTicks(4871), "حازم عارف", "Sonia Williamson", "عقیل, عقیل and أسامة", "4800456903268587889", "Kenya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 7, 23, 17, 27, 0, 572, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 1, 13, 2, 37, 56, 218, DateTimeKind.Local).AddTicks(610), "زينب فريد", "Jewell Larson", 0, "فاروق - جابر‌", "100210191507577527", "Isle of Man", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 9, 27, 21, 20, 37, 819, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 1, 13, 3, 5, 43, 135, DateTimeKind.Local).AddTicks(54), "أروى أمجد", "Dominic Windler", "أمجد - سالم", "3640686239366794672", "Morocco", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 5, 31, 0, 25, 0, 109, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 1, 13, 0, 44, 24, 299, DateTimeKind.Local).AddTicks(627), "آدم سالم", "Maegan Beahan", 0, "هاشم Group", "2184702798080040283", "Malawi", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 6, 18, 23, 13, 44, 146, DateTimeKind.Local).AddTicks(1316), new DateTime(2024, 1, 13, 16, 13, 50, 681, DateTimeKind.Local).AddTicks(649), "زينب فريد", "Johnny Runolfsdottir", 1, "عقیل - عزیز", "5746858448338300084", "South Africa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 23, 12, 56, 34, 547, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 1, 13, 13, 21, 36, 250, DateTimeKind.Local).AddTicks(9422), "إيهاب ربيع", "Veronica Batz", 0, "صلاح Group", "2446489679055788143", "Tanzania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 9, 17, 10, 22, 26, 370, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 1, 13, 20, 11, 1, 692, DateTimeKind.Local).AddTicks(1498), "ربيع معروف", "Paige Ruecker", 0, "حازم, إيهاب and فريد", "1049802600579614208", "Swaziland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 9, 22, 16, 10, 12, 594, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 1, 13, 9, 57, 21, 128, DateTimeKind.Local).AddTicks(3825), "سالم بلال", "Valerie Zemlak", "آدم LLC", "3312050257259081487", "Pitcairn Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 5, 9, 22, 42, 39, 785, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 1, 13, 14, 38, 34, 653, DateTimeKind.Local).AddTicks(7504), "آدم صلاح", "Otis Larson", 1, "سالم - فاروق", "6577180156141090880", "Italy", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 4, 19, 7, 55, 44, 549, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 1, 13, 15, 51, 25, 949, DateTimeKind.Local).AddTicks(7848), "بلال حازم", "Sylvia Hamill", 1, "أسامة - عصار", "13840963811862528", "Tajikistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 9, 22, 22, 34, 52, 327, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 1, 13, 23, 55, 10, 218, DateTimeKind.Local).AddTicks(9115), "فريدة فريد", "Lydia Schmidt", 1, "عصار Inc", "4208791514949670344", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 8, 7, 13, 28, 46, 819, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 1, 13, 17, 30, 17, 592, DateTimeKind.Local).AddTicks(9923), "إيناس صلاح", "Erin Johns", 0, "عزیز - جابر‌", "3143577175708175341", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 10, 6, 45, 56, 615, DateTimeKind.Local).AddTicks(604), new DateTime(2024, 1, 13, 6, 23, 1, 821, DateTimeKind.Local).AddTicks(3627), "سعيد هاشم", "Modesta Boyer", "عاشور - عصار", "7924493622599386573", "South Georgia and the South Sandwich Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 1, 23, 11, 34, 15, 826, DateTimeKind.Local).AddTicks(9002), new DateTime(2024, 1, 13, 3, 56, 56, 345, DateTimeKind.Local).AddTicks(8297), "طارق عصار", "Kassandra Beahan", "ربيع, حازم and إيهاب", "2715466872042946612", "Israel" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 11, 11, 14, 31, 47, 218, DateTimeKind.Local).AddTicks(9257), new DateTime(2024, 1, 13, 15, 3, 7, 398, DateTimeKind.Local).AddTicks(2874), "أمجد سعيد", "Alberto Hudson", 1, "سالم, فؤاد and أمجد", "962467798960144139", "Tuvalu", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 16, 18, 39, 35, 311, DateTimeKind.Local).AddTicks(7893), new DateTime(2024, 1, 13, 10, 31, 56, 266, DateTimeKind.Local).AddTicks(5800), "بلال طارق", "Forrest Stroman", 0, "فاروق - فؤاد", "5717121070537508912", "Guinea-Bissau", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 7, 23, 0, 16, 23, 45, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 1, 13, 10, 36, 46, 237, DateTimeKind.Local).AddTicks(5295), "جابر‌ صلاح", "Bernice Jaskolski", 0, "فريد LLC", "8902356184787763548", "Portugal", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 9, 16, 11, 2, 50, 178, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 1, 13, 23, 30, 47, 823, DateTimeKind.Local).AddTicks(4971), "هاجر حسن", "Magnolia Boyle", "عراقی Inc", "2395331981019639299", "Colombia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 1, 24, 7, 22, 43, 649, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 1, 13, 17, 57, 8, 520, DateTimeKind.Local).AddTicks(1303), "رقية سعيد", "Tyson Ledner", 1, "سالم - إيهاب", "6901076044657921032", "Slovenia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 11, 27, 11, 42, 39, 363, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 1, 13, 10, 26, 29, 29, DateTimeKind.Local).AddTicks(4074), "فاروق عاشور", "Damien Klein", "صلاح, آدم and عصار", "544733978208008275", "Sao Tome and Principe", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 9, 22, 13, 43, 43, 813, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 1, 13, 8, 12, 46, 73, DateTimeKind.Local).AddTicks(621), "شيماء حسن", "Enos Kunde", "عزیز, طارق and أمجد", "2045074613971366595", "Iceland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 8, 19, 17, 27, 31, 566, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 1, 13, 13, 26, 27, 956, DateTimeKind.Local).AddTicks(7249), "لمى هاشم", "Karolann Rogahn", 1, "ربيع - عراقی", "8712715260956494475", "Saint Kitts and Nevis" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 7, 14, 0, 46, 46, 684, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 1, 13, 14, 39, 20, 353, DateTimeKind.Local).AddTicks(7436), "فاروق زيد", "Bert Mosciski", 1, "أمجد - عاشور", "4162893883906161886", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 8, 24, 15, 52, 48, 60, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 1, 13, 12, 36, 24, 255, DateTimeKind.Local).AddTicks(2479), "آدم حازم", "Napoleon Kozey", "بلال, عقیل and طارق", "2732014894122887494", "Botswana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 6, 15, 0, 0, 10, 357, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 1, 13, 12, 56, 3, 484, DateTimeKind.Local).AddTicks(5532), "صلاح سالم", "Eric Fadel", "حسن Group", "153238353227035503", "Turks and Caicos Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 8, 27, 16, 10, 56, 131, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 1, 13, 9, 35, 49, 251, DateTimeKind.Local).AddTicks(3594), "هاجر أمجد", "Billie Bartoletti", "عراقی - بلال", "2049872286397336157", "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 9, 25, 9, 32, 46, 212, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 1, 14, 0, 30, 45, 308, DateTimeKind.Local).AddTicks(1431), "بلال عارف", "Gerard Powlowski", "عزیز and Sons", "1293477865214792027", "Aruba", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 7, 14, 19, 53, 545, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 1, 13, 23, 50, 57, 677, DateTimeKind.Local).AddTicks(3589), "أروى أمجد", "Audra O'Conner", 0, "بلال LLC", "8519538635751659623", "Saint Pierre and Miquelon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 12, 14, 16, 41, 20, 274, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 1, 13, 15, 29, 9, 828, DateTimeKind.Local).AddTicks(7944), "آدم عراقی", "Demetrius Haag", "فؤاد, عارف and حسن", "3266136391081843636", "Trinidad and Tobago", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 8, 29, 22, 37, 0, 498, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 1, 13, 22, 35, 39, 806, DateTimeKind.Local).AddTicks(8556), "فريد معروف", "Jacques Runolfsdottir", 1, "فريد LLC", "2039121620982592361", "Maldives", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2003, 5, 26, 10, 40, 19, 778, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 1, 13, 23, 14, 0, 656, DateTimeKind.Local).AddTicks(9790), "هاجر إيهاب", "Kacey Wisoky", 0, "معروف Inc", "9146046519696728536", "Mauritania" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 2, 22, 11, 26, 216, DateTimeKind.Local).AddTicks(7940), new DateTime(2024, 1, 13, 22, 23, 1, 374, DateTimeKind.Local).AddTicks(5236), "ربيع عصار", "Keshaun Dickinson", 0, "أسامة, بلال and طارق", "4354428013183814109", "Mauritius", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 2, 11, 13, 42, 57, 977, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 1, 13, 6, 20, 45, 732, DateTimeKind.Local).AddTicks(1798), "ربيع طارق", "Kelley Stokes", "عزیز, حازم and طارق", "3383418328520564336", "India", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 10, 13, 7, 22, 51, 525, DateTimeKind.Local).AddTicks(7362), new DateTime(2024, 1, 13, 20, 21, 51, 178, DateTimeKind.Local).AddTicks(566), "إيناس بلال", "Zackary Waelchi", 0, "سعيد Group", "955789111159307057", "Greenland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 1, 31, 11, 31, 41, 740, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 1, 13, 15, 11, 14, 768, DateTimeKind.Local).AddTicks(9396), "طارق فريد", "Aisha Klein", "جابر‌ - هاشم", "5814757917677930319", "Norway", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 8, 28, 22, 24, 19, 77, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 1, 13, 16, 43, 15, 558, DateTimeKind.Local).AddTicks(5842), "زيد معروف", "Jed Abshire", "حازم and Sons", "3678527136619348854", "Kenya", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 4, 1, 16, 44, 30, 265, DateTimeKind.Local).AddTicks(3263), new DateTime(2024, 1, 13, 11, 24, 14, 596, DateTimeKind.Local).AddTicks(8652), "أسامة إيهاب", "Demetris Moen", "فريد - هاشم", "45875579040131091", "Indonesia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 10, 2, 12, 37, 28, 66, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 1, 13, 21, 10, 6, 665, DateTimeKind.Local).AddTicks(9971), "ريم فاروق", "Felicita Boehm", "عصار, سالم and صلاح", "9080860864837007340", "Georgia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 12, 30, 9, 29, 53, 633, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 1, 13, 18, 5, 12, 853, DateTimeKind.Local).AddTicks(9829), "ريم عقیل", "Wendell Gaylord", 1, "فريد - إيهاب", "2044771300523049005", "El Salvador", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 3, 8, 17, 5, 6, 413, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 1, 13, 14, 41, 5, 552, DateTimeKind.Local).AddTicks(3134), "فاروق صلاح", "Emory Ryan", 0, "معروف, بلال and حسن", "722747833051478819", "Jamaica", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 11, 22, 6, 5, 25, 819, DateTimeKind.Local).AddTicks(6119), new DateTime(2024, 1, 13, 0, 58, 20, 412, DateTimeKind.Local).AddTicks(6011), "لمى سالم", "Kavon Schultz", "معروف, سالم and بلال", "3823782195702811034", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 7, 30, 21, 44, 48, 817, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 13, 7, 31, 18, 479, DateTimeKind.Local).AddTicks(7336), "منى حسن", "Jess Lynch", "زيد, حسن and فريد", "607544238433020386", "Georgia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 7, 4, 19, 17, 51, 61, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 1, 13, 19, 1, 23, 366, DateTimeKind.Local).AddTicks(1857), "إيهاب عصار", "Randi Hayes", 0, "عراقی and Sons", "6614798553342794790", "Brunei Darussalam", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 9, 19, 6, 3, 35, 58, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 1, 13, 4, 52, 20, 413, DateTimeKind.Local).AddTicks(6799), "منى سعيد", "Cassie Heidenreich", 0, "حسن and Sons", "3429077359894034355", "United Arab Emirates", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 11, 22, 18, 35, 1, 123, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 1, 13, 23, 1, 12, 794, DateTimeKind.Local).AddTicks(619), "أمجد آدم", "Lillian Larkin", 1, "حازم - عاشور", "7390394826019893403", "British Indian Ocean Territory (Chagos Archipelago)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1959, 10, 22, 11, 9, 27, 896, DateTimeKind.Local).AddTicks(257), new DateTime(2024, 1, 13, 16, 0, 37, 996, DateTimeKind.Local).AddTicks(6305), "رقية عارف", "Keon Krajcik", 0, "بلال - عصار", "722819126826228227", "Russian Federation" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 11, 30, 1, 30, 31, 265, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 1, 13, 14, 26, 52, 459, DateTimeKind.Local).AddTicks(7423), "حازم أمجد", "Jordan Paucek", 1, "عصار and Sons", "3186054869502905067", "Liechtenstein", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 2, 10, 43, 53, 349, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 1, 13, 10, 30, 4, 785, DateTimeKind.Local).AddTicks(4739), "جابر‌ عراقی", "Joanny Johnson", "جابر‌ and Sons", "5674204618281311189", "Portugal", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 6, 4, 15, 9, 58, 510, DateTimeKind.Local).AddTicks(122), new DateTime(2024, 1, 13, 5, 4, 29, 573, DateTimeKind.Local).AddTicks(8495), "هاجر حازم", "Quinton Franecki", 0, "ربيع - فريد", "7908916367904053631", "Estonia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 7, 18, 5, 35, 0, 418, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 1, 13, 3, 3, 5, 825, DateTimeKind.Local).AddTicks(4326), "آية عقیل", "Marianna Crooks", "فاروق - حازم", "2280120540618065989", "Norfolk Island", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 2, 4, 11, 47, 38, 660, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 1, 13, 11, 45, 40, 304, DateTimeKind.Local).AddTicks(9342), "صلاح عزیز", "Al Marks", "فاروق, عصار and بلال", "1697905198344363304", "Mauritania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 6, 26, 0, 11, 15, 345, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 1, 13, 5, 44, 9, 601, DateTimeKind.Local).AddTicks(4439), "إيهاب عصار", "Gussie Torphy", "أمجد - حازم", "3353066428111473459", "Guam", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 4, 8, 23, 55, 39, 608, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 1, 13, 12, 49, 57, 385, DateTimeKind.Local).AddTicks(7306), "فريد زيد", "Destinee Mertz", 0, "آدم LLC", "4919401230768728703", "Macao" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 10, 8, 12, 42, 17, 509, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 1, 13, 8, 50, 7, 157, DateTimeKind.Local).AddTicks(3629), "فؤاد آدم", "Ken Howe", 1, "آدم - عصار", "7861631623747118805", "Spain", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 3, 18, 13, 43, 23, 286, DateTimeKind.Local).AddTicks(7956), new DateTime(2024, 1, 13, 1, 44, 15, 673, DateTimeKind.Local).AddTicks(913), "حسن ربيع", "Presley Nicolas", 0, "بلال - فؤاد", "2698621112058847162", "Benin", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 5, 22, 12, 11, 27, 401, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 13, 22, 36, 49, 904, DateTimeKind.Local).AddTicks(8276), "لمى عزیز", "Beryl Rempel", "عصار, سعيد and طارق", "6236409387049535988", "Taiwan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 12, 13, 13, 12, 30, 42, DateTimeKind.Local).AddTicks(1514), new DateTime(2024, 1, 13, 5, 23, 30, 293, DateTimeKind.Local).AddTicks(5232), "إيهاب سعيد", "Leonel Zieme", 1, "هاشم LLC", "8270492328076501310", "Switzerland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 11, 22, 6, 12, 18, 457, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 1, 13, 7, 38, 21, 718, DateTimeKind.Local).AddTicks(3715), "حازم بلال", "Victoria Bradtke", "عقیل, ربيع and طارق", "6358638233480916641", "Burkina Faso", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 2, 28, 23, 32, 19, 97, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 1, 13, 6, 29, 4, 930, DateTimeKind.Local).AddTicks(9756), "حسن إيهاب", "Christina Tromp", "ربيع - آدم", "1653984513098211342", "Grenada", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 4, 3, 8, 59, 59, 55, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 1, 13, 21, 51, 25, 856, DateTimeKind.Local).AddTicks(7167), "فؤاد فريد", "Cristal Larkin", 1, "عارف, فريد and عارف", "2424650040445889879", "Timor-Leste" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 4, 15, 18, 57, 16, 798, DateTimeKind.Local).AddTicks(816), new DateTime(2024, 1, 13, 16, 25, 45, 978, DateTimeKind.Local).AddTicks(7975), "منى فريد", "Izabella Beier", 0, "آدم Inc", "2384954068637204524", "Libyan Arab Jamahiriya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 5, 18, 6, 0, 56, 665, DateTimeKind.Local).AddTicks(2639), new DateTime(2024, 1, 13, 11, 49, 33, 599, DateTimeKind.Local).AddTicks(1409), "جمانة حسن", "Sister Schowalter", "عزیز - معروف", "4984942829307824107", "Tuvalu", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 4, 14, 15, 7, 329, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 1, 13, 4, 2, 34, 221, DateTimeKind.Local).AddTicks(7459), "فؤاد ربيع", "Arthur Olson", 0, "إيهاب - حازم", "4542259830908218022", "Iceland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 12, 1, 3, 20, 47, 965, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 1, 13, 21, 39, 57, 993, DateTimeKind.Local).AddTicks(1813), "لمى أمجد", "Jannie Grant", "عاشور LLC", "3424854120738358140", "United States Minor Outlying Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 1, 29, 0, 53, 19, 833, DateTimeKind.Local).AddTicks(3043), new DateTime(2024, 1, 13, 4, 44, 7, 289, DateTimeKind.Local).AddTicks(2430), "سالم سالم", "Desmond Friesen", "معروف, فؤاد and جابر‌", "599446534777254671", "Bhutan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 10, 19, 8, 0, 14, 93, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 1, 13, 23, 0, 32, 419, DateTimeKind.Local).AddTicks(2457), "رقية إيهاب", "Quentin Hermann", 0, "أمجد, فريد and عزیز", "4682017896578517047", "Democratic People's Republic of Korea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 23, 14, 32, 59, 728, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 1, 13, 2, 40, 33, 95, DateTimeKind.Local).AddTicks(7576), "منى حسن", "Logan Keeling", "حسن - عاشور", "4512776222116281773", "Israel", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 12, 23, 0, 31, 49, 226, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 1, 13, 14, 52, 11, 881, DateTimeKind.Local).AddTicks(8822), "عبير أمجد", "Jermain Bayer", 0, "طارق, عزیز and معروف", "9128768749794168734", "Saint Kitts and Nevis" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 28, 19, 1, 0, 946, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 1, 13, 6, 36, 2, 439, DateTimeKind.Local).AddTicks(3676), "رقية فؤاد", "Jayde Kreiger", "عقیل LLC", "4681302211881223772", "Bahamas", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 5, 31, 16, 44, 31, 876, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 1, 13, 3, 44, 22, 457, DateTimeKind.Local).AddTicks(5251), "سارة هاشم", "Deshawn Streich", "آدم, عزیز and ربيع", "3908139926402048139", "Bangladesh", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 9, 16, 9, 8, 6, 21, DateTimeKind.Local).AddTicks(4527), new DateTime(2024, 1, 13, 9, 22, 11, 200, DateTimeKind.Local).AddTicks(8443), "زينب إيهاب", "Laney Bashirian", "طارق Inc", "124810889830625391", "Germany", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 7, 19, 13, 25, 11, 896, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 1, 13, 17, 23, 55, 284, DateTimeKind.Local).AddTicks(6850), "حسن معروف", "Reid Russel", 1, "حسن, صلاح and سعيد", "5604623827750052027", "India", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 9, 21, 11, 45, 58, 398, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 1, 13, 1, 58, 26, 219, DateTimeKind.Local).AddTicks(1094), "إيناس أسامة", "Carlee Shields", "ربيع, عاشور and حازم", "2265570578263926812", "Moldova", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 1, 5, 12, 16, 53, 988, DateTimeKind.Local).AddTicks(3834), new DateTime(2024, 1, 13, 6, 56, 0, 28, DateTimeKind.Local).AddTicks(7998), "بلال عراقی", "Madalyn Lynch", "زيد - عراقی", "9026509152332900678", "Serbia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 2, 5, 19, 20, 4, 764, DateTimeKind.Local).AddTicks(8069), new DateTime(2024, 1, 13, 8, 14, 49, 573, DateTimeKind.Local).AddTicks(9418), "أروى فاروق", "Frida Gulgowski", "فاروق, طارق and حازم", "4151309542264227091", "Denmark", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 9, 7, 5, 54, 56, 501, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 1, 13, 15, 57, 32, 231, DateTimeKind.Local).AddTicks(2626), "فاروق معروف", "Orville Feest", 0, "عزیز Group", "3495538279957587713", "Ecuador", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 7, 30, 6, 12, 4, 799, DateTimeKind.Local).AddTicks(367), new DateTime(2024, 1, 13, 14, 43, 22, 287, DateTimeKind.Local).AddTicks(235), "فاروق فؤاد", "Ettie Kerluke", "أسامة - إيهاب", "2931037664292059930", "San Marino", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1989, 6, 13, 6, 16, 34, 37, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 1, 13, 5, 1, 11, 384, DateTimeKind.Local).AddTicks(2647), "شيماء صلاح", "Laney Fay", "فؤاد - سالم", "1201565073943510629", "Croatia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 2, 1, 11, 18, 21, 479, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 1, 13, 21, 11, 34, 91, DateTimeKind.Local).AddTicks(933), "فاطمة عاشور", "Gust Langosh", "هاشم, فاروق and أسامة", "7518007007759014397", "Cocos (Keeling) Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 10, 12, 18, 58, 37, 708, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 1, 14, 0, 30, 22, 664, DateTimeKind.Local).AddTicks(345), "عبير جابر‌", "Curtis Rowe", 1, "أسامة - عقیل", "1163245238668641294", "Montserrat", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 11, 19, 19, 37, 6, 839, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 1, 13, 9, 18, 5, 697, DateTimeKind.Local).AddTicks(3282), "جمانة هاشم", "Maggie Hammes", "آدم LLC", "1376819970403949532", "Svalbard & Jan Mayen Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 10, 25, 1, 53, 36, 980, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 1, 13, 18, 4, 42, 622, DateTimeKind.Local).AddTicks(6080), "فريدة حسن", "Enrico Dicki", "عارف, عقیل and حسن", "4423769270970488707", "American Samoa", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 1, 27, 8, 42, 40, 552, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 1, 13, 14, 53, 5, 294, DateTimeKind.Local).AddTicks(1530), "سارة عصار", "Kristofer Gerhold", "عاشور - عاشور", "4791111254216445383", "China", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 1, 1, 17, 41, 58, 152, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 1, 13, 6, 19, 50, 660, DateTimeKind.Local).AddTicks(8327), "إيهاب سعيد", "Rozella Block", 1, "جابر‌ - عاشور", "6948549352627093316", "Vietnam", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 2, 17, 6, 51, 30, 431, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 1, 13, 17, 15, 32, 880, DateTimeKind.Local).AddTicks(7508), "إيهاب أسامة", "Ana Maggio", "عقیل - طارق", "1932908762703903000", "Serbia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 11, 28, 12, 46, 45, 852, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 1, 13, 7, 44, 51, 746, DateTimeKind.Local).AddTicks(8039), "أروى معروف", "Santina Shanahan", 0, "فريد, ربيع and حازم", "8811107893145235323", "New Zealand", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 7, 12, 21, 16, 2, 556, DateTimeKind.Local).AddTicks(8451), new DateTime(2024, 1, 13, 6, 46, 13, 211, DateTimeKind.Local).AddTicks(5742), "فريد سالم", "Emerald Fisher", "فاروق LLC", "8402433754811488382", "Bahrain", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 13, 23, 18, 11, 248, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 1, 13, 5, 21, 42, 732, DateTimeKind.Local).AddTicks(5630), "جابر‌ عقیل", "Marisa Fay", 1, "فؤاد - فاروق", "2678977557271767316", "Finland", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 8, 28, 13, 47, 43, 392, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 1, 13, 19, 45, 43, 377, DateTimeKind.Local).AddTicks(8316), "إيهاب عارف", "Jovani Mills", "إيهاب - أسامة", "3802699646696061462", "Anguilla", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 7, 25, 23, 40, 44, 473, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 1, 13, 15, 52, 39, 23, DateTimeKind.Local).AddTicks(9911), "حسن زيد", "Hulda Terry", 0, "آدم and Sons", "5065440412683130300", "Malta", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 9, 6, 6, 32, 29, 654, DateTimeKind.Local).AddTicks(3511), new DateTime(2024, 1, 13, 6, 53, 49, 806, DateTimeKind.Local).AddTicks(6603), "جمانة سالم", "Allie Boyle", "عاشور, ربيع and إيهاب", "715655774030575314", "Peru", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 9, 23, 0, 50, 20, 540, DateTimeKind.Local).AddTicks(9614), new DateTime(2024, 1, 13, 13, 55, 19, 852, DateTimeKind.Local).AddTicks(6276), "رقية عزیز", "Zechariah Paucek", "أسامة and Sons", "8245066304934836221", "Rwanda", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1994, 12, 1, 12, 45, 29, 743, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 1, 13, 2, 29, 8, 739, DateTimeKind.Local).AddTicks(5737), "إيهاب حسن", "Orlando Windler", 1, "عاشور, عارف and حازم", "6707182929821406913", "Congo" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 3, 15, 18, 13, 7, 532, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 13, 3, 47, 34, 302, DateTimeKind.Local).AddTicks(2205), "لمى سالم", "Alene Swaniawski", "سالم, إيهاب and عارف", "7477590540444717571", "Oman", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 5, 6, 6, 35, 6, 935, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 1, 13, 13, 44, 6, 623, DateTimeKind.Local).AddTicks(9135), "إيهاب طارق", "Pasquale Durgan", "بلال Group", "8906961052977618379", "Ireland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 10, 31, 10, 26, 52, 841, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 1, 13, 5, 9, 4, 230, DateTimeKind.Local).AddTicks(3193), "سالم عقیل", "Kody Langosh", 1, "عراقی - أسامة", "8413221729901389226", "Pitcairn Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 3, 4, 16, 20, 26, 992, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 1, 13, 4, 43, 24, 526, DateTimeKind.Local).AddTicks(1823), "رنا معروف", "Aniya Heidenreich", "سعيد, سعيد and عاشور", "2829924515202436894", "Taiwan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 10, 30, 9, 16, 45, 755, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 1, 13, 2, 33, 14, 697, DateTimeKind.Local).AddTicks(3976), "لمى معروف", "Adrianna Little", 0, "معروف LLC", "1646342221828857904", "Somalia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 5, 13, 18, 5, 29, 150, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 1, 13, 9, 47, 1, 253, DateTimeKind.Local).AddTicks(2360), "فريد حسن", "Retha Hahn", "آدم LLC", "1921915313892242963", "Central African Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 7, 22, 21, 41, 31, 707, DateTimeKind.Local).AddTicks(2393), new DateTime(2024, 1, 13, 2, 27, 43, 736, DateTimeKind.Local).AddTicks(3569), "جابر‌ أمجد", "Gregorio Hudson", 0, "جابر‌ - طارق", "7031033051248482721", "Djibouti", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 11, 21, 1, 22, 13, 657, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 1, 13, 22, 53, 9, 166, DateTimeKind.Local).AddTicks(2521), "شيماء عراقی", "Mark Wilderman", "سالم - فريد", "5217239442737758246", "Sri Lanka", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 7, 23, 11, 18, 33, 950, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 1, 13, 3, 53, 55, 839, DateTimeKind.Local).AddTicks(3123), "سالم آدم", "Ross Dare", 0, "فؤاد - سعيد", "8694082081317943162", "Andorra", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 7, 26, 4, 44, 30, 267, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 1, 13, 6, 1, 11, 415, DateTimeKind.Local).AddTicks(3814), "جابر‌ أسامة", "Skyla Bogisich", "آدم LLC", "335162850233923854", "Egypt", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1963, 1, 27, 13, 55, 57, 521, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 1, 13, 2, 8, 1, 576, DateTimeKind.Local).AddTicks(8014), "سارة سالم", "Ken Bednar", "عاشور Inc", "8800754560180363333", "Sao Tome and Principe" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 2, 22, 5, 10, 41, 116, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 1, 13, 20, 17, 42, 135, DateTimeKind.Local).AddTicks(1838), "رنا عارف", "Jonas Ortiz", 1, "عقیل, عاشور and عارف", "1264462525571464948", "Mauritania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 3, 16, 15, 35, 59, 523, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 1, 13, 11, 17, 17, 278, DateTimeKind.Local).AddTicks(167), "سارة أسامة", "Bobbie Pacocha", "صلاح Inc", "4969455282494063686", "United States of America" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1981, 10, 16, 22, 14, 40, 305, DateTimeKind.Local).AddTicks(1698), new DateTime(2024, 1, 14, 0, 30, 9, 786, DateTimeKind.Local).AddTicks(440), "زيد عصار", "Jayson Schmidt", "فريد and Sons", "6806664963840566793", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 8, 2, 15, 19, 0, 271, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 1, 13, 10, 32, 12, 839, DateTimeKind.Local).AddTicks(3598), "حازم عزیز", "Roxane Gibson", "طارق - حسن", "5620025216750850447", "Saudi Arabia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 10, 15, 7, 23, 37, 201, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 1, 13, 21, 43, 19, 179, DateTimeKind.Local).AddTicks(4157), "فريد حسن", "Vanessa Treutel", 0, "ربيع LLC", "1666814647990277314", "Zimbabwe", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 1, 31, 8, 34, 20, 512, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 1, 13, 11, 11, 37, 902, DateTimeKind.Local).AddTicks(6384), "طارق إيهاب", "Rosamond Littel", 0, "عارف - فؤاد", "6245377501074367457", "Greenland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 9, 1, 7, 44, 2, 445, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 1, 13, 23, 54, 44, 63, DateTimeKind.Local).AddTicks(2515), "رقية آدم", "Halie Schulist", "عقیل Group", "2713683405207239038", "Georgia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 5, 8, 19, 19, 55, 518, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 1, 13, 6, 42, 51, 480, DateTimeKind.Local).AddTicks(4390), "حازم عراقی", "Lincoln Johnson", 1, "صلاح - صلاح", "6690534523800055459", "Puerto Rico", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 8, 9, 6, 6, 6, 936, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 1, 13, 12, 8, 12, 616, DateTimeKind.Local).AddTicks(4039), "آدم عزیز", "Emmanuel O'Keefe", "حازم and Sons", "3108403843626856479", "Burkina Faso", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 5, 17, 10, 27, 54, 732, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 1, 13, 18, 57, 46, 774, DateTimeKind.Local).AddTicks(3340), "لمى بلال", "Myrl Rice", "صلاح, أمجد and حسن", "3226977285254643651", "Thailand", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 7, 19, 18, 11, 11, 756, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 1, 13, 8, 39, 37, 56, DateTimeKind.Local).AddTicks(7840), "هاجر صلاح", "Rod Bahringer", "فؤاد Inc", "4572351926628849131", "Lithuania", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 4, 2, 17, 52, 0, 420, DateTimeKind.Local).AddTicks(6193), new DateTime(2024, 1, 13, 0, 50, 57, 776, DateTimeKind.Local).AddTicks(8913), "رنا جابر‌", "Mae Abbott", "حازم and Sons", "1584755909514387119", "Norfolk Island", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 7, 16, 13, 56, 58, 482, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 1, 13, 1, 29, 1, 429, DateTimeKind.Local).AddTicks(2086), "أروى إيهاب", "Jamarcus Cormier", 0, "إيهاب - آدم", "3136668524708529659", "Rwanda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 7, 6, 4, 17, 7, 643, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 1, 13, 17, 20, 57, 111, DateTimeKind.Local).AddTicks(7455), "صلاح عقیل", "Erica Bergnaum", 1, "فؤاد, بلال and ربيع", "5427566215137477641", "Indonesia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 1, 18, 17, 21, 50, 421, DateTimeKind.Local).AddTicks(6303), new DateTime(2024, 1, 13, 18, 55, 19, 977, DateTimeKind.Local).AddTicks(4859), "ريم عقیل", "Monserrat Sporer", "فؤاد Inc", "3316317410042251044", "Pakistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1978, 9, 4, 5, 30, 17, 646, DateTimeKind.Local).AddTicks(6113), new DateTime(2024, 1, 13, 19, 54, 22, 946, DateTimeKind.Local).AddTicks(1835), "رنا حسن", "Gayle Schaefer", "سعيد - إيهاب", "2505686812772976019", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 10, 1, 1, 30, 23, 294, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 1, 13, 4, 0, 5, 600, DateTimeKind.Local).AddTicks(9886), "فريد عاشور", "April Gulgowski", "سالم, بلال and فريد", "8945153136355945696", "Marshall Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1974, 1, 12, 19, 37, 37, 646, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 1, 13, 0, 37, 7, 375, DateTimeKind.Local).AddTicks(4950), "آية صلاح", "Kendall Zemlak", 1, "سعيد - عصار", "296374584724454717", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 8, 11, 10, 1, 40, 914, DateTimeKind.Local).AddTicks(1234), new DateTime(2024, 1, 13, 15, 41, 21, 126, DateTimeKind.Local).AddTicks(3954), "دانا ربيع", "Graciela Okuneva", "عاشور, فؤاد and إيهاب", "9149188102042668300", "Puerto Rico", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 1, 6, 12, 29, 48, 607, DateTimeKind.Local).AddTicks(840), new DateTime(2024, 1, 13, 21, 59, 9, 69, DateTimeKind.Local).AddTicks(9580), "سالم فؤاد", "Kira Schmeler", "فؤاد, عقیل and فريد", "396236006754123771", "Timor-Leste", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 11, 12, 17, 25, 12, 57, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 1, 13, 15, 3, 12, 737, DateTimeKind.Local).AddTicks(7976), "رنا أمجد", "Ramiro Heaney", 1, "جابر‌, عارف and طارق", "8119263822679947013", "Ghana", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 2, 17, 17, 58, 5, 716, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 1, 13, 21, 44, 7, 861, DateTimeKind.Local).AddTicks(9529), "إيناس آدم", "Arianna Miller", "فؤاد, فاروق and عزیز", "6087421011660793931", "Somalia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 10, 30, 9, 24, 1, 55, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 1, 13, 1, 18, 48, 87, DateTimeKind.Local).AddTicks(2761), "أسامة عصار", "Lewis Bosco", "عقیل - هاشم", "3901808301069152229", "United Arab Emirates", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 2, 8, 12, 23, 49, 197, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 1, 13, 12, 11, 45, 31, DateTimeKind.Local).AddTicks(2370), "ريم بلال", "Eldora Welch", "بلال - ربيع", "2188683198824097728", "Puerto Rico" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 11, 28, 4, 12, 12, 77, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 1, 13, 19, 12, 58, 302, DateTimeKind.Local).AddTicks(1992), "عبير حسن", "Stella Beahan", 1, "فؤاد, بلال and ربيع", "928247307149834613", "Ghana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 4, 22, 7, 26, 13, 920, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 1, 13, 20, 19, 49, 428, DateTimeKind.Local).AddTicks(5901), "فاطمة بلال", "Clark Wuckert", 1, "ربيع Inc", "9023514674800295100", "Cayman Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "SocialState" },
                values: new object[] { new DateTime(1980, 12, 4, 15, 30, 19, 457, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 1, 14, 0, 8, 44, 105, DateTimeKind.Local).AddTicks(7947), "فؤاد عاشور", "Deondre Schroeder", "عاشور - فريد", "2824923062588116018", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 8, 7, 9, 18, 7, 401, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 1, 13, 4, 32, 24, 731, DateTimeKind.Local).AddTicks(7649), "منى عزیز", "Avery West", "أمجد - بلال", "2615437195916163176", "South Georgia and the South Sandwich Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 3, 16, 19, 32, 13, 695, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 1, 13, 22, 22, 38, 545, DateTimeKind.Local).AddTicks(8787), "عبير زيد", "Kayley Macejkovic", 1, "سعيد - عارف", "418202984639904040", "Marshall Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 4, 30, 5, 32, 3, 503, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 1, 13, 18, 28, 55, 959, DateTimeKind.Local).AddTicks(460), "ربيع هاشم", "Trystan Abshire", "عراقی - أسامة", "4558107239704580", "Moldova", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 12, 2, 9, 4, 55, 947, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 1, 13, 8, 23, 42, 359, DateTimeKind.Local).AddTicks(5549), "دانا عارف", "Mya Ratke", 1, "سعيد, سالم and زيد", "8246013530640864522", "Argentina", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 5, 30, 14, 26, 14, 271, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 1, 13, 13, 52, 59, 891, DateTimeKind.Local).AddTicks(9425), "أمجد فريد", "Mohammad Dicki", "عراقی - جابر‌", "7382994841249961329", "Eritrea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 6, 26, 15, 2, 6, 392, DateTimeKind.Local).AddTicks(5038), new DateTime(2024, 1, 13, 10, 43, 39, 846, DateTimeKind.Local).AddTicks(832), "إيهاب معروف", "Kiera Christiansen", 0, "صلاح and Sons", "6416957820524130554", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 1, 5, 3, 10, 50, 978, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 1, 13, 15, 11, 46, 687, DateTimeKind.Local).AddTicks(4477), "صلاح إيهاب", "Danny Lang", 0, "عارف Group", "6327430020986625240", "Saudi Arabia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 9, 21, 11, 50, 15, 344, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 1, 14, 0, 16, 26, 251, DateTimeKind.Local).AddTicks(5979), "دانا حازم", "Alanna Tromp", 0, "آدم - فؤاد", "9113739363349024104", "Iran", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 8, 25, 9, 4, 46, 635, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 1, 13, 9, 23, 30, 699, DateTimeKind.Local).AddTicks(5073), "شيماء عصار", "Hanna Mayert", "عصار Inc", "4756373926150425909", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 2, 15, 15, 19, 26, 651, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 1, 13, 23, 48, 23, 435, DateTimeKind.Local).AddTicks(3642), "منى فاروق", "Marion Jacobs", "هاشم, طارق and آدم", "5496428403033885122", "Senegal", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 2, 28, 5, 43, 11, 39, DateTimeKind.Local).AddTicks(7687), new DateTime(2024, 1, 13, 3, 40, 59, 710, DateTimeKind.Local).AddTicks(1821), "هاجر عراقی", "Blake Heller", 0, "عزیز - فريد", "1939778745464733139", "Seychelles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 10, 16, 8, 0, 39, 746, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 1, 13, 21, 31, 16, 54, DateTimeKind.Local).AddTicks(9497), "آية زيد", "Darren Rowe", 1, "ربيع Inc", "2458946549586575213", "Sweden", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 2, 9, 14, 6, 26, 260, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 1, 13, 19, 34, 57, 144, DateTimeKind.Local).AddTicks(2020), "فؤاد معروف", "Jimmie Moen", "عراقی, حازم and معروف", "5881199960681291959", "British Indian Ocean Territory (Chagos Archipelago)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1954, 12, 19, 16, 27, 29, 52, DateTimeKind.Local).AddTicks(2379), new DateTime(2024, 1, 13, 6, 50, 22, 30, DateTimeKind.Local).AddTicks(4775), "رنا سعيد", "Kaya Tromp", 1, "أسامة, أمجد and عقیل", "7775016210268056127", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 12, 15, 21, 58, 6, 600, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 1, 13, 5, 57, 1, 542, DateTimeKind.Local).AddTicks(7552), "فاطمة عاشور", "Marianna Purdy", 1, "سالم - عارف", "5237340885599736446", "Cameroon", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 8, 8, 19, 47, 23, 934, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 1, 13, 4, 53, 4, 491, DateTimeKind.Local).AddTicks(4334), "هاجر عراقی", "Vernon Ondricka", 1, "عقیل - أسامة", "2225622129493271840", "Grenada", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 12, 23, 16, 17, 38, 215, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 1, 13, 1, 2, 53, 685, DateTimeKind.Local).AddTicks(3450), "ريم سالم", "Wayne Gutmann", "بلال, بلال and فؤاد", "6235936012839001595", "Indonesia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 12, 8, 5, 56, 46, 177, DateTimeKind.Local).AddTicks(7266), new DateTime(2024, 1, 13, 22, 28, 40, 127, DateTimeKind.Local).AddTicks(1908), "آدم عراقی", "Louvenia Nader", "عقیل, فريد and أسامة", "4324889341104803697", "Sierra Leone", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 12, 28, 14, 6, 15, 667, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 1, 13, 6, 16, 22, 316, DateTimeKind.Local).AddTicks(5281), "فاطمة هاشم", "Chadrick Ward", 0, "سعيد Group", "5292892425876303500", "New Zealand", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 9, 26, 20, 8, 52, 298, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 1, 13, 1, 29, 25, 792, DateTimeKind.Local).AddTicks(7438), "لمى عارف", "Max Zboncak", "فريد Inc", "5840318397910578546", "Aruba", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 2, 7, 23, 15, 21, 199, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 1, 13, 15, 37, 35, 234, DateTimeKind.Local).AddTicks(8775), "أسامة صلاح", "Clare Casper", "حسن Group", "5399706013852754750", "Angola", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 1, 25, 6, 23, 36, 610, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 1, 13, 23, 58, 56, 704, DateTimeKind.Local).AddTicks(8591), "أسامة حازم", "Constance Gusikowski", "زيد - حسن", "5956789069056220720", "New Zealand", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 2, 6, 22, 0, 48, 239, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 1, 13, 19, 4, 7, 327, DateTimeKind.Local).AddTicks(4600), "سالم فؤاد", "Margot Bergnaum", "أمجد, سعيد and آدم", "6384523777382623982", "Faroe Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 30, 17, 18, 50, 249, DateTimeKind.Local).AddTicks(6986), new DateTime(2024, 1, 13, 3, 32, 47, 847, DateTimeKind.Local).AddTicks(2955), "إيناس جابر‌", "Vance Welch", "حسن LLC", "7631389338789174311", "Portugal", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 9, 16, 16, 36, 30, 565, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 1, 13, 21, 3, 38, 149, DateTimeKind.Local).AddTicks(3995), "بلال زيد", "Mittie Sanford", 1, "معروف Group", "8375322910236360963", "Montenegro", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 5, 30, 10, 26, 47, 217, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 1, 13, 20, 2, 35, 637, DateTimeKind.Local).AddTicks(9991), "فؤاد بلال", "Stevie Moen", "حازم Group", "5605562316099625597", "Brazil" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 3, 14, 6, 26, 2, 397, DateTimeKind.Local).AddTicks(1836), new DateTime(2024, 1, 13, 3, 11, 14, 112, DateTimeKind.Local).AddTicks(2937), "صلاح صلاح", "Kelley Hintz", 0, "عزیز Group", "4325729434065466140", "Sri Lanka", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 8, 22, 2, 26, 9, 908, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 1, 13, 23, 44, 25, 458, DateTimeKind.Local).AddTicks(872), "آدم ربيع", "Ignatius Daugherty", "عراقی - فاروق", "7229044267475740635", "Mali", 1 });
        }
    }
}
