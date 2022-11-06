using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicaBartolomeNavarroCesar.Migrations
{
    public partial class NewSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7e3d4e7a-d7ef-4e45-be48-4dfee800a62f", "ffe7ddd7-18e3-4cb3-810e-c07d1a7dd85b", "default", "DEFAULT" },
                    { "bce05143-2ed9-4fef-87da-ff21632ca4ee", "c8779126-4681-4397-8c6e-38858c942d7b", "Admin", "ADMIN" },
                    { "e6f61be6-a24d-428f-9099-4d47de58e39b", "d19748ef-d574-4699-b1c0-dfead510f7b4", "Manager", "MANAGER" },
                    { "e9236eac-0a10-4e1b-8039-488f98521c50", "2a47886c-813a-464e-bfa7-96d24700f879", "Premium", "PREMIUM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2f8ac9d1-3761-43b9-bfc8-c2cb0af0d035", 0, "1620cbb2-bef7-46ac-9530-cc1276d8591f", "premium2@disquera.com", true, false, null, "PREMIUM2@DISQUERA.COM", "PREMIUM2@DISQUERA.COM", "AQAAAAEAACcQAAAAEDdcqSkXldZtKZdbaInmM8wLNjfjcTKhJx4lgipHMYAy0kEtzm8INE9sOZlcaKDG8Q==", null, false, "62a3d9da-4c2d-4a49-bc9f-a03c4d8d48c4", false, "premium2@disquera.com" },
                    { "8a7ce38a-4e04-4a13-8a63-fafcb22a0c77", 0, "e9442b15-fdb6-4268-9b66-52df65e72c64", "Manager@disquera.com", true, false, null, "MANAGER@DISQUERA.COM", "MANAGER@DISQUERA.COM", "AQAAAAEAACcQAAAAEN6DLKyx5z8LS8fQqPE6OCup2aUZfyeXOPcScfH7udMSyDWAc9E9Med8dtOv12fHlw==", null, false, "db7be9e0-fc81-4bbf-8f51-001880f9cf3b", false, "Manager@disquera.com" },
                    { "bd6afd7f-fda0-486b-a38f-621ed634555e", 0, "b01df5ae-623c-4ce4-98ee-5cc42ac1b94c", "Admin@disquera.com", true, false, null, "ADMIN@DISQUERA.COM", "ADMIN@DISQUERA.COM", "AQAAAAEAACcQAAAAEPFIOkT77RsQ8hEbSLZvzMFAnn3IUvhU3SIhoH74Kv6+UUTVOQtAvaC+csj7mOPxBg==", null, false, "b356c920-b83f-4d38-b6c0-d0936ef412c4", false, "Admin@disquera.com" },
                    { "df6d9cde-c856-4c45-8cac-f4a79dfe2c27", 0, "9aede6d8-f3e8-4539-8080-fadf2a0ce4b6", "premium1@disquera.com", true, false, null, "PREMIUM1@DISQUERA.COM", "PREMIUM1@DISQUERA.COM", "AQAAAAEAACcQAAAAECp2nysMkIQ2lhbDxQDE0ue5X9StzJk6JHMIVytjnL+y/uqgZctWZCEJ8GZLxUhEzQ==", null, false, "622c8464-ad97-481c-a27c-c0edd386b597", false, "premium1@disquera.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e9236eac-0a10-4e1b-8039-488f98521c50", "2f8ac9d1-3761-43b9-bfc8-c2cb0af0d035" },
                    { "e6f61be6-a24d-428f-9099-4d47de58e39b", "8a7ce38a-4e04-4a13-8a63-fafcb22a0c77" },
                    { "bce05143-2ed9-4fef-87da-ff21632ca4ee", "bd6afd7f-fda0-486b-a38f-621ed634555e" },
                    { "e9236eac-0a10-4e1b-8039-488f98521c50", "df6d9cde-c856-4c45-8cac-f4a79dfe2c27" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e3d4e7a-d7ef-4e45-be48-4dfee800a62f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9236eac-0a10-4e1b-8039-488f98521c50", "2f8ac9d1-3761-43b9-bfc8-c2cb0af0d035" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6f61be6-a24d-428f-9099-4d47de58e39b", "8a7ce38a-4e04-4a13-8a63-fafcb22a0c77" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bce05143-2ed9-4fef-87da-ff21632ca4ee", "bd6afd7f-fda0-486b-a38f-621ed634555e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9236eac-0a10-4e1b-8039-488f98521c50", "df6d9cde-c856-4c45-8cac-f4a79dfe2c27" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bce05143-2ed9-4fef-87da-ff21632ca4ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6f61be6-a24d-428f-9099-4d47de58e39b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9236eac-0a10-4e1b-8039-488f98521c50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f8ac9d1-3761-43b9-bfc8-c2cb0af0d035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a7ce38a-4e04-4a13-8a63-fafcb22a0c77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd6afd7f-fda0-486b-a38f-621ed634555e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df6d9cde-c856-4c45-8cac-f4a79dfe2c27");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43ed47d4-b8dc-4410-ac07-71d8663e7172", "06fab44b-2097-4613-a82f-073f8b956c0c", "default", "DEFAULT" },
                    { "64a70a8f-24e9-439b-81ce-f2c04831677d", "21dae425-a20e-42be-bce9-ac0b2b1d2f5c", "Manager", "MANAGER" },
                    { "9b99e791-478a-41ea-b15d-995d09ee64aa", "21a40844-1e5c-4504-8759-95deb3477d22", "Admin", "ADMIN" },
                    { "b9e4eca2-8974-4c75-9b72-386be270b138", "ab720550-5ccc-4567-a9e0-02d356ba4f48", "Premium", "PREMIUM" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25ac8f83-7420-4452-bc0b-dbedd3cb16b3", 0, "90aa19df-f350-43f3-b096-e3c44f0fd3b2", "premium1@disquera.com", true, false, null, "PREMIUM1@DISQUERA.COM", "PREMIUM1@DISQUERA.COM", "AQAAAAEAACcQAAAAEOTj7XAS3MOquIJiEOY8/LCkHSu2HzWNG5W7dgwjyJvY14W2smwirlwcl0AJL7lZzg==", null, false, "933b1bd7-21c8-4f34-a03d-ab598874deec", false, "premium1@disquera.com" },
                    { "607a78ec-26b0-4151-81d8-0e152401d6e9", 0, "8c986acc-7612-4f6c-ab9f-db728aecad4c", "Admin@disquera.com", true, false, null, "ADMIN@DISQUERA.COM", "ADMIN@DISQUERA.COM", "AQAAAAEAACcQAAAAEAdqgmiSsTkeyB43VDqPTHVLs8/F2wO0vM/eLMJ0+SlrN9nl3m6ps3/Cm231dJ3bwA==", null, false, "531c8b64-bef2-4b9d-803d-27d5a8f41c8a", false, "Admin@disquera.com" },
                    { "839bc8d1-b268-482e-9af5-56c25207c138", 0, "a846c9f7-1149-43bd-bc00-34a1c6669ac3", "premium2@disquera.com", true, false, null, "PREMIUM2@DISQUERA.COM", "PREMIUM2@DISQUERA.COM", "AQAAAAEAACcQAAAAEKhcQAoq7PjNjr4ezm8G/+FLoWno5fmgYjqj+rKm+JzR4/cj7lY0YfLdL8hl4Pbosg==", null, false, "b30d5cf2-b730-428e-9664-aa21de01e736", false, "premium2@disquera.com" },
                    { "9fea3a66-e9da-44d6-99a9-88f7985b5799", 0, "e90dfd4c-ca45-459b-9bfb-9dac5b692f03", "Manager@disquera.com", true, false, null, "MANAGER@DISQUERA.COM", "MANAGER@DISQUERA.COM", "AQAAAAEAACcQAAAAENycnzzn5h4/HGs+rt58+ZFFi/J3lb9ILgbCUkYZlberNbDbeHK0oeXgoIMeesmCfA==", null, false, "ba94ffe6-ce6f-471d-9f12-1f9dc69953c4", false, "Manager@disquera.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b9e4eca2-8974-4c75-9b72-386be270b138", "25ac8f83-7420-4452-bc0b-dbedd3cb16b3" },
                    { "9b99e791-478a-41ea-b15d-995d09ee64aa", "607a78ec-26b0-4151-81d8-0e152401d6e9" },
                    { "b9e4eca2-8974-4c75-9b72-386be270b138", "839bc8d1-b268-482e-9af5-56c25207c138" },
                    { "64a70a8f-24e9-439b-81ce-f2c04831677d", "9fea3a66-e9da-44d6-99a9-88f7985b5799" }
                });
        }
    }
}
