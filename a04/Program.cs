// Найти максимальное из трех чисел

int a = 5;
int b = 15;
int c = 41;
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = " + max);