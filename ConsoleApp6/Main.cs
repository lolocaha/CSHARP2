using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Prog
    {
        static void Main()
        {
            //Задание 1.2
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
            //Задание 3.3
            Город a = new Город("A");
            Город b = new Город("B");
            Город c = new Город("C");
            Город d = new Город("D");
            Город e = new Город("E");
            Город f = new Город("F");

            a.AddWave(b, 5);
            a.AddWave(f, 1);
            a.AddWave(d, 6);

            b.AddWave(c, 3);
            b.AddWave(a, 5);

            c.AddWave(d, 4);
            c.AddWave(b, 3);

            d.AddWave(c, 4);
            d.AddWave(e, 2);
            d.AddWave(a, 6);

            e.AddWave(f, 2);

            f.AddWave(b, 1);
            f.AddWave(e, 2);
            Console.WriteLine("Задание 3.3:");
            foreach (Город city in new Город[] { a, b, c, d, e, f })
            {
                Console.WriteLine($"Город {city}");
            }
            //Задание 4.8
            Город g = new Город("G", new Dictionary<Город, int> {{ a, 7 }, { c, 9 }});
            Console.WriteLine($"Задание 4.8:\nГород {g}");
            //Задание 5.5
            Console.WriteLine("Задание 5.5:");
            Дробь f1 = new Дробь(1, 3);
            Дробь f2 = new Дробь(2, 3);
            Дробь f3 = new Дробь(3, 4);
            Console.WriteLine($"{f1} + {f2} = {f1.Sum(f2)}");
            Console.WriteLine($"{f1} - {f2} = {f1.Minus(f2)}");
            Console.WriteLine($"{f1} * {f2} = {f1.Mul(f2)}");
            Console.WriteLine($"{f1} / {f2} = {f1.Div(f2)}");
            Console.WriteLine($"{f1} + 2 = {f1.Sum(2)}");
            Console.WriteLine($"{f1} - 2 = {f1.Minus(2)}");
            Console.WriteLine($"{f1} * 2 = {f1.Mul(2)}");
            Console.WriteLine($"{f1} / 2 = {f1.Div(2)}");
            Console.WriteLine($"f1.sum(f2).div(f3).minus(5) = {f1.Sum(f2).Div(f3).Minus(5)}");
        }
    }
}
