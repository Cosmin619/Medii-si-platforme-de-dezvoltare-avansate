using System;

namespace DefinitelyNotACircus.Presentation
{
    internal class Arena
    {
        public void PresentCircus(string circusName)
        {
            Console.WriteLine("Totally not a circus trust me I'm a human (reference: dolphin virus meme)");
            Console.WriteLine(new string('=', 100));
        }

        public void AnnounceAnimal(string animalSpecies)
        {
            Console.WriteLine();
            Console.WriteLine("What does the {0} say?", animalSpecies);
        }

        public void DisplayAnimalPerformance(string performance)
        {
            Console.WriteLine("-> {0}", performance);
        }
    }
}