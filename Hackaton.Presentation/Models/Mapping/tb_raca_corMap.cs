using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_raca_corMap : EntityTypeConfiguration<tb_raca_cor>
    {
        public tb_raca_corMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO_COR_RACA);

            // Properties
            this.Property(t => t.CODIGO_COR_RACA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_COR_RACA)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("tb_raca_cor");
            this.Property(t => t.CODIGO_COR_RACA).HasColumnName("CODIGO_COR_RACA");
            this.Property(t => t.DESCRICAO_COR_RACA).HasColumnName("DESCRICAO_COR_RACA");
        }
    }
}
