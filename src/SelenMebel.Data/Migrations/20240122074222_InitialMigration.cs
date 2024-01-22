using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SelenMebel.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FurnitureFeatures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Furnitures",
                columns: table => new
                {
                    UniqueId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    FurnitureFeatureId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnitures", x => x.UniqueId);
                    table.ForeignKey(
                        name: "FK_Furnitures_FurnitureFeatures_FurnitureFeatureId",
                        column: x => x.FurnitureFeatureId,
                        principalTable: "FurnitureFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfFurnitures",
                columns: table => new
                {
                    FurnitureId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfFurnitures", x => x.FurnitureId);
                    table.ForeignKey(
                        name: "FK_TypeOfFurnitures_Furnitures_FurnitureId",
                        column: x => x.FurnitureId,
                        principalTable: "Furnitures",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    TypeOfFurnitureId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.TypeOfFurnitureId);
                    table.ForeignKey(
                        name: "FK_Categories_TypeOfFurnitures_TypeOfFurnitureId",
                        column: x => x.TypeOfFurnitureId,
                        principalTable: "TypeOfFurnitures",
                        principalColumn: "FurnitureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FurnitureCategories",
                columns: table => new
                {
                    FurnitureId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryTypeOfFurnitureId = table.Column<long>(type: "bigint", nullable: true),
                    FurnitureCategoryCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    FurnitureCategoryFurnitureId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureCategories", x => new { x.FurnitureId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FurnitureCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "TypeOfFurnitureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FurnitureCategories_Categories_CategoryTypeOfFurnitureId",
                        column: x => x.CategoryTypeOfFurnitureId,
                        principalTable: "Categories",
                        principalColumn: "TypeOfFurnitureId");
                    table.ForeignKey(
                        name: "FK_FurnitureCategories_FurnitureCategories_FurnitureCategoryFu~",
                        columns: x => new { x.FurnitureCategoryFurnitureId, x.FurnitureCategoryCategoryId },
                        principalTable: "FurnitureCategories",
                        principalColumns: new[] { "FurnitureId", "CategoryId" });
                    table.ForeignKey(
                        name: "FK_FurnitureCategories_Furnitures_FurnitureId",
                        column: x => x.FurnitureId,
                        principalTable: "Furnitures",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureCategories_CategoryId",
                table: "FurnitureCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureCategories_CategoryTypeOfFurnitureId",
                table: "FurnitureCategories",
                column: "CategoryTypeOfFurnitureId");

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureCategories_FurnitureCategoryFurnitureId_FurnitureC~",
                table: "FurnitureCategories",
                columns: new[] { "FurnitureCategoryFurnitureId", "FurnitureCategoryCategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_FurnitureFeatureId",
                table: "Furnitures",
                column: "FurnitureFeatureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FurnitureCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TypeOfFurnitures");

            migrationBuilder.DropTable(
                name: "Furnitures");

            migrationBuilder.DropTable(
                name: "FurnitureFeatures");
        }
    }
}
