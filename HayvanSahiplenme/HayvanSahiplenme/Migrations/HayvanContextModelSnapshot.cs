﻿// <auto-generated />
using System;
using HayvanSahiplenme.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HayvanSahiplenme.Migrations
{
    [DbContext(typeof(HayvanContext))]
    partial class HayvanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HayvanSahiplenme.Models.Cins", b =>
                {
                    b.Property<int>("CinsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CinsAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CinsAdIng")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("HayvanId")
                        .HasColumnType("int");

                    b.Property<int?>("TurId")
                        .HasColumnType("int");

                    b.HasKey("CinsId");

                    b.HasIndex("TurId");

                    b.ToTable("Cins");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Hayvan", b =>
                {
                    b.Property<int>("HayvanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AsiDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AsiDurumuIng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CinsId")
                        .HasColumnType("int");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CinsiyetIng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("HayvanId");

                    b.HasIndex("CinsId");

                    b.ToTable("Hayvan");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Ilan", b =>
                {
                    b.Property<int>("IlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AciklamaIng")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Fotograf")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("HayvanId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("IlanId");

                    b.HasIndex("HayvanId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Ilans");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adress")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TcNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TelNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Tur", b =>
                {
                    b.Property<int>("TurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TurAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TurAdIng")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TurId");

                    b.ToTable("Tur");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Cins", b =>
                {
                    b.HasOne("HayvanSahiplenme.Models.Tur", "Tur")
                        .WithMany("Cins")
                        .HasForeignKey("TurId");

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Hayvan", b =>
                {
                    b.HasOne("HayvanSahiplenme.Models.Cins", "Cins")
                        .WithMany("Hayvan")
                        .HasForeignKey("CinsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cins");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Ilan", b =>
                {
                    b.HasOne("HayvanSahiplenme.Models.Hayvan", "Hayvan")
                        .WithMany("Ilans")
                        .HasForeignKey("HayvanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HayvanSahiplenme.Models.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hayvan");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Cins", b =>
                {
                    b.Navigation("Hayvan");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Hayvan", b =>
                {
                    b.Navigation("Ilans");
                });

            modelBuilder.Entity("HayvanSahiplenme.Models.Tur", b =>
                {
                    b.Navigation("Cins");
                });
#pragma warning restore 612, 618
        }
    }
}