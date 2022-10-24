using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs
{
    internal class lab003 : ILabs
    { 
        public void Demo()
        {
            // Task 1
            //while 
            int num = 0; 
            int chisl;
            while (num <= 100)
            {
                num++;
                chisl = num % 12;
                if (chisl == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine();
            //do while
            int num2 = 0;
            int chislSecond;
            do
            {
                num2++;
                chislSecond = num2 % 12;
                if (chislSecond == 0)
                {
                    Console.WriteLine(num2);
                }
            }
            while (num2 <= 100);
            Console.WriteLine();
            //for
            int num3;
            int chislThird;
            for (num3 = 0; num3 <= 100; num3++)
            {
                chislThird = num3 % 12;
                if (chislThird == 0 && num3 != 0)
                {
                    Console.WriteLine(num3);
                }
            }
            Console.WriteLine();
            // Task 2
            int chi = 0, summa = 0;
            while (chi <= 30)
            {
                int nc = chi % 2;
                chi++;
                if (nc == 0)
                {
                    summa += chi;
                }
            }
            Console.WriteLine("summa= " + summa);

        }

        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 3;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №3. Тема: Циклы";
        }
    }
}
