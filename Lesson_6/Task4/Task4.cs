namespace Lesson_6
{
    /// <summary>
    /// Полную структуру классов и их взаимосвязь продумать самостоятельно. Исходные данные база (массив) из n машин задать непосредственно в коде. 
    /// Создать базовый класс Auto с методами позволяющим вывести на экран информацию о транспортном средстве, 
    /// а также определить грузоподъемность транспортного средства. 
    /// Создать производные классы: Легковая_машина (марка, номер, скорость, грузоподъемность),
    /// Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, при этом если коляска отсутствует, то грузоподъемность равна 0), 
    /// Грузовик (марка, номер, скорость, грузоподъемность, наличие прицепа, при этом если есть прицеп, то грузоподъемность увеличивается в два раза)
    /// со своими методами вывода информации на экран, и определения грузоподъемности. 
    /// Создать базу (массив) из n машин, вывести полную информацию из базы на экран, а также организовать поиск машин, удовлетворяющих требованиям грузоподъемности.
    /// </summary>
    internal class Task4
    {
        public static void HWTask4()
        {
            Console.WriteLine("\n----- Task 4 -----\n");

            Auto[] autos = { new Car("Subaru", "4568-AA", 200, 1.1),
                             new Car("Huyndai", "6542-BB", 180, 2),
                             new Truck("DAF", "1234-CC", 110, 15, true),
                             new Motorcycle("Suzuki", "6585-DD", 200, 0.2, true),
                             new Motorcycle("Honda", "4533-EE", 200, 0.2, false)};

            Console.WriteLine("\n----- Show all autos: -----\n");

            foreach ( Auto auto in autos )
            {
                auto.ShowInfo();
                Console.WriteLine(new String('-', 20));
            }

            Console.WriteLine("\n----- Search auto by Load Capacity: -----\n");
            Console.Write("Enter Load Capacity: ");
            double loadCapacity = Convert.ToDouble( Console.ReadLine() );

            FindCarByLoadCapacity(autos, loadCapacity);

        }

        public static void FindCarByLoadCapacity(Auto[] autos, double loadCapacity)
        {
            bool hasCar = false;

            foreach( Auto auto in autos )
            {
                if( (auto.GetLoadCapacity() > loadCapacity) || (auto.GetLoadCapacity() == loadCapacity) )
                {
                    hasCar = true;
                    Console.WriteLine(new String('-', 20));
                    auto.ShowInfo();
                }
            }

            if ( !hasCar ) { Console.WriteLine("We found NO car :("); }
        }
    }
}
