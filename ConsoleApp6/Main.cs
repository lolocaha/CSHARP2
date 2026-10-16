using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Prog
    {
        static void Main()
        {//Задание 1.2
            Человек h1 = new Человек("Клеопатра", 192);
            Человек h2 = new Человек("Пушкин", 167);
            Человек h3 = new Человек("Владимир", 189);
            Console.WriteLine($"Задание 1.2:\n{h1}\n{h2}\n{h3}");
            //Задание 1.3
            Имя h4 = new Имя("Клеопатра", null, null);
            Имя h5 = new Имя("Пушкин", "Александр", "Сергеевич");
            Имя h6 = new Имя("Маяковский", "Владимир", "");
            Console.WriteLine($"Задание 1.3:\n{h4}\n{h5}\n{h6}");
            //Задание 2.2
            ЧеловекСИменем h7 = new ЧеловекСИменем(h4, h1.Height);
            ЧеловекСИменем h8 = new ЧеловекСИменем(h5, h2.Height);
            ЧеловекСИменем h9 = new ЧеловекСИменем(h6, h3.Height);
            Console.WriteLine($"Задание 2.2:\n{h7}\n{h8}\n{h9}");
        }
    }
}