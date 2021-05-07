namespace Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class FeeIncomesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Expens",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Entrance",
                table: "Addresses",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymasterId",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FeeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotRegularIncomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResidentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotRegularIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotRegularIncomes_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotRegularIncomes_AspNetUsers_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotRegularIncomes_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegularIncomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResidentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegularIncomes_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegularIncomes_AspNetUsers_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegularIncomes_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "МonthlyТaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    NameId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    IsPersonal = table.Column<bool>(type: "bit", nullable: false),
                    IsRegular = table.Column<bool>(type: "bit", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_МonthlyТaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_МonthlyТaxes_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_МonthlyТaxes_FeeTypes_NameId",
                        column: x => x.NameId,
                        principalTable: "FeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PaymasterId",
                table: "Addresses",
                column: "PaymasterId");

            migrationBuilder.CreateIndex(
                name: "IX_МonthlyТaxes_AddressId",
                table: "МonthlyТaxes",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_МonthlyТaxes_NameId",
                table: "МonthlyТaxes",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_NotRegularIncomes_AddressId",
                table: "NotRegularIncomes",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_NotRegularIncomes_PropertyId",
                table: "NotRegularIncomes",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_NotRegularIncomes_ResidentId",
                table: "NotRegularIncomes",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularIncomes_AddressId",
                table: "RegularIncomes",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularIncomes_PropertyId",
                table: "RegularIncomes",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RegularIncomes_ResidentId",
                table: "RegularIncomes",
                column: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_PaymasterId",
                table: "Addresses",
                column: "PaymasterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_PaymasterId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "МonthlyТaxes");

            migrationBuilder.DropTable(
                name: "NotRegularIncomes");

            migrationBuilder.DropTable(
                name: "RegularIncomes");

            migrationBuilder.DropTable(
                name: "FeeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PaymasterId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PaymasterId",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Expens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Entrance",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    ResidentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Income_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Income_AspNetUsers_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Income_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Income_AddressId",
                table: "Income",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Income_PropertyId",
                table: "Income",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Income_ResidentId",
                table: "Income",
                column: "ResidentId");
        }
    }
}
