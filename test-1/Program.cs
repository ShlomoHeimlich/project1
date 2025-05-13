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
        static void examination(List<int> list_nambers)
        {
            int affirmative = 0;
            foreach(int c in list_nambers)
            {
                if (c > 0)
                {
                    affirmative += 1;
                }
            }
            if (affirmative >= 3)
            {
                menu(list_nambers);
            }
            else
            {
                yuser_input();
            }
        }
        static void yuser_input()
        {
            Console.WriteLine("Please enter at least three positive numbers.");
            List<int> list_nambers = new List<int>();
            string str_nam=Console.ReadLine();
            string[] list_str = str_nam.Split();
            foreach (string c in list_str)
            {
                int num = Convert.ToInt32(c);
                list_nambers.Add(num);
                examination(list_nambers);
            }
        }
        
        static void menu(List<int> list_nambers)
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
            Value_check(valu, list_nambers);
         }
        static void Value_check(int valu,List<int> list_nambers)
        {
            switch(valu)
            {
                case 1:
                    Enter_series();
                    break;
                case 2:
                    Show_series(list_nambers);
                    break;
                case 3:
                    Show_series_reverse(list_nambers);
                    break;
                case 4:
                    Sort_low_to_high(list_nambers);
                    break;
                case 5:
                    max(list_nambers);
                    break;
                case 6:
                    min(list_nambers);
                    break;
                case 7:
                    average(list_nambers);
                    break;
                case 8:
                    Long(list_nambers);
                    break;
                case 9:
                    sum(list_nambers);
                    break;
                case 10:
                    exit();
                    break;
            }
        }
        static void Enter_series()
        {
            yuser_input();
        }
        static void Show_series(List<int> list_nambers)
        {
            foreach(int c in list_nambers)
            {
                Console.WriteLine(c);
            }
            menu(list_nambers);
        }
        static void Show_series_reverse(List<int> list_nambers) 
        { 
           for(int i = list_nambers.Count-1;i>-1;i--)
            {
                Console.WriteLine(list_nambers[i]);
            }
            menu(list_nambers);
        }
        static void Sort_low_to_high(List<int> list_nambers)
        {
            List <int> copy_nambers= list_nambers;
            copy_nambers.Sort();
            foreach(int c in copy_nambers)
            {
                Console.WriteLine(c);
            }
            menu(list_nambers);
        }
        static void max(List<int> list_nambers)
        {
           int max = 0;
           foreach(int c in list_nambers)
            {
                if(c > max)
                {
                    max = c;
                }
                
            }
            Console.WriteLine($"the max nam is {max}");
            menu(list_nambers);

        }
        static void min(List<int> list_nambers)
        {
            int min = list_nambers[0];
            foreach (int c in list_nambers)
            {
                if (c < min)
                {
                    min = c;
                }
                Console.WriteLine(min);
                menu(list_nambers);
            }
        }
        static void average(List<int> list_nambers)
        {
                int Length = list_nambers.Count;
                int sum = 0;
                foreach(int c in list_nambers)
            {
                sum += c;
            }
                Console.WriteLine(sum/ Length);
                menu(list_nambers);
        }
        static void Long(List<int> list_nambers)
        {
            Console.WriteLine(list_nambers.Count);
            menu(list_nambers);
        }
        static void sum(List<int> list_nambers) 
        {
            int sum = 0;
            foreach (int c in list_nambers)
            {
                sum += c;
            }
            Console.WriteLine(sum);
            menu(list_nambers);
        }
        static void exit()
        {

        }




        static void Main(string[] args)
        {
            
        }
    }
}

