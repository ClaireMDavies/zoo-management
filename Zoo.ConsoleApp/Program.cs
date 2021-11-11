using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;
using Zoo.BusinessLogic.Helpers;

namespace Zoo.ConsoleApp
{
  public static class Program
  {
    public static void Main()
    {
      var lions = new[]
      {
        new Lion(new DateTime(2010, 4, 28)),
        new Lion(new DateTime(2012, 5, 11))
      };
      var otherAnimals = new Animal[] {
        new Rabbit(new DateTime(2014, 1, 1)),
        new Zebra(new DateTime(2008, 12, 1)), 
        new GuineaFowl(new DateTime(2021, 1, 1)),
        new SlowLoris(new DateTime(2018, 5, 8)),
        new BonoboChimpanzee(new DateTime(2005, 6, 3))
      };
      var animals = lions.Union<Animal>(otherAnimals).ToList();

      var keepers = new[]
      {
        new Keeper(lions),
        new Keeper(otherAnimals) 
      };

      var feedingScheduler = FeedingScheduler.Instance;
      var groomingScheduler = GroomingScheduler.Instance;

      while (true)
      {
        Console.WriteLine("Feeding the animals...");
        feedingScheduler.AssignFeedingJobs(keepers, animals);

        Console.WriteLine("Grooming the animals...");
        groomingScheduler.AssignGroomingJobs(keepers, animals);

        Console.WriteLine("Done. Results:");

        foreach (var animal in animals)
        {
          Console.WriteLine(animal);
        }

        Console.WriteLine();
        Thread.Sleep(1000);
      }

    }
  }
}
