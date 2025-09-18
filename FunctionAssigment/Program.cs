using System.Xml.Linq;

namespace FunctionAssigment
{
    internal class Program
    {
        /// <summary>
        /// Kysyy nimen
        /// </summary>
        /// <returns>Valid output</returns>
        static string KysyNimi()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    return name.Trim();
            
                Console.WriteLine("Name cannot be empty.");
            }
        }
        static int KysyIkä()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                int age;
                if (int.TryParse(input, out age) && age > 0)
                    return age;

                    Console.WriteLine("Please enter a positive integer.");
            }
        }
        static void TulosNimiJaIkä(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        static bool TarkistaTäysiIkäinen(int age)
        {
            return age >= 18;
        }
        static void VertaaNimeä(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Your name compares to '{compareTo}' (case-insentive.");
            }
            if (name.Equals(compareTo))
            {
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-insentive).");
            }
        }

        static void Main(string[] args)
        {
            string name = KysyNimi();
            int age = KysyIkä();

            TulosNimiJaIkä(name, age);
            bool isFullAge = TarkistaTäysiIkäinen(age);

            if (isFullAge)
            {
                Console.WriteLine("You are not an adult");
            }
            else
                Console.WriteLine("You are not an adult.");

            VertaaNimeä(name, "Matti");
        }
    }
}
