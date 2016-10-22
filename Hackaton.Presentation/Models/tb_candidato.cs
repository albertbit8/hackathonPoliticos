using System;
using System.Collections.Generic;

namespace Hackaton.Presentation.Models
{
    public partial class tb_candidato
    {
        public string CPF_CANDIDATO { get; set; }
        public string ANO_ELEICAO { get; set; }
        public string NUM_TURNO { get; set; }
        public string DESCRICAO_ELEICAO { get; set; }
        public string SIGLA_UF { get; set; }
        public string SIGLA_UE { get; set; }
        public string DESCRICAO_UE { get; set; }
        public Nullable<int> CODIGO_CARGO { get; set; }
        public string NOME_URNA_CANDIDATO { get; set; }
        public string NOME_CANDIDATO { get; set; }
        public string SEQUENCIAL_CANDIDATO { get; set; }
        public string NUMERO_CANDIDATO { get; set; }
        public Nullable<int> COD_SITUACAO_CANDIDATURA { get; set; }
        public Nullable<int> NUMERO_PARTIDO { get; set; }
        public string CODIGO_LEGENDA { get; set; }
        public string SIGLA_LEGENDA { get; set; }
        public string COMPOSICAO_LEGENDA { get; set; }
        public string NOME_LEGENDA { get; set; }
        public Nullable<int> CODIGO_OCUPACAO { get; set; }
        public Nullable<System.DateTime> DATA_NASCIMENTO { get; set; }
        public string NUM_TITULO_ELEITORAL_CANDIDATO { get; set; }
        public Nullable<int> IDADE_DATA_ELEICAO { get; set; }
        public Nullable<int> CODIGO_SEXO { get; set; }
        public Nullable<int> COD_GRAU_INSTRUCAO { get; set; }
        public Nullable<int> CODIGO_ESTADO_CIVIL { get; set; }
        public Nullable<int> CODIGO_COR_RACA { get; set; }
        public Nullable<int> CODIGO_NACIONALIDADE { get; set; }
        public string SIGLA_UF_NASCIMENTO { get; set; }
        public Nullable<int> CODIGO_MUNICIPIO_NASCIMENTO { get; set; }
        public string NOME_MUNICIPIO_NASCIMENTO { get; set; }
        public Nullable<int> DESPESA_MAX_CAMPANHA { get; set; }
        public Nullable<int> COD_SIT_TOT_TURNO { get; set; }
        public string NM_EMAIL { get; set; }
    }
}
