﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            start.InitialScreen();
            Console.ReadKey(true);
        }
    }
}