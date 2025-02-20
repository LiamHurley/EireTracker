﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(EireTrackerContext))]
    [Migration("20220913184547_DefaultValueTest")]
    partial class DefaultValueTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Models.Performance", b =>
                {
                    b.Property<int>("PerformanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerformanceId"), 1L, 1);

                    b.Property<int?>("AccurateCross")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("AccurateKeeperSweeper")
                        .HasColumnType("int");

                    b.Property<int?>("AccurateLongBalls")
                        .HasColumnType("int");

                    b.Property<int?>("AccuratePass")
                        .HasColumnType("int");

                    b.Property<int?>("AerialLost")
                        .HasColumnType("int");

                    b.Property<int?>("AerialWon")
                        .HasColumnType("int");

                    b.Property<int?>("BigChanceCreated")
                        .HasColumnType("int");

                    b.Property<int?>("BigChanceMissed")
                        .HasColumnType("int");

                    b.Property<int?>("BlockedScoringAttempt")
                        .HasColumnType("int");

                    b.Property<int?>("DuelLost")
                        .HasColumnType("int");

                    b.Property<int?>("DuelWon")
                        .HasColumnType("int");

                    b.Property<int?>("ErrorLeadToAShot")
                        .HasColumnType("int");

                    b.Property<int?>("Fouls")
                        .HasColumnType("int");

                    b.Property<int?>("Goals")
                        .HasColumnType("int");

                    b.Property<int?>("InterceptionWon")
                        .HasColumnType("int");

                    b.Property<int?>("KeyPass")
                        .HasColumnType("int");

                    b.Property<int?>("MinutesPlayed")
                        .HasColumnType("int");

                    b.Property<int?>("OnTargetScoringAttempt")
                        .HasColumnType("int");

                    b.Property<int?>("OutfielderBlock")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("PossessionLostCtrl")
                        .HasColumnType("int");

                    b.Property<int?>("Punches")
                        .HasColumnType("int");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int?>("SavedShotsFromInsideTheBox")
                        .HasColumnType("int");

                    b.Property<int?>("Saves")
                        .HasColumnType("int");

                    b.Property<int?>("ShotOffTarget")
                        .HasColumnType("int");

                    b.Property<int?>("TotalClearance")
                        .HasColumnType("int");

                    b.Property<int?>("TotalCross")
                        .HasColumnType("int");

                    b.Property<int?>("TotalKeeperSweeper")
                        .HasColumnType("int");

                    b.Property<int?>("TotalLongBalls")
                        .HasColumnType("int");

                    b.Property<int?>("TotalOffside")
                        .HasColumnType("int");

                    b.Property<int?>("TotalPass")
                        .HasColumnType("int");

                    b.Property<int?>("TotalTackle")
                        .HasColumnType("int");

                    b.Property<int?>("Touches")
                        .HasColumnType("int");

                    b.Property<int?>("WasFouled")
                        .HasColumnType("int");

                    b.HasKey("PerformanceId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("API.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<string>("Club")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("API.Models.Performance", b =>
                {
                    b.HasOne("API.Models.Player", "Player")
                        .WithMany("Performances")
                        .HasForeignKey("PlayerId");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("API.Models.Player", b =>
                {
                    b.Navigation("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}
