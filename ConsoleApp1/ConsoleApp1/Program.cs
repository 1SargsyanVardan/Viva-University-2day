using ConsoleApp1;

//------------------------Task 1------------------------------------
/*string str = "Barev";
PrintDelegate print;
print = Barev;
print(str);
print.Invoke(str);
void Barev(string str) => Console.WriteLine(str);
delegate void PrintDelegate(string str);*/

//------------------------Task 2------------------------------------

ConsoleReadEvent isClicked = new ConsoleReadEvent("asa");
isClicked.OnButtonClicked += DisplayMessage;
isClicked.isButtonClicked();
void DisplayMessage(string message) => Console.WriteLine(message);


//------------------------Task 3------------------------------------

/*int a = 10;
int b = 20;
Operation add = delegate (int x, int y)
{
    return x + y;
};
Operation sub = delegate (int x, int y)
{
    return a - b;
};
int addResult = add(a, b);
int subResult = sub(a, b);
Console.WriteLine($"{a} + {b} = {addResult}");
Console.WriteLine($"{a} - {b} = {subResult}");
delegate int Operation(int x, int y);*/

//------------------------Task 4------------------------------------

/*ComparisonDelegate comparing = (int x, int y) =>
{
    if (x == y)
        return 0;
    if (x > y)
        return 1;
    return -1;
};
int comp = comparing(7, 9);
Console.WriteLine(comp);

delegate int ComparisonDelegate(int x, int y);*/

//------------------------Task 5------------------------------------

/*Balance b = new Balance("094831910",850);
b.BalanceAdd("094831910", 1000);
Console.WriteLine("Mutq arvec 1000 dram");
*/