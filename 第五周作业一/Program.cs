/*
输入公元年份和月份，输出该月份的天数。（用switch……case语句）

样例：输入：2005,5
     输出：31
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五周作业一
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(',');
            int year = Convert.ToInt32(inputSplit[0]);
            int month = Convert.ToInt32(inputSplit[1]) - 1;
            int[] monthLeap = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] monthNormal = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int answer = 0;

            switch (year % 4)
            {
                case 0:
                    if (year % 100 == 0)
                    {
                        answer = year % 400 == 0 ? monthLeap[month] : monthNormal[month];
                        break;
                    }
                    else
                    {
                        answer = monthLeap[month];
                        break;
                    }

                default:
                    answer = monthNormal[month];
                    break;
            }

            Console.Write(answer);
        }
    }
}
