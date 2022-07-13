// 2. Даны два числа. Показать большее и меньшее число

int a = new Random().Next(-15, 20);
int b = new Random().Next(-20, 35);
int max = a;
int min = b;

if (b > max) max = b;
if (a < min) min = a;

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);