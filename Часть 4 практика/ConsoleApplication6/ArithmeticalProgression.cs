using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class ArithmeticalProgression
    {
        public void GetFirstNumber(int n)//Показывает 1й эелемент прогрессии
        {
            Console.WriteLine("The first number = " + n);
        }

        public int SetFirstNumber()//Устанавливает 1й элемент прогрессии
        {
            Console.WriteLine("Enter first number");
            int n=Int32.Parse(Console.ReadLine());
        return n;
        }

        public void GetDifference(int d)//Показывает разницу прогрессии
        {
            Console.WriteLine("The difference =  "+d);

        }
        public int SetDifference()//Установка разницы прогрессии
        {
            Console.WriteLine("Enter difference");
            int n = Int32.Parse(Console.ReadLine());
            return n;
        }

        public int SetLengs() // Длинна прогрессии
        {
            Console.WriteLine("Enter lengs");
            int l = Int32.Parse(Console.ReadLine());
            return l;
        }

        public int[] CreateArray(int n, int d, int l)  //Создаем прогрессию в виде массива с длинной l
        {
            
            int[] array0 = new int[l];
            array0[0] = n;
            Console.WriteLine(array0[0]);
            for (int i = 1; i < array0.Length; i++)
            {

                array0[i] = array0[i - 1] + d;

                Console.WriteLine(array0[i]);
            }

                return array0;

        }

        public void GetNNumber(int [] array)//Показывает n элемент прогрессии
        {
            Console.WriteLine("Enter n number of progression");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine(array[i+1]);
            return;
        }

        public void GetAverage(int[] array2)// Выдает среднее арифметическое прогрессии
        {

            int aver = array2[1] / array2[0];
            Console.WriteLine("Average of progression = "+aver);
           
        }

        public int[] GetSum(int[] array)//Выдает сумму членов прогрессии
        {
            Console.WriteLine("Enter n nuber of progression");
            int n = Int32.Parse(Console.ReadLine());
            int sum=0;
            for (int i=0; i<array[n]; i++)
            {
            sum=sum+array[i];
            }
            Console.WriteLine("Sum of n number progression = "+sum);
            int[] array2 = {n,sum };
            return array2;
        }


    }
}
