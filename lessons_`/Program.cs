namespace lessons__
{

    //1) Написать метод который выводит на экран строку.
    //   Символы из которых состоит строка и их количество вводятся пользователем.

    //2) Написать метод для поиска индекса элемента массива (тип элементов в массиве -int)
    //   метод должен вернуть индекс первого найденного элемента (если он будет найден)



    internal class Program
    {

        // Задание 1:
        static void Simvol(int kolvo, string sim)
        {
            string sim2 = "";

            for (int i = 0; i < kolvo; i++)
            {
                sim2 += sim;
            }

            Console.WriteLine(sim2);
        }

        // Задание 2:

        static int ArrayIndex(int[] array, int number)
        {

            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    index = i;
                    break;
                }
                
            }

            return index;
        }

        static void Main(string[] args)
        {
            // Задание 1: Вызов метода
            Console.Write("Введите количиство символов: ");
            int kol = int.Parse(Console.ReadLine());

            Console.Write("Введите символ: ");
            string sim = Console.ReadLine();

            Simvol(kol, sim);

            // Задание 2: Вызов

            int[] array = new int[100];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }



            Console.WriteLine("Напишет цифру с 1 до 100 для поиска его индекса");
            Console.Write("Напоминаем все числа рандомны и находяться на рандомном месте: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Индекс вашего числа: " + ArrayIndex(array, number));
        }
    }

}
