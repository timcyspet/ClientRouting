using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientRouting.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateclientProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationProperties_ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations");

            migrationBuilder.RenameColumn(
                name: "ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "KeyId");

            migrationBuilder.RenameIndex(
                name: "IX_ResourceConfigurations_ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "IX_ResourceConfigurations_KeyId");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                schema: "Client",
                table: "ConfigurationProperties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "AddressId",
                schema: "Client",
                table: "Clients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                schema: "Client",
                table: "Clients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ClientTypes",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTemmpaltes",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTemmpaltes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientTemmpaltes_ClientTypes_ClientTypeId",
                        column: x => x.ClientTypeId,
                        principalSchema: "Client",
                        principalTable: "ClientTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jurisdictions",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jurisdictions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jurisdictions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Client",
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientCustomProperties",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientTemmpalteId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCustomProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientCustomProperties_ClientTemmpaltes_ClientTemmpalteId",
                        column: x => x.ClientTemmpalteId,
                        principalSchema: "Client",
                        principalTable: "ClientTemmpaltes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JurisdictionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Jurisdictions_JurisdictionId",
                        column: x => x.JurisdictionId,
                        principalSchema: "Client",
                        principalTable: "Jurisdictions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientProperties",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientProperties_ClientCustomProperties_KeyId",
                        column: x => x.KeyId,
                        principalSchema: "Client",
                        principalTable: "ClientCustomProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientProperties_Clients_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "Client",
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressId",
                schema: "Client",
                table: "Clients",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_TypeId",
                schema: "Client",
                table: "Clients",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_JurisdictionId",
                schema: "Client",
                table: "Addresses",
                column: "JurisdictionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCustomProperties_ClientTemmpalteId",
                schema: "Client",
                table: "ClientCustomProperties",
                column: "ClientTemmpalteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProperties_ClientId",
                schema: "Client",
                table: "ClientProperties",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProperties_KeyId",
                schema: "Client",
                table: "ClientProperties",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTemmpaltes_ClientTypeId",
                schema: "Client",
                table: "ClientTemmpaltes",
                column: "ClientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jurisdictions_CountryId",
                schema: "Client",
                table: "Jurisdictions",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                schema: "Client",
                table: "Clients",
                column: "AddressId",
                principalSchema: "Client",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_ClientTypes_TypeId",
                schema: "Client",
                table: "Clients",
                column: "TypeId",
                principalSchema: "Client",
                principalTable: "ClientTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationProperties_KeyId",
                schema: "Client",
                table: "ResourceConfigurations",
                column: "KeyId",
                principalSchema: "Client",
                principalTable: "ConfigurationProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_AddressId",
                schema: "Client",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_ClientTypes_TypeId",
                schema: "Client",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationProperties_KeyId",
                schema: "Client",
                table: "ResourceConfigurations");

            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "ClientProperties",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "Jurisdictions",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "ClientCustomProperties",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "ClientTemmpaltes",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "ClientTypes",
                schema: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AddressId",
                schema: "Client",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_TypeId",
                schema: "Client",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                schema: "Client",
                table: "ConfigurationProperties");

            migrationBuilder.DropColumn(
                name: "AddressId",
                schema: "Client",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TypeId",
                schema: "Client",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "KeyId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "ConfigurationPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ResourceConfigurations_KeyId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "IX_ResourceConfigurations_ConfigurationPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationProperties_ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations",
                column: "ConfigurationPropertyId",
                principalSchema: "Client",
                principalTable: "ConfigurationProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
