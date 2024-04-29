using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rm551478.Migrations
{
    /// <inheritdoc />
    public partial class v2PedidoItemPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Pedido_551478",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Status = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Pedido_551478", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_TB_Pedido_551478_TB_Cliente_551478_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_Cliente_551478",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ItemPedido_551478",
                columns: table => new
                {
                    ItemPedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PedidoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PratoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Quantidade = table.Column<int>(type: "NUMBER(10)", maxLength: 2, nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ItemPedido_551478", x => x.ItemPedidoId);
                    table.ForeignKey(
                        name: "FK_TB_ItemPedido_551478_TB_Pedido_551478_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "TB_Pedido_551478",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ItemPedido_551478_PedidoId",
                table: "TB_ItemPedido_551478",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Pedido_551478_ClienteId",
                table: "TB_Pedido_551478",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ItemPedido_551478");

            migrationBuilder.DropTable(
                name: "TB_Pedido_551478");
        }
    }
}
