﻿// <auto-generated />
using Lab2_School_Linq.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab2_School_Linq.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429224803_Myschool")]
    partial class Myschool
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab2_School_Linq.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.CourseClass", b =>
                {
                    b.Property<int>("CourseClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseClassId"));

                    b.Property<string>("CourseClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseClassId");

                    b.ToTable("CourseClasses");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("FkCourseId")
                        .HasColumnType("int");

                    b.Property<int>("FkStudentId")
                        .HasColumnType("int");

                    b.Property<int>("FkTeacherId")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("FkCourseId");

                    b.HasIndex("FkStudentId");

                    b.HasIndex("FkTeacherId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("FkCourseClassId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("FkCourseClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Enrollment", b =>
                {
                    b.HasOne("Lab2_School_Linq.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("FkCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab2_School_Linq.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("FkStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab2_School_Linq.Models.Teacher", "Teacher")
                        .WithMany("Enrollments")
                        .HasForeignKey("FkTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Student", b =>
                {
                    b.HasOne("Lab2_School_Linq.Models.CourseClass", "CourseClass")
                        .WithMany("Students")
                        .HasForeignKey("FkCourseClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseClass");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.CourseClass", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Lab2_School_Linq.Models.Teacher", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
