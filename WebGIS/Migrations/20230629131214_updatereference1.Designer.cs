﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebGIS.EfCore;

#nullable disable

namespace WebGIS.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    [Migration("20230629131214_updatereference1")]
    partial class updatereference1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebGIS.EfCore.AnoCestice", b =>
                {
                    b.Property<string>("MaticniBrojKo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("AnoCesticaId")
                        .HasColumnType("text");

                    b.Property<string>("BrojCestice")
                        .HasColumnType("text");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text");

                    b.Property<string>("Rotacija")
                        .HasColumnType("text");

                    b.HasKey("MaticniBrojKo");

                    b.ToTable("AnoCestice");
                });

            modelBuilder.Entity("WebGIS.EfCore.Cestice", b =>
                {
                    b.Property<string>("MaticniBrojKo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("AdresaOpisna")
                        .HasColumnType("text");

                    b.Property<string>("BrojCestice")
                        .HasColumnType("text");

                    b.Property<string>("CesticaId")
                        .HasColumnType("text");

                    b.Property<string>("CesticaIzvorId")
                        .HasColumnType("text");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text");

                    b.Property<string>("DetaljniList")
                        .HasColumnType("text");

                    b.Property<string>("OznakaOkoline")
                        .HasColumnType("text");

                    b.Property<string>("PovrsinaAtributna")
                        .HasColumnType("text");

                    b.Property<string>("PovrsinaGraficka")
                        .HasColumnType("text");

                    b.Property<string>("StatusCestice")
                        .HasColumnType("text");

                    b.Property<string>("StatusKzKn")
                        .HasColumnType("text");

                    b.HasKey("MaticniBrojKo");

                    b.ToTable("Cestice");
                });

            modelBuilder.Entity("WebGIS.EfCore.CesticeZgrade", b =>
                {
                    b.Property<string>("ZgradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("CesticaId")
                        .HasColumnType("text");

                    b.HasKey("ZgradaId");

                    b.ToTable("CesticeZgrade");
                });

            modelBuilder.Entity("WebGIS.EfCore.Identifikacije", b =>
                {
                    b.Property<string>("MaticniBrojKo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("BrojCestice")
                        .HasColumnType("text");

                    b.Property<string>("BrojZkCestice")
                        .HasColumnType("text");

                    b.Property<string>("CesticaId")
                        .HasColumnType("text");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text");

                    b.Property<string>("GlavnaKnjigaId")
                        .HasColumnType("text");

                    b.Property<string>("OznakaVezeCestice")
                        .HasColumnType("text");

                    b.Property<string>("OznakaVezeZkCestice")
                        .HasColumnType("text");

                    b.Property<string>("PodbrojZkCestice")
                        .HasColumnType("text");

                    b.Property<string>("Verificirano")
                        .HasColumnType("text");

                    b.Property<string>("ZkCesticaId")
                        .HasColumnType("text");

                    b.HasKey("MaticniBrojKo");

                    b.ToTable("Identifikacije");
                });

            modelBuilder.Entity("WebGIS.EfCore.KatastarskeOpcine", b =>
                {
                    b.Property<string>("MaticniBrojKo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text");

                    b.Property<string>("IzvornoMjerilo")
                        .HasColumnType("text");

                    b.Property<string>("KatastarskaOpcinaId")
                        .HasColumnType("text");

                    b.Property<string>("NazivKo")
                        .HasColumnType("text");

                    b.Property<string>("StatusKzKn")
                        .HasColumnType("text");

                    b.Property<string>("VrstaKatastarskeOpcine")
                        .HasColumnType("text");

                    b.HasKey("MaticniBrojKo");

                    b.ToTable("KatastarskeOpcine");
                });

            modelBuilder.Entity("WebGIS.EfCore.MedjeCestica", b =>
                {
                    b.Property<string>("MaticniBrojKo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Broj")
                        .HasColumnType("text");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text");

                    b.Property<string>("MedjaCesticeId")
                        .HasColumnType("text");

                    b.HasKey("MaticniBrojKo");

                    b.ToTable("MedjeCestica");
                });

            modelBuilder.Entity("WebGIS.EfCore.NaciniUporabe", b =>
                {
                    b.Property<string>("NacinUporabeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("AdresaOpisna")
                        .HasColumnType("text");

                    b.Property<string>("CesticaId")
                        .HasColumnType("text");

                    b.Property<string>("Coordinates")
                        .HasColumnType("text");

                    b.Property<string>("MaticniBrojKo")
                        .HasColumnType("text");

                    b.Property<string>("NazivVrsteUporabe")
                        .HasColumnType("text");

                    b.Property<string>("OznakaPravaGradjenja")
                        .HasColumnType("text");

                    b.Property<string>("PosjedovniListBroj")
                        .HasColumnType("text");

                    b.Property<string>("Povrsina")
                        .HasColumnType("text");

                    b.Property<string>("SifraVrsteUporabe")
                        .HasColumnType("text");

                    b.Property<string>("StatusNacinaUporabe")
                        .HasColumnType("text");

                    b.HasKey("NacinUporabeId");

                    b.ToTable("NaciniUporabe");
                });
#pragma warning restore 612, 618
        }
    }
}