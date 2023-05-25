using Proiect1.Animals;
using Proiect1.Interface;
using Proiect1.Presentation;
using System.Collections.Generic;

namespace Proiect1.CircusModel
{
    internal class Circus
    {
        private readonly Arena arena;
        private readonly List<IAnimal> animals;
        private readonly string CircusName = "Circus Maximus";

        public Circus(Arena arena)
        {
            this.arena = arena;
            animals = new List<IAnimal>();
            animals.Add(new Elephant("Babar"));
            animals.Add(new Lion("King"));
            animals.Add(new Snake("Serphent"));
            animals.Add(new Wolf("Alpha"));
            animals.Add(new Monkey("Wukong"));
        }

        public void Perform()
        {
            arena.PresentCircus(CircusName);
            foreach (IAnimal animal in animals)
            {
                arena.AnnounceAnimal(animal.Name, animal.Species);
                arena.DisplayAnimalPerformance(animal.MakeNoise());
            }
        }
    }
}