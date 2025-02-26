using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_25._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с использованием конструктора по умолчанию
            Software software1 = new Software();
            Console.WriteLine(software1.ToString());

            // Создание объекта с использованием конструктора с параметрами
            Software software2 = new Software("Windows", "Microsoft", true);
            Console.WriteLine(software2.ToString());

            // Ввод данных с консоли и создание объекта
            Console.WriteLine("Введите название ПО:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите производителя:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Платное ли ПО? (true/false):");
            bool isPaid = bool.Parse(Console.ReadLine());

            Software software3 = new Software(name, manufacturer, isPaid);
            Console.WriteLine(software3.ToString());

            // Демонстрация метода TogglePaymentStatus
            Console.WriteLine("\nИзменение статуса оплаты для software3:");
            software3.TogglePaymentStatus();
            Console.WriteLine(software3.ToString());

            // Демонстрация метода IsFreeFromManufacturer
            Console.WriteLine("\nПроверка, является ли ПО бесплатным продуктом заданного производителя:");
            Console.WriteLine("Введите производителя для проверки:");
            string checkManufacturer = Console.ReadLine();
            bool isFree = software3.IsFreeFromManufacturer(checkManufacturer);
            Console.WriteLine($"ПО {software3.Name} от {checkManufacturer} бесплатное: {isFree}");

            // Ожидание ввода пользователя перед закрытием консоли
            Console.ReadLine();
        }
    }
}
