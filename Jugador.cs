using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jugador
    {
        private string nombre;
        private string apellido;
        private DateTime fecha_nacimiento;

        public Jugador() { }
        public Jugador(string nombre, string apellido, DateTime fecha_nacimiento)
        {
           this.Nombre = nombre;
           this.apellido = apellido;
           this.fecha_nacimiento = fecha_nacimiento;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime Fecha_Nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

    }
}
