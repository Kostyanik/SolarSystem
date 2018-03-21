using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Stellar: SpaceObject
    {
        private Planet belongedTo;

        public Stellar(float posX, float posY, float vX, float vY, float m, float rad, objColors myColor) : base(posX, posY, vX, vY, m, rad, myColor)
        {
        }
    }
}
