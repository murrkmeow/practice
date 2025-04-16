namespace addtask
{
    public class Rectangle
    {
        public int X { get; private set; } 
        public int Y { get; private set; } 
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void Resize(int newWidth, int newHeight)
        {
            Width = newWidth;
            Height = newHeight;
        }

        public static Rectangle Intersect(Rectangle r1, Rectangle r2)
        {
            int intersectX = Math.Max(r1.X, r2.X);
            int intersectY = Math.Max(r1.Y, r2.Y);
            int intersectWidth = Math.Min(r1.X + r1.Width, r2.X + r2.Width) - intersectX;
            int intersectHeight = Math.Min(r1.Y + r1.Height, r2.Y + r2.Height) - intersectY;
            
            if (intersectWidth > 0 && intersectHeight > 0)
            {
                return new Rectangle(intersectX, intersectY, intersectWidth, intersectHeight);
            }
            else
            {
                return null;
            }
        }

        public static Rectangle Union(Rectangle r1, Rectangle r2)
        {
            int unionX = Math.Min(r1.X, r2.X);
            int unionY = Math.Min(r1.Y, r2.Y);
            int unionWidth = Math.Max(r1.X + r1.Width, r2.X + r2.Width) - unionX;
            int unionHeight = Math.Max(r1.Y + r1.Height, r2.Y + r2.Height) - unionY;
            return new Rectangle(unionX, unionY, unionWidth, unionHeight);
        }

        public override string ToString()
        {
            return $"Rectangle(X: {X}, Y: {Y}, Width: {Width}, Height: {Height})";
        }
    }
}
