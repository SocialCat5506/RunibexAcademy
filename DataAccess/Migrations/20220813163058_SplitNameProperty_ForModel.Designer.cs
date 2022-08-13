﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AcademyContext))]
    [Migration("20220813163058_SplitNameProperty_ForModel")]
    partial class SplitNameProperty_ForModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<decimal>("DailyPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool?>("MilageLimit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<bool>("Transmission")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ModelId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Entities.Concrete.CarImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EditDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarImages");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IsoCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Entities.Concrete.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("CardHolderNameHash")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("CardHolderNameSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("CardNumberHash")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("CardNumberSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("ExpirationDateHash")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("ExpirationDateSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("Entities.Concrete.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IsoCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Entities.Concrete.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("Entities.Concrete.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("NamePrefix")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NameSuffix")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CreditCardId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Entities.Concrete.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("MilageLimit")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.HasIndex("SupplierId");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Entities.Concrete.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(320)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(500)");

                    b.Property<bool?>("Stasus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.DTOs.CarDetailDto", b =>
                {
                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Milage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("CarDetailDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.CarImageListDto", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("carImageListDtos", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.CreditCardForStoreDto", b =>
                {
                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExpirationMonth")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ExpirationYear")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("CreditCardForStoreDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.PaymentDetailDto", b =>
                {
                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("PaymentDetailDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.RentalDetailDto", b =>
                {
                    b.Property<string>("CarDetail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime?>("RentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("isReturned")
                        .HasColumnType("tinyint(1)");

                    b.ToTable("RentalDetailDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.UserDetailDto", b =>
                {
                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool?>("Stasus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("UserDetailDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.UserForLoginDto", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("UserForLoginDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Entities.DTOs.UserForRegisterDto", b =>
                {
                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("UserForRegisterDto", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("OperationClaimUser", b =>
                {
                    b.Property<int>("OperationClaimsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("OperationClaimsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("OperationClaimUser");
                });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.FuelType", "FuelType")
                        .WithMany("Cars")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Supplier", "Supplier")
                        .WithMany("Cars")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Color");

                    b.Navigation("FuelType");

                    b.Navigation("Model");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Entities.Concrete.CarImage", b =>
                {
                    b.HasOne("Entities.Concrete.Car", "Car")
                        .WithMany("CarImages")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Entities.Concrete.CreditCard", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("CreditCards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Model", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Entities.Concrete.Payment", b =>
                {
                    b.HasOne("Entities.Concrete.CreditCard", "CreditCard")
                        .WithMany("Payments")
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Currency", "Currency")
                        .WithMany("Payments")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditCard");

                    b.Navigation("Currency");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Rental", b =>
                {
                    b.HasOne("Entities.Concrete.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Payment", "Payment")
                        .WithOne("Rental")
                        .HasForeignKey("Entities.Concrete.Rental", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Payment");

                    b.Navigation("Supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Supplier", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithOne("Supplier")
                        .HasForeignKey("Entities.Concrete.Supplier", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("OperationClaimUser", b =>
                {
                    b.HasOne("Entities.Concrete.OperationClaim", null)
                        .WithMany()
                        .HasForeignKey("OperationClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Models");
                });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
                {
                    b.Navigation("CarImages");

                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Concrete.CreditCard", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Entities.Concrete.Currency", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Entities.Concrete.FuelType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Entities.Concrete.Model", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Entities.Concrete.Payment", b =>
                {
                    b.Navigation("Rental")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Supplier", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("CreditCards");

                    b.Navigation("Payments");

                    b.Navigation("Supplier")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
