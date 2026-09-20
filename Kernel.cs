using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Sys = Cosmos.System;

namespace Cosmoscircle
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            graf.starts();
        }

        protected override void Run()
        {
            while (true)
            {
                lines.Main();
                var input = Console.ReadLine();


            }


        }
    }
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;


        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            Sys.MouseManager.ScreenHeight = (uint)(470);
            Sys.MouseManager.ScreenWidth = (uint)(630);






        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }






    class tests



    {


        public static void mainLoop()
        {
            //


            graf.cls(Color.White);
            for (int i = 0; i < 50; i++)
            {
                Pen p = new Pen(Color.FromArgb(255, i*4, i*4,i*4),3);
                graf.canvas.DrawCircle(p, 640 /2,480/2,i);
                graf.canvas.DrawCircle(p, 640 / 2 + 1, 480 / 2 + 1, i);
                graf.canvas.DrawCircle(p, 640 / 2+2, 480 / 2+2, i);
                graf.canvas.DrawCircle(p, 640 / 2 - 1, 480 / 2 - 1, i);
                graf.canvas.DrawCircle(p, 640 / 2  , 480 / 2 + 1, i);
                graf.canvas.DrawCircle(p, 640 / 2+1, 480 / 2 , i);
            }
            //graf.canvas.DrawLine(p, 0,480/2,639,480/2);
            //graf.canvas.DrawLine(p,640 / 2,0, 640 / 2,479);

            graf.displays();
        }



    }



    class lines
    {

        public static void Main()
        {
            tests.mainLoop();



        }



    }


}
