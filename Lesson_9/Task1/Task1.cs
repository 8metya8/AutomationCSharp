namespace Lesson_9
{
    internal class Task1
    {
        /// <summary>
        /// Полную структуру классов и их взаимосвязь продумать самостоятельно. Исходные данные база (List) из n товаров задать непосредственно в коде (захардкодить).
        ///Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить, соответствует ли она сроку годности на текущую дату.
        ///Создать производные классы:
        ////Продукт(название, цена, дата производства, срок годности),
        ///Партия(название, цена, количество шт, дата производства, срок годности), 
        ///Комплект(названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.
        ///Создать базу(List) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск просроченного товара(на момент текущей даты).
        ///Submission status
        /// </summary>
        public static void HWTask1()
        {
            Console.WriteLine("\n----- Task 1 -----");

            Product beans = new Product("Beans", new DateTime(2022, 11, 25), 12, 1.5);
            Product beacon = new Product("Beacon", new DateTime(2023, 02, 25), 2, 3.5);
            Product cola = new Product("Cola", new DateTime(2022, 10, 15), 12, 1.1);
            Product bread = new Product("Bread", new DateTime(2023, 03, 20), 1, 0.5);
            Product olives = new Product("Olives", new DateTime(2022, 09, 25), 6, 0.8);
            Product apple = new Product("Apple", new DateTime(2022, 05, 25), 6, 0.2);
            Product carrot = new Product("Carrot", new DateTime(2022, 09, 25), 4, 0.3);


            BatchOfProduct batchOfBeans = new BatchOfProduct("202211-B-QWERTY", beans, 120);
            BatchOfProduct batchOfCola = new BatchOfProduct("202210-C-ASDFG", cola, 60);

            List<Product> products = new List<Product>();
            products.Add(beans);
            products.Add(beacon);
            products.Add(bread);
            products.Add(olives);
            products.Add(cola);

            Package packageOfProducts = new Package("For Mr. Tern", products);

            beans.ShowInfo();
            batchOfBeans.ShowInfo();
            packageOfProducts.ShowInfo();
            Console.WriteLine($"Are all the products not expired? - {packageOfProducts.ExpirationСheck()}");

            List<Product> productsForChecking = new List<Product>();
            productsForChecking.Add(beans);
            productsForChecking.Add(beacon);
            productsForChecking.Add(apple);
            productsForChecking.Add(bread);
            productsForChecking.Add(olives);
            productsForChecking.Add(cola);
            productsForChecking.Add(carrot);


            Console.WriteLine("\n----- Checking of shelf life -----");
            List<Product> expiredProducts = new List<Product>();
            foreach(Product product in productsForChecking)
            {
                if (product.DateOfManufacture.AddMonths(product.ShelfLife) < DateTime.Now)
                {
                    expiredProducts.Add(product);
                    Console.WriteLine($"{product.Name} is expired.");    
                }
            }
        }

        /// <summary>
        /// Задание 1.1
        ///а) Создать List, содержащий объекты класса Product
        ///б) Распечатать его содержимое используя foreach. 
        ///в) Изменить цену одного продукта на 100. 
        ///г) Удалить последний продукт.
        ///д) Распечатать его содержимое
        ///ж) Удалить все продукты.
        /// </summary>
        public static void HWTask1_1()
        {
            Console.WriteLine("\n----- Task 1_1 -----");

            //а) Создать List, содержащий объекты класса Product
            List<Product> products = GetListOfProducts();

            //б) Распечатать его содержимое используя foreach.
            Console.WriteLine("List of products:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.Name);
            }

            //в) Изменить цену одного продукта на 100.
            products[2].Price += 100;

            //г) Удалить последний продукт.
            products.RemoveAt(products.Count - 1);

            //д) Распечатать его содержимое
            for(int i = 0; i < products.Count; i++)
            {
                products[i].ShowInfo();
            }

            //ж) Удалить все продукты.
            products.Clear();
        }

        /// <summary>
        /// Cоздать коллекцию, содержащую объекты Product. Написать метод, который перебирает элементы коллекции и проверяет цену продуктов. 
        /// Если цена продукта больше 300 рублей, продукт перемещается в другую коллекцию.
        /// </summary>
        public static void HWTask1_2()
        {
            Console.WriteLine("\n----- Task 1_2 -----");

            IList<Product> products = GetListOfProducts();
            IList<Product> expensiveProducts = MoveProductToNewList(products);
        }
        
        public static IList<Product> MoveProductToNewList(IList<Product> products)
        {
            IList<Product> newProducts = new List<Product>();

            foreach (Product product in products)
            {
                if (product.Price > 300)
                {
                    newProducts.Add(product);
                }
            }

            foreach (Product product in newProducts)
            {
                products.Remove(product);
            }

            return newProducts;
        }

        /// <summary>
        /// Создайте Dictionary, содержащий пары значений  - имя продукта и количестов единиц продукта (класс Product).
        ///Перебрать и распечатать пары значений в формате "Name = abc, Count = 5"
        ///Перебрать и распечатать набор из имен продуктов
        ///Перебрать и распечатать значения количества единиц продуктов.
        //Для каждого перебора создать свой метод.
        ///На основе задания 3 необходимо написать преобразование
        ///Dictionary в List.
        ///List в Dictionary.
        /// </summary>
        public static void HWTask1_3()
        {
            Console.WriteLine("\n----- Task 1_3 -----");

            // Создайте Dictionary, содержащий пары значений  - имя продукта и количестов единиц продукта (класс Product).
            IList<Product> _products = GetListOfProducts();
            Dictionary<Product, int> products = new Dictionary<Product, int>();

            foreach (Product product in _products)
            {
                products.Add(product, new Random().Next(0, 10));
            }

            //Перебрать и распечатать пары значений в формате "Name = abc, Count = 5"
            ShowKeyValue(products);

            //Перебрать и распечатать набор из имен продуктов
            ShowKey(products);

            //Перебрать и распечатать значения количества единиц продуктов.
            ShowValue(products);

            //На основе задания 3 необходимо написать преобразование
            //Dictionary в List.
            List<KeyValuePair<Product, int>> list = products.ToList();

            foreach(KeyValuePair<Product, int> keyValue in list)
            {
                Console.WriteLine($"Name - {keyValue.Key.Name}, Count = {keyValue.Value}");
            }

            //List в Dictionary.
            Dictionary<Product, int> dictionary = new Dictionary<Product, int>();
            foreach(KeyValuePair<Product, int> keyValue in list)
            {
                dictionary.Add(keyValue.Key, keyValue.Value);
            }
        }

        public static void ShowKeyValue(Dictionary<Product, int> products)
        {
            Console.WriteLine(new string('-', 20));
            foreach (var product in products)
            {
                Console.WriteLine($"Name - {product.Key.Name}, Count = {product.Value}");
            }
        }

        public static void ShowKey(Dictionary<Product, int> products)
        {
            Console.WriteLine(new string('-', 20));
            foreach (var product in products)
            {
                Console.WriteLine(product.Key.Name);
            }
        }

        public static void ShowValue(Dictionary<Product, int> products)
        {
            Console.WriteLine(new string('-', 20));
            foreach (var product in products)
            {
                Console.WriteLine(product.Value);
            }
        }

        public static List<Product> GetListOfProducts()
        {
            Product beans = new Product("Beans", new DateTime(2022, 11, 25), 12, 150);
            Product beacon = new Product("Beacon", new DateTime(2023, 02, 25), 2, 350);
            Product cola = new Product("Cola", new DateTime(2022, 10, 15), 12, 110);
            Product bread = new Product("Bread", new DateTime(2023, 03, 20), 1, 450);
            Product olives = new Product("Olives", new DateTime(2022, 09, 25), 6, 80);

            List<Product> products = new List<Product>();
            products.Add(beans);
            products.Add(beacon);
            products.Add(bread);
            products.Add(olives);
            products.Add(cola);

            return products;
        }
    }
}
