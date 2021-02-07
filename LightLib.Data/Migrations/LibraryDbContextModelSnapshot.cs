﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LightLib.Data.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("LightLib.Data.Models.Assets.AudioBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeweyIndex")
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("LengthMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfDiscs")
                        .HasColumnType("integer");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AudioBooks");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeweyIndex")
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("LengthMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.CDROM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AlternativeTitle")
                        .HasColumnType("text");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("DeweyIndex")
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cdroms");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.DVD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AlternativeTitle")
                        .HasColumnType("text");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("LengthMinutes")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UPC")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Dvds");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.LibraryAsset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("AvailabilityStatusId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int?>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AvailabilityStatusId");

                    b.HasIndex("LocationId");

                    b.ToTable("LibraryAssets");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Periodical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateOfPublication")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ISSN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniformTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Periodicals");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("AudioBookId")
                        .HasColumnType("integer");

                    b.Property<int?>("BookId")
                        .HasColumnType("integer");

                    b.Property<int?>("CDROMId")
                        .HasColumnType("integer");

                    b.Property<int?>("DVDId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("PeriodicalId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AudioBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("CDROMId");

                    b.HasIndex("DVDId");

                    b.HasIndex("PeriodicalId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.AvailabilityStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The item is lost.",
                            Name = "LOST"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The item is in good condition.",
                            Name = "GOOD_CONDITION"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The item is in unknown whereabouts and condition.",
                            Name = "UNKNOWN_CONDITION"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The item has been destroyed.",
                            Name = "DESTROYED"
                        });
                });

            modelBuilder.Entity("LightLib.Data.Models.BranchHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("BranchId")
                        .HasColumnType("integer");

                    b.Property<int>("CloseTime")
                        .HasColumnType("integer");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("integer");

                    b.Property<int>("OpenTime")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchHours");
                });

            modelBuilder.Entity("LightLib.Data.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid?>("LibraryAssetId")
                        .HasColumnType("uuid");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Since")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Until")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("LightLib.Data.Models.CheckoutHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime?>("CheckedIn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CheckedOut")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LibraryAssetId")
                        .HasColumnType("uuid");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("CheckoutHistories");
                });

            modelBuilder.Entity("LightLib.Data.Models.Hold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("HoldPlaced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LibraryAssetId")
                        .HasColumnType("uuid");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Holds");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("LibraryBranches");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Fees")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("LibraryCards");
                });

            modelBuilder.Entity("LightLib.Data.Models.Patron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("HomeLibraryBranchId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HomeLibraryBranchId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.LibraryAsset", b =>
                {
                    b.HasOne("LightLib.Data.Models.AvailabilityStatus", "AvailabilityStatus")
                        .WithMany()
                        .HasForeignKey("AvailabilityStatusId");

                    b.HasOne("LightLib.Data.Models.LibraryBranch", "Location")
                        .WithMany("LibraryAssets")
                        .HasForeignKey("LocationId");

                    b.Navigation("AvailabilityStatus");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Tag", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.AudioBook", null)
                        .WithMany("Tags")
                        .HasForeignKey("AudioBookId");

                    b.HasOne("LightLib.Data.Models.Assets.Book", null)
                        .WithMany("Tags")
                        .HasForeignKey("BookId");

                    b.HasOne("LightLib.Data.Models.Assets.CDROM", null)
                        .WithMany("Tags")
                        .HasForeignKey("CDROMId");

                    b.HasOne("LightLib.Data.Models.Assets.DVD", null)
                        .WithMany("Tags")
                        .HasForeignKey("DVDId");

                    b.HasOne("LightLib.Data.Models.Assets.Periodical", null)
                        .WithMany("Tags")
                        .HasForeignKey("PeriodicalId");
                });

            modelBuilder.Entity("LightLib.Data.Models.BranchHours", b =>
                {
                    b.HasOne("LightLib.Data.Models.LibraryBranch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("LightLib.Data.Models.Checkout", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.LibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany("Checkouts")
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("LibraryAsset");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.CheckoutHistory", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.LibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("LibraryAsset");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.Hold", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.LibraryAsset", "LibraryAsset")
                        .WithMany()
                        .HasForeignKey("LibraryAssetId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("LibraryAsset");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.Patron", b =>
                {
                    b.HasOne("LightLib.Data.Models.LibraryBranch", "HomeLibraryBranch")
                        .WithMany("Patrons")
                        .HasForeignKey("HomeLibraryBranchId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("HomeLibraryBranch");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.AudioBook", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Book", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.CDROM", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.DVD", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Periodical", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryBranch", b =>
                {
                    b.Navigation("LibraryAssets");

                    b.Navigation("Patrons");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryCard", b =>
                {
                    b.Navigation("Checkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
