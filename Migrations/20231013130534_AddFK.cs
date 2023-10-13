using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTodo.Migrations
{
    /// <inheritdoc />
    public partial class AddFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_TodoLists_TodoListId",
                table: "Todo");

            migrationBuilder.AlterColumn<int>(
                name: "TodoListId",
                table: "Todo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_TodoLists_TodoListId",
                table: "Todo",
                column: "TodoListId",
                principalTable: "TodoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_TodoLists_TodoListId",
                table: "Todo");

            migrationBuilder.AlterColumn<int>(
                name: "TodoListId",
                table: "Todo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_TodoLists_TodoListId",
                table: "Todo",
                column: "TodoListId",
                principalTable: "TodoLists",
                principalColumn: "Id");
        }
    }
}
