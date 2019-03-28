using System;
using System.Collections.Generic;
using System.Text;

namespace Momento2.Entidades
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Programa { get; set; }
        public System.DateTime FechaMatricula { get; set; }
        public double ValorMatricula { get; set; }
    }
}
