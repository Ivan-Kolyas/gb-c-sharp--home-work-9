

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("enter a natural number greater than one 1:");
// int number = int.Parse(Console.ReadLine());

//metod of output of natural numbers from N to 1:
// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} not a natural number");
//     if (number == 0) return;
//     Console.Write("{0,4}", number);
//     NumberCounter (number - 1);
// }

// NumberCounter(number);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("enter the initial number M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("enter the initial number N:");

// int numberN = int.Parse(Console.ReadLine());


// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"the sum of natural elements in the interval from M to N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }

// GapNumberSum(numberM, numberN, 0);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m = InputNumbers("enter m: ");
// int n = InputNumbers("enter n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Akkerman function = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

