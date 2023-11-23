using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class newsxbasj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "AllViewBanners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 23, 39, 29, 755, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 20, 32, 56, 494, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 695, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 699, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 689, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 691, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 691, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 691, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 701, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 693, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 693, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 693, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 693, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 696, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 23, 39, 29, 696, DateTimeKind.Local).AddTicks(7180));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 20, 32, 56, 494, DateTimeKind.Local).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 6, 3, 23, 39, 29, 755, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "AllViewBanners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 426, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 429, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 421, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 423, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 423, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 423, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 431, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 425, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 425, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 425, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 425, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 427, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 20, 32, 56, 428, DateTimeKind.Local).AddTicks(683));
        }
    }
}
