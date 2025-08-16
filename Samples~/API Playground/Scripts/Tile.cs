﻿using CasKev.GridToolkit;

namespace GridToolkitWorkingProject.Demos.APIPlayground
{
    public class Tile : ITile
    {

        public int X { get; set; }
        public int Y { get; set; }
        public bool IsWalkable { get; set; }
        public float Weight { get; set; }

        public Tile(int x, int y, bool isWalkable = true, float weight = 1f)
        {
            IsWalkable = isWalkable;
            X = x;
            Y = y;
            Weight = weight;
        }
    }
}