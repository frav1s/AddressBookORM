using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBookLibrary.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Notes",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _date = table.Column<string>(nullable: true),
                    _note = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Notes", x => x.Id); });

            migrationBuilder.CreateTable(
                "Persons",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    OfficePhone = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Persons", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Notes");

            migrationBuilder.DropTable(
                "Persons");
        }
    }
}