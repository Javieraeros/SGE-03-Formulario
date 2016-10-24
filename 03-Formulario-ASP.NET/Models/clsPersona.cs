using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Formulario_ASP.NET.Models
{
    public class Persona
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTimeOffset FechaNac { get; set; }

        public int id { get; set; }

        public Persona(){
            id = 1;
            Nombre = "";
            Apellidos = "";
            FechaNac = new DateTimeOffset();
            }

        public Persona(int parId,string nombre, string apellidos, DateTimeOffset fechaNac)
        {
            this.id = parId;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
        }
    }
}
