using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    public class Window : IDopElements
    {
        private EnumElements enumElements;
        public int Number { set => enumElements = (EnumElements)value; }

        public void DrawElements(Graphics g, float _startPosX, float _startPosY)
        {
            Brush brWhite = new SolidBrush(Color.White);
            switch (enumElements)
            {               
                case EnumElements.One:
                    for (int i = 0; i < 9; ++i)
                    {
                        g.FillEllipse(brWhite, _startPosX + 45 + (15 * i), _startPosY + 20, 10, 8);
                    }
                    break;

                case EnumElements.Two:
                    for (int i = 0; i < 9; ++i)
                    {
                        g.FillRectangle(brWhite, _startPosX + 45 + (15 * i), _startPosY + 20, 10, 8);
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
