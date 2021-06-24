﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectPAW_Stancescu_Georgian_1057.Modele;

namespace ProiectPAW_Stancescu_Georgian_1057.Migrations
{
    [DbContext(typeof(EF_AppContext))]
    partial class EF_AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("ProiectPAW_Stancescu_Georgian_1057.Clase.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Client")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataRaportare")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriereProblema")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gravitate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProgramatorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stadiu")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TitluProblema")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProgramatorId");

                    b.ToTable("Bugs");
                });

            modelBuilder.Entity("ProiectPAW_Stancescu_Georgian_1057.Clase.Programator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Functie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nume")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenume")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Programatori");
                });

            modelBuilder.Entity("ProiectPAW_Stancescu_Georgian_1057.Clase.Solutie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BugId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cauza")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataSol")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriereSol")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BugId")
                        .IsUnique();

                    b.ToTable("Solutii");
                });

            modelBuilder.Entity("ProiectPAW_Stancescu_Georgian_1057.Clase.Bug", b =>
                {
                    b.HasOne("ProiectPAW_Stancescu_Georgian_1057.Clase.Programator", null)
                        .WithMany("Bugs")
                        .HasForeignKey("ProgramatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProiectPAW_Stancescu_Georgian_1057.Clase.Solutie", b =>
                {
                    b.HasOne("ProiectPAW_Stancescu_Georgian_1057.Clase.Bug", null)
                        .WithOne("Solutie")
                        .HasForeignKey("ProiectPAW_Stancescu_Georgian_1057.Clase.Solutie", "BugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
