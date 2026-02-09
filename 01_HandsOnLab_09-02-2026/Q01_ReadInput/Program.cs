//

class Program
{
    static void Main()
    {
        string name;
        int age;
        double salary;

        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your salary: ");
        salary = double.Parse(Console.ReadLine());

        Console.WriteLine($" the name is: {name} , the age is: {age}, the salary is: {salary}");
    }
}