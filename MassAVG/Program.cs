using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassAVG
{
    internal class Program
    {
        static int m = 1, n = 1, maxValue;

        public static int[,] mass= new int[m,n];

       static int minValue = mass[0,0];

        static float massavg;
        
        static void Main(string[] args)
        {
            Input();
            
        }

        public static void Input()
        {
            try
            {
                Console.WriteLine("Введите размер массива M");
                
                m = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Введите размер массива N");

                n = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите значения массива");
                mass = new int[m,n];
                
               for(int i = 0; i < m; i++ )
                {
                   
                    for (int j =0 ; j < n;j++)
                    {
                        mass[i,j] = int.Parse(Console.ReadLine());
                        
                    }
                    
                }
                MassAVG();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadLine();
                Input();
            }

        }
        public static void MassAVG()
        {
            
            int currentvalue = mass[0,0];
            
            int i, j,sum=0;
            
                for (i = 0; i < m; i++)
                {

                for (j = 0; j < n; j++)
                {

                    try
                    {

                        if(currentvalue >= mass[i, j])
                        {
                            minValue = mass[i,j];
                        }
                        if (currentvalue <= mass[i, j])
                        {
                            maxValue = mass[i, j];
                        }
                        
                        sum+= mass[i,j];

                        currentvalue = mass[i, j];


                    }
                    catch (IndexOutOfRangeException)
                    {

                    }

                }
                if (n == 1)
                {
                    massavg = (float)(mass[i, j]) / n;
                }
                else
                {

                    massavg = (float)sum / n;
                    

                }

                Output(maxValue, minValue, massavg);
                sum = 0;
                    currentvalue = mass[1,0];
                 }








            Console.ReadLine();

        }





        public static void Output( int max,int min, float avg)
        {
            Console.WriteLine($" max={max}, min={min}, AVG={avg}");
            


            
        }

    }    
}
