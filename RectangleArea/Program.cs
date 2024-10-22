using System;
using System.IO;
using System.Linq;

var points = Console.ReadLine().Split(" ").Select(p => double.Parse(p)).ToList();

var xDist = Math.Abs(points[0] - points[2]);
var yDist = Math.Abs(points[1] - points[3]);
var area = xDist * yDist;

Console.WriteLine(Math.Round(area, 3));