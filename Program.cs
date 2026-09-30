// Step 2
// class Program
// {
//     static void Main()
//     {
//         CountDown(5);
//     }

//     static void CountDown(int n)
//     {
//         if (n == 0)
//         {
//             return;
//         }

//         CountDown(n - 1);
//         Console.WriteLine(n);
//     }
// }

// Step 3
// class Program
// {
//     static void Main()
//     {
//         SumToN(4);
//     }

//     static int SumToN(int n)
//     {
//         Console.WriteLine($"Enter: {n}");

//         if (n == 1)
//             return 1;

//         int result = n + SumToN(n - 1);

//         Console.WriteLine($"Exit: {n}, result = {result}");

//         return result;
//     }
// }

// Step 4
// class Program
// {
//     static void Main()
//     {
//         CountDownWithDepth(3, 0);

//         Console.WriteLine();

//         CountDownWithDepth(5, 0);
//     }

//     static void CountDownWithDepth(int n, int depth)
//     {
//         Console.WriteLine($"{new string(' ', depth * 2)}Вызов: n={n}");

//         if (n == 0)
//             return;

//         CountDownWithDepth(n - 1, depth + 1);
//     }
// }

// Part 4
// Task A
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Sum: {SumDigits(4725)}");
//     }
//     static int SumDigits(int number)
//     {
//         if (number < 10)
//             return number;

//         return number % 10 + SumDigits(number / 10);
//     }
// }

// Task B
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Result: {Power(2, 5)}");
//     }

//     static int Power(int number, int power)
//     {
//         if (power == 0)
//             return 1;

//         return number * Power(number, power - 1);
//     }
// }

// Task C

// В первом методе Sum(n) вызывает сам себя с тем же значением что и до этого. N не меняется, поэтому 0 не станет

// Во втором методе оно просто увеличивается, и никогда не пойдет вспаять до 0, разве что достигнув переполнение int. Но даже этого мы не увидим, ошибка быстрее вылетит


// Final task
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a positive number: ");
//         int n = int.Parse(Console.ReadLine()!);

//         Console.WriteLine($"Number count: {CountDigits(n)}");
//         Console.WriteLine($"Num Sum: {SumDigits(n)}");
//         Console.WriteLine($"Max number: {MaxDigit(n)}");
//         Console.Write("Numbers: ");
//         PrintDigits(n);
//         Console.WriteLine();
//     }
//     static int CountDigits(int n)
//     {
//         if (n < 10)
//             return 1;

//         return 1 + CountDigits(n / 10);
//     }
//     static void PrintDigits(int n)
//     {
//         if (n < 10)
//         {
//             Console.Write(n + " ");
//             return;
//         }

//         PrintDigits(n / 10);
//         Console.Write(n % 10 + " ");
//     }
//     static int MaxDigit(int n)
//     {
//         if (n < 10)
//             return n;

//         int max = MaxDigit(n / 10);

//         if (n % 10 > max)
//             return n % 10;

//         return max;
//     }
//     static int SumDigits(int n)
//     {
//         if (n < 10)
//             return n;

//         return n % 10 + SumDigits(n / 10);
//     }
// }