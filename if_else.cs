using System;
class Programm
{
    static void Main(string[] args)
    {
        //Напишите программу ,проверяющее число,введенное с клавиатуры на четность 
        double chislo;
        Console.WriteLine("Введите число");
        chislo = double.Parse(Console.ReadLine());
            if (chislo % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        else 
        {
            Console.WriteLine("Число нечетное");
        }
    }
}