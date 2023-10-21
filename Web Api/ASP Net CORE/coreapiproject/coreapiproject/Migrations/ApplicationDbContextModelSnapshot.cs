﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreapiproject.Entity;

namespace coreapiproject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreapiproject.Entity.Sporcular", b =>
                {
                    b.Property<int>("SporcuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TakimlarID")
                        .HasColumnType("int");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SporcuID");

                    b.HasIndex("TakimlarID");

                    b.ToTable("Sporculars");
                });

            modelBuilder.Entity("coreapiproject.Entity.Takimlar", b =>
                {
                    b.Property<int>("TakimlarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TakimAD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TakimlarID");

                    b.ToTable("Takimlars");
                });

            modelBuilder.Entity("coreapiproject.Entity.Sporcular", b =>
                {
                    b.HasOne("coreapiproject.Entity.Takimlar", "Takimlar")
                        .WithMany()
                        .HasForeignKey("TakimlarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Takimlar");
                });
#pragma warning restore 612, 618
        }
    }
}