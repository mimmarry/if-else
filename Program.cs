using System;
class Programm
{ 
static void Main(string[] args)
    { double firstvalue, secondvalue;
        string action;
        Console.WriteLine("Введите первое число");
        firstvalue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        secondvalue = double.Parse(Console.ReadLine());
        Console.WriteLine("Выберите действие,которое хотите выполнить: '+' '-' '*' '/'");
        action = Console.ReadLine();
        switch (action)
        {
            case "+":
                Console.WriteLine(firstvalue + secondvalue);
                break;
            case "-":
                Console.WriteLine(firstvalue - secondvalue);
                break;
            case "/":
                if (secondvalue == 0)
                {
                    Console.WriteLine("0");
                }
                else 
                {
                    Console.WriteLine(firstvalue / secondvalue);
                }
                break;
            case "*":
                Console.WriteLine(firstvalue * secondvalue);
                break;
            default:
                Console.WriteLine("Ошибка,неизвестный символ");
                break;

        }
        
    }
}