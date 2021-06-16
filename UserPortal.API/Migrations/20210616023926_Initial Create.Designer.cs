﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserPortal.API.Models;

namespace UserPortal.API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210616023926_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("UserPortal.API.Models.UserMaster", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PCode")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserMasters");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@test.com",
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "Main",
                            PCode = "HCL000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
