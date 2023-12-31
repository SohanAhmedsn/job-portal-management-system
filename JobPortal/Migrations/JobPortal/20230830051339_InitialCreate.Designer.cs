﻿// <auto-generated />
using JobPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPortal.Migrations.JobPortal
{
    [DbContext(typeof(JobPortalDbContext))]
    [Migration("20230830051339_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobPortal.Models.JobPost", b =>
                {
                    b.Property<int>("JobPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobPostId"));

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<string>("JobPostName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("JobPosterId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Postion")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("JobPostId");

                    b.HasIndex("JobPosterId");

                    b.ToTable("JobPosts");
                });

            modelBuilder.Entity("JobPortal.Models.JobPoster", b =>
                {
                    b.Property<int>("JobPosterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobPosterId"));

                    b.Property<string>("CompnayAddress")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CompnayName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("JobPosterId");

                    b.ToTable("JobPosters");
                });

            modelBuilder.Entity("JobPortal.Models.JobSeeker", b =>
                {
                    b.Property<int>("JobSeekerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobSeekerId"));

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("JobSeekerId");

                    b.ToTable("JobSeekers");
                });

            modelBuilder.Entity("JobPortal.Models.JobSeekerJobPost", b =>
                {
                    b.Property<int>("JobSeekerId")
                        .HasColumnType("int");

                    b.Property<int>("JobPostId")
                        .HasColumnType("int");

                    b.HasKey("JobSeekerId", "JobPostId");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobSeekerJobPosts");
                });

            modelBuilder.Entity("JobPortal.Models.JobPost", b =>
                {
                    b.HasOne("JobPortal.Models.JobPoster", "JobPoster")
                        .WithMany("JobPosts")
                        .HasForeignKey("JobPosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobPoster");
                });

            modelBuilder.Entity("JobPortal.Models.JobSeekerJobPost", b =>
                {
                    b.HasOne("JobPortal.Models.JobPost", "JobPost")
                        .WithMany()
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobPortal.Models.JobSeeker", "JobSeeker")
                        .WithMany("JobSeekerJobPosts")
                        .HasForeignKey("JobSeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobPost");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("JobPortal.Models.JobPoster", b =>
                {
                    b.Navigation("JobPosts");
                });

            modelBuilder.Entity("JobPortal.Models.JobSeeker", b =>
                {
                    b.Navigation("JobSeekerJobPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
