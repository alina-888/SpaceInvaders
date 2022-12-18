using System;
using System.Threading;

namespace SpaceInvaders
{
    class Program
    {
        //don't need for now
        //static void DrawPlatform()
        //{
        //    Console.Write("■■■■");
        //}
        //got used to set cursor
        //    protected static void WriteAt(string s, int x, int y)
        //{
        //    Console.SetCursorPosition(x, y);
        //    //Console.ForegroundColor = ConsoleColor.DarkGreen;
        //    Console.Write(s);
        //}
        //protected static void WriteAtint(int s_int, int x_int, int y_int)
        //{
        //    Console.SetCursorPosition(x_int, y_int);
        //    //Console.ForegroundColor = ConsoleColor.DarkGreen;
        //    Console.Write(s_int);
        //}
        static void Main(string[] args)
        {
            //window view
            Console.SetWindowSize(50, 25);
                
            //comment this ↓ if you want to see the cursor
            //Console.CursorVisible = false;


            //draw targets
            Console.CursorLeft = 5;

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.CursorLeft, 5);
                Console.Write("■■■");
                Console.CursorLeft += 3;
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //draw character
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight - 5);
            Console.Write("■■■■");

            int alien1 = 5;
            int alien2 = 11;
            int alien3 = 17;

            //design            //add score!!!!
            int score  =  0;
            //Console.SetCursorPosition(Console.WindowWidth - 10, 1);
            //Console.Write("score:" + score);
            //Console.SetCursorPosition(Console.WindowWidth / 2 + 2, Console.WindowHeight - 5);

            //moving with arrows
            while (true)
            {
                
                // Thread.Sleep(200);
                ConsoleKeyInfo _Key = Console.ReadKey();
                switch (_Key.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft >= Console.WindowWidth)
                            break;
                        else
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
                            Console.Write("    ");
                            Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop);
                            Console.Write("■■■■");
                            
                        }
                            break;
                        
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft - 5 < 0)
                            break;
                        else
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 4, Console.CursorTop);
                            Console.Write("    ");
                            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
                            Console.Write("■■■■");
                            break;
                        }

                    case ConsoleKey.Spacebar:
                        //score
                        //score++;
                        //shooting
                        Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop - 1);
                        Console.Write("°");
                        while (Console.CursorTop != 0)
                        {
                            Thread.Sleep(50);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                            Console.Write("°");
                            if (Console.CursorTop < 6) {
                                if (Console.CursorLeft >= alien1 && Console.CursorLeft <= alien1 + 3)
                                {
                                    Console.CursorLeft = alien1 -1;
                                    Console.Write("BOOM");
                                    Thread.Sleep(300);
                                    Console.CursorLeft = alien1 - 1;
                                    Console.Write("    ");
                                    score++;
                                    break;
                                    // give points 
                                }

                                if (Console.CursorLeft >= alien2 && Console.CursorLeft <= alien2 + 3)
                                {
                                    Console.CursorLeft = alien2 - 1;
                                    Console.Write("BOOM");
                                    Thread.Sleep(100);
                                    Console.CursorLeft = alien2 - 1;
                                    Console.Write("    ");
                                    score++;
                                    break;
                                    // give points 
                                }

                                if (Console.CursorLeft >= alien3 && Console.CursorLeft <= alien3 + 3)
                                {
                                    Console.CursorLeft = alien3 - 1;
                                    Console.Write("BOOM");
                                    Thread.Sleep(100);
                                    Console.CursorLeft = alien3 - 1;
                                    Console.Write("    ");
                                    score++;
                                    break;
                                    // give points
                                }
                                if (score >= 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("YOU WIN!");
                                    Thread.Sleep(200);
                                    break;
                                }
                            }
                        }
                            
                       
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft + 1, Console.WindowHeight - 5);
                        break;
                }

            }
        }
    }
}

