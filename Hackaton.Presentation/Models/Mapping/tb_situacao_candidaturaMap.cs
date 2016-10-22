using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_situacao_candidaturaMap : EntityTypeConfiguration<tb_situacao_candidatura>
    {
        public tb_situacao_candidaturaMap()
        {
            // Primary Key
            this.HasKey(t => t.COD_SITUACAO_CANDIDATURA);

            // Properties
            this.Property(t => t.COD_SITUACAO_CANDIDATURA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DES_SITUACAO_CANDIDATURA)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tb_situacao_candidatura");
            this.Property(t => t.COD_SITUACAO_CANDIDATURA).HasColumnName("COD_SITUACAO_CANDIDATURA");
            this.Property(t => t.DES_SITUACAO_CANDIDATURA).HasColumnName("DES_SITUACAO_CANDIDATURA");
        }
    }
}
