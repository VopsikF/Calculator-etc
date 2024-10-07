using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace calculator
{
    public class Button2 : Control
    {
        private StringFormat SF = new StringFormat();
        private bool MouseEntered = false;

        public Button2()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);
            BackColor = Color.Transparent;
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            AdjustFontSize(graph);

            if (Parent is Background parentBackground)
            {
                Point buttonPositionInParent = Parent.PointToClient(this.PointToScreen(Point.Empty));

                Rectangle gradientRect = new Rectangle(
                    -buttonPositionInParent.X,
                    -buttonPositionInParent.Y,
                    Parent.Width,
                    Parent.Height
                );

                using (LinearGradientBrush lgb = new LinearGradientBrush(gradientRect, parentBackground.ColorTop, parentBackground.ColorBottom, LinearGradientMode.Vertical))
                {
                    graph.FillRectangle(lgb, new Rectangle(0, 0, Width, Height));
                }
            }
            else
            {
                graph.Clear(Color.Transparent);
            }

            Rectangle buttonRect = new Rectangle(0, 0, Width - 1, Height - 1);
            Color semiTransparent = Color.FromArgb(100, Color.Black);
            graph.FillRectangle(new SolidBrush(semiTransparent), buttonRect);

            if (MouseEntered)
            {
                Color hoverColor = Color.FromArgb(30, Color.AliceBlue);
                graph.FillRectangle(new SolidBrush(hoverColor), buttonRect);
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), buttonRect, SF);
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