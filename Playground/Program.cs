using Playground.BaseClasses;
using Playground.Enums;
using Playground.StaticClasses;
using System.Drawing;

int[] cisla = { 11, 2, 13, 44, -5, 6, 127, -99, 0, 256 };

var result = cisla.Where(x => x >= 0);
Console.WriteLine(result.Count());


