﻿// <auto-generated />
using HikingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HikingAPI.Data.Migrations
{
    [DbContext(typeof(HikingDbContext))]
    [Migration("20220615152302_establishedRelationships")]
    partial class establishedRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("HikingAPI.Models.Hiking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Distance")
                        .HasColumnType("integer");

                    b.Property<int>("Drop")
                        .HasColumnType("integer");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("end_pointId")
                        .HasColumnType("integer");

                    b.Property<int>("starting_pointId")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("end_pointId");

                    b.HasIndex("starting_pointId");

                    b.ToTable("Hikes");
                });

            modelBuilder.Entity("HikingAPI.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<float>("latitude")
                        .HasColumnType("real");

                    b.Property<float>("longitude")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HikingAPI.Models.Hiking", b =>
                {
                    b.HasOne("HikingAPI.Models.Location", "end_point")
                        .WithMany()
                        .HasForeignKey("end_pointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HikingAPI.Models.Location", "starting_point")
                        .WithMany()
                        .HasForeignKey("starting_pointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("end_point");

                    b.Navigation("starting_point");
                });
#pragma warning restore 612, 618
        }
    }
}
