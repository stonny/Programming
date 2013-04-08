using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Shooter : Engine
    {
        public Shooter (IRenderer renderer, IUserInterface userInterface, int sleepTime) : base(renderer,userInterface,sleepTime)
        {
        }
    }
}
