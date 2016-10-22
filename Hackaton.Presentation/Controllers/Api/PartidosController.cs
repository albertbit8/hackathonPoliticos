using Hackaton.Presentation.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Hackaton.Presentation.Controllers
{
    public class PartidosController : Controller
    {
        public List<PartidoModel> Get()
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
