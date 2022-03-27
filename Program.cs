using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class MethodPractice
    {

        static void Main(string[] args)
        {

            Console.WriteLine("input a string");
            string Character = Console.ReadLine();
            Console.WriteLine(ShowCharacter(Character));

            Console.WriteLine("input the cost");
            double cost= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("int put markup percetage");
            double percentage= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(CalculatePrice(cost,percentage));

            Console.WriteLine("input the degree in F");
            double F= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Celsius(F));

            Console.WriteLine("input an integer");
            int Integer= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(Integer));


        }
        static char ShowCharacter(string Char)
        {
            Console.WriteLine("input the number if character you want");
            int integer = Convert.ToInt32(Console.ReadLine());


            return (Char[integer - 1]);
        }

        static double CalculatePrice(double num1,double num2) 
       
        { 
            return num1+num1 * num2*1/100;
        }

        static double Celsius(double FF) 
        {
           
            return (FF-32)*5/9;
        }

        static bool IsPrime(int Int) 
        {
            int a = 0;
            for (int i = 1; i <= Int; i++)
            {
                if (Int% i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}