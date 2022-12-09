using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chance.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Shelters_ShelterId",
                table: "Animal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal",
                table: "Animal");

            migrationBuilder.RenameTable(
                name: "Animal",
                newName: "Animals");

            migrationBuilder.RenameIndex(
                name: "IX_Animal_ShelterId",
                table: "Animals",
                newName: "IX_Animals_ShelterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animals",
                table: "Animals",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Shelters_ShelterId",
                table: "Animals",
                column: "ShelterId",
                principalTable: "Shelters",
                principalColumn: "ShelterId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Shelters_ShelterId",
                table: "Animals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animals",
                table: "Animals");

            migrationBuilder.RenameTable(
                name: "Animals",
                newName: "Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_ShelterId",
                table: "Animal",
                newName: "IX_Animal_ShelterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal",
                table: "Animal",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Shelters_ShelterId",
                table: "Animal",
                column: "ShelterId",
                principalTable: "Shelters",
                principalColumn: "ShelterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
