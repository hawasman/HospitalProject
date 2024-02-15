using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPatientModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalFiles_Patients_PatientId",
                table: "MedicalFiles");

            migrationBuilder.DropIndex(
                name: "IX_MedicalFiles_PatientId",
                table: "MedicalFiles");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalFiles");

            migrationBuilder.AddColumn<int>(
                name: "MedicalFileId",
                table: "Patients",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Patients",
                type: "integer",
                nullable: true);

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1981, 3, 20, 20, 47, 23, 328, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 2, 15, 8, 22, 11, 782, DateTimeKind.Local).AddTicks(5430), "عبير عقیل", "Jazlyn Yundt", 1, "عارف, أمجد and فاروق", null, "1187234157082395656", "Italy", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1984, 3, 29, 2, 36, 32, 981, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 2, 15, 4, 27, 43, 674, DateTimeKind.Local).AddTicks(7801), "إيناس سالم", "Gail Huels", 1, "حازم - فريد", null, "2024666291369628006", "Swaziland", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1992, 6, 30, 11, 36, 56, 487, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 2, 15, 13, 20, 50, 701, DateTimeKind.Local).AddTicks(1116), "شيماء عصار", "Alexanne Bergstrom", 1, "زيد and Sons", null, "1160134445214752423", "Costa Rica", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1970, 10, 20, 18, 8, 48, 250, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 2, 15, 16, 7, 12, 77, DateTimeKind.Local).AddTicks(1025), "فريد سالم", "Jimmy Cassin", 0, "آدم - عراقی", null, "5440840086626692363", "American Samoa", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1991, 6, 13, 10, 4, 22, 760, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 2, 15, 16, 10, 49, 908, DateTimeKind.Local).AddTicks(2163), "لمى فؤاد", "Hailee Labadie", "صلاح - عارف", null, "4510718992178274228", "Greenland", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 10, 3, 20, 29, 527, DateTimeKind.Local).AddTicks(5208), new DateTime(2024, 2, 15, 7, 2, 35, 911, DateTimeKind.Local).AddTicks(2153), "لمى بلال", "Rocky Bode", 0, "طارق, صلاح and هاشم", null, "3192011671375967489", "Guinea", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1969, 5, 11, 14, 40, 17, 951, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 2, 15, 2, 21, 44, 767, DateTimeKind.Local).AddTicks(7397), "دانا عقیل", "Collin Lowe", 1, "حسن LLC", null, "7326938378901042202", "Cayman Islands", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1968, 10, 27, 15, 53, 18, 390, DateTimeKind.Local).AddTicks(3223), new DateTime(2024, 2, 15, 2, 31, 19, 654, DateTimeKind.Local).AddTicks(5307), "فاروق معروف", "Jordyn Bradtke", 0, "بلال, بلال and أسامة", null, "3104597260472767495", "Antigua and Barbuda", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1979, 3, 3, 17, 37, 11, 306, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 2, 15, 22, 22, 21, 182, DateTimeKind.Local).AddTicks(4523), "سارة أسامة", "Kailee Mills", "معروف - عصار", null, "6549955115543605228", "Costa Rica", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1991, 6, 10, 19, 0, 33, 62, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 2, 15, 21, 2, 27, 534, DateTimeKind.Local).AddTicks(4246), "بلال عزیز", "Asa Yundt", "زيد, آدم and هاشم", null, "4235976280217721916", "Afghanistan", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 4, 16, 10, 45, 52, 365, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 2, 15, 7, 29, 19, 506, DateTimeKind.Local).AddTicks(5685), "فريد طارق", "Aryanna Reichel", 0, "سالم, أسامة and حسن", null, "153908518152086614", "Egypt", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1962, 3, 8, 0, 41, 46, 845, DateTimeKind.Local).AddTicks(3473), new DateTime(2024, 2, 15, 19, 36, 9, 853, DateTimeKind.Local).AddTicks(8759), "طارق فريد", "Annabelle Hoppe", "معروف - أسامة", null, "6048316030799028641", "Guinea-Bissau", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1954, 12, 30, 3, 32, 25, 735, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 2, 15, 5, 27, 55, 544, DateTimeKind.Local).AddTicks(5625), "رقية أمجد", "Shanel Gerlach", 0, "ربيع Inc", null, "7237975526683662453", "Timor-Leste", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1967, 6, 29, 15, 8, 38, 61, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 2, 15, 12, 0, 53, 521, DateTimeKind.Local).AddTicks(1785), "جمانة حازم", "Corene Wintheiser", 1, "عصار, بلال and عصار", null, "151930220794280244", "Finland", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1975, 9, 20, 21, 42, 48, 241, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 2, 15, 15, 9, 49, 386, DateTimeKind.Local).AddTicks(8676), "فاطمة عقیل", "Edison Kovacek", "حازم - عارف", null, "7227741643544068996", "Uganda", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1987, 10, 6, 4, 58, 7, 774, DateTimeKind.Local).AddTicks(1526), new DateTime(2024, 2, 14, 23, 16, 32, 202, DateTimeKind.Local).AddTicks(4979), "عبير عزیز", "Danny Kris", "أمجد - آدم", null, "3199836908489060833", "Greenland", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1979, 5, 6, 13, 28, 38, 665, DateTimeKind.Local).AddTicks(6023), new DateTime(2024, 2, 15, 20, 17, 21, 556, DateTimeKind.Local).AddTicks(6569), "إيهاب عقیل", "Devante Parker", "أمجد Group", null, "2690296531855950853", "British Indian Ocean Territory (Chagos Archipelago)", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1992, 12, 4, 7, 29, 54, 231, DateTimeKind.Local).AddTicks(4438), new DateTime(2024, 2, 15, 2, 37, 40, 538, DateTimeKind.Local).AddTicks(9906), "حازم سعيد", "Maverick Christiansen", "صلاح and Sons", null, "4354905734252268180", "Cyprus", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 2, 13, 22, 40, 29, 97, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 2, 15, 8, 19, 13, 229, DateTimeKind.Local).AddTicks(5554), "دانا عراقی", "Duane Frami", 0, "عقیل - صلاح", null, "2133718339516885127", "Indonesia", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1986, 3, 31, 10, 38, 48, 271, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 2, 15, 4, 34, 37, 166, DateTimeKind.Local).AddTicks(706), "سالم جابر‌", "Alan Bashirian", 0, "فؤاد and Sons", null, "3871937940458126072", "Saint Lucia", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 3, 31, 14, 21, 29, 922, DateTimeKind.Local).AddTicks(5902), new DateTime(2024, 2, 15, 20, 25, 42, 717, DateTimeKind.Local).AddTicks(6444), "دانا عارف", "Marlen Barton", "عزیز LLC", null, "4918941298827625102", "Turkmenistan", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1987, 9, 8, 17, 25, 32, 824, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 2, 15, 19, 19, 28, 259, DateTimeKind.Local).AddTicks(6579), "أروى حسن", "Larue Rowe", 0, "أسامة Group", null, "473175284770448055", "Guernsey", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1986, 6, 25, 17, 5, 51, 272, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 2, 15, 12, 4, 30, 545, DateTimeKind.Local).AddTicks(5313), "فريدة إيهاب", "Eliane Wisozk", 1, "عراقی - عاشور", null, "7263512757596294826", "Cuba", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1955, 10, 25, 10, 48, 13, 767, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 2, 15, 5, 37, 40, 513, DateTimeKind.Local).AddTicks(2656), "آدم عاشور", "Fannie Collins", 0, "عزیز - إيهاب", null, "7474449702227354998", "Switzerland", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 3, 3, 1, 15, 49, 161, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 2, 15, 15, 27, 21, 593, DateTimeKind.Local).AddTicks(2805), "عبير هاشم", "Saige Christiansen", 0, "سعيد LLC", null, "6830180646304033608", "France", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1955, 7, 15, 12, 4, 58, 124, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 2, 15, 9, 50, 30, 190, DateTimeKind.Local).AddTicks(2700), "لمى ربيع", "Augustus Morar", "سعيد, أمجد and سالم", null, "2450606289081857494", "Thailand", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 3, 15, 30, 5, 823, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 2, 15, 1, 11, 48, 611, DateTimeKind.Local).AddTicks(2747), "أروى إيهاب", "Kameron Waelchi", 1, "طارق - فؤاد", null, "7515802633568672186", "Iceland", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 6, 8, 7, 26, 38, 945, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 2, 15, 4, 34, 37, 675, DateTimeKind.Local).AddTicks(8726), "فريدة أمجد", "Jeanie Murray", 0, "بلال, أمجد and فؤاد", null, "787039969528939116", "Cameroon", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1991, 4, 5, 16, 8, 46, 921, DateTimeKind.Local), new DateTime(2024, 2, 15, 2, 46, 3, 485, DateTimeKind.Local).AddTicks(7632), "حسن طارق", "Adrienne Bednar", 1, "عقیل, عاشور and عاشور", null, "7005288815815101704", "Kenya", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1994, 5, 1, 15, 3, 22, 639, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 2, 15, 2, 30, 39, 649, DateTimeKind.Local).AddTicks(3303), "حسن طارق", "Riley Stamm", "عارف Inc", null, "4733662791058350440", "Namibia", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1981, 2, 13, 3, 10, 37, 95, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 2, 15, 8, 39, 47, 860, DateTimeKind.Local).AddTicks(9550), "سعيد عراقی", "Teagan Hoppe", 0, "عقیل, عارف and حازم", null, "4612959029149222123", "China", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1991, 12, 6, 23, 40, 19, 328, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 2, 15, 15, 29, 8, 658, DateTimeKind.Local).AddTicks(4612), "زيد زيد", "Kip King", "سالم, عارف and آدم", null, "8446534315785635723", "Kyrgyz Republic", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1977, 7, 7, 10, 24, 15, 217, DateTimeKind.Local).AddTicks(2683), new DateTime(2024, 2, 15, 2, 4, 25, 444, DateTimeKind.Local).AddTicks(7518), "أسامة بلال", "Gerry Lemke", "زيد Group", null, "7928337873004866852", "Honduras", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1976, 11, 20, 6, 16, 51, 74, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 2, 15, 11, 18, 30, 151, DateTimeKind.Local).AddTicks(7233), "حسن عصار", "Darlene Bradtke", 0, "جابر‌ Inc", null, "4839797684039279682", "Cocos (Keeling) Islands", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1986, 4, 5, 17, 8, 31, 851, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 2, 15, 22, 5, 51, 306, DateTimeKind.Local).AddTicks(9131), "زيد طارق", "Juliana Halvorson", "أسامة - ربيع", null, "669055243041595487", "Liechtenstein", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1969, 6, 5, 13, 11, 37, 914, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 2, 15, 10, 38, 35, 511, DateTimeKind.Local).AddTicks(6142), "ريم إيهاب", "Elena Fisher", "صلاح Inc", null, "8741219105369288418", "Greenland", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1958, 12, 1, 18, 0, 4, 392, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 2, 15, 18, 12, 30, 125, DateTimeKind.Local).AddTicks(738), "طارق هاشم", "Nikolas Kemmer", 0, "عارف - عراقی", null, "91442779297996764", "Bolivia", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1985, 11, 8, 4, 12, 3, 27, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 2, 15, 8, 20, 57, 90, DateTimeKind.Local).AddTicks(2419), "شيماء عزیز", "Alivia O'Kon", 0, "سعيد - سالم", null, "3655633916647497294", "Cook Islands", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1972, 1, 11, 1, 14, 24, 212, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 2, 15, 14, 49, 30, 42, DateTimeKind.Local).AddTicks(1593), "فريد طارق", "Chet Gorczany", 1, "عصار - طارق", null, "570345191999806178", "Dominican Republic", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 18, 3, 54, 57, 980, DateTimeKind.Local).AddTicks(886), new DateTime(2024, 2, 15, 13, 50, 54, 53, DateTimeKind.Local).AddTicks(2236), "أسامة أسامة", "Alden Gorczany", "هاشم - سالم", null, "7409416052902295470", "Maldives", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1997, 6, 18, 0, 26, 56, 247, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 2, 15, 6, 28, 14, 249, DateTimeKind.Local).AddTicks(2849), "إيهاب هاشم", "Greyson Schroeder", "زيد, معروف and عزیز", null, "7810855881313392937", "Northern Mariana Islands", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 20, 9, 31, 30, 159, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 2, 15, 20, 58, 36, 923, DateTimeKind.Local).AddTicks(8336), "فاروق هاشم", "Myra Kub", "صلاح, فاروق and عزیز", null, "1021967574852893960", "Cuba", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1975, 9, 7, 18, 28, 50, 956, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 15, 1, 31, 49, 335, DateTimeKind.Local).AddTicks(2247), "آية عقیل", "Arno Bailey", 1, "طارق, بلال and إيهاب", null, "440548639607851369", "Tanzania", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(2000, 8, 25, 18, 16, 25, 887, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 2, 15, 2, 14, 18, 350, DateTimeKind.Local).AddTicks(3745), "فريد سعيد", "Heather Feeney", 1, "حازم LLC", null, "6269584762219650671", "Lithuania", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(2003, 2, 22, 6, 2, 0, 103, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 2, 15, 22, 18, 10, 645, DateTimeKind.Local).AddTicks(123), "إيهاب عصار", "Jane Schultz", "عقیل - أسامة", null, "218984590437428133", "Togo", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1961, 5, 19, 7, 29, 53, 290, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 2, 15, 2, 3, 34, 106, DateTimeKind.Local).AddTicks(3359), "ريم عراقی", "Jose Macejkovic", "طارق - فريد", null, "6806163817250540693", "Monaco", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1954, 10, 15, 21, 44, 38, 449, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 2, 14, 23, 28, 31, 824, DateTimeKind.Local).AddTicks(9939), "سالم سالم", "Hilma Stokes", "هاشم, طارق and آدم", null, "669826364110048408", "Bahamas", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1969, 3, 7, 5, 12, 58, 256, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 15, 17, 58, 53, 319, DateTimeKind.Local).AddTicks(4690), "زيد فريد", "Winifred Mraz", 1, "إيهاب - طارق", null, "4700957060047731119", "Maldives", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1956, 10, 8, 11, 58, 1, 467, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 2, 15, 17, 48, 57, 353, DateTimeKind.Local).AddTicks(7145), "ريم سعيد", "Laura Crist", "أمجد, حسن and هاشم", null, "1885363441331786679", "Pitcairn Islands", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1984, 1, 23, 0, 26, 7, 621, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 2, 15, 13, 58, 5, 200, DateTimeKind.Local).AddTicks(706), "فاطمة سالم", "Giovanna Klein", "عارف Group", null, "6068189267447305210", "Cocos (Keeling) Islands", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 12, 2, 22, 21, 33, 471, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 2, 15, 3, 30, 30, 550, DateTimeKind.Local).AddTicks(4019), "هاجر عزیز", "Adrain Cremin", 1, "بلال - صلاح", null, "6485319277387408457", "Lithuania", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1970, 5, 18, 15, 36, 54, 557, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 2, 15, 14, 42, 4, 383, DateTimeKind.Local).AddTicks(8845), "فريدة معروف", "Orval Lebsack", 0, "معروف Group", null, "3409688880291452626", "Norway", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 11, 13, 12, 30, 10, 246, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 2, 15, 19, 1, 18, 204, DateTimeKind.Local).AddTicks(4468), "هاجر إيهاب", "Eliseo Pfannerstill", 0, "حسن LLC", null, "1499215009851469349", "Bhutan", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1982, 4, 28, 14, 43, 58, 186, DateTimeKind.Local).AddTicks(8461), new DateTime(2024, 2, 15, 11, 11, 53, 897, DateTimeKind.Local).AddTicks(1628), "إيناس فريد", "Johnny Runte", 1, "عاشور - طارق", null, "3348188796376290135", "Montenegro", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1956, 7, 15, 18, 8, 32, 163, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 2, 15, 8, 12, 34, 227, DateTimeKind.Local).AddTicks(4282), "إيناس فريد", "Carmine Schroeder", 1, "فاروق Inc", null, "7051719713393600185", "Austria", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2003, 5, 15, 5, 3, 12, 969, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 2, 15, 17, 6, 47, 530, DateTimeKind.Local).AddTicks(9918), "جابر‌ فؤاد", "Elmo Stark", 0, "فؤاد LLC", null, "427569237760968293", "Qatar", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1993, 3, 6, 7, 1, 47, 233, DateTimeKind.Local).AddTicks(3019), new DateTime(2024, 2, 15, 22, 29, 38, 68, DateTimeKind.Local).AddTicks(948), "جابر‌ أسامة", "Velva Towne", 0, "بلال Group", null, "3908870343357305243", "Germany", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 14, 6, 33, 39, 382, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 2, 15, 21, 7, 15, 910, DateTimeKind.Local).AddTicks(5641), "منى جابر‌", "Forest Conroy", "حسن - طارق", null, "764390056859179802", "Ethiopia", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1996, 5, 12, 7, 42, 51, 455, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 2, 15, 13, 7, 27, 361, DateTimeKind.Local).AddTicks(1258), "رنا آدم", "Asia Reichert", 1, "حسن - طارق", null, "4646914493930807592", "Greece", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1986, 6, 29, 23, 8, 42, 625, DateTimeKind.Local).AddTicks(3801), new DateTime(2024, 2, 15, 0, 11, 10, 412, DateTimeKind.Local).AddTicks(1274), "طارق زيد", "Kaylie Hirthe", "إيهاب LLC", null, "3815593430075246586", "Holy See (Vatican City State)", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1983, 1, 20, 16, 42, 29, 690, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 15, 18, 48, 25, 565, DateTimeKind.Local).AddTicks(5996), "جابر‌ هاشم", "Haylee Kuvalis", "سالم, جابر‌ and عزیز", null, "6394005353289646471", "Indonesia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1993, 6, 24, 16, 26, 9, 859, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 2, 15, 9, 21, 36, 768, DateTimeKind.Local).AddTicks(2589), "بلال فؤاد", "Karelle Breitenberg", "فاروق and Sons", null, "737728664949193132", "Colombia", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 13, 10, 56, 15, 4, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 2, 15, 11, 55, 23, 801, DateTimeKind.Local).AddTicks(3807), "ربيع بلال", "Melvina Russel", "عزیز, زيد and عقیل", null, "368059399141732701", "Syrian Arab Republic", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1955, 9, 28, 16, 55, 26, 828, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 2, 15, 11, 43, 36, 554, DateTimeKind.Local).AddTicks(8024), "آدم هاشم", "Derrick Larson", 1, "جابر‌ and Sons", null, "1072349061637574156", "Saudi Arabia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1997, 4, 13, 20, 36, 20, 263, DateTimeKind.Local).AddTicks(1112), new DateTime(2024, 2, 15, 3, 18, 10, 157, DateTimeKind.Local).AddTicks(2852), "دانا فريد", "Kaitlyn Bruen", "أمجد LLC", null, "893074649797275354", "Albania", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1984, 1, 30, 11, 59, 59, 58, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 2, 15, 4, 37, 15, 310, DateTimeKind.Local).AddTicks(3605), "أسامة عاشور", "Elias Kautzer", 0, "عراقی Group", null, "4529356362085647439", "Cameroon", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 2, 22, 22, 56, 12, 663, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 2, 15, 9, 49, 5, 18, DateTimeKind.Local).AddTicks(9701), "فؤاد جابر‌", "Quinton Dibbert", 0, "عقیل - فاروق", null, "1063240222529633669", "Gibraltar", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1980, 12, 20, 8, 51, 38, 350, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 2, 15, 14, 37, 21, 10, DateTimeKind.Local).AddTicks(4550), "لمى آدم", "Madison Huel", "أمجد, طارق and عقیل", null, "6761854847374147752", "Sri Lanka", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1961, 5, 10, 23, 27, 37, 315, DateTimeKind.Local).AddTicks(3369), new DateTime(2024, 2, 15, 4, 48, 24, 743, DateTimeKind.Local).AddTicks(4968), "رقية حسن", "Eugene Jacobi", "عراقی - عزیز", null, "4329987498849478297", "Pakistan", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 13, 22, 36, 35, 669, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 2, 15, 6, 26, 18, 870, DateTimeKind.Local).AddTicks(419), "دانا بلال", "Royce Howe", 1, "أمجد Group", null, "2463956312505817675", "Seychelles", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2000, 6, 26, 18, 8, 43, 78, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 2, 15, 4, 13, 37, 192, DateTimeKind.Local).AddTicks(9232), "فاطمة بلال", "Aileen Hayes", 0, "حازم, سعيد and فؤاد", null, "484517004165736764", "Morocco", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1972, 3, 25, 14, 59, 53, 811, DateTimeKind.Local).AddTicks(8704), new DateTime(2024, 2, 15, 9, 30, 16, 273, DateTimeKind.Local).AddTicks(4669), "فاطمة جابر‌", "Christ Wolf", "آدم - أمجد", null, "973041153499546952", "Iran", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1980, 1, 22, 14, 13, 53, 614, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 2, 15, 9, 7, 48, 176, DateTimeKind.Local).AddTicks(7607), "لمى إيهاب", "Judd Becker", 0, "فؤاد, عزیز and أسامة", null, "8984622568367226905", "Trinidad and Tobago", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1979, 8, 11, 7, 27, 4, 767, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 2, 15, 2, 21, 53, 882, DateTimeKind.Local).AddTicks(4189), "بلال ربيع", "Ena Franecki", 0, "عزیز LLC", null, "1809156637591717010", "Croatia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1985, 3, 26, 5, 2, 27, 399, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 2, 15, 5, 54, 37, 695, DateTimeKind.Local).AddTicks(8236), "رنا بلال", "Lucinda Trantow", 1, "زيد Inc", null, "1572568887973101047", "Kiribati", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2002, 2, 10, 20, 58, 8, 997, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 2, 15, 17, 12, 28, 655, DateTimeKind.Local).AddTicks(3096), "رقية فؤاد", "Hanna Cassin", "ربيع - ربيع", null, "5581795473608619138", "Burundi", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2001, 9, 12, 1, 43, 51, 119, DateTimeKind.Local).AddTicks(169), new DateTime(2024, 2, 15, 2, 18, 38, 289, DateTimeKind.Local).AddTicks(713), "سالم أسامة", "Leopoldo Koepp", "عارف, عراقی and عارف", null, "3146126397142646274", "Morocco", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1984, 11, 5, 0, 1, 14, 649, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 2, 15, 16, 14, 36, 431, DateTimeKind.Local).AddTicks(9717), "طارق آدم", "Eveline Moore", "عقیل and Sons", null, "1947646479103317088", "Palau", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1964, 11, 13, 18, 39, 11, 334, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 2, 15, 17, 26, 6, 987, DateTimeKind.Local).AddTicks(4578), "صلاح عزیز", "Pearline Altenwerth", 1, "جابر‌ - عراقی", null, "1837689906817548234", "United States Minor Outlying Islands", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 5, 25, 19, 49, 38, 47, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 2, 15, 13, 28, 52, 411, DateTimeKind.Local).AddTicks(2067), "فريدة زيد", "Verner Nader", 0, "حسن Inc", null, "6315101761726529813", "Bouvet Island (Bouvetoya)", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 2, 4, 22, 45, 36, 364, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 2, 15, 6, 31, 33, 237, DateTimeKind.Local).AddTicks(9684), "صلاح عراقی", "Devan Steuber", "فاروق, عارف and طارق", null, "9060460808709822528", "Estonia", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1954, 6, 28, 0, 22, 9, 966, DateTimeKind.Local).AddTicks(7677), new DateTime(2024, 2, 15, 7, 26, 15, 46, DateTimeKind.Local).AddTicks(4963), "شيماء عراقی", "Treva Abernathy", "معروف - حسن", null, "4157029840731294514", "Guinea", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 4, 17, 19, 57, 3, 891, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 2, 15, 1, 10, 8, 142, DateTimeKind.Local).AddTicks(2551), "فاروق عاشور", "Timothy Blanda", "أسامة - أمجد", null, "6859667578873602343", "Jersey", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1979, 3, 27, 7, 14, 0, 381, DateTimeKind.Local).AddTicks(402), new DateTime(2024, 2, 15, 0, 25, 12, 379, DateTimeKind.Local).AddTicks(5831), "ربيع معروف", "Monserrate Fritsch", "سعيد, عصار and بلال", null, "4475364623048929505", "France", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1995, 6, 23, 16, 57, 1, 451, DateTimeKind.Local).AddTicks(3099), new DateTime(2024, 2, 15, 9, 19, 4, 637, DateTimeKind.Local).AddTicks(9997), "ريم إيهاب", "Tierra Leuschke", 1, "فؤاد LLC", null, "4574674786063078563", "Central African Republic", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1998, 9, 26, 20, 23, 14, 760, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 2, 15, 15, 16, 12, 498, DateTimeKind.Local).AddTicks(5814), "سارة جابر‌", "Modesto Purdy", "عقیل Inc", null, "494489947612238263", "Honduras", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1961, 11, 21, 11, 56, 37, 817, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 2, 15, 17, 59, 17, 845, DateTimeKind.Local).AddTicks(6451), "زيد ربيع", "Imelda Schumm", "جابر‌, عزیز and عصار", null, "5197186892152825091", "Uganda", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1988, 3, 15, 1, 45, 42, 128, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 2, 15, 5, 32, 36, 635, DateTimeKind.Local).AddTicks(6871), "رنا عصار", "Kraig Stark", "أمجد and Sons", null, "2223358222844631716", "Mauritania", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 1, 18, 16, 52, 709, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 2, 15, 8, 10, 41, 364, DateTimeKind.Local).AddTicks(3064), "حسن آدم", "Elouise Veum", 1, "فؤاد, هاشم and عصار", null, "8697781957799590437", "Sri Lanka", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1985, 5, 14, 18, 28, 25, 520, DateTimeKind.Local).AddTicks(7312), new DateTime(2024, 2, 15, 12, 26, 41, 198, DateTimeKind.Local).AddTicks(1756), "طارق عقیل", "Toby Feest", 1, "إيهاب, صلاح and فريد", null, "5344637697599783723", "Taiwan", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 8, 4, 16, 44, 526, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 2, 15, 20, 15, 26, 835, DateTimeKind.Local).AddTicks(2417), "سالم حازم", "Roosevelt Price", 1, "أمجد Group", null, "5339194641348493192", "Tajikistan", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1987, 4, 17, 16, 51, 47, 453, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 2, 14, 23, 14, 49, 862, DateTimeKind.Local).AddTicks(2322), "طارق عزیز", "Margot Zemlak", 1, "طارق, جابر‌ and عقیل", null, "5322903680229794505", "Ukraine", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1959, 11, 5, 9, 41, 38, 561, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 2, 15, 1, 20, 4, 414, DateTimeKind.Local).AddTicks(5941), "عبير بلال", "Carole Mann", "معروف - عاشور", null, "7739825505686720205", "Reunion", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 10, 17, 23, 2, 36, 317, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 2, 15, 6, 31, 7, 692, DateTimeKind.Local).AddTicks(9433), "شيماء معروف", "Citlalli Beatty", 1, "حسن, عزیز and طارق", null, "1903924555055702459", "Bosnia and Herzegovina", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1978, 12, 16, 0, 4, 49, 231, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 2, 15, 12, 47, 53, 619, DateTimeKind.Local).AddTicks(4185), "إيناس عاشور", "William Pagac", 0, "فاروق, فريد and جابر‌", null, "5977331195573521873", "Central African Republic", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1959, 6, 23, 14, 24, 12, 608, DateTimeKind.Local).AddTicks(2342), new DateTime(2024, 2, 15, 22, 31, 7, 621, DateTimeKind.Local).AddTicks(5896), "سارة عزیز", "Blaze Lemke", 0, "حازم - عارف", null, "2136342164699782954", "Grenada", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1966, 10, 10, 19, 10, 31, 426, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 2, 15, 0, 14, 34, 308, DateTimeKind.Local).AddTicks(1264), "زيد فاروق", "Dangelo McLaughlin", 0, "بلال LLC", null, "9072167543605384357", "Poland", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1998, 10, 8, 6, 12, 3, 10, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 2, 15, 12, 20, 47, 872, DateTimeKind.Local).AddTicks(6109), "رنا بلال", "Abner Gleason", "بلال and Sons", null, "2228034694052752071", "Tokelau", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2000, 8, 24, 9, 26, 3, 728, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 2, 15, 8, 32, 4, 436, DateTimeKind.Local).AddTicks(6530), "ربيع حسن", "Meredith DuBuque", "عارف, بلال and سالم", null, "5077122283792560618", "Vanuatu", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1974, 7, 15, 9, 8, 9, 794, DateTimeKind.Local).AddTicks(1564), new DateTime(2024, 2, 15, 10, 38, 48, 560, DateTimeKind.Local).AddTicks(4448), "حازم أمجد", "Zachary Rolfson", 0, "أسامة, طارق and معروف", null, "4063605657143528980", "Micronesia", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1967, 2, 15, 18, 12, 40, 315, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 2, 15, 21, 33, 31, 207, DateTimeKind.Local).AddTicks(9112), "أسامة عزیز", "Zion Murazik", "حازم - فؤاد", null, "4102216804923976441", "Monaco", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1954, 5, 28, 11, 45, 15, 261, DateTimeKind.Local).AddTicks(3271), new DateTime(2024, 2, 15, 6, 48, 26, 746, DateTimeKind.Local).AddTicks(4035), "أمجد فريد", "Adolphus Zboncak", "عصار and Sons", null, "2268077673901098063", "Taiwan", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(2002, 9, 9, 13, 30, 12, 574, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 15, 17, 10, 24, 868, DateTimeKind.Local).AddTicks(3989), "سالم طارق", "Madilyn Renner", "ربيع Inc", null, "647633879945407341", "Croatia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2001, 10, 8, 23, 0, 48, 397, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 2, 15, 1, 56, 42, 434, DateTimeKind.Local).AddTicks(6350), "منى حازم", "Brook Larkin", "عقیل - ربيع", null, "2571467102379685438", "Ghana", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1976, 2, 14, 1, 24, 35, 819, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 2, 15, 12, 51, 57, 701, DateTimeKind.Local).AddTicks(9080), "ربيع بلال", "Jordyn Osinski", "معروف - سعيد", null, "6879602506960539900", "Botswana", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 6, 10, 10, 11, 27, DateTimeKind.Local).AddTicks(3786), new DateTime(2024, 2, 15, 5, 8, 55, 788, DateTimeKind.Local).AddTicks(5644), "جمانة زيد", "Sabryna White", "صلاح, حازم and فاروق", null, "5769380312091553601", "American Samoa", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1998, 9, 25, 1, 3, 36, 162, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 2, 15, 15, 46, 54, 616, DateTimeKind.Local).AddTicks(9132), "فاروق آدم", "Schuyler Pollich", "فاروق, آدم and فؤاد", null, "8141622552241544624", "Bangladesh", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1955, 1, 12, 0, 42, 23, 603, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 2, 14, 23, 51, 17, 463, DateTimeKind.Local).AddTicks(1805), "آية جابر‌", "Marlon Stanton", "عصار, فؤاد and حازم", null, "7937335783877629312", "Morocco", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1979, 1, 20, 10, 4, 36, 803, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 2, 15, 10, 49, 25, 62, DateTimeKind.Local).AddTicks(4336), "منى عزیز", "Aurore Lehner", 1, "جابر‌ Group", null, "2969673887874751611", "Saint Kitts and Nevis", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1989, 9, 11, 1, 36, 43, 257, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 2, 15, 1, 14, 52, 512, DateTimeKind.Local).AddTicks(5700), "زينب صلاح", "Hillary Abbott", 1, "عاشور, عقیل and معروف", null, "5196034107828094631", "Solomon Islands", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1984, 9, 27, 20, 18, 56, 84, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 2, 15, 8, 54, 11, 252, DateTimeKind.Local).AddTicks(3805), "هاجر عاشور", "Krista Murphy", "عزیز - معروف", null, "5668575868987754879", "Isle of Man", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1961, 10, 16, 1, 28, 32, 725, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 2, 15, 3, 41, 42, 772, DateTimeKind.Local).AddTicks(810), "رقية آدم", "Brock Purdy", 1, "ربيع LLC", null, "8022040424151219837", "Central African Republic", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1975, 6, 9, 10, 13, 24, 325, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 2, 15, 19, 41, 39, 790, DateTimeKind.Local).AddTicks(1146), "لمى معروف", "Agustina Barton", "فريد and Sons", null, "5529543311033555284", "Sweden", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1961, 4, 17, 0, 10, 20, 551, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 2, 15, 17, 10, 16, 754, DateTimeKind.Local).AddTicks(1725), "أسامة عراقی", "Kaylee Gorczany", "حسن LLC", null, "1046068351760486215", "Timor-Leste", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2003, 6, 13, 2, 20, 58, 882, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 2, 15, 2, 9, 15, 929, DateTimeKind.Local).AddTicks(2593), "رنا طارق", "Gabriella Lubowitz", "إيهاب - عصار", null, "8350657405756514941", "Iraq", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1969, 6, 14, 0, 41, 20, 598, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 2, 15, 15, 46, 35, 851, DateTimeKind.Local).AddTicks(5318), "آية سالم", "Daisy Wyman", "بلال, جابر‌ and أسامة", null, "2119999664457498212", "Bulgaria", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 17, 17, 0, 34, 752, DateTimeKind.Local).AddTicks(8944), new DateTime(2024, 2, 15, 21, 16, 28, 78, DateTimeKind.Local).AddTicks(3809), "بلال سالم", "Mortimer Ryan", "ربيع LLC", null, "6460188687659555572", "Togo", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1959, 12, 11, 10, 19, 5, 373, DateTimeKind.Local).AddTicks(2410), new DateTime(2024, 2, 15, 16, 27, 4, 80, DateTimeKind.Local).AddTicks(282), "منى طارق", "Hassan Brown", "عقیل Inc", null, "5848476212160889184", "Sweden", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 14, 1, 16, 21, 718, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 2, 15, 21, 0, 16, 731, DateTimeKind.Local).AddTicks(8983), "أمجد حسن", "Hilma Walsh", "إيهاب - عاشور", null, "6348830507998848242", "Saint Lucia", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1992, 7, 30, 0, 43, 52, 317, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 2, 15, 21, 49, 25, 514, DateTimeKind.Local).AddTicks(6497), "فاروق معروف", "Jayda Strosin", "عارف Inc", null, "7451353591614788604", "Samoa", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1993, 3, 20, 8, 51, 19, 739, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 2, 15, 14, 14, 32, 605, DateTimeKind.Local).AddTicks(224), "فريدة طارق", "Manuel Terry", "صلاح - أمجد", null, "5461017462434904445", "Uzbekistan", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1958, 10, 31, 19, 4, 53, 622, DateTimeKind.Local).AddTicks(3855), new DateTime(2024, 2, 15, 11, 33, 19, 598, DateTimeKind.Local).AddTicks(1932), "بلال إيهاب", "Aileen Hilll", "أسامة, ربيع and سعيد", null, "6992038928632375122", "Liberia", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1958, 6, 23, 15, 55, 15, 424, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 15, 8, 42, 38, 793, DateTimeKind.Local).AddTicks(8135), "حازم إيهاب", "Bria Trantow", "طارق - معروف", null, "1827151763358060971", "Portugal", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1957, 2, 2, 0, 50, 22, 556, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 2, 15, 3, 8, 4, 376, DateTimeKind.Local).AddTicks(9985), "فريد أسامة", "Nathan Schinner", 1, "عقیل, حسن and معروف", null, "541725147033930716", "Greenland", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1993, 11, 2, 2, 5, 33, 103, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 2, 14, 23, 13, 4, 478, DateTimeKind.Local).AddTicks(8160), "فؤاد آدم", "Emmanuelle Weimann", 0, "معروف, فؤاد and جابر‌", null, "8679298349755401676", "Cuba", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1995, 1, 21, 4, 8, 27, 380, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 2, 15, 0, 3, 11, 651, DateTimeKind.Local).AddTicks(7273), "آدم حازم", "Brannon Dibbert", "آدم and Sons", null, "302323298398204739", "Bolivia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1980, 3, 28, 1, 58, 3, 750, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 2, 15, 9, 9, 51, 470, DateTimeKind.Local).AddTicks(6584), "هاجر عزیز", "Claudie Ledner", "فؤاد - جابر‌", null, "2408140807286389536", "Saint Martin", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2001, 2, 19, 5, 34, 57, 212, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 2, 15, 12, 46, 5, 373, DateTimeKind.Local).AddTicks(175), "سارة ربيع", "Ansel Romaguera", 0, "سالم - سعيد", null, "5014603036224860091", "Belarus", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1982, 5, 9, 21, 18, 29, 549, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 2, 15, 7, 25, 14, 202, DateTimeKind.Local).AddTicks(753), "ربيع عقیل", "Buford Champlin", 1, "إيهاب, هاشم and أسامة", null, "2953855335164242908", "Micronesia", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1979, 5, 17, 5, 3, 26, 955, DateTimeKind.Local).AddTicks(202), new DateTime(2024, 2, 15, 11, 9, 54, 18, DateTimeKind.Local).AddTicks(2271), "رقية سالم", "Clifton Klocko", 0, "معروف Inc", null, "8013406249470145623", "Gabon", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1956, 12, 25, 0, 59, 56, 717, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 2, 15, 8, 0, 31, 993, DateTimeKind.Local).AddTicks(92), "زيد سعيد", "Aubrey McKenzie", 0, "جابر‌ Inc", null, "3455245422329593919", "Namibia", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1990, 6, 4, 4, 26, 29, 98, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 2, 15, 0, 45, 7, 36, DateTimeKind.Local).AddTicks(1806), "إيناس آدم", "Lloyd O'Reilly", 1, "عزیز - عاشور", null, "8406588402227997063", "Comoros", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1964, 2, 9, 16, 43, 6, 497, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 2, 15, 22, 40, 20, 908, DateTimeKind.Local).AddTicks(6776), "فاطمة معروف", "Demetris Mosciski", 1, "سعيد, جابر‌ and حازم", null, "41576559263720417", "Democratic People's Republic of Korea", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1972, 2, 3, 7, 35, 27, 560, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 2, 15, 11, 55, 11, 902, DateTimeKind.Local).AddTicks(9629), "ربيع عاشور", "Dino Rutherford", 1, "سعيد - طارق", null, "2694034413149777704", "Central African Republic", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1962, 5, 2, 17, 0, 46, 974, DateTimeKind.Local).AddTicks(4274), new DateTime(2024, 2, 15, 18, 13, 9, 577, DateTimeKind.Local).AddTicks(5613), "أسامة عزیز", "Eve Powlowski", "فؤاد, فريد and عزیز", null, "8997437878876398353", "Eritrea", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2002, 8, 4, 11, 50, 12, 687, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 2, 15, 11, 25, 19, 232, DateTimeKind.Local).AddTicks(2679), "آدم سعيد", "Rhea Rogahn", "سالم - طارق", null, "1863000704980246892", "Ethiopia", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1980, 5, 26, 16, 33, 49, 975, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 2, 15, 6, 40, 45, 987, DateTimeKind.Local).AddTicks(2537), "لمى عارف", "Kane Purdy", 0, "معروف - زيد", null, "4930205601128756381", "Bouvet Island (Bouvetoya)", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 7, 12, 16, 13, 24, 99, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 2, 15, 15, 51, 13, 896, DateTimeKind.Local).AddTicks(2138), "حازم زيد", "Lurline Bruen", "عقیل, فريد and أمجد", null, "8808722042287050860", "Christmas Island", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(2002, 10, 12, 14, 16, 21, 63, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 2, 15, 13, 32, 45, 540, DateTimeKind.Local).AddTicks(6519), "دانا عقیل", "Lucinda Goldner", 1, "حازم and Sons", null, "4174877342752407379", "Lebanon", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1989, 10, 7, 11, 30, 54, 129, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 2, 15, 19, 10, 44, 840, DateTimeKind.Local).AddTicks(1275), "زيد ربيع", "Emiliano Doyle", "أمجد, سعيد and عزیز", null, "2080099250371841712", "Cook Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 3, 0, 27, 5, 71, DateTimeKind.Local).AddTicks(5754), new DateTime(2024, 2, 15, 4, 20, 56, 959, DateTimeKind.Local).AddTicks(1039), "فؤاد آدم", "Javon Thiel", 0, "فريد - جابر‌", null, "6939344348363164457", "Rwanda", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 7, 15, 17, 28, 44, 27, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 2, 15, 22, 18, 43, 80, DateTimeKind.Local).AddTicks(6137), "سالم فؤاد", "Nelson Feil", 1, "عارف and Sons", null, "4785798500373797082", "Canada", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1976, 9, 21, 22, 41, 58, 245, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 2, 15, 7, 51, 20, 328, DateTimeKind.Local).AddTicks(407), "ريم آدم", "Regan Larkin", 0, "بلال LLC", null, "4965308307511637046", "Angola", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1992, 4, 23, 19, 23, 46, 750, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 2, 15, 2, 7, 52, 694, DateTimeKind.Local).AddTicks(7530), "بلال آدم", "Jovani Gutkowski", 1, "حازم LLC", null, "7595387389069513637", "Marshall Islands", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1976, 5, 19, 22, 7, 23, 498, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 2, 15, 12, 51, 52, 91, DateTimeKind.Local).AddTicks(5853), "أسامة هاشم", "Darryl Leuschke", "طارق - عزیز", null, "5650081333929185727", "Benin", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 5, 7, 10, 0, 34, 720, DateTimeKind.Local).AddTicks(5429), new DateTime(2024, 2, 15, 13, 8, 56, 158, DateTimeKind.Local).AddTicks(9606), "شيماء جابر‌", "Luis Hoppe", 1, "عقیل and Sons", null, "6663320313368472427", "Zambia", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1999, 10, 16, 14, 16, 7, 258, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 2, 15, 4, 40, 30, 489, DateTimeKind.Local).AddTicks(1723), "بلال عاشور", "Emmanuelle Feest", 1, "عاشور - أسامة", null, "7672952787042348223", "Hungary", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2001, 8, 12, 20, 10, 33, 442, DateTimeKind.Local).AddTicks(6457), new DateTime(2024, 2, 15, 13, 19, 12, 128, DateTimeKind.Local).AddTicks(7410), "إيناس صلاح", "Ivy Breitenberg", "عارف LLC", null, "683787222473804703", "Australia", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2002, 4, 11, 3, 25, 34, 200, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 2, 15, 6, 17, 53, 925, DateTimeKind.Local).AddTicks(7451), "عبير آدم", "Stevie Dickens", 0, "أسامة, زيد and فؤاد", null, "7835320355507401829", "Guernsey", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1982, 12, 16, 4, 7, 21, 12, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 2, 15, 20, 14, 30, 776, DateTimeKind.Local).AddTicks(928), "عبير أسامة", "Myriam Lang", "أمجد - جابر‌", null, "643539141361791972", "Rwanda", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1977, 2, 26, 6, 51, 51, 580, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 2, 15, 9, 45, 49, 662, DateTimeKind.Local).AddTicks(3450), "سالم آدم", "Audreanne Swaniawski", "أمجد, هاشم and أسامة", null, "6921131277215989636", "Isle of Man", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 22, 2, 16, 13, 719, DateTimeKind.Local).AddTicks(8458), new DateTime(2024, 2, 15, 2, 50, 1, 598, DateTimeKind.Local).AddTicks(6723), "جمانة عقیل", "Skylar Monahan", 0, "عزیز, أمجد and عقیل", null, "1394232866369182815", "Sao Tome and Principe", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1965, 11, 14, 1, 59, 44, 539, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 2, 15, 6, 58, 17, 9, DateTimeKind.Local).AddTicks(2537), "جمانة جابر‌", "Dwight Hegmann", "طارق, سعيد and فاروق", null, "2447310372232246334", "Guam", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1976, 10, 9, 21, 19, 44, 143, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 2, 15, 14, 32, 25, 781, DateTimeKind.Local).AddTicks(9483), "منى معروف", "Corine Schaefer", 0, "حازم, عزیز and فؤاد", null, "2277322708963822042", "Saint Kitts and Nevis", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1982, 6, 20, 16, 37, 31, 276, DateTimeKind.Local).AddTicks(2243), new DateTime(2024, 2, 15, 11, 24, 19, 254, DateTimeKind.Local).AddTicks(6266), "سالم صلاح", "Tyrique Bashirian", "هاشم LLC", null, "2310676087712390706", "Saint Martin", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1981, 2, 1, 2, 46, 37, 293, DateTimeKind.Local).AddTicks(2495), new DateTime(2024, 2, 15, 6, 28, 8, 118, DateTimeKind.Local).AddTicks(5365), "زينب فريد", "Ashleigh Schimmel", 0, "عقیل, فؤاد and بلال", null, "3191284447812153295", "Maldives", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 19, 18, 44, 25, 154, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 2, 15, 11, 47, 32, 501, DateTimeKind.Local).AddTicks(9279), "جابر‌ عصار", "Bernie Luettgen", 0, "فريد - آدم", null, "8862478998828169797", "Austria", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1986, 11, 14, 21, 28, 28, 264, DateTimeKind.Local).AddTicks(8933), new DateTime(2024, 2, 15, 22, 25, 10, 867, DateTimeKind.Local).AddTicks(389), "فاطمة زيد", "Jace Barrows", "آدم, عارف and فاروق", null, "5710254584482833963", "Dominican Republic", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1987, 9, 14, 23, 57, 42, 692, DateTimeKind.Local).AddTicks(4101), new DateTime(2024, 2, 15, 13, 31, 10, 807, DateTimeKind.Local).AddTicks(1592), "جمانة فؤاد", "Julie Bahringer", 0, "حسن, جابر‌ and فؤاد", null, "1275492058099052536", "Liechtenstein", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1994, 1, 2, 5, 0, 10, 507, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 2, 15, 14, 23, 24, 968, DateTimeKind.Local).AddTicks(6439), "آية عصار", "Marlon Reilly", 1, "زيد, سعيد and حسن", null, "1244545883956573974", "Ghana", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1960, 9, 2, 9, 35, 39, 242, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 2, 15, 12, 15, 5, 722, DateTimeKind.Local).AddTicks(8689), "آية ربيع", "Delmer Dietrich", "فاروق - جابر‌", null, "293055600619345750", "China", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1957, 6, 16, 4, 22, 30, 23, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 2, 15, 7, 48, 1, 318, DateTimeKind.Local).AddTicks(7616), "إيهاب حسن", "Jaeden Moore", 1, "عاشور LLC", null, "595280247626758860", "Bangladesh", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1956, 11, 2, 6, 0, 50, 472, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 2, 15, 20, 2, 17, 607, DateTimeKind.Local).AddTicks(8573), "عبير أمجد", "Cora Bechtelar", 0, "عاشور, عزیز and عاشور", null, "3996763256631562732", "Chad", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1959, 10, 17, 6, 50, 29, 781, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 2, 15, 10, 49, 33, 973, DateTimeKind.Local).AddTicks(1166), "جابر‌ فريد", "Renee Jones", 0, "عصار, عقیل and زيد", null, "4572256614765091192", "Nepal", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1963, 8, 8, 22, 23, 54, 52, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 2, 15, 2, 14, 18, 731, DateTimeKind.Local).AddTicks(6876), "فؤاد إيهاب", "Connor Schroeder", 0, "سالم - أسامة", null, "3621984464812343581", "Uzbekistan", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1987, 5, 2, 6, 33, 26, 807, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 2, 15, 1, 27, 24, 61, DateTimeKind.Local).AddTicks(7607), "أسامة سعيد", "Catharine Miller", "عصار, حازم and آدم", null, "2252132961859072407", "Sao Tome and Principe", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1970, 11, 9, 11, 42, 40, 320, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 2, 15, 19, 29, 26, 453, DateTimeKind.Local).AddTicks(8767), "أروى إيهاب", "Leone Schuster", "عارف - حازم", null, "157095403164724048", "Vietnam", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 4, 4, 47, 29, 684, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 2, 15, 1, 6, 6, 112, DateTimeKind.Local).AddTicks(871), "فريد زيد", "Jennifer Romaguera", "سالم - عزیز", null, "6060735193057034560", "Mali", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1968, 11, 16, 8, 13, 22, 87, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 2, 15, 20, 49, 8, 84, DateTimeKind.Local).AddTicks(3475), "إيهاب عقیل", "Anna Kuhic", 1, "عصار, معروف and عارف", null, "9167012998046220979", "Iran", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1986, 6, 16, 19, 5, 50, 965, DateTimeKind.Local).AddTicks(6591), new DateTime(2024, 2, 15, 2, 20, 15, 671, DateTimeKind.Local).AddTicks(9464), "منى جابر‌", "Madge Gottlieb", 1, "فؤاد Inc", null, "9117123574867147636", "Nauru", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(2002, 2, 20, 22, 55, 36, 602, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 2, 15, 8, 13, 27, 88, DateTimeKind.Local).AddTicks(6145), "صلاح جابر‌", "Kenny Welch", "عارف and Sons", null, "7325096034956811906", "Western Sahara", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 1, 23, 1, 56, 51, 463, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 2, 15, 16, 33, 2, 678, DateTimeKind.Local).AddTicks(7139), "آية عاشور", "Lenna Connelly", 0, "إيهاب Inc", null, "1239969859691914670", "Gambia", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1992, 9, 11, 1, 24, 17, 918, DateTimeKind.Local).AddTicks(494), new DateTime(2024, 2, 15, 6, 15, 35, 407, DateTimeKind.Local).AddTicks(5333), "فريد حازم", "Cooper Kub", "حازم - طارق", null, "7356568083350522541", "Guadeloupe", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1968, 8, 13, 17, 42, 43, 255, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 2, 15, 1, 58, 40, 582, DateTimeKind.Local).AddTicks(3253), "أروى عارف", "Weston Hammes", "أسامة Inc", null, "51963069156339691", "Ethiopia", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 9, 23, 6, 3, 260, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 2, 15, 14, 16, 52, 564, DateTimeKind.Local).AddTicks(1480), "جمانة فؤاد", "Deion Maggio", "حسن, أمجد and زيد", null, "4951178205189669208", "Afghanistan", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1982, 10, 10, 7, 6, 0, 37, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 2, 15, 2, 19, 45, 209, DateTimeKind.Local).AddTicks(9295), "ريم حازم", "Coleman Wunsch", 0, "هاشم - طارق", null, "7002165819718573158", "South Georgia and the South Sandwich Islands", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1970, 6, 30, 15, 17, 24, 400, DateTimeKind.Local).AddTicks(3237), new DateTime(2024, 2, 15, 21, 22, 30, 390, DateTimeKind.Local).AddTicks(9845), "جمانة آدم", "Buck Kozey", 0, "سالم Inc", null, "987223408433375338", "French Guiana", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1993, 2, 28, 7, 55, 6, 498, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 2, 15, 18, 35, 53, 529, DateTimeKind.Local).AddTicks(1313), "آدم عزیز", "Brad Lowe", "بلال - معروف", null, "5863525095999920729", "Mozambique", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1966, 4, 3, 7, 54, 48, 776, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 2, 15, 8, 25, 3, 971, DateTimeKind.Local).AddTicks(3100), "منى عزیز", "Bernadine Christiansen", "عصار Group", null, "9132103868020117819", "Switzerland", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1957, 8, 29, 1, 0, 13, 156, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 2, 15, 7, 39, 55, 626, DateTimeKind.Local).AddTicks(1011), "إيهاب سعيد", "Gerardo Hahn", 0, "عارف - طارق", null, "2321927466209912666", "Palau", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1973, 7, 16, 1, 24, 5, 510, DateTimeKind.Local).AddTicks(6082), new DateTime(2024, 2, 15, 18, 34, 26, 995, DateTimeKind.Local).AddTicks(5000), "بلال حسن", "Nova Luettgen", "فريد, معروف and هاشم", null, "1202317105002460478", "France", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1980, 6, 27, 10, 25, 7, 882, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 2, 15, 9, 18, 26, 558, DateTimeKind.Local).AddTicks(5179), "جمانة زيد", "Dejah Fisher", 1, "سعيد - فريد", null, "8956187118291717867", "Malawi", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1965, 8, 30, 3, 38, 30, 13, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 2, 15, 13, 8, 10, 706, DateTimeKind.Local).AddTicks(5938), "لمى ربيع", "Arturo Lueilwitz", 1, "جابر‌ - أسامة", null, "6092311897513737466", "Pitcairn Islands", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1986, 9, 4, 4, 17, 21, 517, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 2, 15, 16, 49, 51, 865, DateTimeKind.Local).AddTicks(493), "أمجد حازم", "Bernhard Kuvalis", 0, "أسامة, ربيع and صلاح", null, "6512795939167532578", "Lao People's Democratic Republic", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1994, 9, 14, 9, 0, 53, 321, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 2, 15, 8, 57, 32, 830, DateTimeKind.Local).AddTicks(7976), "أمجد عراقی", "Jaclyn Senger", "فريد, فريد and ربيع", null, "6692947428568649230", "Eritrea", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2002, 9, 27, 6, 51, 26, 743, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 2, 15, 12, 36, 28, 0, DateTimeKind.Local).AddTicks(447), "جابر‌ عراقی", "Maria Crooks", 0, "حازم - ربيع", null, "3171623894515314194", "Turkmenistan", null, 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1997, 3, 26, 0, 12, 52, 368, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 2, 15, 15, 57, 53, 504, DateTimeKind.Local).AddTicks(9271), "آية أسامة", "Riley Mosciski", 0, "آدم - آدم", null, "4467319538839834159", "United States of America", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1972, 2, 7, 23, 30, 53, 623, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 2, 15, 9, 7, 19, 81, DateTimeKind.Local).AddTicks(4752), "حازم حازم", "Marcella Jenkins", "عقیل Inc", null, "8554148651165728249", "Philippines", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1999, 2, 11, 15, 53, 47, 597, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 2, 14, 23, 12, 35, 521, DateTimeKind.Local).AddTicks(7468), "أروى جابر‌", "Angelina Marquardt", "إيهاب, بلال and عراقی", null, "3324718086083371753", "Cayman Islands", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1956, 2, 13, 1, 49, 15, 939, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 2, 15, 10, 5, 46, 606, DateTimeKind.Local).AddTicks(1242), "منى طارق", "Herta MacGyver", "جابر‌, سالم and عاشور", null, "3571891680988562668", "Micronesia", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1970, 9, 21, 19, 47, 47, 928, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 2, 15, 16, 22, 3, 813, DateTimeKind.Local).AddTicks(2106), "بلال بلال", "Eleazar Goldner", "معروف, هاشم and فاروق", null, "2288922637301816723", "Madagascar", null, 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1996, 4, 20, 23, 48, 56, 535, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 2, 15, 7, 6, 47, 178, DateTimeKind.Local).AddTicks(3235), "أسامة بلال", "Alexandro Lehner", "فاروق, عاشور and جابر‌", null, "8703697668102140814", "Barbados", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1994, 3, 2, 0, 28, 27, 91, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 2, 15, 7, 7, 52, 92, DateTimeKind.Local).AddTicks(4476), "آية بلال", "Kale Kuhlman", "عزیز - حسن", null, "1175535084747748047", "Jordan", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(2003, 9, 23, 0, 4, 30, 821, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 2, 15, 18, 36, 27, 689, DateTimeKind.Local).AddTicks(5974), "عبير ربيع", "Hans Konopelski", 0, "ربيع - عراقی", null, "6981887822524785077", "United States Minor Outlying Islands", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1959, 3, 30, 21, 50, 16, 463, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 2, 15, 1, 0, 19, 355, DateTimeKind.Local).AddTicks(7323), "جابر‌ عقیل", "Lorenz Howell", "عراقی - أسامة", null, "819892854727722667", "Comoros", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1992, 11, 18, 18, 40, 5, 235, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 2, 15, 5, 39, 55, 818, DateTimeKind.Local).AddTicks(6469), "إيهاب فاروق", "Kacey Harvey", 1, "عراقی, سالم and آدم", null, "2758998411362234421", "Turkey", null, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1969, 5, 23, 0, 30, 32, 363, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 2, 15, 8, 25, 38, 549, DateTimeKind.Local).AddTicks(6852), "زيد إيهاب", "Anastasia Mertz", "فؤاد - هاشم", null, "7468974200686696196", "Costa Rica", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1998, 7, 23, 1, 38, 14, 592, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 2, 14, 23, 58, 24, 543, DateTimeKind.Local).AddTicks(3125), "فاروق ربيع", "Jaleel Wiza", "صلاح - سعيد", null, "7921392415828132890", "Falkland Islands (Malvinas)", null, 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId", "SocialState" },
                values: new object[] { new DateTime(1991, 1, 23, 6, 22, 9, 168, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 2, 15, 7, 14, 18, 761, DateTimeKind.Local).AddTicks(7373), "بلال فاروق", "Alda Cole", "عاشور - فاروق", null, "2943488157441178275", "Belize", null, 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "MedicalFileId", "NationalId", "Nationality", "PatientId" },
                values: new object[] { new DateTime(1963, 12, 17, 11, 2, 32, 227, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 2, 15, 1, 11, 23, 619, DateTimeKind.Local).AddTicks(1152), "لمى صلاح", "Jaunita Walsh", 0, "صلاح LLC", null, "358396861298442165", "Cocos (Keeling) Islands", null });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalFileId",
                table: "Patients",
                column: "MedicalFileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientId",
                table: "Patients",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalFiles_MedicalFileId",
                table: "Patients",
                column: "MedicalFileId",
                principalTable: "MedicalFiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Patients_PatientId",
                table: "Patients",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalFiles_MedicalFileId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Patients_PatientId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalFileId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MedicalFileId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Patients");

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
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Phone1" },
                values: new object[] { "شارع سمیه, 0801, عجلون, United States Minor Outlying Islands", "القبة", new DateTime(2024, 1, 20, 8, 33, 51, 633, DateTimeKind.Local).AddTicks(291), "blal38@yahoo.com", "1-594-250-0556 x59016" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 10, 19, 1, 46, 8, 678, DateTimeKind.Local).AddTicks(559), new DateTime(2024, 1, 19, 20, 24, 8, 231, DateTimeKind.Local).AddTicks(905), "سارة ربيع", "Ronaldo Hermiston", 0, "عقیل - أمجد", "5100639644262949177", "Gambia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 8, 1, 8, 17, 9, 666, DateTimeKind.Local).AddTicks(9747), new DateTime(2024, 1, 20, 11, 15, 13, 679, DateTimeKind.Local).AddTicks(5621), "رقية سالم", "Triston Johns", 0, "بلال Group", "3745927645456612790", "Timor-Leste", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 8, 31, 0, 5, 1, 55, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 1, 20, 16, 50, 27, 754, DateTimeKind.Local).AddTicks(6303), "فاطمة عراقی", "Raymundo Bode", 0, "سالم LLC", "7735029507890940543", "Ecuador", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1955, 3, 2, 4, 37, 19, 790, DateTimeKind.Local).AddTicks(302), new DateTime(2024, 1, 20, 1, 58, 17, 135, DateTimeKind.Local).AddTicks(3646), "فؤاد أسامة", "Janie Ebert", 1, "أسامة - معروف", "1377696469467128365", "Lesotho" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 2, 5, 2, 48, 30, 703, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 1, 20, 17, 8, 11, 865, DateTimeKind.Local).AddTicks(315), "هاجر آدم", "Libby Schiller", 1, "سعيد, هاشم and فؤاد", "8944911598765535175", "Bahrain", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 6, 24, 15, 54, 7, 227, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 1, 20, 5, 1, 18, 594, DateTimeKind.Local).AddTicks(5261), "عبير فاروق", "Nova Zemlak", "إيهاب, أمجد and عارف", "6728768035179211284", "Sri Lanka", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 10, 31, 1, 51, 32, 770, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 1, 20, 4, 18, 15, 299, DateTimeKind.Local).AddTicks(6847), "حازم عصار", "Candice Schneider", 1, "عزیز, عزیز and عاشور", "7738217257890561770", "New Zealand", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 3, 27, 5, 4, 39, 606, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 1, 20, 9, 28, 37, 755, DateTimeKind.Local).AddTicks(6259), "زينب حازم", "Isadore Crooks", "معروف - فؤاد", "8452338936959298000", "United Arab Emirates", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1956, 12, 26, 4, 32, 22, 856, DateTimeKind.Local).AddTicks(8609), new DateTime(2024, 1, 20, 14, 16, 28, 184, DateTimeKind.Local).AddTicks(6578), "آدم حازم", "Brannon Boyle", 1, "طارق - أسامة", "8248617773616357868", "Afghanistan" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 11, 3, 18, 7, 24, 215, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 1, 20, 4, 28, 53, 352, DateTimeKind.Local).AddTicks(5104), "شيماء فريد", "Burnice Kihn", 0, "معروف LLC", "9016750158254237307", "Maldives", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 8, 18, 15, 39, 3, 609, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 1, 20, 13, 56, 27, 707, DateTimeKind.Local).AddTicks(203), "سارة صلاح", "Dina Mills", "فاروق, صلاح and عارف", "2231680261004521709", "South Africa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1980, 1, 18, 5, 0, 12, 783, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 1, 20, 14, 20, 6, 107, DateTimeKind.Local).AddTicks(1254), "هاجر هاشم", "Lia Shanahan", "آدم, أسامة and عزیز", "4165853426637056848", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 7, 5, 23, 7, 32, 91, DateTimeKind.Local).AddTicks(5401), new DateTime(2024, 1, 20, 8, 20, 36, 219, DateTimeKind.Local).AddTicks(7435), "طارق عراقی", "Tiara Christiansen", "إيهاب LLC", "2411767537437672803", "Northern Mariana Islands", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2003, 1, 5, 12, 30, 1, 691, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 1, 20, 13, 34, 31, 250, DateTimeKind.Local).AddTicks(4980), "ريم صلاح", "Lera Greenholt", 1, "معروف - أمجد", "6522120202997648783", "Lithuania", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 6, 8, 11, 43, 23, 368, DateTimeKind.Local).AddTicks(391), new DateTime(2024, 1, 20, 5, 0, 31, 242, DateTimeKind.Local).AddTicks(1420), "أروى أمجد", "Katrina Weber", 0, "عصار Group", "4468855074895635836", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2000, 5, 1, 8, 25, 59, 72, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 1, 20, 17, 0, 25, 154, DateTimeKind.Local).AddTicks(7436), "صلاح سعيد", "Lavon Schumm", 1, "أسامة, طارق and هاشم", "1578573825225444585", "Ethiopia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 2, 9, 15, 53, 4, 980, DateTimeKind.Local).AddTicks(2381), new DateTime(2024, 1, 20, 0, 15, 16, 389, DateTimeKind.Local).AddTicks(5467), "فؤاد هاشم", "Rossie Sauer", 1, "عارف Inc", "4859454006606909410", "Togo", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 12, 27, 8, 32, 7, 35, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 1, 20, 12, 27, 51, 946, DateTimeKind.Local).AddTicks(5083), "شيماء فاروق", "Gail Murray", "سالم Inc", "4004622200659175736", "Gambia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 4, 21, 20, 56, 5, 186, DateTimeKind.Local).AddTicks(2446), new DateTime(2024, 1, 20, 2, 43, 38, 405, DateTimeKind.Local).AddTicks(9854), "هاجر طارق", "Dianna Gusikowski", 0, "حازم Group", "8773255885411199274", "Cuba", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 1, 17, 9, 53, 42, 167, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 1, 20, 1, 22, 18, 394, DateTimeKind.Local).AddTicks(7486), "دانا إيهاب", "Abdiel Goyette", 1, "إيهاب, فؤاد and عقیل", "8810530316192373819", "Belarus", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 5, 25, 23, 11, 33, 101, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 1, 19, 20, 46, 38, 53, DateTimeKind.Local).AddTicks(9701), "جابر‌ عقیل", "Freddy Cartwright", 0, "فؤاد, زيد and فريد", "6950746492026656591", "Guyana", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 9, 15, 23, 46, 52, 492, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 1, 20, 0, 40, 1, 808, DateTimeKind.Local).AddTicks(7438), "إيهاب عزیز", "Maurice Quigley", 1, "عقیل, إيهاب and عارف", "5477658748595711529", "Syrian Arab Republic" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 4, 22, 12, 10, 59, 614, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 1, 20, 18, 23, 32, 892, DateTimeKind.Local).AddTicks(3587), "إيهاب أسامة", "Nico Williamson", "حسن, عارف and عزیز", "1463450526165813917", "Fiji", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1968, 5, 9, 13, 30, 9, 437, DateTimeKind.Local).AddTicks(1844), new DateTime(2024, 1, 20, 14, 43, 21, 847, DateTimeKind.Local).AddTicks(2803), "شيماء جابر‌", "Dulce Padberg", 1, "عراقی - صلاح", "7201680747481053805", "Montenegro", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1991, 10, 3, 14, 42, 13, 140, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 1, 19, 19, 3, 31, 443, DateTimeKind.Local).AddTicks(5976), "سارة عقیل", "Stanford Steuber", "صلاح LLC", "5330480249822796152", "Belgium" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1986, 5, 23, 0, 12, 45, 56, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 1, 20, 2, 20, 24, 4, DateTimeKind.Local).AddTicks(8652), "آدم فريد", "Chelsea Mitchell", 1, "فؤاد - آدم", "2022062177259971259", "Cambodia", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1985, 10, 11, 16, 51, 32, 953, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 1, 20, 10, 55, 1, 129, DateTimeKind.Local).AddTicks(2153), "عبير سعيد", "Phoebe Greenholt", 1, "عصار Group", "6737575686100605902", "Afghanistan", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1973, 6, 15, 9, 4, 58, 759, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 1, 20, 12, 39, 2, 832, DateTimeKind.Local).AddTicks(5678), "آية عزیز", "Dustin Volkman", 0, "أسامة LLC", "8195704667925724321", "Panama", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1961, 1, 9, 1, 32, 18, 8, DateTimeKind.Local).AddTicks(4546), new DateTime(2024, 1, 20, 17, 12, 13, 163, DateTimeKind.Local).AddTicks(8738), "فاروق صلاح", "Leta Cartwright", 0, "هاشم - حسن", "6438223063338941693", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 12, 3, 6, 38, 10, 690, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 1, 20, 2, 43, 22, 755, DateTimeKind.Local).AddTicks(4171), "زيد جابر‌", "Maverick Reichert", "سعيد, جابر‌ and هاشم", "546664992100471206", "Zimbabwe" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 3, 31, 1, 41, 28, 998, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 1, 19, 23, 4, 17, 473, DateTimeKind.Local).AddTicks(1685), "شيماء سعيد", "Travon Russel", "سالم, عاشور and آدم", "2849184964534601640", "Nepal", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 9, 2, 8, 21, 40, 870, DateTimeKind.Local).AddTicks(1461), new DateTime(2024, 1, 20, 18, 12, 25, 878, DateTimeKind.Local).AddTicks(9824), "هاجر عارف", "Jerrold Stiedemann", 1, "طارق and Sons", "3668384355391342206", "Italy", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1954, 11, 27, 18, 42, 20, 158, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 1, 20, 0, 6, 41, 712, DateTimeKind.Local).AddTicks(4436), "فريد سعيد", "Gordon Hauck", 0, "عراقی Group", "485790099488091372", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 1, 12, 16, 30, 31, 580, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 1, 20, 3, 24, 43, 994, DateTimeKind.Local).AddTicks(5951), "طارق عصار", "Vidal Johnson", 1, "أسامة, سعيد and عزیز", "1423191879764408028", "Denmark", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 9, 21, 14, 41, 15, 735, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 1, 20, 8, 32, 41, 311, DateTimeKind.Local).AddTicks(7338), "فريدة إيهاب", "Neil Schamberger", 1, "إيهاب, ربيع and أسامة", "8459333634190197888", "Thailand", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 4, 20, 22, 51, 53, 17, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 1, 20, 8, 38, 39, 844, DateTimeKind.Local).AddTicks(8984), "حازم سعيد", "Francisca Mueller", "فؤاد LLC", "8918277483298536260", "Lebanon", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 4, 22, 11, 5, 29, 875, DateTimeKind.Local).AddTicks(2356), new DateTime(2024, 1, 19, 20, 44, 19, 496, DateTimeKind.Local).AddTicks(4782), "هاجر أمجد", "Ericka Jacobi", "عقیل, آدم and آدم", "7949943442391468671", "Lebanon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 2, 3, 14, 52, 26, 185, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 1, 20, 2, 28, 35, 338, DateTimeKind.Local).AddTicks(1164), "أسامة عزیز", "Conor Purdy", "هاشم - إيهاب", "60640770167977987", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 7, 22, 3, 20, 43, 33, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 1, 19, 22, 32, 55, 449, DateTimeKind.Local).AddTicks(6380), "آية جابر‌", "Keon Labadie", "سعيد, صلاح and فريد", "2392952514344428877", "Ukraine", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2000, 1, 28, 19, 15, 26, 774, DateTimeKind.Local).AddTicks(1534), new DateTime(2024, 1, 20, 4, 0, 7, 435, DateTimeKind.Local).AddTicks(6341), "فريدة معروف", "Crystel Goodwin", 1, "عصار, فاروق and فريد", "8146314740441857436", "Falkland Islands (Malvinas)", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1955, 2, 20, 8, 27, 21, 925, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 1, 20, 4, 21, 28, 529, DateTimeKind.Local).AddTicks(9487), "فؤاد عقیل", "Edward Harber", "فؤاد, عصار and حسن", "1065945466252154631", "Niger", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1957, 9, 20, 22, 20, 43, 360, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 1, 20, 4, 48, 52, 691, DateTimeKind.Local).AddTicks(9661), "صلاح فريد", "Veda Reinger", "سالم, صلاح and بلال", "7383865167510696262", "Tanzania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 12, 14, 9, 36, 47, 308, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 1, 19, 19, 19, 2, 468, DateTimeKind.Local).AddTicks(2952), "حسن سالم", "Jameson O'Kon", 0, "صلاح and Sons", "1633152817257579767", "Turkmenistan", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 3, 24, 14, 46, 19, 600, DateTimeKind.Local).AddTicks(1158), new DateTime(2024, 1, 19, 21, 41, 3, 734, DateTimeKind.Local).AddTicks(8121), "سارة عقیل", "Idella Reichert", 1, "طارق Inc", "7424596465112214786", "Switzerland", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 11, 2, 11, 50, 26, 116, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 1, 20, 12, 17, 46, 438, DateTimeKind.Local).AddTicks(6270), "فؤاد زيد", "Allan Upton", 1, "فاروق, زيد and حسن", "7871927299614803198", "Sweden", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1965, 10, 17, 19, 16, 13, 901, DateTimeKind.Local).AddTicks(1680), new DateTime(2024, 1, 19, 21, 16, 53, 372, DateTimeKind.Local).AddTicks(5806), "إيناس هاشم", "Yasmine Bauch", 1, "عراقی, عقیل and عزیز", "4997829571092485860", "United Arab Emirates" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 2, 24, 0, 34, 4, 986, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 1, 20, 2, 12, 19, 371, DateTimeKind.Local).AddTicks(5192), "شيماء طارق", "Nestor Schultz", "بلال LLC", "5178036801498383434", "Sudan", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1954, 7, 8, 23, 24, 9, 49, DateTimeKind.Local).AddTicks(7433), new DateTime(2024, 1, 20, 18, 8, 28, 849, DateTimeKind.Local).AddTicks(3254), "آدم حسن", "Vilma Russel", 0, "فريد - هاشم", "8339021285714947073", "Sierra Leone", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 12, 9, 7, 14, 1, 349, DateTimeKind.Local).AddTicks(5414), new DateTime(2024, 1, 20, 1, 43, 18, 186, DateTimeKind.Local).AddTicks(8912), "فريد فريد", "Kamille Weimann", 1, "عصار Group", "5681837872080238297", "Cameroon", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 5, 15, 22, 38, 49, 619, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 1, 20, 17, 3, 26, 781, DateTimeKind.Local).AddTicks(1893), "زينب سعيد", "Leif Feest", "جابر‌, فؤاد and آدم", "8742909774614727978", "Central African Republic", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 3, 25, 0, 29, 54, 706, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 1, 20, 14, 45, 31, 364, DateTimeKind.Local).AddTicks(737), "آدم حسن", "Pierre Waelchi", "حسن - أمجد", "2195877423450044311", "Gabon", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 4, 15, 18, 5, 47, 869, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 1, 20, 6, 33, 19, 810, DateTimeKind.Local).AddTicks(1718), "جمانة حازم", "Kieran Ratke", "عزیز - سعيد", "4826479348355403291", "Iran", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 1, 31, 21, 1, 25, 177, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 1, 20, 16, 35, 15, 382, DateTimeKind.Local).AddTicks(4542), "آدم بلال", "Silas Kihn", "آدم, فؤاد and عراقی", "7156917752251998529", "Bermuda", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 6, 18, 10, 14, 34, 860, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 1, 19, 18, 37, 3, 25, DateTimeKind.Local).AddTicks(2190), "هاجر إيهاب", "Cyrus Ritchie", 0, "حسن Group", "8219163676734037746", "Nicaragua", 3 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 9, 13, 13, 49, 59, 281, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 1, 19, 23, 51, 56, 182, DateTimeKind.Local).AddTicks(8352), "جمانة حسن", "Lucinda Johnson", "عارف, إيهاب and حازم", "6324374140087646229", "Guinea-Bissau", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 12, 6, 21, 27, 18, 35, DateTimeKind.Local).AddTicks(4441), new DateTime(2024, 1, 20, 10, 0, 43, 707, DateTimeKind.Local).AddTicks(2940), "آية إيهاب", "Martin Halvorson", "إيهاب LLC", "2191370630001154289", "Sweden", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 5, 26, 11, 55, 5, 36, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 1, 20, 17, 33, 28, 951, DateTimeKind.Local).AddTicks(2059), "دانا هاشم", "Coty Bednar", "عصار and Sons", "4125256003680510907", "Macedonia", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(2001, 7, 11, 13, 13, 30, 743, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 1, 19, 21, 49, 4, 642, DateTimeKind.Local).AddTicks(7748), "سارة سالم", "Elinore Baumbach", 1, "طارق, زيد and إيهاب", "5181338853015595151", "Madagascar", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 8, 2, 17, 52, 42, 867, DateTimeKind.Local).AddTicks(6028), new DateTime(2024, 1, 20, 2, 33, 4, 601, DateTimeKind.Local).AddTicks(372), "إيهاب هاشم", "Albina Ferry", 1, "فاروق, حازم and أمجد", "6409864603031935554", "Macedonia", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1993, 12, 20, 16, 3, 44, 261, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 1, 20, 0, 46, 51, 312, DateTimeKind.Local).AddTicks(8272), "رنا عقیل", "Ignacio Carroll", "طارق, زيد and صلاح", "362026565088993844", "Antarctica (the territory South of 60 deg S)", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 11, 20, 8, 24, 23, 306, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 1, 20, 7, 55, 50, 581, DateTimeKind.Local).AddTicks(9744), "فؤاد طارق", "Monte Grimes", 1, "جابر‌, عزیز and عقیل", "8247294385351436103", "American Samoa", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1997, 2, 5, 4, 35, 20, 28, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 1, 19, 21, 4, 12, 224, DateTimeKind.Local).AddTicks(6451), "أسامة آدم", "Stan Braun", "أمجد - زيد", "527642570008430304", "Kenya" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 12, 9, 19, 9, 57, 739, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 1, 20, 9, 16, 9, 108, DateTimeKind.Local).AddTicks(4317), "دانا سعيد", "Ciara Zieme", "عقیل, ربيع and عصار", "8295318223955980250", "Macao" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1983, 4, 27, 4, 9, 30, 267, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 1, 20, 15, 32, 54, 22, DateTimeKind.Local).AddTicks(376), "طارق ربيع", "Elroy Feil", "هاشم, حسن and معروف", "2718880027376694548", "Jersey" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1996, 5, 1, 20, 7, 23, 488, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 1, 20, 12, 57, 11, 884, DateTimeKind.Local).AddTicks(902), "أسامة سعيد", "Jessie Fritsch", "زيد LLC", "5160585787530254752", "Germany", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1996, 8, 6, 3, 30, 6, 341, DateTimeKind.Local).AddTicks(6490), new DateTime(2024, 1, 20, 9, 1, 39, 528, DateTimeKind.Local).AddTicks(3987), "جمانة عارف", "Antonette Schuster", "عزیز, هاشم and فاروق", "1871883023489905435", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 7, 23, 21, 32, 11, 500, DateTimeKind.Local).AddTicks(9009), new DateTime(2024, 1, 20, 17, 56, 43, 90, DateTimeKind.Local).AddTicks(4697), "منى صلاح", "Amalia Kulas", "حسن and Sons", "7591702083000295794", "Iceland", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 2, 22, 21, 15, 36, 547, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 1, 19, 18, 43, 24, 394, DateTimeKind.Local).AddTicks(7123), "أسامة زيد", "Gordon O'Hara", "عارف - عصار", "7422449181930939731", "Faroe Islands", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 9, 4, 14, 4, 30, 448, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 1, 20, 8, 11, 49, 393, DateTimeKind.Local).AddTicks(5155), "فاطمة عقیل", "Donny Schamberger", 0, "أمجد - صلاح", "3881217892339198804", "Spain", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1965, 1, 7, 0, 45, 30, 211, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 1, 20, 9, 15, 39, 795, DateTimeKind.Local).AddTicks(8938), "رقية فؤاد", "Angeline Bergnaum", "إيهاب - سالم", "7567854533201371476", "Japan", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 12, 9, 17, 54, 29, 341, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 1, 20, 5, 43, 19, 521, DateTimeKind.Local).AddTicks(5786), "سارة أسامة", "Nova Spencer", "عزیز LLC", "8699531056370295758", "Poland" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 5, 14, 14, 41, 10, 568, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 1, 20, 12, 57, 23, 606, DateTimeKind.Local).AddTicks(9000), "فاروق حازم", "Beverly Mills", "حسن - عراقی", "4601458304569926272", "Slovenia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 4, 27, 15, 5, 20, 171, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 1, 20, 15, 5, 35, 887, DateTimeKind.Local).AddTicks(3544), "جابر‌ إيهاب", "Jessyca VonRueden", "سالم, آدم and طارق", "950133904476107042", "Samoa", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1982, 9, 19, 23, 38, 34, 13, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 1, 19, 19, 26, 8, 710, DateTimeKind.Local).AddTicks(4749), "سارة فاروق", "Naomie Schmitt", "هاشم Inc", "3484395788975564232", "Mali", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 2, 5, 1, 4, 11, 747, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 1, 19, 23, 52, 6, 507, DateTimeKind.Local).AddTicks(9909), "زيد عارف", "Irwin Schaefer", "عقیل and Sons", "2591802890326194813", "Mayotte", 4 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1983, 8, 17, 7, 23, 13, 684, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 1, 19, 21, 56, 10, 515, DateTimeKind.Local).AddTicks(4419), "حسن هاشم", "Felicita Hermiston", "طارق - صلاح", "3422451171118244893", "Botswana", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1989, 3, 27, 10, 46, 30, 28, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 1, 20, 16, 5, 43, 237, DateTimeKind.Local).AddTicks(5695), "رنا جابر‌", "Vergie Mayer", "جابر‌, سعيد and بلال", "1731490337121289003", "French Guiana", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 4, 16, 15, 24, 8, 314, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 1, 20, 2, 49, 39, 493, DateTimeKind.Local).AddTicks(6379), "أروى عقیل", "Claude Kling", "زيد - أسامة", "1155758806179309126", "Romania", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 12, 7, 7, 22, 12, 314, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 1, 20, 9, 52, 20, 573, DateTimeKind.Local).AddTicks(6375), "سارة سالم", "Ulises Abbott", 0, "عارف Group", "262623296896873608", "Turkey", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 11, 17, 0, 59, 49, 112, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 1, 20, 14, 18, 52, 364, DateTimeKind.Local).AddTicks(9556), "ربيع ربيع", "Angie Daugherty", "ربيع, سعيد and عقیل", "894309056050788827", "Virgin Islands, British" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 8, 24, 16, 6, 15, 411, DateTimeKind.Local).AddTicks(1994), new DateTime(2024, 1, 20, 12, 17, 47, 722, DateTimeKind.Local).AddTicks(3749), "دانا فؤاد", "Karolann Gusikowski", 1, "عراقی and Sons", "4793045665329809980", "Canada", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 12, 12, 8, 8, 17, 708, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 1, 20, 1, 16, 14, 545, DateTimeKind.Local).AddTicks(1474), "أمجد فاروق", "Terence Lind", 1, "ربيع and Sons", "1992541602079517157", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1962, 11, 8, 7, 21, 20, 390, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 1, 19, 23, 46, 52, 611, DateTimeKind.Local).AddTicks(2980), "سارة فاروق", "Emmitt Shields", 0, "أسامة, جابر‌ and عقیل", "7367221727678914099", "San Marino" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 2, 24, 11, 22, 38, 235, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 1, 20, 7, 24, 4, 297, DateTimeKind.Local).AddTicks(3070), "سالم آدم", "Larue Koepp", 0, "ربيع - جابر‌", "5350927836035141986", "France", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1969, 9, 26, 10, 17, 19, 730, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 1, 20, 1, 57, 7, 498, DateTimeKind.Local).AddTicks(8567), "زيد سالم", "Jess Macejkovic", "فؤاد, فاروق and فؤاد", "7369149127343572065", "Kazakhstan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 12, 2, 3, 7, 44, 173, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 1, 20, 0, 29, 10, 219, DateTimeKind.Local).AddTicks(543), "صلاح ربيع", "Anita Wolff", "جابر‌ and Sons", "2375454823761823409", "Macedonia", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 1, 6, 21, 43, 54, 410, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 1, 20, 14, 40, 57, 551, DateTimeKind.Local).AddTicks(5844), "أسامة أسامة", "Abbie Cummings", 1, "آدم, عصار and إيهاب", "2954003154041660019", "Faroe Islands", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1957, 5, 31, 19, 59, 6, 439, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 1, 20, 12, 55, 43, 162, DateTimeKind.Local).AddTicks(192), "ريم عراقی", "Joan Bechtelar", 0, "حسن, فاروق and عقیل", "3875163581277165066", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(2002, 5, 17, 6, 18, 48, 292, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 1, 20, 13, 50, 30, 581, DateTimeKind.Local).AddTicks(6921), "فريد فريد", "Maximo Abernathy", "عارف - صلاح", "2004917788073757451", "Faroe Islands" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 12, 1, 23, 32, 5, 340, DateTimeKind.Local).AddTicks(6677), new DateTime(2024, 1, 20, 13, 1, 8, 797, DateTimeKind.Local).AddTicks(4921), "فاطمة آدم", "Idella Goyette", 0, "حازم - سالم", "5687160938774450405", "Trinidad and Tobago", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 12, 23, 9, 42, 52, 575, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 1, 20, 9, 57, 18, 982, DateTimeKind.Local).AddTicks(4847), "حازم عاشور", "Damian Gleichner", "سعيد - زيد", "7174634744274993962", "Jordan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1994, 4, 23, 23, 25, 22, 476, DateTimeKind.Local).AddTicks(5332), new DateTime(2024, 1, 20, 14, 17, 44, 360, DateTimeKind.Local).AddTicks(4681), "هاجر فؤاد", "Norene Braun", 1, "حازم - ربيع", "3878650869282438410", "Hong Kong", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1959, 4, 28, 13, 40, 38, 670, DateTimeKind.Local).AddTicks(8331), new DateTime(2024, 1, 20, 13, 25, 37, 311, DateTimeKind.Local).AddTicks(7305), "رنا آدم", "Myles Jast", "أسامة, زيد and طارق", "2032882031267316776", "Namibia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1973, 11, 12, 16, 18, 46, 971, DateTimeKind.Local).AddTicks(4885), new DateTime(2024, 1, 19, 21, 0, 11, 10, DateTimeKind.Local).AddTicks(8238), "رنا عارف", "Florence Becker", "عقیل, أمجد and عاشور", "2506830563549500661", "El Salvador" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1992, 10, 18, 22, 11, 4, 946, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 1, 20, 7, 59, 22, 990, DateTimeKind.Local).AddTicks(3194), "زيد فؤاد", "Damaris White", "أسامة - فريد", "7103862416895640841", "Saint Martin" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1986, 4, 17, 22, 36, 8, 815, DateTimeKind.Local).AddTicks(2235), new DateTime(2024, 1, 19, 20, 58, 5, 394, DateTimeKind.Local).AddTicks(5942), "رنا طارق", "Abner Walker", 1, "عزیز, فؤاد and فؤاد", "4361699013901621098", "Azerbaijan" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1967, 10, 15, 5, 3, 42, 235, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 1, 19, 22, 56, 39, 266, DateTimeKind.Local).AddTicks(4403), "أمجد سعيد", "Susana Wunsch", "عراقی - عراقی", "2365462170600565471", "Denmark", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1992, 10, 7, 19, 37, 19, 985, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 1, 19, 21, 5, 47, 900, DateTimeKind.Local).AddTicks(897), "لمى بلال", "Mekhi Jacobson", 0, "حسن LLC", "2685792390489783935", "Saint Pierre and Miquelon", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1960, 1, 18, 16, 50, 27, 242, DateTimeKind.Local).AddTicks(9777), new DateTime(2024, 1, 20, 0, 56, 14, 172, DateTimeKind.Local).AddTicks(7562), "رنا هاشم", "Randi Bahringer", "بلال Group", "3270727581697961455", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 6, 22, 17, 36, 20, 604, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 1, 20, 8, 9, 31, 837, DateTimeKind.Local).AddTicks(9134), "هاجر آدم", "Hershel Lehner", 0, "حازم Group", "7950055946005200022", "Mauritania", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1971, 11, 14, 15, 52, 23, 914, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 1, 19, 21, 0, 16, 278, DateTimeKind.Local).AddTicks(7927), "دانا أسامة", "Garth Rolfson", 1, "حسن, فاروق and عزیز", "1366453739606131919", "Suriname" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1966, 1, 2, 19, 13, 47, 587, DateTimeKind.Local).AddTicks(5040), new DateTime(2024, 1, 19, 19, 18, 8, 929, DateTimeKind.Local).AddTicks(756), "بلال عراقی", "Dashawn Skiles", "طارق and Sons", "1851395946568597226", "Kiribati", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1993, 7, 31, 22, 20, 51, 932, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 1, 20, 0, 13, 9, 455, DateTimeKind.Local).AddTicks(2323), "أمجد حسن", "Tabitha Satterfield", "بلال, إيهاب and جابر‌", "4839885811861981751", "Slovakia (Slovak Republic)" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1990, 3, 12, 22, 43, 31, 145, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 1, 20, 11, 36, 45, 228, DateTimeKind.Local).AddTicks(6212), "حسن ربيع", "Jody Labadie", 0, "سالم, صلاح and سعيد", "2758947595835427555", "Northern Mariana Islands" });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1984, 1, 7, 7, 52, 22, 221, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 1, 20, 0, 38, 43, 129, DateTimeKind.Local).AddTicks(1854), "شيماء حازم", "Christopher Green", "عقیل and Sons", "4667767081936309186", "American Samoa" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1997, 2, 5, 11, 21, 2, 566, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 1, 19, 20, 21, 7, 464, DateTimeKind.Local).AddTicks(2811), "ريم عصار", "Rosella Kirlin", 1, "أمجد, صلاح and سعيد", "1146321237153596071", "Seychelles", 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1975, 2, 9, 20, 30, 2, 798, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 1, 20, 12, 6, 31, 805, DateTimeKind.Local).AddTicks(3705), "شيماء سعيد", "Cordia Sanford", "طارق, صلاح and فؤاد", "5744948509525861774", "Kuwait", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 2, 19, 10, 38, 47, 786, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 1, 20, 17, 51, 17, 152, DateTimeKind.Local).AddTicks(5941), "لمى إيهاب", "Tracy Beier", "إيهاب LLC", "5038264248327193323", "Ireland", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1956, 6, 23, 3, 26, 30, 313, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 1, 20, 11, 7, 45, 16, DateTimeKind.Local).AddTicks(5842), "أمجد زيد", "Ariel Auer", "عاشور - فريد", "3193243834130749150", "Iran", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 7, 18, 17, 55, 59, 597, DateTimeKind.Local).AddTicks(9987), new DateTime(2024, 1, 20, 15, 54, 2, 296, DateTimeKind.Local).AddTicks(3540), "فؤاد سالم", "Rowena Becker", "زيد, أمجد and حازم", "6209993465435162988", "Eritrea", 1 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1987, 8, 6, 20, 55, 41, 144, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 1, 20, 13, 17, 30, 659, DateTimeKind.Local).AddTicks(8048), "حسن عقیل", "Eino Jacobson", "سالم - صلاح", "5785240192762812722", "Pakistan", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1980, 8, 25, 22, 23, 35, 357, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 1, 20, 14, 55, 10, 790, DateTimeKind.Local).AddTicks(4181), "شيماء فؤاد", "Julia Hirthe", 0, "حسن - معروف", "8597436659767064532", "Mexico", 2 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 7, 6, 13, 5, 39, 502, DateTimeKind.Local).AddTicks(327), new DateTime(2024, 1, 20, 15, 48, 15, 171, DateTimeKind.Local).AddTicks(7394), "إيناس أمجد", "Aron Smitham", 0, "عراقی - طارق", "4590582068444161032", "Chad", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1971, 10, 18, 11, 5, 7, 472, DateTimeKind.Local).AddTicks(2311), new DateTime(2024, 1, 20, 3, 48, 33, 266, DateTimeKind.Local).AddTicks(1320), "سارة بلال", "Maybelle Marvin", 1, "أسامة - حسن", "1344830072264427301", "Grenada", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 1, 27, 7, 54, 38, 34, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 1, 19, 22, 28, 40, 198, DateTimeKind.Local).AddTicks(9045), "سعيد حسن", "Koby Erdman", "حازم - ربيع", "5025267032106748605", "Honduras", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1958, 6, 21, 3, 24, 32, 981, DateTimeKind.Local).AddTicks(7565), new DateTime(2024, 1, 19, 18, 53, 4, 821, DateTimeKind.Local).AddTicks(7140), "أسامة آدم", "Edgardo Durgan", 1, "حسن Inc", "987352697792719316", "Nicaragua", 2 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1972, 4, 10, 20, 7, 25, 979, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 1, 20, 9, 25, 54, 183, DateTimeKind.Local).AddTicks(2944), "إيناس فاروق", "Candice Ruecker", "معروف - آدم", "77130365919822808", "Trinidad and Tobago" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 6, 10, 18, 8, 57, 78, DateTimeKind.Local).AddTicks(8485), new DateTime(2024, 1, 19, 22, 48, 17, 358, DateTimeKind.Local).AddTicks(6811), "عبير معروف", "Jayde Wisoky", "عقیل - صلاح", "5431938449676994188", "New Caledonia" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1988, 5, 17, 0, 25, 8, 820, DateTimeKind.Local).AddTicks(7372), new DateTime(2024, 1, 19, 22, 37, 20, 699, DateTimeKind.Local).AddTicks(1891), "هاجر عصار", "Keon Lynch", "معروف, سعيد and فاروق", "6315187433034609803", "Brazil", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1981, 12, 22, 19, 42, 41, 835, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 1, 20, 17, 2, 45, 618, DateTimeKind.Local).AddTicks(137), "جابر‌ ربيع", "Tina Green", "جابر‌, عقیل and حسن", "9131943607146205649", "Cambodia", 0 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1976, 4, 23, 5, 43, 35, 467, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 1, 20, 1, 51, 1, 905, DateTimeKind.Local).AddTicks(3116), "سارة أمجد", "Brielle Boyle", "طارق - آدم", "5615903279301652291", "Indonesia", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1999, 12, 10, 9, 58, 45, 426, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 1, 19, 22, 9, 28, 803, DateTimeKind.Local).AddTicks(5611), "صلاح طارق", "Laurel Kuhn", "عارف - عصار", "7220757134316108337", "Mexico", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1998, 2, 25, 1, 3, 39, 810, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 1, 20, 5, 17, 26, 913, DateTimeKind.Local).AddTicks(3487), "منى عارف", "Corrine Abernathy", 1, "عقیل - زيد", "5596085292793561916", "Bosnia and Herzegovina", 0 });

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
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1961, 7, 1, 14, 58, 33, 154, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 1, 20, 11, 44, 12, 583, DateTimeKind.Local).AddTicks(754), "عبير جابر‌", "Jamal Kris", 0, "فاروق, جابر‌ and جابر‌", "4043579406200926029", "Ghana", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1969, 7, 3, 0, 4, 10, 495, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 1, 20, 15, 47, 19, 483, DateTimeKind.Local).AddTicks(7455), "جابر‌ أسامة", "Reyna Ferry", "آدم, معروف and فاروق", "197361630954290372", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1964, 11, 22, 12, 53, 36, 149, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 1, 20, 13, 9, 37, 212, DateTimeKind.Local).AddTicks(3388), "طارق معروف", "Mara Jast", "أمجد - أمجد", "8006751995964850736", "Angola", 3 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Job", "NationalId", "Nationality", "SocialState" },
                values: new object[] { new DateTime(1978, 3, 31, 0, 46, 57, 554, DateTimeKind.Local).AddTicks(8075), new DateTime(2024, 1, 20, 3, 21, 4, 759, DateTimeKind.Local).AddTicks(2087), "صلاح عاشور", "Matt Reichert", "معروف - سعيد", "9125199869910789111", "Kuwait", 1 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BirthDate", "CreatedAt", "FullNameArabic", "FullNameEnglish", "Gender", "Job", "NationalId", "Nationality" },
                values: new object[] { new DateTime(1998, 2, 23, 6, 45, 1, 778, DateTimeKind.Local).AddTicks(5093), new DateTime(2024, 1, 20, 4, 31, 51, 177, DateTimeKind.Local).AddTicks(7040), "منى زيد", "Jarred Walsh", 1, "ربيع, آدم and فاروق", "867191944477925715", "Uzbekistan" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalFiles_PatientId",
                table: "MedicalFiles",
                column: "PatientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalFiles_Patients_PatientId",
                table: "MedicalFiles",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
