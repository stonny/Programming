using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Explosion : MovingObject
    {
         private int lifeTime;

        public new const string CollisionGroupString = "trail";

        public Explosion(MatrixCoords topLeft, int lifeTime)
            : base(topLeft,new char[,]{{'*'}},new MatrixCoords(0,0))
        {
            this.lifeTime = lifeTime;
            if (this.lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }

        public override void Update()
        {
            this.lifeTime--;
            if (this.lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }

        public override string GetCollisionGroupString()
        {
            return Block.CollisionGroupString;
        }
    }
}
