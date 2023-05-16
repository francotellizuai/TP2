using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Delantero : Jugador
    {
        private int cantidad_goles;
        public Delantero() { }

        public Delantero(int cantidad_goles, string nombre, string apellido, DateTime fecha_nacimiento):base(nombre, apellido, fecha_nacimiento)
        {
            this.cantidad_goles = cantidad_goles;
        }
        public int CantidadGoles
        {
            get { return cantidad_goles; }
            set { cantidad_goles = value; }
        }

        public override string ToString()
        {
            return $"***********************\r\nDelantero:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.Fecha_Nacimiento}\r\nCantidad de goles:{cantidad_goles}\r\n";
        }
    }
}
