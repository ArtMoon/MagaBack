﻿// <auto-generated />
using System;
using DIMON_APP.Models.PG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DIMON_APP.Migrations.PostgresDB
{
    [DbContext(typeof(PostgresDBContext))]
    [Migration("20200225154720_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("DIMON_APP.Models.PG.Apparatus", b =>
                {
                    b.Property<int>("ap_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("full_name")
                        .HasColumnType("TEXT");

                    b.Property<int>("parent_ap_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("short_name")
                        .HasColumnType("TEXT");

                    b.HasKey("ap_id");

                    b.ToTable("dm_apparatuses");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Apparatus2SensLink", b =>
                {
                    b.Property<int>("rec_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ap_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sens_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("rec_id");

                    b.HasIndex("ap_id");

                    b.HasIndex("sens_id")
                        .IsUnique();

                    b.ToTable("dm_apparatus_2_sens_link");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.ApparatusInfo", b =>
                {
                    b.Property<int>("ap_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("launch_date")
                        .HasColumnType("TEXT");

                    b.Property<float>("power")
                        .HasColumnType("REAL");

                    b.HasKey("ap_id");

                    b.ToTable("dm_apparatus_info");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Sensor", b =>
                {
                    b.Property<int>("sens_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("sens_name")
                        .HasColumnType("TEXT");

                    b.HasKey("sens_id");

                    b.ToTable("dm_sensors");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.SensorVal", b =>
                {
                    b.Property<int>("val_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("sens_id")
                        .HasColumnType("INTEGER");

                    b.Property<float>("val")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("val_date")
                        .HasColumnType("TEXT");

                    b.HasKey("val_id");

                    b.ToTable("dm_sensor_vals");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("last_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<string>("photo_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("table_num")
                        .HasColumnType("INTEGER");

                    b.HasKey("user_id");

                    b.ToTable("dm_users");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Apparatus2SensLink", b =>
                {
                    b.HasOne("DIMON_APP.Models.PG.Apparatus", "Apparatus")
                        .WithMany("app_link")
                        .HasForeignKey("ap_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DIMON_APP.Models.PG.Sensor", "Sensor")
                        .WithOne("app_link")
                        .HasForeignKey("DIMON_APP.Models.PG.Apparatus2SensLink", "sens_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
