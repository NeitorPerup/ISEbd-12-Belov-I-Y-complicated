using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    class RectangleGunForm : IDopElements
    {
        private EnumElements enumElements;

        public int Number { set => enumElements = (EnumElements)value;}

        public Color DopColor { private set; get; }

        public RectangleGunForm(int gun, Color dopColor)
        {
            Number = gun;
            DopColor = dopColor;
        }

        public void DrawElements(Graphics g, float _startPosX, float _startPosY)
        {
            switch (enumElements)
            {
                case EnumElements.Two:
                    DrawTwoGuns(g, _startPosX, _startPosY);
                    break;

                case EnumElements.Four:
                    DrawFourGuns(g, _startPosX, _startPosY);
                    break;

                case EnumElements.Six:
                    DrawSixGuns(g, _startPosX, _startPosY);
                    break;
            }
        }

        private void DrawTwoGuns(Graphics g, float _startPosX, float _startPosY)
        {
            Brush brDopColor = new SolidBrush(DopColor);

            g.FillRectangle(brDopColor, _startPosX + 185, _startPosY - 7, 20, 12);
            g.FillRectangle(brDopColor, _startPosX + 195, _startPosY - 4, 20, 4);

            g.FillRectangle(brDopColor, _startPosX + 25, _startPosY - 7, 20, 12);
            g.FillRectangle(brDopColor, _startPosX + 9, _startPosY - 4, 20, 4);
        }

        private void DrawFourGuns(Graphics g, float _startPosX, float _startPosY)
        {
            DrawTwoGuns(g, _startPosX, _startPosY);
            Brush brDopColor = new SolidBrush(DopColor);
            g.FillRectangle(brDopColor, _startPosX + 160, _startPosY - 15, 20, 20);
            g.FillRectangle(brDopColor, _startPosX + 170, _startPosY - 12, 27, 3);

            g.FillRectangle(brDopColor, _startPosX + 48, _startPosY - 15, 20, 20);
            g.FillRectangle(brDopColor, _startPosX + 29, _startPosY - 12, 24, 3);
        }

        private void DrawSixGuns(Graphics g, float _startPosX, float _startPosY)
        {
            DrawFourGuns(g, _startPosX, _startPosY);
            Brush brDopColor = new SolidBrush(DopColor);
            PointF[] cannon1Points = { new PointF(_startPosX + 182, _startPosY + 28), new PointF(_startPosX + 190, _startPosY + 15),
                                           new PointF(_startPosX + 198, _startPosY + 28) };
            g.FillPolygon(brDopColor, cannon1Points);
            g.FillRectangle(brDopColor, _startPosX + 195, _startPosY + 20, 23, 5);

            PointF[] cannon2Points = { new PointF(_startPosX + 23, _startPosY + 28), new PointF(_startPosX + 30, _startPosY + 15),
                                           new PointF(_startPosX + 38, _startPosY + 28) };
            g.FillPolygon(brDopColor, cannon2Points);
            g.FillRectangle(brDopColor, _startPosX + 2, _startPosY + 20, 25, 5);
        }
    }
}
