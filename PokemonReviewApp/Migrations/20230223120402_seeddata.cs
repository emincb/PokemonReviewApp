using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategories_Categories_CategoryId",
                table: "PokemonCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategories_Pokemon_PokemonId",
                table: "PokemonCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwners_Owners_OwnerId",
                table: "PokemonOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwners_Pokemon_PokemonId",
                table: "PokemonOwners");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategories_Categories_CategoryId",
                table: "PokemonCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategories_Pokemon_PokemonId",
                table: "PokemonCategories",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwners_Owners_OwnerId",
                table: "PokemonOwners",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwners_Pokemon_PokemonId",
                table: "PokemonOwners",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategories_Categories_CategoryId",
                table: "PokemonCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategories_Pokemon_PokemonId",
                table: "PokemonCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwners_Owners_OwnerId",
                table: "PokemonOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwners_Pokemon_PokemonId",
                table: "PokemonOwners");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategories_Categories_CategoryId",
                table: "PokemonCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategories_Pokemon_PokemonId",
                table: "PokemonCategories",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwners_Owners_OwnerId",
                table: "PokemonOwners",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwners_Pokemon_PokemonId",
                table: "PokemonOwners",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
