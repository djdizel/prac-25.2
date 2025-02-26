using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_25._2
{
    internal class Software
    {
        // Поля
        private string name;
        private string manufacturer;
        private bool isPaid;

        // Свойства с методами доступа get и set
        public string Name
        {
            get { return (name != "") ? name : "неизвестно"; }
            set => name = value;
        }

        public string Manufacturer
        {
            get { return (manufacturer != "") ? manufacturer : "неизвестно"; }
            set => manufacturer = value;
        }

        public bool IsPaid
        {
            get => isPaid;
            set => isPaid = value;
        }

        // Конструктор по умолчанию
        public Software()
        {
            Name = "неизвестно";
            Manufacturer = "неизвестно";
            IsPaid = false;
        }

        // Конструктор с параметрами
        public Software(string name, string manufacturer, bool isPaid)
        {
            Name = name;
            Manufacturer = manufacturer;
            IsPaid = isPaid;
        }

        // Метод для изменения поля платное/бесплатное на противоположное
        public void TogglePaymentStatus()
        {
            IsPaid = !IsPaid;
        }

        // Метод для проверки, является ли ПО бесплатным продуктом заданного производителя
        public bool IsFreeFromManufacturer(string manufacturer)
        {
            return Manufacturer == manufacturer && !IsPaid;
        }

        // Метод для вывода значений всех полей
        public override string ToString()
        {
            return $"Название: {Name}, Производитель: {Manufacturer}, Платное: {(IsPaid ? "Да" : "Нет")}";
        }
    }
}

