using System;

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }
    }
}
