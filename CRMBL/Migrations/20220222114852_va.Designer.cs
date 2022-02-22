﻿// <auto-generated />
using System;
using CRMBL.Molel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRMBL.Migrations
{
    [DbContext(typeof(CRMContext))]
    [Migration("20220222114852_va")]
    partial class va
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRMBL.Molel.Check", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerIdInChek")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("SellerIdInChek")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Checks");
                });

            modelBuilder.Entity("CRMBL.Molel.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameCustomer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CRMBL.Molel.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("NameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Producs");
                });

            modelBuilder.Entity("CRMBL.Molel.Sell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheckIdInSell")
                        .HasColumnType("int");

                    b.Property<int?>("ChekId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductIdInSell")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChekId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sells");
                });

            modelBuilder.Entity("CRMBL.Molel.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameSeller")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("CRMBL.Molel.Check", b =>
                {
                    b.HasOne("CRMBL.Molel.Customer", "Customer")
                        .WithMany("ChecksInCustomer")
                        .HasForeignKey("CustomerId");

                    b.HasOne("CRMBL.Molel.Seller", "Seller")
                        .WithMany("ChecksInSeller")
                        .HasForeignKey("SellerId");

                    b.Navigation("Customer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("CRMBL.Molel.Sell", b =>
                {
                    b.HasOne("CRMBL.Molel.Check", "Chek")
                        .WithMany("Sells")
                        .HasForeignKey("ChekId");

                    b.HasOne("CRMBL.Molel.Product", "Product")
                        .WithMany("SellI")
                        .HasForeignKey("ProductId");

                    b.Navigation("Chek");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CRMBL.Molel.Check", b =>
                {
                    b.Navigation("Sells");
                });

            modelBuilder.Entity("CRMBL.Molel.Customer", b =>
                {
                    b.Navigation("ChecksInCustomer");
                });

            modelBuilder.Entity("CRMBL.Molel.Product", b =>
                {
                    b.Navigation("SellI");
                });

            modelBuilder.Entity("CRMBL.Molel.Seller", b =>
                {
                    b.Navigation("ChecksInSeller");
                });
#pragma warning restore 612, 618
        }
    }
}
