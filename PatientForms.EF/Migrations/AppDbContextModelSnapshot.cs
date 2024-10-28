﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PatientForms.EF.Configurations.DataContext;

#nullable disable

namespace PatientForms.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PatientForms.Domain.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AllergyName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Allergies", (string)null);
                });

            modelBuilder.Entity("PatientForms.Domain.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Diseases", (string)null);
                });

            modelBuilder.Entity("PatientForms.Domain.NCD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NcdName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Ncds", (string)null);
                });

            modelBuilder.Entity("PatientForms.Domain.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("DiseaseInformationId")
                        .HasColumnType("integer");

                    b.Property<byte>("Epilepsy")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseInformationId");

                    b.ToTable("Patients", (string)null);
                });

            modelBuilder.Entity("PatientForms.Domain.PatientAllergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AllergyId")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AllergyId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientAllergies", (string)null);
                });

            modelBuilder.Entity("PatientForms.Domain.PatientNCD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("NcdId")
                        .HasColumnType("integer");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NcdId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientNcds", (string)null);
                });

            modelBuilder.Entity("PatientForms.Domain.Patient", b =>
                {
                    b.HasOne("PatientForms.Domain.Disease", "DiseaseInformation")
                        .WithMany()
                        .HasForeignKey("DiseaseInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiseaseInformation");
                });

            modelBuilder.Entity("PatientForms.Domain.PatientAllergy", b =>
                {
                    b.HasOne("PatientForms.Domain.Allergy", "Allergy")
                        .WithMany("PatientAllergies")
                        .HasForeignKey("AllergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientForms.Domain.Patient", "Patient")
                        .WithMany("PatientAllergies")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergy");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientForms.Domain.PatientNCD", b =>
                {
                    b.HasOne("PatientForms.Domain.NCD", "Ncd")
                        .WithMany("PatientNcds")
                        .HasForeignKey("NcdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientForms.Domain.Patient", "Patient")
                        .WithMany("PatientNcd")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ncd");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientForms.Domain.Allergy", b =>
                {
                    b.Navigation("PatientAllergies");
                });

            modelBuilder.Entity("PatientForms.Domain.NCD", b =>
                {
                    b.Navigation("PatientNcds");
                });

            modelBuilder.Entity("PatientForms.Domain.Patient", b =>
                {
                    b.Navigation("PatientAllergies");

                    b.Navigation("PatientNcd");
                });
#pragma warning restore 612, 618
        }
    }
}
