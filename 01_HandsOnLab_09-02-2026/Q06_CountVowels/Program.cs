class Program
{
    static void Main()
    {
        Console.WriteLine("enter the string: ");
        string input = Console.ReadLine();

        for(int i = 0; i < input.Length(); i++)
        {
            Console.WriteLine(input[i]);
        }
    }
}