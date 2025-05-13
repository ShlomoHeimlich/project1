using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Program
    {
        static void examination(int[]nambers)
        {
            int affirmative = 0;
            foreach(char c in nambers)
            {
                if (c > 0)
                {
                    affirmative += 1;
                }
            }
            if (nambers.Length >= 3&& affirmative >= 3)
            {
                menu(nambers);
            }
        }
        static void menu(int[]nambers)
        {
            string[] menu_str = {
            "1=Replace the current series",
            "2=Display the series in the order it was entered.",
            "3=Display the series in the reversed order it was entered.",
            "4=Display the series in sorted order (from low to high).",
            "5=Display the Max value of the series.",
            "6=Display the Min value of the series.",
            "7=Display the Average of the series.",
            "8=Display the Number of elements in the series.",
            "9=Display the Sum of the series.",
            "10=Exit."};
            foreach (string item in menu_str)
            {
                Console.WriteLine(item);
            }
            int valu;
            do
            {
                 Console.WriteLine("Choose a number from the menu from one to ten.");
                 valu = Convert.ToInt32(Console.ReadLine());
            }
            while (valu>10|| valu<0);
            Value_check(valu, nambers);
         }
        static void Value_check(int valu,int[]nambers)
        {
            switch(valu)
            {
                case 1:
                    Enter_series();
                    break;
                case 2:
                    Show_series(nambers);
                    break;
                case 3:
                    Show_series_reverse(nambers);
                    break;
                case 4:
                    Sort_low_to_high(nambers);
                    break;
                case 5:
                    max(nambers);
                    break;
                case 6:
                    min(nambers);
                    break;
                case 7:
                    average(nambers);
                    break;
                case 8:
                    Long(nambers);
                    break;
                case 9:
                    sum(nambers);
                    break;
                case 10:
                    exit();
                    break;
            }
        }
        static void Enter_series()
        {

        }
        static void Show_series(int[] nambers)
        {
            foreach(int c in nambers)
            {
                Console.WriteLine(c);
            }
            menu(nambers);
        }
        static void Show_series_reverse(int[] nambers) 
        { 
           for(int i = nambers.Length-1;i>-1;i--)
            {
                Console.WriteLine(nambers[i]);
            }
            menu(nambers);
        }
        static void Sort_low_to_high(int[] nambers)
        {
            int[]copy_nambers=nambers;
            Array.Sort(copy_nambers);
            foreach(int c in copy_nambers)
            {
                Console.WriteLine(c);
            }
            menu(nambers);
        }
        static void max(int[] nambers)
        {
           int max = 0;
           foreach(int c in nambers)
            {
                if(c > max)
                {
                    max = c;
                }
                
            }
            Console.WriteLine($"the max nam is {max}");
            menu(nambers);

        }
        static void min(int[] nambers)
        {
            int min = nambers[0];
            foreach (int c in nambers)
            {
                if (c < min)
                {
                    min = c;
                }
                Console.WriteLine(min);
                menu(nambers);
            }
        }
        static void average(int[] nambers)
        {
                int Length =nambers.Length;
                int sum = 0;
                foreach(int c in nambers)
            {
                sum += c;
            }
                Console.WriteLine(sum/ Length);
                menu(nambers);
        }
        static void Long(int[] nambers)
        {
            Console.WriteLine(nambers.Length);
            menu(nambers);
        }
        static void sum(int[] nambers) 
        {
            int sum = 0;
            foreach (char c in nambers)
            {
                sum += c;
            }
            Console.WriteLine(sum);
        }
        static void exit()
        {

        }




        static void Main(string[] args)
        {
            int[] nambers = { 1, 2, 3};
            examination(nambers);
        }
    }
}

