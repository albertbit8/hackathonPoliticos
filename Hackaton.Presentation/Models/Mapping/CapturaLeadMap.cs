using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class CapturaLeadMap : EntityTypeConfiguration<CapturaLead>
    {
        public CapturaLeadMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ip)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("CapturaLeads");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.data).HasColumnName("data");
            this.Property(t => t.ip).HasColumnName("ip");
        }
    }
}
