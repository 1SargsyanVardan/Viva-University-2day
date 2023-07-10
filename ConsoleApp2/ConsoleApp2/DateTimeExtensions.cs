using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static public class DateTimeExtension
    {
        static public string Weekday(this DateTime date,string language)
        {
            if (language == "Russian")
                return date.ToString("dddd");
            else if(language == "Armenian")
            {
                string weekday = date.ToString("dddd");
                string? retWeekday = "";
                switch (weekday)
                {
                    case "понедельник":
                        retWeekday += "երկուշաբթի";
                        break;
                    case "вторник":
                        retWeekday += "երեքշաբթի";
                        break;
                    case "среда":
                        retWeekday += "չորեքշաբթի";
                        break;
                    case "четверг":
                        retWeekday += "հինգշաբթի";
                        break;
                    case "пятница":
                        retWeekday += "ուրբաթ";
                        break;
                    case "суббота":
                        retWeekday += "շաբաթ";
                        break;
                    case "Воскресенье":
                        retWeekday += "կիրակի";
                        break;

                }
                return retWeekday;
            }
            else if(language == "English")
            {
                string weekday = date.ToString("dddd");
                string? retWeekday = "";
                switch (weekday)
                {
                    case "понедельник":
                        retWeekday += "monday";
                        break;
                    case "вторник":
                        retWeekday += "tuesday";
                        break;
                    case "среда":
                        retWeekday += "wednesday";
                        break;
                    case "четверг":
                        retWeekday += "thursday";
                        break;
                    case "пятница":
                        retWeekday += "friday";
                        break;
                    case "суббота":
                        retWeekday += "saturday";
                        break;
                    case "Воскресенье":
                        retWeekday += "sunday";
                        break;

                }
                return retWeekday;
            }
            return "This language is`t in program!";
        }
    }
}
