
namespace TransportPark
{
    public abstract class Transport
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Тип: {Type}, Марка: {Brand}, Модель: {Model}, Год выпуска: {Year}, Макс. скорость: {MaxSpeed} км/ч");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Type} {Brand} {Model} начинает движение.");
        }
    }

    public class Car : Transport
    {
        public string FuelType { get; set; }

        public Car()
        {
            Type = "Автомобиль";
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Тип топлива: {FuelType}");
        }

        public override void Move()
        {
            Console.WriteLine($"Автомобиль {Brand} {Model} едет по дороге со скоростью до {MaxSpeed} км/ч.");
        }

        public double CalculateFuelConsumption(double distance)
        {
            if (FuelType == "бензин")
                return distance * 8 / 100; 
            else if (FuelType == "дизель")
                return distance * 7 / 100; 
            else
                return 0;
        }
    }


    public class Truck : Transport
    {
        public double LoadCapacity { get; set; }

        public Truck()
        {
            Type = "Грузовик";
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Грузоподъемность: {LoadCapacity} тонн");
        }

        public override void Move()
        {
            Console.WriteLine($"Грузовик {Brand} {Model} перевозит груз.");
        }

        public bool CanLoad(double weight)
        {
            return weight <= LoadCapacity;
        }
    }

    public class Bike : Transport
    {
        public bool HasSidecar { get; set; }

        public Bike()
        {
            Type = "Мотоцикл";
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Есть коляска: {HasSidecar}");
        }

        public override void Move()
        {
            Console.WriteLine($"Мотоцикл {Brand} {Model} мчится по дороге.");
        }
    }

    public class Bus : Transport
    {
        public int PassengerCapacity { get; set; }

        public Bus()
        {
            Type = "Автобус";
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Вместимость пассажиров: {PassengerCapacity}");
        }

        public override void Move()
        {
            Console.WriteLine($"Автобус {Brand} {Model} перевозит пассажиров.");
        }

        public double CalculateRevenue(double ticketPrice)
        {
            return PassengerCapacity * ticketPrice;
        }
    }
}
