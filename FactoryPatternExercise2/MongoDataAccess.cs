using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the Mongo database.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database.");
        }
    }
}
