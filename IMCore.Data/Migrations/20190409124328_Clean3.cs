using Microsoft.EntityFrameworkCore.Migrations;

namespace IMCore.Data.Migrations
{
    public partial class Clean3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpokeWith",
                table: "SpokeWith",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractors_MarketId",
                table: "SubContractors",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_PONotes_SpokeWithId",
                table: "PONotes",
                column: "SpokeWithId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PONotes_SpokeWith_SpokeWithId",
            //    table: "PONotes",
            //    column: "SpokeWithId",
            //    principalTable: "SpokeWith",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractors_Market_MarketId",
                table: "SubContractors",
                column: "MarketId",
                principalTable: "Market",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PONotes_SpokeWith_SpokeWithId",
            //    table: "PONotes");

            migrationBuilder.DropForeignKey(
                name: "FK_SubContractors_Market_MarketId",
                table: "SubContractors");

            migrationBuilder.DropIndex(
                name: "IX_SubContractors_MarketId",
                table: "SubContractors");

            migrationBuilder.DropIndex(
                name: "IX_PONotes_SpokeWithId",
                table: "PONotes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SpokeWith",
                newName: "SpokeWith");
        }
    }
}
