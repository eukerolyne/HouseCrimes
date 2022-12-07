﻿// <auto-generated />
using HouseCrimes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HouseCrimes.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221206214420_rascunho")]
    partial class rascunho
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HouseCrimes.Models.Filme", b =>
                {
                    b.Property<int>("filmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FilmeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("filmeId"));

                    b.Property<string>("classificacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilmeClassificacao");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilmeDescricao");

                    b.Property<string>("duracao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilmeDuracao");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilmeTipo");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilmeTitulo");

                    b.HasKey("filmeId");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("HouseCrimes.Models.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usuarioId"));

                    b.Property<string>("usuarioDtnascimento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioDtnascimento");

                    b.Property<string>("usuarioEmail")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("usuarioNickname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNickname");

                    b.Property<string>("usuarioNome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("usuarioPassword")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioPassword");

                    b.Property<string>("usuarioSobrenome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSobrenome");

                    b.Property<string>("usuarioTelefone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.Property<string>("usuarioTipo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTipo");

                    b.HasKey("usuarioId");

                    b.ToTable("Cadastro");
                });
#pragma warning restore 612, 618
        }
    }
}