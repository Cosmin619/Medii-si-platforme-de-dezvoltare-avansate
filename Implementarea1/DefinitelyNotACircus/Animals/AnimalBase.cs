using DefinitelyNotACircus.Interface;

namespace DefinitelyNotACircus.Animals
{
    public abstract class AnimalBase : IAnimal
    {
        public abstract string Species { get; protected set; }
        public abstract string MakeNoise();
    }
}
