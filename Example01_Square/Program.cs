int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
Console.WriteLine("Число a = " + a);
Console.WriteLine("Число b = " + b);
if (a == b * b) {
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}
else if (b == a * a) {
    Console.WriteLine("Число " + b + " является квадратом числа " + a);
}
else {
    Console.WriteLine("Число " + a + " не является квадратом числа " + b + " и число " + b + " не является квадратом числа " + a);
}