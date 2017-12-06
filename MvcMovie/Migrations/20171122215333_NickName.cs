using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
	public partial class NickName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "AspNetUsers");
			
        }
    }
}
