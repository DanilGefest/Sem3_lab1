/*****************************************
 * Выполнил: Земцев Данил Евгеньевич     *
 * Вариант: 3                            *
 * Лабораторная работа №0                *
 * Условие:                              *
 * Из материала плотностью p изготовлен  *
 * диск радиусом r. Каким должна быть    *
 * толщина диска, чтобы он имел массу m? *
 * ***************************************/

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        double Pi = Math.PI;
        double Density = 0;
        double Radius = 0;
        double Mass = 0;

        do
        {
            Console.WriteLine("Введите плотность металла в кг/м^3 (прим. Сталь = 7700)");
            if (!double.TryParse(Console.ReadLine(), out Density) || Density <= 0)
            {
                Console.WriteLine("Значение плотности не может быть отрицательным, " +
                    "равным нулю или текстом. Попробуйте ввести снова");
            }
        } while (Density <= 0);

        do
        {
            Console.WriteLine("Введите радиус диска в метрах (прим. = 0,2)");
            if (!double.TryParse(Console.ReadLine(), out Radius) || Radius <= 0)
            {
                Console.WriteLine("Значение радиуса диска не может быть оотрицательным," +
                    " равным нулю или текстом. Попробуйте ввести снова");
            }
        } while (Radius <= 0);

        do
        {
            Console.WriteLine("Введите массу диска в килограммах (прим. = 300)");
            if (!double.TryParse(Console.ReadLine(), out Mass) || Mass <= 0)
            {
                Console.WriteLine("Значение массы не может быть отрицательным, " +
                    "равным нулю или текстом. Попробуйте ввести снова");
            }
        } while (Mass <= 0);

        double Volume = Mass / Density;
        double height = (Volume) / (Math.PI * Math.Pow(Radius, 2));

        double VolumeInCm = Volume * 1e6; // переводим в см^3
        double heightInCm = height * 100; // переводим в см

        Console.WriteLine("Расчет толщины диска");
        Console.WriteLine("Объем диска: {0:F3},Кг/м^3 ({1:F3},см^3)", Volume, VolumeInCm);
        Console.WriteLine("Высота диска: {0:F3},м ({1:F3},см)", height, heightInCm);
    }
}