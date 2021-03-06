﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Tank
{
    public class TankGame
    {
        public Pen pen = new Pen(Color.Black);
        public Point location,lright,lleft,lup,ldown,location2;
        public int length = 40;
        public Point center,center2;
        public int x, y;
        SolidBrush brushblack = new SolidBrush(Color.Blue);
        SolidBrush brushred = new SolidBrush(Color.Red);
        public void MoveUp(Graphics g)
        {
            g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
            g.FillRectangle(brushblack, location.X + 40, location.Y + 10, length / 2, length);
        }
        public void MoveDown(Graphics g)
        {
            g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
            g.FillRectangle(brushblack, location.X + 40, location.Y + 50, length / 2, length);
        }
        public void MoveRight(Graphics g)
        {
            g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
            g.FillRectangle(brushblack, location.X + 50, location.Y + 40, length, length / 2);
        }
        public void MoveLeft(Graphics g)
        {
            g.FillRectangle(brushblack, location.X + 30, location.Y + 30, length, length);
            g.FillRectangle(brushblack, location.X + 10, location.Y + 40, length, length / 2);
        }
        public void Center()
        {
            center.X = location.X + 40;
            center.Y = location.Y + 40;
        }





        public void MoveUp2(Graphics g)
        {
            g.FillRectangle(brushred, location2.X + 30, location2.Y + 30, length, length);
            g.FillRectangle(brushred, location2.X + 40, location2.Y + 10, length / 2, length);
        }
        public void MoveDown2(Graphics g)
        {
            g.FillRectangle(brushred, location2.X + 30, location2.Y + 30, length, length);
            g.FillRectangle(brushred, location2.X + 40, location2.Y + 50, length / 2, length);
        }
        public void MoveRight2(Graphics g)
        {
            g.FillRectangle(brushred, location2.X + 30, location2.Y + 30, length, length);
            g.FillRectangle(brushred, location2.X + 50, location2.Y + 40, length, length / 2);
        }
        public void MoveLeft2(Graphics g)
        {
            g.FillRectangle(brushred, location2.X + 30, location2.Y + 30, length, length);
            g.FillRectangle(brushred, location2.X + 10, location2.Y + 40, length, length / 2);
        }
        public void Center2()
        {
            center2.X = location2.X + 40;
            center2.Y = location2.Y + 40;
        }
    }
}
