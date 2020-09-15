﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PencatatanSuhuPekerjaAPI.Context;

namespace PencatatanSuhuPekerjaAPI.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200915040934_addTemperature")]
    partial class addTemperature
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PencatatanSuhuPekerjaAPI.Models.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdateAt");

                    b.HasKey("DepartmentId");

                    b.ToTable("tb_m_departments");
                });

            modelBuilder.Entity("PencatatanSuhuPekerjaAPI.Models.Division", b =>
                {
                    b.Property<string>("DivisionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DepartmentId");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdateAt");

                    b.HasKey("DivisionId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("tb_m_divisions");
                });

            modelBuilder.Entity("PencatatanSuhuPekerjaAPI.Models.Temperature", b =>
                {
                    b.Property<string>("TemperatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.HasKey("TemperatureId");

                    b.ToTable("temperatures");
                });

            modelBuilder.Entity("PencatatanSuhuPekerjaAPI.Models.Division", b =>
                {
                    b.HasOne("PencatatanSuhuPekerjaAPI.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
