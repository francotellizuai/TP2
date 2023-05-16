using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Equipo
    {
        private string nombre; 
        private List<Jugador> jugadores;
        private const int CANTIDAD_DELANTEROS = 4;
        private const int CANTIDAD_DEFENSORES = 6;
        private const int CANTIDAD_MEDIOCAMPISTAS = 5;
        private const int CANTIDAD_ARQUEROS = 3;

        private int cantidad_delanteros;
        private int cantidad_defensores;
        private int cantidad_mediocampistas;
        private int cantidad_arqueros;

        public Equipo(string nombre)
        {
            jugadores = new List<Jugador>();
            this.nombre = nombre;
        }

        public Equipo() 
        {
            jugadores = new List<Jugador>();
        }

        public string RegistrarJugador(Jugador jugador)
        {

            string errorMessage = "No existe el el tipo de jugador";
            if (jugador is Arquero)
            {
                if (cantidad_arqueros < CANTIDAD_ARQUEROS)
                {
                    this.jugadores.Add(jugador);
                    cantidad_arqueros++;
                    return "Arquero agregado con éxito.";
                }
                else
                {
                    return "No se puede agregar más arqueros.";
                }
            }
            else if (jugador is Defensor)
            {
                if (cantidad_defensores < CANTIDAD_DEFENSORES)
                {
                    this.jugadores.Add(jugador);
                    cantidad_defensores++;
                    return "Defensor agregado con éxito.";

                }
                else
                {
                    return "No se puede agregar más defensores.";
                }
            }
            else if (jugador is Mediocampista)
            {
                if (cantidad_arqueros < CANTIDAD_ARQUEROS)
                {
                    this.jugadores.Add(jugador);
                    cantidad_arqueros++;
                    return "Mediocampista agregado con éxito.";


                }
                else
                {
                    return "No se puede agregar más mediocampistas.";
                }
            }
            else if (jugador is Delantero)
            {
                if (cantidad_delanteros < CANTIDAD_DELANTEROS)
                {
                    this.jugadores.Add(jugador);
                    cantidad_delanteros++;
                    return "Delantero agregado con éxito.";

                }
                else
                {
                    return "No se puede agregar más delanteros.";
                }
            }

            return errorMessage;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public ReadOnlyCollection<string> ListarJugadores()
        {
            var listaJugadores = new List<string>();
            foreach (var item in jugadores)
            {
                listaJugadores.Add(item.ToString());
            }
            return listaJugadores.AsReadOnly();
        }

        public ReadOnlyCollection<Arquero> ListarArqueros()
        {
            return jugadores.OfType<Arquero>().ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Defensor> ListarDefensores()
        {
            return jugadores.OfType<Defensor>().ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Mediocampista> ListarMedioCampistas()
        {
            return jugadores.OfType<Mediocampista>().ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Delantero> ListarDelanteros()
        {
            return jugadores.OfType<Delantero>().ToList().AsReadOnly();
        }
    }
}

