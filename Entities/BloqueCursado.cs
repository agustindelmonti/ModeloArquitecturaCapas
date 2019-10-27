using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /**
     * Bloque de horario para un curso especifico. Ej: 
     * Mie 9:00 a 10:00
     * Se identifican con un Id y pertenecen a un curso especifico. 
     * Un curso puede tener muchos bloques (TEORIA o PRACTICA)
     **/
    public class BloqueCursado
    {
        [Key]
        public int BloqueID { get; set; }
        public string Titulo { get; set; }

        public enum Tipo { Teoria, Practica, No_Definido };
        public Tipo Descripcion { get; set; }
        
        public TimeSpan Inicio { get; set; }
        public TimeSpan Fin { get; set; }
        public DayOfWeek Dia { get; set; }

        public int CantBloques { get; set; }

        public Curso Curso { get; set; }

        /**
         * Definicion bloque con horas de inicio y fin       
         **/
        public BloqueCursado(TimeSpan _inicio, TimeSpan _fin, DayOfWeek _dia, Tipo _tipo)
        {
            Inicio = _inicio;
            Fin = _fin;
            Dia = _dia;
            Descripcion = _tipo;

            CantBloques = (int) Fin.Subtract(Inicio).TotalHours / 60;
        }

        /**
         * Definicion bloque con hora de inicio y cantidad de bloques
         **/
        public BloqueCursado(TimeSpan _inicio, int _cantBloques, DayOfWeek _dia, Tipo _tipo)
        {
            Inicio = _inicio;
            CantBloques = _cantBloques;
            Dia = _dia;
            Descripcion = _tipo;

            TimeSpan Bloque = new TimeSpan(0, 60 * CantBloques, 0);
            Fin = Inicio.Add(Bloque);
        }

        public BloqueCursado(TimeSpan _inicio, TimeSpan _fin, DayOfWeek _dia, string _titulo, Tipo _descripcion)
            : this(_inicio, _fin, _dia, _descripcion)
        {
            Titulo = _titulo;
            Descripcion = _descripcion;
        }
    }
}
