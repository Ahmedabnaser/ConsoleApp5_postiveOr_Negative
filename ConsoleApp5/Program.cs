namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter a number ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine($"the number {num} is Postive");
            else
                Console.WriteLine($"the number {num} is Negative");

        }
    }
}
