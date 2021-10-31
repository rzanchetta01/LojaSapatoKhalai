using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaSapatoKhalai.Migrations
{
    public partial class AttModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Modelos_Modelo",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Fornecedores_Fornecedor",
                table: "Modelos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_Cliente",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Modelos_Modelo",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_Cliente",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_Modelo",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_Fornecedor",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Estoques_Modelo",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "Fornecedor",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Estoques");

            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idModelo",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFornecedor",
                table: "Modelos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Modelos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdModelo",
                table: "Estoques",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "idModelo",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "IdFornecedor",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "IdModelo",
                table: "Estoques");

            migrationBuilder.AddColumn<int>(
                name: "Cliente",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Modelo",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fornecedor",
                table: "Modelos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Modelo",
                table: "Estoques",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_Cliente",
                table: "Vendas",
                column: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_Modelo",
                table: "Vendas",
                column: "Modelo");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_Fornecedor",
                table: "Modelos",
                column: "Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_Modelo",
                table: "Estoques",
                column: "Modelo");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Modelos_Modelo",
                table: "Estoques",
                column: "Modelo",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Fornecedores_Fornecedor",
                table: "Modelos",
                column: "Fornecedor",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_Cliente",
                table: "Vendas",
                column: "Cliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Modelos_Modelo",
                table: "Vendas",
                column: "Modelo",
                principalTable: "Modelos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
