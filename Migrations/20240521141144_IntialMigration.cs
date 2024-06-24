using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace St10145657_POEPart2.Migrations
{
    /// <inheritdoc />
    public partial class IntialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    full_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin__43AA414137058536", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    phone_number = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__CD65CB855D62CF12", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    stock_quantity = table.Column<int>(type: "int", nullable: false),
                    image_url = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__47027DF5E8EC060A", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    cart_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    product_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    product_description = table.Column<string>(type: "text", nullable: true),
                    product_price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    stock_quantity = table.Column<int>(type: "int", nullable: true),
                    image_url = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cart__2EF52A27936510D9", x => x.cart_id);
                    table.ForeignKey(
                        name: "FK__Cart__customer_i__403A8C7D",
                        column: x => x.customer_id,
                        principalTable: "Customer",
                        principalColumn: "customer_id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payment__ED1FC9EA159AE1D1", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK__Payment__custome__4316F928",
                        column: x => x.customer_id,
                        principalTable: "Customer",
                        principalColumn: "customer_id");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Admin__AB6E61643C6ECEE3",
                table: "Admin",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Admin__F3DBC572D5660EE2",
                table: "Admin",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_customer_id",
                table: "Cart",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Customer__AB6E6164A46E4316",
                table: "Customer",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_customer_id",
                table: "Payment",
                column: "customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
