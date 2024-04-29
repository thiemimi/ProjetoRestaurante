﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using rm551478.Persistencia;

#nullable disable

namespace rm551478.Migrations
{
    [DbContext(typeof(OracleDBContext))]
    partial class OracleDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("rm551478.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CategoriaId");

                    b.ToTable("TB_Categoria_551478");
                });

            modelBuilder.Entity("rm551478.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("NVARCHAR2(8)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("NVARCHAR2(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ClienteId");

                    b.ToTable("TB_Cliente_551478");
                });

            modelBuilder.Entity("rm551478.Models.ItemPedido", b =>
                {
                    b.Property<int>("ItemPedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemPedidoId"));

                    b.Property<int>("PedidoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("PratoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(4,2)")
                        .HasColumnName("PrecoUnitario");

                    b.Property<int>("Quantidade")
                        .HasMaxLength(2)
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("ItemPedidoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("TB_ItemPedido_551478");
                });

            modelBuilder.Entity("rm551478.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("StatusPedido")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Status");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("TB_Pedido_551478");
                });

            modelBuilder.Entity("rm551478.Models.Prato", b =>
                {
                    b.Property<int>("PratoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PratoId"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("PratoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("TB_Prato_551478");
                });

            modelBuilder.Entity("rm551478.Models.ItemPedido", b =>
                {
                    b.HasOne("rm551478.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("rm551478.Models.Pedido", b =>
                {
                    b.HasOne("rm551478.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("rm551478.Models.Prato", b =>
                {
                    b.HasOne("rm551478.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
