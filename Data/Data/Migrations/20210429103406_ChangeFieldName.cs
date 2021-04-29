using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ChangeFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees");

            migrationBuilder.DropForeignKey(
                name: "FK_МonthlyFees_FeeTypes_FeeTypeId",
                table: "МonthlyFees");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthFeeProperty_МonthlyFees_MonthFeesId",
                table: "MonthFeeProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_МonthlyFees",
                table: "МonthlyFees");

            migrationBuilder.RenameTable(
                name: "МonthlyFees",
                newName: "MonthlyFees");

            migrationBuilder.RenameIndex(
                name: "IX_МonthlyFees_FeeTypeId",
                table: "MonthlyFees",
                newName: "IX_MonthlyFees_FeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_МonthlyFees_AddressId",
                table: "MonthlyFees",
                newName: "IX_MonthlyFees_AddressId");

            migrationBuilder.AddColumn<int>(
                name: "MonthFeeId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyFees",
                table: "MonthlyFees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_MonthFeeId",
                table: "Addresses",
                column: "MonthFeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_MonthlyFees_MonthFeeId",
                table: "Addresses",
                column: "MonthFeeId",
                principalTable: "MonthlyFees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthFeeProperty_MonthlyFees_MonthFeesId",
                table: "MonthFeeProperty",
                column: "MonthFeesId",
                principalTable: "MonthlyFees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyFees_Addresses_AddressId",
                table: "MonthlyFees",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyFees_FeeTypes_FeeTypeId",
                table: "MonthlyFees",
                column: "FeeTypeId",
                principalTable: "FeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_MonthlyFees_MonthFeeId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthFeeProperty_MonthlyFees_MonthFeesId",
                table: "MonthFeeProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyFees_Addresses_AddressId",
                table: "MonthlyFees");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyFees_FeeTypes_FeeTypeId",
                table: "MonthlyFees");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_MonthFeeId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyFees",
                table: "MonthlyFees");

            migrationBuilder.DropColumn(
                name: "MonthFeeId",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "MonthlyFees",
                newName: "МonthlyFees");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyFees_FeeTypeId",
                table: "МonthlyFees",
                newName: "IX_МonthlyFees_FeeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyFees_AddressId",
                table: "МonthlyFees",
                newName: "IX_МonthlyFees_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_МonthlyFees",
                table: "МonthlyFees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_Addresses_AddressId",
                table: "МonthlyFees",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_МonthlyFees_FeeTypes_FeeTypeId",
                table: "МonthlyFees",
                column: "FeeTypeId",
                principalTable: "FeeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthFeeProperty_МonthlyFees_MonthFeesId",
                table: "MonthFeeProperty",
                column: "MonthFeesId",
                principalTable: "МonthlyFees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
