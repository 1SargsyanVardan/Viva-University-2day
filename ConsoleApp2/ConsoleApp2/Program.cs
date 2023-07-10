//----------Task1

/*DateTime date = DateTime.Now;
Console.WriteLine(date);
ReplaceDate(ref date);
Patetner(date);
void ReplaceDate(ref DateTime date)
{
    date = date.AddDays(30);
}
void Patetner(DateTime date)
{
    Console.WriteLine("Dzer sakagnayin planum nerarvats patetnery veraaktivacel en yev gortsum en minchev " + date.Day + "/" + date.Month + "/" +date.Year + 
        " "  + date.Hour + ":" + date.Minute);
    Console.WriteLine("Patetneri mnacordy stugelu hamar ugharkeq *208#.");
}*/


//----------Task2
DateTime dt = DateTime.Now;
DateTime newDateTime = GetLastDayOfMonth(dt);
Console.WriteLine( stringFormat(newDateTime, 'm')); 

DateTime GetLastDayOfMonth(DateTime currentDate)
{
    
    DateTime firstDayOfNextMonth = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(1);
    DateTime lastMillisecondOfMonth = firstDayOfNextMonth.AddMilliseconds(-1);
    return lastMillisecondOfMonth;
}

string stringFormat(DateTime dt,char str)
{
    char[] strArray = new char[] { 't', 'd', 'T', 'D', 'F', 'G', 'f', 'g', 'm', 'y', 'r', 's', 'u' };
    if(strArray.Contains(str))
    {
        string retStr = "Dzer sakagnayin planum nerarvats patetnery veraaktivacel en yev gortsum en minchev ";
        switch(str)
        {
            case 't':
                retStr += String.Format("{0:t}", dt);
                break;
            case 'd':
                retStr += String.Format("{0:d}", dt);
                break;

            case 'T':
                retStr += String.Format("{0:T}", dt);
                break;

            case 'D':
                retStr += String.Format("{0:d}", dt);
                break;

            case 'F':
                retStr += String.Format("{0:F}", dt);
                break;

            case 'G':
                retStr += String.Format("{0:G}", dt);
                break;

            case 'f':
                retStr += String.Format("{0:f}", dt);
                break;

            case 'g':
                retStr += String.Format("{0:g}", dt);
                break;

            case 'm':
                retStr += String.Format("{0:m}", dt);
                break;

            case 'y':
                retStr += String.Format("{0:y}", dt);
                break;

            case 'r':
                retStr += String.Format("{0:r}", dt);
                break;

            case 's':
                retStr += String.Format("{0:s}", dt);
                break;

            case 'u':
                retStr += String.Format("{0:u}", dt);
                break;

        }
        return retStr + "\nPatetneri mnacordy stugelu hamar ugharkeq *209#.";
    }
    return "Ayl formatov anhnar e katarel cucadrum!";
}
//----------Task3
/*DateTime datetime1 = new DateTime(2023, 6, 30);
DateTime datetime2 = new DateTime(2023, 7, 8);

int elapsedDays = ElapsedDays(datetime1, datetime2);
Console.WriteLine("Elapsed days: " + elapsedDays);
int ElapsedDays(DateTime datetime1, DateTime datetime2)
{
    TimeSpan timespan = datetime2 - datetime1;
    int elapsedDays = (int)timespan.TotalDays;
    return elapsedDays;
}*/

//----------Task4

/*using ConsoleApp2;

DateTime date = DateTime.Now;
string str = date.Weekday("Russian");
Console.WriteLine(str);*/

//----------Task5
/*using ConsoleApp2;
string patet = "*208*2000*1#";

Ussd ussd = patet.concatStringUssd();
ussd.Print();*/

