

using System;

namespace Anshi._2Lesson
{
    class Program

    {
        static void Main(string[] args)
        {

            while (true)
            {
                double FirstValue, SecondValue;
                string action;


                Console.WriteLine("Введите первое число");
                FirstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                SecondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:'+' '-' '*' '/' ");

                action = Console.ReadLine();
                switch (action)
                {


                    default:
                        Console.WriteLine("Ошибка неизвестная операция");
                        break;
                    case "+":
                        Console.WriteLine(FirstValue + SecondValue);
                        break;

                    case "-":
                        Console.WriteLine(FirstValue - SecondValue);
                        break;

                    case "/":
                        Console.WriteLine(FirstValue / SecondValue);
                        break;

                    case "*":
                        Console.WriteLine(FirstValue * SecondValue);
                        break;
                    case "q":
                        return;
                        
                        
                }
                Console.WriteLine("Нажмите клавишу q для выполнения следуйщей операции");
                Console.ReadLine();
                
                Console.Clear();

            }



        }

                


    }

}








           

       
      







              
            
            
            







        
   

