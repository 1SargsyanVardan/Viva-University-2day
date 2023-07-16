// ---------------------------------Task 1----------------------
/*string filePathOne = @"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Tasks_Day5\FirstText.txt";
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

Console.WriteLine("All lines in two files = " + allLines);*/

//--------------------------------------------Task 2--------------------------
//kargavorvac amboxj directoriay hamar
using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


string directory = @"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Tasks_Day5";
string[] imageInDirectory = Directory.GetFiles(directory, "*jpeg");

//myFunc(imageInDirectory);
//var stringPattern = new[] { "*jpeg", "*png", "*svg", "*WebP" };


/*foreach (string image in imageInDirectory)
{
    Console.WriteLine(image);
}*/
Task t = myFunc(imageInDirectory);
t.Wait();
static Bitmap SetGrayscale(Bitmap btmap)
{
    Bitmap temp = (Bitmap)btmap;
    Bitmap bmap = (Bitmap)temp.Clone();
    Color c;
    for (int i = 0; i < bmap.Width; i++)
    {
        for (int j = 0; j < bmap.Height; j++)
        {
            c = bmap.GetPixel(i, j);
            byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

            bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
        }
    }
    return (Bitmap)bmap.Clone();
}
async Task myFunc(string[] imageInDirectory)
{
    Console.WriteLine("async func");
    await Func(imageInDirectory);
}
Task Func(string[] imageInDirectory)
{
    Console.WriteLine("awaitfunc");
    return Task.Run(() =>
    {
        Bitmap[] bitmaps = new Bitmap[imageInDirectory.Length];
        for (int i = 0; i < imageInDirectory.Length; i++)
        {
            bitmaps[i] = new Bitmap(imageInDirectory[i]);
        }
        for (int i = 0; i < bitmaps.Length; i++)
        {
            bitmaps[i] = new Bitmap(bitmaps[i], new Size(260, bitmaps[i].Height));
            bitmaps[i] = SetGrayscale(bitmaps[i]);
            bitmaps[i].Save(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University\Viva_university_tasks\newImage" + $"{i}" + ".jpeg", ImageFormat.Jpeg);

        }
    });
}
/*Image image = Image.FromStream(File.OpenRead(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Tasks_Day5\Viva.jpeg"));
Console.WriteLine(image.Height);
Console.WriteLine(image.PixelFormat);*/
//ASYNC AWAIT
/*class MyClass
{
    public async static void SomeMethod()
    {
        Console.WriteLine("Some Method Started......");
        Wait();
        Console.WriteLine("Some Method End");
    }
    private static async void Wait()
    {
        await Task.Delay(TimeSpan.FromSeconds(10));
        Console.WriteLine("\n10 Seconds wait Completed\n");
    }
}*/


//--------------------------------------------Task 3-------------------------------------
