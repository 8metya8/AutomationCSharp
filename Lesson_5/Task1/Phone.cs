namespace Lesson_5
{
    /// <summary>
    /// Класс Phone.  
    /// Создайте класс Phone, который содержит переменные number, model и weight.
    /// Создайте три экземпляра этого класса.  
    /// Выведите на консоль значения их переменных.  
    /// Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит { name}”. getNumber –  возвращает номер телефона.Вызвать эти методы для каждого из  объектов.
    /// Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и  weight.
    /// Добавить конструктор, который принимает на вход два параметра для  инициализации переменных класса - number, model.
    /// Добавить конструктор без параметров.
    /// Вызвать из конструктора с тремя параметрами конструктор с двумя.  
    /// Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот  метод.
    /// Создать метод sendMessage с аргументами переменной длины.Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.
    /// </summary>
    internal class Phone
    {
        public string Number { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public Phone(string number, string model, double weigh) : this(number, model)
        {
            Number = number;
            Model = model;
            Weight = weigh;
        }

        public Phone(string number, string model)
        {
            Number = number;
            Model = model;
        }

        public Phone()
        {
        }

        public void receiveCall(string name)
        {
            Console.WriteLine($"Call {name}.");
        }

        public void receiveCall(string name, string number)
        {
            Console.WriteLine($"Call {name} - {number}.");
        }

        public string getNumber()
        {
            return Number;
        }

        public void sendMessage(string[] phoneNumbers, string message)
        {
            foreach(var number in phoneNumbers)
            {
                Console.WriteLine($"You sent message to {number}. Message - {message}");
            }
        }
    }
}
