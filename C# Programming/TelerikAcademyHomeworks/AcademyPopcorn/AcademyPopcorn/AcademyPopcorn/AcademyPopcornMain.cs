using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            //Add exploding blocks
            for (int i = startCol; i < endCol; i+=3)
            {
                Block currBlock = new ExplodingBlock(new MatrixCoords(startRow + 1, i));

                engine.AddObject(currBlock);
            }

            //Add unstopable ball
            Ball theBall = new UnstopableBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            //Add a meteorit ball
            Ball meteor = new MeteoriteBall(new MatrixCoords(WorldRows / 2, WorldCols - 1), new MatrixCoords(-1, -1));

            engine.AddObject(meteor);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);


            //Creating side and ceiling walls
            for (int i = 0; i < WorldCols; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(0, i)));
            }

            for (int row = 1; row < WorldRows; row++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, 0)));
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1)));
            }

            //Add set of unpassable blocks
            for (int i = 1; i < WorldCols - 1; i++)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(1, i)));
            }

            //Add a gift
            engine.AddObject(new Gift(new MatrixCoords(5, 20)));

            //Add gift blocks
            for (int i = startCol; i < endCol; i += 6)
            {
                Block currBlock = new GiftBlock(new MatrixCoords(startRow + 2, i));

                engine.AddObject(currBlock);
            }
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard,100);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
