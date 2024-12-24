
namespace TransportPark
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportPark park = new TransportPark();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Добавить транспортное средство");
                Console.WriteLine("2. Показать все транспортные средства");
                Console.WriteLine("3. Запустить транспорт");
                Console.WriteLine("4. Удалить транспортное средство");
                Console.WriteLine("5. Фильтрация по типу");
                Console.WriteLine("6. Выход");
                Console.Write("Выберите опцию: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddTransport(park);
                        break;
                    case "2":
                        park.ShowAllTransports();
                        Console.ReadKey();
                        break;
                    case "3":
                        StartTransport(park);
                        break;
                    case "4":
                        RemoveTransport(park);
                        break;
                    case "5":
                        FilterTransport(park);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        static void AddTransport(TransportPark park)
        {
            Console.WriteLine("Выберите тип транспорта:");
            Console.WriteLine("1. Автомобиль");
            Console.WriteLine("2. Грузовик");
            Console.WriteLine("3. Мотоцикл");
            Console.WriteLine("4. Автобус");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            Transport transport = null;

            try
            {
                switch (choice)
                {
                    case "1":
                        transport = CreateCar();
                        break;
                    case "2":
                        transport = CreateTruck();
                        break;
                    case "3":
                        transport = CreateBike();
                        break;
                    case "4":
                        transport = CreateBus();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        return;
                }

                park.AddTransport(transport);
                Console.WriteLine("Транспорт добавлен.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода: неверный формат данных.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }

        static Car CreateCar()
        {
            var car = new Car();
            try
            {
                Console.Write("Марка: ");
                car.Brand = Console.ReadLine();
                Console.Write("Модель: ");
                car.Model = Console.ReadLine();
                Console.Write("Год выпуска: ");
                car.Year = int.Parse(Console.ReadLine());
                Console.Write("Максимальная скорость: ");
                car.MaxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Тип топлива (бензин/дизель/электро): ");
                car.FuelType = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число для года и скорости.");
            }
            return car;
        }

        static Truck CreateTruck()
        {
            var truck = new Truck();
            try
            {
                Console.Write("Марка: ");
                truck.Brand = Console.ReadLine();
                Console.Write("Модель: ");
                truck.Model = Console.ReadLine();
                Console.Write("Год выпуска: ");
                truck.Year = int.Parse(Console.ReadLine());
                Console.Write("Максимальная скорость: ");
                truck.MaxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Грузоподъемность (в тоннах): ");
                truck.LoadCapacity = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число для года, скорости и грузоподъемности.");
            }
            return truck;
        }

        static Bike CreateBike()
        {
            var bike = new Bike();
            try
            {
                Console.Write("Марка: ");
                bike.Brand = Console.ReadLine();
                Console.Write("Модель: ");
                bike.Model = Console.ReadLine();
                Console.Write("Год выпуска: ");
                bike.Year = int.Parse(Console.ReadLine());
                Console.Write("Максимальная скорость: ");
                bike.MaxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Есть ли коляска? (true/false): ");
                bike.HasSidecar = bool.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число для года, скорости и корректный формат для коляски.");
            }
            return bike;
        }

        static Bus CreateBus()
        {
            var bus = new Bus();
            try
            {
                Console.Write("Марка: ");
                bus.Brand = Console.ReadLine();
                Console.Write("Модель: ");
                bus.Model = Console.ReadLine();
                Console.Write("Год выпуска: ");
                bus.Year = int.Parse(Console.ReadLine());
                Console.Write("Максимальная скорость: ");
                bus.MaxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Вместимость пассажиров: ");
                bus.PassengerCapacity = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число для года, скорости и вместимости.");
            }
            return bus;
        }

        static void StartTransport(TransportPark park)
        {
            try
            {
                Console.Write("Введите индекс транспорта для запуска: ");
                int index = int.Parse(Console.ReadLine());
                park.StartTransport(index);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректный индекс.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }

        static void RemoveTransport(TransportPark park)
        {
            try
            {
                Console.Write("Введите индекс транспорта для удаления: ");
                int index = int.Parse(Console.ReadLine());
                park.RemoveTransport(index);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректный индекс.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }

        static void FilterTransport(TransportPark park)
        {
            Console.Write("Введите тип транспорта для фильтрации (Автомобиль, Грузовик, Мотоцикл, Автобус): ");
            string type = Console.ReadLine();
            park.FilterByType(type);
            Console.ReadKey();
        }
    }
}
