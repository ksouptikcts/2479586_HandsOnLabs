class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter the number you want to check: ");

        int num = Console.ReadLine();
        n = int.Parse(num);

        if (n == 0) Console.WriteLine("the number is zero ");
        else if (n > 0) Console.WriteLine("the number is positive");
        else if (n < 0) Console.WriteLine("the number is negative");

    }
}