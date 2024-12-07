namespace ConsoleApp110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double age =Convert.ToDouble (Console.ReadLine());
            if (age<18)
            {
                Console.WriteLine("You Are Not Eligible To Vote");

            }
            else
            {
                Console.WriteLine("You Are Eligible To Vote");

            }
        }
    }
}