﻿// <auto-generated />
using System;
using EveM_Curd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EveM_Curd.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20230425131652_EventForm")]
    partial class EventForm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EveM_Curd.Models.EventDetail", b =>
                {
                    b.Property<int>("Event_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Event_id"));

                    b.Property<string>("Event_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Event_id");

                    b.ToTable("EventDetails");
                });

            modelBuilder.Entity("EveM_Curd.Models.EventExpense", b =>
                {
                    b.Property<int>("Expense_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Expense_id"));

                    b.Property<int>("Expense_amount")
                        .HasColumnType("int");

                    b.Property<string>("Expense_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expense_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Expense_id");

                    b.ToTable("EventExpenses");
                });

            modelBuilder.Entity("EveM_Curd.Models.EventForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cmteMbrs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dcmtPth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("enDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("evDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("evTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("locations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainImgPth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phyOnlEvt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recSinEvnt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("stDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EventForms");
                });

            modelBuilder.Entity("EveM_Curd.Models.EventIncome", b =>
                {
                    b.Property<int>("Income_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Income_id"));

                    b.Property<int>("Income_amount")
                        .HasColumnType("int");

                    b.Property<string>("Income_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Income_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Income_id");

                    b.ToTable("EventIncomes");
                });

            modelBuilder.Entity("EveM_Curd.Models.VendorDetail", b =>
                {
                    b.Property<int>("Vendor_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vendor_id"));

                    b.Property<string>("Add_info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_person")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service_offered")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendor_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Vendor_id");

                    b.ToTable("VendorDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
