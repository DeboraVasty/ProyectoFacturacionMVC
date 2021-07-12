 using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FacturacionMVC.Migrations
{
    public partial class primeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablaCliente",
                columns: table => new
                {
                    codigoCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefonos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaCliente", x => x.codigoCliente);
                });

            migrationBuilder.CreateTable(
                name: "TablaProducto",
                columns: table => new
                {
                    CodigoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaProducto", x => x.CodigoProducto);
                });

            migrationBuilder.CreateTable(
                name: "TablaUsuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaUsuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "TablaFactura",
                columns: table => new
                {
                    NumeroFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalFactura = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Anulada = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    codigoCliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaFactura", x => x.NumeroFactura);
                    table.ForeignKey(
                        name: "FK_TablaFactura_TablaCliente_codigoCliente",
                        column: x => x.codigoCliente,
                        principalTable: "TablaCliente",
                        principalColumn: "codigoCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TablaFacturaProducto",
                columns: table => new
                {
                    NumeroFactura = table.Column<int>(type: "int", nullable: false),
                    CodigoProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaFacturaProducto", x => new { x.NumeroFactura, x.CodigoProducto });
                    table.ForeignKey(
                        name: "FK_TablaFacturaProducto_TablaFactura_NumeroFactura",
                        column: x => x.NumeroFactura,
                        principalTable: "TablaFactura",
                        principalColumn: "NumeroFactura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TablaFacturaProducto_TablaProducto_CodigoProducto",
                        column: x => x.CodigoProducto,
                        principalTable: "TablaProducto",
                        principalColumn: "CodigoProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaFactura_codigoCliente",
                table: "TablaFactura",
                column: "codigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_TablaFacturaProducto_CodigoProducto",
                table: "TablaFacturaProducto",
                column: "CodigoProducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaFacturaProducto");

            migrationBuilder.DropTable(
                name: "TablaUsuarios");

            migrationBuilder.DropTable(
                name: "TablaFactura");

            migrationBuilder.DropTable(
                name: "TablaProducto");

            migrationBuilder.DropTable(
                name: "TablaCliente");
        }
    }
}
