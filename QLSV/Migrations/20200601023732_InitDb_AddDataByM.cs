using Microsoft.EntityFrameworkCore.Migrations;

namespace QLSV.Migrations
{
    public partial class InitDb_AddDataByM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ID", "ClassName", "School_ID" },
                values: new object[,]
                {
                    { 1, "Lớp học 01", 1 },
                    { 2, "Lớp học 02", 2 },
                    { 3, "Lớp học 03", 3 },
                    { 4, "Lớp học 04", 1 },
                    { 5, "Lớp học 05", 2 },
                    { 6, "Lớp học 06", 3 }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "ID", "ShoolName" },
                values: new object[,]
                {
                    { 1, "Trường đại học 01" },
                    { 2, "Trường đại học 02" },
                    { 3, "Trường đại học 03" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Class_ID", "StudentName" },
                values: new object[,]
                {
                    { 1, 1, "Học sinh 01" },
                    { 2, 2, "Học sinh 02" },
                    { 3, 3, "Học sinh 03" },
                    { 4, 1, "Học sinh 04" },
                    { 5, 2, "Học sinh 05" },
                    { 6, 3, "Học sinh 06" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}