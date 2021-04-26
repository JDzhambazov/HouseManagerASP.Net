using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class DueAmountTablesAndRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyТaxes_Addresses_AddressId",
                table: "МonthlyТaxes");

            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyТaxes_FeeTypes_NameId",
                table: "МonthlyТaxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_МonthlyТaxes",
                table: "МonthlyТaxes");

            migrationBuilder.DropColumn(
                name: "Lift",
                table: "Properties");

            migrationBuilder.RenameTable(
                name: "МonthlyТaxes",
                newName: "МonthlyFees");

            migrationBuilder.RenameColumn(
                name: "NameId",
                table: "МonthlyFees",
                newName: "FeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_МonthlyТaxes_NameId",
                table: "МonthlyFees",
                newName: "IX_МonthlyFees_FeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_МonthlyТaxes_AddressId",
                table: "МonthlyFees",
                newName: "IX_МonthlyFees_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "МonthlyFees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_МonthlyFees",
                table: "МonthlyFees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "NotRegularDueAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotRegularDueAmounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotRegularDueAmounts_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegularDueAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularDueAmounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegularDueAmounts_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_МonthlyFees_PropertyId",
                table: "МonthlyFees",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_NotRegularDueAmounts_PropertyId",
                table: "NotRegularDueAmounts",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularDueAmounts_PropertyId",
                table: "RegularDueAmounts",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_FeeTypes_FeeTypeId",
                table: "МonthlyFees",
                column: "FeeTypeId",
                principalTable: "FeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_Properties_PropertyId",
                table: "МonthlyFees",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees");

            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_FeeTypes_FeeTypeId",
                table: "МonthlyFees");

            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_Properties_PropertyId",
                table: "МonthlyFees");

            migrationBuilder.DropTable(
                name: "NotRegularDueAmounts");

            migrationBuilder.DropTable(
                name: "RegularDueAmounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_МonthlyFees",
                table: "МonthlyFees");

            migrationBuilder.DropIndex(
                name: "IX_МonthlyFees_PropertyId",
                table: "МonthlyFees");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "МonthlyFees");

            migrationBuilder.RenameTable(
                name: "МonthlyFees",
                newName: "МonthlyТaxes");

            migrationBuilder.RenameColumn(
                name: "FeeTypeId",
                table: "МonthlyТaxes",
                newName: "NameId");

            migrationBuilder.RenameIndex(
                name: "IX_МonthlyFees_FeeTypeId",
                table: "МonthlyТaxes",
                newName: "IX_МonthlyТaxes_NameId");

            migrationBuilder.RenameIndex(
                name: "IX_МonthlyFees_AddressId",
                table: "МonthlyТaxes",
                newName: "IX_МonthlyТaxes_AddressId");

            migrationBuilder.AddColumn<bool>(
                name: "Lift",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_МonthlyТaxes",
                table: "МonthlyТaxes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyТaxes_Addresses_AddressId",
                table: "МonthlyТaxes",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyТaxes_FeeTypes_NameId",
                table: "МonthlyТaxes",
                column: "NameId",
                principalTable: "FeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
