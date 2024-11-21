using Microsoft.EntityFrameworkCore.Migrations;

namespace MainProject.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ListPrice = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Price50 = table.Column<int>(nullable: false),
                    Price100 = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CoverId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_product_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_cover_CoverId",
                        column: x => x.CoverId,
                        principalTable: "cover",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_product_CoverId",
                table: "product",
                column: "CoverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
