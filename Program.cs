using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaprecars_constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Type a four digit number:"); 
            string x = Console.ReadLine();
            while (x != "6174")
            {
                Console.WriteLine($"Number =  {x}");
                string ascending = BubbleSort(x);
                string descending = "";
                for (int i = 0; i < 4; i++)
                {
                    descending = descending + ascending[3 - i];
                }
                x = Convert.ToString(Convert.ToInt32(descending) - Convert.ToInt32(ascending));
                Console.WriteLine($"Descending = {descending}");
                Console.WriteLine($"Ascending = {ascending}");
                Console.WriteLine("");
            }
            Console.WriteLine(x);
            
                
            
        }

        static string BubbleSort(string str)
        {
            char[] myArray = new char[str.Length];
            for (int i = 0; i < 4; i++)
            {
                myArray[i] = Convert.ToChar(str[i]);
            }
            int length = myArray.Length;
            bool Sorted = false;
            char temp = ' ';
            while (Sorted != true)
            {
                Sorted = true;
                for (int i = 0; i < length - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        Sorted = false;
                        temp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = temp;
                    }
                }
            }
            str = "";
            for (int i = 0; i < 4; i++)
            {
                str = str + myArray[i];
            }
            return str;
        }
    }
}
