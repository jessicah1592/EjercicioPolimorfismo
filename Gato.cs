using System;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau miau!");
        }
    }
}
