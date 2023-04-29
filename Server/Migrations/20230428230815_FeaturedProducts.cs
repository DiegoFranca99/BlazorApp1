﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class FeaturedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Featured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Featured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Featured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 2, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Featured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Featured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Featured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Featured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Featured",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Featured",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Featured",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.", "data:image/jpeg;base64,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", "Titulo do Livro 4" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[] { 5, 2, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" });
        }
    }
}
