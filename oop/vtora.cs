using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
   class Rectangle
{
    public int ID { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int TopLeftX { get; set; }
    public int TopLeftY { get; set; }

    public bool Intersects(Rectangle other)
    {
        int left1 = TopLeftX;
        int right1 = TopLeftX + Width;
        int top1 = TopLeftY;
        int bottom1 = TopLeftY + Height;

        int left2 = other.TopLeftX;
        int right2 = other.TopLeftX + other.Width;
        int top2 = other.TopLeftY;
        int bottom2 = other.TopLeftY + other.Height;

        if (left1 > right2 || right1 < left2 || top1 > bottom2 || bottom1 < top2)
            return false;

        return true;
    }
}
    internal class Program
    {   
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Rectangle[] rectangles = new Rectangle[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int id = int.Parse(input[0]);
                int width = int.Parse(input[1]);
                int height = int.Parse(input[2]);
                int topLeftX = int.Parse(input[3]);
                int topLeftY = int.Parse(input[4]);

                rectangles[i] = new Rectangle
                {
                    ID = id,
                    Width = width,
                    Height = height,
                    TopLeftX = topLeftX,
                    TopLeftY = topLeftY
                };
            }

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                int id1 = int.Parse(input[0]);
                int id2 = int.Parse(input[1]);

                Rectangle rect1 = FindRectangle(rectangles, id1);
                Rectangle rect2 = FindRectangle(rectangles, id2);

                bool intersects = rect1.Intersects(rect2);
                Console.WriteLine(intersects ? "true" : "false");
            }
        }
        static Rectangle FindRectangle(Rectangle[] rectangles, int id)
        {
            foreach (Rectangle rectangle in rectangles)
            {
                if (rectangle.ID == id)
                    return rectangle;
            }
            return null;
        }
    }
}
