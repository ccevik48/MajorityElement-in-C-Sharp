using System;

namespace MajorityElement
{
    class Program
    {
        public static int majEle(int[] a)
        {
            int count = 1;
            int currMaxCnt = 0;
            int currMaxEle = a[0];
            for(int i = 0; i < a.Length - 1; i++)
            {
                if(a[i] == a[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if(count > currMaxCnt)
                {
                    currMaxCnt = count;
                    currMaxEle = a[i];
                }
            }
            return currMaxEle;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 2, 2, 7, 9, 1, 2 };
            Console.WriteLine(majEle(arr));
        }
    }
}
