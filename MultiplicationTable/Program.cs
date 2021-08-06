using System;

namespace MultiplicationTable
{   
    class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            int number_question = rnd.Next(18,24);
            int number_mistake=0;
            int number_correc_answers=0;
            int answer=0;
            string v;
            int i;

            var array1 = new int[number_question];
            var array2 = new int[number_question];

            var random = new Random();

            for ( i = 0; i < number_question; i++)
            {
              array1[i] = random.Next(0, 10);
            }
          
            for (i = 0; i < number_question; i++)
            {
                array2[i] = random.Next(0, 10);
            }

            Console.WriteLine("Таблиця множення:");

            for (i = 0; i < number_question; i++)
            {
                Console.Write($"{ array1[i]} x {array2[i]} = ");
                answer = Convert.ToInt32(Console.ReadLine());

                if ((array1[i] * array2[i]) == answer)
                {
                    number_correc_answers++;
                }
                else
                {
                    number_mistake++;
                }
            }

            switch (number_mistake)
              {
                  case 0:
                      v = "Відмінно. Оцінка - 12";
                      break;
                  case 1:
                      v = "Оцінка - 11";
                      break;
                  case 2:
                      v = "Оцінка - 10";
                      break;
                  case 3:
                      v = "Добре. Оцінка - 9";
                      break;
                  case 4:
                      v = "Оцінка - 8";
                      break;
                  case 5:
                      v = "Оцінка - 7";
                      break;
                  case 6:
                      v = "Задовільно. Оцінка - 6";
                      break;
                  case 7:
                      v = "Оцінка - 5";
                      break;
                  case 8:
                      v = "Оцінка - 4";
                      break;
                  case 9:
                      v = "Незадовільно. Оцінка - 3";
                      break;
                  case 10:
                      v = "Оцінка - 2";
                      break;
                  case 11:
                      v = "Оцінка - 1";
                      break;
                  default:
                      v = "Жахливо! Перездача!";
                      break;
              }
              Console.WriteLine(v);
        }
    }
}
