using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface Player
    {
        void Render();

        void Move(int x, int y);

        void Remove();

    }
}
