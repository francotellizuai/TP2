using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Unidad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al banco UAI");
            Equipo equipo = new Equipo();
            Console.WriteLine("Ingrese el nombre del equipo");
            equipo.Nombre = Console.ReadLine(); 

            Console.WriteLine("Seleccione una Opcion:");
            Console.WriteLine("1-Agregar Arquero:");
            Console.WriteLine("2-Agregar Defensor:");
            Console.WriteLine("3-Agregar Mediocampista:");
            Console.WriteLine("4-Agregar Delantero:");
            Console.WriteLine("5-Listar jugadores:");
            Console.WriteLine("6-Listar arqueros:");
            Console.WriteLine("7-Listar defensas:");
            Console.WriteLine("8-Listar mediocampistas:");
            Console.WriteLine("9-Listar delanteros:");
            Console.WriteLine("10-Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            string message = "";

            do
            {
                switch (opcion)
                {
                    case 1:
                        Arquero arquero = new Arquero();
                        Console.WriteLine("Ingrese el nombre del Arquero:");
                        arquero.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido:");
                        arquero.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento:");
                        arquero.Fecha_Nacimiento = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese su altura en CM:");
                        arquero.Altura = Console.ReadLine();

                        message = equipo.RegistrarJugador(arquero);
                        Console.WriteLine(message);
                        break;
                    case 2:
                        Defensor defensor = new Defensor();
                        Console.WriteLine("Ingrese el nombre del Defensor:");
                        defensor.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido:");
                        defensor.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento:");
                        defensor.Fecha_Nacimiento = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese cantidad tarjeras rojas:");
                        defensor.Cantidad_tarjetas_rojas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese cantidad tarjeras amarillas:");
                        defensor.Cantidad_tarjetas_amarillas = int.Parse(Console.ReadLine());

                        message = equipo.RegistrarJugador(defensor);
                        Console.WriteLine(message);
                        break;
                    case 3:
                        Mediocampista mediocampista = new Mediocampista();
                        Console.WriteLine("Ingrese el nombre del Mediocampista:");
                        mediocampista.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido:");
                        mediocampista.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento:");
                        mediocampista.Fecha_Nacimiento = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese cantidad de asistencias:");
                        mediocampista.Cantidad_asistencias = int.Parse(Console.ReadLine());

                        message = equipo.RegistrarJugador(mediocampista);
                        Console.WriteLine(message);
                        break;

                    case 4:
                        Delantero delantero = new Delantero();
                        Console.WriteLine("Ingrese el nombre del Delantero:");
                        delantero.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido:");
                        delantero.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento:");
                        delantero.Fecha_Nacimiento = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese cantidad de goles:");
                        delantero.CantidadGoles = int.Parse(Console.ReadLine());

                        message = equipo.RegistrarJugador(delantero);
                        Console.WriteLine(message);
                        break;
                    case 5:
                        var jugadores = equipo.ListarJugadores();
                        foreach (var jugador in jugadores)
                        {
                            Console.WriteLine(jugador);
                        }
                        break;
                    case 6:
                        var arqueros = equipo.ListarArqueros();
                        foreach (var arqueroItem in arqueros)
                        {
                            Console.WriteLine(arqueroItem);
                        }
                        break;
                    case 7:
                        var defensores = equipo.ListarDefensores();
                        foreach (var defensorItem in defensores)
                        {
                            Console.WriteLine(defensorItem);
                        }
                        break;
                    case 8:
                        var mediocampistas = equipo.ListarMedioCampistas();
                        foreach (var mediocampistaitem in mediocampistas)
                        {
                            Console.WriteLine(mediocampistaitem);
                        }
                        break;
                    case 9:
                        var delanteros = equipo.ListarDelanteros();
                        foreach (var delanteroItem in delanteros)
                        {
                            Console.WriteLine(delanteros);
                        }
                        break;
                }

                Console.WriteLine("Seleccione una Opcion:");
                Console.WriteLine("1-Agregar Arquero:");
                Console.WriteLine("2-Agregar Defensor:");
                Console.WriteLine("3-Agregar Mediocampista:");
                Console.WriteLine("4-Agregar Delantero:");
                Console.WriteLine("5-Listar jugadores:");
                Console.WriteLine("6-Listar arqueros:");
                Console.WriteLine("7-Listar defensas:");
                Console.WriteLine("8-Listar mediocampistas:");
                Console.WriteLine("9-Listar delanteros:");
                Console.WriteLine("10-Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion > 0 && opcion < 7);

            Console.ReadKey();// Esto evita que se cierre el programa


        } 
    }
}