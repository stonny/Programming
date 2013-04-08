using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnstopableBall : Ball
    {
        public UnstopableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "unpassable block";
        }

        //Responds to collision if only meets "unpassable block"
        public override void RespondToCollision(CollisionData collisionData)
        {
            foreach (string type in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (type == "unpassable block" || type == "racket")
                {
                    base.RespondToCollision(collisionData);
                }
                
            }
            
        }
    }
}
