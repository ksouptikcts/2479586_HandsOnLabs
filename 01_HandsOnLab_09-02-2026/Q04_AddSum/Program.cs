class Program
{
    static void Main()
    {
        int a, b, sum = 0;
        Console.WriteLine("enter the both numbers: ");
        Console.WriteLine("enter a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter b: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine(Add(a , b));
    }
    
    static int Add(int a, int b)
    {
        return a+b;
    }
}