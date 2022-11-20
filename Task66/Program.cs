// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int GetSumNums(int indexNums1, int indexNums2)
{
    if (indexNums1 > indexNums2) 
        return 0;
    else
        return indexNums1 + GetSumNums(indexNums1+1, indexNums2);
}

Console.Write("Введите начальное значение ряда: ");
int indexNums1 = int.Parse(Console.ReadLine());

Console.Write("Введите конечное значение ряда: ");
int indexNums2 = int.Parse(Console.ReadLine());

if (indexNums1 > indexNums2) // Меняем местами "от" и "до", если "от" больше, чем "до"
{
    indexNums1 = indexNums2 + indexNums1;
    indexNums2 = indexNums1 - indexNums2;
    indexNums1 = indexNums1 - indexNums2;
}

int sumNums = GetSumNums(indexNums1, indexNums2);
Console.WriteLine($"M={indexNums1}; N={indexNums2}  ->  {sumNums}");

