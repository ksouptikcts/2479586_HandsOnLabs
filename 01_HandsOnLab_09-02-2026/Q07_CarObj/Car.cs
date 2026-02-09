    
    public class Car
    {
        public string Brand { get; set;}
        public string Model { get; set;}
        public int Price { get; set;}

        public int Milage { get; set;}

        public Car( string brand, string model, int price, int milage=0)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Milage = milage;
        }

        public void PrintCar()
        {
            Console.WriteLine($"brand: {Brand}, model: {Model}, price: {Price}, milage: {Milage}");
        }
    }