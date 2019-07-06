using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AverageFreeTime", "FirstName", "LastName" },
                values: new object[] { 1, 99, 9.0, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AverageFreeTime", "FirstName", "LastName" },
                values: new object[] { 2, 99, 9.0, "Jane", "Doe" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Descripton", "Importance", "Status", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "Chest day", 2, 0, "Gym", 2, 1 },
                    { 3, "Doing Homework", 1, 1, "SEDC Homework", 1, 1 },
                    { 4, "Leg day", 1, 2, "Gym", 2, 1 },
                    { 7, "Day for resting", 3, 0, "Resting", 1, 1 },
                    { 8, "Working out", 2, 0, "Crossfit", 2, 1 },
                    { 2, "Kopanje", 2, 2, "Lozje Day", 1, 2 },
                    { 5, "Programing", 1, 2, "C#", 1, 2 },
                    { 6, "C# Homework", 1, 1, "SEDC Homework", 1, 2 },
                    { 9, "Going on class", 1, 1, "SEDC", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "Id", "Description", "Status", "TaskId", "Title" },
                values: new object[,]
                {
                    { 1, "1h Nap", false, 1, "Nap" },
                    { 2, "Watching Basketball", true, 3, "TV" },
                    { 4, "Playing DOTA", false, 4, "PC" },
                    { 3, "Playing Fortnite", false, 2, "PC" },
                    { 5, "Listening Music", false, 5, "Youtiube" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubTasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
