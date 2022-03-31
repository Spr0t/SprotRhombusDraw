using System;

namespace LessonHW15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту ромба: ");
            int h = int.Parse(Console.ReadLine());

            int polovina = h / 2;
            int zvezochek = 1;



            for (int l = 0; l <= h; l++)
            {
                Console.WriteLine("\n");

                for (int i = 0; i <= polovina - zvezochek; i++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < zvezochek; j++)
                {
                    Console.Write("* ");
                }

                if (l < polovina)
                {
                    zvezochek++;
                }
                else
                {
                    zvezochek--;
                }



            }


            Console.ReadLine();
        }
    }
}
