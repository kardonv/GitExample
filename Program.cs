namespace GitExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
