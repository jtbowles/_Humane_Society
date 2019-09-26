using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
           // PointOfEntry.Run();
            Animal animal = new Animal();
            animal.Name = "Cow";
            //Query.AddAnimal(animal);

            Query.RemoveAnimal(animal);




        }
    }
}
