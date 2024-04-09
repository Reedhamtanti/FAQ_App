using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASSIGNMENT2PART2.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Url);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Url);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryUrl = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicUrl = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQs_Categories_CategoryUrl",
                        column: x => x.CategoryUrl,
                        principalTable: "Categories",
                        principalColumn: "Url");
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicUrl",
                        column: x => x.TopicUrl,
                        principalTable: "Topics",
                        principalColumn: "Url",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Url", "Name" },
                values: new object[,]
                {
                    { "general", "General" },
                    { "hist", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Url", "Name" },
                values: new object[,]
                {
                    { "bootstrap", "Bootstrap" },
                    { "csharp", "C#" },
                    { "js", "Javascript" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "CategoryUrl", "Question", "TopicUrl" },
                values: new object[,]
                {
                    { 1, "A CSS framework for creating responsive web apps for multiple screen sizes.", "general", "What is Bootstrap?", "bootstrap" },
                    { 2, "In 2011.", "hist", "When was Bootstrap first released?", "bootstrap" },
                    { 3, "Yes, Bootstrap is designed to be mobile-first, meaning that it prioritizes the mobile viewing experience and adapts to different screen sizes and devices.", "general", "Is Bootstrap mobile-friendly?", "bootstrap" },
                    { 4, "Yes, Bootstrap includes a set of JavaScript plugins that enhance the functionality of its components. ", "general", "Does Bootstrap support JavaScript functionality?", "bootstrap" },
                    { 5, " Bootstrap was created by Mark Otto and Jacob Thornton, both of whom were engineers at Twitter at the time.", "hist", "Who created Bootstrap?", "bootstrap" },
                    { 6, "A general purpose scripting language that executes in a web browser.", "general", "What is Javascript?", "js" },
                    { 7, "In 1995.", "hist", "When was Javascript first released?", "js" },
                    { 8, "The creation of JavaScript was driven by the need for a lightweight scripting language that could be executed on the client-side within web browsers.", "hist", "What was the motivation behind creating JavaScript?", "js" },
                    { 9, "No, JavaScript is not the same as Java. Despite the similar names, they are two distinct programming languages with different syntax, semantics, and purposes.", "general", "Is JavaScript the same as Java?", "js" },
                    { 10, "A general purpose object oriented language that executes in a web browser.", "general", "What is C#?", "csharp" },
                    { 11, "In 2002.", "hist", "When was C# first released?", "csharp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryUrl",
                table: "FAQs",
                column: "CategoryUrl");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicUrl",
                table: "FAQs",
                column: "TopicUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
