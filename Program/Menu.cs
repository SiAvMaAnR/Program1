using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShips;

namespace Program1
{
    class Menu
    {
        static List<Ship> ships = new List<Ship>();

        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" * 1: Просмотр кораблей");
                Console.WriteLine(" * 2: Добавление корабль");
                Console.WriteLine(" * 3: Поиск по кораблям");
                Console.WriteLine(" * 4: Выход");
                Console.Write("Введите номер: ");
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1': PrintShips(); break;
                    case '2': AddShips(); break;
                    case '3': SearchShips(); break;
                    case '4': Environment.Exit(0); break;
                    default: break;
                }
            }
        }

        public static void PrintShips()
        {
            Console.Clear();
            foreach (var item in ships)
            {
                Console.WriteLine(item.PrintToString());
            }
            Console.ReadKey(true);
        }

        public static void AddShips()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите вариант (тип Судна)");
                Console.WriteLine("1. Пароход");
                Console.WriteLine("2. Парусник");
                Console.WriteLine("3. Корвет");
                choice = Console.ReadKey(true).KeyChar;
            }
            while (choice!='1'&&choice!='2'&&choice!='3');

            switch (choice)
            {
                case '1'://Steamer()
                    {
                        string name = "";
                        int weight;
                        int maxSpeed;
                        int massOfCoal;
                        int rangeOfTravel;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите название: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите массу: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out weight) || weight < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите макс. скорость: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out maxSpeed) || maxSpeed < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите массу угля: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out massOfCoal) || massOfCoal < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите дальность хода: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out rangeOfTravel) || rangeOfTravel < 0);

                        ships.Add(new Steamer(name, weight, maxSpeed, massOfCoal, rangeOfTravel)); break;
                    }
                case '2'://Sailboat()
                    {
                        string name = "";
                        int weight;
                        int maxSpeed;
                        string sailMaterial;
                        int sailArea;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите название: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите массу: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out weight) || weight < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите макс. скорость: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out maxSpeed) || maxSpeed < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите материал паруса: ");
                            sailMaterial = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(sailMaterial));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите площадь паруса: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out sailArea) || sailArea < 0);
                        ships.Add(new Sailboat(name,weight,maxSpeed,sailMaterial,sailArea)); break;
                    }
                case '3'://Corvette()
                    {
                        string name = "";
                        int weight;
                        int maxSpeed;
                        string armament;
                        string equipment;

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите название: ");
                            name = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите массу: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out weight) || weight < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите макс. скорость: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out maxSpeed) || maxSpeed < 0);

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите вооружение: ");
                            armament = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(armament));

                        do
                        {
                            Console.Clear();
                            Console.Write("Введите оборудование: ");
                            equipment = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(equipment));

                        ships.Add(new Corvette(name, weight, maxSpeed, armament, equipment)); break;
                    }
                default: throw new Exception("Фиаско");
            }
        }

        public static void SearchShips()
        {
            Console.Clear();
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            foreach (var item in ships)
            {
                if (item.IsSearchContains(searchText))
                {
                    Console.WriteLine(item.PrintToString());
                }
            }
            Console.ReadKey(true);
        }
    }
}
