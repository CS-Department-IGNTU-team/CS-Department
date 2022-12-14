// <auto-generated />
using System;
using CSDepartment.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSDepartment.Api.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20221109171357_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("CSDepartment.Models.Media", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PostTimestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name", "Timestamp");

                    b.HasIndex("PostTitle", "PostTimestamp");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("CSDepartment.Models.Post", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Title", "Timestamp");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CSDepartment.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "admin",
                            Email = "mrunpredictable3679@gmail.com",
                            Name = "Admin",
                            Password = "4321",
                            Role = "Administrator"
                        });
                });

            modelBuilder.Entity("CSDepartment.Models.Media", b =>
                {
                    b.HasOne("CSDepartment.Models.Post", null)
                        .WithMany("Media")
                        .HasForeignKey("PostTitle", "PostTimestamp");
                });

            modelBuilder.Entity("CSDepartment.Models.Post", b =>
                {
                    b.Navigation("Media");
                });
#pragma warning restore 612, 618
        }
    }
}
