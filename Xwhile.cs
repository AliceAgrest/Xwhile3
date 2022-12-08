using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1
            /*
            int singleShovar = 0,shovar1 = 0, sumShovar1 = 6;
            int doubleShovar = 0,shovar2 = 0, sumShovaer2 = 10;
            int sum;

            while (shovar1 != -1 || shovar2 != -1)
            {
                Console.WriteLine("Enter a count of single shovers: ");
                shovar1 = int.Parse(Console.ReadLine());
                if (shovar1 != -1)
                    singleShovar += shovar1;
                else
                    break;
                Console.WriteLine("Enter a count of double shovers: ");
                shovar2 = int.Parse(Console.ReadLine());
                if (shovar2 != -1)
                    doubleShovar += shovar2;
                else
                    break;

                if (shovar1 * sumShovar1 >= 50)
                {
                    Console.WriteLine("You deserve double shover as a gift ");
                    doubleShovar++;
                }
            }
            sum = (singleShovar * sumShovar1) + (doubleShovar * sumShovaer2);
            Console.WriteLine($"The total money collected is {sum}\n" +
                $"The sum of double shovers is {doubleShovar}");
            */
            //q2
            int moneySum , total = 0, moneySum1, somthing,somthing1 = 0,somthingSum = 0;
            double avg;
            Random rnd = new Random();
            //rnd.Next(10,51);

            Console.WriteLine("Enter a sum of money ");
            moneySum = int.Parse(Console.ReadLine());
            moneySum1 = moneySum;

            while (moneySum >= 0)
            {
                somthing = rnd.Next(10, 51);
                moneySum = moneySum - somthing;
                Console.WriteLine($"The value of the product {somthing}\n" +
                    $"Money left {moneySum}");
                total++;
                somthingSum += somthing;
                somthing1 = somthing;
            }
            avg = somthingSum / (double)total;
            Console.WriteLine(value: $"Initial amount {moneySum1}\n" 
                + $"Total products {total}\n"
                + $"The average amount of products {avg}\n" 
                + $"The last product {somthing1}\n"
                + $"final amount {moneySum}");

            Console.ReadLine();
        }
    }
}
