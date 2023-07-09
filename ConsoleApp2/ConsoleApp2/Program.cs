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

//----------Task3
using ConsoleApp2;
string patet = "*208*2000*1#";

Ussd ussd = patet.concatStringUssd();
ussd.Print();
