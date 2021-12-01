using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class MassiveFormulas
    {

        public void NegSum(int[] a, int size, out int res)
        {
            res = 0;
            for (int i = 0; i < size; i++)
            {
                if (a[i] < 0) res += a[i];
            }
        }

        public void MaxEvenNumber(int[] a, int size, out int max)
        {
            max = 0;
            bool z = true;
            for (int i = 0; i < size; i++)
            {
                if (a[i] % 2 == 0)
                {
                    while (z)
                    {
                        max = a[i];
                        z = false;
                    }
                    if (a[i] > max) max = a[i];
                }
            }
        }

        public void TotalNumEvenIndex(int[] a, int size, out int totalnum)
        {
            totalnum = 1;
            for (int i = 2;i<size; i += 2)
            {
                totalnum *= a[i];               
            }
        }

        public void MaxNumIndex(int[] a, int size, out int index)
        {
            int max = a[0];
            index = 0;
            for (int i = 1; i < size; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }
        }

        public void MaxNumber(int[] a, int size, out int num)
        {
            if (a[0] < 0) Math.Abs(a[0]);
            num = a[0];
            for (int i = 1; i < size; i++)
            {
                if (a[i] < 0) Math.Abs(a[i]);
                if (a[i] > num)
                {
                    num = a[i];
                }
            }
        }

        public void PositiveNumIndexSum(int[] a, int size, out int sum)
        {
            sum = 0;
            for (int i = 0; i < size; i++)
            {
                if (a[i] > 0) sum += i;
            }
        }

        public void TotalNumOddNumbers(int[] a, int size, out int total)
        {
            total = 0;
            for (int i = 0; i < size; i++)
            {
                if (a[i] % 2 != 0) total++;
            }
        }
    }
}