// See https://aka.ms/new-console-template for more information
string filePathOne = @"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Tasks_Day5\FirstText.txt";
string filePathTwo = @"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Tasks_Day5\SecondText.txt";
int allLines = 0;
Console.WriteLine($"Start Date: {DateTime.Now}");
try
{
    DateTime start = DateTime.Now;
    if (!File.Exists(filePathOne))
        throw new FileNotFoundException("This File Is not Found First Path of text file");
    if (!File.Exists(filePathTwo))
        throw new FileNotFoundException("This File Is not Found Second Path of text file");
    Task taskOne = Task.Run(() =>
    {
        string[] str = File.ReadAllLines(filePathOne);
        foreach (string str2 in str)
        {
            Console.WriteLine($"Task1 Timer:   { DateTime.Now - start}");
            Thread.Sleep(1000);
            allLines++;
        }

    });

    Task taskTwo = Task.Run(() =>
    {
        string[] str = File.ReadAllLines(filePathTwo);
        foreach (string str2 in str)
        {
            Console.WriteLine($"Task2 Timer:   { DateTime.Now - start}");
            allLines++;
        }
    });
    taskOne.Wait();
    taskTwo.Wait();
}


catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("All lines in two files = " + allLines);