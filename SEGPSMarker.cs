using System.Numerics;

namespace SpaceEngineersCoordinator
{
    public class SEGPSMarker
    {
        public string Name {get;set;} = "PlaceHolder";
        public Vector3 Point {get;set;} = new Vector3();
        public string Color {get;set;} = "#FFFFFF";

        public SEGPSMarker(string GPSString){
            string[] parts = GPSString.Split(":");

            Name = parts[1];

            float X = float.Parse(parts[2]);
            float Y = float.Parse(parts[3]);
            float Z = float.Parse(parts[4]);
            Point = new Vector3(X,Y,Z);

            Color = parts[5];
        }

        public SEGPSMarker(string name, Vector3 point, string color){
            Name = name;
            Point = point;
            Color = color;
        }

        public override string ToString(){
            return $"GPS:{Name}:{Point.X}:{Point.Y}:{Point.Z}:{Color}:";
        }
    }
}