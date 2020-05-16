using System;
using System.Collections.Generic;
using System.Threading;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>()
            {
                new Figure1()/*{color=RGB.Yello*//*w}*/,
                //new Figure2/*{color=RGB.Red},*/
                new Figure3()/*{color=RGB.Blue}*//*,*/,
                new Figure4()/*{color=RGB.Green*//*},*/,
                new Figure5()/*{color=RGB.Red},*/,
                new Figure6()/*{color=RGB.Blue}*/,

            };

            foreach (var item in figures)
            {
                item.Draw(item);
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
    }
}
