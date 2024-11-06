﻿// <auto-generated />
using System;
using A1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace A1.Migrations
{
    [DbContext(typeof(BaiTapDbContext))]
    partial class BaiTapDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("A1.Models.GioHang", b =>
                {
                    b.Property<Guid?>("IdGH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Name")
                        .HasColumnType("int");

                    b.Property<Guid?>("SPid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdGH");

                    b.ToTable("gioHang");
                });

            modelBuilder.Entity("A1.Models.GioHangSanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("GioHangIdGH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SanPhamIdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Soluong")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GioHangIdGH");

                    b.HasIndex("SanPhamIdSP");

                    b.ToTable("GioHangSanPhams");
                });

            modelBuilder.Entity("A1.Models.SanPham", b =>
                {
                    b.Property<Guid?>("IdSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("price")
                        .HasColumnType("real");

                    b.HasKey("IdSP");

                    b.HasIndex("UserId");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("A1.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("A1.Models.GioHangSanPham", b =>
                {
                    b.HasOne("A1.Models.GioHang", null)
                        .WithMany("CartProducts")
                        .HasForeignKey("GioHangIdGH");

                    b.HasOne("A1.Models.SanPham", null)
                        .WithMany("CartProducts")
                        .HasForeignKey("SanPhamIdSP");
                });

            modelBuilder.Entity("A1.Models.SanPham", b =>
                {
                    b.HasOne("A1.Models.User", null)
                        .WithMany("sanPhams")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("A1.Models.GioHang", b =>
                {
                    b.Navigation("CartProducts");
                });

            modelBuilder.Entity("A1.Models.SanPham", b =>
                {
                    b.Navigation("CartProducts");
                });

            modelBuilder.Entity("A1.Models.User", b =>
                {
                    b.Navigation("sanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
