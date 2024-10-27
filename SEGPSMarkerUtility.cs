using System;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;

namespace SpaceEngineersCoordinator
{
    public class SEGPSMarkerUtility
    {
        public static float GetDistance(Vector3 a, Vector3 b)
        {
            return (float)(Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z)));
        }
    }
}