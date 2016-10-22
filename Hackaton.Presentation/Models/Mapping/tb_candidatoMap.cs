using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_candidatoMap : EntityTypeConfiguration<tb_candidato>
    {
        public tb_candidatoMap()
        {
            // Primary Key
            this.HasKey(t => t.CPF_CANDIDATO);

            // Properties
            this.Property(t => t.CPF_CANDIDATO)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.ANO_ELEICAO)
                .HasMaxLength(4);

            this.Property(t => t.NUM_TURNO)
                .HasMaxLength(1);

            this.Property(t => t.DESCRICAO_ELEICAO)
                .HasMaxLength(30);

            this.Property(t => t.SIGLA_UF)
                .HasMaxLength(2);

            this.Property(t => t.SIGLA_UE)
                .HasMaxLength(10);

            this.Property(t => t.DESCRICAO_UE)
                .HasMaxLength(100);

            this.Property(t => t.NOME_URNA_CANDIDATO)
                .HasMaxLength(50);

            this.Property(t => t.NOME_CANDIDATO)
                .HasMaxLength(100);

            this.Property(t => t.SEQUENCIAL_CANDIDATO)
                .HasMaxLength(20);

            this.Property(t => t.NUMERO_CANDIDATO)
                .HasMaxLength(20);

            this.Property(t => t.CODIGO_LEGENDA)
                .HasMaxLength(20);

            this.Property(t => t.SIGLA_LEGENDA)
                .HasMaxLength(20);

            this.Property(t => t.COMPOSICAO_LEGENDA)
                .HasMaxLength(200);

            this.Property(t => t.NOME_LEGENDA)
                .HasMaxLength(200);

            this.Property(t => t.NUM_TITULO_ELEITORAL_CANDIDATO)
                .HasMaxLength(20);

            this.Property(t => t.SIGLA_UF_NASCIMENTO)
                .HasMaxLength(2);

            this.Property(t => t.NOME_MUNICIPIO_NASCIMENTO)
                .HasMaxLength(50);

            this.Property(t => t.NM_EMAIL)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tb_candidato");
            this.Property(t => t.CPF_CANDIDATO).HasColumnName("CPF_CANDIDATO");
            this.Property(t => t.ANO_ELEICAO).HasColumnName("ANO_ELEICAO");
            this.Property(t => t.NUM_TURNO).HasColumnName("NUM_TURNO");
            this.Property(t => t.DESCRICAO_ELEICAO).HasColumnName("DESCRICAO_ELEICAO");
            this.Property(t => t.SIGLA_UF).HasColumnName("SIGLA_UF");
            this.Property(t => t.SIGLA_UE).HasColumnName("SIGLA_UE");
            this.Property(t => t.DESCRICAO_UE).HasColumnName("DESCRICAO_UE");
            this.Property(t => t.CODIGO_CARGO).HasColumnName("CODIGO_CARGO");
            this.Property(t => t.NOME_URNA_CANDIDATO).HasColumnName("NOME_URNA_CANDIDATO");
            this.Property(t => t.NOME_CANDIDATO).HasColumnName("NOME_CANDIDATO");
            this.Property(t => t.SEQUENCIAL_CANDIDATO).HasColumnName("SEQUENCIAL_CANDIDATO");
            this.Property(t => t.NUMERO_CANDIDATO).HasColumnName("NUMERO_CANDIDATO");
            this.Property(t => t.COD_SITUACAO_CANDIDATURA).HasColumnName("COD_SITUACAO_CANDIDATURA");
            this.Property(t => t.NUMERO_PARTIDO).HasColumnName("NUMERO_PARTIDO");
            this.Property(t => t.CODIGO_LEGENDA).HasColumnName("CODIGO_LEGENDA");
            this.Property(t => t.SIGLA_LEGENDA).HasColumnName("SIGLA_LEGENDA");
            this.Property(t => t.COMPOSICAO_LEGENDA).HasColumnName("COMPOSICAO_LEGENDA");
            this.Property(t => t.NOME_LEGENDA).HasColumnName("NOME_LEGENDA");
            this.Property(t => t.CODIGO_OCUPACAO).HasColumnName("CODIGO_OCUPACAO");
            this.Property(t => t.DATA_NASCIMENTO).HasColumnName("DATA_NASCIMENTO");
            this.Property(t => t.NUM_TITULO_ELEITORAL_CANDIDATO).HasColumnName("NUM_TITULO_ELEITORAL_CANDIDATO");
            this.Property(t => t.IDADE_DATA_ELEICAO).HasColumnName("IDADE_DATA_ELEICAO");
            this.Property(t => t.CODIGO_SEXO).HasColumnName("CODIGO_SEXO");
            this.Property(t => t.COD_GRAU_INSTRUCAO).HasColumnName("COD_GRAU_INSTRUCAO");
            this.Property(t => t.CODIGO_ESTADO_CIVIL).HasColumnName("CODIGO_ESTADO_CIVIL");
            this.Property(t => t.CODIGO_COR_RACA).HasColumnName("CODIGO_COR_RACA");
            this.Property(t => t.CODIGO_NACIONALIDADE).HasColumnName("CODIGO_NACIONALIDADE");
            this.Property(t => t.SIGLA_UF_NASCIMENTO).HasColumnName("SIGLA_UF_NASCIMENTO");
            this.Property(t => t.CODIGO_MUNICIPIO_NASCIMENTO).HasColumnName("CODIGO_MUNICIPIO_NASCIMENTO");
            this.Property(t => t.NOME_MUNICIPIO_NASCIMENTO).HasColumnName("NOME_MUNICIPIO_NASCIMENTO");
            this.Property(t => t.DESPESA_MAX_CAMPANHA).HasColumnName("DESPESA_MAX_CAMPANHA");
            this.Property(t => t.COD_SIT_TOT_TURNO).HasColumnName("COD_SIT_TOT_TURNO");
            this.Property(t => t.NM_EMAIL).HasColumnName("NM_EMAIL");
        }
    }
}
