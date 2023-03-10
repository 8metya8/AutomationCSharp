namespace Lesson_6
{
    /// <summary>
    /// Автопарк
    /// Создать класс, cо следующими свойствами: сlass Bus: Пункт назначения, Номер, Время отправления, Число мест. Определить get, set методы для этих свойств.
    /// Создать класс с main методом, в котором будет объявлен объект класса Bus.Вывести все данные (значения полей) объекта в консоль.
    /// Определить иерархию классов в предметной области: Парк общественного траспорта.
    /// Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д.на подобие класса Bus выше.) 
    /// Определить в суперклассе(например, сlass Transport) метод, возвращающий тип транспорта(Electric, Rail, и т.п.). Переопределить этот метод в классах наследниках.
    /// В классе с main методом создать массив объектов из различных видов транспорта.Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль. 
    /// Запросить у пользователя время отправления и/или пункт назначения.Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль. 
    /// Запросить у пользователя время отправления.Вывести в консоль список транспорта, отправляющегося после заданного времени.
    /// ** Выбрать метод в супеклассе (e.g.Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение. 
    /// ** Создать класс TransportService. Определить внутри класса TransportService метод printTransportType, который будет принимать объект типа Transport как параметр. 
    /// Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль. 
    /// ** В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)
    /// </summary>
    internal static class Task3
    {
        public static void HWTask3()
        {
            Console.WriteLine("\n----- Task 3 -----\n");

            PublicTransport[] publicTransports = { new Bus(52, "55a", "Warsaw", new DateTime().AddHours(15).AddMinutes(45), EngineTypeOfTransport.ICE),
                                                   new Bus(33, "155", "Berlin", new DateTime().AddHours(8), EngineTypeOfTransport.Hybrid),
                                                   new Tram(45, "6", "Minsk", new DateTime().AddHours(19).AddMinutes(35), EngineTypeOfTransport.Electric),
                                                   new Trolleybus(40, "33", "Brest", new DateTime().AddHours(18).AddMinutes(30), EngineTypeOfTransport.Electric)};

            PublicTransport.Sort(publicTransports);

            foreach (var transport in publicTransports)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"This is {transport.GetTransportType()}, engine - {transport.GetEngineType()}");
                Console.WriteLine($"Number - {transport.Number} \nDestination - {transport.DestinationStation} \nDepartue time - {transport.DepartureTime.ToShortTimeString()} \nCount of sits - {transport.CountOfSeats}");
            }

            Console.WriteLine("--------------------------------");
            foreach (var transport in publicTransports)
            {
                TransportService.PrintTransportType(transport);
            }

            Console.WriteLine("------------- Search by Time and/or Destination -------------------");
            Console.Write("\nEnter Departure Time (format HH:mm) or press Enter: ");
            string time = Console.ReadLine().Trim();            

            Console.Write("\nEnter destination or press Enter: ");
            string destination = Console.ReadLine().Trim().ToUpper();

            IList<PublicTransport> findedPublicTransports = new List<PublicTransport>();
            DateTime searchTime;

            if (string.IsNullOrEmpty(destination))
            {
                if(!string.IsNullOrEmpty(time))
                {
                    searchTime = new DateTime().AddHours(Convert.ToInt16(time.Split(':')[0])).AddMinutes(Convert.ToInt16(time.Split(':')[1]));
                    findedPublicTransports = PublicTransport.SearchByTime(publicTransports, searchTime);
                }               
            }
            else if (string.IsNullOrEmpty(time))
            {
                if (!string.IsNullOrEmpty(destination))
                {
                    findedPublicTransports = PublicTransport.SearchByDestination(publicTransports, destination);
                }
            }
            else
            {
                searchTime = new DateTime().AddHours(Convert.ToInt16(time.Split(':')[0])).AddMinutes(Convert.ToInt16(time.Split(':')[1]));
                findedPublicTransports = PublicTransport.SearchByTimeAndDestination(publicTransports, searchTime, destination);
            }

            ShowVariants(findedPublicTransports);

            Console.WriteLine("-------------- Search after Time ------------------");
            Console.Write("\nEnter time (format HH:mm): ");
            time = Console.ReadLine();
            searchTime = new DateTime().AddHours(Convert.ToInt16(time.Split(':')[0])).AddMinutes(Convert.ToInt16(time.Split(':')[1]));
            
            findedPublicTransports = PublicTransport.SearchAfterTime(publicTransports, searchTime);

            ShowVariants(findedPublicTransports);

        }

        public static void ShowVariants(IList<PublicTransport> findedPublicTransports)
        {
            if (findedPublicTransports.Count != 0)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("We found follow variants:");
                foreach (var transport in findedPublicTransports)
                {
                    Console.WriteLine($"Number - {transport.Number} \nDestination - {transport.DestinationStation} \nDepartue time - {transport.DepartureTime.ToShortTimeString()} \nCount of sits - {transport.CountOfSeats}");
                    Console.WriteLine("--------------------------------");
                }
            }
            else
            {
                Console.WriteLine("We found no variants.");
            }
        }
    }
}
