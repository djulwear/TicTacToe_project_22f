﻿// <auto-generated />
using System;
using DAL.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Db.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221103094205_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Domain.TicTacToeGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("GameOverAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("GameWonByPlayer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Player1Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("Player1Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Player2Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("Player2Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("TicTacToeOptionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TicTacToeOptionId");

                    b.ToTable("TicTacToeGames");
                });

            modelBuilder.Entity("Domain.TicTacToeGameState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedGameState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TicTacTOeGameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TicTacTOeGameId");

                    b.ToTable("TicTacToeGameStates");
                });

            modelBuilder.Entity("Domain.TicTacToeOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AI")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RandomMoves")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WhiteStarts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TicTacToeOptions");
                });

            modelBuilder.Entity("Domain.TicTacToeGame", b =>
                {
                    b.HasOne("Domain.TicTacToeOption", "TicTacToeOption")
                        .WithMany("TicTacToeGames")
                        .HasForeignKey("TicTacToeOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicTacToeOption");
                });

            modelBuilder.Entity("Domain.TicTacToeGameState", b =>
                {
                    b.HasOne("Domain.TicTacToeGame", "TicTacToeGame")
                        .WithMany("TicTacToeGameStates")
                        .HasForeignKey("TicTacTOeGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicTacToeGame");
                });

            modelBuilder.Entity("Domain.TicTacToeGame", b =>
                {
                    b.Navigation("TicTacToeGameStates");
                });

            modelBuilder.Entity("Domain.TicTacToeOption", b =>
                {
                    b.Navigation("TicTacToeGames");
                });
#pragma warning restore 612, 618
        }
    }
}
