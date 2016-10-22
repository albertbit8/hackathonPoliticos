using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_ocupacaoMap : EntityTypeConfiguration<tb_ocupacao>
    {
        public tb_ocupacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO_OCUPACAO);

            // Properties
            this.Property(t => t.CODIGO_OCUPACAO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_OCUPACAO)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("tb_ocupacao");
            this.Property(t => t.CODIGO_OCUPACAO).HasColumnName("CODIGO_OCUPACAO");
            this.Property(t => t.DESCRICAO_OCUPACAO).HasColumnName("DESCRICAO_OCUPACAO");
        }
    }
}
