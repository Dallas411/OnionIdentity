using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OnionIdentity.Web.Migrations
{
    public partial class Prova4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppIdentityRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentityRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIdentityUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentityUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIdentityUserLogin",
                columns: table => new
                {
                    ProviderKey = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentityUserLogin", x => new { x.ProviderKey, x.LoginProvider });
                });

            migrationBuilder.CreateTable(
                name: "AppIdentityUserRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIdentityUserRole", x => new { x.RoleId, x.UserId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppIdentityRoleClaims");

            migrationBuilder.DropTable(
                name: "AppIdentityUserClaims");

            migrationBuilder.DropTable(
                name: "AppIdentityUserLogin");

            migrationBuilder.DropTable(
                name: "AppIdentityUserRole");
        }
    }
}
