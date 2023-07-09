DateTime date = DateTime.Now;
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
}
