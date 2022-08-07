int a = new Random().Next(1, 1000);
int b = new Random().Next(1, 1000);
int c = new Random().Next(1, 1000);
Console.WriteLine("Число a = " + a);
Console.WriteLine("Число b = " + b);
Console.WriteLine("Число c = " + c);
if (a > b && a > c) {
    Console.WriteLine("Число " + a + " наибольшее из трех");
}
else if (b > a && b > c) {
    Console.WriteLine("Число " + b + " наибольшее из трех");
}
else if (c > a && c > b) {
    Console.WriteLine("Число " + c + " наибольшее из трех");
}