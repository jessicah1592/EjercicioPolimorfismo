using System;

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal miPerro = new Perro();
            Animal miGato = new Gato();

            miPerro.HacerSonido();  // Polimorfismo en acción
            miGato.HacerSonido();   // Polimorfismo en acción

            Console.ReadKey();
        }
    }
}
