namespace DefinitelyNotACircus.Animals
{
    public class Snake : AnimalBase
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
            return ("Sssss");
        }
    }
}