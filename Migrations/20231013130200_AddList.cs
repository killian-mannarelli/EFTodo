using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTodo.Migrations
{
    /// <inheritdoc />
    public partial class AddList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TodoListId",
                table: "Todo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TodoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoLists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todo_TodoListId",
                table: "Todo",
                column: "TodoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_TodoLists_TodoListId",
                table: "Todo",
                column: "TodoListId",
                principalTable: "TodoLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_TodoLists_TodoListId",
                table: "Todo");

            migrationBuilder.DropTable(
                name: "TodoLists");

            migrationBuilder.DropIndex(
                name: "IX_Todo_TodoListId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "TodoListId",
                table: "Todo");
        }
    }
}
