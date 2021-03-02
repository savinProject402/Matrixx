using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    
                    

                    Console.Write("Размер квадратной матрицы =  ");

                    int randomer = Convert.ToInt32(Console.ReadLine());
                    
                    int[,] Matrix = new int[randomer, randomer];

                    Random random = new Random();

                    int rand;


                    for (int i = 0; i < randomer; i++)
                    {
                        for (int j = 0; j < randomer; j++)
                        {
                            rand = random.Next(0,100); // если нужен диапазон
                            Matrix[i, j] = rand;
                        }
                    }

                    for (int i = 0; i < randomer; i++)
                    {
                        for (int j = 0; j < randomer; j++)
                        {
                            Console.Write(Matrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    int[,] trans = new int[randomer, randomer];
                    Console.WriteLine();
                    Console.WriteLine("Транспонированная матрица: ");
                    Console.WriteLine();
                    for (int i = 0; i < randomer; i++)
                    {
                        for (int j = 0; j < randomer; j++)
                        {

                            trans[i, j] = Matrix[j, i];
                            Console.Write(trans[i, j] + "\t");
                            
                            if (j == randomer -1)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine("Что бы выйти с приложения нажмите Escape или нажмите Enter что бы продолжить ");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.ReadLine();
                    
                    continue;


                    
                }

            }
            
        }
    }
}
