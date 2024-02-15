using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPatientMedicalFileModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalFiles_MedicalFileId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalFileId",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "MedicalFileId1",
                table: "Patients",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "MedicalFiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, طريق اقبال لاهوری, 0231, باب الزوار, Kazakhstan", "العوجا", new DateTime(2024, 2, 15, 4, 27, 38, 327, DateTimeKind.Local).AddTicks(2505), "jabr.hashm@gmail.com", "1-201-801-2878 x82105" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, شارع سمیه, 611, إدفو, Cape Verde", "بنجرير", new DateTime(2024, 2, 15, 16, 31, 11, 100, DateTimeKind.Local).AddTicks(339), "zynb32@hotmail.com", "779.598.4950" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, تقاطع سباری, 5, روصو, Pitcairn Islands", "المحمدية", new DateTime(2024, 2, 15, 15, 35, 22, 162, DateTimeKind.Local).AddTicks(7169), "sayd33@hotmail.com", "1-871-557-7263 x3605" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار شهید مطهری, 1179, ودمدني, Mozambique", "جباليا", new DateTime(2024, 2, 15, 19, 0, 35, 936, DateTimeKind.Local).AddTicks(7372), "zynb.aarf83@hotmail.com", "(762) 803-9596" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, تقاطع سمیه, 3, القطيف, Holy See (Vatican City State)", "جاردو", new DateTime(2024, 2, 15, 15, 51, 24, 695, DateTimeKind.Local).AddTicks(4067), "tarq_salm@hotmail.com", "1-803-252-0964 x8365" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, 4708, القائم, Mauritius", "الفيوم", new DateTime(2024, 2, 15, 10, 48, 56, 679, DateTimeKind.Local).AddTicks(4837), "hsn.farwq51@hotmail.com", "244.936.0819" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 70, الناصرة, Mauritius", "سلفيت", new DateTime(2024, 2, 15, 15, 24, 5, 995, DateTimeKind.Local).AddTicks(4162), "rym44@hotmail.com", "333-847-0625 x60527" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, 8921, جيجل, Finland", "عكا", new DateTime(2024, 2, 15, 15, 9, 35, 718, DateTimeKind.Local).AddTicks(5742), "mna.rbya69@hotmail.com", "792-362-7258 x353" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, 98, مال, Sri Lanka", "كركوك", new DateTime(2024, 2, 15, 8, 33, 13, 710, DateTimeKind.Local).AddTicks(7922), "iynas_marwf@hotmail.com", "939-400-7060 x1190" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, 4411, السليل, Moldova", "سكيكدة", new DateTime(2024, 2, 15, 0, 10, 58, 160, DateTimeKind.Local).AddTicks(8963), "shymaa1@yahoo.com", "1-319-419-5599 x133" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, ميدان آفریقا, 012, أوبوك, Comoros", "كيفة", new DateTime(2024, 2, 14, 23, 53, 42, 895, DateTimeKind.Local).AddTicks(2768), "farwq76@gmail.com", "631-932-3098 x030" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, 21, عمان, Benin", "الرمادي", new DateTime(2024, 2, 15, 1, 15, 9, 831, DateTimeKind.Local).AddTicks(9562), "hsn.amjd68@hotmail.com", "972-374-4375" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, دوار کارگر شمالی, 85, خريبة السوق, Tonga", "صير بني ياس", new DateTime(2024, 2, 15, 7, 28, 41, 987, DateTimeKind.Local).AddTicks(9841), "iynas_asamh@yahoo.com", "498-474-8277" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, شارع مالک اشتر, 8, سنار, Mexico", "هرجيسة", new DateTime(2024, 2, 15, 19, 25, 17, 817, DateTimeKind.Local).AddTicks(927), "shymaa.tarq17@hotmail.com", "1-594-701-0475" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, دوار مالک اشتر, 606, نيالا, Gambia", "مكة المكرمة", new DateTime(2024, 2, 15, 5, 49, 26, 205, DateTimeKind.Local).AddTicks(2436), "hajr.hazm15@hotmail.com", "(850) 378-7855 x5121" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, 04, عنابة, United Kingdom", "الكوت", new DateTime(2024, 2, 15, 18, 4, 34, 560, DateTimeKind.Local).AddTicks(9315), "jmanh_salm@gmail.com", "1-271-615-9432" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, طريق آذربایجان, 496, داريا, Saint Lucia", "دير الزور", new DateTime(2024, 2, 15, 21, 44, 31, 301, DateTimeKind.Local).AddTicks(1650), "dana_aqyl@hotmail.com", "(471) 454-4219 x334" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, 32, ودمدني, Myanmar", "الشامية", new DateTime(2024, 2, 15, 0, 9, 51, 972, DateTimeKind.Local).AddTicks(9893), "hajr.araqy72@yahoo.com", "1-988-308-6167 x10936" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, ميدان ابوذر, 17, نالوت, Djibouti", "المالكية", new DateTime(2024, 2, 15, 3, 2, 41, 734, DateTimeKind.Local).AddTicks(8752), "mna_jabr75@yahoo.com", "(766) 247-7167 x993" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, دوار امیرکبیر, 1003, باجل, United Arab Emirates", "البيرة", new DateTime(2024, 2, 15, 2, 11, 11, 875, DateTimeKind.Local).AddTicks(8898), "rbya_asamh@hotmail.com", "691-446-9208 x7398" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار یادگار امام, شارع سباری, 94, الوادي, Andorra", "عين العرب", new DateTime(2024, 2, 15, 9, 2, 47, 848, DateTimeKind.Local).AddTicks(4050), "amjd31@yahoo.com", "495.491.8639 x631" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, شارع ابوذر, 760, وادي زم, Puerto Rico", "بربرة", new DateTime(2024, 2, 15, 1, 36, 53, 487, DateTimeKind.Local).AddTicks(4629), "farwq84@hotmail.com", "242.850.9683" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, 66, السماوة, Saint Lucia", "القنفذة", new DateTime(2024, 2, 15, 19, 23, 38, 518, DateTimeKind.Local).AddTicks(8064), "arwa76@yahoo.com", "278.527.5359 x3801" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, 2, المزاحمية, Saint Barthelemy", "ادلب", new DateTime(2024, 2, 15, 16, 58, 52, 820, DateTimeKind.Local).AddTicks(3687), "rna_aarf@gmail.com", "623.679.6087" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, دوار کارگر شمالی, 7, شيبه, Western Sahara", "الكسوة", new DateTime(2024, 2, 15, 14, 1, 47, 930, DateTimeKind.Local).AddTicks(1872), "slah.fryd60@yahoo.com", "580.973.9619" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, طريق اقبال لاهوری, 4560, يافا, Croatia", "بدبد", new DateTime(2024, 2, 15, 8, 17, 33, 48, DateTimeKind.Local).AddTicks(7098), "asamh20@yahoo.com", "(464) 205-8949" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, طريق آفریقا, 04, باقة الغربية, Cayman Islands", "الفيوم", new DateTime(2024, 2, 15, 16, 0, 42, 380, DateTimeKind.Local).AddTicks(1991), "dana_hazm@yahoo.com", "1-434-797-2726" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع قدس, 4, الفنيدق, Vietnam", "مصراتة", new DateTime(2024, 2, 15, 21, 11, 26, 158, DateTimeKind.Local).AddTicks(3109), "amjd_farwq86@hotmail.com", "1-756-726-7755" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, ميدان یادگار امام, 3, شبين الكوم, Jersey", "مدحاء", new DateTime(2024, 2, 15, 1, 50, 14, 544, DateTimeKind.Local).AddTicks(6748), "jmanh_araqy@hotmail.com", "233.935.7949" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 77, جت, Cote d'Ivoire", "فيفاء", new DateTime(2024, 2, 15, 4, 4, 36, 74, DateTimeKind.Local).AddTicks(7864), "frydh11@yahoo.com", "427.575.1955" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, شارع واعظی, 3, الفقيه بنصالح, Martinique", "السلط", new DateTime(2024, 2, 15, 11, 47, 36, 2, DateTimeKind.Local).AddTicks(4372), "rbya0@gmail.com", "(682) 993-6252 x3112" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, 7884, ازرع, South Africa", "عبري", new DateTime(2024, 2, 15, 19, 15, 5, 361, DateTimeKind.Local).AddTicks(3073), "asamh50@gmail.com", "533-785-7919 x10693" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, تقاطع دماوند, 2211, بليث وين, Argentina", "شرورة", new DateTime(2024, 2, 15, 0, 5, 33, 549, DateTimeKind.Local).AddTicks(810), "zynb55@yahoo.com", "613-682-8994 x8284" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, 5018, عين العرب, Bermuda", "نيالا", new DateTime(2024, 2, 15, 12, 10, 38, 468, DateTimeKind.Local).AddTicks(5840), "jmanh1@gmail.com", "933-868-2467 x6935" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 55, المكلا, Oman", "مدينة حمد", new DateTime(2024, 2, 15, 20, 14, 40, 902, DateTimeKind.Local).AddTicks(1361), "aayh.hsn25@hotmail.com", "(660) 991-7351 x722" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, 341, نيالا, Chile", "لؤلؤة قطر", new DateTime(2024, 2, 15, 12, 23, 33, 285, DateTimeKind.Local).AddTicks(7436), "aadm_farwq24@hotmail.com", "624-289-0126 x22409" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, 384, السويق, Burundi", "النبطية", new DateTime(2024, 2, 15, 4, 19, 39, 81, DateTimeKind.Local).AddTicks(3319), "rbya.aqyl@hotmail.com", "1-963-603-5316 x948" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 9, جزين, Equatorial Guinea", "عشرة رمضان", new DateTime(2024, 2, 15, 1, 22, 24, 902, DateTimeKind.Local).AddTicks(1239), "fatmh_blal@hotmail.com", "258-676-0643 x280" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, شارع راستوان, 7586, كيفة, Guinea", "حلب", new DateTime(2024, 2, 15, 22, 58, 52, 113, DateTimeKind.Local).AddTicks(5539), "iyhab54@gmail.com", "(644) 478-4222 x311" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, 061, ازويرات, Guyana", "اولاد التايمة", new DateTime(2024, 2, 15, 22, 5, 9, 122, DateTimeKind.Local).AddTicks(8761), "sarh.rbya97@yahoo.com", "471.382.0624 x157" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, 94, قرية سار, Saudi Arabia", "ملوى", new DateTime(2024, 2, 15, 20, 14, 14, 712, DateTimeKind.Local).AddTicks(5722), "hsn_farwq@gmail.com", "(230) 388-8073 x1191" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, ش اجاره دار, 2475, اكجوجت, Tuvalu", "الديوانية", new DateTime(2024, 2, 15, 13, 15, 22, 620, DateTimeKind.Local).AddTicks(8590), "fryd90@gmail.com", "1-708-495-5039 x336" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, 7, جرسيف, Ukraine", "بليث وين", new DateTime(2024, 2, 14, 23, 23, 17, 7, DateTimeKind.Local).AddTicks(4863), "mna_sayd22@gmail.com", "948-363-1233 x1093" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, تقاطع قدس, 760, جنين, Slovenia", "حلبجة", new DateTime(2024, 2, 15, 22, 30, 6, 661, DateTimeKind.Local).AddTicks(2912), "rym37@yahoo.com", "(949) 766-8450 x389" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, تقاطع شهید مطهری, 1765, الدمام, Fiji", "رأس لفان", new DateTime(2024, 2, 15, 14, 26, 23, 958, DateTimeKind.Local).AddTicks(8646), "zyd3@gmail.com", "1-926-274-6112" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, دوار سباری, 18, بريكة, Aruba", "الحسيمة", new DateTime(2024, 2, 15, 17, 34, 3, 261, DateTimeKind.Local).AddTicks(7789), "rym.zyd@yahoo.com", "580-927-3418 x241" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 5, العمارة, Haiti", "عين اعبيد", new DateTime(2024, 2, 15, 21, 47, 52, 293, DateTimeKind.Local).AddTicks(6092), "dana_blal15@yahoo.com", "1-399-610-2705" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, شارع امیرکبیر, 6575, خور فكان, Dominican Republic", "السلط", new DateTime(2024, 2, 15, 11, 26, 12, 343, DateTimeKind.Local).AddTicks(1988), "jabr52@hotmail.com", "1-341-522-7584 x29902" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, 0, خصب, United States Minor Outlying Islands", "كفرنجة", new DateTime(2024, 2, 15, 10, 11, 15, 505, DateTimeKind.Local).AddTicks(5095), "iyhab52@gmail.com", "898.383.0042 x75862" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, 774, صحار, Sweden", "كفر الشيخ", new DateTime(2024, 2, 15, 12, 3, 31, 264, DateTimeKind.Local).AddTicks(25), "sayd_hsn@gmail.com", "(874) 336-7036 x70907" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, طريق مالک اشتر, 050, جازان, Tunisia", "تازة", new DateTime(2024, 2, 15, 13, 14, 23, 923, DateTimeKind.Local).AddTicks(5657), "aayh.fuad35@gmail.com", "977.253.3505 x51273" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 2, كوستي, Fiji", "ذمار", new DateTime(2024, 2, 15, 22, 58, 39, 629, DateTimeKind.Local).AddTicks(7108), "iynas_asar4@hotmail.com", "954.525.1454 x882" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, دوار سمیه, 47, دمنهور, Holy See (Vatican City State)", "نابل", new DateTime(2024, 2, 15, 11, 49, 53, 230, DateTimeKind.Local).AddTicks(6480), "zynb.jabr@yahoo.com", "887.854.3564 x638" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, 345, الفنيدق, Ethiopia", "شناص", new DateTime(2024, 2, 15, 5, 3, 38, 669, DateTimeKind.Local).AddTicks(7673), "jabr_iyhab@hotmail.com", "1-813-697-9712 x565" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, طريق رسالت, 8, صيدا, Jersey", "سحار", new DateTime(2024, 2, 15, 2, 1, 7, 377, DateTimeKind.Local).AddTicks(5964), "rbya58@yahoo.com", "272-982-5495 x798" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع مالک اشتر, 248, أعزاز, Bahamas", "بجاية", new DateTime(2024, 2, 15, 0, 12, 45, 801, DateTimeKind.Local).AddTicks(3947), "iynas_aarf@yahoo.com", "962-810-0087" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق استاد قریب, 103, دير البلح, Japan", "روصو", new DateTime(2024, 2, 15, 6, 42, 8, 366, DateTimeKind.Local).AddTicks(5496), "zyd.sayd@gmail.com", "1-200-403-2149 x20336" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, طريق استاد قریب, 1, الخليل, Uruguay", "يريم", new DateTime(2024, 2, 15, 19, 8, 50, 290, DateTimeKind.Local).AddTicks(9836), "frydh16@gmail.com", "(480) 702-9083 x840" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 09, وادي زم, Colombia", "دير عطية", new DateTime(2024, 2, 15, 15, 33, 9, 148, DateTimeKind.Local).AddTicks(7342), "amjd_asar@yahoo.com", "825-836-8938 x2700" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, طريق حقانی, 98, حماة, Antigua and Barbuda", "بليث وين", new DateTime(2024, 2, 15, 17, 14, 6, 571, DateTimeKind.Local).AddTicks(619), "abyr.fuad47@gmail.com", "597.305.9114" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, 1, عطبرة, Greenland", "فاس", new DateTime(2024, 2, 15, 12, 40, 20, 850, DateTimeKind.Local).AddTicks(9094), "fryd98@yahoo.com", "207-818-3082 x83419" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, شارع مالک اشتر, 30, مقطع لحجار, Kuwait", "السليمانية", new DateTime(2024, 2, 15, 12, 45, 25, 218, DateTimeKind.Local).AddTicks(2364), "aayh35@gmail.com", "542.527.4016 x75689" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, دوار استاد قریب, 12, الدور, Colombia", "جبلة", new DateTime(2024, 2, 15, 18, 46, 46, 571, DateTimeKind.Local).AddTicks(6473), "jabr_marwf@yahoo.com", "(404) 210-7295 x086" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, 8829, بو سعادة, Bangladesh", "الرياض", new DateTime(2024, 2, 15, 9, 29, 35, 51, DateTimeKind.Local).AddTicks(4234), "tarq_fryd8@hotmail.com", "972.811.5306" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, طريق دیباجی, 7060, يريم, Pitcairn Islands", "حلبا", new DateTime(2024, 2, 15, 22, 45, 56, 441, DateTimeKind.Local).AddTicks(1834), "rym_hashm@hotmail.com", "(605) 628-3940 x652" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, 58, قرية الجهراء, Afghanistan", "نواكشوط", new DateTime(2024, 2, 15, 18, 51, 23, 105, DateTimeKind.Local).AddTicks(6823), "slah13@gmail.com", "(361) 358-3460" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, شارع موحد دانش, 93, الحسيمة, Guadeloupe", "توريرت", new DateTime(2024, 2, 15, 21, 29, 58, 559, DateTimeKind.Local).AddTicks(1150), "dana_asar53@hotmail.com", "320.297.6874 x299" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, طريق آذربایجان, 17, الدرعية, Mauritania", "تقورت", new DateTime(2024, 2, 15, 9, 55, 41, 3, DateTimeKind.Local).AddTicks(9489), "hsn.hsn@hotmail.com", "(705) 650-5198 x3523" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 258, القنيطرة, Saint Pierre and Miquelon", "خان يونس", new DateTime(2024, 2, 15, 21, 58, 44, 230, DateTimeKind.Local).AddTicks(8599), "aayh.araqy@yahoo.com", "484.792.6142" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, 1, التل, Mexico", "جرسيف", new DateTime(2024, 2, 15, 3, 47, 9, 91, DateTimeKind.Local).AddTicks(3935), "amjd.hashm@yahoo.com", "(865) 839-3927 x94792" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع راستوان, طريق آزادی, 36, الأقصر, Kazakhstan", "العيون", new DateTime(2024, 2, 15, 1, 11, 25, 50, DateTimeKind.Local).AddTicks(8180), "jmanh18@hotmail.com", "(365) 578-1382" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, 577, سكاكا, Paraguay", "تونس", new DateTime(2024, 2, 15, 0, 36, 53, 313, DateTimeKind.Local).AddTicks(8996), "salm.iyhab@gmail.com", "684-240-9725" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, 220, الفحيحيل, Mongolia", "سطيف", new DateTime(2024, 2, 15, 11, 18, 41, 503, DateTimeKind.Local).AddTicks(3421), "sayd.marwf@gmail.com", "382.449.6245" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, 73, جزيرة الحمراء, Central African Republic", "لوك", new DateTime(2024, 2, 15, 15, 6, 17, 994, DateTimeKind.Local).AddTicks(7956), "blal_amjd54@gmail.com", "231.276.1893" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اقبال لاهوری, 0, ذي سفال, Burundi", "بهلا", new DateTime(2024, 2, 15, 13, 18, 49, 642, DateTimeKind.Local).AddTicks(9710), "shymaa.hashm47@gmail.com", "1-851-249-5965 x2939" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, شارع کارگر شمالی, 0248, سيلبابي, Bolivia", "زلفي", new DateTime(2024, 2, 15, 4, 23, 11, 5, DateTimeKind.Local).AddTicks(20), "blal.asamh@hotmail.com", "(539) 363-8983" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, شارع آزادی, 77, المرسى, Palau", "سخنين", new DateTime(2024, 2, 15, 21, 49, 18, 727, DateTimeKind.Local).AddTicks(3851), "blal.asamh@gmail.com", "(313) 567-9826 x296" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آذربایجان, ميدان اجاره دار, 0674, كركوك, Solomon Islands", "خنيفرة", new DateTime(2024, 2, 15, 15, 25, 55, 417, DateTimeKind.Local).AddTicks(61), "zynb.salm86@hotmail.com", "398.351.4277" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, 5151, صفاقس, Ukraine", "جرسيف", new DateTime(2024, 2, 15, 13, 24, 31, 10, DateTimeKind.Local).AddTicks(6053), "rym.aqyl11@gmail.com", "770.424.2913 x6322" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, 399, الجنينة, Namibia", "السماوة", new DateTime(2024, 2, 15, 1, 43, 48, 163, DateTimeKind.Local).AddTicks(2089), "rqyh.iyhab45@hotmail.com", "1-968-956-7399 x276" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, ميدان شهید مطهری, 5916, جونية, Montserrat", "سمائل", new DateTime(2024, 2, 15, 4, 53, 21, 930, DateTimeKind.Local).AddTicks(753), "salm.marwf@yahoo.com", "719.792.9274" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, تقاطع دکتر چمران, 59, كيهيدي, Bhutan", "سعيدة", new DateTime(2024, 2, 15, 16, 31, 23, 858, DateTimeKind.Local).AddTicks(488), "mna84@gmail.com", "(438) 628-4522" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش مالک اشتر, شارع موحد دانش, 0733, بيجي, Algeria", "الخمس", new DateTime(2024, 2, 15, 15, 41, 34, 82, DateTimeKind.Local).AddTicks(2666), "hazm_tarq34@hotmail.com", "917.814.5328 x77647" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, 152, إب, New Zealand", "جلاجل", new DateTime(2024, 2, 15, 6, 21, 42, 791, DateTimeKind.Local).AddTicks(9470), "jabr21@gmail.com", "987.951.2916" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, تقاطع آزادی, 7577, نزوى, Sao Tome and Principe", "فرسان", new DateTime(2024, 2, 15, 21, 18, 43, 786, DateTimeKind.Local).AddTicks(7281), "salm34@yahoo.com", "(868) 478-7887" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق استاد قریب, 4, الجلفة, Uruguay", "بوتلميت", new DateTime(2024, 2, 15, 13, 26, 28, 101, DateTimeKind.Local).AddTicks(7408), "zynb49@yahoo.com", "483-898-5024 x84314" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 50, يبرود, Burkina Faso", "بيت الفقيه", new DateTime(2024, 2, 15, 16, 55, 13, 427, DateTimeKind.Local).AddTicks(221), "slah_fuad@yahoo.com", "(298) 434-9572 x25226" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, 6, زبيد, Lao People's Democratic Republic", "صافيتا", new DateTime(2024, 2, 15, 19, 48, 14, 136, DateTimeKind.Local).AddTicks(1666), "rqyh.hsn2@gmail.com", "268-698-6568" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, 59, وهران, Martinique", "صفوى", new DateTime(2024, 2, 15, 22, 30, 28, 496, DateTimeKind.Local).AddTicks(1277), "zynb2@hotmail.com", "(623) 419-3687" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش استاد قریب, شارع اقبال لاهوری, 44, شندي, Turks and Caicos Islands", "الدويم", new DateTime(2024, 2, 15, 17, 38, 51, 525, DateTimeKind.Local).AddTicks(2258), "hajr_zyd@gmail.com", "1-556-691-9287 x27578" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, ش دیباجی, 48, الإسكندرية, Pakistan", "ميت غمر", new DateTime(2024, 2, 15, 13, 28, 2, 234, DateTimeKind.Local).AddTicks(4459), "fryd_aarf@hotmail.com", "1-635-436-9999 x409" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, شارع یادگار امام, 6515, ريان, Virgin Islands, U.S.", "عين اعبيد", new DateTime(2024, 2, 15, 18, 2, 23, 336, DateTimeKind.Local).AddTicks(9255), "lma.iyhab@yahoo.com", "315.353.9644" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, 5, الليث, San Marino", "بنى سويف", new DateTime(2024, 2, 15, 14, 11, 59, 136, DateTimeKind.Local).AddTicks(7802), "zyd31@yahoo.com", "1-410-753-6685" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, طريق آذربایجان, 89, الخرج, Morocco", "الإسكندرية", new DateTime(2024, 2, 15, 14, 47, 36, 413, DateTimeKind.Local).AddTicks(2445), "farwq1@yahoo.com", "596.809.9930" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, تقاطع فاطمی, 5288, جد حفص, Gibraltar", "ضرما", new DateTime(2024, 2, 15, 21, 54, 35, 220, DateTimeKind.Local).AddTicks(1478), "hazm.jabr36@yahoo.com", "339-389-2003 x49253" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, تقاطع دستغیب, 2141, دهبان, Sao Tome and Principe", "كفر الدوار", new DateTime(2024, 2, 15, 20, 2, 3, 879, DateTimeKind.Local).AddTicks(4238), "lma28@hotmail.com", "790-560-5546 x697" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 96, رفحا, Singapore", "كربلاء", new DateTime(2024, 2, 15, 12, 19, 53, 956, DateTimeKind.Local).AddTicks(9125), "iynas.asamh60@yahoo.com", "950.793.9591" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, ميدان راستوان, 6, جسر الشغور, Saint Vincent and the Grenadines", "الرفاع الغربي", new DateTime(2024, 2, 15, 19, 1, 33, 709, DateTimeKind.Local).AddTicks(5521), "amjd.tarq12@hotmail.com", "(477) 612-5132 x392" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش کارگر شمالی, شارع یادگار امام, 72, الحريق, Grenada", "أعزاز", new DateTime(2024, 2, 15, 3, 46, 14, 929, DateTimeKind.Local).AddTicks(4862), "rbya69@gmail.com", "1-423-802-4327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 2201, الفيوم, Virgin Islands, British", "بنجرير", new DateTime(2024, 2, 15, 2, 54, 54, 648, DateTimeKind.Local).AddTicks(3958), "rbya.aashwr79@hotmail.com", "(421) 288-9490" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, ش یادگار امام, 0490, مدينة الحرير, Germany", "الموصل", new DateTime(2024, 2, 15, 0, 53, 31, 233, DateTimeKind.Local).AddTicks(3233), "farwq.araqy56@gmail.com", "349-465-7763 x163" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سباری, 379, سطيف, Northern Mariana Islands", "كفرشوبا", new DateTime(2024, 2, 15, 15, 29, 43, 135, DateTimeKind.Local).AddTicks(9352), "zynb_aqyl@gmail.com", "1-273-522-9746" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, طريق راستوان, 50, حيفا, Uzbekistan", "اكجوجت", new DateTime(2024, 2, 15, 1, 47, 42, 58, DateTimeKind.Local).AddTicks(4011), "salm.farwq@hotmail.com", "258.761.0054 x83070" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, دوار فاطمی, 373, بوتلميت, Macedonia", "زليطن", new DateTime(2024, 2, 15, 9, 54, 17, 199, DateTimeKind.Local).AddTicks(9966), "rqyh_hsn@hotmail.com", "1-884-826-1980 x2793" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, تقاطع راستوان, 6, جرجا, Yemen", "الفلوجة", new DateTime(2024, 2, 15, 19, 53, 11, 38, DateTimeKind.Local).AddTicks(163), "asamh.fryd3@yahoo.com", "(967) 286-5069 x352" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, 8, عفرين, Suriname", "اللاذقية", new DateTime(2024, 2, 15, 15, 36, 33, 189, DateTimeKind.Local).AddTicks(866), "amjd49@yahoo.com", "358-837-5495 x8396" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, تقاطع سباری, 7626, الحلة, Togo", "الرملة", new DateTime(2024, 2, 15, 22, 18, 0, 871, DateTimeKind.Local).AddTicks(5361), "lma79@yahoo.com", "(270) 555-9588" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, ميدان اجاره دار, 87, المنصورة, Central African Republic", "تزنيت", new DateTime(2024, 2, 15, 21, 14, 48, 393, DateTimeKind.Local).AddTicks(4314), "iyhab_aarf@gmail.com", "1-750-337-5099 x837" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, تقاطع اقبال لاهوری, 7, لؤلؤة قطر, Croatia", "الزاوية", new DateTime(2024, 2, 15, 0, 24, 49, 200, DateTimeKind.Local).AddTicks(6555), "tarq.slah15@yahoo.com", "222-912-3430 x42547" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, 873, السويس, Bosnia and Herzegovina", "الدامر", new DateTime(2024, 2, 15, 2, 4, 14, 496, DateTimeKind.Local).AddTicks(5659), "frydh.aarf@yahoo.com", "786-478-2062 x18975" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, 18, جعار, Tuvalu", "حفر الباطن", new DateTime(2024, 2, 15, 5, 23, 30, 209, DateTimeKind.Local).AddTicks(1298), "zyd.fryd@yahoo.com", "839-693-7348 x33750" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع واعظی, شارع راستوان, 3, القاهرة, Germany", "الناعورة", new DateTime(2024, 2, 15, 9, 10, 22, 834, DateTimeKind.Local).AddTicks(6569), "hazm_asamh@gmail.com", "791.516.3066" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, ش اقبال لاهوری, 170, القحطانية, Belgium", "الجديدة", new DateTime(2024, 2, 15, 0, 19, 4, 929, DateTimeKind.Local).AddTicks(9676), "aayh31@hotmail.com", "235.443.7031 x208" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, 283, أم قصر, Guinea-Bissau", "البتراء", new DateTime(2024, 2, 15, 3, 34, 51, 142, DateTimeKind.Local).AddTicks(5372), "jmanh68@yahoo.com", "996.970.2536 x14336" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, دوار سباری, 870, بعبدا, Seychelles", "مدينة الكويت", new DateTime(2024, 2, 15, 10, 23, 56, 831, DateTimeKind.Local).AddTicks(6586), "abyr43@hotmail.com", "1-332-807-9811 x832" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع ابوذر, 0252, بركاء, Kuwait", "القيصومة", new DateTime(2024, 2, 15, 20, 29, 5, 242, DateTimeKind.Local).AddTicks(8542), "arwa76@yahoo.com", "999-253-8417 x05804" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, دوار دکتر چمران, 5, يوبوكي, Cook Islands", "أم الفحم", new DateTime(2024, 2, 15, 21, 38, 31, 591, DateTimeKind.Local).AddTicks(6168), "rbya_azyz90@hotmail.com", "566.372.3897 x404" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, ش سمیه, 514, مكناس, Qatar", "السيب", new DateTime(2024, 2, 15, 12, 10, 30, 873, DateTimeKind.Local).AddTicks(5706), "fatmh_tarq@yahoo.com", "1-387-669-4282 x5486" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, ميدان امیرکبیر, 883, مدينة الصدر, Sao Tome and Principe", "باقة الغربية", new DateTime(2024, 2, 15, 6, 22, 5, 454, DateTimeKind.Local).AddTicks(5304), "amjd.fuad77@gmail.com", "(334) 633-7308" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, شارع مالک اشتر, 568, ورقلة, Indonesia", "البيضاء", new DateTime(2024, 2, 15, 14, 8, 46, 943, DateTimeKind.Local).AddTicks(6), "iyhab.aadm45@gmail.com", "(906) 801-6286 x6899" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش موحد دانش, 8, القرداحة, Puerto Rico", "السبت اولاد النمة", new DateTime(2024, 2, 15, 5, 6, 49, 11, DateTimeKind.Local).AddTicks(2059), "rym.hsn@yahoo.com", "673.366.8813 x30359" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 8, ضرما, Gambia", "طوباس", new DateTime(2024, 2, 15, 5, 21, 29, 878, DateTimeKind.Local).AddTicks(6428), "iynas.aadm@gmail.com", "474.357.5240 x72896" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دستغیب, 63, زلفي, Pitcairn Islands", "تلعفر", new DateTime(2024, 2, 15, 2, 23, 16, 264, DateTimeKind.Local).AddTicks(2482), "fryd_sayd@yahoo.com", "404.993.1148" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, شارع استاد قریب, 90, ملوى, Hungary", "العيون", new DateTime(2024, 2, 15, 10, 52, 1, 296, DateTimeKind.Local).AddTicks(9990), "mna_salm81@yahoo.com", "424.468.5449 x879" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع شهید مطهری, طريق امیرکبیر, 6407, الجزائر, Mongolia", "ذمار", new DateTime(2024, 2, 15, 13, 28, 23, 663, DateTimeKind.Local).AddTicks(5554), "jmanh_hsn@hotmail.com", "912.404.6434" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, دوار قدس, 332, أبو كمال, Kiribati", "أطار", new DateTime(2024, 2, 14, 23, 36, 13, 841, DateTimeKind.Local).AddTicks(6412), "sayd_azyz87@gmail.com", "679-363-9123 x613" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, تقاطع شهید مطهری, 87, ودمدني, Mongolia", "الدامور", new DateTime(2024, 2, 15, 15, 48, 22, 873, DateTimeKind.Local).AddTicks(67), "amjd33@hotmail.com", "745-741-4698" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 85, ليوا, Montenegro", "بشار", new DateTime(2024, 2, 15, 8, 35, 5, 965, DateTimeKind.Local).AddTicks(8904), "fatmh.farwq48@hotmail.com", "(616) 554-7957 x8667" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان حقانی, 44, العين, Kuwait", "الفحيحيل", new DateTime(2024, 2, 15, 0, 47, 0, 1, DateTimeKind.Local).AddTicks(3114), "fryd.farwq@hotmail.com", "499-397-6379 x2260" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع واعظی, 1587, صفوى, Guadeloupe", "ملوى", new DateTime(2024, 2, 15, 8, 53, 56, 343, DateTimeKind.Local).AddTicks(6124), "blal40@yahoo.com", "(257) 604-0241 x0925" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, تقاطع آزادی, 1, سمائل, Holy See (Vatican City State)", "وادي زم", new DateTime(2024, 2, 15, 2, 12, 42, 530, DateTimeKind.Local).AddTicks(2289), "iyhab67@gmail.com", "983.254.3359 x87731" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 72, القاهرة, Faroe Islands", "مدينة الكويت", new DateTime(2024, 2, 15, 7, 49, 43, 857, DateTimeKind.Local).AddTicks(909), "fuad_asamh@hotmail.com", "733.314.4575 x9842" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, تقاطع آذربایجان, 8, ضرما, Cape Verde", "الناصرية", new DateTime(2024, 2, 15, 5, 3, 8, 460, DateTimeKind.Local).AddTicks(3265), "rna_blal@gmail.com", "1-607-924-1893" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, طريق حقانی, 92, خريبكة, Burkina Faso", "سلمية", new DateTime(2024, 2, 15, 17, 9, 9, 255, DateTimeKind.Local).AddTicks(2568), "aadm30@yahoo.com", "878-873-4347" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار رسالت, شارع امیرکبیر, 381, سعيدة, Israel", "الجفر", new DateTime(2024, 2, 15, 9, 40, 24, 387, DateTimeKind.Local).AddTicks(8645), "iynas50@gmail.com", "1-358-477-2878" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, ميدان دکتر چمران, 106, الوكرة, Northern Mariana Islands", "الرياض", new DateTime(2024, 2, 15, 15, 0, 47, 793, DateTimeKind.Local).AddTicks(6398), "sayd.aashwr36@hotmail.com", "1-291-391-7094 x7520" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, تقاطع رسالت, 3, السويق, American Samoa", "القرداحة", new DateTime(2024, 2, 15, 6, 43, 55, 335, DateTimeKind.Local).AddTicks(9423), "aayh.salm0@yahoo.com", "391-551-5356" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, طريق سباری, 491, مصيرة, Svalbard & Jan Mayen Islands", "يريم", new DateTime(2024, 2, 15, 1, 3, 34, 577, DateTimeKind.Local).AddTicks(758), "aadm_salm25@yahoo.com", "1-598-752-1610 x204" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, طريق دکتر چمران, 4, ازرع, Paraguay", "أوبوك", new DateTime(2024, 2, 15, 20, 50, 28, 476, DateTimeKind.Local).AddTicks(146), "asamh_hsn80@hotmail.com", "899-444-9421" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, طريق ابوذر, 057, القنيطرة, Montserrat", "الحسكة", new DateTime(2024, 2, 15, 20, 44, 15, 664, DateTimeKind.Local).AddTicks(8259), "shymaa_zyd69@hotmail.com", "(613) 376-3737 x1206" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, دوار کارگر شمالی, 7, الكرك, Somalia", "كفر الشيخ", new DateTime(2024, 2, 15, 2, 46, 8, 999, DateTimeKind.Local).AddTicks(3975), "fuad.asamh8@hotmail.com", "934-839-9329" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, 0286, أريحا, French Southern Territories", "الجلفة", new DateTime(2024, 2, 15, 11, 55, 6, 30, DateTimeKind.Local).AddTicks(915), "aadm.rbya49@yahoo.com", "767.647.0505 x333" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اقبال لاهوری, 6698, إب, Suriname", "ذمار", new DateTime(2024, 2, 15, 6, 55, 10, 857, DateTimeKind.Local).AddTicks(4629), "lma20@gmail.com", "565.634.0727 x206" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, شارع حقانی, 6, بشار, Nicaragua", "العوجا", new DateTime(2024, 2, 14, 23, 23, 40, 578, DateTimeKind.Local).AddTicks(2911), "dana63@hotmail.com", "831.402.8033 x38134" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, ش آفریقا, 26, رفح, Argentina", "أخميم", new DateTime(2024, 2, 15, 18, 48, 48, 670, DateTimeKind.Local).AddTicks(1792), "jabr.azyz98@gmail.com", "(722) 759-8360" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع مالک اشتر, طريق آذربایجان, 7267, القرداحة, Nigeria", "تطوان", new DateTime(2024, 2, 15, 5, 35, 8, 255, DateTimeKind.Local).AddTicks(8423), "hsn.amjd@hotmail.com", "356.216.5023 x6754" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, شارع رسالت, 137, مرزق, Spain", "علي صبيح", new DateTime(2024, 2, 15, 6, 46, 38, 787, DateTimeKind.Local).AddTicks(3856), "rqyh.salm65@yahoo.com", "515.263.9619 x44521" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, 964, صلخد, Saint Vincent and the Grenadines", "المدية", new DateTime(2024, 2, 15, 11, 40, 30, 459, DateTimeKind.Local).AddTicks(9337), "rym43@yahoo.com", "497.514.7055" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, دوار حقانی, 118, الحسيمة, Somalia", "جيبوتي", new DateTime(2024, 2, 15, 7, 26, 21, 401, DateTimeKind.Local).AddTicks(3308), "sayd.marwf61@gmail.com", "1-949-828-8611 x928" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش راستوان, 4206, شيبه, Micronesia", "جزين", new DateTime(2024, 2, 15, 1, 26, 48, 638, DateTimeKind.Local).AddTicks(7624), "rna.aqyl@yahoo.com", "614.518.3819 x416" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, شارع امیرکبیر, 9, عجمان, Serbia", "ينبع", new DateTime(2024, 2, 15, 6, 11, 3, 51, DateTimeKind.Local).AddTicks(7572), "abyr32@hotmail.com", "880-861-7283" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, ش دیباجی, 7745, حلبا, Nigeria", "الميادين", new DateTime(2024, 2, 15, 1, 5, 8, 446, DateTimeKind.Local).AddTicks(1299), "sayd_blal@hotmail.com", "715.759.2493" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, 83, طبرق, Bolivia", "النهود", new DateTime(2024, 2, 15, 16, 44, 11, 569, DateTimeKind.Local).AddTicks(1929), "abyr_iyhab78@gmail.com", "465.429.7818 x49022" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان راستوان, 40, الرويس, Mexico", "الأقصر", new DateTime(2024, 2, 15, 6, 26, 24, 456, DateTimeKind.Local).AddTicks(558), "lma36@hotmail.com", "1-465-482-4056 x5689" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار سمیه, تقاطع دستغیب, 7156, حديثة, Cook Islands", "زبيد", new DateTime(2024, 2, 15, 20, 22, 30, 395, DateTimeKind.Local).AddTicks(6218), "sarh98@gmail.com", "1-723-220-4078 x67864" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, طريق یادگار امام, 9125, تيارت, Montserrat", "بورو", new DateTime(2024, 2, 15, 5, 51, 24, 587, DateTimeKind.Local).AddTicks(9730), "rna.slah97@gmail.com", "630.235.4579 x617" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, تقاطع هویزه, 9230, تيماء, Anguilla", "صيدا", new DateTime(2024, 2, 15, 14, 40, 47, 863, DateTimeKind.Local).AddTicks(2357), "lma62@yahoo.com", "1-896-397-9408 x0780" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق یادگار امام, ش رسالت, 7, باب الزوار, India", "مصراتة", new DateTime(2024, 2, 15, 12, 34, 45, 758, DateTimeKind.Local).AddTicks(7225), "frydh_rbya57@hotmail.com", "916.652.3568" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, طريق سمیه, 466, مال, Turkey", "خريبكة", new DateTime(2024, 2, 15, 11, 18, 12, 608, DateTimeKind.Local).AddTicks(4991), "hsn_zyd@hotmail.com", "887.396.5770 x8520" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 749, القامشلي, Dominican Republic", "بنجرير", new DateTime(2024, 2, 15, 12, 22, 17, 611, DateTimeKind.Local).AddTicks(6343), "dana.hashm91@hotmail.com", "(847) 742-4590 x358" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, دوار دکتر چمران, 0811, بريكة, Italy", "مادبا", new DateTime(2024, 2, 15, 14, 24, 15, 834, DateTimeKind.Local).AddTicks(5050), "tarq1@hotmail.com", "(433) 987-2657 x884" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 771, ازويرات, Montenegro", "هيت", new DateTime(2024, 2, 15, 6, 52, 49, 601, DateTimeKind.Local).AddTicks(6147), "zyd.hsn28@hotmail.com", "(650) 767-4921 x69244" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, ميدان حقانی, 172, المنستير, Nigeria", "سمائل", new DateTime(2024, 2, 15, 11, 48, 4, 902, DateTimeKind.Local).AddTicks(6328), "fryd80@hotmail.com", "1-965-902-4368 x10840" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, شارع ابوذر, 818, مكة المكرمة, Guatemala", "سمائل", new DateTime(2024, 2, 15, 3, 12, 25, 128, DateTimeKind.Local).AddTicks(7225), "dana_aqyl16@hotmail.com", "(404) 939-1687" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق فاطمی, ش آذربایجان, 980, ينبع, Belarus", "يامبيو", new DateTime(2024, 2, 15, 8, 39, 37, 671, DateTimeKind.Local).AddTicks(2020), "frydh_blal@yahoo.com", "822.267.5385 x72244" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آفریقا, 93, تكريت, Mauritania", "غرداية", new DateTime(2024, 2, 15, 21, 40, 40, 435, DateTimeKind.Local).AddTicks(6482), "blal_amjd85@yahoo.com", "(456) 711-3558" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, 791, الطينطان, Zambia", "يافا", new DateTime(2024, 2, 15, 16, 26, 29, 615, DateTimeKind.Local).AddTicks(3183), "slah.aadm@yahoo.com", "1-978-536-9784 x4257" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, ميدان واعظی, 4727, العين, Poland", "مسقط", new DateTime(2024, 2, 15, 22, 16, 37, 350, DateTimeKind.Local).AddTicks(2249), "iynas_jabr33@hotmail.com", "(760) 906-6682 x1564" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, ميدان اجاره دار, 0024, تنومة, Uruguay", "جرابلس", new DateTime(2024, 2, 15, 5, 32, 55, 275, DateTimeKind.Local).AddTicks(9360), "slah.sayd99@gmail.com", "(553) 657-4746" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, دوار دکتر چمران, 9173, الخمس, Svalbard & Jan Mayen Islands", "الرياض", new DateTime(2024, 2, 15, 10, 48, 22, 365, DateTimeKind.Local).AddTicks(1972), "hazm.asamh@gmail.com", "1-759-448-2206" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش قدس, 14, سيدي قاسم, Fiji", "تلعفر", new DateTime(2024, 2, 15, 9, 36, 34, 197, DateTimeKind.Local).AddTicks(7194), "slah83@yahoo.com", "(892) 999-9824" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, ش امیرکبیر, 9, تنومة, Namibia", "أم درمان", new DateTime(2024, 2, 15, 6, 8, 18, 102, DateTimeKind.Local).AddTicks(945), "zyd.jabr95@yahoo.com", "1-704-588-7539 x685" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, ش اجاره دار, 506, أعزاز, Denmark", "ولاتة", new DateTime(2024, 2, 15, 20, 2, 43, 908, DateTimeKind.Local).AddTicks(267), "rna_farwq@gmail.com", "695-605-6303" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, دوار قدس, 506, عفرين, Liechtenstein", "دبا", new DateTime(2024, 2, 15, 7, 17, 12, 444, DateTimeKind.Local).AddTicks(2033), "fatmh55@yahoo.com", "493.983.4842 x58598" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 3935, إزكي, Timor-Leste", "العضيلية", new DateTime(2024, 2, 15, 10, 10, 15, 361, DateTimeKind.Local).AddTicks(4390), "lma.hsn95@gmail.com", "623-254-2972" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, دوار آذربایجان, 0, قلعة السراغنة, Barbados", "شندي", new DateTime(2024, 2, 15, 9, 9, 6, 960, DateTimeKind.Local).AddTicks(2039), "mna_tarq@hotmail.com", "292-678-3562 x0376" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, 5, الخمس, Romania", "مدحاء", new DateTime(2024, 2, 15, 19, 14, 4, 525, DateTimeKind.Local).AddTicks(3891), "rna7@hotmail.com", "905-734-5566 x94307" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, دوار شهید مطهری, 6, أعزاز, China", "يي", new DateTime(2024, 2, 15, 3, 30, 46, 973, DateTimeKind.Local).AddTicks(6356), "rbya97@gmail.com", "1-576-583-6249 x4982" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, تقاطع اجاره دار, 3536, الخليل, Brunei Darussalam", "الحجرة", new DateTime(2024, 2, 14, 23, 27, 30, 804, DateTimeKind.Local).AddTicks(1535), "hajr78@yahoo.com", "596.824.3943 x19803" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, طريق واعظی, 65, الناظور, Kyrgyz Republic", "شبرا الخيمة", new DateTime(2024, 2, 15, 1, 12, 24, 501, DateTimeKind.Local).AddTicks(6077), "sarh.aqyl41@yahoo.com", "912.314.3292" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آذربایجان, 645, برديرا, Lesotho", "قنا", new DateTime(2024, 2, 15, 20, 30, 16, 89, DateTimeKind.Local).AddTicks(5229), "fatmh_hashm@yahoo.com", "910.497.6637 x3701" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, شارع فاطمی, 2, بيجي, Timor-Leste", "الدوادمي", new DateTime(2024, 2, 15, 8, 31, 35, 373, DateTimeKind.Local).AddTicks(5427), "asamh_amjd@yahoo.com", "1-896-781-4493" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, 2243, تلكلخ, Mozambique", "مال", new DateTime(2024, 2, 15, 14, 25, 58, 491, DateTimeKind.Local).AddTicks(5962), "fryd_jabr@hotmail.com", "611.822.5433" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, 16, حلب, Democratic People's Republic of Korea", "الرباط", new DateTime(2024, 2, 15, 15, 13, 35, 870, DateTimeKind.Local).AddTicks(8644), "iyhab75@hotmail.com", "281-497-3849" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, تقاطع سمیه, 0651, طنطا, Paraguay", "جباليا", new DateTime(2024, 2, 15, 3, 19, 43, 944, DateTimeKind.Local).AddTicks(1680), "hsn.amjd@hotmail.com", "1-296-796-5786" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, 911, عين العرب, Ukraine", "البغدادي", new DateTime(2024, 2, 15, 22, 17, 41, 961, DateTimeKind.Local).AddTicks(4862), "mna.marwf1@yahoo.com", "437-270-5638 x523" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, ميدان اقبال لاهوری, 86, تل رفعت, Guinea-Bissau", "تلعفر", new DateTime(2024, 2, 15, 12, 43, 41, 143, DateTimeKind.Local).AddTicks(2152), "sarh_fryd@hotmail.com", "1-795-375-2003 x2521" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, دوار موحد دانش, 9555, القطيف, Myanmar", "الكوت", new DateTime(2024, 2, 15, 1, 42, 32, 286, DateTimeKind.Local).AddTicks(5549), "rqyh_zyd@yahoo.com", "1-235-857-9483 x3022" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آذربایجان, طريق دکتر چمران, 46, البيضاء, Nicaragua", "زحلة", new DateTime(2024, 2, 15, 14, 49, 58, 203, DateTimeKind.Local).AddTicks(8966), "zynb.hsn@yahoo.com", "1-564-299-1601 x1227" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آفریقا, تقاطع استاد قریب, 1, عطبرة, Sao Tome and Principe", "يفرن", new DateTime(2024, 2, 15, 6, 42, 27, 323, DateTimeKind.Local).AddTicks(1459), "salm9@gmail.com", "640.359.3450 x940" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 07, هولهول, Turkmenistan", "الليث", new DateTime(2024, 2, 15, 9, 27, 29, 33, DateTimeKind.Local).AddTicks(3228), "sayd39@yahoo.com", "(963) 827-8740" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, 1852, سنار, Virgin Islands, British", "الرستاق", new DateTime(2024, 2, 15, 18, 26, 44, 6, DateTimeKind.Local).AddTicks(7507), "rna.aadm@hotmail.com", "325.451.3515 x4787" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان یادگار امام, دوار اقبال لاهوری, 392, باتنة, China", "الزرقاء", new DateTime(2024, 2, 15, 22, 8, 10, 61, DateTimeKind.Local).AddTicks(5799), "hajr93@hotmail.com", "432.767.7375" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, 932, عالي, Iceland", "ينبع", new DateTime(2024, 2, 15, 6, 39, 35, 202, DateTimeKind.Local).AddTicks(1406), "farwq16@yahoo.com", "(401) 485-7149 x554" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, طريق حقانی, 369, أسيوط, Gibraltar", "القامشلي", new DateTime(2024, 2, 15, 2, 4, 53, 828, DateTimeKind.Local).AddTicks(1037), "fatmh.aqyl17@gmail.com", "247.297.8707" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, ميدان سباری, 0843, بنزرت, Ukraine", "بعبدا", new DateTime(2024, 2, 15, 13, 26, 47, 504, DateTimeKind.Local).AddTicks(8544), "aayh.blal73@gmail.com", "1-364-433-7922 x43660" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, 332, خور أنجار, Hungary", "بدر حنين", new DateTime(2024, 2, 15, 18, 0, 8, 7, DateTimeKind.Local).AddTicks(3173), "arwa.marwf11@gmail.com", "(871) 253-0284 x9589" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, تقاطع امیرکبیر, 6, الناعورة, Bahamas", "كفر قاسم", new DateTime(2024, 2, 15, 1, 20, 1, 817, DateTimeKind.Local).AddTicks(2778), "frydh46@hotmail.com", "553.360.3062 x103" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, دوار امیرکبیر, 479, الرملة, Svalbard & Jan Mayen Islands", "العوجا", new DateTime(2024, 2, 15, 6, 24, 12, 649, DateTimeKind.Local).AddTicks(6358), "asamh_hsn12@gmail.com", "876-911-6402 x5084" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دکتر چمران, دوار آفریقا, 68, كفرنجة, Latvia", "سمائل", new DateTime(2024, 2, 15, 22, 41, 6, 903, DateTimeKind.Local).AddTicks(9242), "farwq14@hotmail.com", "(572) 380-6302 x354" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 6, 25, 16, 43, 20, 779, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 2, 15, 8, 15, 31, 423, DateTimeKind.Local).AddTicks(1818), "سالم ربيع", "Angela Lang", "عراقی and Sons", null, "5676453728014184928", "Congo", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 18, 6, 9, 44, 735, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 2, 15, 2, 46, 3, 368, DateTimeKind.Local).AddTicks(5814), "فؤاد عراقی", "Bartholome Kreiger", 0, "عراقی - طارق", null, "2863651640912193664", "Equatorial Guinea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 30, 6, 15, 52, 506, DateTimeKind.Local).AddTicks(5940), new DateTime(2024, 2, 15, 17, 1, 36, 415, DateTimeKind.Local).AddTicks(3778), "حازم عاشور", "Lina Greenfelder", 0, "عصار - حازم", null, "5974917751148390928", "Jordan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 1, 11, 22, 14, 27, 949, DateTimeKind.Local).AddTicks(8418), new DateTime(2024, 2, 15, 3, 3, 55, 887, DateTimeKind.Local).AddTicks(2277), "صلاح حسن", "Gianni Crist", 1, "فريد LLC", null, "449660411020975042", "Norfolk Island", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 12, 1, 2, 16, 25, 165, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 2, 15, 12, 3, 57, 44, DateTimeKind.Local).AddTicks(737), "منى أمجد", "Jovani Schumm", "فؤاد Group", null, "7820091479551445606", "Saint Pierre and Miquelon", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 8, 30, 4, 16, 21, 141, DateTimeKind.Local).AddTicks(8411), new DateTime(2024, 2, 15, 20, 52, 50, 217, DateTimeKind.Local).AddTicks(2480), "منى آدم", "Hester Gerlach", 1, "عزیز - أمجد", null, "6870693048389916027", "Tajikistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 10, 3, 21, 18, 47, 389, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 2, 15, 3, 47, 42, 755, DateTimeKind.Local).AddTicks(828), "حسن طارق", "Garrison Mraz", "عارف, معروف and هاشم", null, "1849643073176457432", "Bolivia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 4, 12, 12, 10, 48, 102, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 2, 15, 0, 45, 21, 296, DateTimeKind.Local).AddTicks(5116), "جابر‌ حازم", "Leanne Collins", "هاشم - عراقی", null, "1413329008183136623", "Zambia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 1, 12, 3, 41, 12, 276, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 2, 15, 18, 58, 42, 547, DateTimeKind.Local).AddTicks(7462), "فاروق فؤاد", "Saul Jast", 1, "فريد and Sons", null, "2455040823121876936", "Wallis and Futuna" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 4, 30, 20, 14, 22, 614, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 2, 15, 14, 53, 0, 108, DateTimeKind.Local).AddTicks(6623), "جمانة بلال", "Madeline Bauch", "فؤاد, عارف and بلال", null, "8078583512374832139", "Thailand", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 7, 10, 5, 28, 19, 379, DateTimeKind.Local).AddTicks(3781), new DateTime(2024, 2, 15, 20, 37, 37, 408, DateTimeKind.Local).AddTicks(3460), "إيهاب عصار", "Hannah Mitchell", 1, "بلال Inc", null, "8685644657753582701", "Latvia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 2, 4, 7, 49, 44, 287, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 2, 15, 19, 19, 12, 318, DateTimeKind.Local).AddTicks(2540), "أروى عاشور", "Vaughn Dare", "عاشور, سعيد and ربيع", null, "5853026250233770794", "Canada", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 7, 13, 22, 44, 19, 824, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 2, 15, 11, 42, 23, 282, DateTimeKind.Local).AddTicks(6594), "أسامة أمجد", "Judy Trantow", 1, "فؤاد, إيهاب and جابر‌", null, "4479102329314837380", "Cocos (Keeling) Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 5, 9, 11, 52, 7, 811, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 2, 15, 20, 9, 21, 606, DateTimeKind.Local).AddTicks(7539), "رقية حازم", "Clair Langosh", 0, "فاروق - عزیز", null, "619746198713618214", "Aruba", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 6, 21, 15, 28, 41, 793, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 2, 15, 19, 11, 19, 573, DateTimeKind.Local).AddTicks(1181), "ربيع عزیز", "Carole Willms", "فؤاد - فريد", null, "961287321379568998", "Madagascar" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 2, 3, 1, 50, 24, 364, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 2, 15, 2, 43, 27, 588, DateTimeKind.Local).AddTicks(4384), "فؤاد بلال", "Raoul Wuckert", 0, "آدم - جابر‌", null, "9149480537933608409", "Kenya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 7, 24, 20, 21, 41, 38, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 2, 15, 1, 22, 45, 682, DateTimeKind.Local).AddTicks(6279), "هاجر آدم", "Kaitlyn Hickle", 1, "إيهاب Inc", null, "5682456077145658382", "Reunion" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 5, 6, 19, 28, 2, 775, DateTimeKind.Local).AddTicks(9719), new DateTime(2024, 2, 15, 5, 16, 11, 290, DateTimeKind.Local).AddTicks(5345), "فاروق عزیز", "Itzel Emard", 1, "عارف Group", null, "4121265890252576562", "Montenegro", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1995, 12, 23, 12, 29, 28, 442, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 2, 15, 14, 56, 16, 844, DateTimeKind.Local).AddTicks(3393), "أمجد زيد", "Brendan Feil", "معروف, عصار and فؤاد", null, "6587348615974265949", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 13, 22, 33, 34, 954, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 2, 15, 20, 14, 43, 612, DateTimeKind.Local).AddTicks(2836), "هاجر ربيع", "Levi VonRueden", "حازم, جابر‌ and بلال", null, "1207220429780497737", "Kuwait", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 12, 17, 43, 15, 604, DateTimeKind.Local).AddTicks(5322), new DateTime(2024, 2, 15, 15, 27, 54, 596, DateTimeKind.Local).AddTicks(4336), "جابر‌ فؤاد", "Cynthia Wisozk", 0, "عارف and Sons", null, "8018806377188583927", "Maldives", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 12, 21, 15, 31, 1, 124, DateTimeKind.Local).AddTicks(9104), new DateTime(2024, 2, 15, 14, 21, 44, 640, DateTimeKind.Local).AddTicks(608), "جابر‌ بلال", "Iliana Labadie", 1, "آدم, إيهاب and فؤاد", null, "7461966873430430645", "South Africa", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 4, 16, 9, 12, 8, 112, DateTimeKind.Local).AddTicks(725), new DateTime(2024, 2, 15, 8, 21, 30, 499, DateTimeKind.Local).AddTicks(8580), "حسن هاشم", "Kaci Conn", "أمجد Group", null, "7236368006803385417", "French Polynesia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 5, 8, 19, 5, 2, 631, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 2, 15, 7, 46, 10, 138, DateTimeKind.Local).AddTicks(7434), "بلال عراقی", "Ceasar Carter", 1, "عزیز - زيد", null, "2612148504985000453", "Peru", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 2, 4, 18, 8, 29, 640, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 2, 15, 3, 54, 22, 156, DateTimeKind.Local).AddTicks(6748), "منى فؤاد", "Gregory Beatty", "عصار - حسن", null, "223895575574537501", "Qatar" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 11, 5, 13, 42, 56, 921, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 2, 15, 13, 13, 56, 217, DateTimeKind.Local).AddTicks(868), "فاروق حسن", "Julie Harvey", 0, "عصار, بلال and أمجد", null, "6564064155547243957", "Denmark", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 2, 18, 1, 38, 44, 404, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 2, 15, 7, 5, 29, 99, DateTimeKind.Local).AddTicks(6661), "ريم زيد", "Santos Strosin", "عراقی - عراقی", null, "2125758048969869655", "Iran", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 11, 13, 13, 6, 30, 593, DateTimeKind.Local).AddTicks(958), new DateTime(2024, 2, 15, 19, 14, 19, 215, DateTimeKind.Local).AddTicks(1891), "عبير صلاح", "Darwin Osinski", "سعيد - أسامة", null, "1169629654526203640", "Gabon" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 4, 7, 12, 46, 3, 583, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 2, 15, 13, 23, 4, 883, DateTimeKind.Local).AddTicks(6791), "حازم صلاح", "Garfield Klocko", "أمجد, بلال and فاروق", null, "549344129919559864", "Christmas Island", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 6, 7, 0, 36, 40, 991, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 2, 15, 11, 25, 55, 663, DateTimeKind.Local).AddTicks(3135), "ربيع آدم", "Elena Anderson", "سالم, سالم and عصار", null, "1074610810768410532", "Kuwait", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 8, 1, 14, 2, 55, 955, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 2, 15, 13, 35, 32, 653, DateTimeKind.Local).AddTicks(9925), "طارق ربيع", "Chris Bogisich", 1, "فؤاد, سالم and آدم", null, "2118422221845850184", "Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 7, 2, 5, 26, 23, 537, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 2, 15, 12, 45, 47, 959, DateTimeKind.Local).AddTicks(7118), "إيهاب أسامة", "Edison Schmitt", "آدم - سالم", null, "2485823447722701753", "Saint Kitts and Nevis", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 29, 3, 10, 18, 60, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 2, 15, 8, 40, 20, 69, DateTimeKind.Local).AddTicks(230), "دانا حازم", "Heidi Hermiston", 0, "عراقی, سالم and ربيع", null, "36098732429426646", "Ukraine", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1958, 9, 6, 14, 6, 52, 661, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 2, 15, 22, 55, 4, 808, DateTimeKind.Local).AddTicks(1818), "ريم عقیل", "Dennis White", 1, "عراقی Inc", null, "4304284365801778578", "Micronesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 3, 4, 15, 27, 29, 799, DateTimeKind.Local).AddTicks(6059), new DateTime(2024, 2, 15, 2, 24, 49, 676, DateTimeKind.Local).AddTicks(7452), "زيد حسن", "Brandi Altenwerth", 1, "آدم, ربيع and آدم", null, "3329711899181908399", "Antigua and Barbuda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 2, 27, 10, 42, 26, 332, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 2, 14, 23, 25, 37, 11, DateTimeKind.Local).AddTicks(4976), "آية عقیل", "Marlee Haag", 0, "طارق LLC", null, "5011615423988837471", "Reunion", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 5, 24, 22, 9, 30, 487, DateTimeKind.Local).AddTicks(3577), new DateTime(2024, 2, 15, 17, 32, 54, 873, DateTimeKind.Local).AddTicks(6520), "دانا معروف", "Kareem Sanford", "آدم, عارف and ربيع", null, "2567189402706701239", "Gibraltar", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 8, 19, 0, 2, 4, 996, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 2, 15, 9, 24, 11, 995, DateTimeKind.Local).AddTicks(4066), "إيناس حازم", "Trey Wiegand", 1, "هاشم, عقیل and فاروق", null, "8331245182671026343", "Yemen", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 1, 21, 7, 49, 24, 463, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 2, 15, 9, 34, 36, 67, DateTimeKind.Local).AddTicks(8119), "آدم معروف", "Allison Deckow", 0, "عقیل, صلاح and عزیز", null, "1270110870270010436", "Japan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 8, 23, 13, 16, 12, 220, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 2, 15, 18, 5, 58, 245, DateTimeKind.Local).AddTicks(3925), "أروى عزیز", "Ansley Swaniawski", 1, "ربيع - إيهاب", null, "7232249446851717638", "Seychelles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 3, 1, 8, 36, 3, 973, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 2, 15, 2, 51, 2, 726, DateTimeKind.Local).AddTicks(7027), "طارق عصار", "Pattie Ziemann", 0, "فؤاد - عارف", null, "1775312517622689195", "Aruba", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 10, 28, 5, 54, 51, 834, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 2, 15, 15, 53, 27, 268, DateTimeKind.Local).AddTicks(8587), "ربيع زيد", "Della Kshlerin", 1, "إيهاب - فاروق", null, "79534498956196842", "Ukraine", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 18, 13, 15, 37, 968, DateTimeKind.Local).AddTicks(7598), new DateTime(2024, 2, 15, 6, 22, 48, 284, DateTimeKind.Local).AddTicks(5262), "سعيد آدم", "Junior Zboncak", "طارق Inc", null, "2567823874020508902", "Sudan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 9, 7, 19, 12, 3, 146, DateTimeKind.Local).AddTicks(2775), new DateTime(2024, 2, 15, 22, 53, 26, 604, DateTimeKind.Local).AddTicks(6071), "آية فؤاد", "Loyal Jones", "زيد, ربيع and آدم", null, "7467802697130594457", "Oman" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 12, 1, 21, 55, 25, 18, DateTimeKind.Local).AddTicks(4299), new DateTime(2024, 2, 15, 13, 57, 26, 407, DateTimeKind.Local).AddTicks(1470), "ريم جابر‌", "Jules Rice", "حازم, هاشم and طارق", null, "3810039802625426563", "Saint Helena", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 1, 11, 16, 35, 57, 867, DateTimeKind.Local).AddTicks(3978), new DateTime(2024, 2, 15, 18, 36, 48, 95, DateTimeKind.Local).AddTicks(9297), "فريد حازم", "Amani Cormier", 1, "ربيع, فاروق and فؤاد", null, "5431191629474979858", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 12, 30, 18, 38, 43, 792, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 2, 15, 19, 49, 51, 638, DateTimeKind.Local).AddTicks(1159), "آدم آدم", "Karson Conn", 1, "بلال - فاروق", null, "490999204995971646", "Timor-Leste", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 10, 12, 19, 7, 24, 380, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 2, 15, 8, 32, 25, 608, DateTimeKind.Local).AddTicks(8745), "رنا فريد", "Vella MacGyver", 0, "حازم, أمجد and طارق", null, "9152417225473461654", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 8, 27, 23, 46, 44, 283, DateTimeKind.Local).AddTicks(4175), new DateTime(2024, 2, 15, 9, 45, 55, 729, DateTimeKind.Local).AddTicks(1080), "زينب ربيع", "Briana Jenkins", "أسامة and Sons", null, "3308176958225172619", "Macao", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 1, 14, 23, 46, 42, 956, DateTimeKind.Local).AddTicks(8364), new DateTime(2024, 2, 15, 18, 51, 19, 665, DateTimeKind.Local).AddTicks(3434), "دانا سعيد", "Tamara Daugherty", "عارف and Sons", null, "5053134138004439425", "South Africa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 3, 21, 18, 21, 16, 860, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 2, 15, 8, 36, 56, 339, DateTimeKind.Local).AddTicks(2113), "أروى حسن", "Mac Ledner", 0, "ربيع - فاروق", null, "7156889961147890220", "Cocos (Keeling) Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 21, 20, 26, 50, 292, DateTimeKind.Local).AddTicks(1785), new DateTime(2024, 2, 15, 5, 35, 37, 424, DateTimeKind.Local).AddTicks(8702), "جابر‌ ربيع", "Meda Reynolds", 1, "إيهاب Group", null, "1751052403750447656", "Czech Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 5, 20, 8, 15, 51, 793, DateTimeKind.Local).AddTicks(48), new DateTime(2024, 2, 15, 6, 59, 6, 513, DateTimeKind.Local).AddTicks(3127), "سارة فريد", "Britney D'Amore", "سالم - إيهاب", null, "4204110187676838433", "Turkey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 3, 21, 15, 24, 20, 200, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 2, 15, 21, 16, 56, 44, DateTimeKind.Local).AddTicks(7777), "حازم حازم", "Catharine Gerhold", "أمجد - أسامة", null, "3819936640969516360", "Guernsey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 5, 31, 21, 57, 54, 573, DateTimeKind.Local).AddTicks(8487), new DateTime(2024, 2, 15, 8, 16, 37, 540, DateTimeKind.Local).AddTicks(2854), "فاطمة ربيع", "Elissa Schroeder", 0, "عراقی LLC", null, "3447940688801423567", "Finland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 2, 2, 18, 31, 983, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 2, 15, 17, 42, 17, 27, DateTimeKind.Local).AddTicks(5940), "زينب عزیز", "Darrin Haley", 1, "فؤاد, زيد and عصار", null, "2798470818382948240", "Nepal", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 4, 19, 20, 24, 18, 330, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 2, 15, 10, 6, 47, 515, DateTimeKind.Local).AddTicks(5270), "حسن عراقی", "Gabriella Rogahn", 1, "أمجد, صلاح and عصار", null, "4417216091167304913", "United Arab Emirates", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 1, 27, 14, 18, 18, 990, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 2, 15, 14, 17, 53, 336, DateTimeKind.Local).AddTicks(9767), "سارة فاروق", "Alessandra Kiehn", "صلاح - آدم", null, "1728456119853924154", "Turks and Caicos Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1970, 3, 4, 4, 59, 55, 786, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 2, 14, 23, 45, 24, 328, DateTimeKind.Local).AddTicks(2445), "سارة فاروق", "Will Conroy", 0, "عزیز, سالم and بلال", null, "1316203387858364685", "Poland" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 12, 6, 4, 7, 0, 612, DateTimeKind.Local).AddTicks(3669), new DateTime(2024, 2, 15, 6, 22, 49, 622, DateTimeKind.Local).AddTicks(8700), "شيماء طارق", "Daisy Stehr", "جابر‌, عزیز and عقیل", null, "4743803141798541371", "Libyan Arab Jamahiriya", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 11, 6, 11, 3, 29, 607, DateTimeKind.Local).AddTicks(2614), new DateTime(2024, 2, 15, 7, 16, 39, 974, DateTimeKind.Local).AddTicks(8721), "بلال عارف", "Russell Kuhic", "زيد Group", null, "4630532607033069002", "Anguilla", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 12, 25, 21, 21, 41, 268, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 2, 15, 20, 1, 38, 298, DateTimeKind.Local).AddTicks(221), "فريدة بلال", "Lynn Gibson", 1, "عارف - عقیل", null, "688984753409155546", "Ecuador", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 11, 22, 16, 54, 40, 768, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 2, 15, 2, 59, 3, 768, DateTimeKind.Local).AddTicks(6448), "فريدة طارق", "Xzavier Lang", "عصار and Sons", null, "2837890765745654170", "Philippines", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 6, 1, 19, 19, 2, 492, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 2, 15, 16, 29, 14, 327, DateTimeKind.Local).AddTicks(6619), "زيد عاشور", "Cindy Leffler", 0, "عزیز LLC", null, "1093685104125931444", "Bahamas", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 2, 22, 7, 57, 40, 306, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 2, 15, 19, 9, 36, 21, DateTimeKind.Local).AddTicks(3935), "ريم عقیل", "Diana Hegmann", "عارف Group", null, "3164516352699654322", "Vanuatu", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 2, 14, 8, 29, 14, 959, DateTimeKind.Local).AddTicks(8926), new DateTime(2024, 2, 15, 17, 25, 55, 301, DateTimeKind.Local).AddTicks(5777), "رقية أسامة", "Chloe Stracke", 1, "جابر‌ Inc", null, "3291792212261469520", "Antigua and Barbuda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 6, 11, 29, 38, 237, DateTimeKind.Local).AddTicks(4959), new DateTime(2024, 2, 15, 18, 48, 52, 135, DateTimeKind.Local).AddTicks(7979), "رقية آدم", "Omari Feeney", 1, "طارق, معروف and عزیز", null, "115649765515294067", "Kenya", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 6, 9, 13, 35, 3, 786, DateTimeKind.Local).AddTicks(6146), new DateTime(2024, 2, 15, 2, 9, 5, 144, DateTimeKind.Local).AddTicks(8612), "طارق ربيع", "Lessie Huels", "فؤاد and Sons", null, "4577593565404043506", "Djibouti", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 2, 27, 20, 35, 3, 817, DateTimeKind.Local).AddTicks(5404), new DateTime(2024, 2, 15, 19, 12, 46, 374, DateTimeKind.Local).AddTicks(913), "إيهاب حازم", "Giovanny Kihn", 1, "معروف - معروف", null, "7615368487511833570", "Cuba", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 17, 10, 55, 37, 28, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 2, 15, 13, 2, 55, 240, DateTimeKind.Local).AddTicks(289), "أسامة زيد", "Kattie Hackett", 0, "عقیل Group", null, "7777605565089402912", "Albania", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 4, 28, 12, 18, 15, 910, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 2, 15, 14, 22, 35, 5, DateTimeKind.Local).AddTicks(6927), "عبير أسامة", "Lavern Gusikowski", "بلال Group", null, "5868723843046607134", "Western Sahara", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 7, 27, 11, 35, 14, 832, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 2, 15, 16, 53, 5, 977, DateTimeKind.Local).AddTicks(9481), "حسن صلاح", "Florida Lubowitz", "هاشم, بلال and آدم", null, "8641735109177220211", "Japan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 12, 13, 16, 34, 39, 543, DateTimeKind.Local).AddTicks(7643), new DateTime(2024, 2, 15, 14, 19, 29, 754, DateTimeKind.Local).AddTicks(1092), "صلاح آدم", "Andrew Shanahan", "صلاح - عصار", null, "7482646924218412043", "Algeria", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 1, 27, 18, 31, 0, 46, DateTimeKind.Local).AddTicks(3085), new DateTime(2024, 2, 15, 21, 24, 31, 916, DateTimeKind.Local).AddTicks(3609), "رنا حازم", "Stevie Schiller", 1, "عاشور - سعيد", null, "506420755302463532", "Poland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 6, 11, 13, 53, 50, 507, DateTimeKind.Local).AddTicks(5316), new DateTime(2024, 2, 15, 12, 40, 36, 67, DateTimeKind.Local).AddTicks(5503), "زينب سالم", "Linnea Weber", 0, "أسامة, آدم and سعيد", null, "7741757322599260106", "Portugal", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 2, 17, 15, 2, 49, 699, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 2, 15, 21, 59, 52, 745, DateTimeKind.Local).AddTicks(828), "رقية ربيع", "Alaina Franecki", 1, "سعيد, عاشور and فريد", null, "7612801920714673602", "Guyana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 12, 7, 20, 48, 8, 159, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 2, 15, 2, 53, 34, 429, DateTimeKind.Local).AddTicks(5744), "آدم آدم", "Ramon Krajcik", 0, "عارف - بلال", null, "7075027606047954612", "Norfolk Island", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 10, 31, 16, 44, 55, 607, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 2, 15, 21, 0, 3, 366, DateTimeKind.Local).AddTicks(2892), "عبير عاشور", "Naomi Heidenreich", "حازم - حسن", null, "7276792962362341357", "Iran", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 3, 11, 9, 31, 38, 793, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 2, 15, 9, 43, 42, 610, DateTimeKind.Local).AddTicks(4419), "لمى طارق", "Alexzander Considine", "عصار - عصار", null, "1687258381630532811", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 7, 1, 12, 17, 3, 751, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 2, 15, 10, 56, 47, 647, DateTimeKind.Local).AddTicks(9399), "زيد أمجد", "Effie Walsh", 1, "إيهاب LLC", null, "8687991301186050105", "Tuvalu" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 9, 20, 23, 40, 1, 951, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 2, 15, 5, 15, 4, 537, DateTimeKind.Local).AddTicks(3806), "إيهاب حسن", "Ora Beatty", 0, "عارف - فاروق", null, "8735147736165452952", "British Indian Ocean Territory (Chagos Archipelago)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 9, 2, 5, 2, 57, 370, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 2, 15, 6, 40, 14, 172, DateTimeKind.Local).AddTicks(4663), "دانا سعيد", "Savanna Nikolaus", "ربيع, فاروق and طارق", null, "5753912502538059818", "Jamaica", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 5, 27, 10, 54, 22, 296, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 2, 15, 16, 42, 38, 235, DateTimeKind.Local).AddTicks(8167), "سالم سالم", "Jordon Cartwright", 0, "بلال, إيهاب and عصار", null, "9098276907099994464", "Lebanon", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2002, 2, 14, 8, 17, 25, 933, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 2, 15, 8, 30, 26, 369, DateTimeKind.Local).AddTicks(2882), "عبير سعيد", "Reid Franecki", "عراقی, إيهاب and أمجد", null, "7456886382895872484", "Christmas Island" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 11, 12, 1, 39, 39, 159, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 2, 15, 18, 57, 41, 200, DateTimeKind.Local).AddTicks(2053), "رنا أمجد", "Federico Gerhold", 0, "سالم - فؤاد", null, "784414598364309710", "Maldives", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 3, 18, 9, 20, 2, 60, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 2, 15, 5, 56, 53, 876, DateTimeKind.Local).AddTicks(229), "زيد معروف", "Wilson Barton", "عاشور, فؤاد and صلاح", null, "5546227842576893298", "Virgin Islands, U.S." });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 8, 13, 14, 28, 23, 777, DateTimeKind.Local).AddTicks(5137), new DateTime(2024, 2, 15, 9, 30, 27, 562, DateTimeKind.Local).AddTicks(4793), "سارة بلال", "Emanuel Block", "سالم, هاشم and أسامة", null, "7133969966285509294", "Guinea", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 1, 29, 9, 30, 9, 515, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 2, 15, 3, 7, 5, 994, DateTimeKind.Local).AddTicks(9750), "ربيع أمجد", "Alana Lynch", 1, "طارق Inc", null, "2829346302980483076", "Ghana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 7, 11, 34, 30, 707, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 2, 15, 12, 45, 41, 439, DateTimeKind.Local).AddTicks(1215), "إيهاب صلاح", "Dedric Walter", 0, "صلاح Inc", null, "8781093653993039681", "Singapore", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 5, 6, 7, 48, 57, 131, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 2, 15, 5, 21, 49, 978, DateTimeKind.Local).AddTicks(194), "منى بلال", "Ransom Keebler", 0, "أسامة, عزیز and حسن", null, "1063633797097411714", "French Southern Territories" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 2, 9, 1, 56, 8, 951, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 2, 15, 6, 48, 28, 715, DateTimeKind.Local).AddTicks(8724), "فاروق سعيد", "Robin Heidenreich", "هاشم LLC", null, "5035099435796552618", "Romania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 2, 26, 18, 0, 51, 927, DateTimeKind.Local).AddTicks(7897), new DateTime(2024, 2, 15, 19, 6, 32, 570, DateTimeKind.Local).AddTicks(4647), "آية زيد", "Marc Bauch", "فريد - عصار", null, "6247340081636055502", "France", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 28, 0, 26, 30, 624, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 2, 15, 16, 38, 33, 400, DateTimeKind.Local).AddTicks(8934), "شيماء زيد", "Brandyn Parisian", 1, "سعيد Inc", null, "7566854360230739932", "Pitcairn Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 12, 26, 19, 39, 9, 659, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 2, 15, 8, 21, 10, 301, DateTimeKind.Local).AddTicks(4982), "فاروق جابر‌", "Karlee Hamill", "عراقی - عصار", null, "7447188977862301063", "Reunion", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 5, 15, 16, 19, 57, 633, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 2, 15, 5, 11, 17, 55, DateTimeKind.Local).AddTicks(4128), "أروى معروف", "Makenzie Kreiger", 1, "عقیل, عارف and أمجد", null, "1542275811756341192", "Macao", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 1, 9, 18, 3, 8, 867, DateTimeKind.Local).AddTicks(3281), new DateTime(2024, 2, 15, 17, 10, 50, 392, DateTimeKind.Local).AddTicks(341), "آية حازم", "Ramiro Dooley", 1, "إيهاب LLC", null, "8575467327892295154", "Kenya", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 1, 9, 4, 15, 42, 446, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 2, 15, 8, 35, 46, 480, DateTimeKind.Local).AddTicks(4208), "ربيع فؤاد", "Dallin Nicolas", "جابر‌ - عزیز", null, "2036265806366659744", "Jordan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 10, 4, 21, 22, 58, 451, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 2, 15, 12, 4, 20, 526, DateTimeKind.Local).AddTicks(5240), "حسن جابر‌", "Libby Lowe", 0, "زيد, حسن and بلال", null, "1501540431823296018", "Belgium", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 4, 10, 10, 56, 46, 33, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 2, 15, 20, 32, 30, 262, DateTimeKind.Local).AddTicks(3356), "فاطمة ربيع", "Maia McKenzie", 1, "آدم, ربيع and عارف", null, "5670586966262898138", "Guam", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 5, 9, 10, 49, 43, 293, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 2, 15, 19, 43, 1, 566, DateTimeKind.Local).AddTicks(9109), "حسن فاروق", "Lexi Kunze", "فاروق - صلاح", null, "3099376241092633683", "Netherlands Antilles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 6, 25, 2, 37, 50, 9, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 2, 15, 2, 49, 17, 294, DateTimeKind.Local).AddTicks(5915), "سالم أمجد", "Ephraim Greenfelder", "عقیل, عارف and عقیل", null, "5763013758870952775", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 10, 21, 19, 25, 26, 880, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 2, 15, 5, 29, 24, 759, DateTimeKind.Local).AddTicks(3566), "أروى عزیز", "Makenzie Adams", "آدم - معروف", null, "1103668829428312463", "Bolivia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 10, 27, 14, 52, 35, 211, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 2, 15, 8, 27, 10, 776, DateTimeKind.Local).AddTicks(2231), "شيماء فؤاد", "Scot Nader", 0, "أسامة - عراقی", null, "869820514273969084", "Tuvalu", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 1, 21, 19, 2, 21, 109, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 2, 15, 0, 2, 55, 980, DateTimeKind.Local).AddTicks(1314), "فريد سعيد", "Meredith Zulauf", "طارق LLC", null, "6655569388121509455", "Germany", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 24, 21, 45, 32, 276, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 2, 15, 2, 56, 31, 429, DateTimeKind.Local).AddTicks(2328), "فاروق سعيد", "Houston Bashirian", "صلاح and Sons", null, "5872883647815795879", "Netherlands Antilles", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 1, 20, 19, 57, 27, 455, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 2, 15, 7, 26, 37, 606, DateTimeKind.Local).AddTicks(5654), "جابر‌ آدم", "Camila Bruen", 0, "صلاح - عصار", null, "5601041833085904715", "Algeria", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 3, 2, 18, 57, 18, 736, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 2, 15, 15, 12, 58, 888, DateTimeKind.Local).AddTicks(5990), "حسن إيهاب", "Emely Doyle", "فؤاد LLC", null, "271360126935026520", "Western Sahara" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 18, 20, 55, 20, 763, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 2, 15, 12, 6, 1, 741, DateTimeKind.Local).AddTicks(6784), "لمى حازم", "Guido Zemlak", "جابر‌, عارف and آدم", null, "3655345678200194074", "Macedonia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 1, 24, 13, 42, 22, 141, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 2, 15, 0, 32, 58, 290, DateTimeKind.Local).AddTicks(9123), "عبير فاروق", "Christine Hudson", "حسن, زيد and عارف", null, "3960414330202984764", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 28, 8, 9, 44, 341, DateTimeKind.Local).AddTicks(6401), new DateTime(2024, 2, 15, 19, 40, 16, 895, DateTimeKind.Local).AddTicks(3834), "جمانة عارف", "Susan Hills", "معروف and Sons", null, "1004943197039311615", "Mali", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 10, 2, 6, 15, 50, 617, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 2, 15, 3, 40, 23, 743, DateTimeKind.Local).AddTicks(4930), "فريدة سالم", "Kaylie Ullrich", "زيد, عاشور and جابر‌", null, "4996541770123632270", "Brazil", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 4, 14, 21, 55, 51, 221, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 2, 15, 13, 17, 38, 598, DateTimeKind.Local).AddTicks(7682), "رقية حسن", "Candida Satterfield", "حسن Group", null, "2134990018237413087", "Ecuador", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 10, 11, 14, 37, 15, 21, DateTimeKind.Local).AddTicks(753), new DateTime(2024, 2, 15, 2, 24, 20, 714, DateTimeKind.Local).AddTicks(3186), "آدم عارف", "Jamir Lowe", "جابر‌ - أمجد", null, "1149757570824362453", "Peru", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 7, 12, 8, 0, 41, 104, DateTimeKind.Local).AddTicks(7793), new DateTime(2024, 2, 15, 1, 25, 50, 147, DateTimeKind.Local).AddTicks(9911), "ريم سعيد", "Jacky Klocko", "طارق, أسامة and عزیز", null, "6658326037684402633", "Bahrain" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 12, 31, 5, 25, 23, 728, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 2, 15, 8, 17, 36, 866, DateTimeKind.Local).AddTicks(1339), "سارة إيهاب", "Davion Corwin", "عصار - عصار", null, "145722965188690708", "China", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 24, 16, 19, 28, 467, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 2, 15, 10, 59, 38, 305, DateTimeKind.Local).AddTicks(3490), "منى إيهاب", "Raymundo Beahan", "عزیز LLC", null, "5779863455378247171", "Bermuda", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 9, 30, 3, 39, 34, 754, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 2, 15, 22, 6, 46, 478, DateTimeKind.Local).AddTicks(2277), "رقية صلاح", "Mittie Durgan", 1, "بلال - إيهاب", null, "8896197831130674498", "Malawi", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 2, 4, 4, 1, 26, 50, DateTimeKind.Local).AddTicks(1482), new DateTime(2024, 2, 15, 3, 29, 16, 433, DateTimeKind.Local).AddTicks(9362), "لمى عراقی", "Karianne Steuber", 1, "إيهاب and Sons", null, "4179855636506695317", "Kyrgyz Republic", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 11, 23, 9, 38, 53, 254, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 2, 15, 5, 30, 10, 996, DateTimeKind.Local).AddTicks(781), "ريم حسن", "Macie Blick", 0, "حازم, أسامة and فاروق", null, "6692075894646831126", "Comoros", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 2, 5, 18, 29, 33, 637, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 2, 15, 5, 46, 1, 816, DateTimeKind.Local).AddTicks(3740), "فريد سالم", "Deondre Schneider", "سالم - عصار", null, "1860688302560823111", "Netherlands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1958, 9, 29, 23, 31, 44, 794, DateTimeKind.Local).AddTicks(8232), new DateTime(2024, 2, 15, 19, 36, 21, 871, DateTimeKind.Local).AddTicks(6437), "إيناس فريد", "Rene Ritchie", "إيهاب, جابر‌ and عزیز", null, "2448515267952216371", "United Kingdom" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 6, 7, 20, 39, 58, 176, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 2, 15, 6, 11, 59, 308, DateTimeKind.Local).AddTicks(3343), "إيهاب سالم", "Nia Gutkowski", 1, "طارق and Sons", null, "4600534261742108203", "Belarus", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 8, 17, 23, 46, 9, 307, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 2, 15, 19, 5, 1, 910, DateTimeKind.Local).AddTicks(2184), "فريد معروف", "Cynthia Bashirian", "فؤاد - طارق", null, "1048731530661899645", "Oman", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 2, 14, 22, 38, 33, 996, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 2, 15, 3, 42, 28, 820, DateTimeKind.Local).AddTicks(3372), "أروى عراقی", "Dock Crona", "حازم, هاشم and سالم", null, "2040603817394896161", "Russian Federation", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 7, 21, 18, 1, 13, 104, DateTimeKind.Local).AddTicks(2117), new DateTime(2024, 2, 15, 22, 20, 56, 461, DateTimeKind.Local).AddTicks(5953), "ربيع سعيد", "Tavares Casper", 1, "زيد Inc", null, "5938777685097219212", "Kenya", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 21, 20, 42, 54, 922, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 2, 15, 11, 18, 21, 215, DateTimeKind.Local).AddTicks(8782), "آدم فؤاد", "Sheila Kling", "فاروق, فؤاد and عاشور", null, "1181491386941780351", "Austria", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 5, 11, 6, 49, 8, 188, DateTimeKind.Local).AddTicks(9598), new DateTime(2024, 2, 15, 6, 7, 3, 346, DateTimeKind.Local).AddTicks(2027), "سالم حازم", "Bart Larson", 1, "سعيد - عصار", null, "4140316741505345245", "Guinea-Bissau" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 4, 4, 2, 22, 37, 34, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 2, 15, 14, 9, 57, 752, DateTimeKind.Local).AddTicks(9589), "إيهاب عصار", "Fern Rodriguez", 1, "فريد - عراقی", null, "599238005717055778", "Isle of Man", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 2, 2, 5, 48, 46, 628, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 2, 15, 8, 39, 5, 605, DateTimeKind.Local).AddTicks(8979), "لمى عراقی", "Kieran Greenholt", 0, "عارف, طارق and إيهاب", null, "5833321010933666331", "United States Minor Outlying Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 11, 12, 5, 7, 42, 123, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 2, 15, 20, 24, 30, 777, DateTimeKind.Local).AddTicks(4289), "منى عقیل", "Lamont Brakus", "عزیز - سعيد", null, "8387892135437449737", "Gibraltar" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 18, 11, 5, 14, 48, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 2, 15, 18, 48, 16, 828, DateTimeKind.Local).AddTicks(9086), "إيهاب زيد", "Janet Donnelly", "أسامة - هاشم", null, "8812154273231671801", "Romania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 4, 23, 8, 52, 40, 658, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 2, 15, 3, 14, 24, 800, DateTimeKind.Local).AddTicks(4562), "دانا عارف", "Jaeden Hermann", 0, "عاشور - جابر‌", null, "6804963095719421085", "Austria", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 10, 16, 13, 46, 8, 148, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 2, 15, 9, 57, 31, 437, DateTimeKind.Local).AddTicks(2356), "هاجر زيد", "Fay Hilll", 0, "عاشور, بلال and حسن", null, "58583581714091984", "Uganda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 8, 7, 3, 36, 18, 320, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 2, 15, 20, 23, 49, 281, DateTimeKind.Local).AddTicks(130), "جابر‌ زيد", "Marjory Mertz", "سالم Group", null, "658672809492278375", "Norway", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 11, 6, 8, 19, 35, 744, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 2, 15, 20, 37, 0, 678, DateTimeKind.Local).AddTicks(3159), "أسامة إيهاب", "Omari Cormier", 1, "ربيع - سعيد", null, "7051016922865812170", "Armenia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 6, 3, 19, 18, 56, 115, DateTimeKind.Local).AddTicks(3846), new DateTime(2024, 2, 15, 22, 4, 9, 460, DateTimeKind.Local).AddTicks(7804), "ربيع عصار", "Arielle Metz", "زيد Group", null, "6080896874207698603", "Paraguay", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 5, 2, 14, 8, 59, 748, DateTimeKind.Local).AddTicks(7548), new DateTime(2024, 2, 15, 1, 23, 30, 300, DateTimeKind.Local).AddTicks(6230), "شيماء فاروق", "Arlo Nienow", 1, "أمجد - عصار", null, "8500050446424763128", "Japan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 4, 2, 8, 13, 40, 126, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 2, 15, 5, 57, 50, 670, DateTimeKind.Local).AddTicks(8559), "جمانة فؤاد", "Clemens Mitchell", "سعيد, إيهاب and زيد", null, "6047556514049267646", "Saint Pierre and Miquelon", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 9, 17, 5, 47, 8, 922, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 2, 15, 13, 58, 55, 282, DateTimeKind.Local).AddTicks(1702), "ربيع حسن", "Pearl Haley", "عارف LLC", null, "634664961578875483", "Latvia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 4, 15, 11, 40, 13, 296, DateTimeKind.Local).AddTicks(9623), new DateTime(2024, 2, 15, 7, 58, 6, 531, DateTimeKind.Local).AddTicks(3402), "أمجد حازم", "Dangelo Kris", "أمجد and Sons", null, "6484102468601731874", "Cambodia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 8, 18, 15, 6, 129, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 2, 15, 20, 7, 14, 734, DateTimeKind.Local).AddTicks(5707), "فؤاد عقیل", "Dena Hessel", 1, "أسامة LLC", null, "5190263514706567153", "Kyrgyz Republic", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 3, 27, 19, 6, 48, 793, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 2, 15, 6, 16, 2, 208, DateTimeKind.Local).AddTicks(1517), "فاروق عزیز", "Sanford Heaney", "آدم, عارف and آدم", null, "5397208010203554157", "British Indian Ocean Territory (Chagos Archipelago)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1999, 5, 12, 19, 38, 56, 543, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 2, 15, 7, 34, 49, 54, DateTimeKind.Local).AddTicks(3418), "منى صلاح", "Seth Dach", 1, "هاشم - زيد", null, "7400761760661006451", "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 7, 12, 21, 9, 39, 605, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 2, 15, 15, 56, 54, 129, DateTimeKind.Local).AddTicks(781), "ربيع أمجد", "Walter Boyle", 0, "جابر‌ - آدم", null, "1780977846498519429", "Latvia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 5, 15, 19, 41, 44, 572, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 2, 15, 10, 51, 18, 662, DateTimeKind.Local).AddTicks(5895), "أمجد إيهاب", "Aaliyah Senger", 1, "بلال LLC", null, "8746604026045739154", "Kazakhstan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 10, 23, 13, 34, 59, 148, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 2, 15, 14, 8, 53, 274, DateTimeKind.Local).AddTicks(543), "ربيع فاروق", "Flo Beatty", 0, "صلاح, عزیز and معروف", null, "5187126833685098836", "Peru", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 9, 15, 12, 29, 43, 658, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 2, 14, 23, 51, 56, 108, DateTimeKind.Local).AddTicks(9914), "آدم صلاح", "Francisca Wisozk", 0, "صلاح, عقیل and إيهاب", null, "7642034221446928166", "Indonesia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 11, 8, 17, 54, 52, 756, DateTimeKind.Local).AddTicks(5956), new DateTime(2024, 2, 15, 13, 16, 14, 710, DateTimeKind.Local).AddTicks(7502), "صلاح حسن", "Bonnie Gleichner", 0, "صلاح LLC", null, "9199216663141641003", "Gabon", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 3, 10, 18, 44, 44, 173, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 2, 15, 20, 52, 30, 904, DateTimeKind.Local).AddTicks(4646), "ربيع حازم", "Vivianne Watsica", "حسن - آدم", null, "3801671420965924489", "Cocos (Keeling) Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 9, 27, 3, 29, 47, 572, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 2, 15, 20, 4, 23, 519, DateTimeKind.Local).AddTicks(7434), "دانا حازم", "Serenity Rippin", 0, "طارق, عراقی and إيهاب", null, "557502401696271563", "Kuwait", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 7, 27, 11, 9, 9, 789, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 2, 15, 13, 21, 11, 125, DateTimeKind.Local).AddTicks(1161), "فاروق زيد", "Amina Greenfelder", 1, "صلاح - عقیل", null, "362301777860740055", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 10, 5, 23, 24, 15, 371, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 2, 15, 14, 22, 4, 23, DateTimeKind.Local).AddTicks(1316), "فريد ربيع", "Hadley Treutel", 1, "فريد - عراقی", null, "1966191095541372431", "Kazakhstan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 8, 9, 17, 28, 41, 768, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 2, 15, 5, 4, 36, 315, DateTimeKind.Local).AddTicks(480), "ربيع فريد", "Chester Hills", 0, "فؤاد, صلاح and عارف", null, "6699391715441191365", "Namibia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 3, 13, 17, 11, 21, 928, DateTimeKind.Local).AddTicks(8463), new DateTime(2024, 2, 15, 10, 29, 22, 264, DateTimeKind.Local).AddTicks(964), "شيماء فؤاد", "Merlin Harris", "عاشور, فريد and أسامة", null, "386478179545551705", "Croatia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 2, 23, 6, 14, 50, 69, DateTimeKind.Local).AddTicks(2299), new DateTime(2024, 2, 15, 8, 49, 46, 432, DateTimeKind.Local).AddTicks(9712), "لمى إيهاب", "Tyreek Cremin", "صلاح - طارق", null, "5267038291774543277", "Isle of Man", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 2, 1, 14, 28, 2, 404, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 2, 15, 18, 10, 44, 340, DateTimeKind.Local).AddTicks(8823), "إيناس هاشم", "Rosalia Stamm", 1, "فؤاد - ربيع", null, "6929451426934321440", "Slovakia (Slovak Republic)", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 8, 7, 22, 12, 12, 76, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 2, 15, 11, 11, 51, 622, DateTimeKind.Local).AddTicks(1332), "إيناس صلاح", "Katheryn Von", 1, "عراقی, صلاح and عارف", null, "2347967121077517591", "United States of America", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 11, 2, 3, 0, 50, 148, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 2, 15, 12, 32, 18, 901, DateTimeKind.Local).AddTicks(1576), "حازم حازم", "Walter Hettinger", 0, "عصار, بلال and عصار", null, "2801340743191830323", "Georgia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 6, 12, 7, 40, 48, 146, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 2, 15, 22, 2, 50, 582, DateTimeKind.Local).AddTicks(3578), "إيهاب عقیل", "Crawford Goyette", "فريد - أسامة", null, "2658259788910995731", "Romania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 2, 6, 6, 55, 48, 958, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 2, 15, 14, 17, 31, 222, DateTimeKind.Local).AddTicks(9593), "ربيع ربيع", "Tomasa Aufderhar", "آدم Inc", null, "6715815806107453221", "Sao Tome and Principe", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 1, 30, 3, 56, 4, 732, DateTimeKind.Local).AddTicks(6388), new DateTime(2024, 2, 15, 19, 39, 25, 377, DateTimeKind.Local).AddTicks(3137), "آية عصار", "Major Halvorson", "معروف - عزیز", null, "1572648783989266942", "Antigua and Barbuda", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 1, 24, 12, 29, 12, 49, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 2, 15, 4, 13, 33, 620, DateTimeKind.Local).AddTicks(2555), "ربيع فريد", "Josiane Mraz", 0, "طارق LLC", null, "4392084923600940079", "Paraguay", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 3, 26, 22, 5, 44, 102, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 2, 15, 16, 50, 44, 690, DateTimeKind.Local).AddTicks(9188), "سالم سالم", "Candice Deckow", "آدم, طارق and جابر‌", null, "7059173185241903498", "Benin", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 5, 26, 15, 39, 38, 81, DateTimeKind.Local).AddTicks(2724), new DateTime(2024, 2, 15, 18, 21, 22, 809, DateTimeKind.Local).AddTicks(2833), "زينب سالم", "Akeem Green", 1, "أمجد LLC", null, "3095430647667467222", "Spain", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 1, 11, 17, 18, 9, 867, DateTimeKind.Local).AddTicks(8934), new DateTime(2024, 2, 15, 14, 14, 11, 380, DateTimeKind.Local).AddTicks(9996), "زيد عقیل", "Timmy Daugherty", "هاشم - عاشور", null, "6082599024025079340", "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 8, 18, 15, 36, 59, 354, DateTimeKind.Local).AddTicks(9639), new DateTime(2024, 2, 15, 5, 19, 55, 24, DateTimeKind.Local).AddTicks(5096), "منى حازم", "Jed Jacobs", "زيد - أمجد", null, "7712643369235361987", "Montserrat", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 1, 15, 2, 3, 37, 63, DateTimeKind.Local).AddTicks(6054), new DateTime(2024, 2, 15, 15, 13, 23, 358, DateTimeKind.Local).AddTicks(2383), "صلاح عاشور", "Sasha Ward", 1, "أمجد - عقیل", null, "7071157693374157514", "French Polynesia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 6, 24, 13, 45, 30, 557, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 2, 15, 8, 39, 52, 45, DateTimeKind.Local).AddTicks(8024), "لمى عزیز", "Jaylan Fay", 0, "سعيد Inc", null, "7396973034824695770", "Tanzania", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 14, 2, 3, 45, 804, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 2, 15, 9, 41, 16, 112, DateTimeKind.Local).AddTicks(1038), "سعيد فريد", "Isaias Blick", "زيد - فؤاد", null, "6253865131440357185", "Benin", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 13, 14, 51, 3, 909, DateTimeKind.Local).AddTicks(1986), new DateTime(2024, 2, 15, 2, 45, 3, 967, DateTimeKind.Local).AddTicks(1644), "سعيد فريد", "Eleanora Cruickshank", "عراقی - طارق", null, "7455126174939790828", "Heard Island and McDonald Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 9, 1, 5, 9, 47, 123, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 2, 15, 5, 40, 29, 299, DateTimeKind.Local).AddTicks(2135), "ريم صلاح", "Reed Medhurst", "معروف, هاشم and هاشم", null, "1187860118885648798", "Mozambique", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 7, 24, 8, 17, 12, 14, DateTimeKind.Local).AddTicks(313), new DateTime(2024, 2, 15, 16, 12, 58, 587, DateTimeKind.Local).AddTicks(8293), "دانا فريد", "Sallie Nolan", 1, "بلال Group", null, "3916930883489691707", "Israel", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 10, 20, 15, 59, 24, 327, DateTimeKind.Local).AddTicks(6653), new DateTime(2024, 2, 15, 16, 49, 26, 755, DateTimeKind.Local).AddTicks(2644), "ريم حسن", "Jerome Harris", "عراقی Inc", null, "5492623109140974056", "Cyprus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 8, 1, 56, 15, 975, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 2, 15, 11, 10, 52, 460, DateTimeKind.Local).AddTicks(4121), "عبير أسامة", "Lemuel Metz", "ربيع Inc", null, "2118041382953641157", "French Guiana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 11, 25, 6, 7, 18, 595, DateTimeKind.Local).AddTicks(9859), new DateTime(2024, 2, 15, 15, 28, 56, 480, DateTimeKind.Local).AddTicks(6029), "دانا عاشور", "Rosario Champlin", "معروف and Sons", null, "4742643287963322448", "Singapore", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 12, 15, 38, 18, 53, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 2, 15, 8, 5, 53, 827, DateTimeKind.Local).AddTicks(6960), "عبير صلاح", "Rigoberto Quigley", "هاشم - صلاح", null, "7326554454093636815", "Monaco", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 12, 28, 15, 26, 49, 896, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 2, 15, 4, 9, 58, 35, DateTimeKind.Local).AddTicks(5115), "عبير عقیل", "Ansel Bahringer", 1, "عراقی - جابر‌", null, "3867294093808171757", "Honduras", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 2, 10, 12, 35, 37, 292, DateTimeKind.Local).AddTicks(786), new DateTime(2024, 2, 15, 10, 12, 38, 139, DateTimeKind.Local).AddTicks(9766), "هاجر زيد", "Heloise Lebsack", "عراقی Group", null, "120992659818899098", "Germany", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 1, 18, 16, 4, 24, 639, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 2, 15, 15, 12, 24, 666, DateTimeKind.Local).AddTicks(9555), "رقية سعيد", "Ahmed Macejkovic", 0, "فاروق - أمجد", null, "593081805320174321", "Saint Kitts and Nevis" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 3, 5, 7, 57, 0, 195, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 2, 15, 5, 6, 39, 322, DateTimeKind.Local).AddTicks(7569), "فريد طارق", "Lorine Bechtelar", 1, "حسن - سالم", null, "6001251759583834943", "Kenya", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 7, 13, 11, 19, 43, 475, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 2, 15, 6, 25, 1, 877, DateTimeKind.Local).AddTicks(572), "سالم طارق", "Tania Mante", 0, "فاروق - معروف", null, "5355542994247008509", "Argentina", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 11, 15, 0, 49, 44, 620, DateTimeKind.Local).AddTicks(3235), new DateTime(2024, 2, 15, 0, 50, 26, 482, DateTimeKind.Local).AddTicks(87), "أروى سالم", "Hank Corkery", "عارف and Sons", null, "2356008547264455586", "Vanuatu", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 8, 11, 23, 59, 48, 359, DateTimeKind.Local).AddTicks(6105), new DateTime(2024, 2, 15, 7, 49, 36, 805, DateTimeKind.Local).AddTicks(135), "سالم بلال", "Alba Casper", "معروف - إيهاب", null, "1950650874262812630", "El Salvador", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1967, 4, 2, 7, 7, 58, 792, DateTimeKind.Local).AddTicks(6134), new DateTime(2024, 2, 15, 4, 4, 24, 363, DateTimeKind.Local).AddTicks(3508), "عبير سالم", "Hosea Champlin", 1, "عقیل, عزیز and عزیز", null, "756059525374794904", "Haiti" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 7, 29, 23, 58, 25, 622, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 2, 15, 1, 0, 58, 496, DateTimeKind.Local).AddTicks(2903), "أسامة عراقی", "Sydney Shields", 1, "أمجد Inc", null, "6400017354725612186", "Yemen", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 11, 5, 46, 11, 431, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 2, 15, 16, 25, 0, 96, DateTimeKind.Local).AddTicks(7825), "زينب زيد", "Ayana Rolfson", "فاروق Group", null, "3639992302933652117", "Niger", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2002, 9, 12, 9, 29, 11, 541, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 2, 15, 4, 13, 5, 119, DateTimeKind.Local).AddTicks(7852), "أروى عقیل", "Joyce Mertz", 1, "معروف, ربيع and سعيد", null, "5197710552151355107", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 1, 22, 15, 19, 59, 493, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 2, 15, 17, 37, 18, 493, DateTimeKind.Local).AddTicks(1359), "منى ربيع", "Kaylie Hermann", "معروف and Sons", null, "7174724904967280627", "India", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 3, 11, 17, 6, 47, 768, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 2, 15, 22, 5, 52, 619, DateTimeKind.Local).AddTicks(8461), "زيد سعيد", "Dawson Runolfsdottir", 0, "أسامة, سالم and سعيد", null, "6661651491327706603", "Netherlands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 2, 19, 1, 25, 47, 616, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 2, 15, 3, 20, 13, 672, DateTimeKind.Local).AddTicks(6042), "فؤاد عزیز", "Kiana Klocko", 0, "بلال Inc", null, "6468475322667455926", "Bulgaria", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 7, 3, 1, 26, 38, 9, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 2, 15, 13, 30, 10, 932, DateTimeKind.Local).AddTicks(3856), "فريدة عقیل", "Leila Steuber", 0, "عقیل - صلاح", null, "6753158102120617959", "Palau", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 11, 11, 1, 32, 49, 701, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 2, 15, 13, 50, 22, 283, DateTimeKind.Local).AddTicks(5189), "بلال بلال", "Nina Rutherford", 0, "أسامة - عصار", null, "8439436402640674847", "Holy See (Vatican City State)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 8, 20, 23, 18, 59, 519, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 2, 15, 20, 27, 3, 884, DateTimeKind.Local).AddTicks(3019), "ربيع هاشم", "Hailie Bernier", 0, "آدم - حسن", null, "6703053231928802974", "Hungary", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 11, 12, 16, 20, 50, 421, DateTimeKind.Local).AddTicks(7633), new DateTime(2024, 2, 14, 23, 42, 30, 560, DateTimeKind.Local).AddTicks(3661), "آية عارف", "Myriam Veum", "حازم, حازم and عراقی", null, "1483323657353602671", "Saint Kitts and Nevis", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 10, 31, 13, 49, 7, 791, DateTimeKind.Local).AddTicks(5193), new DateTime(2024, 2, 15, 11, 41, 21, 655, DateTimeKind.Local).AddTicks(808), "آية أمجد", "Ava Lehner", "أسامة - بلال", null, "8542627972180244111", "Lao People's Democratic Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 8, 20, 6, 43, 15, 896, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 2, 15, 18, 52, 52, 945, DateTimeKind.Local).AddTicks(4302), "هاجر فاروق", "Terrell Ratke", 0, "عقیل - فاروق", null, "1978886721764528731", "South Georgia and the South Sandwich Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 2, 15, 0, 58, 0, 355, DateTimeKind.Local).AddTicks(5323), new DateTime(2024, 2, 15, 2, 31, 50, 414, DateTimeKind.Local).AddTicks(4037), "هاجر أسامة", "Sharon Rolfson", 0, "سالم, زيد and حسن", null, "4472815776566335921", "Republic of Korea", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 1, 8, 13, 44, 46, 344, DateTimeKind.Local).AddTicks(3148), new DateTime(2024, 2, 15, 22, 23, 5, 278, DateTimeKind.Local).AddTicks(6666), "فريدة هاشم", "Caden Zboncak", 0, "عاشور, عصار and أسامة", null, "6340602038484423545", "Puerto Rico", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 8, 5, 2, 41, 21, 433, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 2, 15, 15, 31, 12, 365, DateTimeKind.Local).AddTicks(4597), "إيناس صلاح", "Nicole Kris", 1, "عصار - آدم", null, "6142858156775344596", "French Guiana" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId1", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 2, 5, 3, 54, 12, 316, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 2, 15, 2, 39, 5, 126, DateTimeKind.Local).AddTicks(47), "ريم فؤاد", "Jasper Hyatt", 1, "معروف - عصار", null, "404440639290086459", "Libyan Arab Jamahiriya", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalFileId1",
                table: "Patients",
                column: "MedicalFileId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalFiles_MedicalFileId1",
                table: "Patients",
                column: "MedicalFileId1",
                principalTable: "MedicalFiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalFiles_MedicalFileId1",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalFileId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MedicalFileId1",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalFiles");

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, شارع آفریقا, 5322, صنعاء, Yemen", "القضيمة", new DateTime(2024, 2, 15, 11, 49, 58, 324, DateTimeKind.Local).AddTicks(1952), "salm.tarq@gmail.com", "1-270-282-3915 x863" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, 56, سيان, Armenia", "الفجيرة", new DateTime(2024, 2, 15, 16, 2, 40, 719, DateTimeKind.Local).AddTicks(2983), "hajr.aarf36@yahoo.com", "(751) 709-8344" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع ابوذر, 247, زاخو, Tajikistan", "سترة", new DateTime(2024, 2, 15, 7, 45, 26, 719, DateTimeKind.Local).AddTicks(9357), "fryd_hsn@gmail.com", "260-646-6954 x0507" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, دوار مالک اشتر, 51, بليث وين, Saudi Arabia", "دورا", new DateTime(2024, 2, 14, 23, 48, 12, 301, DateTimeKind.Local).AddTicks(7597), "rqyh44@yahoo.com", "1-626-387-7850 x00435" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع سمیه, طريق کارگر شمالی, 025, ينبع, Azerbaijan", "النبطية", new DateTime(2024, 2, 15, 10, 37, 35, 462, DateTimeKind.Local).AddTicks(1536), "sarh22@yahoo.com", "484-519-8344 x68836" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, ش هویزه, 871, رام الله, French Guiana", "بيت حانون", new DateTime(2024, 2, 15, 17, 43, 4, 261, DateTimeKind.Local).AddTicks(8515), "sarh_slah@yahoo.com", "364-698-6788 x4526" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آذربایجان, 3354, عقوبة, Greenland", "تعز", new DateTime(2024, 2, 15, 7, 45, 46, 576, DateTimeKind.Local).AddTicks(2566), "farwq.araqy@gmail.com", "1-471-604-3997" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, 4, البيضاء, Saint Pierre and Miquelon", "آلاك", new DateTime(2024, 2, 15, 15, 33, 50, 753, DateTimeKind.Local).AddTicks(8268), "zynb_azyz43@gmail.com", "868-346-0535 x570" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آفریقا, دوار اقبال لاهوری, 006, صلخد, Angola", "الدويم", new DateTime(2024, 2, 15, 5, 59, 28, 746, DateTimeKind.Local).AddTicks(5319), "blal60@gmail.com", "786-426-3001 x20092" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 312, منبج, French Polynesia", "مدينة الحرير", new DateTime(2024, 2, 15, 22, 1, 0, 1, DateTimeKind.Local).AddTicks(4445), "frydh.blal27@hotmail.com", "(969) 466-6424 x560" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق شهید مطهری, 2, الكرك, Ethiopia", "سوهاج", new DateTime(2024, 2, 15, 20, 13, 55, 854, DateTimeKind.Local).AddTicks(9802), "rna.hsn82@hotmail.com", "658.523.3963 x334" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 61, المدية, South Africa", "الشحر", new DateTime(2024, 2, 15, 13, 46, 5, 626, DateTimeKind.Local).AddTicks(9737), "dana38@hotmail.com", "1-268-952-4001" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, 197, أوبوك, Cote d'Ivoire", "سلفيت", new DateTime(2024, 2, 15, 20, 18, 4, 89, DateTimeKind.Local).AddTicks(6384), "dana_asamh@yahoo.com", "1-766-715-6404" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, دوار یادگار امام, 295, ورقلة, Svalbard & Jan Mayen Islands", "خان يونس", new DateTime(2024, 2, 15, 20, 42, 27, 144, DateTimeKind.Local).AddTicks(3786), "fuad.farwq14@yahoo.com", "232.306.6648 x697" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آزادی, 1, الأتارب, Gabon", "غارو", new DateTime(2024, 2, 15, 5, 38, 11, 96, DateTimeKind.Local).AddTicks(1781), "sayd60@yahoo.com", "1-412-319-8828" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 559, القضارف, Dominica", "الجنينة", new DateTime(2024, 2, 15, 14, 55, 38, 900, DateTimeKind.Local).AddTicks(7423), "farwq.hsn8@gmail.com", "778-789-9034 x42841" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, شارع رسالت, 139, الرس, Senegal", "كرو", new DateTime(2024, 2, 15, 21, 19, 44, 740, DateTimeKind.Local).AddTicks(8291), "amjd_fuad88@gmail.com", "(262) 547-3809 x297" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, ش موحد دانش, 1, ودمدني, Aruba", "ذي سفال", new DateTime(2024, 2, 15, 2, 22, 1, 888, DateTimeKind.Local).AddTicks(7033), "fatmh_araqy@gmail.com", "(435) 314-6861" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, 9, أغادير, Nicaragua", "زبيد", new DateTime(2024, 2, 15, 2, 7, 4, 155, DateTimeKind.Local).AddTicks(3156), "amjd94@gmail.com", "617.815.2276 x575" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق واعظی, طريق دماوند, 1, السلط, French Polynesia", "أدم", new DateTime(2024, 2, 15, 3, 32, 27, 585, DateTimeKind.Local).AddTicks(2517), "sayd.hashm@yahoo.com", "452-946-5536 x33817" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, طريق دماوند, 8, جعار, Tonga", "كفرشوبا", new DateTime(2024, 2, 15, 11, 50, 5, 227, DateTimeKind.Local).AddTicks(1317), "zynb_fuad@hotmail.com", "853.914.4815" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان کارگر شمالی, 7, سنار, Dominica", "الدامر", new DateTime(2024, 2, 15, 2, 3, 14, 80, DateTimeKind.Local).AddTicks(5936), "mna62@gmail.com", "(941) 420-9090" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دستغیب, دوار سباری, 25, البيضاء, Senegal", "السلط", new DateTime(2024, 2, 15, 21, 11, 48, 544, DateTimeKind.Local).AddTicks(143), "rym.araqy79@yahoo.com", "(288) 531-3043" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان موحد دانش, 5, البصرة, Slovenia", "جد حفص", new DateTime(2024, 2, 15, 12, 36, 13, 760, DateTimeKind.Local).AddTicks(6633), "zyd72@gmail.com", "1-851-716-3361 x544" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, 1, الحسكة, Lithuania", "الحلة", new DateTime(2024, 2, 15, 15, 32, 54, 265, DateTimeKind.Local).AddTicks(3790), "tarq.fryd11@yahoo.com", "274.258.4851" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, 8760, براقي, Ecuador", "الجوف", new DateTime(2024, 2, 15, 9, 48, 38, 851, DateTimeKind.Local).AddTicks(8733), "jmanh75@hotmail.com", "1-612-805-3851" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دماوند, دوار واعظی, 51, مدينة عيسى, Nepal", "خان شيخون", new DateTime(2024, 2, 15, 15, 50, 57, 878, DateTimeKind.Local).AddTicks(3615), "zyd_salm@hotmail.com", "662-892-4255" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, 4, يبرود, Togo", "بركان", new DateTime(2024, 2, 15, 3, 7, 6, 661, DateTimeKind.Local).AddTicks(1912), "farwq_asar@gmail.com", "705.998.4432 x973" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, 12, ربك, Martinique", "عفك", new DateTime(2024, 2, 15, 4, 36, 57, 822, DateTimeKind.Local).AddTicks(98), "iynas.rbya37@hotmail.com", "894-649-4536" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, طريق دکتر چمران, 892, بجاية, Madagascar", "أم القيوين", new DateTime(2024, 2, 15, 3, 14, 50, 82, DateTimeKind.Local).AddTicks(1608), "jmanh_aqyl84@gmail.com", "(970) 824-4919 x00376" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع یادگار امام, 27, حديثة, Namibia", "قريات", new DateTime(2024, 2, 15, 22, 22, 11, 72, DateTimeKind.Local).AddTicks(9471), "asamh.asar@hotmail.com", "(704) 706-0587 x46090" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان شهید مطهری, 0, علي صبيح, Myanmar", "حلبا", new DateTime(2024, 2, 15, 21, 16, 52, 193, DateTimeKind.Local).AddTicks(770), "slah20@gmail.com", "(922) 697-7529 x949" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, 7, الخروب, Saint Pierre and Miquelon", "مراكش", new DateTime(2024, 2, 15, 22, 46, 1, 53, DateTimeKind.Local).AddTicks(6785), "iyhab85@gmail.com", "331-790-0125 x50323" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, ميدان آذربایجان, 27, ريسوت, Nauru", "الجزائر", new DateTime(2024, 2, 15, 2, 28, 6, 313, DateTimeKind.Local).AddTicks(9287), "jabr_fuad91@yahoo.com", "1-848-967-5005 x3332" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, دوار یادگار امام, 6, دبى, British Indian Ocean Territory (Chagos Archipelago)", "القنفذة", new DateTime(2024, 2, 15, 18, 23, 38, 834, DateTimeKind.Local).AddTicks(4127), "hsn.sayd@hotmail.com", "1-379-779-2024 x5061" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 03, العيون, Moldova", "راس العين", new DateTime(2024, 2, 15, 6, 19, 57, 933, DateTimeKind.Local).AddTicks(5051), "dana_hashm@hotmail.com", "905.705.6331 x98117" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سباری, دوار راستوان, 571, الإسكندرية, Saint Martin", "ريان", new DateTime(2024, 2, 15, 14, 27, 1, 469, DateTimeKind.Local).AddTicks(2964), "rna46@gmail.com", "(950) 733-4288 x451" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دستغیب, 616, جحفية, Taiwan", "بعبدا", new DateTime(2024, 2, 15, 2, 20, 2, 674, DateTimeKind.Local).AddTicks(5881), "hazm.asar@yahoo.com", "397-382-5653" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, 063, جحفية, Palau", "ازرع", new DateTime(2024, 2, 15, 3, 49, 34, 120, DateTimeKind.Local).AddTicks(9523), "mna8@gmail.com", "509-301-3645 x058" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, ميدان یادگار امام, 1188, البريمي, Oman", "صافيتا", new DateTime(2024, 2, 15, 8, 17, 51, 887, DateTimeKind.Local).AddTicks(4968), "rqyh73@hotmail.com", "629.737.5640" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, شارع قدس, 1, ضرما, Brazil", "حلبجة", new DateTime(2024, 2, 15, 0, 55, 8, 856, DateTimeKind.Local).AddTicks(7093), "sarh.hashm9@gmail.com", "1-592-641-9993" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع امیرکبیر, طريق دیباجی, 02, الرياض, Nauru", "القبة", new DateTime(2024, 2, 15, 22, 55, 20, 4, DateTimeKind.Local).AddTicks(1513), "asamh.hazm@yahoo.com", "(315) 942-1248" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, 929, خور فكان, Kazakhstan", "دبا", new DateTime(2024, 2, 15, 8, 3, 35, 747, DateTimeKind.Local).AddTicks(9495), "lma_fuad82@gmail.com", "1-783-851-6279 x6723" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع استاد قریب, 2523, رابغ, France", "الوادي", new DateTime(2024, 2, 15, 20, 57, 17, 141, DateTimeKind.Local).AddTicks(3421), "salm.araqy40@gmail.com", "344-548-2116 x32992" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, 3, أدم, Singapore", "الأغواط", new DateTime(2024, 2, 15, 22, 11, 34, 985, DateTimeKind.Local).AddTicks(9509), "zynb.iyhab98@yahoo.com", "1-721-337-3995 x217" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 9, الإسكندرية, United Arab Emirates", "الرباط", new DateTime(2024, 2, 15, 8, 23, 18, 638, DateTimeKind.Local).AddTicks(3402), "rym69@gmail.com", "1-780-895-1794 x7127" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, ش فاطمی, 8, تل كيف, Sudan", "القحطانية", new DateTime(2024, 2, 15, 8, 30, 32, 334, DateTimeKind.Local).AddTicks(3890), "salm_sayd@yahoo.com", "(865) 940-1943 x0318" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 4828, شلالة العذاورة, Bangladesh", "مدنين", new DateTime(2024, 2, 15, 16, 52, 41, 512, DateTimeKind.Local).AddTicks(1827), "fatmh.slah@yahoo.com", "722-844-8240" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, 2, النجف, Saint Martin", "التل", new DateTime(2024, 2, 15, 5, 38, 38, 487, DateTimeKind.Local).AddTicks(5464), "aayh74@gmail.com", "583.280.3330 x0931" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, تقاطع فاطمی, 72, النهود, Virgin Islands, U.S.", "تيارت", new DateTime(2024, 2, 15, 8, 39, 26, 820, DateTimeKind.Local).AddTicks(2938), "iyhab_tarq@hotmail.com", "1-521-878-2212 x41360" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آزادی, 899, توريرت, Algeria", "فاس", new DateTime(2024, 2, 15, 12, 20, 6, 311, DateTimeKind.Local).AddTicks(696), "rqyh93@gmail.com", "1-478-833-4651 x85266" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 6, القحطانية, Republic of Korea", "الناصرية", new DateTime(2024, 2, 15, 19, 36, 19, 717, DateTimeKind.Local).AddTicks(9775), "sayd52@hotmail.com", "1-828-320-1641 x600" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع ابوذر, 44, الميادين, Saint Kitts and Nevis", "صفرو", new DateTime(2024, 2, 15, 14, 49, 41, 154, DateTimeKind.Local).AddTicks(4709), "aadm33@gmail.com", "200.606.3472 x5894" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, ميدان استاد قریب, 84, عفيف, Taiwan", "الدقم", new DateTime(2024, 2, 15, 9, 54, 58, 664, DateTimeKind.Local).AddTicks(6679), "iyhab23@gmail.com", "(274) 941-7384" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع هویزه, 388, آلاك, Jersey", "مكة المكرمة", new DateTime(2024, 2, 15, 8, 23, 20, 227, DateTimeKind.Local).AddTicks(8588), "arwa75@yahoo.com", "241-764-1242 x147" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, تقاطع یادگار امام, 8, بركاء, Botswana", "العيون", new DateTime(2024, 2, 15, 15, 57, 14, 137, DateTimeKind.Local).AddTicks(2458), "lma27@gmail.com", "959-482-2158 x56747" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, دوار موحد دانش, 598, طرعان, Norway", "عين اعبيد", new DateTime(2024, 2, 15, 5, 36, 22, 247, DateTimeKind.Local).AddTicks(4771), "frydh_iyhab@yahoo.com", "363-659-8044 x7512" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, 172, الحجرة, Philippines", "كفر الدوار", new DateTime(2024, 2, 15, 16, 35, 47, 1, DateTimeKind.Local).AddTicks(8213), "farwq20@yahoo.com", "744.463.3294" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان رسالت, ميدان آذربایجان, 34, شرورة, Bouvet Island (Bouvetoya)", "أبو كمال", new DateTime(2024, 2, 15, 18, 2, 23, 469, DateTimeKind.Local).AddTicks(8071), "rym.asamh28@yahoo.com", "1-291-335-1557" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دستغیب, شارع دماوند, 47, اليوسفية, Malta", "سعيدة", new DateTime(2024, 2, 15, 9, 30, 3, 886, DateTimeKind.Local).AddTicks(4643), "dana_tarq@gmail.com", "(391) 285-8777" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, 5, حفر الباطن, Greenland", "الرقة", new DateTime(2024, 2, 14, 23, 14, 0, 930, DateTimeKind.Local).AddTicks(1343), "fuad95@yahoo.com", "(782) 213-9985 x834" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اقبال لاهوری, طريق آفریقا, 5233, نوى, Jamaica", "الشارقة", new DateTime(2024, 2, 15, 5, 6, 3, 118, DateTimeKind.Local).AddTicks(7460), "abyr52@gmail.com", "(353) 664-5886" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار استاد قریب, 292, إربد, Cameroon", "بريدة", new DateTime(2024, 2, 15, 21, 2, 43, 556, DateTimeKind.Local).AddTicks(6757), "zynb.fryd3@gmail.com", "1-596-402-4885" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, 8, القائم, Heard Island and McDonald Islands", "ثول", new DateTime(2024, 2, 15, 21, 28, 45, 654, DateTimeKind.Local).AddTicks(9722), "sarh_aashwr@gmail.com", "(808) 755-8526" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دکتر چمران, 0, الأتارب, Guernsey", "نيالا", new DateTime(2024, 2, 15, 20, 46, 10, 358, DateTimeKind.Local).AddTicks(8938), "fryd_hsn33@hotmail.com", "1-492-608-2145 x7068" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع حقانی, طريق اقبال لاهوری, 0, العلا, Botswana", "زليطن", new DateTime(2024, 2, 15, 7, 23, 2, 86, DateTimeKind.Local).AddTicks(3860), "jmanh30@gmail.com", "1-417-495-8121 x485" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دکتر چمران, 068, العيينة, Hungary", "أرتا", new DateTime(2024, 2, 15, 7, 27, 32, 288, DateTimeKind.Local).AddTicks(7543), "slah.hsn@hotmail.com", "1-526-442-3618 x9344" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, 3, سبها, Venezuela", "عرعر", new DateTime(2024, 2, 15, 10, 30, 43, 227, DateTimeKind.Local).AddTicks(5628), "hajr36@yahoo.com", "(982) 920-7899" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, طريق قدس, 756, دهبان, Micronesia", "تونس", new DateTime(2024, 2, 15, 17, 37, 50, 556, DateTimeKind.Local).AddTicks(5434), "rbya.araqy@yahoo.com", "857.302.4580 x5959" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سباری, شارع سمیه, 98, تونس, New Zealand", "كفر الدوار", new DateTime(2024, 2, 15, 6, 24, 56, 289, DateTimeKind.Local).AddTicks(2379), "aadm.jabr@yahoo.com", "(595) 778-9281 x84128" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش امیرکبیر, ميدان سمیه, 994, شفاعمرو, Zimbabwe", "تلعفر", new DateTime(2024, 2, 15, 9, 11, 13, 176, DateTimeKind.Local).AddTicks(8182), "lma68@gmail.com", "(399) 757-9151 x5834" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع فاطمی, ميدان واعظی, 43, السويداء, Guyana", "تاروت", new DateTime(2024, 2, 15, 20, 4, 9, 146, DateTimeKind.Local).AddTicks(2928), "fatmh_salm57@hotmail.com", "(930) 854-5411" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, ميدان واعظی, 54, بو سعادة, Jamaica", "القويعية", new DateTime(2024, 2, 15, 0, 45, 50, 696, DateTimeKind.Local).AddTicks(6415), "zynb.asamh@gmail.com", "460.510.2032 x734" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, ش دماوند, 355, الدويم, Honduras", "الرفاع الغربي", new DateTime(2024, 2, 15, 0, 23, 39, 669, DateTimeKind.Local).AddTicks(8780), "tarq13@yahoo.com", "404-871-7331 x8801" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دیباجی, تقاطع مالک اشتر, 7, الفاشر, Tokelau", "الأبيض", new DateTime(2024, 2, 15, 23, 1, 40, 511, DateTimeKind.Local).AddTicks(4475), "rna.farwq21@hotmail.com", "(858) 528-1631" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش ابوذر, 1671, قسنطينة, Palau", "تربة البقوم", new DateTime(2024, 2, 15, 9, 27, 51, 299, DateTimeKind.Local).AddTicks(5728), "shymaa.farwq@hotmail.com", "605.606.5746 x70127" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, طريق اجاره دار, 1, الناظور, Netherlands", "خصب", new DateTime(2024, 2, 15, 9, 20, 51, 322, DateTimeKind.Local).AddTicks(832), "rym91@gmail.com", "1-832-576-8892 x1429" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان ابوذر, 512, دير عطية, Bulgaria", "السليل", new DateTime(2024, 2, 15, 20, 20, 12, 179, DateTimeKind.Local).AddTicks(1093), "abyr_asamh47@gmail.com", "(315) 406-0892 x6014" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, 2516, قلعة السراغنة, Djibouti", "باب الزوار", new DateTime(2024, 2, 15, 10, 8, 42, 234, DateTimeKind.Local).AddTicks(8235), "fatmh73@yahoo.com", "673-914-7966 x276" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, طريق مالک اشتر, 995, جبلة, Netherlands", "خانقين", new DateTime(2024, 2, 15, 3, 20, 59, 580, DateTimeKind.Local).AddTicks(9761), "slah.azyz@gmail.com", "772-691-9101" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, 0, البيضاء, Reunion", "المنطقة الخضراء", new DateTime(2024, 2, 15, 6, 16, 34, 619, DateTimeKind.Local).AddTicks(5296), "arwa_araqy@gmail.com", "988-630-6947 x18694" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, ش اقبال لاهوری, 665, بشار, Morocco", "قصرين", new DateTime(2024, 2, 15, 22, 41, 31, 522, DateTimeKind.Local).AddTicks(8950), "lma16@yahoo.com", "623.723.9114" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق آذربایجان, ش اقبال لاهوری, 8531, تيفلت, Cape Verde", "الطريف", new DateTime(2024, 2, 15, 16, 55, 47, 239, DateTimeKind.Local).AddTicks(8408), "zynb81@gmail.com", "1-439-774-8460 x1497" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, 2461, مدينة الملك عبد الله الاقتصادية, Madagascar", "ريان", new DateTime(2024, 2, 15, 12, 58, 7, 249, DateTimeKind.Local).AddTicks(964), "dana.fuad27@hotmail.com", "(408) 993-4327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آفریقا, 5, طرعان, Virgin Islands, British", "نالوت", new DateTime(2024, 2, 15, 11, 4, 25, 76, DateTimeKind.Local).AddTicks(9382), "iyhab52@hotmail.com", "610-795-5583 x9013" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 3, تارودانت, Greece", "اكجوجت", new DateTime(2024, 2, 15, 17, 57, 40, 148, DateTimeKind.Local).AddTicks(1702), "rna.amjd@gmail.com", "826-882-2296 x40916" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, 6386, ريسوت, Australia", "برديرا", new DateTime(2024, 2, 14, 23, 17, 47, 618, DateTimeKind.Local).AddTicks(3001), "abyr.iyhab@gmail.com", "(552) 643-4193 x436" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, تقاطع سباری, 5266, حلفا الجديدة, Iran", "سمائل", new DateTime(2024, 2, 15, 6, 8, 31, 194, DateTimeKind.Local).AddTicks(5926), "aayh.asar@yahoo.com", "1-541-688-5995" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع موحد دانش, طريق شهید مطهری, 17, غارو, Honduras", "حلبا", new DateTime(2024, 2, 15, 11, 28, 45, 150, DateTimeKind.Local).AddTicks(7226), "rna69@gmail.com", "(876) 942-8760 x63123" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, ميدان راستوان, 33, فيفاء, Bahamas", "تعز", new DateTime(2024, 2, 15, 8, 49, 55, 432, DateTimeKind.Local).AddTicks(6613), "iyhab_hsn76@yahoo.com", "(539) 726-2199" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دیباجی, طريق راستوان, 6, مصياف, Cote d'Ivoire", "الرملة", new DateTime(2024, 2, 15, 8, 14, 5, 448, DateTimeKind.Local).AddTicks(1469), "hajr_farwq@hotmail.com", "1-637-727-4289" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان مالک اشتر, دوار قدس, 78, الجبيل, Ireland", "حائل", new DateTime(2024, 2, 15, 1, 48, 52, 720, DateTimeKind.Local).AddTicks(3344), "iyhab_amjd47@gmail.com", "(967) 934-6496" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع فاطمی, شارع موحد دانش, 10, مدينة الكويت, Djibouti", "عفيف", new DateTime(2024, 2, 15, 16, 57, 9, 115, DateTimeKind.Local).AddTicks(5366), "sayd.aarf58@yahoo.com", "(712) 580-2012 x8311" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, تقاطع امیرکبیر, 9, عقوبة, Solomon Islands", "الكاظمية", new DateTime(2024, 2, 15, 1, 0, 48, 584, DateTimeKind.Local).AddTicks(1074), "shymaa_asamh79@yahoo.com", "363.756.8813" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اجاره دار, 398, تبوك, Sweden", "الموصل", new DateTime(2024, 2, 15, 5, 53, 55, 450, DateTimeKind.Local).AddTicks(6521), "lma9@hotmail.com", "279.258.2993" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, 0, حلفا الجديدة, Kazakhstan", "الرياض", new DateTime(2024, 2, 15, 12, 27, 56, 544, DateTimeKind.Local).AddTicks(4315), "zynb.blal@yahoo.com", "306-332-6225 x06890" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار واعظی, 2, بورتسودان, Wallis and Futuna", "رابغ", new DateTime(2024, 2, 15, 7, 34, 13, 603, DateTimeKind.Local).AddTicks(3854), "rqyh77@hotmail.com", "(440) 935-2895 x9677" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان سمیه, 5, سيدي بلعباس, Jamaica", "مدينة الصدر", new DateTime(2024, 2, 15, 15, 7, 42, 240, DateTimeKind.Local).AddTicks(6884), "salm87@yahoo.com", "1-359-927-8293 x7147" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع حقانی, شارع سمیه, 5571, زليطن, Mexico", "ربك", new DateTime(2024, 2, 15, 10, 1, 30, 135, DateTimeKind.Local).AddTicks(9868), "dana6@yahoo.com", "(990) 679-3144 x402" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار فاطمی, 434, غريان, Iraq", "القائم", new DateTime(2024, 2, 15, 2, 14, 29, 15, DateTimeKind.Local).AddTicks(32), "sarh67@gmail.com", "(914) 374-6178 x228" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دماوند, 609, الدوحة, Equatorial Guinea", "مصراتة", new DateTime(2024, 2, 15, 8, 39, 11, 719, DateTimeKind.Local).AddTicks(7623), "amjd.fryd@gmail.com", "(425) 601-8344 x931" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع قدس, 29, الدامور, Faroe Islands", "ربك", new DateTime(2024, 2, 15, 15, 50, 39, 385, DateTimeKind.Local).AddTicks(8015), "aayh_hashm28@hotmail.com", "(935) 515-3250" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, تقاطع مالک اشتر, 462, طرابلس, Hungary", "آلاك", new DateTime(2024, 2, 15, 20, 20, 24, 167, DateTimeKind.Local).AddTicks(5941), "arwa_araqy@yahoo.com", "631-844-9157 x50641" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دیباجی, طريق کارگر شمالی, 348, العمارة, Gambia", "حقل", new DateTime(2024, 2, 15, 3, 36, 20, 917, DateTimeKind.Local).AddTicks(3407), "rym58@hotmail.com", "(886) 828-3413 x630" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, دوار موحد دانش, 0, القضيمة, Burkina Faso", "أسفي", new DateTime(2024, 2, 14, 23, 9, 16, 650, DateTimeKind.Local).AddTicks(3916), "blal_blal@gmail.com", "683-425-3107" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, 9, وهران, Timor-Leste", "داريا", new DateTime(2024, 2, 15, 4, 12, 4, 790, DateTimeKind.Local).AddTicks(9893), "fryd.fryd@hotmail.com", "883.374.9506 x03989" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, شارع دکتر چمران, 745, الدقم, Argentina", "طرابلس", new DateTime(2024, 2, 15, 7, 38, 17, 768, DateTimeKind.Local).AddTicks(2188), "salm.slah@gmail.com", "420-332-9663" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, 10, كفر الشيخ, Saint Martin", "بربرة", new DateTime(2024, 2, 15, 5, 30, 47, 816, DateTimeKind.Local).AddTicks(5843), "dana_fuad10@gmail.com", "874-290-9954" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, 05, الدوادمي, Gambia", "دخيل", new DateTime(2024, 2, 15, 8, 10, 50, 630, DateTimeKind.Local).AddTicks(8397), "amjd.fuad@yahoo.com", "587.584.1697 x86719" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار مالک اشتر, ش فاطمی, 1, شقراء, Equatorial Guinea", "الفحيحيل", new DateTime(2024, 2, 15, 1, 22, 32, 245, DateTimeKind.Local).AddTicks(2304), "fryd.hazm90@gmail.com", "723.880.0717" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, 3, كفر الدوار, Tanzania", "طنجة", new DateTime(2024, 2, 15, 6, 18, 6, 609, DateTimeKind.Local).AddTicks(5859), "iynas.marwf59@gmail.com", "360-645-0032" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع رسالت, طريق استاد قریب, 94, الشوف, Austria", "العرائش", new DateTime(2024, 2, 15, 15, 32, 19, 95, DateTimeKind.Local).AddTicks(7644), "sayd85@yahoo.com", "(401) 751-9757 x70840" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع ابوذر, 714, أدم, Nepal", "بلد", new DateTime(2024, 2, 15, 17, 28, 48, 723, DateTimeKind.Local).AddTicks(4234), "zyd.farwq62@yahoo.com", "418-452-2217 x2267" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع یادگار امام, 6004, شبين الكوم, Venezuela", "تربة البقوم", new DateTime(2024, 2, 15, 16, 48, 31, 442, DateTimeKind.Local).AddTicks(6347), "hazm.aashwr@yahoo.com", "712.790.9260 x00833" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, طريق مالک اشتر, 0, المطرية, Ireland", "سكيكدة", new DateTime(2024, 2, 15, 1, 6, 51, 246, DateTimeKind.Local).AddTicks(7873), "abyr49@hotmail.com", "512.632.9612 x06670" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق رسالت, 3, جيبوتي, Macedonia", "خفجي", new DateTime(2024, 2, 15, 11, 51, 36, 21, DateTimeKind.Local).AddTicks(1269), "blal_amjd@yahoo.com", "359-430-7209 x295" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش شهید مطهری, طريق رسالت, 053, الدويم, Mozambique", "الجش", new DateTime(2024, 2, 15, 13, 1, 29, 168, DateTimeKind.Local).AddTicks(3516), "hsn.aashwr19@yahoo.com", "365-445-2995" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, دوار امیرکبیر, 1, الفقيه بنصالح, Oman", "تاروت", new DateTime(2024, 2, 15, 4, 41, 56, 604, DateTimeKind.Local).AddTicks(8252), "slah.hashm95@yahoo.com", "517-975-6789 x33669" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, 618, غارو, Algeria", "مطرح", new DateTime(2024, 2, 15, 13, 16, 58, 163, DateTimeKind.Local).AddTicks(7902), "frydh.aarf@hotmail.com", "(846) 284-2404" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش یادگار امام, ش یادگار امام, 921, جيبوتي, Malta", "هيت", new DateTime(2024, 2, 15, 10, 48, 57, 297, DateTimeKind.Local).AddTicks(5299), "lma_marwf69@gmail.com", "600-626-2002" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع رسالت, ش آفریقا, 8544, النهود, Afghanistan", "حائل", new DateTime(2024, 2, 15, 4, 6, 27, 692, DateTimeKind.Local).AddTicks(7800), "fryd.aqyl13@hotmail.com", "482.535.9190 x74403" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 44, عين العرب, Nepal", "الدرعية", new DateTime(2024, 2, 15, 12, 49, 27, 577, DateTimeKind.Local).AddTicks(3272), "aadm.farwq33@yahoo.com", "1-253-202-1070 x151" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, 203, بيت لاهيا, Slovenia", "الجبيل", new DateTime(2024, 2, 15, 16, 54, 27, 520, DateTimeKind.Local).AddTicks(9475), "slah_sayd@yahoo.com", "544.310.9480 x7784" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق ابوذر, 2804, جباليا, Colombia", "حائل", new DateTime(2024, 2, 15, 17, 33, 57, 930, DateTimeKind.Local).AddTicks(4774), "fryd51@gmail.com", "(564) 731-6198 x81140" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 67, دمياط, Seychelles", "السيب", new DateTime(2024, 2, 15, 0, 3, 20, 600, DateTimeKind.Local).AddTicks(9419), "arwa_aarf@gmail.com", "758-488-1748 x124" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دماوند, ميدان سمیه, 0920, الأزرق, Singapore", "الأقصر", new DateTime(2024, 2, 15, 2, 47, 28, 120, DateTimeKind.Local).AddTicks(5215), "fuad50@gmail.com", "895-263-5380" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان هویزه, طريق دستغیب, 373, العقير, Mayotte", "سحار", new DateTime(2024, 2, 15, 1, 42, 30, 274, DateTimeKind.Local).AddTicks(7106), "lma.fuad2@yahoo.com", "1-202-701-4719" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اجاره دار, شارع آذربایجان, 9, النعمة, Tuvalu", "مادبا", new DateTime(2024, 2, 15, 18, 13, 14, 216, DateTimeKind.Local).AddTicks(2589), "rqyh.azyz@hotmail.com", "(820) 412-8872" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آفریقا, دوار دماوند, 55, غليلة, Mauritius", "أم قصر", new DateTime(2024, 2, 15, 1, 35, 0, 776, DateTimeKind.Local).AddTicks(428), "rym.salm33@yahoo.com", "1-211-358-5375 x036" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع شهید مطهری, ش واعظی, 8, بلبيس, Rwanda", "أخميم", new DateTime(2024, 2, 14, 23, 52, 45, 515, DateTimeKind.Local).AddTicks(6048), "sayd.iyhab80@hotmail.com", "1-775-209-9322 x6173" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دیباجی, 9203, خانقين, Kuwait", "سحاب", new DateTime(2024, 2, 15, 13, 49, 6, 965, DateTimeKind.Local).AddTicks(17), "dana.zyd62@hotmail.com", "(321) 816-6225" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, 59, الفلوجة, Zimbabwe", "لوك", new DateTime(2024, 2, 15, 8, 54, 22, 229, DateTimeKind.Local).AddTicks(3816), "zynb.sayd@gmail.com", "(708) 894-2805 x44756" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آذربایجان, 6353, كفرشوبا, Guinea-Bissau", "دمياط", new DateTime(2024, 2, 15, 16, 2, 0, 282, DateTimeKind.Local).AddTicks(1976), "lma.blal@hotmail.com", "(663) 827-0503 x793" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان فاطمی, ميدان هویزه, 400, أم رواب, Finland", "حمص", new DateTime(2024, 2, 15, 11, 4, 53, 125, DateTimeKind.Local).AddTicks(8875), "shymaa60@gmail.com", "408-599-2604 x798" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, تقاطع اجاره دار, 43, دومة الجندل, Senegal", "زوارة", new DateTime(2024, 2, 15, 20, 11, 0, 836, DateTimeKind.Local).AddTicks(8821), "arwa.sayd89@yahoo.com", "(888) 393-4988 x823" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, ميدان سمیه, 1, المرج, Isle of Man", "بيت حانون", new DateTime(2024, 2, 15, 18, 5, 9, 664, DateTimeKind.Local).AddTicks(401), "mna50@yahoo.com", "1-991-329-2972 x27235" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, 183, تيفلت, Colombia", "كفر كنا", new DateTime(2024, 2, 15, 11, 23, 56, 937, DateTimeKind.Local).AddTicks(2167), "farwq.jabr@hotmail.com", "842.626.5231 x2756" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 77, لحج, Uganda", "مدينة الصدر", new DateTime(2024, 2, 15, 1, 43, 6, 373, DateTimeKind.Local).AddTicks(4021), "fryd_farwq76@hotmail.com", "312-218-9127 x1559" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان واعظی, 5436, الفاشر, Somalia", "أم الفحم", new DateTime(2024, 2, 15, 6, 56, 1, 904, DateTimeKind.Local).AddTicks(4207), "rna19@gmail.com", "604-302-7732" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق مالک اشتر, ميدان آفریقا, 5, البريمي, Vanuatu", "زاخو", new DateTime(2024, 2, 15, 7, 12, 26, 915, DateTimeKind.Local).AddTicks(3310), "iynas51@hotmail.com", "1-866-351-3163" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع اقبال لاهوری, 5, القيروان, Lithuania", "النبك", new DateTime(2024, 2, 15, 12, 46, 37, 418, DateTimeKind.Local).AddTicks(6164), "rqyh_aarf29@yahoo.com", "832-690-6399" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اجاره دار, ميدان رسالت, 964, عطبرة, Vietnam", "التل", new DateTime(2024, 2, 15, 19, 22, 1, 218, DateTimeKind.Local).AddTicks(6305), "frydh.iyhab@hotmail.com", "878.621.7820" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع اجاره دار, 1904, راس العين, Nauru", "الزرقاء", new DateTime(2024, 2, 15, 6, 45, 58, 909, DateTimeKind.Local).AddTicks(1296), "rym_farwq@gmail.com", "287-673-7642 x60005" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 0, داريا, Martinique", "شرورة", new DateTime(2024, 2, 15, 21, 34, 1, 450, DateTimeKind.Local).AddTicks(8551), "iyhab83@hotmail.com", "(381) 535-6233 x0088" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع قدس, تقاطع آذربایجان, 907, الفجيرة, Saint Kitts and Nevis", "صفرو", new DateTime(2024, 2, 15, 8, 32, 11, 972, DateTimeKind.Local).AddTicks(2402), "iyhab.rbya@yahoo.com", "1-568-966-9301" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع آزادی, 43, خنيفرة, Saint Lucia", "مسعد", new DateTime(2024, 2, 15, 10, 47, 25, 272, DateTimeKind.Local).AddTicks(8466), "sarh6@hotmail.com", "1-785-394-4082 x0327" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, ميدان دکتر چمران, 74, غليزان, Turkmenistan", "سوهاج", new DateTime(2024, 2, 15, 13, 45, 43, 284, DateTimeKind.Local).AddTicks(1007), "arwa.jabr77@gmail.com", "733.784.6130" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سباری, 133, تجكجة, Netherlands Antilles", "التاجي", new DateTime(2024, 2, 15, 3, 33, 36, 34, DateTimeKind.Local).AddTicks(950), "frydh75@gmail.com", "737-585-0149" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش فاطمی, شارع فاطمی, 30, قالمة, Macao", "مصيرة", new DateTime(2024, 2, 15, 12, 2, 44, 124, DateTimeKind.Local).AddTicks(6910), "iyhab34@gmail.com", "884-825-5269 x86405" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع کارگر شمالی, 2251, ثقبة, Reunion", "إزكي", new DateTime(2024, 2, 15, 22, 22, 48, 797, DateTimeKind.Local).AddTicks(7174), "dana.azyz@gmail.com", "983.938.0874" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع مالک اشتر, 3041, برديرا, Brazil", "خصب", new DateTime(2024, 2, 15, 18, 34, 5, 701, DateTimeKind.Local).AddTicks(6556), "zyd.slah@yahoo.com", "972.932.5676" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان قدس, 1, القامشلي, Mauritius", "إجدابيا", new DateTime(2024, 2, 15, 8, 55, 46, 9, DateTimeKind.Local).AddTicks(9965), "fatmh.azyz65@gmail.com", "(477) 915-7705 x539" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, 313, الجبيل, Paraguay", "دبى", new DateTime(2024, 2, 15, 7, 33, 7, 944, DateTimeKind.Local).AddTicks(7569), "sayd_hashm82@yahoo.com", "(735) 863-1019 x854" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش آزادی, تقاطع هویزه, 4600, شفاعمرو, Iran", "نيالا", new DateTime(2024, 2, 14, 23, 41, 52, 856, DateTimeKind.Local).AddTicks(5629), "zynb.salm@gmail.com", "702.248.1921 x20505" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش اقبال لاهوری, شارع اقبال لاهوری, 12, عامودا, Palestinian Territory", "طنطا", new DateTime(2024, 2, 15, 22, 54, 59, 920, DateTimeKind.Local).AddTicks(6575), "iynas.jabr@gmail.com", "1-876-547-7217 x07102" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان آزادی, شارع دکتر چمران, 108, سيدي قاسم, Dominica", "مطرح", new DateTime(2024, 2, 15, 10, 2, 43, 459, DateTimeKind.Local).AddTicks(9666), "fryd.slah10@yahoo.com", "770-200-7757 x46684" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار آزادی, 3, الخروب, Madagascar", "الباب", new DateTime(2024, 2, 15, 4, 58, 11, 733, DateTimeKind.Local).AddTicks(4193), "zyd_araqy@yahoo.com", "640-252-6048" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, 5784, كربلاء, Timor-Leste", "خان يونس", new DateTime(2024, 2, 15, 8, 2, 17, 386, DateTimeKind.Local).AddTicks(9361), "amjd.araqy@yahoo.com", "217-688-6557" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش هویزه, 696, الفحيحيل, Falkland Islands (Malvinas)", "علي صبيح", new DateTime(2024, 2, 15, 4, 40, 33, 521, DateTimeKind.Local).AddTicks(2702), "aayh.azyz34@yahoo.com", "587.969.5863" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع امیرکبیر, 463, مادبا, Samoa", "صفاقس", new DateTime(2024, 2, 15, 13, 15, 27, 872, DateTimeKind.Local).AddTicks(2858), "mna.aashwr52@hotmail.com", "1-339-768-7060 x439" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق اجاره دار, طريق ابوذر, 22, كفر كنا, Sao Tome and Principe", "الكاظمية", new DateTime(2024, 2, 15, 13, 48, 54, 353, DateTimeKind.Local).AddTicks(13), "rqyh_aarf@hotmail.com", "1-601-250-5837 x346" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار راستوان, 0968, الزقازيق, San Marino", "العيينة", new DateTime(2024, 2, 15, 11, 42, 51, 959, DateTimeKind.Local).AddTicks(302), "tarq_tarq@gmail.com", "1-958-357-2715" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سمیه, 40, المالكية, Bahamas", "قلعة السراغنة", new DateTime(2024, 2, 15, 15, 38, 31, 373, DateTimeKind.Local).AddTicks(9354), "rbya_sayd@hotmail.com", "293.481.9976" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, 424, الدقم, Aruba", "ضبا", new DateTime(2024, 2, 15, 20, 49, 10, 55, DateTimeKind.Local).AddTicks(8020), "dana99@gmail.com", "(850) 503-4392" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق موحد دانش, 73, لؤلؤة قطر, Chile", "نيالا", new DateTime(2024, 2, 15, 12, 49, 29, 663, DateTimeKind.Local).AddTicks(1806), "zynb_asar81@hotmail.com", "(579) 467-5590 x8227" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار دیباجی, 09, أسفي, Djibouti", "تنومة", new DateTime(2024, 2, 15, 15, 22, 38, 212, DateTimeKind.Local).AddTicks(7303), "lma1@yahoo.com", "336.778.9650 x75790" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش رسالت, شارع اجاره دار, 224, إزكي, Argentina", "بوكادوم", new DateTime(2024, 2, 15, 20, 42, 7, 568, DateTimeKind.Local).AddTicks(142), "rbya_marwf@hotmail.com", "(833) 771-8829" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار حقانی, 6857, خريبة السوق, Vietnam", "بوكى", new DateTime(2024, 2, 15, 2, 6, 43, 904, DateTimeKind.Local).AddTicks(7491), "lma_rbya53@yahoo.com", "367.688.6095" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دماوند, تقاطع ابوذر, 4825, المطرية, Bosnia and Herzegovina", "سحاب", new DateTime(2024, 2, 15, 18, 45, 13, 42, DateTimeKind.Local).AddTicks(6981), "farwq23@hotmail.com", "857.994.6599 x433" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان دیباجی, 478, القدس, Algeria", "الحوامدية", new DateTime(2024, 2, 15, 7, 11, 12, 444, DateTimeKind.Local).AddTicks(6035), "rna_jabr@hotmail.com", "886.334.1214" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار قدس, دوار اجاره دار, 0711, القضيمة, Kazakhstan", "تل رفعت", new DateTime(2024, 2, 15, 21, 19, 31, 834, DateTimeKind.Local).AddTicks(1275), "zynb.rbya14@gmail.com", "284.978.2854" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان اقبال لاهوری, طريق آفریقا, 38, جحفية, Brazil", "بيت لاهيا", new DateTime(2024, 2, 15, 13, 7, 2, 451, DateTimeKind.Local).AddTicks(807), "jabr67@hotmail.com", "580-574-3092" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, طريق آفریقا, 8061, العوجا, Myanmar", "الزيمة", new DateTime(2024, 2, 15, 14, 56, 11, 986, DateTimeKind.Local).AddTicks(8342), "hajr60@hotmail.com", "999-812-1702" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار کارگر شمالی, طريق آفریقا, 9, جوبا, Mongolia", "عجمان", new DateTime(2024, 2, 15, 5, 5, 22, 956, DateTimeKind.Local).AddTicks(4809), "iyhab.rbya@gmail.com", "799.467.9739 x750" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق هویزه, ش آفریقا, 66, الموصل, Guyana", "عجلون", new DateTime(2024, 2, 15, 6, 4, 48, 786, DateTimeKind.Local).AddTicks(5895), "aayh.aarf@gmail.com", "627-591-0684" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, دوار دکتر چمران, 0, مصراتة, France", "حيفا", new DateTime(2024, 2, 15, 11, 13, 55, 933, DateTimeKind.Local).AddTicks(9681), "aadm_hazm79@gmail.com", "786-857-9246 x6244" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق حقانی, تقاطع استاد قریب, 1350, الجوف, South Georgia and the South Sandwich Islands", "كلميم", new DateTime(2024, 2, 15, 2, 38, 44, 484, DateTimeKind.Local).AddTicks(9493), "hazm_iyhab31@yahoo.com", "1-647-672-5569 x135" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق دکتر چمران, 867, الفحيحيل, Philippines", "الخبر", new DateTime(2024, 2, 15, 13, 48, 49, 674, DateTimeKind.Local).AddTicks(4516), "rqyh_araqy@hotmail.com", "565.998.2427 x73225" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, ميدان رسالت, 33, رفحا, Costa Rica", "أريحا", new DateTime(2024, 2, 15, 9, 42, 5, 424, DateTimeKind.Local).AddTicks(6438), "mna_farwq53@gmail.com", "(914) 327-7071" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع دماوند, شارع آذربایجان, 20, قابس, British Indian Ocean Territory (Chagos Archipelago)", "عين وسارة", new DateTime(2024, 2, 15, 0, 10, 50, 215, DateTimeKind.Local).AddTicks(5241), "jmanh.aashwr89@yahoo.com", "(283) 215-8074 x2496" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع هویزه, 18, رندا, Benin", "سكيكدة", new DateTime(2024, 2, 15, 13, 11, 52, 951, DateTimeKind.Local).AddTicks(5586), "amjd.hsn17@gmail.com", "547-948-4218" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع کارگر شمالی, 65, ولاتة, Rwanda", "الجبيل", new DateTime(2024, 2, 15, 0, 59, 14, 237, DateTimeKind.Local).AddTicks(6943), "arwa_hashm@hotmail.com", "1-692-709-6246 x8414" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع دماوند, 92, طانطان, Lesotho", "جلب", new DateTime(2024, 2, 15, 13, 40, 59, 404, DateTimeKind.Local).AddTicks(1738), "iyhab89@hotmail.com", "913.250.1662" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع مالک اشتر, 108, القويسمة, Solomon Islands", "الجش", new DateTime(2024, 2, 15, 17, 27, 18, 722, DateTimeKind.Local).AddTicks(72), "fuad_sayd@gmail.com", "1-375-671-6359" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, ميدان فاطمی, 15, الباحة, San Marino", "دهبان", new DateTime(2024, 2, 15, 19, 39, 59, 875, DateTimeKind.Local).AddTicks(4524), "fuad_fryd@yahoo.com", "321-765-3502" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش دکتر چمران, دوار مالک اشتر, 0, بلبيس, Syrian Arab Republic", "السفيرة", new DateTime(2024, 2, 15, 4, 30, 47, 843, DateTimeKind.Local).AddTicks(1988), "arwa23@gmail.com", "1-400-644-8353" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش سمیه, ش استاد قریب, 1367, خصب, Timor-Leste", "هولهول", new DateTime(2024, 2, 15, 1, 44, 16, 970, DateTimeKind.Local).AddTicks(9064), "slah.amjd31@hotmail.com", "256.336.3189 x2181" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار امیرکبیر, 463, باب الزوار, Nicaragua", "دخان", new DateTime(2024, 2, 15, 17, 2, 46, 629, DateTimeKind.Local).AddTicks(9687), "fatmh_farwq@gmail.com", "1-832-452-3054" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق کارگر شمالی, تقاطع راستوان, 3578, أخميم, Germany", "العلمة", new DateTime(2024, 2, 15, 8, 22, 24, 895, DateTimeKind.Local).AddTicks(2400), "mna_araqy@hotmail.com", "(602) 784-7497" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار ابوذر, دوار آذربایجان, 6641, المالكية, Iceland", "مدحاء", new DateTime(2024, 2, 15, 2, 15, 43, 824, DateTimeKind.Local).AddTicks(5387), "hajr.iyhab@yahoo.com", "686.671.8985" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش حقانی, 63, فاس, Belarus", "ابها", new DateTime(2024, 2, 15, 14, 3, 40, 144, DateTimeKind.Local).AddTicks(104), "amjd.slah59@yahoo.com", "1-313-397-1917 x905" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع راستوان, ميدان هویزه, 6750, جونية, Montenegro", "حقل", new DateTime(2024, 2, 15, 22, 17, 54, 72, DateTimeKind.Local).AddTicks(1723), "zynb_aashwr@hotmail.com", "370-369-6645 x1608" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق قدس, 1, الزقازيق, Tokelau", "خور أنجار", new DateTime(2024, 2, 15, 14, 18, 19, 192, DateTimeKind.Local).AddTicks(7186), "fuad.salm@hotmail.com", "1-354-908-9518" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ميدان استاد قریب, ميدان ابوذر, 6502, دير عطية, Portugal", "دهبان", new DateTime(2024, 2, 15, 4, 10, 35, 569, DateTimeKind.Local).AddTicks(3823), "tarq.araqy@hotmail.com", "941-322-1430 x35454" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار هویزه, 854, السويس, French Polynesia", "عين البيضاء", new DateTime(2024, 2, 15, 9, 56, 0, 379, DateTimeKind.Local).AddTicks(5653), "salm.sayd99@gmail.com", "927-243-6853 x39391" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع آفریقا, 699, خور فكان, India", "ودمدني", new DateTime(2024, 2, 15, 7, 30, 31, 962, DateTimeKind.Local).AddTicks(7675), "fatmh.slah0@hotmail.com", "809.520.5340" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "طريق سباری, 804, العيون, Timor-Leste", "غرداية", new DateTime(2024, 2, 15, 17, 27, 34, 388, DateTimeKind.Local).AddTicks(6402), "iynas11@yahoo.com", "1-348-471-7592" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "ش واعظی, ش هویزه, 5, البليدة, Cayman Islands", "عدن", new DateTime(2024, 2, 15, 1, 4, 53, 212, DateTimeKind.Local).AddTicks(1034), "fatmh_azyz2@hotmail.com", "542.557.6033 x612" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "تقاطع موحد دانش, 718, تيارت, Martinique", "المدية", new DateTime(2024, 2, 15, 8, 7, 20, 831, DateTimeKind.Local).AddTicks(135), "blal41@yahoo.com", "1-262-477-6045" });

            migrationBuilder.UpdateData(
                table: "ContactInfos",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "دوار اجاره دار, دوار قدس, 10, الفاشر, Antarctica (the territory South of 60 deg S)", "منح", new DateTime(2024, 2, 15, 20, 30, 49, 356, DateTimeKind.Local).AddTicks(8161), "abyr.hashm97@yahoo.com", "527.997.1331" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 3, 20, 20, 47, 23, 328, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 2, 15, 8, 22, 11, 782, DateTimeKind.Local).AddTicks(5430), "عبير عقیل", "Jazlyn Yundt", "عارف, أمجد and فاروق", "1187234157082395656", "Italy", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 3, 29, 2, 36, 32, 981, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 2, 15, 4, 27, 43, 674, DateTimeKind.Local).AddTicks(7801), "إيناس سالم", "Gail Huels", 1, "حازم - فريد", "2024666291369628006", "Swaziland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 6, 30, 11, 36, 56, 487, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 2, 15, 13, 20, 50, 701, DateTimeKind.Local).AddTicks(1116), "شيماء عصار", "Alexanne Bergstrom", 1, "زيد and Sons", "1160134445214752423", "Costa Rica", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 10, 20, 18, 8, 48, 250, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 2, 15, 16, 7, 12, 77, DateTimeKind.Local).AddTicks(1025), "فريد سالم", "Jimmy Cassin", 0, "آدم - عراقی", "5440840086626692363", "American Samoa", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 6, 13, 10, 4, 22, 760, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 15, 16, 10, 49, 908, DateTimeKind.Local).AddTicks(2163), "لمى فؤاد", "Hailee Labadie", "صلاح - عارف", "4510718992178274228", "Greenland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 10, 3, 20, 29, 527, DateTimeKind.Local).AddTicks(5208), new DateTime(2024, 2, 15, 7, 2, 35, 911, DateTimeKind.Local).AddTicks(2153), "لمى بلال", "Rocky Bode", 0, "طارق, صلاح and هاشم", "3192011671375967489", "Guinea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 5, 11, 14, 40, 17, 951, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 2, 15, 2, 21, 44, 767, DateTimeKind.Local).AddTicks(7397), "دانا عقیل", "Collin Lowe", "حسن LLC", "7326938378901042202", "Cayman Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 10, 27, 15, 53, 18, 390, DateTimeKind.Local).AddTicks(3223), new DateTime(2024, 2, 15, 2, 31, 19, 654, DateTimeKind.Local).AddTicks(5307), "فاروق معروف", "Jordyn Bradtke", "بلال, بلال and أسامة", "3104597260472767495", "Antigua and Barbuda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 3, 3, 17, 37, 11, 306, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 2, 15, 22, 22, 21, 182, DateTimeKind.Local).AddTicks(4523), "سارة أسامة", "Kailee Mills", 0, "معروف - عصار", "6549955115543605228", "Costa Rica" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 6, 10, 19, 0, 33, 62, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 2, 15, 21, 2, 27, 534, DateTimeKind.Local).AddTicks(4246), "بلال عزیز", "Asa Yundt", "زيد, آدم and هاشم", "4235976280217721916", "Afghanistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 4, 16, 10, 45, 52, 365, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 2, 15, 7, 29, 19, 506, DateTimeKind.Local).AddTicks(5685), "فريد طارق", "Aryanna Reichel", 0, "سالم, أسامة and حسن", "153908518152086614", "Egypt", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 8, 0, 41, 46, 845, DateTimeKind.Local).AddTicks(3473), new DateTime(2024, 2, 15, 19, 36, 9, 853, DateTimeKind.Local).AddTicks(8759), "طارق فريد", "Annabelle Hoppe", "معروف - أسامة", "6048316030799028641", "Guinea-Bissau", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 12, 30, 3, 32, 25, 735, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 2, 15, 5, 27, 55, 544, DateTimeKind.Local).AddTicks(5625), "رقية أمجد", "Shanel Gerlach", 0, "ربيع Inc", "7237975526683662453", "Timor-Leste", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 29, 15, 8, 38, 61, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 2, 15, 12, 0, 53, 521, DateTimeKind.Local).AddTicks(1785), "جمانة حازم", "Corene Wintheiser", 1, "عصار, بلال and عصار", "151930220794280244", "Finland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1975, 9, 20, 21, 42, 48, 241, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 2, 15, 15, 9, 49, 386, DateTimeKind.Local).AddTicks(8676), "فاطمة عقیل", "Edison Kovacek", "حازم - عارف", "7227741643544068996", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 10, 6, 4, 58, 7, 774, DateTimeKind.Local).AddTicks(1526), new DateTime(2024, 2, 14, 23, 16, 32, 202, DateTimeKind.Local).AddTicks(4979), "عبير عزیز", "Danny Kris", 1, "أمجد - آدم", "3199836908489060833", "Greenland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 5, 6, 13, 28, 38, 665, DateTimeKind.Local).AddTicks(6023), new DateTime(2024, 2, 15, 20, 17, 21, 556, DateTimeKind.Local).AddTicks(6569), "إيهاب عقیل", "Devante Parker", 0, "أمجد Group", "2690296531855950853", "British Indian Ocean Territory (Chagos Archipelago)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 12, 4, 7, 29, 54, 231, DateTimeKind.Local).AddTicks(4438), new DateTime(2024, 2, 15, 2, 37, 40, 538, DateTimeKind.Local).AddTicks(9906), "حازم سعيد", "Maverick Christiansen", 0, "صلاح and Sons", "4354905734252268180", "Cyprus", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 2, 13, 22, 40, 29, 97, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 2, 15, 8, 19, 13, 229, DateTimeKind.Local).AddTicks(5554), "دانا عراقی", "Duane Frami", "عقیل - صلاح", "2133718339516885127", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 3, 31, 10, 38, 48, 271, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 2, 15, 4, 34, 37, 166, DateTimeKind.Local).AddTicks(706), "سالم جابر‌", "Alan Bashirian", "فؤاد and Sons", "3871937940458126072", "Saint Lucia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 3, 31, 14, 21, 29, 922, DateTimeKind.Local).AddTicks(5902), new DateTime(2024, 2, 15, 20, 25, 42, 717, DateTimeKind.Local).AddTicks(6444), "دانا عارف", "Marlen Barton", 1, "عزیز LLC", "4918941298827625102", "Turkmenistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 9, 8, 17, 25, 32, 824, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 2, 15, 19, 19, 28, 259, DateTimeKind.Local).AddTicks(6579), "أروى حسن", "Larue Rowe", 0, "أسامة Group", "473175284770448055", "Guernsey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 6, 25, 17, 5, 51, 272, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 2, 15, 12, 4, 30, 545, DateTimeKind.Local).AddTicks(5313), "فريدة إيهاب", "Eliane Wisozk", "عراقی - عاشور", "7263512757596294826", "Cuba", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 10, 25, 10, 48, 13, 767, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 2, 15, 5, 37, 40, 513, DateTimeKind.Local).AddTicks(2656), "آدم عاشور", "Fannie Collins", 0, "عزیز - إيهاب", "7474449702227354998", "Switzerland", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 3, 3, 1, 15, 49, 161, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 2, 15, 15, 27, 21, 593, DateTimeKind.Local).AddTicks(2805), "عبير هاشم", "Saige Christiansen", "سعيد LLC", "6830180646304033608", "France" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 7, 15, 12, 4, 58, 124, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 2, 15, 9, 50, 30, 190, DateTimeKind.Local).AddTicks(2700), "لمى ربيع", "Augustus Morar", 1, "سعيد, أمجد and سالم", "2450606289081857494", "Thailand", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 3, 15, 30, 5, 823, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 2, 15, 1, 11, 48, 611, DateTimeKind.Local).AddTicks(2747), "أروى إيهاب", "Kameron Waelchi", "طارق - فؤاد", "7515802633568672186", "Iceland", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 6, 8, 7, 26, 38, 945, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 2, 15, 4, 34, 37, 675, DateTimeKind.Local).AddTicks(8726), "فريدة أمجد", "Jeanie Murray", "بلال, أمجد and فؤاد", "787039969528939116", "Cameroon" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 4, 5, 16, 8, 46, 921, DateTimeKind.Local), new DateTime(2024, 2, 15, 2, 46, 3, 485, DateTimeKind.Local).AddTicks(7632), "حسن طارق", "Adrienne Bednar", "عقیل, عاشور and عاشور", "7005288815815101704", "Kenya", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 5, 1, 15, 3, 22, 639, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 2, 15, 2, 30, 39, 649, DateTimeKind.Local).AddTicks(3303), "حسن طارق", "Riley Stamm", "عارف Inc", "4733662791058350440", "Namibia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 13, 3, 10, 37, 95, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 2, 15, 8, 39, 47, 860, DateTimeKind.Local).AddTicks(9550), "سعيد عراقی", "Teagan Hoppe", 0, "عقیل, عارف and حازم", "4612959029149222123", "China", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1991, 12, 6, 23, 40, 19, 328, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 2, 15, 15, 29, 8, 658, DateTimeKind.Local).AddTicks(4612), "زيد زيد", "Kip King", "سالم, عارف and آدم", "8446534315785635723", "Kyrgyz Republic", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1977, 7, 7, 10, 24, 15, 217, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 2, 15, 2, 4, 25, 444, DateTimeKind.Local).AddTicks(7518), "أسامة بلال", "Gerry Lemke", 1, "زيد Group", "7928337873004866852", "Honduras", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 11, 20, 6, 16, 51, 74, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 2, 15, 11, 18, 30, 151, DateTimeKind.Local).AddTicks(7233), "حسن عصار", "Darlene Bradtke", 0, "جابر‌ Inc", "4839797684039279682", "Cocos (Keeling) Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 4, 5, 17, 8, 31, 851, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 2, 15, 22, 5, 51, 306, DateTimeKind.Local).AddTicks(9131), "زيد طارق", "Juliana Halvorson", 0, "أسامة - ربيع", "669055243041595487", "Liechtenstein", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 6, 5, 13, 11, 37, 914, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 2, 15, 10, 38, 35, 511, DateTimeKind.Local).AddTicks(6142), "ريم إيهاب", "Elena Fisher", 1, "صلاح Inc", "8741219105369288418", "Greenland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 12, 1, 18, 0, 4, 392, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 2, 15, 18, 12, 30, 125, DateTimeKind.Local).AddTicks(738), "طارق هاشم", "Nikolas Kemmer", "عارف - عراقی", "91442779297996764", "Bolivia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 8, 4, 12, 3, 27, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 2, 15, 8, 20, 57, 90, DateTimeKind.Local).AddTicks(2419), "شيماء عزیز", "Alivia O'Kon", 0, "سعيد - سالم", "3655633916647497294", "Cook Islands", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 1, 11, 1, 14, 24, 212, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 2, 15, 14, 49, 30, 42, DateTimeKind.Local).AddTicks(1593), "فريد طارق", "Chet Gorczany", 1, "عصار - طارق", "570345191999806178", "Dominican Republic", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 18, 3, 54, 57, 980, DateTimeKind.Local).AddTicks(886), new DateTime(2024, 2, 15, 13, 50, 54, 53, DateTimeKind.Local).AddTicks(2236), "أسامة أسامة", "Alden Gorczany", 0, "هاشم - سالم", "7409416052902295470", "Maldives", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 6, 18, 0, 26, 56, 247, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 2, 15, 6, 28, 14, 249, DateTimeKind.Local).AddTicks(2849), "إيهاب هاشم", "Greyson Schroeder", 1, "زيد, معروف and عزیز", "7810855881313392937", "Northern Mariana Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 20, 9, 31, 30, 159, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 2, 15, 20, 58, 36, 923, DateTimeKind.Local).AddTicks(8336), "فاروق هاشم", "Myra Kub", 0, "صلاح, فاروق and عزیز", "1021967574852893960", "Cuba", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 9, 7, 18, 28, 50, 956, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 15, 1, 31, 49, 335, DateTimeKind.Local).AddTicks(2247), "آية عقیل", "Arno Bailey", "طارق, بلال and إيهاب", "440548639607851369", "Tanzania", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 8, 25, 18, 16, 25, 887, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 2, 15, 2, 14, 18, 350, DateTimeKind.Local).AddTicks(3745), "فريد سعيد", "Heather Feeney", "حازم LLC", "6269584762219650671", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 2, 22, 6, 2, 0, 103, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 2, 15, 22, 18, 10, 645, DateTimeKind.Local).AddTicks(123), "إيهاب عصار", "Jane Schultz", "عقیل - أسامة", "218984590437428133", "Togo", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 5, 19, 7, 29, 53, 290, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 2, 15, 2, 3, 34, 106, DateTimeKind.Local).AddTicks(3359), "ريم عراقی", "Jose Macejkovic", 0, "طارق - فريد", "6806163817250540693", "Monaco" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 10, 15, 21, 44, 38, 449, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 2, 14, 23, 28, 31, 824, DateTimeKind.Local).AddTicks(9939), "سالم سالم", "Hilma Stokes", 0, "هاشم, طارق and آدم", "669826364110048408", "Bahamas", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 3, 7, 5, 12, 58, 256, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 15, 17, 58, 53, 319, DateTimeKind.Local).AddTicks(4690), "زيد فريد", "Winifred Mraz", 1, "إيهاب - طارق", "4700957060047731119", "Maldives" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 10, 8, 11, 58, 1, 467, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 2, 15, 17, 48, 57, 353, DateTimeKind.Local).AddTicks(7145), "ريم سعيد", "Laura Crist", "أمجد, حسن and هاشم", "1885363441331786679", "Pitcairn Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 1, 23, 0, 26, 7, 621, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 2, 15, 13, 58, 5, 200, DateTimeKind.Local).AddTicks(706), "فاطمة سالم", "Giovanna Klein", "عارف Group", "6068189267447305210", "Cocos (Keeling) Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 12, 2, 22, 21, 33, 471, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 2, 15, 3, 30, 30, 550, DateTimeKind.Local).AddTicks(4019), "هاجر عزیز", "Adrain Cremin", 1, "بلال - صلاح", "6485319277387408457", "Lithuania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 5, 18, 15, 36, 54, 557, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 2, 15, 14, 42, 4, 383, DateTimeKind.Local).AddTicks(8845), "فريدة معروف", "Orval Lebsack", 0, "معروف Group", "3409688880291452626", "Norway", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 11, 13, 12, 30, 10, 246, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 2, 15, 19, 1, 18, 204, DateTimeKind.Local).AddTicks(4468), "هاجر إيهاب", "Eliseo Pfannerstill", "حسن LLC", "1499215009851469349", "Bhutan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 4, 28, 14, 43, 58, 186, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 2, 15, 11, 11, 53, 897, DateTimeKind.Local).AddTicks(1628), "إيناس فريد", "Johnny Runte", "عاشور - طارق", "3348188796376290135", "Montenegro", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 7, 15, 18, 8, 32, 163, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 2, 15, 8, 12, 34, 227, DateTimeKind.Local).AddTicks(4282), "إيناس فريد", "Carmine Schroeder", 1, "فاروق Inc", "7051719713393600185", "Austria", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 5, 15, 5, 3, 12, 969, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 2, 15, 17, 6, 47, 530, DateTimeKind.Local).AddTicks(9918), "جابر‌ فؤاد", "Elmo Stark", 0, "فؤاد LLC", "427569237760968293", "Qatar", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 3, 6, 7, 1, 47, 233, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 2, 15, 22, 29, 38, 68, DateTimeKind.Local).AddTicks(948), "جابر‌ أسامة", "Velva Towne", 0, "بلال Group", "3908870343357305243", "Germany", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 14, 6, 33, 39, 382, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 2, 15, 21, 7, 15, 910, DateTimeKind.Local).AddTicks(5641), "منى جابر‌", "Forest Conroy", "حسن - طارق", "764390056859179802", "Ethiopia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 5, 12, 7, 42, 51, 455, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 2, 15, 13, 7, 27, 361, DateTimeKind.Local).AddTicks(1258), "رنا آدم", "Asia Reichert", 1, "حسن - طارق", "4646914493930807592", "Greece" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 6, 29, 23, 8, 42, 625, DateTimeKind.Local).AddTicks(3801), new DateTime(2024, 2, 15, 0, 11, 10, 412, DateTimeKind.Local).AddTicks(1274), "طارق زيد", "Kaylie Hirthe", "إيهاب LLC", "3815593430075246586", "Holy See (Vatican City State)", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 1, 20, 16, 42, 29, 690, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 15, 18, 48, 25, 565, DateTimeKind.Local).AddTicks(5996), "جابر‌ هاشم", "Haylee Kuvalis", "سالم, جابر‌ and عزیز", "6394005353289646471", "Indonesia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 6, 24, 16, 26, 9, 859, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 2, 15, 9, 21, 36, 768, DateTimeKind.Local).AddTicks(2589), "بلال فؤاد", "Karelle Breitenberg", 0, "فاروق and Sons", "737728664949193132", "Colombia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 13, 10, 56, 15, 4, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 2, 15, 11, 55, 23, 801, DateTimeKind.Local).AddTicks(3807), "ربيع بلال", "Melvina Russel", "عزیز, زيد and عقیل", "368059399141732701", "Syrian Arab Republic", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 9, 28, 16, 55, 26, 828, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 2, 15, 11, 43, 36, 554, DateTimeKind.Local).AddTicks(8024), "آدم هاشم", "Derrick Larson", 1, "جابر‌ and Sons", "1072349061637574156", "Saudi Arabia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 4, 13, 20, 36, 20, 263, DateTimeKind.Local).AddTicks(1112), new DateTime(2024, 2, 15, 3, 18, 10, 157, DateTimeKind.Local).AddTicks(2852), "دانا فريد", "Kaitlyn Bruen", "أمجد LLC", "893074649797275354", "Albania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 1, 30, 11, 59, 59, 58, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 2, 15, 4, 37, 15, 310, DateTimeKind.Local).AddTicks(3605), "أسامة عاشور", "Elias Kautzer", 0, "عراقی Group", "4529356362085647439", "Cameroon", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 2, 22, 22, 56, 12, 663, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 2, 15, 9, 49, 5, 18, DateTimeKind.Local).AddTicks(9701), "فؤاد جابر‌", "Quinton Dibbert", 0, "عقیل - فاروق", "1063240222529633669", "Gibraltar", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 12, 20, 8, 51, 38, 350, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 2, 15, 14, 37, 21, 10, DateTimeKind.Local).AddTicks(4550), "لمى آدم", "Madison Huel", "أمجد, طارق and عقیل", "6761854847374147752", "Sri Lanka", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 5, 10, 23, 27, 37, 315, DateTimeKind.Local).AddTicks(3369), new DateTime(2024, 2, 15, 4, 48, 24, 743, DateTimeKind.Local).AddTicks(4968), "رقية حسن", "Eugene Jacobi", 0, "عراقی - عزیز", "4329987498849478297", "Pakistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 13, 22, 36, 35, 669, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 2, 15, 6, 26, 18, 870, DateTimeKind.Local).AddTicks(419), "دانا بلال", "Royce Howe", 1, "أمجد Group", "2463956312505817675", "Seychelles", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 6, 26, 18, 8, 43, 78, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 2, 15, 4, 13, 37, 192, DateTimeKind.Local).AddTicks(9232), "فاطمة بلال", "Aileen Hayes", "حازم, سعيد and فؤاد", "484517004165736764", "Morocco", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 25, 14, 59, 53, 811, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 2, 15, 9, 30, 16, 273, DateTimeKind.Local).AddTicks(4669), "فاطمة جابر‌", "Christ Wolf", "آدم - أمجد", "973041153499546952", "Iran", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 1, 22, 14, 13, 53, 614, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 2, 15, 9, 7, 48, 176, DateTimeKind.Local).AddTicks(7607), "لمى إيهاب", "Judd Becker", "فؤاد, عزیز and أسامة", "8984622568367226905", "Trinidad and Tobago", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1979, 8, 11, 7, 27, 4, 767, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 2, 15, 2, 21, 53, 882, DateTimeKind.Local).AddTicks(4189), "بلال ربيع", "Ena Franecki", 0, "عزیز LLC", "1809156637591717010", "Croatia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 3, 26, 5, 2, 27, 399, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 2, 15, 5, 54, 37, 695, DateTimeKind.Local).AddTicks(8236), "رنا بلال", "Lucinda Trantow", 1, "زيد Inc", "1572568887973101047", "Kiribati", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 10, 20, 58, 8, 997, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 2, 15, 17, 12, 28, 655, DateTimeKind.Local).AddTicks(3096), "رقية فؤاد", "Hanna Cassin", 0, "ربيع - ربيع", "5581795473608619138", "Burundi", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 9, 12, 1, 43, 51, 119, DateTimeKind.Local).AddTicks(169), new DateTime(2024, 2, 15, 2, 18, 38, 289, DateTimeKind.Local).AddTicks(713), "سالم أسامة", "Leopoldo Koepp", 1, "عارف, عراقی and عارف", "3146126397142646274", "Morocco", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 11, 5, 0, 1, 14, 649, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 2, 15, 16, 14, 36, 431, DateTimeKind.Local).AddTicks(9717), "طارق آدم", "Eveline Moore", "عقیل and Sons", "1947646479103317088", "Palau", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1964, 11, 13, 18, 39, 11, 334, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 2, 15, 17, 26, 6, 987, DateTimeKind.Local).AddTicks(4578), "صلاح عزیز", "Pearline Altenwerth", "جابر‌ - عراقی", "1837689906817548234", "United States Minor Outlying Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 5, 25, 19, 49, 38, 47, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 2, 15, 13, 28, 52, 411, DateTimeKind.Local).AddTicks(2067), "فريدة زيد", "Verner Nader", 0, "حسن Inc", "6315101761726529813", "Bouvet Island (Bouvetoya)" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1968, 2, 4, 22, 45, 36, 364, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 2, 15, 6, 31, 33, 237, DateTimeKind.Local).AddTicks(9684), "صلاح عراقی", "Devan Steuber", 1, "فاروق, عارف and طارق", "9060460808709822528", "Estonia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 6, 28, 0, 22, 9, 966, DateTimeKind.Local).AddTicks(7677), new DateTime(2024, 2, 15, 7, 26, 15, 46, DateTimeKind.Local).AddTicks(4963), "شيماء عراقی", "Treva Abernathy", "معروف - حسن", "4157029840731294514", "Guinea", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 4, 17, 19, 57, 3, 891, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 2, 15, 1, 10, 8, 142, DateTimeKind.Local).AddTicks(2551), "فاروق عاشور", "Timothy Blanda", 1, "أسامة - أمجد", "6859667578873602343", "Jersey", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 3, 27, 7, 14, 0, 381, DateTimeKind.Local).AddTicks(402), new DateTime(2024, 2, 15, 0, 25, 12, 379, DateTimeKind.Local).AddTicks(5831), "ربيع معروف", "Monserrate Fritsch", "سعيد, عصار and بلال", "4475364623048929505", "France" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 6, 23, 16, 57, 1, 451, DateTimeKind.Local).AddTicks(3099), new DateTime(2024, 2, 15, 9, 19, 4, 637, DateTimeKind.Local).AddTicks(9997), "ريم إيهاب", "Tierra Leuschke", 1, "فؤاد LLC", "4574674786063078563", "Central African Republic", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 9, 26, 20, 23, 14, 760, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 2, 15, 15, 16, 12, 498, DateTimeKind.Local).AddTicks(5814), "سارة جابر‌", "Modesto Purdy", "عقیل Inc", "494489947612238263", "Honduras" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 11, 21, 11, 56, 37, 817, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 2, 15, 17, 59, 17, 845, DateTimeKind.Local).AddTicks(6451), "زيد ربيع", "Imelda Schumm", "جابر‌, عزیز and عصار", "5197186892152825091", "Uganda", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 3, 15, 1, 45, 42, 128, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 2, 15, 5, 32, 36, 635, DateTimeKind.Local).AddTicks(6871), "رنا عصار", "Kraig Stark", 0, "أمجد and Sons", "2223358222844631716", "Mauritania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 1, 18, 16, 52, 709, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 2, 15, 8, 10, 41, 364, DateTimeKind.Local).AddTicks(3064), "حسن آدم", "Elouise Veum", 1, "فؤاد, هاشم and عصار", "8697781957799590437", "Sri Lanka", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1985, 5, 14, 18, 28, 25, 520, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 2, 15, 12, 26, 41, 198, DateTimeKind.Local).AddTicks(1756), "طارق عقیل", "Toby Feest", 1, "إيهاب, صلاح and فريد", "5344637697599783723", "Taiwan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 8, 4, 16, 44, 526, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 2, 15, 20, 15, 26, 835, DateTimeKind.Local).AddTicks(2417), "سالم حازم", "Roosevelt Price", "أمجد Group", "5339194641348493192", "Tajikistan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 4, 17, 16, 51, 47, 453, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 2, 14, 23, 14, 49, 862, DateTimeKind.Local).AddTicks(2322), "طارق عزیز", "Margot Zemlak", "طارق, جابر‌ and عقیل", "5322903680229794505", "Ukraine", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 11, 5, 9, 41, 38, 561, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 2, 15, 1, 20, 4, 414, DateTimeKind.Local).AddTicks(5941), "عبير بلال", "Carole Mann", 0, "معروف - عاشور", "7739825505686720205", "Reunion", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 10, 17, 23, 2, 36, 317, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 2, 15, 6, 31, 7, 692, DateTimeKind.Local).AddTicks(9433), "شيماء معروف", "Citlalli Beatty", "حسن, عزیز and طارق", "1903924555055702459", "Bosnia and Herzegovina", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 12, 16, 0, 4, 49, 231, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 2, 15, 12, 47, 53, 619, DateTimeKind.Local).AddTicks(4185), "إيناس عاشور", "William Pagac", 0, "فاروق, فريد and جابر‌", "5977331195573521873", "Central African Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 6, 23, 14, 24, 12, 608, DateTimeKind.Local).AddTicks(2342), new DateTime(2024, 2, 15, 22, 31, 7, 621, DateTimeKind.Local).AddTicks(5896), "سارة عزیز", "Blaze Lemke", 0, "حازم - عارف", "2136342164699782954", "Grenada", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 10, 10, 19, 10, 31, 426, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 2, 15, 0, 14, 34, 308, DateTimeKind.Local).AddTicks(1264), "زيد فاروق", "Dangelo McLaughlin", "بلال LLC", "9072167543605384357", "Poland", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 10, 8, 6, 12, 3, 10, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 2, 15, 12, 20, 47, 872, DateTimeKind.Local).AddTicks(6109), "رنا بلال", "Abner Gleason", 1, "بلال and Sons", "2228034694052752071", "Tokelau", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 8, 24, 9, 26, 3, 728, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 2, 15, 8, 32, 4, 436, DateTimeKind.Local).AddTicks(6530), "ربيع حسن", "Meredith DuBuque", 0, "عارف, بلال and سالم", "5077122283792560618", "Vanuatu", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1974, 7, 15, 9, 8, 9, 794, DateTimeKind.Local).AddTicks(1564), new DateTime(2024, 2, 15, 10, 38, 48, 560, DateTimeKind.Local).AddTicks(4448), "حازم أمجد", "Zachary Rolfson", "أسامة, طارق and معروف", "4063605657143528980", "Micronesia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1967, 2, 15, 18, 12, 40, 315, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 2, 15, 21, 33, 31, 207, DateTimeKind.Local).AddTicks(9112), "أسامة عزیز", "Zion Murazik", "حازم - فؤاد", "4102216804923976441", "Monaco" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 5, 28, 11, 45, 15, 261, DateTimeKind.Local).AddTicks(3271), new DateTime(2024, 2, 15, 6, 48, 26, 746, DateTimeKind.Local).AddTicks(4035), "أمجد فريد", "Adolphus Zboncak", "عصار and Sons", "2268077673901098063", "Taiwan", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 9, 9, 13, 30, 12, 574, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 15, 17, 10, 24, 868, DateTimeKind.Local).AddTicks(3989), "سالم طارق", "Madilyn Renner", 1, "ربيع Inc", "647633879945407341", "Croatia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 10, 8, 23, 0, 48, 397, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 2, 15, 1, 56, 42, 434, DateTimeKind.Local).AddTicks(6350), "منى حازم", "Brook Larkin", "عقیل - ربيع", "2571467102379685438", "Ghana", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 2, 14, 1, 24, 35, 819, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 2, 15, 12, 51, 57, 701, DateTimeKind.Local).AddTicks(9080), "ربيع بلال", "Jordyn Osinski", "معروف - سعيد", "6879602506960539900", "Botswana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 6, 10, 10, 11, 27, DateTimeKind.Local).AddTicks(3786), new DateTime(2024, 2, 15, 5, 8, 55, 788, DateTimeKind.Local).AddTicks(5644), "جمانة زيد", "Sabryna White", 1, "صلاح, حازم and فاروق", "5769380312091553601", "American Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 9, 25, 1, 3, 36, 162, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 2, 15, 15, 46, 54, 616, DateTimeKind.Local).AddTicks(9132), "فاروق آدم", "Schuyler Pollich", "فاروق, آدم and فؤاد", "8141622552241544624", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 1, 12, 0, 42, 23, 603, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 2, 14, 23, 51, 17, 463, DateTimeKind.Local).AddTicks(1805), "آية جابر‌", "Marlon Stanton", "عصار, فؤاد and حازم", "7937335783877629312", "Morocco", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 1, 20, 10, 4, 36, 803, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 2, 15, 10, 49, 25, 62, DateTimeKind.Local).AddTicks(4336), "منى عزیز", "Aurore Lehner", "جابر‌ Group", "2969673887874751611", "Saint Kitts and Nevis" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 9, 11, 1, 36, 43, 257, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 2, 15, 1, 14, 52, 512, DateTimeKind.Local).AddTicks(5700), "زينب صلاح", "Hillary Abbott", "عاشور, عقیل and معروف", "5196034107828094631", "Solomon Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1984, 9, 27, 20, 18, 56, 84, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 2, 15, 8, 54, 11, 252, DateTimeKind.Local).AddTicks(3805), "هاجر عاشور", "Krista Murphy", "عزیز - معروف", "5668575868987754879", "Isle of Man", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 10, 16, 1, 28, 32, 725, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 2, 15, 3, 41, 42, 772, DateTimeKind.Local).AddTicks(810), "رقية آدم", "Brock Purdy", "ربيع LLC", "8022040424151219837", "Central African Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 6, 9, 10, 13, 24, 325, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 2, 15, 19, 41, 39, 790, DateTimeKind.Local).AddTicks(1146), "لمى معروف", "Agustina Barton", "فريد and Sons", "5529543311033555284", "Sweden", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 4, 17, 0, 10, 20, 551, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 2, 15, 17, 10, 16, 754, DateTimeKind.Local).AddTicks(1725), "أسامة عراقی", "Kaylee Gorczany", "حسن LLC", "1046068351760486215", "Timor-Leste" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 6, 13, 2, 20, 58, 882, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 2, 15, 2, 9, 15, 929, DateTimeKind.Local).AddTicks(2593), "رنا طارق", "Gabriella Lubowitz", "إيهاب - عصار", "8350657405756514941", "Iraq", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 6, 14, 0, 41, 20, 598, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 2, 15, 15, 46, 35, 851, DateTimeKind.Local).AddTicks(5318), "آية سالم", "Daisy Wyman", "بلال, جابر‌ and أسامة", "2119999664457498212", "Bulgaria", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 17, 17, 0, 34, 752, DateTimeKind.Local).AddTicks(8944), new DateTime(2024, 2, 15, 21, 16, 28, 78, DateTimeKind.Local).AddTicks(3809), "بلال سالم", "Mortimer Ryan", 0, "ربيع LLC", "6460188687659555572", "Togo", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 12, 11, 10, 19, 5, 373, DateTimeKind.Local).AddTicks(2410), new DateTime(2024, 2, 15, 16, 27, 4, 80, DateTimeKind.Local).AddTicks(282), "منى طارق", "Hassan Brown", 0, "عقیل Inc", "5848476212160889184", "Sweden", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 14, 1, 16, 21, 718, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 2, 15, 21, 0, 16, 731, DateTimeKind.Local).AddTicks(8983), "أمجد حسن", "Hilma Walsh", 1, "إيهاب - عاشور", "6348830507998848242", "Saint Lucia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 7, 30, 0, 43, 52, 317, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 2, 15, 21, 49, 25, 514, DateTimeKind.Local).AddTicks(6497), "فاروق معروف", "Jayda Strosin", "عارف Inc", "7451353591614788604", "Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 3, 20, 8, 51, 19, 739, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 2, 15, 14, 14, 32, 605, DateTimeKind.Local).AddTicks(224), "فريدة طارق", "Manuel Terry", "صلاح - أمجد", "5461017462434904445", "Uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 10, 31, 19, 4, 53, 622, DateTimeKind.Local).AddTicks(3855), new DateTime(2024, 2, 15, 11, 33, 19, 598, DateTimeKind.Local).AddTicks(1932), "بلال إيهاب", "Aileen Hilll", 0, "أسامة, ربيع and سعيد", "6992038928632375122", "Liberia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 6, 23, 15, 55, 15, 424, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 15, 8, 42, 38, 793, DateTimeKind.Local).AddTicks(8135), "حازم إيهاب", "Bria Trantow", "طارق - معروف", "1827151763358060971", "Portugal", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 2, 2, 0, 50, 22, 556, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 2, 15, 3, 8, 4, 376, DateTimeKind.Local).AddTicks(9985), "فريد أسامة", "Nathan Schinner", "عقیل, حسن and معروف", "541725147033930716", "Greenland", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 11, 2, 2, 5, 33, 103, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 2, 14, 23, 13, 4, 478, DateTimeKind.Local).AddTicks(8160), "فؤاد آدم", "Emmanuelle Weimann", 0, "معروف, فؤاد and جابر‌", "8679298349755401676", "Cuba", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1995, 1, 21, 4, 8, 27, 380, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 2, 15, 0, 3, 11, 651, DateTimeKind.Local).AddTicks(7273), "آدم حازم", "Brannon Dibbert", "آدم and Sons", "302323298398204739", "Bolivia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 3, 28, 1, 58, 3, 750, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 2, 15, 9, 9, 51, 470, DateTimeKind.Local).AddTicks(6584), "هاجر عزیز", "Claudie Ledner", 0, "فؤاد - جابر‌", "2408140807286389536", "Saint Martin" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 2, 19, 5, 34, 57, 212, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 2, 15, 12, 46, 5, 373, DateTimeKind.Local).AddTicks(175), "سارة ربيع", "Ansel Romaguera", 0, "سالم - سعيد", "5014603036224860091", "Belarus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1982, 5, 9, 21, 18, 29, 549, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 2, 15, 7, 25, 14, 202, DateTimeKind.Local).AddTicks(753), "ربيع عقیل", "Buford Champlin", 1, "إيهاب, هاشم and أسامة", "2953855335164242908", "Micronesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1979, 5, 17, 5, 3, 26, 955, DateTimeKind.Local).AddTicks(202), new DateTime(2024, 2, 15, 11, 9, 54, 18, DateTimeKind.Local).AddTicks(2271), "رقية سالم", "Clifton Klocko", "معروف Inc", "8013406249470145623", "Gabon" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 12, 25, 0, 59, 56, 717, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 2, 15, 8, 0, 31, 993, DateTimeKind.Local).AddTicks(92), "زيد سعيد", "Aubrey McKenzie", "جابر‌ Inc", "3455245422329593919", "Namibia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1990, 6, 4, 4, 26, 29, 98, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 2, 15, 0, 45, 7, 36, DateTimeKind.Local).AddTicks(1806), "إيناس آدم", "Lloyd O'Reilly", 1, "عزیز - عاشور", "8406588402227997063", "Comoros", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 2, 9, 16, 43, 6, 497, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 15, 22, 40, 20, 908, DateTimeKind.Local).AddTicks(6776), "فاطمة معروف", "Demetris Mosciski", 1, "سعيد, جابر‌ and حازم", "41576559263720417", "Democratic People's Republic of Korea", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 2, 3, 7, 35, 27, 560, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 2, 15, 11, 55, 11, 902, DateTimeKind.Local).AddTicks(9629), "ربيع عاشور", "Dino Rutherford", "سعيد - طارق", "2694034413149777704", "Central African Republic", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 5, 2, 17, 0, 46, 974, DateTimeKind.Local).AddTicks(4274), new DateTime(2024, 2, 15, 18, 13, 9, 577, DateTimeKind.Local).AddTicks(5613), "أسامة عزیز", "Eve Powlowski", 0, "فؤاد, فريد and عزیز", "8997437878876398353", "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 8, 4, 11, 50, 12, 687, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 2, 15, 11, 25, 19, 232, DateTimeKind.Local).AddTicks(2679), "آدم سعيد", "Rhea Rogahn", "سالم - طارق", "1863000704980246892", "Ethiopia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 5, 26, 16, 33, 49, 975, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 2, 15, 6, 40, 45, 987, DateTimeKind.Local).AddTicks(2537), "لمى عارف", "Kane Purdy", 0, "معروف - زيد", "4930205601128756381", "Bouvet Island (Bouvetoya)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 7, 12, 16, 13, 24, 99, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 2, 15, 15, 51, 13, 896, DateTimeKind.Local).AddTicks(2138), "حازم زيد", "Lurline Bruen", "عقیل, فريد and أمجد", "8808722042287050860", "Christmas Island", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 10, 12, 14, 16, 21, 63, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 2, 15, 13, 32, 45, 540, DateTimeKind.Local).AddTicks(6519), "دانا عقیل", "Lucinda Goldner", "حازم and Sons", "4174877342752407379", "Lebanon", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 10, 7, 11, 30, 54, 129, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 2, 15, 19, 10, 44, 840, DateTimeKind.Local).AddTicks(1275), "زيد ربيع", "Emiliano Doyle", "أمجد, سعيد and عزیز", "2080099250371841712", "Cook Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 3, 0, 27, 5, 71, DateTimeKind.Local).AddTicks(5754), new DateTime(2024, 2, 15, 4, 20, 56, 959, DateTimeKind.Local).AddTicks(1039), "فؤاد آدم", "Javon Thiel", 0, "فريد - جابر‌", "6939344348363164457", "Rwanda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 7, 15, 17, 28, 44, 27, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 2, 15, 22, 18, 43, 80, DateTimeKind.Local).AddTicks(6137), "سالم فؤاد", "Nelson Feil", "عارف and Sons", "4785798500373797082", "Canada", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1976, 9, 21, 22, 41, 58, 245, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 2, 15, 7, 51, 20, 328, DateTimeKind.Local).AddTicks(407), "ريم آدم", "Regan Larkin", 0, "بلال LLC", "4965308307511637046", "Angola" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 4, 23, 19, 23, 46, 750, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 2, 15, 2, 7, 52, 694, DateTimeKind.Local).AddTicks(7530), "بلال آدم", "Jovani Gutkowski", 1, "حازم LLC", "7595387389069513637", "Marshall Islands" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 5, 19, 22, 7, 23, 498, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 2, 15, 12, 51, 52, 91, DateTimeKind.Local).AddTicks(5853), "أسامة هاشم", "Darryl Leuschke", 0, "طارق - عزیز", "5650081333929185727", "Benin", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 5, 7, 10, 0, 34, 720, DateTimeKind.Local).AddTicks(5429), new DateTime(2024, 2, 15, 13, 8, 56, 158, DateTimeKind.Local).AddTicks(9606), "شيماء جابر‌", "Luis Hoppe", 1, "عقیل and Sons", "6663320313368472427", "Zambia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 10, 16, 14, 16, 7, 258, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 2, 15, 4, 40, 30, 489, DateTimeKind.Local).AddTicks(1723), "بلال عاشور", "Emmanuelle Feest", 1, "عاشور - أسامة", "7672952787042348223", "Hungary", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 8, 12, 20, 10, 33, 442, DateTimeKind.Local).AddTicks(6457), new DateTime(2024, 2, 15, 13, 19, 12, 128, DateTimeKind.Local).AddTicks(7410), "إيناس صلاح", "Ivy Breitenberg", 1, "عارف LLC", "683787222473804703", "Australia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 4, 11, 3, 25, 34, 200, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 2, 15, 6, 17, 53, 925, DateTimeKind.Local).AddTicks(7451), "عبير آدم", "Stevie Dickens", "أسامة, زيد and فؤاد", "7835320355507401829", "Guernsey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 12, 16, 4, 7, 21, 12, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 2, 15, 20, 14, 30, 776, DateTimeKind.Local).AddTicks(928), "عبير أسامة", "Myriam Lang", 1, "أمجد - جابر‌", "643539141361791972", "Rwanda", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1977, 2, 26, 6, 51, 51, 580, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 2, 15, 9, 45, 49, 662, DateTimeKind.Local).AddTicks(3450), "سالم آدم", "Audreanne Swaniawski", 0, "أمجد, هاشم and أسامة", "6921131277215989636", "Isle of Man" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 22, 2, 16, 13, 719, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 2, 15, 2, 50, 1, 598, DateTimeKind.Local).AddTicks(6723), "جمانة عقیل", "Skylar Monahan", 0, "عزیز, أمجد and عقیل", "1394232866369182815", "Sao Tome and Principe", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 11, 14, 1, 59, 44, 539, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 2, 15, 6, 58, 17, 9, DateTimeKind.Local).AddTicks(2537), "جمانة جابر‌", "Dwight Hegmann", 1, "طارق, سعيد and فاروق", "2447310372232246334", "Guam", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 10, 9, 21, 19, 44, 143, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 2, 15, 14, 32, 25, 781, DateTimeKind.Local).AddTicks(9483), "منى معروف", "Corine Schaefer", "حازم, عزیز and فؤاد", "2277322708963822042", "Saint Kitts and Nevis", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 6, 20, 16, 37, 31, 276, DateTimeKind.Local).AddTicks(2243), new DateTime(2024, 2, 15, 11, 24, 19, 254, DateTimeKind.Local).AddTicks(6266), "سالم صلاح", "Tyrique Bashirian", "هاشم LLC", "2310676087712390706", "Saint Martin", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 1, 2, 46, 37, 293, DateTimeKind.Local).AddTicks(2495), new DateTime(2024, 2, 15, 6, 28, 8, 118, DateTimeKind.Local).AddTicks(5365), "زينب فريد", "Ashleigh Schimmel", 0, "عقیل, فؤاد and بلال", "3191284447812153295", "Maldives", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 19, 18, 44, 25, 154, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 2, 15, 11, 47, 32, 501, DateTimeKind.Local).AddTicks(9279), "جابر‌ عصار", "Bernie Luettgen", 0, "فريد - آدم", "8862478998828169797", "Austria", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 11, 14, 21, 28, 28, 264, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 2, 15, 22, 25, 10, 867, DateTimeKind.Local).AddTicks(389), "فاطمة زيد", "Jace Barrows", 1, "آدم, عارف and فاروق", "5710254584482833963", "Dominican Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 9, 14, 23, 57, 42, 692, DateTimeKind.Local).AddTicks(4101), new DateTime(2024, 2, 15, 13, 31, 10, 807, DateTimeKind.Local).AddTicks(1592), "جمانة فؤاد", "Julie Bahringer", "حسن, جابر‌ and فؤاد", "1275492058099052536", "Liechtenstein", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 1, 2, 5, 0, 10, 507, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 2, 15, 14, 23, 24, 968, DateTimeKind.Local).AddTicks(6439), "آية عصار", "Marlon Reilly", "زيد, سعيد and حسن", "1244545883956573974", "Ghana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1960, 9, 2, 9, 35, 39, 242, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 2, 15, 12, 15, 5, 722, DateTimeKind.Local).AddTicks(8689), "آية ربيع", "Delmer Dietrich", "فاروق - جابر‌", "293055600619345750", "China", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 6, 16, 4, 22, 30, 23, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 2, 15, 7, 48, 1, 318, DateTimeKind.Local).AddTicks(7616), "إيهاب حسن", "Jaeden Moore", 1, "عاشور LLC", "595280247626758860", "Bangladesh", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 11, 2, 6, 0, 50, 472, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 2, 15, 20, 2, 17, 607, DateTimeKind.Local).AddTicks(8573), "عبير أمجد", "Cora Bechtelar", "عاشور, عزیز and عاشور", "3996763256631562732", "Chad", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 10, 17, 6, 50, 29, 781, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 2, 15, 10, 49, 33, 973, DateTimeKind.Local).AddTicks(1166), "جابر‌ فريد", "Renee Jones", 0, "عصار, عقیل and زيد", "4572256614765091192", "Nepal", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1963, 8, 8, 22, 23, 54, 52, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 2, 15, 2, 14, 18, 731, DateTimeKind.Local).AddTicks(6876), "فؤاد إيهاب", "Connor Schroeder", "سالم - أسامة", "3621984464812343581", "Uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 5, 2, 6, 33, 26, 807, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 2, 15, 1, 27, 24, 61, DateTimeKind.Local).AddTicks(7607), "أسامة سعيد", "Catharine Miller", "عصار, حازم and آدم", "2252132961859072407", "Sao Tome and Principe", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 11, 9, 11, 42, 40, 320, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 2, 15, 19, 29, 26, 453, DateTimeKind.Local).AddTicks(8767), "أروى إيهاب", "Leone Schuster", 0, "عارف - حازم", "157095403164724048", "Vietnam", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 4, 4, 47, 29, 684, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 2, 15, 1, 6, 6, 112, DateTimeKind.Local).AddTicks(871), "فريد زيد", "Jennifer Romaguera", 1, "سالم - عزیز", "6060735193057034560", "Mali", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 11, 16, 8, 13, 22, 87, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 2, 15, 20, 49, 8, 84, DateTimeKind.Local).AddTicks(3475), "إيهاب عقیل", "Anna Kuhic", "عصار, معروف and عارف", "9167012998046220979", "Iran", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 6, 16, 19, 5, 50, 965, DateTimeKind.Local).AddTicks(6591), new DateTime(2024, 2, 15, 2, 20, 15, 671, DateTimeKind.Local).AddTicks(9464), "منى جابر‌", "Madge Gottlieb", "فؤاد Inc", "9117123574867147636", "Nauru", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 20, 22, 55, 36, 602, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 2, 15, 8, 13, 27, 88, DateTimeKind.Local).AddTicks(6145), "صلاح جابر‌", "Kenny Welch", "عارف and Sons", "7325096034956811906", "Western Sahara", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 1, 23, 1, 56, 51, 463, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 2, 15, 16, 33, 2, 678, DateTimeKind.Local).AddTicks(7139), "آية عاشور", "Lenna Connelly", 0, "إيهاب Inc", "1239969859691914670", "Gambia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 9, 11, 1, 24, 17, 918, DateTimeKind.Local).AddTicks(494), new DateTime(2024, 2, 15, 6, 15, 35, 407, DateTimeKind.Local).AddTicks(5333), "فريد حازم", "Cooper Kub", "حازم - طارق", "7356568083350522541", "Guadeloupe", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 13, 17, 42, 43, 255, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 2, 15, 1, 58, 40, 582, DateTimeKind.Local).AddTicks(3253), "أروى عارف", "Weston Hammes", "أسامة Inc", "51963069156339691", "Ethiopia", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 9, 23, 6, 3, 260, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 2, 15, 14, 16, 52, 564, DateTimeKind.Local).AddTicks(1480), "جمانة فؤاد", "Deion Maggio", "حسن, أمجد and زيد", "4951178205189669208", "Afghanistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 10, 10, 7, 6, 0, 37, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 2, 15, 2, 19, 45, 209, DateTimeKind.Local).AddTicks(9295), "ريم حازم", "Coleman Wunsch", "هاشم - طارق", "7002165819718573158", "South Georgia and the South Sandwich Islands", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 6, 30, 15, 17, 24, 400, DateTimeKind.Local).AddTicks(3237), new DateTime(2024, 2, 15, 21, 22, 30, 390, DateTimeKind.Local).AddTicks(9845), "جمانة آدم", "Buck Kozey", 0, "سالم Inc", "987223408433375338", "French Guiana", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 28, 7, 55, 6, 498, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 2, 15, 18, 35, 53, 529, DateTimeKind.Local).AddTicks(1313), "آدم عزیز", "Brad Lowe", "بلال - معروف", "5863525095999920729", "Mozambique", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1966, 4, 3, 7, 54, 48, 776, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 2, 15, 8, 25, 3, 971, DateTimeKind.Local).AddTicks(3100), "منى عزیز", "Bernadine Christiansen", 1, "عصار Group", "9132103868020117819", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 8, 29, 1, 0, 13, 156, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 2, 15, 7, 39, 55, 626, DateTimeKind.Local).AddTicks(1011), "إيهاب سعيد", "Gerardo Hahn", 0, "عارف - طارق", "2321927466209912666", "Palau", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 7, 16, 1, 24, 5, 510, DateTimeKind.Local).AddTicks(6082), new DateTime(2024, 2, 15, 18, 34, 26, 995, DateTimeKind.Local).AddTicks(5000), "بلال حسن", "Nova Luettgen", 1, "فريد, معروف and هاشم", "1202317105002460478", "France", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 27, 10, 25, 7, 882, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 2, 15, 9, 18, 26, 558, DateTimeKind.Local).AddTicks(5179), "جمانة زيد", "Dejah Fisher", "سعيد - فريد", "8956187118291717867", "Malawi", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 8, 30, 3, 38, 30, 13, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 2, 15, 13, 8, 10, 706, DateTimeKind.Local).AddTicks(5938), "لمى ربيع", "Arturo Lueilwitz", "جابر‌ - أسامة", "6092311897513737466", "Pitcairn Islands", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 9, 4, 4, 17, 21, 517, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 2, 15, 16, 49, 51, 865, DateTimeKind.Local).AddTicks(493), "أمجد حازم", "Bernhard Kuvalis", 0, "أسامة, ربيع and صلاح", "6512795939167532578", "Lao People's Democratic Republic" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 9, 14, 9, 0, 53, 321, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 2, 15, 8, 57, 32, 830, DateTimeKind.Local).AddTicks(7976), "أمجد عراقی", "Jaclyn Senger", 0, "فريد, فريد and ربيع", "6692947428568649230", "Eritrea", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2002, 9, 27, 6, 51, 26, 743, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 2, 15, 12, 36, 28, 0, DateTimeKind.Local).AddTicks(447), "جابر‌ عراقی", "Maria Crooks", "حازم - ربيع", "3171623894515314194", "Turkmenistan", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 3, 26, 0, 12, 52, 368, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 2, 15, 15, 57, 53, 504, DateTimeKind.Local).AddTicks(9271), "آية أسامة", "Riley Mosciski", 0, "آدم - آدم", "4467319538839834159", "United States of America" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1972, 2, 7, 23, 30, 53, 623, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 2, 15, 9, 7, 19, 81, DateTimeKind.Local).AddTicks(4752), "حازم حازم", "Marcella Jenkins", "عقیل Inc", "8554148651165728249", "Philippines", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 2, 11, 15, 53, 47, 597, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 2, 14, 23, 12, 35, 521, DateTimeKind.Local).AddTicks(7468), "أروى جابر‌", "Angelina Marquardt", 1, "إيهاب, بلال and عراقی", "3324718086083371753", "Cayman Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 2, 13, 1, 49, 15, 939, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 2, 15, 10, 5, 46, 606, DateTimeKind.Local).AddTicks(1242), "منى طارق", "Herta MacGyver", 1, "جابر‌, سالم and عاشور", "3571891680988562668", "Micronesia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 21, 19, 47, 47, 928, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 2, 15, 16, 22, 3, 813, DateTimeKind.Local).AddTicks(2106), "بلال بلال", "Eleazar Goldner", 1, "معروف, هاشم and فاروق", "2288922637301816723", "Madagascar", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 4, 20, 23, 48, 56, 535, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 2, 15, 7, 6, 47, 178, DateTimeKind.Local).AddTicks(3235), "أسامة بلال", "Alexandro Lehner", 1, "فاروق, عاشور and جابر‌", "8703697668102140814", "Barbados" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 2, 0, 28, 27, 91, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 2, 15, 7, 7, 52, 92, DateTimeKind.Local).AddTicks(4476), "آية بلال", "Kale Kuhlman", 1, "عزیز - حسن", "1175535084747748047", "Jordan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 23, 0, 4, 30, 821, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 2, 15, 18, 36, 27, 689, DateTimeKind.Local).AddTicks(5974), "عبير ربيع", "Hans Konopelski", "ربيع - عراقی", "6981887822524785077", "United States Minor Outlying Islands", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 30, 21, 50, 16, 463, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 2, 15, 1, 0, 19, 355, DateTimeKind.Local).AddTicks(7323), "جابر‌ عقیل", "Lorenz Howell", "عراقی - أسامة", "819892854727722667", "Comoros", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 11, 18, 18, 40, 5, 235, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 2, 15, 5, 39, 55, 818, DateTimeKind.Local).AddTicks(6469), "إيهاب فاروق", "Kacey Harvey", 1, "عراقی, سالم and آدم", "2758998411362234421", "Turkey", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 5, 23, 0, 30, 32, 363, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 2, 15, 8, 25, 38, 549, DateTimeKind.Local).AddTicks(6852), "زيد إيهاب", "Anastasia Mertz", 1, "فؤاد - هاشم", "7468974200686696196", "Costa Rica", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 7, 23, 1, 38, 14, 592, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 2, 14, 23, 58, 24, 543, DateTimeKind.Local).AddTicks(3125), "فاروق ربيع", "Jaleel Wiza", 1, "صلاح - سعيد", "7921392415828132890", "Falkland Islands (Malvinas)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 1, 23, 6, 22, 9, 168, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 2, 15, 7, 14, 18, 761, DateTimeKind.Local).AddTicks(7373), "بلال فاروق", "Alda Cole", 0, "عاشور - فاروق", "2943488157441178275", "Belize" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1963, 12, 17, 11, 2, 32, 227, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 2, 15, 1, 11, 23, 619, DateTimeKind.Local).AddTicks(1152), "لمى صلاح", "Jaunita Walsh", 0, "صلاح LLC", "358396861298442165", "Cocos (Keeling) Islands", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalFileId",
                table: "Patients",
                column: "MedicalFileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalFiles_MedicalFileId",
                table: "Patients",
                column: "MedicalFileId",
                principalTable: "MedicalFiles",
                principalColumn: "Id");
        }
    }
}
