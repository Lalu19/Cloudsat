using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class aboutcax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 19, 53, 57, 307, DateTimeKind.Local).AddTicks(2377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 1, 19, 52, 33, 372, DateTimeKind.Local).AddTicks(1120));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 1, 19, 52, 33, 372, DateTimeKind.Local).AddTicks(1120),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 6, 1, 19, 53, 57, 307, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 288, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 293, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 294, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 279, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 281, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 281, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 281, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 296, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 286, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 286, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 286, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 286, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 290, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 6, 1, 19, 52, 33, 291, DateTimeKind.Local).AddTicks(949));
        }
    }
}
