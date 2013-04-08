using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        //Leaving a trail
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> trailList = new List<GameObject>();
            trailList.Add(new TrailObject(this.topLeft, 3));
            return trailList;
        }
    }
}
