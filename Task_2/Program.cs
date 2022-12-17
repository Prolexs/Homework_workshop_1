/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("введите первое число ");
Console.WriteLine("введите второе число ");
Console.WriteLine("введите третье число ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if(A > max) max = A;
if(B > max) max = B;
if(C > max) max = C;
Console.WriteLine($"Максимальное значение равно: {max}");