using System;
using Zoo.BusinessLogic.Helpers;


namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : Animal, ICanBeGroomed
  {
        public DateTime lastGroomed { get; set; }
        public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
    {
         
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