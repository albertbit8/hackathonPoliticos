using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Presentation.Models
{
    public class CandidatoModel
    {
        public CandidatoModel()
        {
            this.Candidatos = new List<CandidatosModel>();
        }

        public int TotalEleitos { get; set; }
        public decimal TotalDespesas { get; set; }
        public List<CandidatosModel> Candidatos { get; set; }
    }
}