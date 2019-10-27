using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    
    public class BloqueCursado
    {
        public int BloqueId { get; set; }
        public string Titulo{ get; set; }
        public string Descripcion { get; set; }

        //Bloque de horario. Ej: Mie 9:00 a 10:30
        public string Inicio{ get; set; }
        public string Fin { get; set; }
        public DayOfWeek Dia { get; set; }

        //constructor bloque vacio
        public BloqueCursado(string _inicio, string _fin, DayOfWeek _dia)
        {
            Inicio = _inicio;
            Fin = _fin;
            Dia = _dia;
        }

        public BloqueCursado(string _inicio, string _fin, DayOfWeek _dia ,string _titulo, string _descripcion) 
            : this(_inicio, _fin, _dia)
        {
            Titulo = _titulo;
            Descripcion = _descripcion;
        }
    }
}