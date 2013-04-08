using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Gift : MovingObject
    {
        public Gift(MatrixCoords topLeft):base(topLeft, new char[,]{{'G'}},new MatrixCoords(1,0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                for (int i = -1; i < 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        producedObjects.Add(new Explosion(new MatrixCoords(this.GetTopLeft().Row + i, this.GetTopLeft().Col + j), 3));
                    }
                }
            }

            return producedObjects;
        }
    }
}
