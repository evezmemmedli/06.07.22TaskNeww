using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlCreatTable.Migrations
{
    public partial class changedBlogFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "BlockQuote",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockQuote",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Blogs",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
