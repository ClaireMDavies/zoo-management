using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Helpers
{
    public static class Grooming
    {
        
        public static void GroomAnimal(ICanBeGroomed groomedAnimal)
        {
            
            groomedAnimal.lastGroomed = DateTime.Now;
            

            
        }

    }
}
