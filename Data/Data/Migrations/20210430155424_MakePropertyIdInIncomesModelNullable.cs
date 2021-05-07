namespace Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class MakePropertyIdInIncomesModelNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotRegularIncomes_Properties_PropertyId",
                table: "NotRegularIncomes");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularIncomes_Properties_PropertyId",
                table: "RegularIncomes");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "RegularIncomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "NotRegularIncomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_NotRegularIncomes_Properties_PropertyId",
                table: "NotRegularIncomes",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularIncomes_Properties_PropertyId",
                table: "RegularIncomes",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotRegularIncomes_Properties_PropertyId",
                table: "NotRegularIncomes");

            migrationBuilder.DropForeignKey(
                name: "FK_RegularIncomes_Properties_PropertyId",
                table: "RegularIncomes");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "RegularIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "NotRegularIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NotRegularIncomes_Properties_PropertyId",
                table: "NotRegularIncomes",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegularIncomes_Properties_PropertyId",
                table: "RegularIncomes",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
