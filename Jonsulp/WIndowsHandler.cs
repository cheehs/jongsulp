using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Jonsulp
{
    class WindowsHandler
    {
        [DllImport("user32", CallingConvention = CallingConvention.StdCall)]
        public static extern long SetCursorPos(int x, int y);
    }
}
