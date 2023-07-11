//-------------------------Task 1----------------------
try
{
    string str = File.ReadAllText(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Task_Day4\MyFirstFile.txt");
    string newStr = str.AllUpperCase();
    File.WriteAllText(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Task_Day4\MySecondFile.txt", newStr);
}
catch
{
    Console.WriteLine("File isn`t found");
}
finally
{
    Console.WriteLine("Finally block");
}
public static class StringExtension
{
    public static string AllUpperCase(this string str)
    {
        string[] strArray = str.Split(' ');
        for (int i = 0; i < strArray.Length; i++)
        {
            char ch = char.ToUpper(strArray[i][0]);
            string otherStr = strArray[i].Substring(1).ToLower();
            strArray[i] = ch + otherStr;
        }
        
        return string.Join(' ', strArray);
    }
}