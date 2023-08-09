using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientRouting.Data.Migrations
{
    /// <inheritdoc />
    public partial class clientservices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Client",
                table: "ResourceConfigurations");

            migrationBuilder.AddColumn<long>(
                name: "ServiceId",
                schema: "Client",
                table: "ResourceTypes",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientEngagements",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientEngagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                schema: "Client",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEngagementId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_ClientEngagements_ClientEngagementId",
                        column: x => x.ClientEngagementId,
                        principalSchema: "Client",
                        principalTable: "ClientEngagements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypes_ServiceId",
                schema: "Client",
                table: "ResourceTypes",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ClientEngagementId",
                schema: "Client",
                table: "Services",
                column: "ClientEngagementId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypes_Services_ServiceId",
                schema: "Client",
                table: "ResourceTypes",
                column: "ServiceId",
                principalSchema: "Client",
                principalTable: "Services",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypes_Services_ServiceId",
                schema: "Client",
                table: "ResourceTypes");

            migrationBuilder.DropTable(
                name: "Services",
                schema: "Client");

            migrationBuilder.DropTable(
                name: "ClientEngagements",
                schema: "Client");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypes_ServiceId",
                schema: "Client",
                table: "ResourceTypes");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                schema: "Client",
                table: "ResourceTypes");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                schema: "Client",
                table: "ResourceConfigurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
