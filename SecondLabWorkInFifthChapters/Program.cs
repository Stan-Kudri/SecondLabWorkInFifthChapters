/*
Упражнение 5.1 Написать метод, возвращающий наибольшее из двух 
чисел. Входные параметры метода – два целых числа. Протестировать метод.

Упражнение 5.2 Написать метод, который меняет местами значения двух 
передаваемых параметров. Параметры передавать по ссылке. Протестировать 
метод.

Упражнение 5.3 Написать метод вычисления факториала числа, 
результат вычислений передавать в выходном параметре. Если метод отработал 
успешно, то вернуть значение true; если в процессе вычисления возникло 
переполнение, то вернуть значение false. Для отслеживания переполнения 
значения использовать блок checked.

Упражнение 5.4 Написать рекурсивный метод вычисления факториала 
числа.

Домашнее задание 5.1 Написать метод, который вычисляет НОД двух 
натуральных чисел (алгоритм Евклида). Написать метод с тем же именем, 
который вычисляет НОД трех натуральных чисел. 

Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий 
значение n-го числа ряда Фибоначчи. Ряд Фибоначчи – последовательность 
натуральных чисел 1, 1, 2, 3, 5, 8, 13… Для таких чисел верно соотношение 
Fk = Fk-1 + Fk-2 .
*/

/* var firstValue = int.Parse(Console.ReadLine());
var secondValue = int.Parse(Console.ReadLine());
Console.WriteLine($"{Factorial(firstValue, out int value)}    -  {value}");

Console.WriteLine($"Большее из двух значений {GreaterNumber(firstValue, secondValue)}");
SwapValue(ref firstValue,ref secondValue);
Console.WriteLine($"firstValue={firstValue}");
Console.WriteLine($"secondValue={secondValue}"); */

using SecondLabWorkInFifthChapters;

var firstValue = int.Parse(Console.ReadLine());
var secondValue = int.Parse(Console.ReadLine());
var thirdValue = int.Parse(Console.ReadLine());
var nOD = new EuclidAlgorithm();
Console.WriteLine(nOD.GreatestCommonDivisor(firstValue, secondValue, thirdValue));

int GreaterNumber(int firstV, int secondV) => Math.Max(firstV, secondV);

void SwapValue(ref int firstV, ref int secondV)
{
    var value = firstV;
    firstV = secondV;
    secondV = value;
}

bool Factorial(int number, out int value)
{
    value = 1;
    try
    {
        for (int i = 1; i <= number; i++)
        {
            checked
            {
                value *= i;
            }
        }
        return true;
    }
    catch
    {
        value = 0;
        return false;
    }
}

int FactorialRecursion(int number)
{
    if (number == 1)
        return 1;
    return number * FactorialRecursion(number - 1);
}

int FibonacciNumber(int number)
{
    if (number == 0)
        return 0;
    if (number == 1 || number == 2)
        return 1;
    return FibonacciNumber(number - 1) + FibonacciNumber(number-2);
}

