using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class aboutcaswe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 20, 1, 49, 107, DateTimeKind.Local).AddTicks(6032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 1, 19, 53, 57, 307, DateTimeKind.Local).AddTicks(2377));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 19, 53, 57, 307, DateTimeKind.Local).AddTicks(2377),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 6, 1, 20, 1, 49, 107, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 236, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 240, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 229, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 230, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 230, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 230, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 242, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 234, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 234, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 234, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 234, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 237, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 53, 57, 237, DateTimeKind.Local).AddTicks(9665));
        }
    }
}
