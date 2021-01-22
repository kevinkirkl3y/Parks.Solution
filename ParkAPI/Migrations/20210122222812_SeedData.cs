using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TotalArea",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TotalArea",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "Address", "Name", "State", "TotalArea", "Website" },
                values: new object[,]
                {
                    { 1, "PO Box 129 Grand Canyon, AZ 86023", "Grand Canyon National Park", "Arizona", "1902 mi²", "https://www.nps.gov/grca/index.htm" },
                    { 2, "P.O. Box 579 Death Valley, CA 92328", "Death Valley National Park", "California", "5,270 mi²", "https://www.nps.gov/deva/index.htm" },
                    { 3, "PO Box 577 Yosemite, CA 95389", "Yosemite National Park", "California", "1,169 mi²", "https://www.nps.gov/yose/index.htm" },
                    { 4, "PO Box 7 Crater Lake , OR 97604", "Crater Lake National Park", "Oregon", "20.6 mi²", "https://www.nps.gov/crla/index.htm" },
                    { 5, "HC 70, PO Box15 Torrey, UT 84775", "Capitol Reef National Park", "Utah", "378 mi²", "https://www.nps.gov/care/index.htm" }
                });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "Address", "Name", "State", "TotalArea", "Website" },
                values: new object[,]
                {
                    { 1, "6109 N. Apache Trail Apache Junction, AZ 85119", "Lost Dutchman State Park", "Arizona", ".5 mi²", "https://azstateparks.com/lost-dutchman/" },
                    { 2, "UT-313, Moab, UT 84532", "Dead Horse Point State Park", "Utah", "8.4 mi²", "https://stateparks.utah.gov/parks/dead-horse/" },
                    { 3, " 44°21'58.01N, 121° 8'13.32W or 44.367612, -121.138988", "Smith Rock State Park", "Oregon", "1.1 mi²", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=36" },
                    { 4, "138 Emerald Bay Rd, South Lake Tahoe, CA 96150", "Emerald Bay State Park", "California", "2.4 mi²", "https://www.parks.ca.gov/?page_id=506" },
                    { 5, "4050 Red Rock Loop Rd Sedona, AZ 86336", "Red Rock State Park", "Arizona", ".45 mi²", "https://azstateparks.com/red-rock/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TotalArea",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TotalArea",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
