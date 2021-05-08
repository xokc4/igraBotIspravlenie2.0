using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraBotIspravlenie2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Здравствуйте, это игра вычитание чисел. \n Вы вводите количество игроков , минимальное и максимальное значение , после которых получается рандомное число. \n Ваша задача состоит в том чтобы дойти до нуля первым , используя только 1, 2, 3, 4");
            Console.WriteLine("введите свой никнейм");
            string userTry = Console.ReadLine();
            string bot = "Bot";// названия бота
            bool f = true;
            Console.WriteLine("введите максимальное и минимальное число для игры ");
            Console.WriteLine("введите минимальное число");
            var Min4islo = int.Parse(Console.ReadLine());// ввод минимального значения
            Console.WriteLine("введите максимальное число");
            var Max4islo = int.Parse(Console.ReadLine());// ввод максимального значения
            Random rand = new Random();
            int gameNumber = rand.Next(Min4islo, Max4islo); // рандомное число
            int Bot4isla = 0;
            //цикл игры
            while (gameNumber > 0)
            {


                if (f)
                {
                    Console.WriteLine("Введите строку:");
                    int igrok4islo;// число игрока
                    string WWod = Console.ReadLine();// ввод числа

                    bool result = int.TryParse(WWod, out igrok4islo);//преобразование из строки в число
                    if (result == true)
                    {

                        if (igrok4islo < 1 || igrok4islo > 4)// проверка числа
                        {
                            Console.WriteLine("вы ввели не правильное число");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("вы ввели не число");
                    }

                }
                else
                {
                    Bot4isla = rand.Next(1, 5); // ход компьютера
                    Console.WriteLine(bot + " походил " + Bot4isla);
                }

                gameNumber -= Bot4isla;
                f = !f;
            }
            Console.WriteLine(0);
            Console.WriteLine("{0} победил!", f ? bot : userTry);
            Console.ReadKey();
        }
    }
}
