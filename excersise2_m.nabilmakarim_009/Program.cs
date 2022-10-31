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
        }
        static void Main(string[] args)
        {
        }
    }
}
