using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;

namespace ChickenMicken
{
    interface ICollidiable
    {
        void CollisionPlayerAttacksToEnemy(ContentManager Content, List<PlayerAttack> spaceShipAttacks, List<Enemy> chickens, List<Explosion> explosions, Player spaceShip);

        void CollisionPlayerToEnemy(ContentManager Content, Player spaceShip, List<Enemy> chickens, List<Explosion> explosions);

        void CollisionEnemychickenAttacksToPlayer(ContentManager Content, Player spaceShip, List<EnemyAttack> chickenAttacks, List<Explosion> explosions);
    }

    interface CopyOfICollidiable
    {
        void CollisionPlayerAttacksToEnemy(ContentManager Content, List<PlayerAttack> spaceShipAttacks, List<Enemy> chickens, List<Explosion> explosions, Player spaceShip);

        void CollisionPlayerToEnemy(ContentManager Content, Player spaceShip, List<Enemy> chickens, List<Explosion> explosions);

        void CollisionEnemychickenAttacksToPlayer(ContentManager Content, Player spaceShip, List<EnemyAttack> chickenAttacks, List<Explosion> explosions);
    }
}
