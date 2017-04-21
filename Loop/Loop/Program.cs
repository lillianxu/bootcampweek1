using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int b = 0;
          String[] person = { "Bob", "Mary", "Joe", "Sue", "John", "Nancy" };

            //foreach loop
            foreach (string value in person)
            {
                Console.WriteLine("Foreach loop name:{0}", value);
            }


            //for loop
            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("For loop name is:" + person[i]);
            }

            //while loop
            while (j <= 5)
            {
                Console.WriteLine("While loop name is:" + person[j]);
                j++;
            }

            //list number
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(13);
            list.Add(15);

         //for loop
            for (int m = 0; m <= 8; m++)
            {
                Console.WriteLine("For loop list number is:" + list[m]);
            }

            //while loop
            while (k <= 8)
            {
                Console.WriteLine("While loop list number is:" + list[k]);
                k++;
            }
            //foreach loop
            foreach (int value in list)
            {
                Console.WriteLine("Foreach loop list number:{0}", value);
            }

            //Print the total of the list of numbers. (Hint. Look at the Sum method).
            Console.WriteLine("total of the list of numbers:" + k);



            //Print the numbers from the list where the number's can't be divided by 2

            while (b <= 8 )
            {   if (list[b] % 2 != 0)
                Console.WriteLine(list[b] + "can't be divided by 2");
                b++;
            }

            //Print the largest number from the list.
            int temMax=0;
            for(int a=0;a<=7;a++)
            {

                // Console.WriteLine(list[a+1]);


                if (list[a] > list[a + 1])
                {
                    temMax = list[a];
                    list[a] = list[a + 1];
                    list[a + 1] = temMax;
                }
                else temMax =list[a + 1];
                
            }
            Console.WriteLine("The largest number is:"+temMax);

            // Print the smallest number from the list.
            int temMin = 0;
            for (int a = 0; a <= 7; a++)
            {
                if (list[a] < list[a + 1])
                {
                    temMin = list[a];
                    list[a] = list[a + 1];
                    list[a + 1] = temMin;
                }
                else temMin = list[a + 1];
            }
            Console.WriteLine("The smallest number is:" + temMin);

            //Print the average value from the list of numbers.
            int Sum = 0;
            int n = 0;
            for (int a = 0; a <= 8; a++)
            {
                Sum += list[a];
                n = a + 1;
            }
            
            Console.WriteLine("The average value is:" + Sum/n);



            //Print the numbers from the list using order by descending.

            for(int a=0;a<8;a++)
            {
                for (int c = a+1; c <=8; c++)
                {
                    if(list[c]>list[a])
                    {
                        int temp = list[c];
                        list[c] = list[a];
                        list[a] = temp;
                    }
                }
            }
            foreach (int value in list)
            {
                Console.WriteLine("Foreach descend list number:{0}", value);
            }

            Console.ReadKey();

        }
    }
}
