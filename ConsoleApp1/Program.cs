namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            x = Convert.ToInt32(Console.ReadLine());

            if (x < 0) y = x * x;

            else

            {

                y = 5;

                y += 2 * x;

            }

            Console.WriteLine(y);

        }
    }
}
