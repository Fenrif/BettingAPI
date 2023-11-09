﻿// <auto-generated />
using System;
using BettingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BettingAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231109170349_MatchOdds")]
    partial class MatchOdds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BettingAPI.Models.Match", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MatchTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sport")
                        .HasColumnType("int");

                    b.Property<string>("TeamA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("BettingAPI.Models.MatchOdds", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MatchID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Odd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Specifier")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MatchID");

                    b.ToTable("MatchOdds");
                });

            modelBuilder.Entity("BettingAPI.Models.MatchOdds", b =>
                {
                    b.HasOne("BettingAPI.Models.Match", "Match")
                        .WithMany("MatchOdds")
                        .HasForeignKey("MatchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("BettingAPI.Models.Match", b =>
                {
                    b.Navigation("MatchOdds");
                });
#pragma warning restore 612, 618
        }
    }
}
