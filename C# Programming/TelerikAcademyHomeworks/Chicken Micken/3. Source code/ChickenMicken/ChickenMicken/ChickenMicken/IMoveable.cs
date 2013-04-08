using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ChickenMicken
{
    /// <summary>
    /// This interface implements the Restriction of movement in the bounds of the Playing window
    /// </summary>
    public interface IMoveable
    {
        // Initializing the RestrictMovement method
        void RestrictMovement(GraphicsDeviceManager graphic);
    }
}
