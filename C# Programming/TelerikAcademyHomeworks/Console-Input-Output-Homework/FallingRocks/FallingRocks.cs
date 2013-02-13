
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

struct Rocks
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}

class Program
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void Main(string[] args)
    {
        PrintOnPosition(25, 1, "Falling Rocks Game", ConsoleColor.Yellow);
        PrintOnPosition(0, 2, "You are a Dwarf ->  (0)", ConsoleColor.Blue);
        PrintOnPosition(0, 3, "Move with the arrow keys  <-  -> ", ConsoleColor.White);
        PrintOnPosition(0, 4, "Objects You Must Avoid:", ConsoleColor.Red);
        PrintOnPosition(0, 5, "^, @, *, &, +, %, $, #, !, ., ;, ", ConsoleColor.Red);
        PrintOnPosition(0, 6, "You Have 5 lives available !", ConsoleColor.White);
        PrintOnPosition(0, 7, "Press [Enter] When you are ready to begin the game !", ConsoleColor.White);
        Console.ReadLine();
        int playfieldWidth = 81;
        int livesCount = 5;
        int score = 0;
        double speed = 500;
        bool hit = false;
        string[] rockSymbols = { "@", "#", "$", "%", "^", "&", "*", ";", ".","!" };
        Console.BufferHeight = Console.WindowHeight = 25;
        Console.BufferWidth = Console.WindowWidth = 80;
        Rocks Dwarf = new Rocks();
        Dwarf.x = 40;
        Dwarf.y = Console.WindowHeight - 1;
        Dwarf.c = "(0)";
        Dwarf.color = ConsoleColor.Blue;
        Random randomGenerator = new Random();
        List<Rocks> rocks = new List<Rocks>();
        while (true)
        {
            
            hit = false;
            {
                Rocks newRock = new Rocks();
                newRock.color = ConsoleColor.Green;
                newRock.x = randomGenerator.Next(0, playfieldWidth - 5);
                newRock.y = 2;
                newRock.c = rockSymbols[randomGenerator.Next(0,9)];
                rocks.Add(newRock);
            }
            


            // Move dwarf (key pressed) - solved
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (Dwarf.x - 1 >= 0)
                    {
                        Dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (Dwarf.x + 5 < playfieldWidth)
                    {
                        Dwarf.x++;

                    }
                }
            }
            List<Rocks> newList = new List<Rocks>();
            // Move rocks -solved
            for (int i = 0; i < rocks.Count; i++)
            {
                Rocks oldRock = rocks[i];
                Rocks newRock = new Rocks();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                // Collision-solved

                if ((newRock.y == Dwarf.y && newRock.x == Dwarf.x) ||( newRock.y  == Dwarf.y  && newRock.x  == Dwarf.x+1 ) || (newRock.y == Dwarf.y && newRock.x == Dwarf.x+2))
                {
                    livesCount--;
                    speed += 10;
                    hit = true;
                    Console.Beep();
                    if (speed > 550)
                    {
                        speed = 550;
                    }
                    
                    if (livesCount <= 0)
                    {
                        Console.Clear();
                        PrintOnPosition(35, 12, "GAME OVER!", ConsoleColor.Red);
                        PrintOnPosition(32, 13, "Press [Enter] To Exit!", ConsoleColor.Red);
                        PrintOnPosition(34, 14, "Your score:"+score, ConsoleColor.Yellow);
                        Console.ReadLine();
                        return;
                    }


                }
                else
                {
                    score += 5;
                   
                   
                  
                }

                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
           
            // Clear console -solved
            Console.Clear();
           
            // Redraw playfield -solved
           
            foreach (Rocks rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
            }
            if (hit)
            {
                rocks.Clear();
                PrintOnPosition(Dwarf.x, Dwarf.y, "(X)", ConsoleColor.Magenta);
            }
            // Draw Info -solved
            else
            {
                PrintOnPosition(Dwarf.x, Dwarf.y, Dwarf.c, Dwarf.color);
            }
            // Slow down program - solved
            PrintOnPosition(1, 1, "Lives: " + livesCount, ConsoleColor.White);
            PrintOnPosition(10, 1, "| Score: " + score, ConsoleColor.White);
                PrintOnPosition(26, 1, "| Speed: " + speed, ConsoleColor.White);
            PrintOnPosition(0, 2, "--------------------------------------------------------------------------------", ConsoleColor.Green);
            Thread.Sleep((int)(600-speed));
        }
    }
}


