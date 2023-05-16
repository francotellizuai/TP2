using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Defensor : Jugador
    {
        private int cantidad_tarjetas_rojas;
        private int cantidad_tarjetas_amarillas;

        public Defensor() { }

        public Defensor(int cantidad_tarjetas_rojas, int cantidad_tarjetas_amarillas, string nombre, string apellido, DateTime fecha_nacimiento) : base(nombre, apellido, fecha_nacimiento)
        {
            this.cantidad_tarjetas_rojas = cantidad_tarjetas_rojas;
            this.cantidad_tarjetas_amarillas = cantidad_tarjetas_amarillas;

        }
        public int Cantidad_tarjetas_amarillas
        {
            get { return cantidad_tarjetas_amarillas; }
            set { cantidad_tarjetas_amarillas = value; }
        }

        public int Cantidad_tarjetas_rojas
        {
            get { return cantidad_tarjetas_rojas; }
            set { cantidad_tarjetas_rojas = value; }
        }

        public override string ToString()
        {
            return $"***********************\r\nDefensor:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.Fecha_Nacimiento}\r\nCantidad de tarjetas rojas:{cantidad_tarjetas_rojas}\r\nCantidad de tarjetas amarillas:{cantidad_tarjetas_amarillas}";
        }
    }

}
