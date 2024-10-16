using Tyuiu.RyabtsevNE.Sprint2.Task0.V27.Lib;

DataService ds = new();
int x = 1305, y = 275;
Console.WriteLine("Исходные данные: ");
Console.WriteLine("x = 1305");
Console.WriteLine("y = 275");
Console.WriteLine("Результат: ");
Console.WriteLine(ds.GetCompareOperations(x, y));
Console.ReadKey();
