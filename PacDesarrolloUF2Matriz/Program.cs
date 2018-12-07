using System;

namespace PacDesarrolloUF2Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Elije la fila que quieres eliminar");
            int xConsola = int.Parse(Console.ReadLine());
            Console.WriteLine("Elije la columna que quieres eliminar");
            int yConsola = int.Parse(Console.ReadLine());

            int[,] matriz = new int[3, 3]; 

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                { 

                    if (y == xConsola && x == yConsola)
                    {
                        matriz[y, x] = 0;
                    }
                    else
                    {
                        matriz[y, x] = 1;
                    }
                    Console.Write(matriz[y,x] + " ");
                                       
                }

                Console.WriteLine("  ");

            }
            
            
            
            Console.ReadKey();
        }
    }
}
