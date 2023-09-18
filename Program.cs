using System; // Директива using для использования пространства имен System

namespace MyFirstCSharpProgram // Объявление пространства имен
{
    class Program // Объявление класса
    {
        static void Main(string[] args) // Главный метод Main
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string Name = "Dmitry";
            int age = 33;
            const bool Pet = false;
            const double ShoeSize = 49.5;

            Console.WriteLine($"Меня зовут {Name}");
            Console.WriteLine("Мой возраст {0}", age);
            Console.WriteLine($"У вас есть питомец? {Pet}");
            Console.WriteLine("Какой у вас размер ноги? {0}", ShoeSize );



        }
    }
}

