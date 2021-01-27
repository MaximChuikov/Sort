using System;

namespace Сортировка_любого_массива
{
    enum Big
    {
        theSmallest, smaller, small, medium, big, bigger, theBiggest 
    }
    class Maxim : IComparable
    {
        public Big me;

        public int CompareTo(object obj)
        {
            var that = (Maxim)obj;
            var value = (int)that.me;

            if ((int)me < value)
                return -1;
            else if ((int)me == value)
                return 0;
            else
                return 1;
        }

        public override string ToString()
        {
            return me.ToString();
        }
    }

    static class Sort
    {
        public static void BubbleSort(this Array array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    var left = (IComparable)array.GetValue(j - 1);
                    var right = array.GetValue(j);
                    if (left.CompareTo(right) < 0)
                    {
                        var temp = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temp, j - 1);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int[] intAr = new int[] { 34, 678, 12, 1, 45, 566, 12, 1, 1, 2, 46, 45 };
            string[] strAr = new string[] { "ABC", "abc", "123", "321", "119", "aaa", "A", "B", "1", ".", "D", "E", "F", "G", "H" };
            char[] chAr = new char[] { 'B', 'A', 'E', 'D', 'C', 'C', 'G', 'F', 'c', 'd', 'a', 'd' };
            var dAr = new double[] { 3.6, 5.678888888, 78, 1.0, 1, 4, 5.6786767676, 2, 3.5 };

            intAr.BubbleSort();
            strAr.BubbleSort();
            chAr.BubbleSort();
            dAr.BubbleSort();

            Random rand = new Random();

            Maxim[] max = new Maxim[7];

            for (int i = 0; i < max.Length; i++)
            {
                max[i] = new Maxim { me = (Big)rand.Next(0, 7) };
            }

            max.BubbleSort();

            Console.ReadKey();
        }
    }
}
