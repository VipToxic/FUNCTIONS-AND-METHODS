namespace peregryzka
{
    internal class Program
    {
        /// <summary>
        /// Умнажает две целые числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Umnojenie(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Умнажает три целые числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Umnojenie(int a, int b, int c)
        {
            return a * b * c;
        }

        /// <summary>
        /// Умнажает две дробных числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Umnojenie(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Умнажает три дробных числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double Umnojenie(double a, double b, double c)
        {
            return a * b * c;
        }
       

        static void Main(string[] args)
        {

            Console.WriteLine(Umnojenie(4, 7));

            Console.WriteLine(Umnojenie(4, 7, 9));

            Console.WriteLine(Umnojenie(4.5, 7.3));

            Console.WriteLine(Umnojenie(4.3, 3.7, 7.8));

    

        }
    }
}
