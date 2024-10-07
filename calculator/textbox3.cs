using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace calculator
{
    public class TextBox3 : Control
    {
        private StringFormat SF = new StringFormat();
        private bool MouseEntered = false;
        private bool FocusedTextbox = false;

        private string inputText = "";  
        private Font textFont;

        public void Clear()
        {
            this.TextBoxText = string.Empty; 
        }
        public TextBox3()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(200, 30);
            BackColor = Color.Transparent;  
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Far;
            SF.LineAlignment = StringAlignment.Center;

            textFont = new Font(FontFamily.GenericSansSerif, 12);  // Default font
            this.SetStyle(ControlStyles.Selectable, true);  // Allow focus
            this.TabStop = true;  
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Check only for Backspace
            if (e.KeyCode == Keys.Back && inputText.Length > 0)
            {
                inputText = inputText.Substring(0, inputText.Length - 1);
                Invalidate(); 
            }

            e.Handled = true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Allow digits, 'x', 'b' and Backspace to be entered
            if (char.IsDigit(e.KeyChar) ||  e.KeyChar == 'x' || e.KeyChar == 'b' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back && inputText.Length > 0)
                {
                    inputText = inputText.Substring(0, inputText.Length - 1); 
                }
                else
                {
                    inputText += e.KeyChar;
                }
                Invalidate();  
            }

            e.Handled = true;  
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            AdjustFontSize(graph);

            // Clear background - transparent
            Rectangle textboxRect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Draw a semi-transparent background if necessary
            if (Parent is Background parentBackground)
            {
                Point textboxPositionInParent = Parent.PointToClient(this.PointToScreen(Point.Empty));

                Rectangle gradientRect = new Rectangle(
                    -textboxPositionInParent.X,
                    -textboxPositionInParent.Y,
                    Parent.Width,
                    Parent.Height
                );

                using (LinearGradientBrush lgb = new LinearGradientBrush(gradientRect, parentBackground.ColorTop, parentBackground.ColorBottom, LinearGradientMode.Vertical))
                {
                    graph.FillRectangle(lgb, textboxRect);
                }
            }
            else
            {
                graph.Clear(Color.Transparent); 
            }

            // Draw the border of the input field
            if (MouseEntered)
            {
                Color hoverColor = Color.FromArgb(30, Color.AliceBlue);
                graph.FillRectangle(new SolidBrush(hoverColor), textboxRect);
            }

            if (FocusedTextbox)
            {
                graph.DrawRectangle(new Pen(Color.AliceBlue, 2), textboxRect);  // Thick border at focus
            }
            else
            {
                graph.DrawRectangle(new Pen(Color.Black, 1), textboxRect);  // Normal boundary
            }

            // Drawing text
            graph.DrawString(inputText, textFont, new SolidBrush(ForeColor), new RectangleF(5, 5, Width - 10, Height - 10), SF);
        }

        private void AdjustFontSize(Graphics graph)
        {
            float fontSize = Height * 0.5f;
            textFont = new Font(Font.FontFamily, fontSize, Font.Style);
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

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            FocusedTextbox = true;
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            FocusedTextbox = false;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            this.Focus();  
        }

        public void AddSymbol(char symbol)
        {
            inputText += symbol;
            Invalidate();  
        }
 
        public string TextBoxText
        {
            get { return inputText; }
            set { inputText = value; Invalidate(); }
        }
    }
}
