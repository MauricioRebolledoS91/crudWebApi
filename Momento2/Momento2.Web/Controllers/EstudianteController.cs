using Momento2.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Momento2.Web.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            //Consumir el api de Estudiantes
            HttpClient cliente = new HttpClient();
            //Apuntando a la ubicación del api
            cliente.BaseAddress = new Uri("http://localhost:64861/");

            var request = cliente.GetAsync("api/Estudiante").Result;
            if (request.IsSuccessStatusCode)
            {
                var response = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Estudiante>>(response);
                return View(listado);
            }
            return View(new List<Estudiante>());
        }
    }
}