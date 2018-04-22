﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Model;
using System;

namespace Model.Migrations
{
    [DbContext(typeof(LmsDbContext))]
    partial class LmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Course", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AverageRating");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<double>("DiscountedPrice");

                    b.Property<int>("EnrolledCount");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFree");

                    b.Property<string>("Language");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<double>("RegularPrice");

                    b.Property<int>("StudentLevel");

                    b.Property<string>("Topic");

                    b.Property<int>("TotalDurationHour");

                    b.Property<int>("TotalLectureCount");

                    b.Property<string>("TrainerName");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Model.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Courses");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<double>("TotalCredit");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
