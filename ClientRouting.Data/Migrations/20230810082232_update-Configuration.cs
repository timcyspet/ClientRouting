using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientRouting.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationTypes_ConfigurationTypeId",
                schema: "Client",
                table: "ResourceConfigurations");

            migrationBuilder.DropTable(
                name: "ConfigurationTypes",
                schema: "Client");

            migrationBuilder.RenameColumn(
                name: "ConfigurationTypeId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "ConfigurationPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ResourceConfigurations_ConfigurationTypeId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "IX_ResourceConfigurations_ConfigurationPropertyId");

            migrationBuilder.CreateTable(
                name: "ConfigurationProperties",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceTemplateId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigurationProperties_ResourceTemplates_ResourceTemplateId",
                        column: x => x.ResourceTemplateId,
                        principalSchema: "Client",
                        principalTable: "ResourceTemplates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationProperties_ResourceTemplateId",
                schema: "Client",
                table: "ConfigurationProperties",
                column: "ResourceTemplateId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationProperties_ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations");

            migrationBuilder.DropTable(
                name: "ConfigurationProperties",
                schema: "Client");

            migrationBuilder.RenameColumn(
                name: "ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "ConfigurationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResourceConfigurations_ConfigurationPropertyId",
                schema: "Client",
                table: "ResourceConfigurations",
                newName: "IX_ResourceConfigurations_ConfigurationTypeId");

            migrationBuilder.CreateTable(
                name: "ConfigurationTypes",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceTemplateId = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigurationTypes_ResourceTemplates_ResourceTemplateId",
                        column: x => x.ResourceTemplateId,
                        principalSchema: "Client",
                        principalTable: "ResourceTemplates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationTypes_ResourceTemplateId",
                schema: "Client",
                table: "ConfigurationTypes",
                column: "ResourceTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceConfigurations_ConfigurationTypes_ConfigurationTypeId",
                schema: "Client",
                table: "ResourceConfigurations",
                column: "ConfigurationTypeId",
                principalSchema: "Client",
                principalTable: "ConfigurationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
