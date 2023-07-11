//-------------------------Task 1----------------------
try
{
    string str = File.ReadAllText(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Task_Day4\MyFirstFile.txt");
    string newStr = str.ToUpper();
    File.WriteAllText(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Task_Day4\MySecondFile.txt", newStr);
}
catch(FileNotFoundException e)
{
    //Console.WriteLine("File isn`t found");
    Console.WriteLine(e.Message);
}
catch(IOException)
{
    Console.WriteLine("IOException");
}

finally
{
    Console.WriteLine("Finally block");
}