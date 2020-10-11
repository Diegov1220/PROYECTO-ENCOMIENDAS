using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa3_Dominio.Entidades;

namespace Capa1.Presentacion.Controllers.Operaciones
{
    [RoutePrefix("RealizarEnvio")]
    public class RealizarEnvioController : Controller
    {
        // GET: RealizarEnvio
        public ActionResult Index()
        {
            return View();
        }

        [Route("RealizarEnvio")]
        public ActionResult RealizarEnvioPaquete()
        {

            List<Envio> list = new List<Envio>();
            return View(list);

        }
    }
}