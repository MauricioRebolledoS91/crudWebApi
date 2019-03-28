using Momento2.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Momento2.Controllers
{
    public class EstudianteController : ApiController
    {
        
        public IEnumerable<Estudiante> Get()
        {
            MomentoConnection BD = new MomentoConnection();
            var listado = BD.Estudiante.ToList();
            return listado;
        }
    }
}
