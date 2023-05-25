namespace Proiect1.Animals
{
    public class Lion : AnimalBase
    {
        public Lion(string Name)
        {
            base.Name = Name;
        }

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