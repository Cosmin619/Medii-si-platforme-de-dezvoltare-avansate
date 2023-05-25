namespace Proiect1.Animals
{
    public class Monkey : AnimalBase
    {
        public Monkey(string Name)
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
            return ("Wawa wawa www");
        }
    }
}