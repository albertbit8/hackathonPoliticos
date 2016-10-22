using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Presentation.Models
{
    public class CandidatosModel
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public decimal Arrecadacao { get; set; }
        public decimal Despesa { get; set; }
    }
}