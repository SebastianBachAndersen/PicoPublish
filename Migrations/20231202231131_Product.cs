using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "dette er en beskrivelse", "test" },
                    { 2, "dette er en beskrivelse", "test" },
                    { 3, "dette er en beskrivelse", "test" },
                    { 4, "dette er en beskrivelse", "test" },
                    { 5, "dette er en beskrivelse", "test" },
                    { 6, "dette er en beskrivelse", "test" },
                    { 7, "dette er en beskrivelse", "test" },
                    { 8, "dette er en beskrivelse", "test" },
                    { 9, "dette er en beskrivelse", "test" },
                    { 10, "dette er en beskrivelse", "test" },
                    { 11, "dette er en beskrivelse", "test" },
                    { 12, "dette er en beskrivelse", "test" },
                    { 13, "dette er en beskrivelse", "test" },
                    { 14, "dette er en beskrivelse", "test" },
                    { 15, "dette er en beskrivelse", "test" },
                    { 16, "dette er en beskrivelse", "test" },
                    { 17, "dette er en beskrivelse", "test" },
                    { 18, "dette er en beskrivelse", "test" },
                    { 19, "dette er en beskrivelse", "test" },
                    { 20, "dette er en beskrivelse", "test" },
                    { 21, "dette er en beskrivelse", "test" },
                    { 22, "dette er en beskrivelse", "test" },
                    { 23, "dette er en beskrivelse", "test" },
                    { 24, "dette er en beskrivelse", "test" },
                    { 25, "dette er en beskrivelse", "test" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
