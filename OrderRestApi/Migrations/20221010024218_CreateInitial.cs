using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderRestApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BakeryOrders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    ordered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pieces = table.Column<int>(type: "int", nullable: false),
                    Type_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ordertime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakeryOrders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BakeryOrders");
        }
    }
}
