class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int max = int.MinValue;

        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"enter the number of the : {i+1}");
            int num = int.Parse(Console.ReadLine());
            if(num >= max) max = num;
            numbers[i] = num;
        }

        // printing the array as a list
        Console.WriteLine(String.Join(", " , numbers));
        // Console.WriteLine(numbers.Max());
        Console.WriteLine(max);

    }
}