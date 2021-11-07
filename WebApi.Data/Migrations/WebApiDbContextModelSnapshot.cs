﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data.EF;

namespace WebApi.Data.Migrations
{
    [DbContext(typeof(WebApiDbContext))]
    partial class WebApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OriginPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserForeignKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookingId");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("WebApi.Data.Entites.BookingDetail", b =>
                {
                    b.Property<int>("BookingDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("FieldForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("FieldScheduleForeignKey")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingDetailId");

                    b.HasIndex("BookingForeignKey");

                    b.HasIndex("FieldForeignKey");

                    b.HasIndex("FieldScheduleForeignKey");

                    b.ToTable("BookingDetail");
                });

            modelBuilder.Entity("WebApi.Data.Entites.BookingDiscount", b =>
                {
                    b.Property<int>("BookingDiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingForeignKey")
                        .HasColumnType("int");

                    b.Property<int>("DiscountForeignKey")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("BookingDiscountId");

                    b.HasIndex("BookingForeignKey");

                    b.HasIndex("DiscountForeignKey");

                    b.ToTable("BookingDiscount");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscountCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DiscountId");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("WebApi.Data.Entites.FeedBack", b =>
                {
                    b.Property<int>("FeedBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingDetailForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumOfStart")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserForeignKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FeedBackId");

                    b.HasIndex("BookingDetailForeignKey");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("FeedBack");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Field", b =>
                {
                    b.Property<int>("FieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 11, 5, 13, 48, 18, 88, DateTimeKind.Local).AddTicks(6296));

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupFieldForeinKey")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TopHot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(-1);

                    b.Property<int>("TypeField")
                        .HasColumnType("int");

                    b.Property<Guid>("UserForeignKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FieldId");

                    b.HasIndex("GroupFieldForeinKey");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Field");

                    b.HasData(
                        new
                        {
                            FieldId = 1,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 140, DateTimeKind.Local).AddTicks(8059),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupFieldForeinKey = 1,
                            IsHot = true,
                            Name = "A",
                            Status = true,
                            TopHot = 1,
                            TypeField = 5,
                            UserForeignKey = new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9")
                        },
                        new
                        {
                            FieldId = 2,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(528),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupFieldForeinKey = 1,
                            IsHot = true,
                            Name = "B",
                            Status = true,
                            TopHot = 3,
                            TypeField = 5,
                            UserForeignKey = new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9")
                        },
                        new
                        {
                            FieldId = 3,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(619),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupFieldForeinKey = 1,
                            IsHot = true,
                            Name = "C",
                            Status = true,
                            TopHot = 2,
                            TypeField = 7,
                            UserForeignKey = new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9")
                        },
                        new
                        {
                            FieldId = 4,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(641),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupFieldForeinKey = 2,
                            IsHot = true,
                            Name = "A",
                            Status = true,
                            TopHot = 1,
                            TypeField = 5,
                            UserForeignKey = new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb")
                        },
                        new
                        {
                            FieldId = 5,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(646),
                            DeletedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupFieldForeinKey = 2,
                            IsHot = true,
                            Name = "B",
                            Status = true,
                            TopHot = 2,
                            TypeField = 11,
                            UserForeignKey = new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb")
                        });
                });

            modelBuilder.Entity("WebApi.Data.Entites.FieldSchedule", b =>
                {
                    b.Property<int>("FieldScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldForeignKey")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("FieldScheduleID");

                    b.HasIndex("FieldForeignKey");

                    b.ToTable("FieldSchedule");

                    b.HasData(
                        new
                        {
                            FieldScheduleID = 1,
                            FieldForeignKey = 1,
                            OriginPrice = 0m,
                            Price = 0m,
                            Status = true,
                            TimeEnd = new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeStart = new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FieldScheduleID = 2,
                            FieldForeignKey = 2,
                            OriginPrice = 0m,
                            Price = 0m,
                            Status = true,
                            TimeEnd = new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeStart = new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FieldScheduleID = 3,
                            FieldForeignKey = 3,
                            OriginPrice = 0m,
                            Price = 0m,
                            Status = true,
                            TimeEnd = new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeStart = new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FieldScheduleID = 4,
                            FieldForeignKey = 4,
                            OriginPrice = 0m,
                            Price = 0m,
                            Status = true,
                            TimeEnd = new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeStart = new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FieldScheduleID = 5,
                            FieldForeignKey = 5,
                            OriginPrice = 0m,
                            Price = 0m,
                            Status = true,
                            TimeEnd = new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeStart = new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApi.Data.Entites.GroupField", b =>
                {
                    b.Property<int>("GroupFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<Guid>("UserForeignKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GroupFieldId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupField");

                    b.HasData(
                        new
                        {
                            GroupFieldId = 1,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 117, DateTimeKind.Local).AddTicks(840),
                            Description = "Sports facilities are the most valuable asset in the business. has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.",
                            Name = "Hoang",
                            Status = true,
                            UserForeignKey = new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9")
                        },
                        new
                        {
                            GroupFieldId = 2,
                            Address = "HN",
                            CreatedAt = new DateTime(2021, 11, 5, 13, 48, 18, 117, DateTimeKind.Local).AddTicks(1628),
                            Description = "Sports facilities are the most valuable asset in the business. has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.",
                            Name = "VanTam",
                            Status = true,
                            UserForeignKey = new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb")
                        });
                });

            modelBuilder.Entity("WebApi.Data.Entites.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"),
                            ConcurrencyStamp = "c906b459-af99-42cc-a4aa-cf95d03f5c4e",
                            Description = "Admin is boss",
                            Name = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"),
                            ConcurrencyStamp = "852a4210-98fc-4156-a724-72f63ebc1f45",
                            Description = "Owner is manager",
                            Name = "OWNER"
                        },
                        new
                        {
                            Id = new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"),
                            ConcurrencyStamp = "b53ad226-f55e-4e04-bc08-1ea2c684d1d1",
                            Description = "User is user",
                            Name = "USER"
                        });
                });

            modelBuilder.Entity("WebApi.Data.Entites.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "97a515c6-cd30-4726-8b47-344af5f7d71b",
                            DoB = new DateTime(1998, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hoangbd@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Bach Duy",
                            LastName = "Hoang",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELPx09IH6XmbgBfcfhQ40dnRUOAOrnaoafAa7BwWi8pmXLivWb5eHCJ3zPM1EgbCIg==",
                            PhoneNumber = "09356248153",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e9ed1013-69a5-42f8-b6de-164a82cbed3b",
                            DoB = new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tamnv@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Nguyen Van",
                            LastName = "Tam",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEKaZw0nyS+ow3kvs/odDOciu5UArxLhg2yRIRz4WfjIjauxNABKY3Q3pI00Ee/roSA==",
                            PhoneNumber = "096589475135",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("WebApi.Data.Entites.Booking", b =>
                {
                    b.HasOne("WebApi.Data.Entites.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserForeignKey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Data.Entites.BookingDetail", b =>
                {
                    b.HasOne("WebApi.Data.Entites.Booking", "Booking")
                        .WithMany("BookingDetails")
                        .HasForeignKey("BookingForeignKey");

                    b.HasOne("WebApi.Data.Entites.Field", "Field")
                        .WithMany("BookingDetails")
                        .HasForeignKey("FieldForeignKey");

                    b.HasOne("WebApi.Data.Entites.FieldSchedule", "FieldSchedule")
                        .WithMany("BookingDetails")
                        .HasForeignKey("FieldScheduleForeignKey");

                    b.Navigation("Booking");

                    b.Navigation("Field");

                    b.Navigation("FieldSchedule");
                });

            modelBuilder.Entity("WebApi.Data.Entites.BookingDiscount", b =>
                {
                    b.HasOne("WebApi.Data.Entites.Booking", "Booking")
                        .WithMany("BookingDiscount")
                        .HasForeignKey("BookingForeignKey");

                    b.HasOne("WebApi.Data.Entites.Discount", "Discount")
                        .WithMany("BookingDiscount")
                        .HasForeignKey("DiscountForeignKey");

                    b.Navigation("Booking");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("WebApi.Data.Entites.FeedBack", b =>
                {
                    b.HasOne("WebApi.Data.Entites.BookingDetail", "BookingDetail")
                        .WithMany("Feedbacks")
                        .HasForeignKey("BookingDetailForeignKey");

                    b.HasOne("WebApi.Data.Entites.User", "User")
                        .WithMany("FeedBacks")
                        .HasForeignKey("UserForeignKey");

                    b.Navigation("BookingDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Field", b =>
                {
                    b.HasOne("WebApi.Data.Entites.GroupField", "GroupField")
                        .WithMany("Fields")
                        .HasForeignKey("GroupFieldForeinKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Data.Entites.User", "User")
                        .WithMany("Fields")
                        .HasForeignKey("UserForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupField");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Data.Entites.FieldSchedule", b =>
                {
                    b.HasOne("WebApi.Data.Entites.Field", "Field")
                        .WithMany("FieldSchedules")
                        .HasForeignKey("FieldForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("WebApi.Data.Entites.GroupField", b =>
                {
                    b.HasOne("WebApi.Data.Entites.User", "User")
                        .WithMany("GroupFields")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Booking", b =>
                {
                    b.Navigation("BookingDetails");

                    b.Navigation("BookingDiscount");
                });

            modelBuilder.Entity("WebApi.Data.Entites.BookingDetail", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Discount", b =>
                {
                    b.Navigation("BookingDiscount");
                });

            modelBuilder.Entity("WebApi.Data.Entites.Field", b =>
                {
                    b.Navigation("BookingDetails");

                    b.Navigation("FieldSchedules");
                });

            modelBuilder.Entity("WebApi.Data.Entites.FieldSchedule", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("WebApi.Data.Entites.GroupField", b =>
                {
                    b.Navigation("Fields");
                });

            modelBuilder.Entity("WebApi.Data.Entites.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("FeedBacks");

                    b.Navigation("Fields");

                    b.Navigation("GroupFields");
                });
#pragma warning restore 612, 618
        }
    }
}
