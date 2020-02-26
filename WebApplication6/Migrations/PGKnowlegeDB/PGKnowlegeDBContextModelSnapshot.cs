﻿// <auto-generated />
using DIMON_APP.Models.PG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DIMON_APP.Migrations.PGKnowlegeDB
{
    [DbContext(typeof(PGKnowlegeDBContext))]
    partial class PGKnowlegeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DIMON_APP.Models.PG.Problem", b =>
                {
                    b.Property<int>("pr_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("pr_color")
                        .HasColumnType("character varying(1)")
                        .HasMaxLength(1);

                    b.Property<string>("pr_cond")
                        .HasColumnType("character varying(1)")
                        .HasMaxLength(1);

                    b.Property<string>("pr_nn")
                        .HasColumnType("text");

                    b.Property<string>("pr_text")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int>("sens_id")
                        .HasColumnType("integer");

                    b.HasKey("pr_id");

                    b.ToTable("dm_problem");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Reason", b =>
                {
                    b.Property<int>("rs_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("nn_rs")
                        .HasColumnType("text");

                    b.Property<int>("pr_id")
                        .HasColumnType("integer");

                    b.Property<char>("rs_cond")
                        .HasColumnType("character(1)")
                        .HasMaxLength(1);

                    b.Property<string>("rs_text")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<int>("sens_id")
                        .HasColumnType("integer");

                    b.HasKey("rs_id");

                    b.HasIndex("pr_id");

                    b.ToTable("dm_reason");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Solution", b =>
                {
                    b.Property<int>("sol_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("rs_id")
                        .HasColumnType("integer");

                    b.Property<int>("sens_id")
                        .HasColumnType("integer");

                    b.Property<string>("sol_nn")
                        .HasColumnType("text");

                    b.Property<string>("sol_par")
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.Property<string>("sol_text")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.HasKey("sol_id");

                    b.HasIndex("rs_id");

                    b.ToTable("dm_solution");
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Reason", b =>
                {
                    b.HasOne("DIMON_APP.Models.PG.Problem", "problem")
                        .WithMany("reasons")
                        .HasForeignKey("pr_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DIMON_APP.Models.PG.Solution", b =>
                {
                    b.HasOne("DIMON_APP.Models.PG.Reason", "reason")
                        .WithMany("solutions")
                        .HasForeignKey("rs_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
