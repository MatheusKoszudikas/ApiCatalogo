using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    public partial class PopulaCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO categorias (Nome, ImagemUrl) VALUES ('Bebidas', 'bebidas.jpg')");
            mb.Sql("INSERT INTO categorias (Nome, ImagemUrl) VALUES ('Lanches', 'lanches.jpg')");
            mb.Sql("INSERT INTO categorias (Nome, ImagemUrl) VALUES ('Sobremesas', 'sobremesas.jpg')");
            
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM categoria");
        }
    }
}
