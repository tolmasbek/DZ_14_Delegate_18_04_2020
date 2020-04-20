using System;
using CalculatorFunctionsSpase;

namespace DZ_14_Delegate
{
    class Program
    {
        delegate T DelegateCalc <T> (T num1, T num2);
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
            System.Console.Write("Введиет num1: ");
            double num1 = double.Parse(Console.ReadLine());
            System.Console.Write("Введиет num2: ");
            double num2 = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Выберите один из действий для этих чисел: ");
            System.Console.WriteLine("1: -,\n2: +,\n3: /,\n4: *.");
            System.Console.Write("Ваш выбор: "); 

            double choise = double.Parse(Console.ReadLine());
            switch(choise)
            {
                case 1:
                {
                    DelegateCalc<double> minus = CalculatorFunctions.Minus;
                    System.Console.WriteLine(minus.Invoke(num1,num2));
                    break;
                }
                case 2:
                {
                    DelegateCalc<double> plus = CalculatorFunctions.Plus;
                    System.Console.WriteLine(plus.Invoke(num1,num2));
                    break;
                }
                case 3:
                {
                    DelegateCalc<double> division = CalculatorFunctions.Division;
                    System.Console.WriteLine(division.Invoke(num1,num2));
                    break;
                }
                case 4:
                {
                    DelegateCalc<double> multiplication = CalculatorFunctions.Multiplication;
                    System.Console.WriteLine(multiplication.Invoke(num1,num2));
                    break;
                }
            }
            Console.ReadKey();
        }    
    }
}
