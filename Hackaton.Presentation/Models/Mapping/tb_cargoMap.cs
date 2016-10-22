using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_cargoMap : EntityTypeConfiguration<tb_cargo>
    {
        public tb_cargoMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO_CARGO);

            // Properties
            this.Property(t => t.CODIGO_CARGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_CARGO)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tb_cargo");
            this.Property(t => t.CODIGO_CARGO).HasColumnName("CODIGO_CARGO");
            this.Property(t => t.DESCRICAO_CARGO).HasColumnName("DESCRICAO_CARGO");
        }
    }
}
