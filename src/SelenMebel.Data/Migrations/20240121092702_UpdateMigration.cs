using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SelenMebel.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_TypeOfFurnitures_TypeOfFurnitureId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_FurnitureFeatures_FurnitureFeatures_FurnitureFeatureId",
                table: "FurnitureFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_FurnitureFeatures_FurnitureFeatureId",
                table: "Furnitures");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfFurnitures_Furnitures_FurnitureId",
                table: "TypeOfFurnitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfFurnitures",
                table: "TypeOfFurnitures");

            migrationBuilder.DropIndex(
                name: "IX_TypeOfFurnitures_FurnitureId",
                table: "TypeOfFurnitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Furnitures",
                table: "Furnitures");

            migrationBuilder.DropIndex(
                name: "IX_FurnitureFeatures_FurnitureFeatureId",
                table: "FurnitureFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_TypeOfFurnitureId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FurnitureFeatureId",
                table: "FurnitureFeatures");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeOfFurnitures",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "TypeOfFurnitures",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "UniqueId",
                table: "Furnitures",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Furnitures",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Furnitures",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Furnitures",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Furnitures",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Categories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfFurnitures",
                table: "TypeOfFurnitures",
                column: "FurnitureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Furnitures",
                table: "Furnitures",
                column: "UniqueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "TypeOfFurnitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_TypeOfFurnitures_TypeOfFurnitureId",
                table: "Categories",
                column: "TypeOfFurnitureId",
                principalTable: "TypeOfFurnitures",
                principalColumn: "FurnitureId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_FurnitureFeatures_FurnitureFeatureId",
                table: "Furnitures",
                column: "FurnitureFeatureId",
                principalTable: "FurnitureFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfFurnitures_Furnitures_FurnitureId",
                table: "TypeOfFurnitures",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "UniqueId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_TypeOfFurnitures_TypeOfFurnitureId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_FurnitureFeatures_FurnitureFeatureId",
                table: "Furnitures");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeOfFurnitures_Furnitures_FurnitureId",
                table: "TypeOfFurnitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfFurnitures",
                table: "TypeOfFurnitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Furnitures",
                table: "Furnitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeOfFurnitures",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "TypeOfFurnitures",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Furnitures",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Furnitures",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Furnitures",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Furnitures",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "UniqueId",
                table: "Furnitures",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "FurnitureFeatureId",
                table: "FurnitureFeatures",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Categories",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfFurnitures",
                table: "TypeOfFurnitures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Furnitures",
                table: "Furnitures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfFurnitures_FurnitureId",
                table: "TypeOfFurnitures",
                column: "FurnitureId");

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureFeatures_FurnitureFeatureId",
                table: "FurnitureFeatures",
                column: "FurnitureFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TypeOfFurnitureId",
                table: "Categories",
                column: "TypeOfFurnitureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_TypeOfFurnitures_TypeOfFurnitureId",
                table: "Categories",
                column: "TypeOfFurnitureId",
                principalTable: "TypeOfFurnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FurnitureFeatures_FurnitureFeatures_FurnitureFeatureId",
                table: "FurnitureFeatures",
                column: "FurnitureFeatureId",
                principalTable: "FurnitureFeatures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_FurnitureFeatures_FurnitureFeatureId",
                table: "Furnitures",
                column: "FurnitureFeatureId",
                principalTable: "FurnitureFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeOfFurnitures_Furnitures_FurnitureId",
                table: "TypeOfFurnitures",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
