using Microsoft.EntityFrameworkCore.Migrations;

namespace SimelERP.Persistence.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "TestERPs",
                newName: "TestERPId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestERPId",
                table: "TestERPs",
                newName: "TestId");
        }
    }
}
