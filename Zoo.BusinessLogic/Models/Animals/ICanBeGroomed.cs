using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public interface ICanBeGroomed
    {
         void Groom();
         DateTime lastGroomed { get; set; }

    }
}
