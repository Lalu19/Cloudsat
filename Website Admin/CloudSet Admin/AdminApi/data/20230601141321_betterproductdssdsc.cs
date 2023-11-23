using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class betterproductdssdsc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    AboutUsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    ImageUpload = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.AboutUsId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationMasters",
                columns: table => new
                {
                    ApplicationMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationMasterName = table.Column<string>(nullable: true),
                    ApplicationMasterLogo = table.Column<string>(nullable: true),
                    Parent = table.Column<int>(nullable: true),
                    ApplicationMasterMonthlyPrice = table.Column<string>(nullable: true),
                    ApplicationMasterQuarterlyPrice = table.Column<string>(nullable: true),
                    ApplicationMasterHalfyearlyPrice = table.Column<string>(nullable: true),
                    ApplicationMasterYearlyPrice = table.Column<string>(nullable: true),
                    packagename = table.Column<string>(nullable: true),
                    frontpagedisplay = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    ApplicationMasterId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMasters", x => x.ApplicationMasterId);
                    table.ForeignKey(
                        name: "FK_ApplicationMasters_ApplicationMasters_ApplicationMasterId1",
                        column: x => x.ApplicationMasterId1,
                        principalTable: "ApplicationMasters",
                        principalColumn: "ApplicationMasterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    bannerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUpload = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.bannerId);
                });

            migrationBuilder.CreateTable(
                name: "BetterProducts",
                columns: table => new
                {
                    BetterProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    ImageUpload = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetterProducts", x => x.BetterProductId);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    CareersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    JobOpeningid = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    ExperienceinYears = table.Column<string>(nullable: true),
                    Resume = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.CareersId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Parent = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 6, 1, 19, 43, 20, 720, DateTimeKind.Local).AddTicks(4552)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_Parent",
                        column: x => x.Parent,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DownloadApps",
                columns: table => new
                {
                    DownloadAppId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(nullable: true),
                    ApplicationFile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadApps", x => x.DownloadAppId);
                });

            migrationBuilder.CreateTable(
                name: "Homepages",
                columns: table => new
                {
                    homeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUpload = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homepages", x => x.homeid);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    WebsitePages = table.Column<string>(nullable: true),
                    ImageUpload = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "JobOpening",
                columns: table => new
                {
                    JobOpeningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobPositionName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Industry = table.Column<string>(nullable: true),
                    JobType = table.Column<string>(nullable: true),
                    WorkExperience = table.Column<string>(nullable: true),
                    DateOpened = table.Column<DateTime>(nullable: false),
                    JobDescription = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpening", x => x.JobOpeningId);
                });

            migrationBuilder.CreateTable(
                name: "LogHistory",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogCode = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LogInTime = table.Column<DateTime>(nullable: false),
                    LogOutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistory", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    MenuTitle = table.Column<string>(maxLength: 100, nullable: false),
                    URL = table.Column<string>(maxLength: 500, nullable: true),
                    IsSubMenu = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroupWiseMenuMapping",
                columns: table => new
                {
                    MenuGroupWiseMenuMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroupWiseMenuMapping", x => x.MenuGroupWiseMenuMappingId);
                });

            migrationBuilder.CreateTable(
                name: "PlanningAndApplications",
                columns: table => new
                {
                    planningandapplicationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationMasterId = table.Column<int>(nullable: false),
                    PlanningId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanningAndApplications", x => x.planningandapplicationid);
                });

            migrationBuilder.CreateTable(
                name: "PlanningMasters",
                columns: table => new
                {
                    PlanningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanningName = table.Column<string>(nullable: true),
                    PlanningMasterMonthlyPlan = table.Column<string>(nullable: true),
                    PlanningMasterQuaterlyPlan = table.Column<string>(nullable: true),
                    PlanningMasterHalfYearlyPlan = table.Column<string>(nullable: true),
                    PlanningMasterAnnuallyPlan = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanningMasters", x => x.PlanningId);
                });

            migrationBuilder.CreateTable(
                name: "Pricingproducts",
                columns: table => new
                {
                    PricingproductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingId = table.Column<int>(nullable: false),
                    productname = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricingproducts", x => x.PricingproductId);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    PricingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planes = table.Column<string>(nullable: true),
                    period = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.PricingId);
                });

            migrationBuilder.CreateTable(
                name: "PrivacyPolicies",
                columns: table => new
                {
                    PrivacyPolicyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyPolicies", x => x.PrivacyPolicyid);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionApplictions",
                columns: table => new
                {
                    SubscriptionApplictionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Companysize = table.Column<string>(nullable: true),
                    TermsAndconditions = table.Column<bool>(nullable: false),
                    term = table.Column<string>(nullable: true),
                    Applictions = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionApplictions", x => x.SubscriptionApplictionId);
                });

            migrationBuilder.CreateTable(
                name: "Termsandconditions",
                columns: table => new
                {
                    termsandconditionsid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    termsandconditionText = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termsandconditions", x => x.termsandconditionsid);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    RoleDesc = table.Column<string>(maxLength: 500, nullable: true),
                    MenuGroupId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    LastPasswordChangeDate = table.Column<DateTime>(nullable: true),
                    PasswordChangedBy = table.Column<int>(nullable: true),
                    IsPasswordChange = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Websitepages",
                columns: table => new
                {
                    WebsitePagesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Header = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Description1 = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true),
                    Description3 = table.Column<string>(nullable: true),
                    Description4 = table.Column<string>(nullable: true),
                    Description5 = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Websitepages", x => x.WebsitePagesId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedBy", "CreatedOn", "Icon", "IsActive", "IsDeleted", "Order", "Parent", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, "Restaurant", 1, new DateTime(2023, 6, 1, 19, 43, 20, 674, DateTimeKind.Local).AddTicks(8222), "/images/restaurant.png", true, false, 100, null, null, null });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "AddedBy", "DateAdded", "IconClass", "IsActive", "IsMigrationData", "IsSubMenu", "LastUpdatedBy", "LastUpdatedDate", "MenuTitle", "ParentID", "SortOrder", "URL" },
                values: new object[,]
                {
                    { 10, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3717), "", true, true, 0, null, null, "Change Password", 9, 0, "/User/ChangePassword" },
                    { 8, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3712), "", true, true, 0, null, null, "Profile", 5, 0, "/User/UserProfile" },
                    { 7, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3710), "", true, true, 0, null, null, "Role List", 5, 0, "/User/RoleList" },
                    { 6, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3707), "", true, true, 0, null, null, "User List", 5, 0, "/User/UserList" },
                    { 9, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3715), "fas fa-wrench", true, true, 1, null, null, "Settings", 0, 4, "" },
                    { 4, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3702), "", true, true, 0, null, null, "Menu Group List", 2, 0, "/Menu/MenuGroupList" },
                    { 3, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3699), "", true, true, 0, null, null, "Menu List", 2, 0, "/Menu/MenuList" },
                    { 2, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3689), "fas fa-ellipsis-v", true, true, 1, null, null, "Menu", 0, 2, "" },
                    { 1, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(2624), "fas fa-home", true, true, 0, null, null, "Dashboard", 0, 1, "/DashBoard/Index" },
                    { 5, 1, new DateTime(2023, 6, 1, 19, 43, 20, 678, DateTimeKind.Local).AddTicks(3705), "fas fa-user", true, true, 1, null, null, "User", 0, 3, "" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "MenuGroupID", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 1, 19, 43, 20, 668, DateTimeKind.Local).AddTicks(4617), true, true, null, null, "Super Admin Group" },
                    { 2, 1, new DateTime(2023, 6, 1, 19, 43, 20, 669, DateTimeKind.Local).AddTicks(9969), true, true, null, null, "User Group" },
                    { 3, 1, new DateTime(2023, 6, 1, 19, 43, 20, 670, DateTimeKind.Local).AddTicks(2), true, true, null, null, "Buyer" },
                    { 4, 1, new DateTime(2023, 6, 1, 19, 43, 20, 670, DateTimeKind.Local).AddTicks(7), true, true, null, null, "Seller" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroupWiseMenuMapping",
                columns: new[] { "MenuGroupWiseMenuMappingId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "MenuGroupId", "MenuId" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9958), true, true, 1, 10 },
                    { 10, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9964), true, true, 2, 10 },
                    { 9, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9962), true, true, 2, 8 },
                    { 8, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9960), true, true, 2, 1 },
                    { 6, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9956), true, true, 1, 8 },
                    { 1, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(8779), true, true, 1, 1 },
                    { 4, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9856), true, true, 1, 6 },
                    { 3, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9853), true, true, 1, 4 },
                    { 2, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9844), true, true, 1, 3 },
                    { 5, 1, new DateTime(2023, 6, 1, 19, 43, 20, 679, DateTimeKind.Local).AddTicks(9858), true, true, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupId", "RoleDesc", "RoleName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 1, 19, 43, 20, 673, DateTimeKind.Local).AddTicks(4488), true, true, null, null, 1, null, "Admin" },
                    { 2, 1, new DateTime(2023, 6, 1, 19, 43, 20, 673, DateTimeKind.Local).AddTicks(5586), true, true, null, null, 2, null, "User" },
                    { 3, 1, new DateTime(2023, 6, 1, 19, 43, 20, 673, DateTimeKind.Local).AddTicks(5595), true, true, null, null, 3, null, "Buyer" },
                    { 4, 1, new DateTime(2023, 6, 1, 19, 43, 20, 673, DateTimeKind.Local).AddTicks(5598), true, true, null, null, 4, null, "Seller" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddedBy", "DateAdded", "DateOfBirth", "Email", "FullName", "ImagePath", "IsActive", "IsMigrationData", "IsPasswordChange", "LastPasswordChangeDate", "LastUpdatedBy", "LastUpdatedDate", "Mobile", "Password", "PasswordChangedBy", "UserName", "UserRoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 1, 19, 43, 20, 676, DateTimeKind.Local).AddTicks(1231), null, null, "Appman", null, true, true, false, null, null, null, null, "Appman@2019", null, "developer", 1 },
                    { 2, 1, new DateTime(2023, 6, 1, 19, 43, 20, 676, DateTimeKind.Local).AddTicks(2830), null, null, "Helen Smith", null, true, true, false, null, null, null, null, "user@2020", null, "user@2020", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationMasters_ApplicationMasterId1",
                table: "ApplicationMasters",
                column: "ApplicationMasterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Parent",
                table: "Categories",
                column: "Parent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "ApplicationMasters");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BetterProducts");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DownloadApps");

            migrationBuilder.DropTable(
                name: "Homepages");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "JobOpening");

            migrationBuilder.DropTable(
                name: "LogHistory");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "MenuGroupWiseMenuMapping");

            migrationBuilder.DropTable(
                name: "PlanningAndApplications");

            migrationBuilder.DropTable(
                name: "PlanningMasters");

            migrationBuilder.DropTable(
                name: "Pricingproducts");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "PrivacyPolicies");

            migrationBuilder.DropTable(
                name: "SubscriptionApplictions");

            migrationBuilder.DropTable(
                name: "Termsandconditions");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Websitepages");
        }
    }
}
