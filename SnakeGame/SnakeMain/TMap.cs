﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace SnakeMain
{
    public enum TMapPoint { EMPTY, FRUIT, WALL, SNAKE }
    public class TMap 
    {
        private TMapPoint[,] matrix;
        public const int MAX_WIDTH = 20, MAX_HEIGHT = 20;
        public int Width { get { return matrix.GetLength(1); } }
        public int Height { get { return matrix.GetLength(0); } }
        public TMapPoint this[int x, int y]
        {
            get { return matrix[y, x]; }
            set { matrix[y, x] = value; }
        }
        public TMapPoint this [TPoint p]
        {
            get { return matrix[p.Y, p.X]; }
            set { matrix[p.Y, p.X] = value; }
        }
        public TMap(TMapPoint [,] _map)
        {
            if (_map.GetLength(0) > MAX_HEIGHT || _map.GetLength(1) > MAX_WIDTH)
                throw new Exception("Размер карты больше максимального");
            matrix = _map;
        }
    }
}
