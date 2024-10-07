
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace calculator
{
    public class Background : Panel
    {
        public Background()
        {
            this.Dock = DockStyle.Fill;
        }
        public Color ColorBottom { get; set; }
        public Color ColorTop { get; set; }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorBottom, this.ColorTop, LinearGradientMode.Vertical);


            Blend blend = new Blend();
            blend.Positions = new[] { 0.0f, 0.9f, 1.0f }; 
            blend.Factors = new[] { 1.0f, 0.7f, 0.8f };   

            lgb.Blend = blend;


            g.FillRectangle(lgb, this.ClientRectangle);

            base.OnPaint(e);
        }

    }
}
