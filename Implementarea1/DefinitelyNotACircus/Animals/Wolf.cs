namespace DefinitelyNotACircus.Animals
{
    public class Wolf : AnimalBase
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
            return ("Awww");
        }
    }
}