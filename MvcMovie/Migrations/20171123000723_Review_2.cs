using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MvcMovie.Migrations
{
    public partial class Review_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropPrimaryKey(
			   name: "PK_Review",
			   table: "Review");

			migrationBuilder.DropColumn(
				name: "ID",
				table: "Review");

			migrationBuilder.AddColumn<int>(
				name: "ReviewID",
				table: "Review",
				type: "int",
				nullable: false,
				defaultValue: 0)
				.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

			migrationBuilder.AddPrimaryKey(
				name: "PK_Review",
				table: "Review",
				column: "ReviewID");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropPrimaryKey(
				name: "PK_Review",
				table: "Review");

			migrationBuilder.DropColumn(
				name: "ReviewID",
				table: "Review");

			migrationBuilder.AddColumn<int>(
				name: "ID",
				table: "Review",
				nullable: false,
				defaultValue: 0)
				.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

			migrationBuilder.AddPrimaryKey(
				name: "PK_Review",
				table: "Review",
				column: "ID");
		}
	}
}


      
