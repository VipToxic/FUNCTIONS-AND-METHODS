namespace FUNCTIONS_AND_METHODS
{
    internal class Program
    {


        static int Slojenie(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = Slojenie(a, b);
            Console.WriteLine("Результат: " + result);

            Console.WriteLine();

            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int result2 = Slojenie(a2, b2);
            Console.WriteLine("Результат: " + result2);

            Console.WriteLine();

            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int result3 = Slojenie(a3, b3);
            Console.WriteLine("Результат: " + result3);
        }
    }
}
