using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ExpenseTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Expens");

            migrationBuilder.AddColumn<int>(
                name: "ExpensTypeId",
                table: "Expens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExpensesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensesTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expens_ExpensTypeId",
                table: "Expens",
                column: "ExpensTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expens_ExpensesTypes_ExpensTypeId",
                table: "Expens",
                column: "ExpensTypeId",
                principalTable: "ExpensesTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expens_ExpensesTypes_ExpensTypeId",
                table: "Expens");

            migrationBuilder.DropTable(
                name: "ExpensesTypes");

            migrationBuilder.DropIndex(
                name: "IX_Expens_ExpensTypeId",
                table: "Expens");

            migrationBuilder.DropColumn(
                name: "ExpensTypeId",
                table: "Expens");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Expens",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
