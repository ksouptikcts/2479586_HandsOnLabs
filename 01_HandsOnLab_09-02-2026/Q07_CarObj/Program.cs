
using System;

class Program
{
    static void Main()
    {
        var car1 = new Car("BMW", "X7", 12000000 , 120);  
        var car2 = new Car("Audi", "Q7", 9500000);
        var car3 = new Car("Mercedes-Benz", "GLS", 14000000);
        var car4 = new Car("Lamborghini", "Urus", 35000000);
        var car5 = new Car("Range Rover", "Autobiography", 28000000);

        car1.PrintCar();
        car2.PrintCar();
        car3.PrintCar();
        car4.PrintCar();
        car5.PrintCar();
    }
}
