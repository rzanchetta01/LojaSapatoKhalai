using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaSapatoKhalai.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModelo = table.Column<int>(type: "int", nullable: false),
                    Qnt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFornecedor = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    CodigoRef = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idModelo = table.Column<int>(type: "int", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    DtVenda = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Sapato de luxo" },
                    { 2, "Chuteiras" },
                    { 3, "Sapatos casuais" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "CPF", "Endereco", "Nome", "Sexo" },
                values: new object[,]
                {
                    { 1, "1354532", "Mansão maromba", "Rodrigo", "m" },
                    { 2, "765432123", "Casa do bom filho", "Marcos", "m" },
                    { 3, "1354532", "Rua Perdida das cruzes", "Ana", "f" }
                });

            migrationBuilder.InsertData(
                table: "Estoques",
                columns: new[] { "Id", "IdModelo", "Qnt" },
                values: new object[,]
                {
                    { 2, 2, 10 },
                    { 3, 3, 110 },
                    { 1, 1, 1000 }
                });

            migrationBuilder.InsertData(
                table: "Fornecedores",
                columns: new[] { "Id", "CNPJ", "Endereco", "Nome" },
                values: new object[,]
                {
                    { 1, "1953049285142", "China, shin shon shun", "China in Shoes" },
                    { 2, "1276629478241", "Africa do Sul, Cidade do Cabo", "Africa has Shoes" },
                    { 3, "9994724861245", "India, Nova Dehli", "India doens't do Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Modelos",
                columns: new[] { "Id", "CodigoRef", "Cor", "IdCategoria", "IdFornecedor", "Nome", "Preco", "Tamanho" },
                values: new object[,]
                {
                    { 1, "asnaeb", "Branco", 1, 1, "Supreme Ben 10 mil", 1500.0, 36 },
                    { 2, "asnaeba", "Preto", 2, 2, "Chute certo", 350.0, 42 },
                    { 3, "asnaebbbe", "Cinza", 3, 3, "Skatenis", 150.0, 39 }
                });

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "DtVenda", "Quantidade", "idCliente", "idModelo" },
                values: new object[,]
                {
                    { 2, "19/10/2021", 1, 2, 2 },
                    { 1, "22/06/2021", 10, 1, 1 },
                    { 3, "03/11/2021", 1, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
