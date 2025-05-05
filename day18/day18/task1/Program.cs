using System;
using GeometryLibrary;
using Bank;


class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
        Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
        Console.WriteLine($"Тип треугольника: {triangle.GetTriangleType()}");

        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");



        A obj = new A(1, 2);
        Console.WriteLine($"Сумма: {obj.Sum()}");
        Console.WriteLine($"Остаток: {obj.ModuloAssign()}");

        INotifyer notifier = new ConsoleNotifier();
        BankAccount account1 = new BankAccount("Сберегательный", 5000,notifier);
        account1.PrintInfo();

        account1.Deposit(1500);
        account1.Withdraw(2000);
        account1.Withdraw(5000); // Проверка на недостаточность средств

        BankAccount account2 = new BankAccount("Текущий", 3000, notifier);
        account2.PrintInfo();



       
}
}
