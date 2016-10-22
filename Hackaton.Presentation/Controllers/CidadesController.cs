using Hackaton.Presentation.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Hackaton.Presentation.Controllers
{
    public class CidadesController : ApiController
    {
        public List<CidadeDominioModel> Get()
        {
            List<CidadeDominioModel> cidades = new List<CidadeDominioModel>();
            cidades.Add(new CidadeDominioModel()
            {
                Id = 1,
                Nome = "São Paulo"
            });
            cidades.Add(new CidadeDominioModel()
            {
                Id = 2,
                Nome = "Ribeirão Preto"
            });

            return cidades;
        }

        public List<PartidoModel> Detalhes()
        {
            List<PartidoModel> partidos = new List<PartidoModel>();
            partidos.Add(new PartidoModel()
            {
                Sigla = "PT",
                Gastos = 2000
            });
            partidos.Add(new PartidoModel()
            {
                Sigla = "PSDB",
                Gastos = 3000
            });

            return partidos;
        }
    }
}
