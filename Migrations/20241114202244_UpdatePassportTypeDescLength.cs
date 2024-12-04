using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PassportsApp.Migrations
{
    public partial class UpdatePassportTypeDescLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authority_Country_Country",
                table: "Authority");

            migrationBuilder.DropForeignKey(
                name: "FK_Passport_PassportsHolder_HolderId",
                table: "Passport");

            migrationBuilder.DropForeignKey(
                name: "FK_Passport_PassportType_PasportType",
                table: "Passport");

            migrationBuilder.DropForeignKey(
                name: "FK_PassportsHolder_Sex_SexAbr",
                table: "PassportsHolder");

            migrationBuilder.DropIndex(
                name: "IX_Passport_HolderId",
                table: "Passport");

            migrationBuilder.DropIndex(
                name: "IX_Passport_PasportType",
                table: "Passport");

            migrationBuilder.DropIndex(
                name: "IX_Authority_Country",
                table: "Authority");

            migrationBuilder.DropColumn(
                name: "HolderId",
                table: "Passport");

            migrationBuilder.DropColumn(
                name: "PasportType",
                table: "Passport");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Authority");

            migrationBuilder.RenameColumn(
                name: "Birtday",
                table: "PassportsHolder",
                newName: "Birthday");

            migrationBuilder.AlterColumn<string>(
                name: "PassportTypeDesc",
                table: "PassportType",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "PassportsHolder",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SexAbr",
                table: "PassportsHolder",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HolderPhoto",
                table: "PassportsHolder",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HolderName",
                table: "PassportsHolder",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "PassportsHolder",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Passport",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Country",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Authority",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Passport_Type",
                table: "Passport",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Authority_CountryCode",
                table: "Authority",
                column: "CountryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Authority_Country_CountryCode",
                table: "Authority",
                column: "CountryCode",
                principalTable: "Country",
                principalColumn: "CountryCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passport_PassportType_Type",
                table: "Passport",
                column: "Type",
                principalTable: "PassportType",
                principalColumn: "PassportTypeAbr",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassportsHolder_Sex_SexAbr",
                table: "PassportsHolder",
                column: "SexAbr",
                principalTable: "Sex",
                principalColumn: "SexAbr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authority_Country_CountryCode",
                table: "Authority");

            migrationBuilder.DropForeignKey(
                name: "FK_Passport_PassportType_Type",
                table: "Passport");

            migrationBuilder.DropForeignKey(
                name: "FK_PassportsHolder_Sex_SexAbr",
                table: "PassportsHolder");

            migrationBuilder.DropIndex(
                name: "IX_Passport_Type",
                table: "Passport");

            migrationBuilder.DropIndex(
                name: "IX_Authority_CountryCode",
                table: "Authority");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Passport");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Authority");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "PassportsHolder",
                newName: "Birtday");

            migrationBuilder.UpdateData(
                table: "PassportType",
                keyColumn: "PassportTypeDesc",
                keyValue: null,
                column: "PassportTypeDesc",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PassportTypeDesc",
                table: "PassportType",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PassportsHolder",
                keyColumn: "Signature",
                keyValue: null,
                column: "Signature",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Signature",
                table: "PassportsHolder",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PassportsHolder",
                keyColumn: "SexAbr",
                keyValue: null,
                column: "SexAbr",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "SexAbr",
                table: "PassportsHolder",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PassportsHolder",
                keyColumn: "HolderPhoto",
                keyValue: null,
                column: "HolderPhoto",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "HolderPhoto",
                table: "PassportsHolder",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PassportsHolder",
                keyColumn: "HolderName",
                keyValue: null,
                column: "HolderName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "HolderName",
                table: "PassportsHolder",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PassportsHolder",
                keyColumn: "BirthPlace",
                keyValue: null,
                column: "BirthPlace",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "PassportsHolder",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "HolderId",
                table: "Passport",
                type: "int",
                maxLength: 15,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PasportType",
                table: "Passport",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryName",
                keyValue: null,
                column: "CountryName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Country",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Authority",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Passport_HolderId",
                table: "Passport",
                column: "HolderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passport_PasportType",
                table: "Passport",
                column: "PasportType");

            migrationBuilder.CreateIndex(
                name: "IX_Authority_Country",
                table: "Authority",
                column: "Country");

            migrationBuilder.AddForeignKey(
                name: "FK_Authority_Country_Country",
                table: "Authority",
                column: "Country",
                principalTable: "Country",
                principalColumn: "CountryCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passport_PassportsHolder_HolderId",
                table: "Passport",
                column: "HolderId",
                principalTable: "PassportsHolder",
                principalColumn: "HolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Passport_PassportType_PasportType",
                table: "Passport",
                column: "PasportType",
                principalTable: "PassportType",
                principalColumn: "PassportTypeAbr",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassportsHolder_Sex_SexAbr",
                table: "PassportsHolder",
                column: "SexAbr",
                principalTable: "Sex",
                principalColumn: "SexAbr",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
