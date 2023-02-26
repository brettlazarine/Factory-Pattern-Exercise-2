namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product("battery", 1.75);
            var p2 = new Product("water bottle", 2.25);
            bool isDb = false;
            string answer; 
            do
            {
                Console.WriteLine("What database do you want to use: List, SQL, or Mongo?");
                answer = Console.ReadLine();
                if (answer.ToLower() == "list" || answer.ToLower() == "sql" || answer.ToLower() == "mongo") { isDb = true; }
            } while (isDb == false);
            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(answer);
            var prodList = dataAccess.LoadData(); prodList.Add(p1); prodList.Add(p2);
            Console.WriteLine("Products in the database and their price:");
            foreach (Product product in prodList)
            {
                Console.WriteLine($"{product.Name}: ${product.Price}");
            }
            dataAccess.SaveData();
        }
    }
}
