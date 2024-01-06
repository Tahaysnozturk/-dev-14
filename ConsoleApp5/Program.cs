using System;

namespace Ornek213
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 78, 56, 23, 95, 68, 87, 61, 77, 45, 33 };

            for (int i = 0; i < A.Length - 1; i++)
            {
                int EnBuyukYer = i;

                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > A[EnBuyukYer])
                    {
                        EnBuyukYer = j;
                    }
                }

                int gecici = A[i];
                A[i] = A[EnBuyukYer];
                A[EnBuyukYer] = gecici;

                Console.WriteLine(A[i]);
            }

            Console.Write("Devam etmek için bir tuşa basın...");
            Console.ReadKey(true);
        }
    }
}