using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraFlix.EFPersistence.Migrations
{
    public partial class TableVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "varchar(70)", nullable: true),
                    descricao = table.Column<string>(type: "varchar(400)", nullable: true),
                    url = table.Column<string>(type: "varchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "videos");
        }
    }
}
