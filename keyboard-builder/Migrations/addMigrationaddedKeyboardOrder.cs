using Microsoft.EntityFrameworkCore.Migrations;

namespace keyboard_builder.Migrations
{
    public partial class addedKeyboardOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyboardOrders",
                columns: table => new

                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1")

                    KeyboardName = table.Column<string>(type: "nvarchar(max)", nullable: false)

                    BasePrice = table.Column<float>(type: "real", nullable: false)
                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyboardOrders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyboardOrders");
        }
    }
}