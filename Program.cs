﻿using System;

namespace AddDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(GetDayName(dayNumber));

            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt16(Console.ReadLine());

            int finalDay = CalculateFinalDay(dayNumber, dayToAdd);
            Console.WriteLine(GetDayName(finalDay));
        }

        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: return "The day is MONDAY";
                case 2: return "The day is TUESDAY";
                case 3: return "The day is WEDNESDAY";
                case 4: return "The day is THURSDAY";
                case 5: return "The day is FRIDAY";
                case 6: return "The day is SATURDAY";
                case 7: return "The day is SUNDAY";
                default: return "Invalid Input.";
            }
        }

        static int CalculateFinalDay(int dayNumber, int dayToAdd)
        {
            int finalDay = (dayNumber + dayToAdd) % 7;
            return finalDay == 0 ? 7 : finalDay;
        }
    }
}
