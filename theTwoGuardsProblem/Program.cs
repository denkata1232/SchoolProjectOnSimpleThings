using System.Text.RegularExpressions;
using AngouriMath;
using AngouriMath.Extensions;
namespace theTwoGuardsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int check = rand.Next(0,2);
            bool guard1 = true;
            bool guard2 = true;
            string door1 = null;
            string door2 = null;
            if (check == 0)
            {
                guard1 = true;
                door1 = "safe";
                guard2 = false;
                door2 = "dager";
            }
            else if (check == 1)
            {
                door2 = "safe";
                guard1 = false;
                door1 = "dager";
                guard2 = true;
            }
            check = rand.Next(0,2);
            string input = Console.ReadLine();
            Entity ex = input;
            Console.Write("which guard or door are you asking:");
            bool fate;
            string choice = Console.ReadLine();
            while (choice != "door1" || choice != "door2")
            {
                if (choice == "guard1")
                {
                    fate = !(ex.EvaluableBoolean^guard1);
                }
                else if(choice == "guard2")
                {
                    fate= !(ex.EvaluableBoolean ^ guard2);
                }
                choice = Console.ReadLine();
            }
            if (choice == "door1")
            {
                Console.WriteLine(door1);
            }
            else if(choice == "door2")
            {
                Console.WriteLine(door2);
            }
        }
    }
}
