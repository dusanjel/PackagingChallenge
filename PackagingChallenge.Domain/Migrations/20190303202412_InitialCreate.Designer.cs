﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PackagingChallenge.Domain.Models;

namespace PackagingChallenge.Domain.Migrations
{
    [DbContext(typeof(PackagingChallengeContext))]
    [Migration("20190303202412_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PackagingChallenge.Domain.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxWeight");

                    b.HasKey("Id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("PackagingChallenge.Domain.Models.PackageList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<int>("IndexNumber");

                    b.Property<int>("Item");

                    b.Property<int?>("PackageId");

                    b.Property<decimal>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.ToTable("PackageLists");
                });

            modelBuilder.Entity("PackagingChallenge.Domain.Models.PackageList", b =>
                {
                    b.HasOne("PackagingChallenge.Domain.Models.Package")
                        .WithMany("PackageList")
                        .HasForeignKey("PackageId");
                });
#pragma warning restore 612, 618
        }
    }
}
