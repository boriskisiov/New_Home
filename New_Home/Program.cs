using System.Transactions;

namespace New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeofflower = Console.ReadLine();
            int flowercount = int.Parse(Console.ReadLine());
            double bugget = double.Parse(Console.ReadLine());
            double cost = 0;



            if (typeofflower == "Roses")
            {
                cost = flowercount * 5.00;
                if (flowercount >= 80)
                    cost = cost * 0.9;
            }
            else if (typeofflower == "Dahlias")
            {
                cost = flowercount * 3.80;
                if (flowercount > 90)
                    cost = cost * 0.85;

            }
            else if (typeofflower == "Tulips")
            {
                cost = cost * 2.80;
                if (flowercount > 80)
                    cost = cost * 0.85;
            }
            else if (typeofflower == "Narcissus")
            {
                cost = cost * 3;
                if (flowercount < 120)
                    cost = cost * 1.15;
            }
            else if (typeofflower == "Gladiolus")
            {
                cost = cost * 2.5;
                if (flowercount < 80)
                    cost = cost * 1.2;
            }
            
            
             if (bugget < cost)
                Console.WriteLine($"Not enough money, you need {cost - bugget:f2} leva more.");
            else Console.WriteLine($"Hey, you have a great garden with {flowercount} {typeofflower} and {bugget - cost:f2} leva left.");
        }
            

        }
    }


   