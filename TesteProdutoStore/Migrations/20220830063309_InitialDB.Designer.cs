// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteProdutoStore.Data;

#nullable disable

namespace TesteProdutoStore.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20220830063309_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TesteProdutoStore.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tblCategoriaProduto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Descricao = "Eletrodomestico",
                            Nome = "Eletrônico"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            Descricao = "Aparelhos e Acessórios",
                            Nome = "Celulares"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            Descricao = "Artigos para Vestuário em Geral",
                            Nome = "Moda"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            Descricao = "Livros",
                            Nome = "Livros"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            Descricao = "Produtos para Informatica",
                            Nome = "Informática"
                        });
                });

            modelBuilder.Entity("TesteProdutoStore.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Perecivel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("tblProduto");
                });

            modelBuilder.Entity("TesteProdutoStore.Models.Produto", b =>
                {
                    b.HasOne("TesteProdutoStore.Models.Categoria", "Categoria")
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
