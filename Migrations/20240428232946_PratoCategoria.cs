using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rm551478.Migrations
{
    /// <inheritdoc />
    public partial class PratoCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Categoria_551478",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Categoria_551478", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "TB_Prato_551478",
                columns: table => new
                {
                    PratoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Prato_551478", x => x.PratoId);
                    table.ForeignKey(
                        name: "FK_TB_Prato_551478_TB_Categoria_551478_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TB_Categoria_551478",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Prato_551478_CategoriaId",
                table: "TB_Prato_551478",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Prato_551478");

            migrationBuilder.DropTable(
                name: "TB_Categoria_551478");
        }
    }
}
