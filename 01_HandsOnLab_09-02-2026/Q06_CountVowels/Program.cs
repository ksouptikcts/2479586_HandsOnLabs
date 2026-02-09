class Program
{
    static void Main()
    {
        Console.WriteLine("enter the string: ");
        string input = Console.ReadLine();
        int num = 0;

        for(int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i]);
            if("aeiouAEIOU".Contains(input[i])) num++;
        }

        Console.WriteLine(num);
    }
}