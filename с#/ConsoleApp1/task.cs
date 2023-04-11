using System;

string[] arrIn = new string[0]; // Массив входных строк
string[] arrOut = new string[0]; // Массив выходных строк
string s = ""; // вводимая строка
int sizeIn = 0; // Размер входного массива
int sizeOut = 0; // Размер выходного массива

Console.WriteLine("Введите строки (пустая строка завершает ввод):");
s = Console.ReadLine();
while (s != "")
{
    sizeIn++;
    Array.Resize<string>(ref arrIn, sizeIn);
    arrIn[sizeIn - 1] = s;
    s = Console.ReadLine();
}

foreach (var item in arrIn)
{
    if (item.Length <= 3)
    {
        sizeOut++;
        Array.Resize<string>(ref arrOut, sizeOut);
        arrOut[sizeOut - 1] = item;
    }
}

Console.WriteLine("Результат:");
foreach(var item in arrOut)
{
    Console.WriteLine("{0}", item);
}