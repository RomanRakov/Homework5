using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5
{
    enum Month
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
    internal class Program
    {
        static int[] average(int[,] temperature)
        {
            int[] average = new int[temperature.GetLength(0)];
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    sum += temperature[i, j];
                }
                average[i] = sum / temperature.GetLength(1);
            }
            return average;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 6.3\nНаписать программу, вычисляющую среднюю температуру за год");
            int[,] temperature = new int[12, 30];
            Random rnd = new Random();
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    temperature[i, j] = rnd.Next(-40, 40);
                }
            }
            int[] averageTemperatures = average(temperature);
            Array.Sort(averageTemperatures);
            for (int i = 0; i < averageTemperatures.Length; i++)
            {
                Console.WriteLine($"Средняя температура за {i + 1} месяц = {averageTemperatures[i]}");
            }
            
            Console.WriteLine("\nДомашнее задание 6.3\nНаписать программу для упражнения 6.3, использовав класс Dictionary<TKey, TValue>");
            Dictionary<Month, int[]> temperatures = new Dictionary<Month, int[]>();
            for (Month month = Month.Январь; month <= Month.Декабрь; month++)
            {
                int[] monthTemperatures = new int[30];
                for (int i = 0; i < monthTemperatures.Length; i++)
                {
                    monthTemperatures[i] = rnd.Next(-40, 40);
                }
                temperatures[month] = monthTemperatures;
            }
            foreach (var step in temperatures)
            {
                Console.WriteLine($"Средняя температура за {step.Key} =  {step.Value.Sum() / 30}");
            }
            Console.ReadKey();
        }    
    
    }
}
