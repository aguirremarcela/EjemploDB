﻿// <auto-generated />
using System;
using EntityFrameworkDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    [DbContext(typeof(DataDBContext))]
    [Migration("20231020182925_ProdRecUnique")]
    partial class ProdRecUnique
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Aliquots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Percentaje")
                        .HasPrecision(9, 4)
                        .HasColumnType("decimal(9,4)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Aliquot", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Persons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Person", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6789),
                            Name = "Felipe",
                            Updated = new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6802)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6804),
                            Name = "Carlos",
                            Updated = new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6804)
                        });
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Aliquot")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id_Aliquot");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Receipts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<string>("Total")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.ToTable("Receipt", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Receipts_Detalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdReceipt")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("Unitprice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdProduct")
                        .IsUnique();

                    b.HasIndex("IdReceipt")
                        .IsUnique();

                    b.ToTable("Receipt_Details", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Product", b =>
                {
                    b.HasOne("EntityFrameworkDB.Data.Models.Aliquots", "Aliquots")
                        .WithMany("Products")
                        .HasForeignKey("Id_Aliquot")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aliquots");
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Receipts", b =>
                {
                    b.HasOne("EntityFrameworkDB.Data.Models.Persons", "Persona")
                        .WithMany("Receipts")
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Receipts_Detalles", b =>
                {
                    b.HasOne("EntityFrameworkDB.Data.Models.Product", "Product")
                        .WithMany("Receipts")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkDB.Data.Models.Receipts", "Receipts")
                        .WithMany("Detalles")
                        .HasForeignKey("IdReceipt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Aliquots", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Persons", b =>
                {
                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Product", b =>
                {
                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("EntityFrameworkDB.Data.Models.Receipts", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}