using System;

namespace factory
{
    abstract class Figure
    {
        public int[,] geometry { get; set; }

        public abstract void Geometry();

        public RGB color { get; set; }

        public virtual void Draw(Figure figure)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (figure.geometry[i,j]==1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n"+figure.color);

        }
    }
}
