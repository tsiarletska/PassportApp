﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PassportsApp.Data;

#nullable disable

namespace PassportsApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241113110621_AddBirthdayColumn")]
    partial class AddBirthdayColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PassportsApp.Models.Authority", b =>
                {
                    b.Property<int>("AutorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasMaxLength(255)
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HouseNum")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.HasKey("AutorityId");

                    b.HasIndex("Country");

                    b.ToTable("Authority");
                });

            modelBuilder.Entity("PassportsApp.Models.Country", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.HasKey("CountryCode");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("PassportsApp.Models.Passport", b =>
                {
                    b.Property<int>("PassportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("HolderId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<DateTime>("IssueDate")
                        .HasMaxLength(5)
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PasportType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("PassportId");

                    b.HasIndex("HolderId")
                        .IsUnique();

                    b.HasIndex("PasportType");

                    b.ToTable("Passport");
                });

            modelBuilder.Entity("PassportsApp.Models.PassportHolder", b =>
                {
                    b.Property<int>("HolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birtday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Citizenship")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("HolderPhoto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HolderSurname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("PassportId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("PatronymicMatronymic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("SexAbr")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("HolderId");

                    b.HasIndex("Citizenship");

                    b.HasIndex("PassportId");

                    b.HasIndex("SexAbr");

                    b.ToTable("PassportsHolder");
                });

            modelBuilder.Entity("PassportsApp.Models.PassportType", b =>
                {
                    b.Property<string>("PassportTypeAbr")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PassportTypeDesc")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.HasKey("PassportTypeAbr");

                    b.ToTable("PassportType");
                });

            modelBuilder.Entity("PassportsApp.Models.Sex", b =>
                {
                    b.Property<string>("SexAbr")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FullSex")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("SexAbr");

                    b.ToTable("Sex");
                });

            modelBuilder.Entity("PassportsApp.Models.Authority", b =>
                {
                    b.HasOne("PassportsApp.Models.Country", "Countries")
                        .WithMany()
                        .HasForeignKey("Country")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("PassportsApp.Models.Passport", b =>
                {
                    b.HasOne("PassportsApp.Models.PassportHolder", "PassportHolder")
                        .WithOne()
                        .HasForeignKey("PassportsApp.Models.Passport", "HolderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PassportsApp.Models.PassportType", "PassportTypes")
                        .WithMany()
                        .HasForeignKey("PasportType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PassportHolder");

                    b.Navigation("PassportTypes");
                });

            modelBuilder.Entity("PassportsApp.Models.PassportHolder", b =>
                {
                    b.HasOne("PassportsApp.Models.Country", "Countries")
                        .WithMany()
                        .HasForeignKey("Citizenship")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PassportsApp.Models.Passport", "Passport")
                        .WithMany()
                        .HasForeignKey("PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PassportsApp.Models.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexAbr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");

                    b.Navigation("Passport");

                    b.Navigation("Sex");
                });
#pragma warning restore 612, 618
        }
    }
}
