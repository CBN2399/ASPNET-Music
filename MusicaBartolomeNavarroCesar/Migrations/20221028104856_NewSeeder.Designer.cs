﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicaBartolomeNavarroCesar.Data;

#nullable disable

namespace MusicaBartolomeNavarroCesar.Migrations
{
    [DbContext(typeof(ChinookContext))]
    [Migration("20221028104856_NewSeeder")]
    partial class NewSeeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.HasData(
                        new
                        {
                            Id = "7e3d4e7a-d7ef-4e45-be48-4dfee800a62f",
                            ConcurrencyStamp = "ffe7ddd7-18e3-4cb3-810e-c07d1a7dd85b",
                            Name = "default",
                            NormalizedName = "DEFAULT"
                        },
                        new
                        {
                            Id = "bce05143-2ed9-4fef-87da-ff21632ca4ee",
                            ConcurrencyStamp = "c8779126-4681-4397-8c6e-38858c942d7b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e9236eac-0a10-4e1b-8039-488f98521c50",
                            ConcurrencyStamp = "2a47886c-813a-464e-bfa7-96d24700f879",
                            Name = "Premium",
                            NormalizedName = "PREMIUM"
                        },
                        new
                        {
                            Id = "e6f61be6-a24d-428f-9099-4d47de58e39b",
                            ConcurrencyStamp = "d19748ef-d574-4699-b1c0-dfead510f7b4",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.HasData(
                        new
                        {
                            Id = "bd6afd7f-fda0-486b-a38f-621ed634555e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b01df5ae-623c-4ce4-98ee-5cc42ac1b94c",
                            Email = "Admin@disquera.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DISQUERA.COM",
                            NormalizedUserName = "ADMIN@DISQUERA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPFIOkT77RsQ8hEbSLZvzMFAnn3IUvhU3SIhoH74Kv6+UUTVOQtAvaC+csj7mOPxBg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b356c920-b83f-4d38-b6c0-d0936ef412c4",
                            TwoFactorEnabled = false,
                            UserName = "Admin@disquera.com"
                        },
                        new
                        {
                            Id = "8a7ce38a-4e04-4a13-8a63-fafcb22a0c77",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e9442b15-fdb6-4268-9b66-52df65e72c64",
                            Email = "Manager@disquera.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@DISQUERA.COM",
                            NormalizedUserName = "MANAGER@DISQUERA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEN6DLKyx5z8LS8fQqPE6OCup2aUZfyeXOPcScfH7udMSyDWAc9E9Med8dtOv12fHlw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "db7be9e0-fc81-4bbf-8f51-001880f9cf3b",
                            TwoFactorEnabled = false,
                            UserName = "Manager@disquera.com"
                        },
                        new
                        {
                            Id = "df6d9cde-c856-4c45-8cac-f4a79dfe2c27",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9aede6d8-f3e8-4539-8080-fadf2a0ce4b6",
                            Email = "premium1@disquera.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PREMIUM1@DISQUERA.COM",
                            NormalizedUserName = "PREMIUM1@DISQUERA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECp2nysMkIQ2lhbDxQDE0ue5X9StzJk6JHMIVytjnL+y/uqgZctWZCEJ8GZLxUhEzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "622c8464-ad97-481c-a27c-c0edd386b597",
                            TwoFactorEnabled = false,
                            UserName = "premium1@disquera.com"
                        },
                        new
                        {
                            Id = "2f8ac9d1-3761-43b9-bfc8-c2cb0af0d035",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1620cbb2-bef7-46ac-9530-cc1276d8591f",
                            Email = "premium2@disquera.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PREMIUM2@DISQUERA.COM",
                            NormalizedUserName = "PREMIUM2@DISQUERA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDdcqSkXldZtKZdbaInmM8wLNjfjcTKhJx4lgipHMYAy0kEtzm8INE9sOZlcaKDG8Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "62a3d9da-4c2d-4a49-bc9f-a03c4d8d48c4",
                            TwoFactorEnabled = false,
                            UserName = "premium2@disquera.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "bd6afd7f-fda0-486b-a38f-621ed634555e",
                            RoleId = "bce05143-2ed9-4fef-87da-ff21632ca4ee"
                        },
                        new
                        {
                            UserId = "8a7ce38a-4e04-4a13-8a63-fafcb22a0c77",
                            RoleId = "e6f61be6-a24d-428f-9099-4d47de58e39b"
                        },
                        new
                        {
                            UserId = "df6d9cde-c856-4c45-8cac-f4a79dfe2c27",
                            RoleId = "e9236eac-0a10-4e1b-8039-488f98521c50"
                        },
                        new
                        {
                            UserId = "2f8ac9d1-3761-43b9-bfc8-c2cb0af0d035",
                            RoleId = "e9236eac-0a10-4e1b-8039-488f98521c50"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.HasKey("AlbumId");

                    b.HasIndex(new[] { "ArtistId" }, "IFK_AlbumArtistId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int?>("Bytes")
                        .HasColumnType("int");

                    b.Property<string>("Composer")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Milliseconds")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric(10,2)");

                    b.HasKey("TrackId");

                    b.HasIndex(new[] { "AlbumId" }, "IFK_TrackAlbumId");

                    b.HasIndex(new[] { "GenreId" }, "IFK_TrackGenreId");

                    b.HasIndex(new[] { "MediaTypeId" }, "IFK_TrackMediaTypeId");

                    b.ToTable("Track");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Album", b =>
                {
                    b.HasOne("MusicaBartolomeNavarroCesar.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .IsRequired()
                        .HasConstraintName("FK_AlbumArtistId");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Track", b =>
                {
                    b.HasOne("MusicaBartolomeNavarroCesar.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .HasConstraintName("FK_TrackAlbumId");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicaBartolomeNavarroCesar.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
