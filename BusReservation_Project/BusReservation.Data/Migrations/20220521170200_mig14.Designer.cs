﻿// <auto-generated />
using System;
using BusReservation.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusReservation.Data.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20220521170200_mig14")]
    partial class mig14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("BusReservation.Entity.ChooseSeat", b =>
                {
                    b.Property<int>("ChooseSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DirectionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEmpty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ChooseSeatId");

                    b.HasIndex("DirectionId");

                    b.ToTable("ChooseSeats");
                });

            modelBuilder.Entity("BusReservation.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BusReservation.Entity.Direction", b =>
                {
                    b.Property<int>("DirectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("FinishCity")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("SeatTotalNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartCity")
                        .HasColumnType("TEXT");

                    b.HasKey("DirectionId");

                    b.ToTable("Directions");
                });

            modelBuilder.Entity("BusReservation.Entity.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DirectionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PassengerMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassengerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassengerSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassengerTel")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("SeatNo")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BusReservation.Entity.ChooseSeat", b =>
                {
                    b.HasOne("BusReservation.Entity.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");
                });
#pragma warning restore 612, 618
        }
    }
}
