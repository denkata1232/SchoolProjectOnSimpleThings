namespace numberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 101);
            int guess = int.Parse(Console.ReadLine());
            while (num != guess)
            {
                if (num < guess)
                    Console.WriteLine("lower");
                else if (num > guess)
                    Console.WriteLine("higher");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Congrats! The number was {guess}.");
        }
    }
}
