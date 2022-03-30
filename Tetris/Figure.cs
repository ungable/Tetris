using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Figure
    {
        protected Point[] points = new Point[4];
        /// <summary>
        /// Отрисовывает фигуру
        /// </summary>
        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        /// <summary>
        /// Движение фигуры
        /// </summary>
        /// <param name="dir">Перечисление</param>
        public void Move(Direction dir)
        {
            foreach(Point p in points)
            {
                p.Move(dir);
            }
        }

        public void Hide()
        {
            foreach(Point p in points)
            {
                p.Hide();
            }
        }
    }
}
