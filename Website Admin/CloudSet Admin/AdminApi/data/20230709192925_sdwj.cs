using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class sdwj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 10, 0, 59, 25, 266, DateTimeKind.Local).AddTicks(5971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 6, 14, 25, 25, 480, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 245, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 246, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 242, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 243, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 243, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 243, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 247, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 244, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 244, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 244, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 244, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 245, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 10, 0, 59, 25, 245, DateTimeKind.Local).AddTicks(8742));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 6, 14, 25, 25, 480, DateTimeKind.Local).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 7, 10, 0, 59, 25, 266, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 419, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 422, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 414, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 415, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 415, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 415, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 423, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 424, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 417, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 417, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 417, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 417, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 420, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 6, 14, 25, 25, 420, DateTimeKind.Local).AddTicks(4908));
        }
    }
}
