class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number you want to check: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n == 0) Console.WriteLine("the number is zero ");
        else if (n > 0) Console.WriteLine("the number is positive");
        else if (n < 0) Console.WriteLine("the number is negative");
    }
}