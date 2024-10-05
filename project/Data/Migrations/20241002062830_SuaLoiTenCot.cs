using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Data.Migrations
{
    /// <inheritdoc />
    public partial class SuaLoiTenCot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaiId",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TheLoaiId",
                table: "SanPham",
                newName: "TheLoaild");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_TheLoaiId",
                table: "SanPham",
                newName: "IX_SanPham_TheLoaild");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaild",
                table: "SanPham",
                column: "TheLoaild",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaild",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TheLoaild",
                table: "SanPham",
                newName: "TheLoaiId");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_TheLoaild",
                table: "SanPham",
                newName: "IX_SanPham_TheLoaiId");

            migrationBuilder.AlterColumn<double>(
                name: "ImageUrl",
                table: "SanPham",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaiId",
                table: "SanPham",
                column: "TheLoaiId",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
