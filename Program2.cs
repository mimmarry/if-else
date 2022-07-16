using System;
class Programm
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
        double firstvalue, secondvalue;
        string action;
            try
            {
                Console.WriteLine("Введите первое число");
                firstvalue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                secondvalue = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Не удалось преобразовать строку в число");
                Console.ReadLine();
                continue;
            }
        Console.WriteLine("Выберите действие,которое хотите выполнить: '+' '-' '*' '/'");
        action = Console.ReadLine();
            if (action == "+")
            {
                Console.WriteLine(firstvalue + secondvalue);
            }
            else if (action == "-")
            {
                Console.WriteLine(firstvalue - secondvalue);
            }
            else if (action == "*")
            {
                Console.WriteLine(firstvalue * secondvalue);
            }
            else if (action == "/")
            {
                if (secondvalue == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(firstvalue / secondvalue);
                }
            }
            else
            {
                Console.WriteLine("Неизвестное действие");
               
            }
            }
     
    }


    }
