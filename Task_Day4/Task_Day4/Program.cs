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
MyService First = new MyService("First",1000,10,false);
Subcriber user1 = new Subcriber("37494831910", 1500, false, false, new DateTime(2023, 7, 25));
First.Active(ref user1);

public class MyService
{
    string name ;
    double price;
    int minDutartionFromActiveService ;
    bool hasInRouming;
    public MyService(string name,double price,int duration,bool hasInRoaming)
    {
        this.name = name;
        this.price = price;
        minDutartionFromActiveService = duration;
        this.hasInRouming = hasInRoaming;
    }
    public void Active(ref Subcriber user)
    {
        try
        {
            if (user == null)
                throw new Exception("User isn`t found!!");
            if (user.PhoneNum.Length != 11 || int.TryParse(user.PhoneNum, out _))
                throw new Exception("Inputing phone number isn`t valid phone number");
            if (EndDay(user.ExpirationDate) < MinDutartionFromActiveService)
                throw new Exception("Time exception");
            if (user.IsInRoaming)
                if (!HasInRouming)
                    throw new Exception("The service isn`t acvtive in roaming");
            if (user.IsServiceActive)
                throw new Exception("This Service is active now");
            if (user.Balance < Price)
            {
                BalanceNotEnough();
                throw new Exception("The balance in the account is not enough to activate the Service");
            }
            if (user.Balance - price < 0)
                throw new Exception("Hamakargi xndir");
            user.myBalance(user.Balance - price);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        user.myDate(DateTime.Now.AddDays(30));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The service successfully activeted");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{Name} Patety hajoxutyamb aktivacvel e ev ayn aktiv e minchev {user.ExpirationDate}");
        Console.WriteLine($"Dzer yntacik hashivy kazmum e {user.Balance} dr.");
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
    public string Name
    {
        get { return name; }
    }
    public double Price
    {
        get { return price; }
    }
    public int MinDutartionFromActiveService
    {
        get { return minDutartionFromActiveService;}
    }
    public bool HasInRouming
    {
        get { return hasInRouming; }
    }
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
    public void myBalance(double balance)
    {
        this.balance = balance;
    }
    public void myDate(DateTime date)
    {
        expirationDate = date;
    }
    public string PhoneNum { get { return phoneNum; } }
    public double Balance { get { return balance; } }
    public bool IsServiceActive { get { return isServiceActive; } }
    public bool IsInRoaming { get { return isInRoaming; } }
    public DateTime ExpirationDate { get { return expirationDate; } }
}