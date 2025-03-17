using System;

namespace GIT
{
    class Firm
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Year { get; set; }

        public Firm(string name, string address, int year)
        {
            Name = name;
            Address = address;
            Year = year;
        }

        public string GetInfo()
        {
            return $"Фирма: {Name}, Адрес: {Address}, Год основания: {Year}";
        }

        public bool IsOlder(int year)
        {
            return Year < year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firm firm = new Firm("Пример Фирма", "г. Москва, ул. Примерная, д. 1", 2000);

            Console.WriteLine(firm.GetInfo());

            bool isOlder = firm.IsOlder(2010);
            Console.WriteLine($"Фирма старше 2010 года: {isOlder}");

            Console.ReadKey();
        }
    }
}