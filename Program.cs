using System;

namespace FirstHomeWork
{
    
    class Program
    {
        private const int LinesCount = 5;
        static void Main(string[] args)
        {
            Console.Clear();
            //直角三角形
            RightAngledTriangle();
            //等腰三角形
            IsocelesTriangle();
            //空心三角形
            OpenTriangle();
            //空心菱形
            OpenDiamond();
        }

        ///静态函数只能引用静态函数 static
        ///输出直角三角形
        static void RightAngledTriangle()
        {
            Console.WriteLine("输出直角三角形：");
            for (int i = 0; i < LinesCount; i++)
            {
                Console.WriteLine(new String('*', i + 1));
            }
        }
            ///输出等腰三角形  
        static void IsocelesTriangle()
        {
            Console.WriteLine("输出等腰三角形：");
            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < LinesCount - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
            Console.WriteLine();
            }
        }
       /// <summary>
       /// 输出空心三角形
       /// </summary>
        static void OpenTriangle()
        {
            Console.WriteLine("输出空心三角形：");
            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < LinesCount - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                if (i != LinesCount - 1)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                else
                {
                    for (int j = 0; j < 2 * LinesCount - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 输出空心菱形
        /// </summary>
        static void OpenDiamond()
        {
            Console.WriteLine("输出空心菱形：");
            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < LinesCount - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }
            for (int i = 1; i < LinesCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                {
                    for (int j = 0; j <= LinesCount - 1 - i; j++)
                    {
                        if (j == 0 || j == LinesCount - 1 - i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
