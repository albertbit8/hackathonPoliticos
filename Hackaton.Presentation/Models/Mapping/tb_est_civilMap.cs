using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_est_civilMap : EntityTypeConfiguration<tb_est_civil>
    {
        public tb_est_civilMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO_ESTADO_CIVIL);

            // Properties
            this.Property(t => t.CODIGO_ESTADO_CIVIL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_ESTADO_CIVIL)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("tb_est_civil");
            this.Property(t => t.CODIGO_ESTADO_CIVIL).HasColumnName("CODIGO_ESTADO_CIVIL");
            this.Property(t => t.DESCRICAO_ESTADO_CIVIL).HasColumnName("DESCRICAO_ESTADO_CIVIL");
        }
    }
}
