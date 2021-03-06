﻿// <auto-generated />
using System;
using EasyBuilderAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyBuilderAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EasyBuilderAPI.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutComponent")
                        .HasColumnName("about_component")
                        .HasColumnType("text");

                    b.Property<string>("ComponentName")
                        .HasColumnName("component_name")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DeveloperId")
                        .HasColumnName("developer_id")
                        .HasColumnType("integer");

                    b.Property<int>("Downloads")
                        .HasColumnName("downloads")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnName("price")
                        .HasColumnType("integer");

                    b.Property<string>("SourceToJSON")
                        .HasColumnName("source_to_json")
                        .HasColumnType("text");

                    b.Property<int>("Stars")
                        .HasColumnName("stars")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("component");
                });

            modelBuilder.Entity("EasyBuilderAPI.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ProfileId")
                        .HasColumnName("profile_id")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnName("rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("developer");
                });

            modelBuilder.Entity("EasyBuilderAPI.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("profile");
                });

            modelBuilder.Entity("EasyBuilderAPI.Models.Component", b =>
                {
                    b.HasOne("EasyBuilderAPI.Models.Developer", "Developer")
                        .WithMany("Components")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
