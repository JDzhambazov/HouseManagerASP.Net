namespace Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class CreateMonthFeeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees");

            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_Properties_PropertyId",
                table: "МonthlyFees");

            migrationBuilder.DropIndex(
                name: "IX_МonthlyFees_PropertyId",
                table: "МonthlyFees");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "МonthlyFees");

            migrationBuilder.CreateTable(
                name: "MonthFeeProperty",
                columns: table => new
                {
                    MonthFeesId = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthFeeProperty", x => new { x.MonthFeesId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_MonthFeeProperty_МonthlyFees_MonthFeesId",
                        column: x => x.MonthFeesId,
                        principalTable: "МonthlyFees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonthFeeProperty_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthFeeProperty_PropertiesId",
                table: "MonthFeeProperty",
                column: "PropertiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees");

            migrationBuilder.DropTable(
                name: "MonthFeeProperty");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "МonthlyFees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_МonthlyFees_PropertyId",
                table: "МonthlyFees",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees",
                column: "AddressId",
                principalTable: "Addresses",
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
    }
}
