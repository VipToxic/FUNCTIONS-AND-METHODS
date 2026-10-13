namespace Scope
{
    internal class Program
    {

        /// <summary>
        /// Метод приветсвует пользователя
        /// </summary>
        /// <param name="hello"></param>
        /// <param name="name"></param>
        static void SayHello(string hello = "Привет", string name = "Человек")
        {

            // string.IsNullOrWhiteSpace(name) Оно проверяет не является ли name == null
            // Если да то к нему присваиваться значение Пользователь
            if (string.IsNullOrWhiteSpace(name)) { name = "Пользователь"; }

            if (string.IsNullOrWhiteSpace(hello)) { hello = "Привет"; }

            Console.WriteLine(hello + " " + name + "...");
        }
        static void Main(string[] args)
        {
           

            try
            {
                Console.Write("Напиши имя: ");
                string name = Console.ReadLine();
                Console.Write("Напиши Приветствие: ");
                string hello1 = Console.ReadLine();

                SayHello(hello1, name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex);
            }
            

          
        }
    }
}