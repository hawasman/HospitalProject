﻿// <auto-generated />
using System;
using Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Helpers.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("text");

                    b.Property<string>("Phone1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone2")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("Api.Helpers.FinancialInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<string>("CompanyNo")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("CurrenctCredit")
                        .HasColumnType("double precision");

                    b.Property<double>("DebtSet")
                        .HasColumnType("double precision");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision");

                    b.Property<double>("InitialCredit")
                        .HasColumnType("double precision");

                    b.Property<string>("InsuranceAccount")
                        .HasColumnType("text");

                    b.Property<DateTime>("InsuranceExp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("PatientClass")
                        .HasColumnType("text");

                    b.Property<string>("PatientType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("FinancialInfo");
                });

            modelBuilder.Entity("Api.Models.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ExaminationId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PatientId")
                        .HasColumnType("integer");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ExaminationId");

                    b.HasIndex("PatientId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("Api.Models.Examination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<int>("BillId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Normal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Examinations");
                });

            modelBuilder.Entity("Api.Models.MedicalFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<string[]>("Allergies")
                        .HasColumnType("text[]");

                    b.Property<string>("BloodPressure")
                        .HasColumnType("text");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("HeatDgree")
                        .HasColumnType("double precision");

                    b.Property<int>("Hieght")
                        .HasColumnType("integer");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<int>("PulseRate")
                        .HasColumnType("integer");

                    b.Property<int>("SugarLevel")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("MedicalFiles");
                });

            modelBuilder.Entity("Api.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ContactInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("FinancialInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("FullNameArabic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullNameEnglish")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Job")
                        .HasColumnType("text");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SocialState")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("FinancialInfoId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Api.Models.TreatmentHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveField")
                        .HasColumnType("boolean");

                    b.Property<string[]>("Analysis")
                        .HasColumnType("text[]");

                    b.Property<int>("Clinicid")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<string[]>("Examinations")
                        .HasColumnType("text[]");

                    b.Property<int>("MedicalFileId")
                        .HasColumnType("integer");

                    b.Property<string[]>("Services")
                        .HasColumnType("text[]");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("Treatment")
                        .HasColumnType("text[]");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MedicalFileId");

                    b.ToTable("TreatmentsHistory");
                });

            modelBuilder.Entity("Api.Models.Attachment", b =>
                {
                    b.HasOne("Api.Models.Examination", null)
                        .WithMany("Attachments")
                        .HasForeignKey("ExaminationId");

                    b.HasOne("Api.Models.Patient", null)
                        .WithMany("Attachments")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Api.Models.MedicalFile", b =>
                {
                    b.HasOne("Api.Models.Patient", "Patient")
                        .WithOne("MedicalFile")
                        .HasForeignKey("Api.Models.MedicalFile", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Api.Models.Patient", b =>
                {
                    b.HasOne("Api.Helpers.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");

                    b.HasOne("Api.Helpers.FinancialInfo", "FinancialInfo")
                        .WithMany()
                        .HasForeignKey("FinancialInfoId");

                    b.Navigation("ContactInfo");

                    b.Navigation("FinancialInfo");
                });

            modelBuilder.Entity("Api.Models.TreatmentHistory", b =>
                {
                    b.HasOne("Api.Models.MedicalFile", "MedicalFile")
                        .WithMany("TreatmentHistory")
                        .HasForeignKey("MedicalFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalFile");
                });

            modelBuilder.Entity("Api.Models.Examination", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("Api.Models.MedicalFile", b =>
                {
                    b.Navigation("TreatmentHistory");
                });

            modelBuilder.Entity("Api.Models.Patient", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("MedicalFile");
                });
#pragma warning restore 612, 618
        }
    }
}