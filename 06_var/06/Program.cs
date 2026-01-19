namespace _06;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
        for (int i = 0; i < lines.Length; i++)
        {Console.WriteLine(lines[i]);}
    }
}
