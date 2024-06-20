using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace gui // Przykładowa przestrzeń nazw
{
    public class RoundedComboBox : ComboBox
    {
        private int borderWidth = 2; // Grubość ramki
        private Color borderColor = Color.LightGray; // Kolor ramki

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Rysowanie tła
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);

            // Rysowanie ramki zaokrąglonej
            GraphicsPath path = new GraphicsPath();
            int radius = 10; // Promień zaokrąglenia rogów
            int width = this.Width;
            int height = this.Height;

            // Lewy górny róg
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddLine(radius, 0, width - radius, 0);

            // Górna krawędź
            path.AddArc(width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddLine(width, radius, width, height - radius);

            // Prawy dolny róg
            path.AddArc(width - radius * 2, height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(width - radius, height, radius, height);

            // Dolna krawędź
            path.AddArc(0, height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(0, height - radius, 0, radius);

            path.CloseFigure();

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
            e.Graphics.DrawPath(new Pen(borderColor, borderWidth), path);

            // Rysowanie strzałki ComboBoxa
            int arrowX = width - 20;
            int arrowY = height / 2 - 2;
            e.Graphics.FillPolygon(new SolidBrush(this.ForeColor),
                new Point[] { new Point(arrowX, arrowY), new Point(arrowX + 10, arrowY), new Point(arrowX + 5, arrowY + 5) });
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            this.Invalidate(); // Odświeża kontrolkę po rozwinięciu ComboBoxa
        }
    }
}
