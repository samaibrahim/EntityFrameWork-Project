﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iti_DB.Context;

#nullable disable

namespace iti_DB.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20250314124631_MigrationV02")]
    partial class MigrationV02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("iti_DB.models.Course", b =>
                {
                    b.Property<int>("Crs_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Crs_Id"));

                    b.Property<string>("Crs_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Crs_Id");

                    b.HasIndex("Top_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("iti_DB.models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_Id"));

                    b.Property<string>("Dept_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept_Maneger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Maneger_Hiredate")
                        .HasColumnType("datetime2");

                    b.HasKey("Dept_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("iti_DB.models.Ins_Crs", b =>
                {
                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Evaluation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Crs_Id", "Ins_Id");

                    b.HasIndex("Ins_Id");

                    b.ToTable("Ins_Cources");
                });

            modelBuilder.Entity("iti_DB.models.Instructor", b =>
                {
                    b.Property<int>("Ins_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ins_Id"));

                    b.Property<int?>("Dept_id")
                        .HasColumnType("int");

                    b.Property<string>("Ins_Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ins_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Ins_Id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("iti_DB.models.Student", b =>
                {
                    b.Property<int>("St_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("St_Id"));

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("St_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("St_Age")
                        .HasColumnType("int");

                    b.Property<int?>("St_super")
                        .HasColumnType("int");

                    b.HasKey("St_Id");

                    b.HasIndex("Dept_Id");

                    b.HasIndex("St_super");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("iti_DB.models.Student_Course", b =>
                {
                    b.Property<int>("St_Id")
                        .HasColumnType("int");

                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("St_Id", "Crs_Id");

                    b.HasIndex("Crs_Id");

                    b.ToTable("Student_Courses");
                });

            modelBuilder.Entity("iti_DB.models.Topic", b =>
                {
                    b.Property<int>("Top_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Top_Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Top_Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("iti_DB.models.Course", b =>
                {
                    b.HasOne("iti_DB.models.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("Top_Id");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("iti_DB.models.Ins_Crs", b =>
                {
                    b.HasOne("iti_DB.models.Course", "Course")
                        .WithMany("Ins_Courses")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iti_DB.models.Instructor", "Instructor")
                        .WithMany("Ins_Courses")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("iti_DB.models.Instructor", b =>
                {
                    b.HasOne("iti_DB.models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("iti_DB.models.Student", b =>
                {
                    b.HasOne("iti_DB.models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("Dept_Id");

                    b.HasOne("iti_DB.models.Student", "Superviser")
                        .WithMany("students")
                        .HasForeignKey("St_super");

                    b.Navigation("Department");

                    b.Navigation("Superviser");
                });

            modelBuilder.Entity("iti_DB.models.Student_Course", b =>
                {
                    b.HasOne("iti_DB.models.Course", "Course")
                        .WithMany("Student_Courses")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iti_DB.models.Student", "Student")
                        .WithMany("Student_Courses")
                        .HasForeignKey("St_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("iti_DB.models.Course", b =>
                {
                    b.Navigation("Ins_Courses");

                    b.Navigation("Student_Courses");
                });

            modelBuilder.Entity("iti_DB.models.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("iti_DB.models.Instructor", b =>
                {
                    b.Navigation("Ins_Courses");
                });

            modelBuilder.Entity("iti_DB.models.Student", b =>
                {
                    b.Navigation("Student_Courses");

                    b.Navigation("students");
                });

            modelBuilder.Entity("iti_DB.models.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
