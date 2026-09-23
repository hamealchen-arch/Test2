// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("First Program");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(55); //darkish grey

            



            Draw.SetLineSize(0);
            Draw.SetFillColor(33, 33, 177); //blue
            Draw.Square(120, 120, 160); //middel blue part of mock-hamilton flag


            Draw.SetFillColor(229, 199, 55); //yellow
            Draw.Rectangle(40, 120, 80, 160); //left yellow part of mock-hamilton flag
            Draw.Rectangle(280, 120, 80, 160); //right yellow part of mock-hamilton flag


            Draw.SetLineSize(5);
            Draw.SetLineColor(229, 199, 55); //yellow line
            Draw.SetFillColor(33, 33, 177); //blue
            Draw.Polygon(200, 200, 60, 6, 90, PolygoneMode.InsideRadius); //draws hexagon


            Draw.SetFillColor(229, 199, 55); //yellow
            Draw.SetLineSize(1);
            Draw.Circle(200, 200, 30); //draws circle




            //Draw.SetLineSize(5);
            //Draw.PolyLine([200, 140], [140, 200]);
            //Draw.PolyLine(int[x], int[y]);
            //Draw.shape(positions, sizes);







        }
    }

}
