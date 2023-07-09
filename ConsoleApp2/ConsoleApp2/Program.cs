// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime date = DateTime.Now;
date = date.AddDays(30);

string patet = "Dzer sakagnayin planum nerarvats patetnery veraaktivacel en yev gortsum en minchev " + date.ToString("MM/dd/yyyy") + 
    "\nPatetneri mnacordy stugelu hamar ugharkeq *208#.";
Console.WriteLine(patet);