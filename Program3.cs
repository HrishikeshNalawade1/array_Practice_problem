using System;

namespace program
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 12, 8, 9, 10, 43, 7, 3, 1 };
            int ab = 0;
            int temp = 0;
            int le = arr.Length;
            for (int i = 0; i < le; i++)
            {
                for (int j = i + 1; j < le; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 3; i < le; i++)
            {
                ab = ab + arr[i];

            }
            Console.WriteLine(ab);
        } 
    }
}

