using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class newbase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 20, 6, 28, 675, DateTimeKind.Local).AddTicks(666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 1, 20, 1, 49, 107, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 596, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 602, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 588, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 590, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 590, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 590, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 604, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 594, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 594, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 594, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 594, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 598, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 6, 28, 598, DateTimeKind.Local).AddTicks(8356));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 20, 1, 49, 107, DateTimeKind.Local).AddTicks(6032),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 6, 1, 20, 6, 28, 675, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 24, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 31, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 16, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 18, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 18, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 18, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 34, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 22, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 23, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 23, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 23, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 26, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 20, 1, 49, 27, DateTimeKind.Local).AddTicks(270));
        }
    }
}
