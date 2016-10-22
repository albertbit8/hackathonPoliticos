using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Hackaton.Presentation.Models.Mapping
{
    public class LeadMap : EntityTypeConfiguration<Lead>
    {
        public LeadMap()
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

            this.Property(t => t.mensagem)
                .HasMaxLength(2000);

            this.Property(t => t.telefone)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Leads");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.data).HasColumnName("data");
            this.Property(t => t.mensagem).HasColumnName("mensagem");
            this.Property(t => t.telefone).HasColumnName("telefone");
        }
    }
}
