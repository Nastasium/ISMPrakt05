using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ISMPrakt05Console
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("\tEnter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Random ran = new Random();
            Console.Write($"\tArray[{size}] = ");
            Console.Write("{");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) 
            {
                    arr[i] = ran.Next(-10, 10);
                    Console.Write($"  {arr[i]}");
            }            
            Console.WriteLine("  }");
            int res, max, totalnum, index, num, sum, total;
            var mf = new MassiveFormulas();
            mf.NegSum(arr, size, out res);
            mf.MaxEvenNumber(arr, size, out max);
            mf.TotalNumEvenIndex(arr, size, out totalnum);
            mf.MaxNumIndex(arr, size, out index);
            mf.MaxNumber(arr, size, out num);
            mf.PositiveNumIndexSum(arr, size, out sum);
            mf.TotalNumOddNumbers(arr, size, out total);
            Console.WriteLine($"\tTask 1 result: {res}\n\tTask 2 result: {max}\n\tTask 3 result: {totalnum}\n\tTask 4 result: {index}\n\tTask 5 result: {num}\n\tTask 6 result: {sum}\n\tTask 7 result: {total}");
            Console.ReadLine();
        }
    }
}
