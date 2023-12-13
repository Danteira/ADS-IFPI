﻿// <auto-generated />
using System;
using Lincoln_MatheusAPS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lincoln_MatheusAPS.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231210200713_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Item", b =>
                {
                    b.Property<int>("IdI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdPd")
                        .HasColumnType("int");

                    b.Property<int>("Percentual")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("IdI");

                    b.HasIndex("Id");

                    b.HasIndex("IdPd");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Marca", b =>
                {
                    b.Property<int>("IdM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("IdM");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Idt")
                        .HasColumnType("int");

                    b.Property<int>("Idtp")
                        .HasColumnType("int");

                    b.Property<int>("Idv")
                        .HasColumnType("int");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("Idt");

                    b.HasIndex("Idtp");

                    b.HasIndex("Idv");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Pagamento", b =>
                {
                    b.Property<int>("Idp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Idp");

                    b.HasIndex("Id");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Produto", b =>
                {
                    b.Property<int>("IdPd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("IdM")
                        .HasColumnType("int");

                    b.Property<string>("NomeId")
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("IdPd");

                    b.HasIndex("IdM");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("Idtp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrador")
                        .HasColumnType("longtext");

                    b.HasKey("Idtp");

                    b.ToTable("TipoDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Transportadora", b =>
                {
                    b.Property<int>("Idt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Idt");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Vendedor", b =>
                {
                    b.Property<int>("Idv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Idv");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("Lincoln_MatheusAPS.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("Lincoln_MatheusAPS.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Item", b =>
                {
                    b.HasOne("Lincoln_MatheusAPS.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Items")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lincoln_MatheusAPS.Models.Produto", "Produto")
                        .WithMany("Items")
                        .HasForeignKey("IdPd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.NotaDeVenda", b =>
                {
                    b.HasOne("Lincoln_MatheusAPS.Models.Cliente", "Cliente")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lincoln_MatheusAPS.Models.Transportadora", "Transportadora")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("Idt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lincoln_MatheusAPS.Models.TipoDePagamento", "TipoDePagamento")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("Idtp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lincoln_MatheusAPS.Models.Vendedor", "Vendedor")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("Idv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoDePagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Pagamento", b =>
                {
                    b.HasOne("Lincoln_MatheusAPS.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Pagamentos")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Produto", b =>
                {
                    b.HasOne("Lincoln_MatheusAPS.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("IdM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Cliente", b =>
                {
                    b.Navigation("NotaDeVendas");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Produto", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.TipoDePagamento", b =>
                {
                    b.Navigation("NotaDeVendas");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Transportadora", b =>
                {
                    b.Navigation("NotaDeVendas");
                });

            modelBuilder.Entity("Lincoln_MatheusAPS.Models.Vendedor", b =>
                {
                    b.Navigation("NotaDeVendas");
                });
#pragma warning restore 612, 618
        }
    }
}
