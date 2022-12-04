using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra

            Console.WriteLine("Introduceti numarul de cifre din sir: ");
            int n = int.Parse(Console.ReadLine());
            int[] sir= new  int[n];
            Console.WriteLine("Introduceti cele "+n+ " numere din sir: ");
            for(int i=0; i<n; i++)
            {
                sir[i] = int.Parse(Console.ReadLine());

            }
            int media = 0;
            int j = 0;
            for(int i = 0; i<n; i++)
            {
                if(sir[i]%2==0)
                {
                    media = media + sir[i];
                    j++;
                }
            }
            if(j==0)
            {
                Console.WriteLine("Nu sunt numere pare in sir");
            }
            else
            {
                Console.WriteLine("Media artimetica a numerelor pare din sir este " + media / j);

            }

        }
    }
}
