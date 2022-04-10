using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesslayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Blogs_BlogID1",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogID1",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogID1",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID1",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogID1",
                table: "Blogs",
                column: "BlogID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Blogs_BlogID1",
                table: "Blogs",
                column: "BlogID1",
                principalTable: "Blogs",
                principalColumn: "BlogID");
        }
    }
}
