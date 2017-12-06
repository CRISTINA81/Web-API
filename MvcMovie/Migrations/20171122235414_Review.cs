using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MvcMovie.Migrations
{
	public partial class Review : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
			   name: "Title",
			   table: "Movie",
			   type: "nvarchar(60)",
			   maxLength: 60,
			   nullable: false,
			   oldClrType: typeof(string),
			   oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Rating",
				table: "Movie",
				type: "nvarchar(5)",
				maxLength: 5,
				nullable: false,
				oldClrType: typeof(string),
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "Genre",
				table: "Movie",
				type: "nvarchar(30)",
				maxLength: 30,
				nullable: false,
				oldClrType: typeof(string),
				oldNullable: true);

			migrationBuilder.CreateTable(
				name: "Review",
				columns: table => new
				{
					ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
					MovieID = table.Column<int>(type: "int", nullable: false),
					ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Review", x => x.ID);
				});
		}



		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				   name: "Review");

			migrationBuilder.AlterColumn<string>(
				name: "Title",
				table: "Movie",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(60)",
				oldMaxLength: 60);

			migrationBuilder.AlterColumn<string>(
				name: "Rating",
				table: "Movie",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(5)",
				oldMaxLength: 5);

			migrationBuilder.AlterColumn<string>(
				name: "Genre",
				table: "Movie",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(30)",
				oldMaxLength: 30);
		}
	}
}

