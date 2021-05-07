namespace Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddRangeInCostsProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRegular",
                table: "Expens",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRegular",
                table: "Expens");
        }
    }
}
