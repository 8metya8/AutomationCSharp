using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal static class Task1
    {
        /// <summary>
        /// Класс Phone.  
        /// Создайте класс Phone, который содержит переменные number, model и weight.
        /// Создайте три экземпляра этого класса.  
        /// Выведите на консоль значения их переменных.  
        /// Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит { name}”.
        /// getNumber –  возвращает номер телефона.Вызвать эти методы для каждого из  объектов.
        /// Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и  weight.
        /// Добавить конструктор, который принимает на вход два параметра для  инициализации переменных класса - number, model.
        /// Добавить конструктор без параметров.
        /// Вызвать из конструктора с тремя параметрами конструктор с двумя.  Добавьте перегруженный метод receiveCall, 
        /// который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.
        /// Создать метод sendMessage с аргументами переменной длины.Данный метод принимает на вход номера телефонов,
        /// которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.
        /// </summary>
        public static void HWTask1()
        {
            Phone phone = new Phone("+375(29)842-41-33", "Huawei P40", 0.192);
            Phone phone2 = new Phone("+375(29)111-22-33", "iPhone 14", 0.202);
            Phone phone3 = new Phone("+375(29)444-55-66", "Xiaomi Note 12", 0.175);

            Console.WriteLine("Phone number - {0}, model - {1}, weight - {2} kg", phone.Number, phone.Model, phone.Weight);
            Console.WriteLine("Phone number - {0}, model - {1}, weight - {2} kg", phone2.Number, phone2.Model, phone2.Weight);
            Console.WriteLine("Phone number - {0}, model - {1}, weight - {2} kg", phone3.Number, phone3.Model, phone3.Weight);

            phone.receiveCall("Nick");
            Console.WriteLine($"Your phone number - {phone.getNumber()}");
            phone2.receiveCall("Mike");
            Console.WriteLine($"Your phone number - {phone2.getNumber()}");
            phone3.receiveCall("Veronica");
            Console.WriteLine($"Your phone number - {phone3.getNumber()}");

            phone.receiveCall("Den", "+375(00)111-27-56");
            phone.sendMessage(new string[] { "+375(29)111-22-33", "+375(29)444-55-66", "+375(29)404-50-60" }, "Hello my frend!");
        }
    }
}
