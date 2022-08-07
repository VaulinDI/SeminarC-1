int x = new Random().Next(1, 10); // Заданное число
Console.WriteLine("Заданное число: " + x);
Console.WriteLine("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine()); // Введенное число
if (y % x == 0) {
    Console.WriteLine("Введенное число кратно заданному");
}
else {    
    Console.WriteLine("Введенное число не кратно заданному. Остаток от деления равен: " + y % x);
}