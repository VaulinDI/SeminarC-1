int x = new Random().Next(10, 100);
int nsecond = x % 10;
int nfirst = (x - nsecond) / 10;
Console.WriteLine("Сгенерировано число: " + x);
Console.WriteLine("Вторая цифра числа: " + nsecond);
Console.WriteLine("Первая цифра числа: " + nfirst);
if (nsecond > nfirst) {
    Console.WriteLine("Наибольшая цифра числа: " + nsecond);
}
else {
    Console.WriteLine("Наибольшая цифра числа: " + nfirst);
}
