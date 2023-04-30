// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// Console.Write("Введите положительное натуральное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void OutputNaturalNums(int n) {
//     if(n > 1) {
//         Console.Write(n + "," + " ");
//     } else Console.Write(n);
//     if(n > 1) OutputNaturalNums(n - 1);
// }
// OutputNaturalNums(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Введите целое натуральное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое натуральное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumOfElements(int m, int n) {
//     int sum = 0;
//     // if(m == n) sum = m + n;
//     if(m > n ) {
//         sum = m + SumOfElements(m - 1, n);
//         if(m == n + 1) sum = sum + n;
//     }
//     if(m < n ) {
//         sum = m + SumOfElements(m + 1, n);
//         if(m == n - 1) sum = sum + n;
//     }
    
//     return sum;
// }
// int summa;
// if(m == n) {
//     summa = m + n;
// } else summa = SumOfElements(m,n);
// Console.WriteLine($"Сумма элементов между {m} и {n} = {summa}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Clear();

// int Akerman (int m, int n)
// {
//     if (m == 0) return n + 1;
//         else if (m != 0 && n == 0) return Akerman(m - 1, 1);
//                 else return Akerman(m - 1, Akerman(m, n - 1));    
// }
// Console.Write("Введите положительное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите положительное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"A({m},{n}) = {Akerman(m,n)}");