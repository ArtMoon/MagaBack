﻿// <auto-generated />
using System;
using DIMON_APP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DIMON_APP.Migrations
{
    [DbContext(typeof(MyWebApiDbContext))]
    partial class MyWebApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("DIMON_APP.Models.Apparatus", b =>
                {
                    b.Property<int>("Id_Ap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("App_name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Parent_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id_Ap");

                    b.ToTable("Apparatus");
                });

            modelBuilder.Entity("DIMON_APP.Models.SensorInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SensorName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("sensorInfo");
                });

            modelBuilder.Entity("DIMON_APP.Models.Sensor_vals", b =>
                {
                    b.Property<int>("Value_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Date_time")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id_sensor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Parent_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sensor_name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Sensor_value")
                        .HasColumnType("REAL");

                    b.HasKey("Value_id");

                    b.ToTable("Sensor_Val");
                });

            modelBuilder.Entity("DIMON_APP.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Last_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
