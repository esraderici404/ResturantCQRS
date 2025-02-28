using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cqrs_dal.Migrations
{
    public partial class mihg4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialNamesurname = table.Column<int>(type: "int", nullable: false),
                    TestimonialDescription = table.Column<int>(type: "int", nullable: false),
                    TestimonialProfession = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
