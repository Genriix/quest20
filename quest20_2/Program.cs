using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest20_2
{
    class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return System.String.Format(Name, Year);
        }
    }
    class CarCollection<T> where T : Car, new()
    {
        List<T> Cars = new List<T>();

        public void Add(string Name, int Year)
        {
            Cars.Add(new T() { Name = Name, Year = Year });
        }

        public T this[int Index]
        {
            get { return Cars[Index]; }
            set { Cars[Index] = value; }
        }

        public int Count
        {
            get { return Cars.Count; }
        }
        public void Clear()
        {
            Cars.Clear();
            Console.WriteLine("\nКоллекция автопарка отчищена");
        }
    }
    static class Program
    {
        static void Main(string[] args)
        {
            var collection = new CarCollection<Car>();
            collection.Add("Bentley Continental", 2016);
            collection.Add("Ferrari 458", 2015);
            collection.Add("Chevrolet Impala", 1967);

            Console.WriteLine("" +
                "Выберите операцию:\n" +
                "Добавить машину в коллекцию.........[ A ]\n" +
                "Показать все машины в коллекции.....[ S ]\n" +
                "Удалить колеекцию...................[ D ]\n" +
                "Показать длину коллекции............[ C ]\n" +
                "Выйти...............................[Esc]");

            while(true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        {
                            Console.WriteLine("\nВведите название машины");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введит год изготавления");
                            int year = int.Parse(Console.ReadLine());
                            collection.Add(name, year);
                            Console.WriteLine($"Автомобиль {name} {year} года выпуска успешно добавлен в коллекцию");
                            break;
                        }
                    case ConsoleKey.S: 
                        { 
                            Console.WriteLine("\nАвтомобили в коллекции:"); 
                            for (int i = 0; i < collection.Count; i++) Console.WriteLine(collection[i]); 
                            break; 
                        }
                    case ConsoleKey.D: collection.Clear(); break;
                    case ConsoleKey.C: Console.WriteLine("\nРазмер коллекции: " + collection.Count); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
