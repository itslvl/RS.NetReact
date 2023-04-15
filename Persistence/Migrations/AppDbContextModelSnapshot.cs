﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Agama", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agama");
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Bahasa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bahasa");
                });

            modelBuilder.Entity("Domain.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("Domain.Golongan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("UraianGolongan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UraianPangkat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Golongan");
                });

            modelBuilder.Entity("Domain.Jabatan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jabatan");
                });

            modelBuilder.Entity("Domain.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LocationTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrgId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZoneId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LocationTypeId");

                    b.HasIndex("OrgId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Domain.LocationType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocationType");
                });

            modelBuilder.Entity("Domain.Negara", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Negara");
                });

            modelBuilder.Entity("Domain.Org", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("OrgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrgTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Parent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SSClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SSClientSecret")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SSOrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SaveDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrgTypeID");

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

            modelBuilder.Entity("Domain.Pegawai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AgamaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Alamat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BahasaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GolonganId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IsFakasi")
                        .HasColumnType("int");

                    b.Property<Guid>("JabatanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NIP")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nama")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("NegaraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Pendidikan3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PendidikanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PerkawinanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PictFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SukuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TglLahir")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TlgMasuk")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tlp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TmpLahir")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("ZoneId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AgamaId");

                    b.HasIndex("BahasaId");

                    b.HasIndex("GenderId");

                    b.HasIndex("GolonganId");

                    b.HasIndex("JabatanId");

                    b.HasIndex("NegaraId");

                    b.HasIndex("Pendidikan3Id");

                    b.HasIndex("PendidikanId");

                    b.HasIndex("PerkawinanId");

                    b.HasIndex("SukuId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Pegawai");
                });

            modelBuilder.Entity("Domain.Pendidikan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pendidikan");
                });

            modelBuilder.Entity("Domain.Pendidikan1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pendidikan1");
                });

            modelBuilder.Entity("Domain.Pendidikan2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Pendidikan2");
                });

            modelBuilder.Entity("Domain.Pendidikan3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Pendidikan3");
                });

            modelBuilder.Entity("Domain.Perkawinan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perkawinan");
                });

            modelBuilder.Entity("Domain.Suku", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<string>("Uraian")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suku");
                });

            modelBuilder.Entity("Domain.Zone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("VillageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Location", b =>
                {
                    b.HasOne("Domain.LocationType", "LocationType")
                        .WithMany("Location")
                        .HasForeignKey("LocationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Org", null)
                        .WithMany("Location")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Zone", "Zone")
                        .WithMany("Location")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationType");

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("Domain.Org", b =>
                {
                    b.HasOne("Domain.OrgType", "OrgType")
                        .WithMany("Org")
                        .HasForeignKey("OrgTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrgType");
                });

            modelBuilder.Entity("Domain.Pegawai", b =>
                {
                    b.HasOne("Domain.Agama", "PegawaiAgama")
                        .WithMany("AgamaPegawai")
                        .HasForeignKey("AgamaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Bahasa", "PegawaiBahasa")
                        .WithMany("BahasaPegawai")
                        .HasForeignKey("BahasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Gender", "PegawaiGender")
                        .WithMany("GenderPegawai")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Golongan", "PegawaiGolongan")
                        .WithMany("GolonganPegawai")
                        .HasForeignKey("GolonganId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Jabatan", "PegawaiJabatan")
                        .WithMany("JabatanPegawai")
                        .HasForeignKey("JabatanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Negara", "PegawaiNegara")
                        .WithMany("NegaraPegawai")
                        .HasForeignKey("NegaraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Pendidikan3", "PegawaiPendidikan3")
                        .WithMany("Pendidikan3Pegawai")
                        .HasForeignKey("Pendidikan3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Pendidikan", "PegawaiPendidikan")
                        .WithMany("PendidikanPegawai")
                        .HasForeignKey("PendidikanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Perkawinan", "PegawaiPerkawinan")
                        .WithMany("PerkawinanPegawai")
                        .HasForeignKey("PerkawinanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Suku", "PegawaiSuku")
                        .WithMany("SukuPegawai")
                        .HasForeignKey("SukuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Zone", "PegawaiZone")
                        .WithMany()
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PegawaiAgama");

                    b.Navigation("PegawaiBahasa");

                    b.Navigation("PegawaiGender");

                    b.Navigation("PegawaiGolongan");

                    b.Navigation("PegawaiJabatan");

                    b.Navigation("PegawaiNegara");

                    b.Navigation("PegawaiPendidikan");

                    b.Navigation("PegawaiPendidikan3");

                    b.Navigation("PegawaiPerkawinan");

                    b.Navigation("PegawaiSuku");

                    b.Navigation("PegawaiZone");
                });

            modelBuilder.Entity("Domain.Pendidikan2", b =>
                {
                    b.HasOne("Domain.Pendidikan1", "Pendidikan2Ke1")
                        .WithMany("Pendidikan1Ke2")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pendidikan2Ke1");
                });

            modelBuilder.Entity("Domain.Pendidikan3", b =>
                {
                    b.HasOne("Domain.Pendidikan2", "Pendidikan3Ke2")
                        .WithMany("Pendidikan2Ke3")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pendidikan3Ke2");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Agama", b =>
                {
                    b.Navigation("AgamaPegawai");
                });

            modelBuilder.Entity("Domain.Bahasa", b =>
                {
                    b.Navigation("BahasaPegawai");
                });

            modelBuilder.Entity("Domain.Gender", b =>
                {
                    b.Navigation("GenderPegawai");
                });

            modelBuilder.Entity("Domain.Golongan", b =>
                {
                    b.Navigation("GolonganPegawai");
                });

            modelBuilder.Entity("Domain.Jabatan", b =>
                {
                    b.Navigation("JabatanPegawai");
                });

            modelBuilder.Entity("Domain.LocationType", b =>
                {
                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Negara", b =>
                {
                    b.Navigation("NegaraPegawai");
                });

            modelBuilder.Entity("Domain.Org", b =>
                {
                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.OrgType", b =>
                {
                    b.Navigation("Org");
                });

            modelBuilder.Entity("Domain.Pendidikan", b =>
                {
                    b.Navigation("PendidikanPegawai");
                });

            modelBuilder.Entity("Domain.Pendidikan1", b =>
                {
                    b.Navigation("Pendidikan1Ke2");
                });

            modelBuilder.Entity("Domain.Pendidikan2", b =>
                {
                    b.Navigation("Pendidikan2Ke3");
                });

            modelBuilder.Entity("Domain.Pendidikan3", b =>
                {
                    b.Navigation("Pendidikan3Pegawai");
                });

            modelBuilder.Entity("Domain.Perkawinan", b =>
                {
                    b.Navigation("PerkawinanPegawai");
                });

            modelBuilder.Entity("Domain.Suku", b =>
                {
                    b.Navigation("SukuPegawai");
                });

            modelBuilder.Entity("Domain.Zone", b =>
                {
                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
