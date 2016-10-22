using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_nacionalidadeMap : EntityTypeConfiguration<tb_nacionalidade>
    {
        public tb_nacionalidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO_COR_RACA);

            // Properties
            this.Property(t => t.CODIGO_COR_RACA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_NACIONALIDADE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_nacionalidade");
            this.Property(t => t.CODIGO_COR_RACA).HasColumnName("CODIGO_COR_RACA");
            this.Property(t => t.DESCRICAO_NACIONALIDADE).HasColumnName("DESCRICAO_NACIONALIDADE");
        }
    }
}
