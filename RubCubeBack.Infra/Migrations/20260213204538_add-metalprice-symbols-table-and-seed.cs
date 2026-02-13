using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RubCubeBack.Infra.Migrations
{
    /// <inheritdoc />
    public partial class addmetalpricesymbolstableandseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MetalPriceSymbols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetalPriceSymbols", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("628374f8-d612-45f5-8262-1dae1dd64b2f"), "XAG", "Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0b9e1ceb-fe19-4e93-a6d3-bfe6d43a1e2c"), "XAG-BID", "Silver Bid", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("302b7d06-645e-4c10-a576-f209cc553ff6"), "XAG-ASK", "Silver Ask", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("320917f0-4776-4004-b0bf-c0b2f61012a8"), "XAU", "Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ddaf0332-e977-40be-9fe9-06807a0d8d61"), "XAU-BID", "Gold Bid", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a3a9748a-6450-4511-ac8c-17f3950e0d6f"), "XAU-ASK", "Gold Ask", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e061f6bb-87e4-4a88-b020-4553a7c3efcc"), "XPD", "Palladium", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d52a146a-468b-4437-afd1-339364a91935"), "XPD-BID", "Palladium Bid", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("8ef4a2a0-b0ca-4258-9c7a-33b542357eea"), "XPD-ASK", "Palladium Ask", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a18418d5-ac83-48a7-b2fc-e08b4c9ed57d"), "XPT", "Platinum", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("68643ba4-723d-4bf8-8880-e9ec4f59bc30"), "XPT-BID", "Platinum Bid", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c34bbb83-60f8-4ecc-a0cf-cda53c8a4d41"), "XPT-ASK", "Platinum Ask", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("51ad692d-8450-4abb-aceb-c42467e423fb"), "XRH", "Rhodium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7a6c6cb0-2555-4d83-999a-5333f20515b7"), "ALU", "Aluminum", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("38a17238-87c5-4799-beb2-70aa5bc0dd24"), "XCO", "Cobalt", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("bd00d806-f584-4892-af09-e2bb69288a0b"), "XCU", "Copper", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("65ee0834-536b-45f5-8b88-72dd425328e7"), "XGA", "Gallium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("512180b1-b185-4d44-a95e-7a80d43a8856"), "XIN", "Indium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e2c441f5-b66b-471f-ac38-c73707ae4f9b"), "IRON", "Iron Ore", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b8c2b466-9ee9-4c4d-8cdc-0f19c9eb9cc1"), "XPB", "Lead", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("dec64ced-3dc7-46bc-8a01-686305d9f6be"), "XLI", "Lithium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("cbc7b2c5-37e3-4ceb-a13d-504cdd3c92a5"), "XMO", "Molybdenum", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("21348768-3073-4381-b8a0-cc591304dcb9"), "NI", "Nickel", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fc7bf740-9003-4a85-9ed4-6875f3bfb381"), "XND", "Neodymium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b23d1ccd-0dde-4b76-9c90-288e81abed53"), "XSN", "Tin", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("525b1d99-6bbd-49af-8380-5752be1a2b7e"), "XTE", "Tellurium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("1875b434-dbeb-40ee-9da1-8023f10774c4"), "XU", "Uranium", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ccc109e8-425a-43b5-b2ca-1effaacb9f14"), "ZNC", "Zinc", "Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fba5f0b0-0899-43e1-b997-1f349b957f2c"), "XAU-AHME", "Ahmedabad Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("49d0420f-2295-4e9b-90c2-da44d2835ce1"), "XAU-BANG", "Bangalore Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b9466cc8-1355-4d09-99c9-efa75b2dc840"), "XAU-BHOP", "Bhopal Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b7dfbe34-5420-4014-bf2f-c9a298236d34"), "XAU-CHAN", "Chandigarh Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ded80daf-fadb-49f9-8393-b373643ff9c7"), "XAU-CHEN", "Chennai Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("87aee587-cef5-45e7-b740-25c3d53c914a"), "XAU-COIM", "Coimbatore Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("60245bcb-2729-40f8-8e26-f4da4f72daf8"), "XAU-DEHR", "Dehradun Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("da4173ef-f7f7-4d7e-b9f1-9c734118a26c"), "XAU-FARI", "Faridabad Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3ab70d39-1919-4742-888e-80b174644dda"), "XAU-GURG", "Gurgaon Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fe49515c-759d-46db-b722-23df3db708e0"), "XAU-GUWA", "Guwahati Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7b5be286-e485-4245-b8b2-99a80247d3c6"), "XAU-HYDE", "Hyderabad Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5ad42b6f-aea1-4269-9d13-b738b6bfe6bc"), "XAU-INDO", "Indore Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7aa50e09-8d5c-4e7c-af66-73af72ff7271"), "XAU-JAIP", "Jaipur Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("63f3f87a-c2cd-400e-8846-6058ca53f06b"), "XAU-KANP", "Kanpur Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5f0221cd-acbd-4117-879d-fa0a25d1a635"), "XAU-KOCH", "Kochi Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("520397b1-b824-476f-a699-b3c67fc5c3d5"), "XAU-KOLH", "Kolhapur Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d7647d40-9572-4758-957e-45db7fa6f30e"), "XAU-KOLK", "Kolkata Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("4a77faaf-8da5-480d-98cf-e2b8e7653ea0"), "XAU-LUCK", "Lucknow Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ed2546d6-912f-4175-b7f2-3b04543096f8"), "XAU-LUDH", "Ludhiana Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("70f4acad-902a-4269-b6df-a5f81d7e9f79"), "XAU-MADU", "Madurai Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a1363daa-3084-48a9-8e7f-672d2a852da5"), "XAU-MALA", "Malappuram Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b952f4e2-26b9-437a-96c2-c12fd1eb9314"), "XAU-MANG", "Mangalore Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7e0e8022-0169-48c7-9eb7-5ab21b099a43"), "XAU-MEER", "Meerut Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7204187a-15d3-423a-99e8-6fa00d1febcd"), "XAU-MUMB", "Mumbai Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("8747bf2a-63e3-47c9-b04d-15967a48c861"), "XAU-MYSO", "Mysore Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3e1ee5fa-5540-4d0c-b7ce-3e06404759e4"), "XAU-NAGP", "Nagpur Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3f44c6a5-8c34-4a15-837d-000ebc4093a5"), "XAU-NOID", "Noida Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d17e2406-cbd5-4fb0-ad6b-bbac85ab7a84"), "XAU-PATN", "Patna Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("df2ca1b0-bf97-4d7d-9ca8-0ea01cf777a2"), "XAU-POND", "Pondicherry Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c91b549a-85fd-4151-b250-daad0d5be950"), "XAU-PUNE", "Pune Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7bb1d916-46e9-4d6a-84c2-1c9917d0d3ef"), "XAU-RAIP", "Raipur Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("6b4d267c-4459-4389-80d1-9b889b123011"), "XAU-SALE", "Salem Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("9a0b586c-c6df-4d04-88e7-74ab625e31ac"), "XAU-VIJA", "Vijayawada Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("2f2dff2d-f93a-49e4-81b0-12f7635251b6"), "XAU-VISA", "Visakhapatnam Gold", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("359fc293-0945-4948-9e9d-6e87ffcaab28"), "XAG-AHME", "Ahmedabad Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("16278b19-24bd-42ce-a5c6-a20252acd6de"), "XAG-BANG", "Bangalore Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("4dee6a85-df8c-48fc-9506-d462083f898e"), "XAG-CHAN", "Chandigarh Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("281de38f-1c75-44bc-bbaa-c3c68ff03a0c"), "XAG-CHEN", "Chennai Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ef1fa68c-7959-43e5-97dd-f1387061a5ff"), "XAG-COIM", "Coimbatore Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("31b186c5-f29f-422f-afa8-37589a23e6ee"), "XAG-HYDE", "Hyderabad Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("01d5db01-76c7-425e-b433-ad95358c019f"), "XAG-JAIP", "Jaipur Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("15558648-7b75-493a-b773-2d5fcfd9a940"), "XAG-KOLK", "Kolkata Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fd3f1ad6-5530-4306-8654-dd1186f1caae"), "XAG-LUCK", "Lucknow Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("1debe106-1303-4664-ab99-0fe08af99482"), "XAG-MADU", "Madurai Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("27676424-5fca-4b80-b844-9233467057b3"), "XAG-MANG", "Mangalore Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("aefaf2c3-cc96-4db4-a18a-84f6ce153c54"), "XAG-MUMB", "Mumbai Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("532a1d76-5a71-4907-8b38-6616d7b859d1"), "XAG-MYSO", "Mysore Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d7a5c0df-5d81-470a-ad8a-dcb30c5586cc"), "XAG-NAGP", "Nagpur Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("084e7320-67e4-450a-b5e4-4af09aeef036"), "XAG-PATN", "Patna Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("474154f8-8530-406d-832d-8a740fb3697f"), "XAG-PUNE", "Pune Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ead8f3e7-030d-4cd9-8971-8681f81c94e0"), "XAG-SALE", "Salem Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("86cf64bd-0e22-46d4-8cf3-d0495fa64627"), "XAG-VIJA", "Vijayawada Silver", "Troy Ounce" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("93a52e02-caa5-46f5-905a-0d396a935e30"), "ADA", "Cardano", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("85cbf890-0e67-4de7-9dc9-a8a334690732"), "BNB", "Binance Coin", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a5a11429-65f5-4baa-9481-c90c6d430556"), "BTC", "Bitcoin", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("9dacd66f-cf8d-4c46-a82d-89a30444d7dc"), "DOGE", "Dogecoin", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("34233bbe-9706-4d1b-9862-044ed0b245b3"), "DOT", "Polkadot", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("4ae6eca3-d1a4-44fb-b67a-2cd241ba67d8"), "ETH", "Ethereum", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e3df0443-2687-4e9f-b639-b954c5e335b0"), "LINK", "Chainlink", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("826d8f95-1505-4334-bd17-8cea45c8d499"), "LTC", "Litecoin", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ffd8d0e8-f3bd-4197-8b2c-e26aa626fc68"), "SOL", "Solana", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0a19354f-6a22-4508-9e97-b41f16dc0be2"), "TRX", "Tron", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("80b43c26-8e24-476a-9127-716ed29c2b28"), "USDC", "USD Coin", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("024c4f24-3af0-4617-83d0-c27437083d9f"), "USDT", "Tether", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("25815b40-f6c0-473e-98e7-642566184f43"), "XRP", "Ripple", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ac1428bd-f44c-4606-ab7a-4fd969715a40"), "BRENT", "Brent Crude", "per Barrel (Bbl)" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("be2a843f-8f48-41a5-818f-f0394a7728d7"), "GASOLINE", "Gasoline", "per Gallon (Gal)" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e77e7fcf-4a4f-4efd-9925-807270f64cd2"), "NATURALGAS", "Natural Gas", "per Million British Thermal Units (MMBtu)" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fac3d44f-8131-48ee-bec8-0bb46903e00b"), "WTI", "West Texas Intermediate", "per Barrel (Bbl)" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b07ed4dd-99fb-42ae-9869-8fcf31f7fe9b"), "AED", "UAE Dirham", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("2e0d5aad-321c-4724-808d-6eec42cf728a"), "AFN", "Afghan Afghani", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a859b62a-c6ad-46dd-835d-b04044a6d53c"), "ALL", "Albanian Lek", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("68e5203b-0c60-4cf4-a1d8-6b98ed93bfed"), "AMD", "Armenian Dram", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("1ba9dac1-186a-4573-bcd5-9157d446b368"), "ANG", "Netherlands Antillean Guilder", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("45c8c1ab-110a-4449-8a09-41a00e9d615a"), "AOA", "Angolan Kwanza", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a1223413-408a-4082-9334-ff25575abb8a"), "ARS", "Argentine Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("68cbe2af-e428-4d58-a75b-9fd8242466a4"), "AUD", "Australian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("214d8702-42da-4c91-9df6-a507789b04ee"), "AZN", "Azerbaijan Manat", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d5497a87-746f-42ff-81eb-aa8cd7cdb7fe"), "BAM", "Bosnia And Herzegovina Convertible Mark", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("27d469d5-00cc-4673-beac-ca10903b7854"), "BBD", "Barbadian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f3af7ac3-f206-46b0-bbfd-7d23c9ca4ffb"), "BDT", "Bangladeshi Taka", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a96ed4ad-1206-4035-b184-3418ed4dc4d3"), "BGN", "Bulgarian Lev", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("32a50696-2318-4754-b752-8247c3e42520"), "BHD", "Bahraini Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5dfe2e23-0e06-42b4-b6ad-eb7c203d86fa"), "BIF", "Burundi Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b4ca9d6d-7217-4fef-9a62-c09b576a6264"), "BIH", "Bosnia-Herzegovina Convertible Mark", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7a58e60c-3999-4325-97c6-737d2cd4e4a4"), "BND", "Brunei Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a90190a4-a637-46ca-aeb3-9eee7089c2ca"), "BOB", "Bolivian Boliviano", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e908e649-ff67-4cd7-a13f-af906b4eeb50"), "BRL", "Brazilian Real", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3e88c3a1-69fb-4e87-9507-854687f35d2b"), "BSD", "Bahamian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("643fd6ec-ddc3-4bf9-8dc3-58a4b9c29545"), "BTN", "Bhutanese Ngultrum", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c47de27e-9d47-479b-8093-d00ac98c0c42"), "BWP", "Botswanan Pula", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("64296e8a-189f-4099-a47b-6d17fbc989b2"), "BYN", "Belarusian Ruble", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("28671f89-733a-459b-b808-2e24053c9488"), "BZD", "Belize Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7a5bb5a1-64ea-46a4-90ff-b5f8fd72e842"), "CAD", "Canadian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("31c72678-c65c-4cff-8e75-7b7134bd462f"), "CDF", "Congolese Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b57704af-2d19-424f-93fb-becf7af3b11d"), "CHF", "Swiss Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ad658eb2-a88d-4375-b541-e8d048355a99"), "CLF", "Chilean Unit Of Account", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("879d3b84-024b-4f1f-bca5-8b903793592b"), "CLP", "Chilean Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0410fad8-4ac2-4a3d-97da-1cffe05cf6ec"), "CNY", "Chinese Yuan Renminbi", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("bd22904e-adeb-47a6-aac8-fc898b1dba2c"), "COP", "Colombian Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0f4dde2b-0a47-45d9-92bf-d2a7e695cdae"), "CRC", "Costa Rican Colon", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("dd77a488-55da-4cec-901d-4b29a1d93843"), "CVE", "Cape Verdean Escudo", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0216b41e-a3b3-406c-9dbc-e9aa92000fdf"), "CZK", "Czech Koruna", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("265eb2fa-3013-418b-bbda-f5f8d24ba5d1"), "DJF", "Djiboutian Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("17bd2eb2-a5f0-4b68-9b96-52f6873852dd"), "DKK", "Danish Krone", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e80e25d1-55a0-41c1-b997-bb5d4f168fb6"), "DOP", "Dominican Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b4fd0878-55ec-4787-a283-22737c488904"), "DZD", "Algerian Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("657ced24-1e4f-4fb0-ae73-675b0cbae3ed"), "EGP", "Egyptian Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a4f3bacb-f4bd-476e-a0c6-29808ccdd9e9"), "ERN", "Eritrean Nakfa", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("4ac5da22-761d-4e38-aef9-3fa5e04850fb"), "ETB", "Ethiopian Birr", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0ceeb7a8-899e-47f5-8a34-d8cdf020fed6"), "EUR", "European Euro", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("0d19efdc-e952-41ec-bb8d-d27684e02399"), "FJD", "Fijian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("029aff6f-1199-45ce-b283-a31381af9975"), "FKP", "Falkland Islands Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7f2a045c-5fa6-4c0d-b8ec-f8b5e5a4a13c"), "GBP", "Pound Sterling", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ecdd2d5e-688f-4598-9c6d-c531f85bdc7f"), "GEL", "Georgian Lari", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a4edbb34-d71f-40f8-9893-68640109702d"), "GHS", "Ghanaian Cedi", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fc5529cc-b20c-4e4c-a188-797e1cf01a8d"), "GIP", "Gibraltar Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("211a84ff-746b-4333-a722-ec721dac3dfe"), "GMD", "Gambian Dalasi", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("623e46d1-b8b3-4655-9d61-0ba1b0b4b5a7"), "GNF", "Guinean Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c26ccc69-43b5-4e81-8293-6967bba02cbc"), "GTQ", "Guatemalan Quetzal", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ba686d5b-6a18-46db-8850-5a8748592a31"), "GYD", "Guyanese Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b0b4262b-aeb0-49fb-8cf9-37ab4cd7e590"), "HKD", "Hong Kong Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("2f84dfe7-e105-4db6-9cbe-48540bd61ee9"), "HNL", "Honduran Lempira", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("299762fe-bb95-4238-8752-09d42d5a5a6f"), "HRK", "Croatian Kuna", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("4e472979-4afc-48ba-ae1d-c689249e1e68"), "HTG", "Haitian Gourde", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c76a5708-e34f-4c11-8c93-1acf2b175347"), "HUF", "Hungarian Forint", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5d45b0b4-fbd2-4800-a1a1-1bad3730f0b0"), "IDR", "Indonesian Rupiah", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b16ccf6b-cb20-4c9a-b87b-d1673a8d7bd7"), "ILS", "Israeli New Shekel", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f3bfde28-0b9f-4dcc-a08e-5a741ca379ba"), "INR", "Indian Rupee", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d5bc6c0d-512d-4499-b6be-95424d9c1cb8"), "IQD", "Iraqi Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c98d7fc8-0b47-4cd4-bb2c-9790bd81f7bd"), "IRR", "Iranian Rial", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("6355117f-ac0a-47b7-a590-2e5b43f87f27"), "ISK", "Icelandic Krona", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("edc7e969-2a2a-4f24-b71c-788301456919"), "JMD", "Jamaican Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("be69d4b3-49eb-43de-9ace-e2f92bd746c7"), "JOD", "Jordanian Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("172111bd-b698-4345-89b9-761f731a7e1f"), "JPY", "Japanese Yen", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("9336504a-1147-4765-bf2a-9199f2a0beaa"), "KES", "Kenyan Shilling", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("698d8a45-94c6-4668-94b7-a9032051f2ff"), "KGS", "Kyrgyzstani Som", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("1ebcf064-e5b7-4778-8324-baf80b5dd5b0"), "KHR", "Cambodian Riel", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3df3af46-623a-4b36-a5b3-b45214fe705e"), "KMF", "Comorian Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b176b359-9ead-4e27-b842-a57d76c06f73"), "KRW", "South Korean Won", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d1069f64-5c35-4fdc-a003-66a894076e9d"), "KWD", "Kuwaiti Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("27dc4462-051c-4ca5-82ef-17439d5bc5fd"), "KYD", "Cayman Islands Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("ff5bf5c7-568c-4f43-b8a3-9be44a068fba"), "KZT", "Kazakhstani Tenge", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7bd5fd9e-782d-4de9-802c-6ead9bd6c4de"), "LAK", "Lao Kip", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("549ae714-5522-46aa-812b-89f691a95318"), "LBP", "Lebanese Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f67bbce3-e614-4b67-ae48-7cf798d7c270"), "LKR", "Sri Lankan Rupee", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("64aa176d-1ffe-460b-8d39-054069acfeec"), "LRD", "Liberian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f6367964-9d91-4bd7-be87-78482ee1e1b1"), "LSL", "Lesotho Loti", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("df03e5e1-40ca-4b15-ae45-aa707a8c701c"), "LYD", "Libyan Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("20e3ee3d-6d17-470d-b4a7-c0210be7a30a"), "MAD", "Moroccan Dirham", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("afffc44c-bfb5-4355-abc1-6a3ba7280026"), "MDL", "Moldovan Leu", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("2e4b9000-4582-4324-ade4-ce895e1c207d"), "MGA", "Malagasy Ariary", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("399e58e4-9951-4f3c-92e4-22a6b888e05d"), "MKD", "Macedonian Denar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("116f0e91-f6a4-46be-81d3-312636f726fa"), "MMK", "Myanmar Kyat", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b9b717b2-5fe0-4941-b01e-670f3f675592"), "MNT", "Mongolian Tugrik", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("2246f165-c2b2-4f7b-a335-c558705a7c74"), "MOP", "Macanese Pataca", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f68062e0-eaee-40ef-912e-464ab7d39d56"), "MRO", "Mauritanian Ouguiya", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a4e0984a-65a4-41c1-8d98-e4fbdfa9aff5"), "MUR", "Mauritian Rupee", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7c4cd746-7b40-404b-9a1b-ead636101e38"), "MVR", "Maldivian Rufiyaa", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("16467229-84ae-44ab-8631-8ca09bf41a66"), "MWK", "Malawian Kwacha", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("aeaee163-326f-4e2b-bc0d-2bb91df5ea5a"), "MXN", "Mexican Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("6d435c72-9c86-4706-b0d2-2fdf524a1739"), "MYR", "Malaysian Ringgit", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("98dbc0e5-af0f-4c9f-91c3-ebdf605ed166"), "MZN", "Mozambican Metical", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("bb67cadd-9e4d-492c-9fd1-99931840fd8f"), "NAD", "Namibian Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("37b5433d-3c15-41f7-9090-4c75b963e10c"), "NGN", "Nigerian Naira", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("4200d94d-44e8-4fbc-b9b0-8bd88f52c42b"), "NIO", "Nicaraguan Cordoba", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("bf27c536-d4b4-481b-8c44-8cfa3df42221"), "NOK", "Norwegian Krone", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f7d91fad-bae1-4043-b542-16c0cda887c5"), "NPR", "Nepalese Rupee", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("625ec600-be77-4ab8-9fad-5906146b5a52"), "NZD", "New Zealand Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("8c2fc542-4eb2-4133-bf56-09ae369dde76"), "OMR", "Omani Rial", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("8b180dde-16dc-4779-88bd-c16ff59df3e0"), "PAB", "Panamanian Balboa", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7a2f8f13-12f2-4373-be0c-7dfa4a85d92c"), "PEN", "Peruvian Sol", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("11b3a6fe-83ca-4f42-bfe7-6e7ec6b09262"), "PHP", "Philippine Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3d3324dc-9102-4b5e-b499-79aad1e4056b"), "PKR", "Pakistani Rupee", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("fa4bc2b0-0eff-4db4-a70c-39d6acf19843"), "PLN", "Polish Zloty", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e6ee1318-b67c-4e40-b3ae-b71cba8b2f8e"), "PYG", "Paraguayan Guarani", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b01dcec7-d8e4-4eb5-a6be-a5fdf38d37aa"), "QAR", "Qatari Riyal", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("e1056bbd-4fe4-4776-98e5-a1b45e273953"), "RON", "Romanian Leu", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("3ebf6781-d459-4f9d-bb12-5bdbab75c814"), "RSD", "Serbian Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("329c3a9d-6881-43c6-9aa9-59604e8c7cb2"), "RUB", "Russian Ruble", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("adaa9e1f-b503-4e96-b67f-656403ba845e"), "RWF", "Rwandan Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("629d51f9-0fc7-467e-a82f-d5be29f698e5"), "SAR", "Saudi Arabian Riyal", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f7050657-0f31-4c35-9600-6de460be3f37"), "SCR", "Seychellois Rupee", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("02eedafc-9475-4aa6-a253-4b6ac4f24c90"), "SDG", "Sudanese Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d1758fda-9a4b-4298-953c-207c7633d01d"), "SEK", "Swedish Krona", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("cb20bc1e-077a-48aa-b1ba-51ee519f62d5"), "SGD", "Singapore Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("565273fb-c135-4ece-8876-f5769d50d52c"), "SHP", "Saint Helena Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("b92b694d-c3ee-4f48-8e18-4476420ad76d"), "SLL", "Sierra Leonean Leone", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c9813905-76a7-4414-bdb6-165ff98d8931"), "SOS", "Somali Shilling", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("bfbc39c1-daef-46e4-8721-8de4ca3b9cc8"), "SRD", "Surinamese Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("44e82696-0f28-4413-ba38-fc7d53eecbbd"), "STN", "Sao Tome And Principe Dobra", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("46e90202-8a68-408e-9b4e-18f0eda6d895"), "SYP", "Syrian Pound", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("531a113d-a294-4e14-8f62-7fe368bfe3fd"), "SVC", "Salvadoran Colón", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5e8b138d-0422-4b46-a6c3-341dd22bfa0d"), "SZL", "Swazi Lilangeni", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("538b8b21-c33d-4096-92a8-f5e6bf7e364e"), "THB", "Thai Baht", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("df48cd71-03ca-4690-aa9a-e549182ab798"), "TJS", "Tajikistani Somoni", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c72c71c1-4415-412e-b5c0-f86eb669429e"), "TMT", "Turkmen Manat", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c5a421a3-70ac-4be6-8aa6-95bc99d0c1fe"), "TND", "Tunisian Dinar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("30375e75-2010-48f9-8aec-ffcc3c18041a"), "TOP", "Tongan Pa'anga", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("8c566fac-2f8f-420a-8a07-b87b0ec5d1e0"), "TRY", "Turkish Lira", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5d459acf-bba9-4923-b035-018455284e0b"), "TTD", "Trinidad And Tobago Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("c4ced323-9c96-407b-a464-72bbcbc343af"), "TWD", "New Taiwan Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("439eb763-c96f-4e76-8180-7aa333554056"), "TZS", "Tanzanian Shilling", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("82e5f380-a014-4c96-b98d-7465a9cdb625"), "UAH", "Ukrainian Hryvnia", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("9aa39bde-ae9c-4a91-92c5-5afdeff44841"), "UGX", "Ugandan Shilling", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f49149b7-434a-4754-9604-4bf6f2400459"), "USD", "United States Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("f0ca1ffa-a3f4-45db-b239-bb68028a7bae"), "UYU", "Uruguayan Peso", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("d0b6fae6-0b4d-4424-9426-5afdf728aa1a"), "UZS", "Uzbekistani Som", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("10033ef8-e803-486b-86fa-d1a1cae3c9bd"), "VES", "Venezuelan Bolivar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("a6c4eebb-9815-4e59-befa-6761721b8103"), "VND", "Vietnamese Dong", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("38ee8d78-ed81-4fc2-be62-4a3c1700cc2a"), "VUV", "Vanuatu Vatu", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("9f91ff27-238c-4b43-9df7-8afbb1e9854c"), "WST", "Samoan Tala", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("655a555b-3048-4475-aa5b-ccdb2d9490b5"), "XAF", "Central African CFA Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("263c991d-622a-4589-aa73-0e9beaeb616f"), "XCD", "East Caribbean Dollar", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5a1ed27a-0b9b-46c3-b17a-40928d392179"), "XOF", "West African CFA Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("5acc74b9-b64d-49be-9c65-804dc9194cee"), "XPF", "CFP Franc", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("7b0d7f1b-31e6-4ab1-a1b4-65ee8bde561e"), "YER", "Yemeni Rial", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("9d7c0113-021d-4893-b114-0a419e0dc359"), "ZAR", "South African Rand", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("717d766a-4e27-4ae4-8ce5-92d5835201ee"), "ZMK", "Zambian Kwacha (pre-2013)", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("46488ed3-a02a-41ef-b548-f3beb2586909"), "ZMW", "Zambian Kwacha", "" });
            migrationBuilder.InsertData(
                table: "MetalPriceSymbols",
                columns: new[] { "Id", "Code", "Name", "Unit" },
                values: new object[] { new Guid("2f11e713-ee31-40da-8b74-f57f4df44dad"), "Provided by MetalpriceAPI", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetalPriceSymbols");
        }
    }
}
