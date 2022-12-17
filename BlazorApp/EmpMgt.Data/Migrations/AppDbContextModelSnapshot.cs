﻿// <auto-generated />
using System;
using EmpMgt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpMgt.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmpMgt.Data.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Marketing"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Designs"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Products"
                        });
                });

            modelBuilder.Entity("EmpMgt.Data.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = 1,
                            Email = "maryl@sample.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "Linglang",
                            Photo = "images/mary.png"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = 1,
                            Email = "johnl@sample.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Longrich",
                            Photo = "images/john.png"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = 2,
                            Email = "sarar@sample.com",
                            FirstName = "Sara",
                            Gender = 1,
                            LastName = "Richards",
                            Photo = "images/sara.png"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(1984, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = 3,
                            Email = "samf@sample.com",
                            FirstName = "Sam",
                            Gender = 0,
                            LastName = "Fin",
                            Photo = "images/sam.jpeg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
