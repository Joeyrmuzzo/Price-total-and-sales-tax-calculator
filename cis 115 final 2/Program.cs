using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_115_final_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchaseAmount, salesTax=0;
            int countyCode;

            Console.WriteLine("Please enter the purchase amount: ");
            purchaseAmount =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter your county code number: ");
            countyCode = Convert.ToInt32(Console.ReadLine());


            while (countyCode>=8&&countyCode<=40)
            {
                if (countyCode >= 8 && countyCode <= 15)
                {
                    salesTax = .05;
                }
                else if (countyCode >= 15 && countyCode <= 30)
                {
                    salesTax = .06;
                }
                else if (countyCode >= 30)
                {
                    salesTax = .07;
                }

                Console.WriteLine("The total is: " + (purchaseAmount + purchaseAmount* salesTax));
                Console.WriteLine("The SalesTax is: " + (salesTax * purchaseAmount));

                Console.ReadLine();
                
            }
            
        }
    }
}
