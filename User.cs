using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharpProgram
{
    internal class User
    {
   
            //Публичные поля класса
            public string Name;
            public int Age;
            private string FavoriteColor;
            internal int Passport; // доступно в любом месте текущего проекта
            private DateTime EmploymentDate = DateTime.Now;

            //Конструктор класса.

            public User()
            {
                Name = "Unknown";
                Age = 0;
                FavoriteColor = "Unknown";
            }

            public User(string name, int age)
            {
                Name = name;
                Age = age;
                FavoriteColor = "Unknown";
            }
            public User(string name, int age, string favoriteColor, int passport)
            {
                Name = name;
                Age = age;
                FavoriteColor = favoriteColor;
                Passport = passport;

            }



            //Методы класса
            public string Print()
            {
                return $"Пользователя зовут {Name}, возраст {Age}, любимый цвет {FavoriteColor}, сотрудник принят на работу {EmploymentDate} \n " +
                    $"Пасорт сотрудника: {Passport}";
            }

            public void ChangeName(string ChangeName)
            {
                Name = ChangeName;
            }

            public void ChangeAge(int age)
            {
                Age = age;
            }

            public void ChangeFavoriteColor(string favoriteColor)
            {
                FavoriteColor = favoriteColor;
            }

            private void ChangePassword(int password)
            {
                Passport = password;
            }
    }
}
