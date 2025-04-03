﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDeJogos.Context;

#nullable disable

namespace ProjetoDeJogos.Migrations
{
    [DbContext(typeof(ProjetoJogosContext))]
    [Migration("20250403163049_DbJogos2")]
    partial class DbJogos2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoDeJogos.Domains.Jogo", b =>
                {
                    b.Property<Guid>("JogoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nomeDoJogo")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("plataforma")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("JogoID");

                    b.HasIndex("nomeDoJogo")
                        .IsUnique()
                        .HasFilter("[nomeDoJogo] IS NOT NULL");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("ProjetoDeJogos.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JogoFavorito")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("JogoFavorito");

                    b.HasIndex("Nickname")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoDeJogos.Domains.Usuarios", b =>
                {
                    b.HasOne("ProjetoDeJogos.Domains.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoFavorito")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");
                });
#pragma warning restore 612, 618
        }
    }
}
