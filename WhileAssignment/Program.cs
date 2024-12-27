using System;

namespace WhileAssignment
{
    class Program
    {
        static void Main()
        {
            int text_counter = 0;
            while (text_counter < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                text_counter++;
            }

            int number_counter = 1;
            Console.WriteLine("1'den 20'ye kadar olan sayılar:");
            while (number_counter < 21)
            {
                Console.WriteLine(number_counter);
                number_counter++;
            }

            int even_counter = 1;
            Console.WriteLine("1'den 20'ye kadar olan çift sayılar:");
            while (even_counter < 21)
            {
                if (even_counter % 2 == 0)
                {
                    Console.WriteLine(even_counter);
                }
                even_counter++;
            }

            int sum_counter = 51;
            int sum = 0;
            while (sum_counter < 150)
            {
                sum += sum_counter;
                sum_counter++;
            }
            Console.WriteLine($"50'den 150'e kadar olan sayıların toplamı: {sum} ");

            int even_sum = 0, odd_sum = 0;
            int counter = 2;
            while (counter < 120)
            {
                if (counter % 2 == 0)
                {
                    even_sum += counter;
                }
                else
                {
                    odd_sum += counter;
                }
                counter++;
            }

            Console.WriteLine($"1 ile 120 arasındaki tek sayılarin toplami = {even_sum}");
            Console.WriteLine($"1 ile 120 arasındaki cift sayılarin toplami = {odd_sum}");



        }
    }
}