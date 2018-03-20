﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using SFCDentalGame.DAL;
using SFCDentalGame.DAL.Entities;
using System;

namespace SFCDentalGame.Migrations
{
    [DbContext(typeof(SFCContext))]
    [Migration("20180226155028_Inheritance")]
    partial class Inheritance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.Behaviour", b =>
                {
                    b.Property<int>("BehaviourId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BehaviourDescription");

                    b.Property<string>("BehaviourName");

                    b.Property<string>("BehaviourType");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Points");

                    b.Property<string>("ProffesionalComment");

                    b.Property<int>("ratings");

                    b.HasKey("BehaviourId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Behaviour");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Behaviour");
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryDescription");

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.Frequency", b =>
                {
                    b.Property<int>("FrequencyId");

                    b.Property<int?>("BehaviourWithFreqBehaviourId");

                    b.Property<string>("FrequencyName");

                    b.Property<int?>("LongerPractices");

                    b.Property<int?>("OtherSupporting");

                    b.Property<int?>("UsageBehaviour");

                    b.Property<decimal>("points");

                    b.HasKey("FrequencyId");

                    b.HasIndex("BehaviourWithFreqBehaviourId");

                    b.ToTable("Frequency");
                });

            modelBuilder.Entity("SFCDentalGame.Models.DentalHealth", b =>
                {
                    b.Property<int>("DentalHealthId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("PracticeSubmitTime");

                    b.Property<decimal>("TeethAge");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("DentalHealthId");

                    b.ToTable("DentalHealth");
                });

            modelBuilder.Entity("SFCDentalGame.Models.DentalHealthDetail", b =>
                {
                    b.Property<int>("DentalHealthDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BehaviourId");

                    b.Property<string>("Comment");

                    b.Property<int>("DentalHealthId");

                    b.Property<decimal>("Points");

                    b.HasKey("DentalHealthDetailId");

                    b.HasIndex("BehaviourId");

                    b.HasIndex("DentalHealthId");

                    b.ToTable("HealthDetail");
                });

            modelBuilder.Entity("SFCDentalGame.Models.DentalPracticeItem", b =>
                {
                    b.Property<int>("DentalPracticeItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BehaviourId");

                    b.Property<string>("DentalPracticeId");

                    b.Property<string>("FrequencyName");

                    b.Property<double>("Score");

                    b.HasKey("DentalPracticeItemID");

                    b.HasIndex("BehaviourId");

                    b.ToTable("PracticeItem");
                });

            modelBuilder.Entity("SFCDentalGame.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("PlayerId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("SFCDentalGame.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DentalHealthId");

                    b.HasKey("ProfileId");

                    b.HasIndex("DentalHealthId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.FreqBehaviour", b =>
                {
                    b.HasBaseType("SFCDentalGame.DAL.Entities.Behaviour");

                    b.Property<int>("LongerPractices");

                    b.Property<int>("OtherSupporting");

                    b.Property<int>("UsageBehaviour");

                    b.ToTable("FrequencyBehaviour");

                    b.HasDiscriminator().HasValue("FreqBehaviour");
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.RangeBehaviour", b =>
                {
                    b.HasBaseType("SFCDentalGame.DAL.Entities.Behaviour");

                    b.Property<int>("Range");

                    b.ToTable("RangeBehaviour");

                    b.HasDiscriminator().HasValue("RangeBehaviour");
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.Behaviour", b =>
                {
                    b.HasOne("SFCDentalGame.DAL.Entities.Category", "Category")
                        .WithMany("Behaviours")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFCDentalGame.DAL.Entities.Frequency", b =>
                {
                    b.HasOne("SFCDentalGame.DAL.Entities.FreqBehaviour", "BehaviourWithFreq")
                        .WithMany()
                        .HasForeignKey("BehaviourWithFreqBehaviourId");
                });

            modelBuilder.Entity("SFCDentalGame.Models.DentalHealthDetail", b =>
                {
                    b.HasOne("SFCDentalGame.DAL.Entities.Behaviour", "Behaviour")
                        .WithMany()
                        .HasForeignKey("BehaviourId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SFCDentalGame.Models.DentalHealth", "DentalHealth")
                        .WithMany("HealthDetails")
                        .HasForeignKey("DentalHealthId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SFCDentalGame.Models.DentalPracticeItem", b =>
                {
                    b.HasOne("SFCDentalGame.DAL.Entities.Behaviour", "Behaviour")
                        .WithMany()
                        .HasForeignKey("BehaviourId");
                });

            modelBuilder.Entity("SFCDentalGame.Models.Profile", b =>
                {
                    b.HasOne("SFCDentalGame.Models.DentalHealth", "DentalHealth")
                        .WithMany()
                        .HasForeignKey("DentalHealthId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}