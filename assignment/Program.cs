using assignment.Enums;
using System.ComponentModel;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //    1 - Create an enum called "WeekDays" with the days of the week
            //    (Monday to Sunday) as its members.Then, write a C# program that
            //    prints out all the days of the week using this enum.

            //string[] daysOfWeek = Enum.GetNames(typeof(WeekDays));
            //for (int i=0; i<daysOfWeek.Length;i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //} 
            #endregion

            #region q2
            //2.Create an enum called "Season" with the four seasons(Spring,
            //Summer, Autumn, Winter) as its members.Write a C# program that
            //takes a season name as input from the user and displays the
            //corresponding month range for that season. Note range for seasons (
            //spring march to may , summer june to august, autumn September to
            //November, winter December to February)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();
            //Season season;
            //if (Enum.TryParse(input, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season.");
            //}

            #endregion

            #region q3
            //4 - Assign the following Permissions(Read, write, Delete, Execute) in a
            //form of Enum.

            //● Create Variable from previous Enum to Add multible
            //Permission

            //Permission p = (Permission)16;
            ////or 
            //p |= Permission.Read;   
            //p |= Permission.Write;   
            //p |= Permission.Execute; 
            //p |= Permission.Delete;  
            //Console.WriteLine($"Assigned Permissions: {p}");

            #endregion

            #region q5
            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            //as its members.Write a C# program that takes a color name as input from
            //the user and displays a message indicating whether the input color is a
            //primary color or not.

            //Console.WriteLine("Enter a color :");
            //Colors c;
            //bool b=Enum.TryParse(Console.ReadLine(), true, out c);
            //if (b)
            //{
            //    Console.WriteLine($"{c} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{c} is not a primary color.");
            //}
            #endregion
        }
    }
}
