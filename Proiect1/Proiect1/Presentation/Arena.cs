using System;

namespace Proiect1.Presentation
{
    internal class Arena
    {
        public void PresentCircus(string circusName)
        {
            Console.WriteLine("This is {0}", circusName);
            Console.WriteLine(new string('=', 50));
        }

        public void AnnounceAnimal(string animalName, string animalSpecies)
        {
            Console.WriteLine();
            Console.WriteLine("Next will perform {0}. It is a {1}:", animalName, animalSpecies);
        }

        public void DisplayAnimalPerformance(string performance)
        {
            Console.WriteLine("-> {0}", performance);
        }
    }
}