using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Supervisor
{
    public class ModernButton : Button
    {
        public Color StartColor { get; set; } = Color.FromArgb(0, 153, 255);
        public Color EndColor { get; set; } = Color.FromArgb(0, 102, 204);
        public int BorderRadius { get; set; } = 20;

        private bool isHovered = false;
        private bool isPressed = false;

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            // Events pour hover / clic
            MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
            MouseLeave += (s, e) => { isHovered = false; isPressed = false; Invalidate(); };
            MouseDown += (s, e) => { isPressed = true; Invalidate(); };
            MouseUp += (s, e) => { isPressed = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = ClientRectangle;

            // Couleurs dynamiques selon l'état
            Color c1 = StartColor;
            Color c2 = EndColor;

            if (isPressed)
            {
                c1 = Darken(StartColor, 0.15f);
                c2 = Darken(EndColor, 0.15f);
            }
            else if (isHovered)
            {
                c1 = Lighten(StartColor, 0.15f);
                c2 = Lighten(EndColor, 0.15f);
            }

            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, c1, c2, 90f))
            {
                e.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rect,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        private Color Lighten(Color c, float amount)
        {
            int r = Math.Min(255, (int)(c.R + 255 * amount));
            int g = Math.Min(255, (int)(c.G + 255 * amount));
            int b = Math.Min(255, (int)(c.B + 255 * amount));
            return Color.FromArgb(r, g, b);
        }

        private Color Darken(Color c, float amount)
        {
            int r = Math.Max(0, (int)(c.R - 255 * amount));
            int g = Math.Max(0, (int)(c.G - 255 * amount));
            int b = Math.Max(0, (int)(c.B - 255 * amount));
            return Color.FromArgb(r, g, b);
        }
    }
}
