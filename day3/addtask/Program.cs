using System;

namespace addtask
{
    class Program
    {
        static void Main()
        {
            Rectangle rect1 = new Rectangle(0, 0, 5, 10);
            Rectangle rect2 = new Rectangle(3, 5, 7, 4);

            Console.WriteLine("Исходные прямоугольники:");
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);
            
            rect1.Move(2, 3);

            Console.WriteLine("\nПосле перемещения rect1:");
            Console.WriteLine(rect1);
            
            rect2.Resize(10, 6);

            Console.WriteLine("\nПосле изменения размеров rect2:");
            Console.WriteLine(rect2);
            
            Rectangle intersection = Rectangle.Intersect(rect1, rect2);

            Console.WriteLine("\nПересечение прямоугольников:");
            Console.WriteLine(intersection != null ? intersection.ToString() : "Пересечения нет");
            
            Rectangle union = Rectangle.Union(rect1, rect2);

            Console.WriteLine("\nОбъединяющий прямоугольник:");
            Console.WriteLine(union);
        }
    }
}
