using Proiect1.Interface;

namespace Proiect1.Animals
{
    public abstract class AnimalBase : IAnimal
    {
        public string Name { get; protected set; }
        public abstract string Species { get; protected set; }
        public abstract string MakeNoise();
    }
}
