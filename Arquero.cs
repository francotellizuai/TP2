using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arquero : Jugador
    {
        private string altura;
        public Arquero() { }

        public Arquero(string altura, string nombre, string apellido, DateTime fecha_nacimiento) : base(nombre, apellido, fecha_nacimiento)
        {
            this.altura = altura;
        }
        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override string ToString()
        {
            return $"***********************\r\nArquero:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.Fecha_Nacimiento}\r\nAltura:{altura}\r\n";
        }
    }
}
