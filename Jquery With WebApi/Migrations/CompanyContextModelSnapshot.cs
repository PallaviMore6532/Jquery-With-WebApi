﻿// <auto-generated />
using Jquery_With_WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jquery_With_WebApi.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jquery_With_WebApi.Models.Course", b =>
                {
                    b.Property<long>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CourseID"));

                    b.Property<long>("CourseFees")
                        .HasColumnType("bigint");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DiscountAmount")
                        .HasColumnType("bigint");

                    b.Property<long>("FinalAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1L,
                            CourseFees = 5000L,
                            CourseName = "C Programming",
                            DiscountAmount = 1000L,
                            FinalAmount = 4000L,
                            SubjectName = "Programming"
                        },
                        new
                        {
                            CourseID = 2L,
                            CourseFees = 12000L,
                            CourseName = "Sql/Pl Programming",
                            DiscountAmount = 2000L,
                            FinalAmount = 10000L,
                            SubjectName = "Database"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}