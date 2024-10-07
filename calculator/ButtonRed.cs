using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public class ButtonRed : Control
    {
        public bool AllowTransparency = true;
        private StringFormat SF = new StringFormat();
        private bool MouseEntered = false;

        public ButtonRed()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor | 
                     ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);
            BackColor = Color.Maroon;
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.Transparent)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.Transparent)), rect);
            }

            AdjustFontSize(graph);

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }

        private void AdjustFontSize(Graphics graph)
        {

            float fontSize = Height * 0.3f;
            Font font = new Font(Font.FontFamily, fontSize, Font.Style);

            SizeF textSize = graph.MeasureString(Text, font);

            while ((textSize.Width > Width || textSize.Height > Height) && fontSize > 1)
            {
                fontSize -= 0.5f;
                font = new Font(Font.FontFamily, fontSize, Font.Style);
                textSize = graph.MeasureString(Text, font);
            }

            Font = font;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }
    }
}
