﻿// <auto-generated />
using System;
using CarModule.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarModule.Infrastructure.Migrations
{
    [DbContext(typeof(CarModuleContext))]
    [Migration("20240531145954_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("CarModule")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarModule.Domain.Entities.CarMake", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("DeletedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGdpr")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LastUpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("LastUpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("IsDeleted");

                    b.ToTable("CarMakes", "CarModule");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7287e4d6-b648-46ea-b81d-cdbb7ad872da"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8576), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = new Guid("9d16b331-b955-486d-9f4b-b5cf66a577ac"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = new Guid("53481d9d-acdf-41bb-b720-4a267536442d"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = new Guid("eab78139-37bc-4df6-a3e6-7446552469ca"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = new Guid("e7e82a96-8602-4fcb-9dcf-59d3f1e6fedc"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8650), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Nissan"
                        },
                        new
                        {
                            Id = new Guid("0d0c430f-76a9-4fd1-b1ee-8e7a0fed8d75"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Jeep"
                        },
                        new
                        {
                            Id = new Guid("99e4c746-59cb-43c3-b23d-e0fa0b4cdd3b"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8659), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = new Guid("4decf079-3f54-4c38-9a77-9b68d07956de"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Dodge"
                        },
                        new
                        {
                            Id = new Guid("17c56ff4-ed4a-4b3b-b171-cebaffa2ccc6"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Kia"
                        },
                        new
                        {
                            Id = new Guid("87e75c03-91d8-49ce-b073-89d365fe59f0"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8670), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = new Guid("b4700214-a16b-48bf-96fc-93928db68063"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Ram"
                        },
                        new
                        {
                            Id = new Guid("01eed1ba-e980-42c7-be5c-53b89ca44123"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8677), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "GMC"
                        },
                        new
                        {
                            Id = new Guid("e8379af2-ac28-4ea9-b272-c2b44d158c6c"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = new Guid("20dc528d-0fde-4551-a0b3-6c4027d39411"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8683), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Subaru"
                        },
                        new
                        {
                            Id = new Guid("220c821a-1331-472c-a02e-2303811a3a60"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Volkswagen"
                        },
                        new
                        {
                            Id = new Guid("d39bb50e-ab01-4ed3-a7df-ce8b285ac987"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = new Guid("a4938e80-588e-4ca1-b621-4400b0bb2467"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8693), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Lexus"
                        },
                        new
                        {
                            Id = new Guid("bb814475-6aa6-4113-8685-5484095bf05d"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8697), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Mazda"
                        },
                        new
                        {
                            Id = new Guid("421c4af8-5874-45ae-8cac-0129a1bc7751"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Buick"
                        },
                        new
                        {
                            Id = new Guid("80890a69-3175-4d7d-9a26-dffe46f09b4d"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Cadillac"
                        },
                        new
                        {
                            Id = new Guid("1e46d67d-10a5-48dd-990e-6798fb55e8e1"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Volvo"
                        },
                        new
                        {
                            Id = new Guid("f8b41df5-77c9-4490-8df7-836a2038bbed"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Lincoln"
                        },
                        new
                        {
                            Id = new Guid("63c09ddd-eb45-4a18-8b0d-cabb4194edcf"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Land Rover"
                        },
                        new
                        {
                            Id = new Guid("c9a81f4f-0ce7-427e-b0d3-fc8245ea35d9"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Porsche"
                        },
                        new
                        {
                            Id = new Guid("9fb88bad-8658-463f-b5c3-8dd7ee5a88a4"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8720), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Jaguar"
                        },
                        new
                        {
                            Id = new Guid("b7ff96b6-e9cf-48ec-aac7-74bd40ae4a1c"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Acura"
                        },
                        new
                        {
                            Id = new Guid("8544f301-edb6-4dc8-9b8d-e8eff68b878e"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8726), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Infiniti"
                        },
                        new
                        {
                            Id = new Guid("01033e6f-1d02-4a9a-aaf9-0678c21a158a"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8729), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Mini"
                        },
                        new
                        {
                            Id = new Guid("75880695-b23d-4ce2-a77a-a5021cd10505"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Mitsubishi"
                        },
                        new
                        {
                            Id = new Guid("3c94ddc7-abaf-4f2c-bef6-0dc5614df837"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8736), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Bentley"
                        },
                        new
                        {
                            Id = new Guid("3a3e7ecd-41bc-47c1-80e6-49f3c898be21"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Fiat"
                        },
                        new
                        {
                            Id = new Guid("a5c9ca04-db41-421d-8c22-e86882f11f2f"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8742), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Smart"
                        },
                        new
                        {
                            Id = new Guid("33b0b393-8a2d-4d01-b2a9-fff72a96473e"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Scion"
                        },
                        new
                        {
                            Id = new Guid("479344bc-520a-40e4-af5c-50adccae5484"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Tesla"
                        },
                        new
                        {
                            Id = new Guid("262e0d81-48a1-4a29-b0bf-49f84e0e49a9"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Genesis"
                        },
                        new
                        {
                            Id = new Guid("e9ca2bd2-20f3-447b-9e30-d6f536e69a55"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8756), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Maserati"
                        },
                        new
                        {
                            Id = new Guid("43e5b83d-32e6-47ac-a5c6-11c068b14cd6"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Ferrari"
                        },
                        new
                        {
                            Id = new Guid("5142099b-9355-407e-a229-1b307e71f201"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Lamborghini"
                        },
                        new
                        {
                            Id = new Guid("33740f26-ab9e-423a-80ee-643a971c870f"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8766), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "McLaren"
                        },
                        new
                        {
                            Id = new Guid("6b285a80-5693-42fd-baf2-8e1e4d499995"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8812), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Rolls-Royce"
                        },
                        new
                        {
                            Id = new Guid("36602f7c-35f7-4a6c-b1e3-e7c3b0e23b46"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Bugatti"
                        },
                        new
                        {
                            Id = new Guid("714ed326-9edb-4b80-97f8-66df5ca5392a"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Koenigsegg"
                        },
                        new
                        {
                            Id = new Guid("6de8ac30-ecd2-43aa-b575-ba9a6d844ba6"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Pagani"
                        },
                        new
                        {
                            Id = new Guid("55ad59a4-2ec6-4fb0-a3a4-b9659781aea1"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Lotus"
                        },
                        new
                        {
                            Id = new Guid("def12ff1-1cd2-473a-924f-8d9ca09e1c93"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Alfa Romeo"
                        },
                        new
                        {
                            Id = new Guid("2fe719ae-fa15-440a-a810-124563e065ee"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8834), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Aston Martin"
                        },
                        new
                        {
                            Id = new Guid("dbff39ee-0fea-4c34-9dd4-c5054385ebc0"),
                            CreatedDate = new DateTimeOffset(new DateTime(2024, 5, 31, 16, 59, 53, 804, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            IsGdpr = false,
                            IsSystem = false,
                            Name = "Bentley"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
