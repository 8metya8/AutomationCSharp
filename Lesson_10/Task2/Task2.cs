namespace Lesson_10
{
    /// <summary>
    /// Реализовать класс машина у который будет поле  обобщенное двигатель. 
    /// Создать иерархию наследования для двигателей(абстрактный, дизельный, бензиновый, електро). 
    /// Сделать так чтобы создать автомобиль можно было только передавая туда один из типов двигателя.
    /// Реализовать методы для движения автомобиля и заправки в зависимости от типа двигателя.
    /// </summary>
    internal class Task2
    {
        public static void HWTask2()
        {
            Console.WriteLine("----- Task 2 - Car -----");

            Car<ElectricEngine> electricCar = new Car<ElectricEngine>(new ElectricEngine("EL-1231-ER5"), 400);
            Car<DieselEngine> dieselCar = new Car<DieselEngine>(new DieselEngine("DIS-4141-E5"), 600);
            Car<GasoilEngine> gasoilCar = new Car<GasoilEngine>(new GasoilEngine("GAS-1001-E6"), 500);

            electricCar.GasUp();
            dieselCar.GasUp();
            gasoilCar.GasUp();

            electricCar.Move(100);
            dieselCar.Move(150);
            gasoilCar.Move(50);
        }
    }
}
