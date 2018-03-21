using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystem
{
    class SpaceObject
    {
        private float posX;
        public float x { get { return posX; } }
        private float posY;
        public float y { get { return posY; } }
        private float vX;
        public float vx { get { return vX; } set { vX = value; } }
        private float vY;
        public float vy { get { return vY; } set { vY = value; } }
        private float m;
        public float M { get { return m; } }
        private float rad;
        private objColors myColor;

        public void Move()
        {
            posX += vx;
            posY += vy;
        }

        public SpaceObject(float posX, float posY, float vX, float vY, float m, float rad, objColors myColor)
        {
            this.posX = posX;
            this.posY = posY;
            this.vX = vX;
            this.vY = vY;
            this.m = m;
            this.rad = rad;
            this.myColor = myColor;
        }

        public void Draw(Graphics ge)
        {
            Pen specPen = Pens.Black;
            SolidBrush myBrush = new SolidBrush(Color.Black);
            switch (myColor)
            {
                case objColors.blue: myBrush.Color = Color.Blue; break;
                case objColors.green: myBrush.Color = Color.Green; break;
                case objColors.purple: myBrush.Color = Color.Purple; break;
                case objColors.red: myBrush.Color = Color.Red; break;
                case objColors.yellow: myBrush.Color = Color.Yellow; break;
                default: myBrush = new SolidBrush(Color.White); break;
            }
            ge.FillEllipse(myBrush, posX - rad / 2, posY - rad / 2, rad, rad);
            ge.DrawEllipse(specPen, posX - rad / 2, posY - rad / 2, rad, rad);
        }
    }
    public enum objColors { red,green,blue,purple,yellow, }

}
 