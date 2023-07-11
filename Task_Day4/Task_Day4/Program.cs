//-------------------------Task 1----------------------
/*try
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
}*/

//-------------------------Task 2----------------------


//first versia-------------------------------------

/*
Console.Write("(If your age between 18 and 40) Please input your age: ");
string? inputString = Console.ReadLine();

int age;
if (int.TryParse(inputString, out _))
{
    age = int.Parse(inputString);
    try
    {
        if (age < 18 || age > 40)
        {
            throw new ArgumentException("Age must be between 18 and 40.");
        }
        Console.WriteLine("Valided");

    }
    catch (ArgumentException e)

    {
        Console.WriteLine(e.Message);
    }
}
else
    Console.WriteLine("Input value is`t number");*/

//second versia-------------------------------------
while (true)
{
    Console.Write("(If your age between 18 and 40) Please input your age: ");
    string? inputString = Console.ReadLine();

    int age;
    try
    {
        age = int.Parse(inputString);
        if (age < 18 || age > 40)
        {
            throw new ArgumentException("Age must be between 18 and 40.");
        }
        Console.WriteLine("Valided!");
        break;
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}