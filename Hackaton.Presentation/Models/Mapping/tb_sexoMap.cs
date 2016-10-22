using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class tb_sexoMap : EntityTypeConfiguration<tb_sexo>
    {
        public tb_sexoMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO_SEXO);

            // Properties
            this.Property(t => t.CODIGO_SEXO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRICAO_SEXO)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("tb_sexo");
            this.Property(t => t.CODIGO_SEXO).HasColumnName("CODIGO_SEXO");
            this.Property(t => t.DESCRICAO_SEXO).HasColumnName("DESCRICAO_SEXO");
        }
    }
}
