// See https://aka.ms/new-console-template for more information
string str = "Barev";
PrintDelegate print;
print = Barev;
print(str);
print.Invoke(str);
void Barev(string str) => Console.WriteLine(str);
delegate void PrintDelegate(string str);
