using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        private int lifeTime;

        public new const string CollisionGroupString = "trail";

        public TrailObject(MatrixCoords topLeft, int lifeTime)
            : base(topLeft, new char[,] { { '+' } })
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
            return false;
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
