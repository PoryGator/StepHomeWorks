namespace HomeWorkAutoPark;

public class FleetManagerApp

{
    public abstract class Transport
    {
        public string Make { get; set; }  // марка
        public string Model { get; set; }  // модель
        public int Year { get; set; }  // год выпуска
        public FuelType Fuel { get; set; }  // тип топлива
        public BodyType Body { get; set; }  // тип кузова

        protected Transport(string make, string model, int year, FuelType fuel, BodyType body)
        {
            Make = make;
            Model = model;
            Year = year;
            Fuel = fuel;
            Body = body;
        }

        public virtual void Update(string make = null, string model = null, int? year = null, FuelType? fuel = null, BodyType? body = null)
        {
            if (make != null) Make = make;
            if (model != null) Model = model;
            if (year.HasValue) Year = year.Value;
            if (fuel.HasValue) Fuel = fuel.Value;
            if (body.HasValue) Body = body.Value;
        }

        public override string ToString()
        {
            return $"{Make} {Model} ({Year}), {Fuel}, {Body}";
        }
    }
}
