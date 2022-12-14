using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise2_m.nabilmakarim_009
{
    internal class Program
    {
        private int[] arr = new int[29];
        private int cmp_count = 0;
        private int mov_count = 0;

        void Read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                int n = 0;
                if (n <= 29)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 29 elements \n");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=======================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, MN;
            if (low > high)
                return;

            i = low + 1;
            MN = high;

            pivot = arr[low];

            while (i <= MN)
            {
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }

                cmp_count++;

                if (i < MN)
                
                {
                    swap(i, MN);
                    mov_count++;
                }
            }

            if (low < MN)
            {
                swap(low, MN);
                mov_count++;
            }

            q_sort(low, MN - 1);
          
            q_sort(MN + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Sorted Array elements");
            Console.WriteLine("\n---------------------");

            int n = 0;
            for (int MN = 0; MN < n; MN++)
            {
                {
                    Console.WriteLine(arr[j]);
                }
                Console.WriteLine("\nNumber of comparisons: ", cmp_count);
                Console.WriteLine("\nNumber of data movemenets: " + mov_count);
            }
        }
        int getSize()
        {
            return (n);
        }


        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.Read();
            myList.q_sort(0, myList.getSize() - 1);            
            myList.display();            
            Console.WriteLine("\n\nPress Enter to exit. ");
            Console.Read();
        }
    }
}
