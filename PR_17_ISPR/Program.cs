using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_17_ISPR
{
    class Utensil
    {
        public string name;
        public string name2;
        public string material;
        public string material2;
        public int quantity;
        public int quantity2;

        void GetInfo() // вычисление
        {

            if (quantity > quantity2)
            {
                int calculation1 = quantity - quantity2;
                Console.WriteLine(name + " больше " + name2 + " на " + calculation1 + " шт.");
            }
            else
            {
                int calculation2 = quantity2 - quantity;
                Console.WriteLine(name2 + " больше " + name + " на " + calculation2 + " шт.");
            }
        }
        public void SetInfo() // ввод данных
        {
            Console.WriteLine("\nВведите данные о посуде:\n");
            Console.WriteLine("Введите название 1-ой посуды:");
            name = Console.ReadLine();

            Console.WriteLine("Введите материал 1-ой посуды:");
            material = Console.ReadLine();

            Console.WriteLine("Введите название 2-ой посуды:");
            name2 = Console.ReadLine();

            Console.WriteLine("Введите материал 2-ой посуды:");
            material2 = Console.ReadLine();

            Console.WriteLine("Введите количество " + name);
            quantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество " + name2);
            quantity2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\nДанные о посуде:"); // Дальше вывод с данным table_info
            Console.WriteLine("\n-----");
            Console.WriteLine("Вы используете посуду '" + name + "' состоящей из '" + material + "' и '" + name2 + "' состоящей из '" + material2 + "'.");
            Console.WriteLine("-----\n");
            Console.WriteLine("-----");
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Материал: " + material);
            Console.WriteLine("Общее кол-во:" + quantity);
            Console.WriteLine("\nНазвание: " + name2);
            Console.WriteLine("Материал: " + material2);
            Console.WriteLine("Общее кол-во:" + quantity2);
            Console.WriteLine("-----");

            Console.WriteLine("\nРабота с посудой:");

            GetInfo();
        }

        ~Utensil() // деструктор для проверки*
        {
            Console.WriteLine("\nДеструктор сработал.");
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // ввод значения для продолжения цикла
            do
            {
                Console.Clear();

                Utensil utensil = new Utensil();
                Console.WriteLine("\nПрактическая работа №17");
                utensil.SetInfo(); // переход к вводу данных
                Console.WriteLine("\nНажмите 1, чтобы завершить работу, или 2, чтобы продолжить.\n");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x == 2);
            Console.WriteLine("\nЗавершение работы. Спасибо, что использовали эту программу.");
            Console.ReadKey(); // задержка экрана консоли
        }
    }
}