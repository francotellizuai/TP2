using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mediocampista : Jugador
    {
        private int cantidad_asistencias;
        public Mediocampista() { }

        public Mediocampista(int cantidad_asistencias, string nombre, string apellido, DateTime fecha_nacimiento) : base(nombre, apellido, fecha_nacimiento)
        {
            this.cantidad_asistencias = cantidad_asistencias;
        }
        public int Cantidad_asistencias
        {
            get { return cantidad_asistencias; }
            set { cantidad_asistencias = value; }
        }


        public override string ToString()
        {
            return $"***********************\r\nMediocampista:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.Fecha_Nacimiento}\r\nCantidad asistencias:{cantidad_asistencias}\r\n";
        }
    }

}
