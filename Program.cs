using System; // Директива using для использования пространства имен System

namespace MyFirstCSharpProgram // Объявление пространства имен
{
    class Program // Объявление класса
    {
        
        static void Main(string[] args) // Главный метод Main
        {
        
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            User FirstUser = new User("Ekaterina", 39, "Yellow", 4590);
            
            FirstUser.Passport = 333;
            Console.WriteLine(FirstUser.Print());
            Console.ReadKey();

            //"Ekaterina", 39


        }
    }

    
}

