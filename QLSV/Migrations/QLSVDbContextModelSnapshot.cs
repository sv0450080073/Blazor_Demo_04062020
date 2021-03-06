﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLSV.Data;

namespace QLSV.Migrations
{
    [DbContext(typeof(QLSVDbContext))]
    partial class QLSVDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLSV.Models.Class", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("School_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClassName = "Lớp học 01",
                            School_ID = 1
                        },
                        new
                        {
                            ID = 2,
                            ClassName = "Lớp học 02",
                            School_ID = 2
                        },
                        new
                        {
                            ID = 3,
                            ClassName = "Lớp học 03",
                            School_ID = 3
                        },
                        new
                        {
                            ID = 4,
                            ClassName = "Lớp học 04",
                            School_ID = 1
                        },
                        new
                        {
                            ID = 5,
                            ClassName = "Lớp học 05",
                            School_ID = 2
                        },
                        new
                        {
                            ID = 6,
                            ClassName = "Lớp học 06",
                            School_ID = 3
                        });
                });

            modelBuilder.Entity("QLSV.Models.School", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShoolName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ShoolName = "Trường đại học 01"
                        },
                        new
                        {
                            ID = 2,
                            ShoolName = "Trường đại học 02"
                        },
                        new
                        {
                            ID = 3,
                            ShoolName = "Trường đại học 03"
                        });
                });

            modelBuilder.Entity("QLSV.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Class_ID")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Class_ID = 1,
                            StudentName = "Học sinh 01"
                        },
                        new
                        {
                            ID = 2,
                            Class_ID = 2,
                            StudentName = "Học sinh 02"
                        },
                        new
                        {
                            ID = 3,
                            Class_ID = 3,
                            StudentName = "Học sinh 03"
                        },
                        new
                        {
                            ID = 4,
                            Class_ID = 1,
                            StudentName = "Học sinh 04"
                        },
                        new
                        {
                            ID = 5,
                            Class_ID = 2,
                            StudentName = "Học sinh 05"
                        },
                        new
                        {
                            ID = 6,
                            Class_ID = 3,
                            StudentName = "Học sinh 06"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
