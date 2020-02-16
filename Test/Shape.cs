using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IShape
    {
        // Метод для рисования
        void Draw();
        // Метод для вычесления площади
        int[] getSide();
        // Метод для задания цвета
        Color getColor();

        String ToString();
    }
}
