namespace DefinitelyNotACircus.Animals
{
    public class Lion : AnimalBase
    {
        public override string Species
        {
            get
            {
                return this.GetType().Name;
            }
            protected set { }
        }

        public override string MakeNoise()
        {
            return ("Rwaar");
        }
    }
}