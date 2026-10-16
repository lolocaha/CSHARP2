using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp6
{
    public class Check
    {
        public static string ReadString(string FirstMessage)
        {

            Console.WriteLine(FirstMessage);
            string result = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(result))
            {
                Console.Write("Ошибка,введите данные типа string");
                result = Console.ReadLine();
            }
            return result;
        }
        public static int ReadInt(string FirstMessage)
        {
            Console.WriteLine(FirstMessage);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Введите число: ");

            }
            return result;
        }
        public static string OptionalReadString(string FirstMessage)
        {
            Console.WriteLine(FirstMessage);
            string result = Console.ReadLine() ;
            while (!string.IsNullOrWhiteSpace(result) && result.Any(char.IsDigit))
            {
                Console.Write("Некорректный ввод");
                result = Console.ReadLine();
            }return result;
        }
    }
}
