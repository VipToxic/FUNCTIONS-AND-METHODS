namespace Scope
{
    internal class Program
    {



        /// <summary>
        /// Метод чтобы конвертировать месяц рождение
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        static string GetMonthName(int month) 
        {
            // Переменная чтобы хранить название месяца
            string nameMonthPerson = "";

            // Массив название месяца
            string[] nameMonth = 
            {
                "Явнарь", "Февраль",
                "Март", "Апрель",
                "Май", "Июнь",
                "Июль", "Август ",
                "Сентябрь", "Октябрь",
                "Ноябрь", "Декабрь",
            };

            // Перебор массива
            for (int i = 0; i < nameMonth.Length; i++)
            {
                if ((i + 1) == month)
                {
                    nameMonthPerson = nameMonth[i];
                    break;
                }
            }
            // Возврашаем полученую название
            return nameMonthPerson;

        }

        /// <summary>
        /// Метод приветсвует пользователя
        /// </summary>
        /// <param name="hello"></param>
        /// <param name="name"></param>
        static void SayHello(string name = "Пользователь", int year = 0, int month = 0, int day = 0)
        {
            // Тут мы храним текущую дату
            DateTime today = DateTime.Today;
            int age = 0;

            // string.IsNullOrWhiteSpace(name) Оно проверяет не является ли name == null (или же пробел)
            // Если да то к нему присваиваться значение Пользователь
            if (string.IsNullOrWhiteSpace(name)) { name = "Пользователь"; }

            // Проверяем не равенн ли данные к 0
            if (year == 0 || month == 0 || day == 0)
            {
                // Если да то просто выводим сообщение об неизвестии возраста
                Console.WriteLine("День рождение не известен...");
            }
            // В противном случае считаем возраст
            else
            {
               age = today.Year - year; 

                if (today.Month < month || today.Month == month && today.Day < day)
                {
                    age--;
                }
            }

            Console.WriteLine($"Привет {name}!");
            Console.WriteLine($"Дата рождение: {day} числа {GetMonthName(month)} {year} года...");
            Console.WriteLine($"Возраст {name}: {age}");
        }
        static void Main(string[] args)
        {
           

            try
            {
                // Получаем данные
                Console.Write("Напиши имя: ");
                string name = Console.ReadLine();

                Console.WriteLine("Напиши дату рождение: ");
                Console.Write("Год рождение: ");

                int year = int.Parse(Console.ReadLine());
                Console.Write("Месяц: ");

                int month = int.Parse(Console.ReadLine());
                Console.Write("День: ");

                int day = int.Parse(Console.ReadLine());

                SayHello(name, year, month, day);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}