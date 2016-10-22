using Hackaton.Presentation.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Hackaton.Presentation.Controllers
{
    public class PartidosController : ApiController
    {
        public List<PartidoDominioModel> Get()
        {
            List<PartidoDominioModel> partidos = new List<PartidoDominioModel>();
            partidos.Add(new PartidoDominioModel()
            {
                Id = 1,
                Sigla = "PT"
            });
            partidos.Add(new PartidoDominioModel()
            {
                Id = 2,
                Sigla = "PSOL"
            });

            return partidos;
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
