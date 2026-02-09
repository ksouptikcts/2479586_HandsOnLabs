class Program
{
    static void Main()
    {
        int a = 10;
        int b = 0;

        try
        {
            int result = a/b;
            Console.WriteLine("the result is : "+result);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("any number can not be divided by zero ");
        }
    }
}