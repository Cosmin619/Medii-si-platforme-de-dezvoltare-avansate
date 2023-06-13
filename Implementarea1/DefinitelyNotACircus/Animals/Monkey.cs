namespace DefinitelyNotACircus.Animals
{
    public class Monkey : AnimalBase
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
            return ("Wawa wawa www");
        }
    }
}