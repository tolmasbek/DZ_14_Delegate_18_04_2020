using System;
using CalculatorFunctionsSpase;

namespace DZ_14_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Задание 2
                    A. Создайте проект по шаблону Console Application.
                    B. Создать статические методы основных функции калькулятора (-, +, /, *)
                        1. Методы должны принимать 2 обобщённых типов (generic) и возвращать такой
                        же тип в качестве результата
                    C. Создать делегат, соответствующий данным методам и присвоить каждый метод по
                    необходимость от выбора пользователя и присвоить метод как значение к делегату.
                        1. Вызов методов происходит только по средством делегата.
            */
            System.Console.Write("Введиет num_1: ");
            int num_1 = int.Parse(Console.ReadLine());
            System.Console.Write("Введиет num_2: ");
            int num_2 = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Выберите один из действий для этих чисел: ");
            System.Console.WriteLine("1: -,\n2: +,\n3: /,\n4: *.");
            System.Console.Write("Ваш выбор: "); 

            int choise = int.Parse(Console.ReadLine());
            
            Console.ReadKey();
        }    
    }
}
