using System;
using Zoo.BusinessLogic.Helpers;


namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : Animal, ICanBeGroomed
  {
        public DateTime lastGroomed { get; set; }
        public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
    {

    }
    public override void Feed()
    {
      Console.WriteLine("<Munch, munch>");
      base.Feed();
    }
    public void Groom()
        {
            Grooming.GroomAnimal(this);

        }
        public override string ToString()
        {
            return base.ToString() + $"; last groomed {lastGroomed} ";
        }
    
  }
}