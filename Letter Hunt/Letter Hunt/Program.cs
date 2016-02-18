using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Media;



namespace Letter_Hunt
{
    class Program
    {
        static int level = 1, stage = 1, main_move_counter = 0;
        static bool snake_main = true;
        struct Location
        {
            public int X;
            public int Y;

            public Location(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
        static void start() // start animation
        {
            Console.CursorVisible = false;
            for (int i = 0; i < 29; i++)
            {
                Thread.Sleep(140);
                if (i % 2 == 0)
                { Console.ForegroundColor = ConsoleColor.Magenta; }
                if (i % 4 == 0)
                { Console.ForegroundColor = ConsoleColor.Yellow; }
                if (i % 6 == 0)
                { Console.ForegroundColor = ConsoleColor.Red; }


                Console.SetCursorPosition(1 + i, 1 + i);
                Console.WriteLine("            DDDDDDDD    EEEEEEEE   UU     UU");
                Console.SetCursorPosition(1 + i, 2 + i);
                Console.WriteLine("            DD   DDDD   EE         UU     UU");
                Console.SetCursorPosition(1 + i, 3 + i);
                Console.WriteLine("            DD     DDD  EE         UU     UU");
                Console.SetCursorPosition(1 + i, 4 + i);
                Console.WriteLine("            DD      DD  EEEEEEEE   UU     UU");
                Console.SetCursorPosition(1 + i, 5 + i);
                Console.WriteLine("            DD      DD  EEEEEEEE   UU     UU");
                Console.SetCursorPosition(1 + i, 6 + i);
                Console.WriteLine("            DD     DDD  EE         UUUUUUUUU");
                Console.SetCursorPosition(1 + i, 7 + i);
                Console.WriteLine("            DDDDDDDD    EEEEEEEE   UUUUUUUUU");

                Console.SetCursorPosition(70 - i, 1 + i);
                Console.WriteLine("DDDDDDDD    EEEEEEEE   UU     UU");
                Console.SetCursorPosition(70 - i, 2 + i);
                Console.WriteLine("DD   DDDD   EE         UU     UU");
                Console.SetCursorPosition(70 - i, 3 + i);
                Console.WriteLine("DD     DDD  EE         UU     UU");
                Console.SetCursorPosition(70 - i, 4 + i);
                Console.WriteLine("DD      DD  EEEEEEEE   UU     UU");
                Console.SetCursorPosition(70 - i, 5 + i);
                Console.WriteLine("DD      DD  EEEEEEEE   UU     UU");
                Console.SetCursorPosition(70 - i, 6 + i);
                Console.WriteLine("DD     DDD  EE         UUUUUUUUU");
                Console.SetCursorPosition(70 - i, 7 + i);
                Console.WriteLine("DDDDDDDD    EEEEEEEE   UUUUUUUUU");


                if (i == 28)
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(9 + i, 9 + i);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  DOKUZ EYLUL UNIVERSITY ENTERTAINMENT");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(9 + i, 9 + i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  DOKUZ EYLUL UNIVERSITY ENTERTAINMENT");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(9 + i, 9 + i);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("  DOKUZ EYLUL UNIVERSITY ENTERTAINMENT");
                    Thread.Sleep(600);

                }

            }

            Thread.Sleep(300);
        }
        static void firstscreen()  // main menu
        {


            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(12, 1);
            Console.Write(@"     _______..__   __.      ___       __  ___  _______ ");
            Console.SetCursorPosition(12, 2);
            Console.Write(@"    /       ||  \ |  |     /   \     |  |/  / |   ____|");
            Console.SetCursorPosition(12, 3);
            Console.Write(@"   |   (----`|   \|  |    /  ^  \    |  '  /  |  |__   ");
            Console.SetCursorPosition(12, 4);
            Console.Write(@"    \   \    |  . `  |   /  /_\  \   |    <   |   __|  ");
            Console.SetCursorPosition(12, 5);
            Console.Write(@".----)   |   |  |\   |  /  _____  \  |  .  \  |  |____ ");
            Console.SetCursorPosition(12, 6);
            Console.Write(@"|_______/    |__| \__| /__/     \__\ |__|\__\ |_______|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(50, 8);
            Console.Write("By Dokuz Eylul University");

            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 5; i < 16; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write("*");
            }

            for (int i = 65; i < 72; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.Write("*");
            }

            Console.SetCursorPosition(72, 4);
            Console.Write("@");

            Console.SetCursorPosition(21, 4);
            Console.Write("*");
            Console.SetCursorPosition(22, 4);
            Console.Write("*");
            Console.SetCursorPosition(23, 4);
            Console.Write("*");
            Console.SetCursorPosition(24, 4);
            Console.Write("*");
            Console.SetCursorPosition(34, 4);
            Console.Write("*");
            Console.SetCursorPosition(35, 4);
            Console.Write("*");
            Console.SetCursorPosition(36, 4);
            Console.Write("*");
            Console.SetCursorPosition(46, 4);
            Console.Write("*");
            Console.SetCursorPosition(47, 4);
            Console.Write("*");
            Console.SetCursorPosition(48, 4);
            Console.Write("*");
            Console.SetCursorPosition(55, 4);
            Console.Write("*");
            Console.SetCursorPosition(56, 4);
            Console.Write("*");
            Console.SetCursorPosition(57, 4);
            Console.Write("*");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(75, 4);
            Console.Write((char)1);
            Console.SetCursorPosition(12, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                 HELP                      ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                  PLAY                        LAST SCORE   ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                 EXIT             ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  Press Direction Key ( ↑ , ↓ , → , ← )    ");


            int posxmenu = Console.CursorLeft;
            int posymenu = Console.CursorTop;
            posxmenu = 10; posymenu = 23;
            Console.ForegroundColor = ConsoleColor.Magenta;

            firstscreencommand(posymenu, posxmenu);

        }

        private static void firstscreencommand(int posymenu, int posxmenu)  // Main menu commands
        {
            Console.SetCursorPosition(43, 16);
            Console.Write("  ");
            Console.SetCursorPosition(57, 16);
            Console.Write("  ");
            Console.SetCursorPosition(15, 16);
            Console.Write("►►");
            Console.SetCursorPosition(23, 16);
            Console.Write("◄◄");
            Console.SetCursorPosition(30, 13);
            Console.Write("  ");
            Console.SetCursorPosition(38, 13);
            Console.Write("  ");
            Console.SetCursorPosition(30, 20);
            Console.Write("  ");
            Console.SetCursorPosition(38, 20);
            Console.Write("  ");

            posxmenu = 10; posymenu = 23;
            bool consolmenu = true;
            ConsoleKeyInfo ckimenu;
            ckimenu = Console.ReadKey(true);
            if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 10) && (posymenu == 23))) // If user use enter key directly 
            {
                consolmenu = false;
                Console.Clear();
                gamelevels();
            }
            else
            {
                do
                {
                    ckimenu = Console.ReadKey(true);
                } while (ckimenu.Key != ConsoleKey.RightArrow && ckimenu.Key != ConsoleKey.LeftArrow && ckimenu.Key != ConsoleKey.UpArrow && ckimenu.Key != ConsoleKey.DownArrow);
            }

            while (consolmenu)
            {
                Thread.Sleep(50);

                if (Console.KeyAvailable)
                {
                    ckimenu = Console.ReadKey(true);
                    if (ckimenu.Key == ConsoleKey.RightArrow || ckimenu.Key == ConsoleKey.LeftArrow || ckimenu.Key == ConsoleKey.UpArrow || ckimenu.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(12, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                 HELP                                                            ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                  PLAY                        LAST SCORE       ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                       ");
                        Console.WriteLine("                                                   ");
                        Console.WriteLine("                                 EXIT                 ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                  Press Direction Key ( ↑ , ↓ , → , ← )            ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (ckimenu.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("►►");
                    Console.SetCursorPosition(57, 16);
                    Console.Write("◄◄");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(38, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 20);
                    Console.Write("  ");
                    Console.SetCursorPosition(38, 20);
                    Console.Write("  ");
                    posymenu = 10; posxmenu = 41;
                }
                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 41) && (posymenu == 10)))
                {
                    consolmenu = false;
                    Console.Clear();
                    last_score(ckimenu);
                }


                else if (ckimenu.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(57, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("►►");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("◄◄");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(38, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 20);
                    Console.Write("  ");
                    Console.SetCursorPosition(38, 20);
                    Console.Write("  ");

                    posxmenu = 10; posymenu = 23;
                }
                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 10) && (posymenu == 23)))
                {
                    consolmenu = false;
                    Console.Clear();
                    gamelevels();
                }


                else if (ckimenu.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(57, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("►►");
                    Console.SetCursorPosition(38, 13);
                    Console.Write("◄◄");
                    Console.SetCursorPosition(30, 20);
                    Console.Write("  ");
                    Console.SetCursorPosition(38, 20);
                    Console.Write("  ");
                    posxmenu = 8; posymenu = 33;
                }

                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 8) && (posymenu == 33)))
                {
                    Console.Clear();
                    help(ckimenu);
                }

                else if (ckimenu.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(57, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(38, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 20);
                    Console.Write("►►");
                    Console.SetCursorPosition(38, 20);
                    Console.Write("◄◄");
                    posxmenu = 12; posymenu = 30;
                }

                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 12) && (posymenu == 30)))
                {
                    Environment.Exit(1);
                }


            }


        }

        static int diff = 0;
        private static void gamelevels() // Game's difficulties
        {

            Console.SetCursorPosition(12, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                 NORMAL                    ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                  EASY                        HARD         ");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  Press Direction Key ( ↑ , ↓ , → , ← )            ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(43, 16);
            Console.Write("  ");
            Console.SetCursorPosition(57, 16);
            Console.Write("  ");
            Console.SetCursorPosition(15, 16);
            Console.Write("►►");
            Console.SetCursorPosition(23, 16);
            Console.Write("◄◄");
            Console.SetCursorPosition(30, 13);
            Console.Write("  ");
            Console.SetCursorPosition(40, 13);
            Console.Write("  ");
            Console.SetCursorPosition(30, 20);
            Console.Write("  ");
            Console.SetCursorPosition(40, 20);
            Console.Write("  ");
            int posxmenu = Console.CursorLeft;
            int posymenu = Console.CursorTop;
            posxmenu = 10; posymenu = 23;
            bool consolmenu = true;

            ConsoleKeyInfo ckimenu;
            ckimenu = Console.ReadKey(true);
            if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 10) && (posymenu == 23))) 
            {
                consolmenu = false;
                Console.Clear();
                diff = 100;
                firstgameboard();
            }
            else
            {
                do
                {
                    ckimenu = Console.ReadKey(true);
                } while (ckimenu.Key != ConsoleKey.RightArrow && ckimenu.Key != ConsoleKey.LeftArrow && ckimenu.Key != ConsoleKey.UpArrow);
            }
            while (consolmenu)
            {
                Thread.Sleep(50);

                if (Console.KeyAvailable)
                {
                    ckimenu = Console.ReadKey(true);
                    if (ckimenu.Key == ConsoleKey.RightArrow || ckimenu.Key == ConsoleKey.LeftArrow || ckimenu.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(12, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                 NORMAL                     ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                  EASY                        HARD         ");
                        Console.WriteLine("                                                           ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine("                                                  ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                  Press Direction Key ( ↑ , ↓ , → , ← )            ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (ckimenu.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("►►");
                    Console.SetCursorPosition(51, 16);
                    Console.Write("◄◄");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(40, 13);
                    Console.Write("  ");
                    posymenu = 10; posxmenu = 41;
                }
                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 41) && (posymenu == 10)))
                {
                    consolmenu = false;
                    Console.Clear();
                    diff = 50;
                    firstgameboard();
                }


                else if (ckimenu.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(51, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("►►");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("◄◄");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("  ");
                    Console.SetCursorPosition(40, 13);
                    Console.Write("  ");

                    posxmenu = 10; posymenu = 23;
                }
              

                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 10) && (posymenu == 23))) 
                {
                    consolmenu = false;
                    Console.Clear();
                    diff = 100;
                    firstgameboard();
                }


                else if (ckimenu.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(43, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(51, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(15, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(23, 16);
                    Console.Write("  ");
                    Console.SetCursorPosition(30, 13);
                    Console.Write("►►");
                    Console.SetCursorPosition(40, 13);
                    Console.Write("◄◄");
                    posxmenu = 8; posymenu = 33;
                }

                else if ((ckimenu.Key == ConsoleKey.Enter) && ((posxmenu == 8) && (posymenu == 33)))
                {
                    consolmenu = false;
                    Console.Clear();
                    diff = 80;
                    firstgameboard();
                }
            }

        }

        private static void help(ConsoleKeyInfo ckimenu)  // Help menu screen
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("          Use the arrow keys to move the snake");
            Console.WriteLine("          Eat words and complete idioms or proverb");
            Console.WriteLine("  If you hit the edges or try to eat itself,The game is over ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("          Press 'M' or 'BackSpace' key to back menu");
            Console.ResetColor();
            ckimenu = Console.ReadKey(true);
            if (ckimenu.Key == ConsoleKey.M || ckimenu.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                firstscreen();
            }
        }

        private static void last_score(ConsoleKeyInfo ckimenu)  // Help menu screen
        {
            StreamReader f = File.OpenText("Save.txt");
            string score_save = f.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                       Last Score");
            Console.WriteLine("                       ----------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                           " + score_save);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("          Press 'M' or 'BackSpace' key to back menu");
            Console.ResetColor();
            f.Close();
            ckimenu = Console.ReadKey(true);
            if (ckimenu.Key == ConsoleKey.M || ckimenu.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                firstscreen();
            }
        }

        static void firstgameboard()  // Gameboard construction stages
        {
            Console.ForegroundColor = ConsoleColor.White;

            if (level == 1 && stage == 1)
            {
                Console.SetCursorPosition(10, 2);
                Console.WriteLine(" _        _______  _______  ______  _________ _        _______ ");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("( \\      (  ___  )(  ___  )(  __  \\ \\__   __/( (    /|(  ____ \\");
                Console.SetCursorPosition(10, 4);
                Console.WriteLine("| (      | (   ) || (   ) || (  \\  )   ) (   |  \\  ( || (    \\/");
                Console.SetCursorPosition(10, 5);
                Console.WriteLine("| |      | |   | || (___) || |   ) |   | |   |   \\ | || |      ");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("| |      | |   | ||  ___  || |   | |   | |   | (\\ \\) || | ____ ");
                Console.SetCursorPosition(10, 7);
                Console.WriteLine("| |      | |   | || (   ) || |   ) |   | |   | | \\   || | \\_  )");
                Console.SetCursorPosition(10, 8);
                Console.WriteLine("| (____/\\| (___) || )   ( || (__/  )___) (___| )  \\  || (___) |");
                Console.SetCursorPosition(10, 9);
                Console.WriteLine("(_______/(_______)|/     \\|(______/ \\_______/|/    )_)(_______)");
                Console.SetCursorPosition(19, 12);
                Console.WriteLine(" _______  _______  _______  _______ ");
                Console.SetCursorPosition(19, 13);
                Console.WriteLine("(  ____ \\(  ___  )(       )(  ____ \\");
                Console.SetCursorPosition(19, 14);
                Console.WriteLine("| (    \\/| (   ) || () () || (    \\/");
                Console.SetCursorPosition(19, 15);
                Console.WriteLine("| |      | (___) || || || || (__    ");
                Console.SetCursorPosition(19, 16);
                Console.WriteLine("| | ____ |  ___  || |(_)| ||  __)   ");
                Console.SetCursorPosition(19, 17);
                Console.WriteLine("| | \\_  )| (   ) || |   | || (      ");
                Console.SetCursorPosition(19, 18);
                Console.WriteLine("| (___) || )   ( || )   ( || (____/\\");
                Console.SetCursorPosition(19, 19);
                Console.WriteLine("(_______)|/     \\||/     \\|(_______/");

                Console.SetCursorPosition(10, 23);
                for (int i = 0; i < 55; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.Write("*");
                    if (i == 54)
                    {
                        Console.SetCursorPosition(65, 22);
                        Console.Write("***");
                        Console.SetCursorPosition(65, 23);
                        Console.Write("****");
                        Console.SetCursorPosition(65, 24);
                        Console.Write("***");
                    }
                }
                Console.SetCursorPosition(10, 23);
                for (int i = 0; i < 55; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Thread.Sleep(20);
                    Console.Write("*");
                    if (i == 54)
                    {
                        Console.SetCursorPosition(65, 22);
                        Console.Write("***");
                        Console.SetCursorPosition(65, 23);
                        Console.Write("****  ");
                        Console.SetCursorPosition(65, 24);
                        Console.Write("***");
                    }
                }
                Thread.Sleep(40);
            }

            int countwalls = 0, upwall = 0, dx = 0, dy = 0;
            string[,] gameboard = new string[25, 60];
            bool maincountwalls = false;
            string upperwords = " ";
            string upperwords2 = " ";
            string betweenword = " ";

            Random random = new Random();
            do
            {
                maincountwalls = false;
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        if (j > 0 && i > 0 && i < 24 && j < 59)
                        { gameboard[i, j] = " "; }
                        else
                        { gameboard[i, j] = "#"; }
                    }
                }



                countwalls = 0;

                while (countwalls != 2 * level)  // wall in the array
                {


                    dx = random.Next(1, 24);
                    dy = random.Next(1, 59);
                    Console.SetCursorPosition(dx + 1, dy + 1);
                    upwall = random.Next(1, 5);

                    if (gameboard[dx, dy] == " " && gameboard[dx + 1, dy] == " " && gameboard[dx - 1, dy] == " " && gameboard[dx, dy + 1] == " " && gameboard[dx, dy - 1] == " " && gameboard[dx + 1, dy + 1] == " " && gameboard[dx - 1, dy - 1] == " " && gameboard[dx + 1, dy - 1] == " " && gameboard[dx - 1, dy + 1] == " ")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (upwall == 1)
                            {
                                if (gameboard[dx + i, dy] == " ")
                                {
                                    gameboard[dx + i, dy] = "#";
                                }
                                else
                                {
                                    if (gameboard[dx + i, dy] == "#" && dx + i > 0 && dx + i < 24 && dy > 0 && dy < 59)
                                        maincountwalls = true;
                                    else
                                    { break; }
                                }
                                if (gameboard[dx + i, dy - 1] == "#" || gameboard[dx + i, dy + 1] == "#")
                                    maincountwalls = true;
                                if (i == 9)
                                {
                                    if (gameboard[dx + 10, dy] == "#" || gameboard[dx + 10, dy - 1] == "#" || gameboard[dx + 10, dy + 1] == "#")
                                        maincountwalls = true;
                                }
                            }
                            else if (upwall == 2)
                            {
                                if (gameboard[dx, dy + i] == " ")
                                { gameboard[dx, dy + i] = "#"; }
                                else
                                {
                                    if (gameboard[dx, dy + i] == "#" && dx > 0 && dx < 24 && dy + i > 0 && dy + i < 59)
                                        maincountwalls = true;
                                    else
                                        break;
                                }
                                if (gameboard[dx + 1, dy + i] == "#" || gameboard[dx - 1, dy + i] == "#")
                                    maincountwalls = true;
                                if (i == 9)
                                {
                                    if (gameboard[dx, dy + 10] == "#" || gameboard[dx + 1, dy + 10] == "#" || gameboard[dx - 1, dy + 10] == "#")
                                        maincountwalls = true;
                                }
                            }

                            else if (upwall == 3)
                            {
                                if (gameboard[dx - i, dy] == " ")
                                { gameboard[dx - i, dy] = "#"; }
                                else
                                {
                                    if (gameboard[dx - i, dy] == "#" && dx - i > 0 && dx - i < 24 && dy > 0 && dy < 59)
                                    {
                                        maincountwalls = true;
                                    }
                                    else
                                        break;
                                }

                                if (gameboard[dx - i, dy - 1] == "#" || gameboard[dx - i, dy + 1] == "#")
                                    maincountwalls = true;
                                if (i == 9)
                                {
                                    if (gameboard[dx - 10, dy] == "#" || gameboard[dx - 10, dy - 1] == "#" || gameboard[dx - 10, dy + 1] == "#")
                                        maincountwalls = true;
                                }


                            }
                            else if (upwall == 4)
                            {
                                if (gameboard[dx, dy - i] == " ")
                                { gameboard[dx, dy - i] = "#"; }
                                else
                                {
                                    if (gameboard[dx, dy - i] == "#" && dx > 0 && dx < 24 && dy - i > 0 && dy - i < 59)
                                        maincountwalls = true;
                                    else
                                        break;


                                    if (gameboard[dx + 1, dy - i] == "#" || gameboard[dx - 1, dy - i] == "#")
                                        maincountwalls = true;
                                    if (i == 9)
                                    {
                                        if (gameboard[dx, dy - 10] == "#" || gameboard[dx + 1, dy - 10] == "#" || gameboard[dx - 1, dy - 10] == "#")
                                            maincountwalls = true;
                                    }
                                }
                            }
                        }
                    }
                    else
                        maincountwalls = true;
                    countwalls++;
                }
            } while (maincountwalls == true);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string[] alfabe = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            for (int i = 0; i < 29; i++)
            {

                do
                {

                    dx = random.Next(1, 24);
                    dy = random.Next(1, 59);
                } while (gameboard[dx, dy] != " ");

                gameboard[dx, dy] = alfabe[i];

            }



            System.IO.StreamReader f = File.OpenText("statements\\statements.txt");  // statements.txt include idioms
            string[] idiom = new string[20];
            string[] idiomson = new string[5];
            int randomidiom = 0;
            string string_level = Convert.ToString(level);

            do
            {
                for (int i = 0; i < 20; i++)
                {
                    idiom[i] = f.ReadLine();
                }


            } while (!f.EndOfStream);



            int counteridiom = 0;
            for (int i = 0; i < 20; i++)
            {
                if (idiom[i].Substring(0, 1) == string_level)
                {
                    idiomson[counteridiom] = idiom[i];
                    counteridiom++;
                }
            }

            int movecounter = 0;

            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                randomidiom = random.Next(0, 5);
                upperwords2 = idiomson[randomidiom].ToUpper();
            } while (upperwords2 == betweenword);
            betweenword = upperwords2;
            upperwords = upperwords2;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(62, 1);
            Console.WriteLine("   D.E.Ü. C.S.");
            Console.SetCursorPosition(62, 2);
            Console.Write("----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(62, 4);
            Console.WriteLine(upperwords.Substring(2));
            Console.SetCursorPosition(62, 5);
            Console.Write("----------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(62, 7);
            Console.Write("LEVEL: " + level);
            Console.SetCursorPosition(62, 9);
            Console.Write("STAGE: " + stage);
            Console.ForegroundColor = ConsoleColor.Black;

            if (level == 1)
            { Console.SetCursorPosition(62, 11); Console.WriteLine("TWO-WORDED IDIOMS"); }
            if (level == 2)
            { Console.SetCursorPosition(62, 11); Console.WriteLine("THREE-WORDED IDIOMS"); }
            if (level == 3)
            { Console.SetCursorPosition(62, 11); Console.WriteLine("FOUR-WORDED IDIOMS"); }
            if (level == 4)
            { Console.SetCursorPosition(62, 11); Console.WriteLine("PROVERB"); }
            Console.ForegroundColor = ConsoleColor.DarkBlue;



            for (int i = 2; i < upperwords.Length; i++)
            {
                dx = random.Next(1, 24);
                dy = random.Next(1, 59);
                if (gameboard[dx, dy] != " ")
                {
                    do
                    {

                        dx = random.Next(1, 24);
                        dy = random.Next(1, 59);
                    } while (gameboard[dx, dy] != " ");

                }

                gameboard[dx, dy] = upperwords.Substring(i, 1);

            }


            for (int i = 0; i < 5; i++)
            {
                idiomson[i] = "";
            }
            upperwords = upperwords.Remove(0, 2);
            for (int i = 0; i < upperwords.Length; i++)
            {
                if (upperwords.Substring(i, 1) == " ")
                {
                    upperwords = upperwords.Remove(i, 1);
                }

            }





            Snake(ref gameboard, ref upperwords, ref movecounter);
        }

        public static void Snake(ref string[,] gameboard, ref string upperwords, ref int movecounter)  // snake's shape
        {
            Random random = new Random();





            string snake2 = "%", artı = "+", snake = "";
            snake = snake2 + artı;
            Console.SetCursorPosition(11, 26);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press Direction Key ( ↑ , ↓ , → , ← )            ");


            Playgameboard(ref gameboard, ref upperwords, ref snake, ref snake2, ref artı, ref movecounter);

        }

        public static void Playgameboard(ref string[,] gameboard, ref string upperwords, ref string snake, ref string snake2, ref string artı, ref int movecounter)
        {

            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (gameboard[i, j] == "#")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(gameboard[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(gameboard[i, j]);
                    }

                }
                Console.WriteLine();

            }


            StartSnake(ref gameboard, ref upperwords, ref snake, ref snake2, ref artı, ref movecounter);




        }
        // snake's motions
        public static void StartSnake(ref string[,] gameboard, ref string upperwords, ref string snake, ref string snake2, ref string artı, ref int movecounter)
        {
            while (snake_main)
            {


                bool controlmove = true;
                bool yenenharf = true;
                Random random = new Random();

                int headsnakex = random.Next(3, 59); // snake's location by randomly
                int headsnakey = random.Next(3, 24); 
                while (gameboard[headsnakey, headsnakex] != " " || gameboard[headsnakey, headsnakex - 1] != " " || gameboard[headsnakey, headsnakex + 1] != " ")
                {
                    headsnakex = random.Next(3, 59);
                    headsnakey = random.Next(3, 24);
                }


                Location head = new Location(headsnakex, headsnakey);
                Location head2 = new Location(headsnakex - 1, headsnakey);
                Location[] snake33 = new Location[100];
                snake33[0] = head;
                snake33[1] = head2;

                Location next;

                for (int i = 0; i < snake33.Length; i++)
                {
                    if (snake33[i].X == 0 && snake33[i].Y == 0)
                        break;
                    Console.SetCursorPosition(snake33[i].X, snake33[i].Y);
                    gameboard[snake33[i].Y, snake33[i].X] = "" + snake[i];
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(snake[i]);
                }
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey(true);
                } while (cki.Key != ConsoleKey.RightArrow && cki.Key != ConsoleKey.UpArrow && cki.Key != ConsoleKey.DownArrow);

                while (controlmove)
                {

                    movecounter++;
                    main_move_counter++;
                    if (cki.Key == ConsoleKey.RightArrow)
                    {
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo cki2 = Console.ReadKey(true);
                            if (cki2.Key == ConsoleKey.UpArrow || cki2.Key == ConsoleKey.DownArrow)
                            { cki = cki2; }
                        }
                    }

                    else if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo cki2 = Console.ReadKey(true);
                            if (cki2.Key == ConsoleKey.UpArrow || cki2.Key == ConsoleKey.DownArrow)
                            { cki = cki2; }
                        }
                    }


                    else if (cki.Key == ConsoleKey.UpArrow)
                    {
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo cki2 = Console.ReadKey(true);
                            if (cki2.Key == ConsoleKey.RightArrow || cki2.Key == ConsoleKey.LeftArrow)
                            { cki = cki2; }
                        }
                    }

                    else if (cki.Key == ConsoleKey.DownArrow)
                    {

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo cki2 = Console.ReadKey(true);
                            if (cki2.Key == ConsoleKey.RightArrow || cki2.Key == ConsoleKey.LeftArrow)
                            { cki = cki2; }
                        }
                    }


                    snake = snake2 + artı;


                    next = snake33[0];
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    // show snake
                    for (int i = 0; i < snake33.Length; i++)
                    {
                        if (snake33[i].X == 0 && snake33[i].Y == 0)
                            break;
                        Console.SetCursorPosition(snake33[i].X, snake33[i].Y);
                        gameboard[snake33[i].Y, snake33[i].X] = "" + snake[i];
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(snake[i]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    // handle input
                    Thread.Sleep(diff);


                    switch (cki.Key)
                    {
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.UpArrow:
                            if (next.Y > 0)
                                next.Y--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (next.Y < 25)
                                next.Y++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (next.X > 0)
                                next.X--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (next.X < 60)
                                next.X++;
                            break;
                    }

                    for (int i = snake33.Length - 2; i > -1; i--)
                    {
                        snake33[i + 1] = snake33[i];
                    }
                    snake33[0] = next;
                    for (int i = 1; i < snake33.Length; i++)
                    {
                        if (snake33[i].X == 0 && snake33[i].Y == 0)
                            break;
                        if (snake33[0].X == snake33[i].X && snake33[0].Y == snake33[i].Y)
                        {
                            SoundPlayer over = new SoundPlayer();
                            over.SoundLocation = "sounds\\gameover.wav";
                            over.Play();
                            for (int k = 0; k < 8; k++)
                            {


                                for (int j = 0; j < 8; j++)
                                {
                                    System.Threading.Thread.Sleep(50);
                                    Console.SetCursorPosition(snake33[i].X, snake33[0].Y);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("GAME OVER");


                                }
                                System.Threading.Thread.Sleep(50);
                                Console.SetCursorPosition(snake33[i].X, snake33[0].Y);
                                Console.WriteLine("         ");
                            }

                            SoundPlayer robocop = new SoundPlayer();
                            robocop.SoundLocation = "sounds\\robocop2.wav";
                            robocop.Play();
                            Console.Clear();
                            Console.ResetColor();

                            Thread.Sleep(800);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(22, 2);
                            Console.WriteLine(" _______  _______  _______  _______ ");
                            Console.SetCursorPosition(22, 3);
                            Console.WriteLine("(  ____ \\(  ___  )(       )(  ____ \\");
                            Console.SetCursorPosition(22, 4);
                            Console.WriteLine("| (    \\/| (   ) || () () || (    \\/");
                            Console.SetCursorPosition(22, 5);
                            Console.WriteLine("| |      | (___) || || || || (__    ");
                            Console.SetCursorPosition(22, 6);
                            Console.WriteLine("| | ____ |  ___  || |(_)| ||  __)   ");
                            Console.SetCursorPosition(22, 7);
                            Console.WriteLine("| | \\_  )| (   ) || |   | || (      ");
                            Console.SetCursorPosition(22, 8);
                            Console.WriteLine("| (___) || )   ( || )   ( || (____/\\");
                            Console.SetCursorPosition(22, 9);
                            Console.WriteLine("(_______)|/     \\||/     \\|(_______/");
                            Console.SetCursorPosition(22, 12);
                            Console.WriteLine(" _______           _______  _______ ");
                            Console.SetCursorPosition(22, 13);
                            Console.WriteLine("(  ___  )|\\     /|(  ____ \\(  ____ )");
                            Console.SetCursorPosition(22, 14);
                            Console.WriteLine("| (   ) || )   ( || (    \\/| (    )|");
                            Console.SetCursorPosition(22, 15);
                            Console.WriteLine("| |   | || |   | || (__    | (____)|");
                            Console.SetCursorPosition(22, 16);
                            Console.WriteLine("| |   | |( (   ) )|  __)   |     __)");
                            Console.SetCursorPosition(22, 17);
                            Console.WriteLine("| |   | | \\ \\_/ / | (      | (\\ (   ");
                            Console.SetCursorPosition(22, 18);
                            Console.WriteLine("| (___) |  \\   /  | (____/\\| ) \\ \\__");
                            Console.SetCursorPosition(22, 19);
                            Console.WriteLine("(_______)   \\_/   (_______/|/   \\__/");
                            Console.SetCursorPosition(14, 25);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Your Score: " + main_move_counter);
                            StreamWriter f = File.CreateText("Save.txt");
                            f.WriteLine(main_move_counter);
                            Console.WriteLine();
                            Console.SetCursorPosition(14, 27);
                            Console.WriteLine("Score has been saved.");
                            Console.WriteLine();
                            Console.SetCursorPosition(14, 29);
                            Console.WriteLine("Good Bye!");
                            f.Close();
                            stage = 1;
                            level = 1;
                            main_move_counter = 0;
                            Console.SetCursorPosition(10, 23);
                            for (int j = 0; j < 55; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.Write("*");
                                if (j == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }
                            Console.SetCursorPosition(10, 23);
                            for (int j = 0; j < 55; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Thread.Sleep(40);
                                Console.Write("*");
                                if (j == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****  ");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }
                            Thread.Sleep(40);
                            firstscreen(); controlmove = false; break;
                        }

                    }
                    int noktatut = 0;
                    if (gameboard[next.Y, next.X] != " ")
                    {
                        if (gameboard[next.Y, next.X] != "#")
                        {
                            if (upperwords.Substring(snake2.Length - 1, 1) == gameboard[next.Y, next.X])
                            {

                                snake2 = snake2.Insert(snake2.Length, gameboard[next.Y, next.X]);
                                yenenharf = false;
                            }
                            if (yenenharf == true)
                            {
                                movecounter = movecounter + 40;
                                main_move_counter = main_move_counter + 40;
                                artı = artı.Insert(artı.Length, gameboard[next.Y, next.X]);
                                bool tekrar_atama = false;
                                do
                                {
                                    int tekrar_atama_x; int tekrar_atama_y;
                                    tekrar_atama_x = random.Next(1, 24);
                                    tekrar_atama_y = random.Next(1, 59);
                                    if (gameboard[tekrar_atama_x, tekrar_atama_y] == " ")
                                    {
                                        gameboard[tekrar_atama_x, tekrar_atama_y] = gameboard[next.Y, next.X];
                                        Console.SetCursorPosition(tekrar_atama_y, tekrar_atama_x);
                                        Console.Write(gameboard[next.Y, next.X]);
                                        tekrar_atama = true; break;
                                    }
                                } while (tekrar_atama == false);
                            }
                            yenenharf = true;
                            snake = snake2 + artı;
                            for (int i = 0; i < snake33.Length; i++)
                            {
                                if (snake33[i].X == 0 && snake33[i].Y == 0)
                                    break;
                                Console.SetCursorPosition(snake33[i].X, snake33[i].Y);
                                gameboard[snake33[i].Y, snake33[i].X] = "" + snake[i];
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(snake[i]);
                                noktatut = i;
                            }
                        }
                        else
                        {
                            SoundPlayer over = new SoundPlayer();
                            over.SoundLocation = "sounds\\gameover.wav";
                            over.Play();

                            for (int k = 0; k < 8; k++)
                            {


                                for (int j = 0; j < 8; j++)
                                {
                                    System.Threading.Thread.Sleep(50);
                                    Console.SetCursorPosition(snake33[noktatut].X, snake33[0].Y);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("GAME OVER");

                                }
                                System.Threading.Thread.Sleep(50);
                                Console.SetCursorPosition(snake33[noktatut].X, snake33[0].Y);
                                Console.WriteLine("         ");
                            }
                            SoundPlayer robocop = new SoundPlayer();
                            robocop.SoundLocation = "sounds\\robocop2.wav";
                            robocop.Play();
                            Console.Clear();
                            Console.ResetColor();
                            Thread.Sleep(800);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(22, 2);
                            Console.WriteLine(" _______  _______  _______  _______ ");
                            Console.SetCursorPosition(22, 3);
                            Console.WriteLine("(  ____ \\(  ___  )(       )(  ____ \\");
                            Console.SetCursorPosition(22, 4);
                            Console.WriteLine("| (    \\/| (   ) || () () || (    \\/");
                            Console.SetCursorPosition(22, 5);
                            Console.WriteLine("| |      | (___) || || || || (__    ");
                            Console.SetCursorPosition(22, 6);
                            Console.WriteLine("| | ____ |  ___  || |(_)| ||  __)   ");
                            Console.SetCursorPosition(22, 7);
                            Console.WriteLine("| | \\_  )| (   ) || |   | || (      ");
                            Console.SetCursorPosition(22, 8);
                            Console.WriteLine("| (___) || )   ( || )   ( || (____/\\");
                            Console.SetCursorPosition(22, 9);
                            Console.WriteLine("(_______)|/     \\||/     \\|(_______/");
                            Console.SetCursorPosition(22, 12);
                            Console.WriteLine(" _______           _______  _______ ");
                            Console.SetCursorPosition(22, 13);
                            Console.WriteLine("(  ___  )|\\     /|(  ____ \\(  ____ )");
                            Console.SetCursorPosition(22, 14);
                            Console.WriteLine("| (   ) || )   ( || (    \\/| (    )|");
                            Console.SetCursorPosition(22, 15);
                            Console.WriteLine("| |   | || |   | || (__    | (____)|");
                            Console.SetCursorPosition(22, 16);
                            Console.WriteLine("| |   | |( (   ) )|  __)   |     __)");
                            Console.SetCursorPosition(22, 17);
                            Console.WriteLine("| |   | | \\ \\_/ / | (      | (\\ (   ");
                            Console.SetCursorPosition(22, 18);
                            Console.WriteLine("| (___) |  \\   /  | (____/\\| ) \\ \\__");
                            Console.SetCursorPosition(22, 19);
                            Console.WriteLine("(_______)   \\_/   (_______/|/   \\__/");
                            Console.SetCursorPosition(14, 25);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Your Score: " + main_move_counter);
                            StreamWriter f = File.CreateText("Save.txt");
                            f.WriteLine(main_move_counter);
                            Console.WriteLine();
                            Console.SetCursorPosition(14, 27);
                            Console.WriteLine("Score has been saved.");
                            Console.WriteLine();
                            Console.SetCursorPosition(14, 29);
                            Console.WriteLine("Good Bye!");
                            f.Close();
                            stage = 1;
                            level = 1;
                            main_move_counter = 0;
                            Console.SetCursorPosition(10, 23);
                            for (int i = 0; i < 55; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.Write("*");
                                if (i == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }

                            Console.SetCursorPosition(10, 23);
                            for (int i = 0; i < 55; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Thread.Sleep(40);
                                Console.Write("*");
                                if (i == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****  ");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }
                            Thread.Sleep(40);
                            firstscreen(); controlmove = false; break;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < snake33.Length; i++)
                        {
                            if (snake33[i].X == 0 && snake33[i].Y == 0)
                            {
                                gameboard[snake33[i - 1].Y, snake33[i - 1].X] = " ";
                                Console.SetCursorPosition(snake33[i - 1].X, snake33[i - 1].Y);
                                Console.Write(" ");
                                Location remove = new Location(0, 0);
                                snake33[i - 1] = remove;
                                break;
                            }
                        }

                        for (int i = 0; i < snake33.Length; i++)
                        {
                            if (snake33[i].X == 0 && snake33[i].Y == 0)
                                break;
                            Console.SetCursorPosition(snake33[i].X, snake33[i].Y);
                            gameboard[snake33[i].Y, snake33[i].X] = "" + snake[i];
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(snake[i]);
                        }
                    }
                   

                    Console.SetCursorPosition(62, 14);
                    Console.Write("MOVE: " + movecounter);
                    Console.SetCursorPosition(62, 16);
                    Console.Write("TOTAL MOVE: " + main_move_counter);

                    if (snake2.Length - 1 == upperwords.Length)
                    {
                        Thread.Sleep(2000);
                        Console.Clear();

                        if (stage == 1)
                        {
                            stage++;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(22, 2);
                            Console.WriteLine(" _        _______          _________");
                            Console.SetCursorPosition(22, 3);
                            Console.WriteLine("( (    /|(  ____ \\|\\     /|\\__   __/");
                            Console.SetCursorPosition(22, 4);
                            Console.WriteLine("|  \\  ( || (    \\/( \\   / )   ) (   ");
                            Console.SetCursorPosition(22, 5);
                            Console.WriteLine("|   \\ | || (__     \\ (_) /    | |   ");
                            Console.SetCursorPosition(22, 6);
                            Console.WriteLine("| (\\ \\) ||  __)     ) _ (     | |   ");
                            Console.SetCursorPosition(22, 7);
                            Console.WriteLine("| | \\   || (       / ( ) \\    | |   ");
                            Console.SetCursorPosition(22, 8);
                            Console.WriteLine("| )  \\  || (____/\\( /   \\ )   | |   ");
                            Console.SetCursorPosition(22, 9);
                            Console.WriteLine("|/    )_)(_______/|/     \\|   )_(   ");
                            Console.SetCursorPosition(17, 12);
                            Console.WriteLine(" _______ _________ _______  _______  _______ ");
                            Console.SetCursorPosition(17, 13);
                            Console.WriteLine("(  ____ \\\\__   __/(  ___  )(  ____ \\(  ____ \\");
                            Console.SetCursorPosition(17, 14);
                            Console.WriteLine("| (    \\/   ) (   | (   ) || (    \\/| (    \\/");
                            Console.SetCursorPosition(17, 15);
                            Console.WriteLine("| (_____    | |   | (___) || |      | (__    ");
                            Console.SetCursorPosition(17, 16);
                            Console.WriteLine("(_____  )   | |   |  ___  || | ____ |  __)   ");
                            Console.SetCursorPosition(17, 17);
                            Console.WriteLine("      ) |   | |   | (   ) || | \\_  )| (      ");
                            Console.SetCursorPosition(17, 18);
                            Console.WriteLine("/\\____) |   | |   | )   ( || (___) || (____/\\");
                            Console.SetCursorPosition(17, 19);
                            Console.WriteLine("\\_______)   )_(   |/     \\|(_______)(_______/");

                            Console.SetCursorPosition(10, 23);
                            for (int i = 0; i < 55; i++)
                            {


                                Console.Write("*");
                                if (i == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }

                            Console.SetCursorPosition(10, 23);
                            for (int i = 0; i < 55; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Thread.Sleep(20);
                                Console.Write("*");
                                if (i == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****  ");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }
                            Thread.Sleep(40);
                        }
                        else if (stage == 2)
                        {
                            stage = 1;
                            level++;

                            if (level == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(14, 2);
                                Console.WriteLine("_________          _______    _______  _        ______  ");
                                Console.SetCursorPosition(14, 3);
                                Console.WriteLine("\\__   __/|\\     /|(  ____ \\  (  ____ \\( (    /|(  __  \\ ");
                                Console.SetCursorPosition(14, 4);
                                Console.WriteLine("   ) (   | )   ( || (    \\/  | (    \\/|  \\  ( || (  \\  )");
                                Console.SetCursorPosition(14, 5);
                                Console.WriteLine("   | |   | (___) || (__      | (__    |   \\ | || |   ) |");
                                Console.SetCursorPosition(14, 6);
                                Console.WriteLine("   | |   |  ___  ||  __)     |  __)   | (\\ \\) || |   | |");
                                Console.SetCursorPosition(14, 7);
                                Console.WriteLine("   | |   | (   ) || (        | (      | | \\   || |   ) |");
                                Console.SetCursorPosition(14, 8);
                                Console.WriteLine("   | |   | )   ( || (____/\\  | (____/\\| )  \\  || (__/  )");
                                Console.SetCursorPosition(14, 9);
                                Console.WriteLine("   )_(   |/     \\|(_______/  (_______/|/    )_)(______/ ");
                                Console.SetCursorPosition(14, 15);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Your Score: " + main_move_counter);
                                StreamWriter f = File.CreateText("Save.txt"); // save last score
                                f.WriteLine(main_move_counter);
                                Console.WriteLine();
                                Console.SetCursorPosition(14, 19);
                                Console.WriteLine(" Score has been saved.");
                                Console.WriteLine();
                                Console.SetCursorPosition(14, 22);
                                Console.WriteLine(" Good Bye!");
                                f.Close();

                                Console.ReadKey();
                                firstscreen();
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(22, 2);
                            Console.WriteLine(" _        _______          _________");
                            Console.SetCursorPosition(22, 3);
                            Console.WriteLine("( (    /|(  ____ \\|\\     /|\\__   __/");
                            Console.SetCursorPosition(22, 4);
                            Console.WriteLine("|  \\  ( || (    \\/( \\   / )   ) (   ");
                            Console.SetCursorPosition(22, 5);
                            Console.WriteLine("|   \\ | || (__     \\ (_) /    | |   ");
                            Console.SetCursorPosition(22, 6);
                            Console.WriteLine("| (\\ \\) ||  __)     ) _ (     | |   ");
                            Console.SetCursorPosition(22, 7);
                            Console.WriteLine("| | \\   || (       / ( ) \\    | |   ");
                            Console.SetCursorPosition(22, 8);
                            Console.WriteLine("| )  \\  || (____/\\( /   \\ )   | |   ");
                            Console.SetCursorPosition(22, 9);
                            Console.WriteLine("|/    )_)(_______/|/     \\|   )_(   ");
                            Console.SetCursorPosition(19, 12);
                            Console.WriteLine(" _        _______           _______  _   ");
                            Console.SetCursorPosition(19, 13);
                            Console.WriteLine("( \\      (  ____ \\|\\     /|(  ____ \\( \\  ");
                            Console.SetCursorPosition(19, 14);
                            Console.WriteLine("| (      | (    \\/| )   ( || (    \\/| ( ");
                            Console.SetCursorPosition(19, 15);
                            Console.WriteLine("| |      | (__    | |   | || (__    | |  ");
                            Console.SetCursorPosition(19, 16);
                            Console.WriteLine("| |      |  __)   ( (   ) )|  __)   | |  ");
                            Console.SetCursorPosition(19, 17);
                            Console.WriteLine("| |      | (       \\ \\_/ / | (      | |   ");
                            Console.SetCursorPosition(19, 18);
                            Console.WriteLine("| (____/\\| (____/\\  \\   /  | (____/\\| (____/\\");
                            Console.SetCursorPosition(19, 19);
                            Console.WriteLine("(_______/(_______/   \\_/   (_______/(_______/");

                            Console.SetCursorPosition(10, 23);
                            for (int i = 0; i < 55; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.Write("*");
                                if (i == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }

                            Console.SetCursorPosition(10, 23);
                            for (int i = 0; i < 55; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Thread.Sleep(20);
                                Console.Write("*");
                                if (i == 54)
                                {
                                    Console.SetCursorPosition(65, 22);
                                    Console.Write("***");
                                    Console.SetCursorPosition(65, 23);
                                    Console.Write("****  ");
                                    Console.SetCursorPosition(65, 24);
                                    Console.Write("***");
                                }
                            }
                            Thread.Sleep(40);

                        }
                        firstgameboard();
                        break;


                    }
                }

            }
        }

        static void Main(string[] args)
        {
            SoundPlayer robocop = new SoundPlayer();
            robocop.SoundLocation = "sounds\\robocop.wav";
            robocop.Play();
            Console.CursorVisible = false;
            Console.SetWindowSize(120, 30); // set console size
            Console.Title = "Letter Hunt - Dokuz Eylul University - Department of Computer Engineering";
            start();
            firstscreen();
            Console.ReadLine();


        }
    }
}








