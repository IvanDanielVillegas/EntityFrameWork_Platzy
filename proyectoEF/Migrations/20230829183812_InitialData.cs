using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace proyectoEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("0600c553-1196-404e-baa5-fc2ddc0fba50"), null, "Actividades pendientes", 20 },
                    { new Guid("0600c553-1196-404e-baa5-fc2ddc0fba51"), null, "Actividades personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0600c553-1196-404e-baa5-fc2ddc0fba60"), new Guid("0600c553-1196-404e-baa5-fc2ddc0fba50"), null, new DateTime(2023, 8, 29, 13, 38, 12, 184, DateTimeKind.Local).AddTicks(6832), 1, "Pago de servicios publicos" },
                    { new Guid("0600c553-1196-404e-baa5-fc2ddc0fba61"), new Guid("0600c553-1196-404e-baa5-fc2ddc0fba51"), null, new DateTime(2023, 8, 29, 13, 38, 12, 184, DateTimeKind.Local).AddTicks(6847), 0, "Terminar de ver pelicula en netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("0600c553-1196-404e-baa5-fc2ddc0fba60"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("0600c553-1196-404e-baa5-fc2ddc0fba61"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("0600c553-1196-404e-baa5-fc2ddc0fba50"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("0600c553-1196-404e-baa5-fc2ddc0fba51"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
