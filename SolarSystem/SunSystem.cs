using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem
{
    class SunSystem
    {
        List<SpaceObject> myObjects = new List<SpaceObject>();
        Star sun;

        public SunSystem()
        {
            sun = new Star(200, 250, 0, 0, 2000, 50, objColors.blue);
            myObjects.Add(sun);
            myObjects.Add(new Planet(200,300,-0.1f,-0.1f,7,7,objColors.red));
            myObjects.Add(new Planet(200,100, 0.1f, 0.1f, 10,12, objColors.green));
            myObjects.Add(new Planet(200,50, 0.11f, 0.11f,0.1f,2,objColors.blue));
        }

        public void processTime()
        {
            foreach (SpaceObject so in myObjects)
            {
                foreach (SpaceObject sa in myObjects)
                {
                    if (sa == so) continue;
                    /*
                    float d = sqrt((so.x - sa.x) * (so.x - sa.x) + (so.y - sa.y) * (so.y - sa.y));
                    if (d > 3)
                    {
                        so.vx += 0.0007 * sa.m / d / d * (sa.x - so.x) / d;
                        so.vy += 0.0007 * sa.m / d / d * (sa.y - so.y) / d;
                    }*/
                    float d = (float)Math.Sqrt((so.x - sa.x) * (so.x - sa.x) + (so.y - sa.y) * (so.y - sa.y));
                    if (d > 3)
                    {
                        so.vx += (float) 0.0007 * sa.M / d / d * (sa.x - so.x) / d;
                        so.vy += (float) 0.0007 * sa.M / d / d * (sa.y - so.y) / d;
                    }
                }
                so.Move();
            }
        }

        public void Draw(Graphics ge)
        {
            foreach (SpaceObject so in myObjects)
            {
                so.Draw(ge);
            }
        }
    }
}