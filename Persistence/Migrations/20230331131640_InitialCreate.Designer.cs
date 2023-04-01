﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230331131640_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Org", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("OrgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrgTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SSClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SSClientSecret")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SSOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SaveDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrgTypeId");

                    b.ToTable("Org");
                });

            modelBuilder.Entity("Domain.OrgType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaveDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OrgType");
                });

            modelBuilder.Entity("Domain.Org", b =>
                {
                    b.HasOne("Domain.OrgType", "OrgType")
                        .WithMany()
                        .HasForeignKey("OrgTypeId");

                    b.Navigation("OrgType");
                });
#pragma warning restore 612, 618
        }
    }
}