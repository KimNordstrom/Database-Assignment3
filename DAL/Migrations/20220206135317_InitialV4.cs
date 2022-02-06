using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentOfPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MentorID = table.Column<int>(type: "int", nullable: true),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staffs_Staffs_MentorID",
                        column: x => x.MentorID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "Date", nullable: false),
                    InventoryDate = table.Column<DateTime>(type: "Date", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    CampaignID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Campaigns_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffEmails",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffEmails", x => x.EmailID);
                    table.ForeignKey(
                        name: "FK_StaffEmails_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productsInDepartments",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsInDepartments", x => new { x.ProductID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_productsInDepartments_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productsInDepartments_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "CampaignID", "Name", "PercentOfPrice" },
                values: new object[,]
                {
                    { 1, "BBQ Weekend", 20.0 },
                    { 2, "Breakfast Sale", 15.0 },
                    { 3, "Healthy Week", 25.0 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffID", "EndDate", "MentorID", "Name", "PersonalNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, null, null, "John A", "19680413-5436", "070-5002138" },
                    { 2, null, null, "Bob B", "19531030-8564", "078-3219543" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Name", "StaffID" },
                values: new object[,]
                {
                    { 4, "Drink", 1 },
                    { 6, "Pantry", 1 },
                    { 2, "Bread", 2 },
                    { 3, "Meat", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CampaignID", "Contents", "ExpireDate", "InventoryDate", "Name", "Price", "StaffID", "Stock" },
                values: new object[,]
                {
                    { 4, 2, "Flour, Water", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "White Bread", 15.0, 1, 22 },
                    { 10, 3, "Water", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water", 5.0, 1, 4 },
                    { 11, null, "Carbonated Water, Flavor", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soda", 15.0, 1, 35 },
                    { 16, null, "Wheat", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flour", 10.0, 1, 17 },
                    { 9, null, "Fish", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish", 30.0, 2, 2 },
                    { 7, 1, "Chicken", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken", 35.0, 2, 26 },
                    { 8, 1, "Cow Meat, Fat", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steak", 25.0, 2, 11 }
                });

            migrationBuilder.InsertData(
                table: "StaffEmails",
                columns: new[] { "EmailID", "Email", "StaffID" },
                values: new object[,]
                {
                    { 1, "MrA@hotmail.com", 1 },
                    { 2, "JohnTheBoss@hotmail.com", 1 },
                    { 3, "bobbyb@gmail.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffID", "EndDate", "MentorID", "Name", "PersonalNumber", "PhoneNumber" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Anna H", "20010121-9451", "076-8659302" },
                    { 4, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Carl N", "19980715-7203", "076-3246012" },
                    { 5, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sarah W", "19921003-3241", "075-5346295" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Name", "StaffID" },
                values: new object[,]
                {
                    { 1, "Dairy", 3 },
                    { 5, "Fruit", 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CampaignID", "Contents", "ExpireDate", "InventoryDate", "Name", "Price", "StaffID", "Stock" },
                values: new object[,]
                {
                    { 18, null, "", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking Oil", 24.0, 5, 21 },
                    { 13, 3, "", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", 5.0, 4, 14 },
                    { 14, 3, "", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", 8.0, 4, 25 },
                    { 17, null, "Tomatoes", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canned Tomatoes", 5.0, 5, 0 },
                    { 15, 3, "", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melon", 15.0, 3, 1 },
                    { 6, null, "Flour, Water, Yeast", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baguette", 20.0, 3, 15 },
                    { 5, 3, "Flour, Water, Oats", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whole Grain Bread", 18.0, 3, 9 },
                    { 2, 2, "Churned Cream, Salt", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butter", 9.0, 3, 13 },
                    { 1, 2, "Cow Milk", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk", 12.0, 3, 0 },
                    { 12, 1, "Fermented Wheat", new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beer", 24.0, 5, 15 },
                    { 3, 2, "Fremented Milk", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yogurt", 14.0, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "StaffEmails",
                columns: new[] { "EmailID", "Email", "StaffID" },
                values: new object[,]
                {
                    { 4, "Anna2001@gmail.com", 3 },
                    { 7, "Sarah.W@live.com", 5 },
                    { 6, "Carl_N@outlook.com", 4 },
                    { 5, "Carlster98@outlook.com", 4 }
                });

            migrationBuilder.InsertData(
                table: "productsInDepartments",
                columns: new[] { "DepartmentID", "ProductID" },
                values: new object[,]
                {
                    { 2, 4 },
                    { 3, 8 },
                    { 3, 7 },
                    { 6, 16 },
                    { 4, 11 },
                    { 3, 9 },
                    { 4, 10 }
                });

            migrationBuilder.InsertData(
                table: "productsInDepartments",
                columns: new[] { "DepartmentID", "ProductID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 5 },
                    { 2, 6 },
                    { 5, 15 },
                    { 5, 13 },
                    { 5, 14 },
                    { 4, 12 },
                    { 6, 17 },
                    { 6, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StaffID",
                table: "Departments",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampaignID",
                table: "Products",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StaffID",
                table: "Products",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_productsInDepartments_DepartmentID",
                table: "productsInDepartments",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_StaffEmails_StaffID",
                table: "StaffEmails",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_MentorID",
                table: "Staffs",
                column: "MentorID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_PersonalNumber",
                table: "Staffs",
                column: "PersonalNumber",
                unique: true,
                filter: "[PersonalNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productsInDepartments");

            migrationBuilder.DropTable(
                name: "StaffEmails");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
