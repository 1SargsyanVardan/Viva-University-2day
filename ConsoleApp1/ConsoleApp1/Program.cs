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

/*ConsoleReadEvent isClicked = new ConsoleReadEvent("clicked");*/

//------------------------Task 3------------------------------------

int a = 10;
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
delegate int Operation(int x, int y);
