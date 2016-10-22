using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_grau_instrucaoMap : EntityTypeConfiguration<tb_grau_instrucao>
    {
        public tb_grau_instrucaoMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_GRAU_INSTRUCAO);

            // Properties
            this.Property(t => t.COD_GRAU_INSTRUCAO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_GRAU_INSTRUCAO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_grau_instrucao");
            this.Property(t => t.COD_GRAU_INSTRUCAO).HasColumnName("COD_GRAU_INSTRUCAO");
            this.Property(t => t.DESCRICAO_GRAU_INSTRUCAO).HasColumnName("DESCRICAO_GRAU_INSTRUCAO");
        }
    }
}
