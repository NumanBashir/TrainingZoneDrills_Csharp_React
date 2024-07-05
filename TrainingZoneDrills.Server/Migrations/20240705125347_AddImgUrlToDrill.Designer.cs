﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingZoneDrills.Server.Context;

#nullable disable

namespace TrainingZoneDrills.Server.Migrations
{
    [DbContext(typeof(TrainingZoneContext))]
    [Migration("20240705125347_AddImgUrlToDrill")]
    partial class AddImgUrlToDrill
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.Drill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drills");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.DrillCategory", b =>
                {
                    b.Property<int>("DrillId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("DrillId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("DrillCategories");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.DrillEquipment", b =>
                {
                    b.Property<int>("DrillId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.HasKey("DrillId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("DrillEquipments");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.DrillCategory", b =>
                {
                    b.HasOne("TrainingZoneDrills.Server.Models.Category", "Category")
                        .WithMany("DrillCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingZoneDrills.Server.Models.Drill", "Drill")
                        .WithMany("DrillCategories")
                        .HasForeignKey("DrillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Drill");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.DrillEquipment", b =>
                {
                    b.HasOne("TrainingZoneDrills.Server.Models.Drill", "Drill")
                        .WithMany("DrillEquipments")
                        .HasForeignKey("DrillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingZoneDrills.Server.Models.Equipment", "Equipment")
                        .WithMany("DrillEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drill");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.Category", b =>
                {
                    b.Navigation("DrillCategories");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.Drill", b =>
                {
                    b.Navigation("DrillCategories");

                    b.Navigation("DrillEquipments");
                });

            modelBuilder.Entity("TrainingZoneDrills.Server.Models.Equipment", b =>
                {
                    b.Navigation("DrillEquipments");
                });
#pragma warning restore 612, 618
        }
    }
}
