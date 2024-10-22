﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product.Models;

#nullable disable

namespace Product.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240813025111_createTable")]
    partial class createTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Product.Models.Department", b =>
                {
                    b.Property<string>("DepartmentCode")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DepartmentCode");

                    b.Property<string>("AdditionalFields")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AdditionalFields");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DepartmentName");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Location");

                    b.Property<int>("NumberOfPersonnels")
                        .HasColumnType("int")
                        .HasColumnName("NumberOfPersonnels");

                    b.HasKey("DepartmentCode");

                    b.ToTable("Department_Tbl");
                });

            modelBuilder.Entity("Product.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeCode")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("EmployeeCode");

                    b.Property<string>("DepartmentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("DepartmentCode");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EmployeeName");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Rank");

                    b.HasKey("EmployeeCode");

                    b.HasIndex("DepartmentCode");

                    b.ToTable("Employee_Tbl");
                });

            modelBuilder.Entity("Product.Models.Employee", b =>
                {
                    b.HasOne("Product.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Product.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
