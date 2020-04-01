﻿// <auto-generated />
using System;
using DIMON_APP.Models.PG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DIMON_APP.Migrations.PostgresDB
{
    [DbContext(typeof(PostgresDBContext))]
    [Migration("20200329091057_ApparatusBind4")]
    partial class ApparatusBind4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DIMON_APP.Models.PG.Alarm", b =>
                {
                    b.Property<int>("al_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("al_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("al_param")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("al_reason")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("al_text")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<float>("al_value")
                        .HasColumnType("real");

                    b.Property<int>("ap_id")
                        .HasColumnType("integer");

                    b.Property<int>("sens_id")
                        .HasColumnType("integer");

                    b.HasKey("al_id");

                    b.HasIndex("ap_id");

                    b.HasIndex("sens_id");

                    b.ToTable("dm_alarms");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Apparatus", b =>
                {
                    b.Property<int>("ap_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("full_name")
                        .HasColumnType("text");

                    b.Property<int>("parent_ap_id")
                        .HasColumnType("integer");

                    b.Property<string>("short_name")
                        .HasColumnType("text");

                    b.HasKey("ap_id");

                    b.ToTable("dm_apparatuses");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Apparatus2SensLink", b =>
                {
                    b.Property<int>("rec_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ap_id")
                        .HasColumnType("integer");

                    b.Property<int>("sens_id")
                        .HasColumnType("integer");

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
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<DateTime>("launch_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("power")
                        .HasColumnType("real");

                    b.HasKey("ap_id");

                    b.ToTable("dm_apparatus_info");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Sensor", b =>
                {
                    b.Property<int>("sens_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("sens_name")
                        .HasColumnType("text");

                    b.HasKey("sens_id");

                    b.ToTable("dm_sensors");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.SensorVal", b =>
                {
                    b.Property<int>("val_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("sens_id")
                        .HasColumnType("integer");

                    b.Property<float>("val")
                        .HasColumnType("real");

                    b.Property<DateTime>("val_date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("val_id");

                    b.ToTable("dm_sensor_vals");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("photo_url")
                        .HasColumnType("text");

                    b.Property<int>("table_num")
                        .HasColumnType("integer");

                    b.HasKey("user_id");

                    b.ToTable("dm_users");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Alarm", b =>
                {
                    b.HasOne("DIMON_APP.Models.PG.Apparatus", "apparatus")
                        .WithMany("alarms")
                        .HasForeignKey("ap_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DIMON_APP.Models.PG.Sensor", "sensor")
                        .WithMany("alarms")
                        .HasForeignKey("sens_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
