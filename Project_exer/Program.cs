namespace LoginCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string passowrd = Console.ReadLine();
            if (name == "Admin" && passowrd == "PaSsCodE")
            {
                Console.WriteLine("Welcome");
            }
            Console.WriteLine("Go home hacker!");
        }
    }
}
