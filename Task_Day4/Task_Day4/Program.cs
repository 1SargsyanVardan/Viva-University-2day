//-------------------------Task 1----------------------
/*try
{
    string str = File.ReadAllText(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Task_Day4\MyFirstFile.txt");
    string newStr = str.ToUpper();
    File.WriteAllText(@"C:\Users\User\OneDrive\Рабочий стол\Viva-University-2day\Task_Days\MySecondFile.txt", newStr);
}
catch (FileNotFoundException e)
{
    //Console.WriteLine("File isn`t found");
    Console.WriteLine(e.Message);
}
catch (IOException)
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
/*while (true)
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
}*/

Subcriber user1 = new Subcriber("37494831910", 150, false, false, new DateTime(2023, 7, 25));
try
{
    if (user1 == null)
        throw new Exception("User isn`t found!!");
    if (user1.PhoneNum.Length != 11 || int.TryParse(user1.PhoneNum, out _))
        throw new Exception("Inputing phone number isn`t valid phone number");
    if (EndDay(user1.ExpirationDate) < 10)
        throw new Exception("Time exception");
    if (user1.IsInRoaming)
        throw new Exception("The service isn`t acvtive in roaming");
    if (user1.IsServiceActive)
        throw new Exception("This Service is active now");
    if (user1.Balance < 1000)
    {
        BalanceNotEnough();
        throw new Exception("The balance in the account is not enough to activate the Service");
    }
    Console.WriteLine("The service successfully activeted");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void BalanceNotEnough()
{
    Console.WriteLine("Hashvi vra chka bavarar gumar:  Hishecum Pateti arjeqn e 1000dr");
}

int EndDay(DateTime date)
{
    TimeSpan duration = date - DateTime.Now;
    return duration.Days;
}

public class Subcriber
{
    string? phoneNum;
    double balance;
    bool isInRoaming;
    bool isServiceActive;
    DateTime expirationDate;
    public Subcriber(string phoneNum,double balance,bool isInRoaming,bool isServiceActive,DateTime expirationDate)
    {
        this.phoneNum = phoneNum;
        this.balance = balance;
        this.isInRoaming = isInRoaming;
        this.isServiceActive = isServiceActive;
        this.expirationDate = expirationDate;
    }

    public string PhoneNum { get { return phoneNum; } }
    public double Balance { get { return balance; } }
    public bool IsServiceActive { get { return isServiceActive; } }
    public bool IsInRoaming { get { return isInRoaming; } }
    public DateTime ExpirationDate { get { return expirationDate; } }
}