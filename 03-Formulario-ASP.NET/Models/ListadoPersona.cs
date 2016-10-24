using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03_Formulario_ASP.NET.Models
{
    /// <summary>
    /// Clase de utilidades de prueba, no se debe usar así
    /// </summary>
    public class ListadoPersona
    {
        private List<Persona> p = new List<Persona>();
        
        public void ListadoDefecto()
        {
            p.Add(new Persona(1, "Javier", "Ruiz", new DateTimeOffset()));
            p.Add(new Persona(2, "Javier2", "Ruiz2", new DateTimeOffset()));
            p.Add(new Persona(3, "Javier3", "Ruiz3", new DateTimeOffset()));
            p.Add(new Persona(4, "Javier4", "Ruiz4", new DateTimeOffset()));
            p.Add(new Persona(5, "Javier5", "Ruiz5", new DateTimeOffset()));
            p.Add(new Persona(6, "Javier6", "Ruiz6", new DateTimeOffset()));
        }
        
        public void aniadePersona(Persona ps)
        {
            p.Add(ps);
        }

        public List<Persona> devuelveListado()
        {
            return p;
        }
    }
}