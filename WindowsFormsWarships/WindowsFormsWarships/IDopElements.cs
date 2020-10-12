using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    public interface IDopElements
    {
        int Number { set; }

        void DrawElements(Graphics g, float _startPosX, float _startPosY);
    }
}
