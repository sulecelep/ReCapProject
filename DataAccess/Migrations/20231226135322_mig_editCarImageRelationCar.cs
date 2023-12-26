using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_editCarImageRelationCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages");

            migrationBuilder.DropIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
