using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWarships
{
    public class DockAlreadyHaveException : Exception
    {
        public DockAlreadyHaveException() : base("В доке уже есть такой корабль") { }
    }
}
