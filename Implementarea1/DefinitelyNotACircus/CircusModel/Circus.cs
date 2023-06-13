using DefinitelyNotACircus.Animals;
using DefinitelyNotACircus.Interface;
using DefinitelyNotACircus.Presentation;
using System.Collections.Generic;

namespace DefinitelyNotACircus.CircusModel
{
    internal class Circus
    {
        private readonly Arena arena;
        private readonly List<IAnimal> animals;
        private readonly string CircusName = "Circus Maximus";

        public Circus(Arena arena)
        {
            this.arena = arena;
            animals = new List<IAnimal>
            {
                new Elephant(),
                new Lion(),
                new Snake(),
                new Wolf(),
                new Monkey()
            };
        }

        public void Perform()
        {
            arena.PresentCircus(CircusName);
            foreach (IAnimal animal in animals)
            {
                arena.AnnounceAnimal(animal.Species);
                arena.DisplayAnimalPerformance(animal.MakeNoise());
            }
        }
    }
}