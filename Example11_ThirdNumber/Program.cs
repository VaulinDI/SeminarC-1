Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 99 && x < 1000) {
    Console.WriteLine("Третья цифра числа: " + (x % 10));
}
else if (x > 999 && x < 10000) {
    Console.WriteLine("Третья цифра числа: " + (x / 10 % 10));
}
else if (x > 9999 && x < 100000) {
    Console.WriteLine("Третья цифра числа: " + (x / 100 % 10));
}
else if (x > 99999 && x < 1000000) {
    Console.WriteLine("Третья цифра числа: " + (x / 1000 % 10));
}
else if (x > 999999 && x < 10000000) {
    Console.WriteLine("Третья цифра числа: " + (x / 10000 % 10));
}
else if (x > 9999999 && x < 100000000) {
    Console.WriteLine("Третья цифра числа: " + (x / 100000 % 10));
}
else if (x > 99999999 && x < 1000000000) {
    Console.WriteLine("Третья цифра числа: " + (x / 1000000 % 10));
}
else if (x > 999999999 && x < 10000000000) {
    Console.WriteLine("Третья цифра числа: " + (x / 10000000 % 10));
}
else if (x > 9999999999 && x < 100000000000) {
    Console.WriteLine("Третья цифра числа: " + (x / 100000000 % 10));
}
else if (x < 100) {
    Console.WriteLine("Третьей цифры в данном числе нет");
}
