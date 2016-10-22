using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Hackaton.Presentation.Models.Mapping;

namespace Hackaton.Presentation.Models
{
    public partial class VivaRealDBContext : DbContext
    {
        static VivaRealDBContext()
        {
            Database.SetInitializer<VivaRealDBContext>(null);
        }

        public VivaRealDBContext()
            : base("Name=VivaRealDBContext")
        {
        }

        public DbSet<CapturaLead> CapturaLeads { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<tb_cargo> tb_cargo { get; set; }
        public DbSet<tb_est_civil> tb_est_civil { get; set; }
        public DbSet<tb_grau_instrucao> tb_grau_instrucao { get; set; }
        public DbSet<tb_nacionalidade> tb_nacionalidade { get; set; }
        public DbSet<tb_ocupacao> tb_ocupacao { get; set; }
        public DbSet<tb_raca_cor> tb_raca_cor { get; set; }
        public DbSet<tb_sexo> tb_sexo { get; set; }
        public DbSet<tb_situacao_candidatura> tb_situacao_candidatura { get; set; }
        public DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CapturaLeadMap());
            modelBuilder.Configurations.Add(new LeadMap());
            modelBuilder.Configurations.Add(new tb_cargoMap());
            modelBuilder.Configurations.Add(new tb_est_civilMap());
            modelBuilder.Configurations.Add(new tb_grau_instrucaoMap());
            modelBuilder.Configurations.Add(new tb_nacionalidadeMap());
            modelBuilder.Configurations.Add(new tb_ocupacaoMap());
            modelBuilder.Configurations.Add(new tb_raca_corMap());
            modelBuilder.Configurations.Add(new tb_sexoMap());
            modelBuilder.Configurations.Add(new tb_situacao_candidaturaMap());
            modelBuilder.Configurations.Add(new database_firewall_rulesMap());
        }
    }
}
