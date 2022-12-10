using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tryitter.Migrations
{
    public partial class PopulaPostagens : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Postagens(Texto, DataPostagem, ContaId) Values('Estou no Banco Xp, em Pix Produtos.', now(), 1)");
            mb.Sql("Insert into Postagens(Texto, DataPostagem, ContaId) Values('Estou em Aliança Ams Engs.', now(), 2)");
            mb.Sql("Insert into Postagens(Texto, DataPostagem, ContaId) Values('Estou na Trybe.', now(), 3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Postagens");
        }
    }
}
