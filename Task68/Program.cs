// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetFuncAkkerman(int numM, int numN)
{
    if (numM == 0) 
        return numN + 1;
    else if (numN == 0) 
        return GetFuncAkkerman(numM-1, 1);
    else
        return GetFuncAkkerman(numM-1, GetFuncAkkerman(numM, numN-1));
}

Console.Write("Введите не отрицательное число (m): ");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите не отрицательное число (n): ");
int numN = int.Parse(Console.ReadLine());

int funcAkkerman = GetFuncAkkerman(numM, numN);
Console.WriteLine($"m={numM}; n={numN}  ->  A(m,n)  ->  {funcAkkerman}");
