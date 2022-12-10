using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tryitter.Migrations
{
    public partial class PopulaContas : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Contas(Nome, Email, Modulo, Status, Senha) Values('Carol', 'carol@email.com', 'AceleracaoC#', 'Tá acabando!!!', '1234')");
            mb.Sql("Insert into Contas(Nome, Email, Modulo, Status, Senha) Values('Elimar', 'elimar@email.com', 'AceleracaoC#', 'Tô na XP!!!', '5678')");
            mb.Sql("Insert into Contas(Nome, Email, Modulo, Status, Senha) Values('Marina', 'marina@email.com', 'Trybe', 'Calma gente!!!', '9101112')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Contas");
        }
    }
}
