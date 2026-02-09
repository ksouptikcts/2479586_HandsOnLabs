using System.IO;
class Program
{
    static void Main()
    {
        String input = "hello my name is souptik";
        InputText(input);

        Console.WriteLine(OutputText("sample.txt"));
    }

    public static void InputText(string input)
    {
        File.WriteAllText("sample.txt" , input);
    }

    public static string OutputText(string fileName)
    {
        string output = File.ReadAllText(fileName);
        return output;
    }
}