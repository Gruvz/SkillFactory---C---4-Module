using System; // Директива using для использования пространства имен System
using System.Data;

namespace MyFirstCSharpProgram // Объявление пространства имен
{
    class Program // Объявление класса
    {

        static void Main(string[] args) // Главный метод Main
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter your name:");
            string Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {Name} and age is {age}");

            //Специально играюсь с DateTime
            Console.Write("Enter your birthdate:");
            DateTime BirdDate = DateTime.Parse(Console.ReadLine());
            string formattedDate = BirdDate.ToString("yyyy-MM-dd");
            Console.WriteLine($"Your birtdate is {formattedDate}");

            Console.ReadKey();

        }
    }
}


