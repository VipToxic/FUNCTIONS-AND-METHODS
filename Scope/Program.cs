namespace Scope
{
    internal class Program
    {

        

        // Стек и куча
        // ссылочные и значимые типы данных


        // Параметры

        static void Main(string[] args)
        {

            SayHello();

            void SayHello()
            {
                Console.WriteLine("Hello");
            }

            SayHello();


            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            PrintMessage("Привет");

        }
    }
}