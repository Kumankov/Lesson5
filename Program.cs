/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.*/
// [345, 897, 568, 234] -> 2

int Task34(int size)
{
int[] massive34 = new int[size];
int countEven=0;
for (int i=0; i< size; i++)
    {
        massive34[i] =  new Random().Next(100, 999);      
        if (massive34[i]%2==0) countEven = countEven+1;
        if (i==0) Console.Write($"[{massive34[i]},");
        else if (i==size-1) Console.WriteLine($"{massive34[i]}]");
        else Console.Write($"{massive34[i]},");           
    }
return countEven;
}
Console.WriteLine("Введите количество элементов массива для задачи 34");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество четных элементов: {Task34 (A)}");

/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.*/
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Task36(int size)
{
int[] massive36 = new int[size];
int sumOdd=0;
for (int i=0; i< size; i++)
    {
        massive36[i] =  new Random().Next(-99,99);      
        if (i%2>0) sumOdd = sumOdd+massive36[i];
        if (i==0) Console.Write($"[{massive36[i]},");
        else if (i==size-1) Console.WriteLine($"{massive36[i]}]");
        else Console.Write($"{massive36[i]},");           
    }
return sumOdd;
}
Console.WriteLine("Введите количество элементов массива для задачи 36");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {Task36 (B)}");

/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.*/
// [3 7 22 2 78] -> 76
// Два варианта заполнения массива: случайное или ручной ввод.
int Task38(int var, int size)
{
int[] massive38 = new int[size];
for (int i=0; i<size; i++)
    {
       if (var==1) massive38[i] =  new Random().Next(-99,99); 
       else  
        {
            Console.WriteLine($"Введите количество {i} элемент массива для задачи 38");
            massive38[i] = int.Parse(Console.ReadLine());      
        }    
    }
int min = massive38[0];
int max = massive38[0];    
for (int j=0; j<size; j++)
    {
        if (massive38[j]>max) max = massive38[j];
        if (massive38[j]<min) min = massive38[j];
        if (j==0) Console.Write($"[{massive38[j]},");
        else if (j==size-1) Console.WriteLine($"{massive38[j]}]");
        else Console.Write($"{massive38[j]},");       
    }    
return max-min;
}
Console.WriteLine("Введите вариант заполнения массива для задачи 38. 1 - случаные числа, иначе ручной ввод");
int C = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество элементов массива для задачи 38");
int D = int.Parse(Console.ReadLine());
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Task38(C,D)}");
