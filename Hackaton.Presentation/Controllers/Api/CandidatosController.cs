using Hackaton.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackaton.Presentation.Controllers.Api
{
    public class CandidatosController : ApiController
    {
        public List<CandidatosModel> Get()
        {
            List<CandidatosModel> candidatos = new List<CandidatosModel>();

            candidatos.Add(new CandidatosModel()
            {
                Nome = "Fernando Haddad",
                Despesa = 2000,
                Arrecadacao = 3000
            });

            candidatos.Add(new CandidatosModel()
            {
                Nome = "João Dória",
                Despesa = 5000,
                Arrecadacao = 10000
            });

            return candidatos;
        }

        public List<CandidatoDetalhesModel> Detalhes(int id)
        {
            List<CandidatoDetalhesModel> candidatos = new List<CandidatoDetalhesModel>();

            candidatos.Add(new CandidatoDetalhesModel()
            {
                Nome = "Fernando Haddad",
                Partido = "PT",
                Coligacao = "PT",
                Genero = "Masculino",
                Raca = "Branca",
                Patrimonio = 500,
                Votos = 200,
                Arrecadacao = 19000,
                Despesas = 24700,
                Percentual = 30
            });

            return candidatos;
        }
    }
}