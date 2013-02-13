using System;

class ShipDamage
{
    static int shipDmg(int shipX1, int shipY1, int shipX2, int shipY2, int catX, int catY,int H)
    {
        int sum = 0;
        int mirrorY = 2 * H - catY;
        int minX = Math.Min(shipX1, shipX2);
        int maxX = Math.Max(shipX1, shipX2);
        int minY = Math.Min(shipY1, shipY2);
        int maxY = Math.Max(shipY1, shipY2);

        if ((catX == minX || catX == maxX) && (mirrorY == minY || mirrorY == maxY))
        {
            sum += 25; // Hit in the corner
        }
        if (((catX == minX || catX == maxX) && (mirrorY > minY && mirrorY < maxY)) ||
            ((mirrorY == minY || mirrorY == maxY) && (catX > minX && catX < maxX)))
        {

            sum += 50; // Hit in the border
        }

         if ((catX > minX) && (catX < maxX) && (mirrorY > minY) && (mirrorY < maxY))
        {
            sum += 100; // Hit in the internal body
        }

        return sum;
    }
    static void Main()
    {
        int sum = 0;
        int shipX1 = int.Parse(Console.ReadLine());
        int shipY1 = int.Parse(Console.ReadLine());
        int shipX2 = int.Parse(Console.ReadLine());
        int shipY2 = int.Parse(Console.ReadLine());
        int horizont = int.Parse(Console.ReadLine());
        int catapultX1 = int.Parse(Console.ReadLine());
        int catapultY1 = int.Parse(Console.ReadLine());   
        int catapultX2 = int.Parse(Console.ReadLine());
        int catapultY2 = int.Parse(Console.ReadLine());
        int catapultX3 = int.Parse(Console.ReadLine());
        int catapultY3 = int.Parse(Console.ReadLine());

        sum = sum + shipDmg(shipX1, shipY1, shipX2, shipY2, catapultX1, catapultY1, horizont);
        sum = sum + shipDmg(shipX1, shipY1, shipX2, shipY2, catapultX2, catapultY2, horizont);
        sum = sum + shipDmg(shipX1, shipY1, shipX2, shipY2, catapultX3, catapultY3, horizont);
        Console.WriteLine("{0}%",sum);
    }
}

