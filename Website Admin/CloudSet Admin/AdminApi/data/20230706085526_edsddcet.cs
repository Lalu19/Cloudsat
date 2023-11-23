using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class edsddcet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Largecontent",
                table: "Images",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 6, 14, 25, 25, 480, DateTimeKind.Local).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 5, 20, 59, 49, 517, DateTimeKind.Local).AddTicks(6454));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Largecontent",
                table: "Images");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 5, 20, 59, 49, 517, DateTimeKind.Local).AddTicks(6454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 7, 6, 14, 25, 25, 480, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 458, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 463, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 451, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 452, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 452, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 452, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 466, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 456, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 456, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 456, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 456, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 460, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 7, 5, 20, 59, 49, 460, DateTimeKind.Local).AddTicks(7943));
        }
    }
}
