using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArray
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
            
            //Create a string array with the following names "Bob", "Mary", "Joe", "Sue", "John","Nancy"
            string[] Names={ "Bob", "Mary", "Joe", "Sue", "John", "Nancy" };

            //Print the array of names to the console
            //for loops
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("For Name is:{0}",Names[i] );
            }

            //while loops
            int NameNumber = 0;
            while (NameNumber < Names.Length)
            {
                Console.WriteLine("While Name is:{0}", Names[NameNumber]);
                NameNumber++;
            }
            //foreach loop
            foreach (string value in Names)
            {
                Console.WriteLine("Foreach Name is:{0}", value);
            }

    */
            //Create a list with the following numbers 1, 3, 4 , 5, 6, 7, 8 , 13 , 15
            int[] Number = { 1, 3, 4, 5, 6, 7, 13, 8, 15 };

            // Print a list of numbers to the console
            //for loops
            for(int i=0;i<Number.Length;i++)
            {
                Console.WriteLine("For number is:{0}", Number[i]);
            }
            /*
                            //while loops
                            int Quantity = 0;
                            while (Quantity<Number.Length)
                            {
                                Console.WriteLine("While number is :{0}", Number[Quantity]);
                                Quantity++;
                            }
                            //foreach loop
                            foreach (int value in Number)
                            {
                                Console.WriteLine("foreach number is:{0}",value);
                            }


                    //Print the total of the list of numbers. (Hint. Look at the Sum method)
                    Console.WriteLine("Total number is:" + Number.Length);


                //  Print the numbers from the list where the number's can't be divided by 2.
                            for (int i = 0; i < Number.Length; i++)
                            {
                                if(Number[i]%2!=0)
                                Console.WriteLine( Number[i]+ "can't be divided by 2");
                            }
              */
            //Print the largest number from the list.
            int large = 0;
            int templarge = 0;
                    for (large= 0; large < Number.Length-1; large++)
                    {
                        if (Number[large] > Number[large + 1])
                        {
                            templarge = Number[large];
                            Number[large] = Number[large + 1];
                            Number[large + 1] = templarge;
                        }
                        else templarge = Number[large + 1];
                    }
            Console.WriteLine("The largest number is:{0}",templarge);

            //Print the smallest number from the list.
            int small = 0;
            int tempSmall = 0;
            while (small< Number.Length - 1)
            {
                if (Number[small] < Number[small + 1])
                {
                    tempSmall = Number[small];
                    Number[small] = Number[small + 1];
                    Number[small + 1] = tempSmall;
                }
                small++;
            }
            Console.WriteLine("The smallest number is:{0}", Number[small]);
            //Print the average value from the list of numbers.
            int sum = 0;
            for (int i = 0; i < Number.Length; i++)
            {
                sum += Number[i];
            }
            Console.WriteLine("The average number is:{0}", sum/Number.Length);

            //Print the numbers from the list using order by descending.
            int tempOrder = 0;
            for (int i=0;i<Number.Length;i++)
             {
                for(int j=i+1;j<Number.Length;j++)
                {
                    if (Number[i] < Number[j])
                    {
                        tempOrder = Number[i];
                        Number[i] = Number[j];
                        Number[j] = tempOrder;
                    }
                }
             }
            foreach (int value in Number)
            {
                Console.WriteLine("{0}", value);
            }
            Console.ReadKey();
        }
    }
}
