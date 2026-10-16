using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class Человек
    {
        private string name;
        private int height;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0) throw new ArgumentException("Рост должен быть больше 0");
                height = value;
            }
        }

        public Человек(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return $"""Человек с именем "{Name}" и ростом: {Height}""";
        }
    }

    public class Имя
    {
        private string lastName;
        private string firstName;
        private string middleName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public Имя(string lastName, string firstName, string middleName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
        }

        public override string ToString()
        {
            List<string> parts = new List<string>();
            if (!string.IsNullOrWhiteSpace(LastName)) parts.Add(LastName);
            if (!string.IsNullOrWhiteSpace(FirstName)) parts.Add(FirstName);
            if (!string.IsNullOrWhiteSpace(MiddleName)) parts.Add(MiddleName);
            return string.Join(" ", parts);
        }
    }
    public class ЧеловекСИменем
    {
        private Имя name;
        private int height;

        public Имя Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0) throw new ArgumentException("Рост должен быть больше 0");
                height = value;
            }
        }

        public ЧеловекСИменем(Имя name, int height)
        {
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return $"Человека с Именем {Name} и ростом {Height}";
        }
    }
    public class Город
    {
        private string name;
        private Dictionary<Город, int> wave;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Город(string name)
        {
            Name = name;
            wave = new Dictionary<Город, int>();
        }

        public Город(string name, Dictionary<Город, int> paths) : this(name)
        {
            if (paths != null)
            {
                foreach (var pair in paths)
                    wave.Add(pair.Key, pair.Value);
            }
        }

        public void AddWave(Город city, int price)
        {
            wave[city] = price;
        }

        public override string ToString()
        {
            List<string> parts = new List<string>();
            foreach (var pair in wave)
                parts.Add($"{pair.Key.Name}:{pair.Value}");
            return $"{Name} -> {string.Join(", ", parts)}";
        }
    }

    public class Дробь
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть 0");
                denominator = value;
            }
        }

        public Дробь(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Дробь Sum(Дробь other)
        {
            return new Дробь(Numerator * other.Denominator + other.Numerator * Denominator,
                             Denominator * other.Denominator);
        }
        public Дробь Sum(int n) { return Sum(new Дробь(n, 1)); }

        public Дробь Minus(Дробь other)
        {
            return new Дробь(Numerator * other.Denominator - other.Numerator * Denominator,
                             Denominator * other.Denominator);
        }
        public Дробь Minus(int n) { return Minus(new Дробь(n, 1)); }

        public Дробь Mul(Дробь other)
        {
            return new Дробь(Numerator * other.Numerator, Denominator * other.Denominator);
        }
        public Дробь Mul(int n) { return Mul(new Дробь(n, 1)); }

        public Дробь Div(Дробь other)
        {
            if (other.Numerator == 0) throw new DivideByZeroException("Деление на нулевую дробь");
            return new Дробь(Numerator * other.Denominator, Denominator * other.Numerator);
        }
        public Дробь Div(int n) { return Div(new Дробь(n, 1)); }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

}