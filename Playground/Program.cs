using Playground.BaseClasses;
using Playground.Enums;
using Playground.StaticClasses;
using System.Drawing;

Auto auto = new Auto("ss59585", Color.Black, 56897.4, "Audi");

if (auto.IsAutoStolen)
    Console.WriteLine("Auto je kradené!");
else
    Console.WriteLine("Auto není kradené!");