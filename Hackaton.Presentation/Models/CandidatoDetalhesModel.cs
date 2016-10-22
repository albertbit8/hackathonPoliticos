using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Presentation.Models
{
    public class CandidatoDetalhesModel
    {
        public string Nome { get; set; }
        public string Partido { get; set; }
        public string Coligacao { get; set; }
        public string Genero { get; set; }
        public string Raca { get; set; }
        public decimal Patrimonio { get; set; }
        public int Votos { get; set; }
        public decimal Arrecadacao { get; set; }
        public decimal Despesas { get; set; }
        public decimal Percentual { get; set; }
    }
}