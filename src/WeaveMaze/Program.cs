﻿using Mazes;
using Mazes.Algorithms;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace WeaveMaze
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var grid = new WeaveGrid(20, 20);
            new RecursiveBacktracker().On(grid);

            var image = await grid.ToImageAsync();
            image.Save("weave.png", ImageFormat.Png);
        }
    }
}
