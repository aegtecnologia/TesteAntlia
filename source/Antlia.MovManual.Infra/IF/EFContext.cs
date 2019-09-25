using Antlia.MovManual.Domain.Dominios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Antlia.MovManual.Infra.IF
{
    public sealed class EFContext : DbContext
    {
        public EFContext()
        { }

        public EFContext(DbContextOptions<EFContext> opcoes)
            : base(opcoes)
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCosif> ProdutosCosif { get; set; }
        public DbSet<MovimentoManual> MovimentosManual { get; set; }

        protected override void OnModelCreating(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.ForSqlServerUseIdentityColumns();
            construtorDeModelos.HasDefaultSchema("dbo");

            ConfiguraProduto(construtorDeModelos);
            ConfiguraMovimentoManual(construtorDeModelos);
            ConfiguraProdutoCosif(construtorDeModelos);
        }

        private void ConfiguraProduto(ModelBuilder construtorDeModelos)
        {
            //ToDo seprarar em arquivo Config
            //ToDo Incluir Chave estrangeira
            construtorDeModelos.Entity<Produto>(etd =>
            {
                etd.ToTable("PRODUTO");
                etd.HasKey(c => c.COD_PRODUTO);
                etd.Property(c => c.COD_PRODUTO).HasMaxLength(4).IsRequired();
                etd.Property(c => c.DES_PRODUTO).HasMaxLength(30);
                etd.Property(c => c.STA_STATUS).HasMaxLength(1);
            });
        }

        private void ConfiguraProdutoCosif(ModelBuilder construtorDeModelos)
        {

            //ToDo seprarar em arquivo Config
            //ToDo Incluir Chave estrangeira
            construtorDeModelos.Entity<ProdutoCosif>(etd =>
            {
                etd.ToTable("PRODUTO_COSIF");
                etd.HasKey(c => new { c.COD_PRODUTO, c.COD_COSIF });
                etd.Property(c => c.COD_PRODUTO).HasMaxLength(4).IsRequired();
                etd.Property(c => c.COD_COSIF).HasMaxLength(30).IsRequired();
                etd.Property(c => c.COD_CLASSIFICACAO).HasMaxLength(6);
                etd.Property(c => c.STA_STATUS).HasMaxLength(1);
            });
        }

        private void ConfiguraMovimentoManual(ModelBuilder construtorDeModelos)
        {

            //ToDo seprarar em arquivo Config
            //ToDo Incluir Chave estrangeira
            construtorDeModelos.Entity<MovimentoManual>(etd =>
            {
                etd.ToTable("MOVIMENTO_MANUAL");
                etd.HasKey(c => new { c.COD_PRODUTO, c.COD_COSIF, c.DAT_ANO, c.DAT_MES,c.NUM_LANCAMENTO });
                etd.Property(c => c.DAT_MES).IsRequired();
                etd.Property(c => c.DAT_ANO).IsRequired();
                etd.Property(c => c.NUM_LANCAMENTO).IsRequired();
                etd.Property(c => c.COD_PRODUTO).HasMaxLength(4).IsRequired();
                etd.Property(c => c.COD_COSIF).HasMaxLength(11).IsRequired();
                etd.Property(c => c.DES_DESCRICAO).HasMaxLength(8000);
                etd.Property(c => c.COD_USUARIO).HasMaxLength(100);
            });
        }
    }
}
