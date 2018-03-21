using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class displaySolarSystem : Panel
    {

        SunSystem mySystem = new SunSystem();

        public displaySolarSystem()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public displaySolarSystem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            mySystem.processTime();
            mySystem.Draw(e.Graphics);
        }
    }
}
