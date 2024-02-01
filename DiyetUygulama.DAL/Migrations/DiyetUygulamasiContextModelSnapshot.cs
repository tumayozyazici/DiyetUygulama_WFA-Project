﻿// <auto-generated />
using System;
using DiyetUygulama.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyetUygulama.DAL.Migrations
{
    [DbContext(typeof(DiyetUygulamasiContext))]
    partial class DiyetUygulamasiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("AdminSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            AdminName = "admin",
                            AdminSurname = "admin",
                            CreatedDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8217),
                            Email = "admin@admin.com",
                            Password = "password",
                            Status = 0
                        });
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Et",
                            CreatedDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8207),
                            Status = 0
                        });
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MealDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WaterConsumption")
                        .HasColumnType("integer");

                    b.HasKey("MealId");

                    b.HasIndex("MemberId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            MealId = 1,
                            CreatedDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8225),
                            MealDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8224),
                            MealType = 1,
                            MemberId = 1,
                            Status = 0
                        });
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MemberSurname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("MembershipDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MemberId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberId = 1,
                            CreatedDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8096),
                            Email = "member@member.com",
                            MemberName = "Tümay",
                            MemberSurname = "Özyazıcı",
                            MembershipDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8082),
                            Password = "password",
                            Status = 0
                        });
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.MemberDetail", b =>
                {
                    b.Property<int>("MemberDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberDetailId"), 1L, 1);

                    b.Property<int?>("Allergy1")
                        .HasColumnType("int");

                    b.Property<int?>("Allergy2")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("FatRatio")
                        .HasColumnType("float");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsDiabetes")
                        .HasColumnType("bit");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("MemberDetailId");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("MemberDetails");

                    b.HasData(
                        new
                        {
                            MemberDetailId = 1,
                            Allergy1 = 0,
                            Allergy2 = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8196),
                            FatRatio = 20.0,
                            Gender = true,
                            Height = 180.0,
                            IsDiabetes = true,
                            MemberId = 1,
                            Status = 0,
                            Weight = 100.0
                        });
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbonhydrate")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<bool>("HasGluten")
                        .HasColumnType("bit");

                    b.Property<bool>("HasLactose")
                        .HasColumnType("bit");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar");

                    b.Property<string>("Portion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MealId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Amount = 120.0,
                            Calories = 100.0,
                            Carbonhydrate = 2.6000000000000001,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 2, 1, 12, 11, 57, 654, DateTimeKind.Local).AddTicks(8231),
                            Fat = 10.56,
                            HasGluten = false,
                            HasLactose = false,
                            MealId = 1,
                            Portion = "1 dilim",
                            ProductName = "Bonfile",
                            Protein = 34.5,
                            Status = 0,
                            Unit = "g"
                        });
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Meal", b =>
                {
                    b.HasOne("DiyetUygulama.DATA.Entities.Member", "Member")
                        .WithMany("Meals")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.MemberDetail", b =>
                {
                    b.HasOne("DiyetUygulama.DATA.Entities.Member", "Member")
                        .WithOne("MemberDetail")
                        .HasForeignKey("DiyetUygulama.DATA.Entities.MemberDetail", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Product", b =>
                {
                    b.HasOne("DiyetUygulama.DATA.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetUygulama.DATA.Entities.Meal", "Meal")
                        .WithMany("Products")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Meal", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DiyetUygulama.DATA.Entities.Member", b =>
                {
                    b.Navigation("Meals");

                    b.Navigation("MemberDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
