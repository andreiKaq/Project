using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using WMPLib;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!!!!!!");
            Console.ForegroundColor = ConsoleColor.Green;
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "music.mp3";
            wplayer.controls.play();


            for (int i = 1000; i > 2; i -= 3)
            {
                Console.WriteLine(i + " - 7 = " + (i - 7));
                System.Threading.Thread.Sleep(50);
            }

            Console.WriteLine("Im Ghoul...");
            Console.ReadKey();
        }

    }
}
