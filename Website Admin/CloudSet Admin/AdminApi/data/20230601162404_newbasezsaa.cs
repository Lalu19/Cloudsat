using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class newbasezsaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 21, 54, 4, 261, DateTimeKind.Local).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 1, 20, 25, 39, 778, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 208, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 213, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 201, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 203, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 203, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 203, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 215, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 206, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 206, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 206, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 206, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 210, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 21, 54, 4, 210, DateTimeKind.Local).AddTicks(7204));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 20, 25, 39, 778, DateTimeKind.Local).AddTicks(29),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 6, 1, 21, 54, 4, 261, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 728, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 732, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 723, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 724, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 724, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 724, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 734, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 727, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 727, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 727, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 727, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 730, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 25, 39, 730, DateTimeKind.Local).AddTicks(6375));
        }
    }
}
