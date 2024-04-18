using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APsAutoImport.Migrations
{
    /// <inheritdoc />
    public partial class initAngela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Catergories_CatergoryName",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catergories",
                table: "Catergories");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CatergoryName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CatergoryName",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "CatergoryName",
                table: "Catergories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CatergoryID",
                table: "Catergories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CatergoryID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catergories",
                table: "Catergories",
                column: "CatergoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CatergoryID",
                table: "Cars",
                column: "CatergoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Catergories_CatergoryID",
                table: "Cars",
                column: "CatergoryID",
                principalTable: "Catergories",
                principalColumn: "CatergoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Catergories_CatergoryID",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catergories",
                table: "Catergories");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CatergoryID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CatergoryID",
                table: "Catergories");

            migrationBuilder.DropColumn(
                name: "CatergoryID",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "CatergoryName",
                table: "Catergories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CatergoryName",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catergories",
                table: "Catergories",
                column: "CatergoryName");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CatergoryName",
                table: "Cars",
                column: "CatergoryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Catergories_CatergoryName",
                table: "Cars",
                column: "CatergoryName",
                principalTable: "Catergories",
                principalColumn: "CatergoryName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
