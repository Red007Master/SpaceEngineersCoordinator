using System;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;

namespace SpaceEngineersCoordinator;

class Program
{
    static void Main(string[] args)
    {
        string p1SouceString = "GPS:p1:137003.361518088:-95559.8874482321:-39270.2439633229:#FF75C9F1:";
        string p2SouceString = "GPS:p2:137016.231225439:-95569.9266256685:-39248.0593891441:#FF75C9F1:";

        SEGPSMarker p1 = new SEGPSMarker(p1SouceString);
        SEGPSMarker p2 = new SEGPSMarker(p2SouceString);
            
        Vector3 deviation = p2.Point - p1.Point;

        deviation = deviation * 10;

        SEGPSMarker p3 = new SEGPSMarker("p3", p1.Point + deviation, "#FF75C9F1");

        Console.WriteLine($"P3: {p3}");
    }
}
