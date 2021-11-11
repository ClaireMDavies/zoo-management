using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Helpers;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class BonoboChimpanzee : Animal, ICanBeGroomed
    {
        public DateTime lastGroomed { get; set; }
        public BonoboChimpanzee(DateTime dateOfBirth) : base(dateOfBirth)
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
